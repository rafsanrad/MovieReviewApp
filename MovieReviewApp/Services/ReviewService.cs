using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using MovieReviewApp.Models;

namespace MovieReviewApp.Services
{
    public class ReviewService
    {
        // =====================================================
        // CONNECTION STRING
        // =====================================================

        private readonly string connectionString =
            @"Data Source=.\SQLEXPRESS;Initial Catalog=MovieReviewDB;Integrated Security=True;TrustServerCertificate=True;";


        // =====================================================
        // ADD REVIEW
        // =====================================================

        public bool AddReview(
            int userId,
            int movieId,
            int rating,
            string comment)
        {
            using (SqlConnection connection =
                new SqlConnection(connectionString))
            {
                connection.Open();

                string query = @"
                    INSERT INTO Reviews
                    (
                        UserId,
                        MovieId,
                        Rating,
                        ReviewText,
                        ReviewDate
                    )
                    VALUES
                    (
                        @UserId,
                        @MovieId,
                        @Rating,
                        @ReviewText,
                        GETDATE()
                    )";

                using (SqlCommand command =
                    new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue(
                        "@UserId",
                        userId
                    );

                    command.Parameters.AddWithValue(
                        "@MovieId",
                        movieId
                    );

                    command.Parameters.AddWithValue(
                        "@Rating",
                        rating
                    );

                    command.Parameters.AddWithValue(
                        "@ReviewText",
                        string.IsNullOrWhiteSpace(comment)
                            ? (object)DBNull.Value
                            : comment
                    );

                    return command.ExecuteNonQuery() > 0;
                }
            }
        }


        // =====================================================
        // GET REVIEWS FOR A MOVIE
        // =====================================================

        public List<Review> GetReviewsByMovie(
            int movieId)
        {
            List<Review> reviews =
                new List<Review>();

            using (SqlConnection connection =
                new SqlConnection(connectionString))
            {
                connection.Open();

                string query = @"
                    SELECT
                        r.ReviewId,
                        r.UserId,
                        r.MovieId,
                        r.Rating,
                        r.ReviewText,
                        r.ReviewDate,
                        u.Name
                    FROM Reviews r
                    INNER JOIN Users u
                        ON r.UserId = u.UserId
                    WHERE r.MovieId = @MovieId
                    ORDER BY r.ReviewDate DESC";

                using (SqlCommand command =
                    new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue(
                        "@MovieId",
                        movieId
                    );

                    using (SqlDataReader reader =
                        command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Review review =
                                new Review();

                            review.ReviewId =
                                Convert.ToInt32(
                                    reader["ReviewId"]
                                );

                            review.UserId =
                                Convert.ToInt32(
                                    reader["UserId"]
                                );

                            review.MovieId =
                                Convert.ToInt32(
                                    reader["MovieId"]
                                );

                            review.Rating =
                                Convert.ToInt32(
                                    reader["Rating"]
                                );

                            // Database column = ReviewText
                            // C# property = Comment
                            review.Comment =
                                reader["ReviewText"] == DBNull.Value
                                    ? ""
                                    : reader["ReviewText"].ToString();

                            review.ReviewDate =
                                Convert.ToDateTime(
                                    reader["ReviewDate"]
                                );

                            review.UserName =
                                reader["Name"].ToString();

                            reviews.Add(review);
                        }
                    }
                }
            }

            return reviews;
        }


        // =====================================================
        // GET AVERAGE RATING
        // =====================================================

        public double GetAverageRating(
            int movieId)
        {
            using (SqlConnection connection =
                new SqlConnection(connectionString))
            {
                connection.Open();

                string query = @"
                    SELECT AVG(CAST(Rating AS FLOAT))
                    FROM Reviews
                    WHERE MovieId = @MovieId";

                using (SqlCommand command =
                    new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue(
                        "@MovieId",
                        movieId
                    );

                    object result =
                        command.ExecuteScalar();

                    if (result == null ||
                        result == DBNull.Value)
                    {
                        return 0;
                    }

                    return Convert.ToDouble(result);
                }
            }
        }


        // =====================================================
        // GET REVIEW COUNT
        // =====================================================

        public int GetReviewCount(
            int movieId)
        {
            using (SqlConnection connection =
                new SqlConnection(connectionString))
            {
                connection.Open();

                string query = @"
                    SELECT COUNT(*)
                    FROM Reviews
                    WHERE MovieId = @MovieId";

                using (SqlCommand command =
                    new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue(
                        "@MovieId",
                        movieId
                    );

                    return Convert.ToInt32(
                        command.ExecuteScalar()
                    );
                }
            }
        }


        // =====================================================
        // UPDATE REVIEW
        // =====================================================

        public bool UpdateReview(
            int reviewId,
            int userId,
            int rating,
            string comment)
        {
            using (SqlConnection connection =
                new SqlConnection(connectionString))
            {
                connection.Open();

                string query = @"
                    UPDATE Reviews
                    SET
                        Rating = @Rating,
                        ReviewText = @ReviewText
                    WHERE ReviewId = @ReviewId
                    AND UserId = @UserId";

                using (SqlCommand command =
                    new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue(
                        "@Rating",
                        rating
                    );

                    command.Parameters.AddWithValue(
                        "@ReviewText",
                        string.IsNullOrWhiteSpace(comment)
                            ? (object)DBNull.Value
                            : comment
                    );

                    command.Parameters.AddWithValue(
                        "@ReviewId",
                        reviewId
                    );

                    command.Parameters.AddWithValue(
                        "@UserId",
                        userId
                    );

                    return command.ExecuteNonQuery() > 0;
                }
            }
        }


        // =====================================================
        // DELETE REVIEW
        // =====================================================

        public bool DeleteReview(
            int reviewId,
            int userId)
        {
            using (SqlConnection connection =
                new SqlConnection(connectionString))
            {
                connection.Open();

                string query = @"
                    DELETE FROM Reviews
                    WHERE ReviewId = @ReviewId
                    AND UserId = @UserId";

                using (SqlCommand command =
                    new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue(
                        "@ReviewId",
                        reviewId
                    );

                    command.Parameters.AddWithValue(
                        "@UserId",
                        userId
                    );

                    return command.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}