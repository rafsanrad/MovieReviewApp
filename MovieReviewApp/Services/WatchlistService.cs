using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using MovieReviewApp.Models;

namespace MovieReviewApp.Services
{
    public class WatchlistService
    {
        private readonly DatabaseHelper db =
            new DatabaseHelper();


        // =====================================================
        // ADD TO WATCHLIST
        // =====================================================

        public bool AddToWatchlist(
            int userId,
            int movieId)
        {
            using (SqlConnection connection =
                   db.GetConnection())
            {
                connection.Open();

                // Check if already in watchlist

                string checkQuery = @"
                    SELECT COUNT(*)
                    FROM Watchlist
                    WHERE UserId = @UserId
                    AND MovieId = @MovieId";


                using (SqlCommand checkCommand =
                       new SqlCommand(
                           checkQuery,
                           connection))
                {
                    checkCommand.Parameters.AddWithValue(
                        "@UserId",
                        userId
                    );

                    checkCommand.Parameters.AddWithValue(
                        "@MovieId",
                        movieId
                    );


                    int count =
                        Convert.ToInt32(
                            checkCommand.ExecuteScalar()
                        );


                    if (count > 0)
                    {
                        return false;
                    }
                }


                // Insert into Watchlist

                string insertQuery = @"
                    INSERT INTO Watchlist
                    (
                        UserId,
                        MovieId
                    )
                    VALUES
                    (
                        @UserId,
                        @MovieId
                    )";


                using (SqlCommand insertCommand =
                       new SqlCommand(
                           insertQuery,
                           connection))
                {
                    insertCommand.Parameters.AddWithValue(
                        "@UserId",
                        userId
                    );

                    insertCommand.Parameters.AddWithValue(
                        "@MovieId",
                        movieId
                    );


                    insertCommand.ExecuteNonQuery();
                }


                return true;
            }
        }


        // =====================================================
        // GET WATCHLIST MOVIES
        // =====================================================

        public List<Movie> GetWatchlistMovies(
            int userId)
        {
            List<Movie> movies =
                new List<Movie>();


            using (SqlConnection connection =
                   db.GetConnection())
            {
                connection.Open();


                string query = @"
                    SELECT
                        M.MovieId,
                        M.Title,
                        M.Description,
                        M.ReleaseYear,
                        M.Genre,
                        M.Director,
                        M.PosterPath

                    FROM Watchlist W

                    INNER JOIN Movies M
                        ON W.MovieId = M.MovieId

                    WHERE W.UserId = @UserId

                    ORDER BY W.WatchlistId DESC";


                using (SqlCommand command =
                       new SqlCommand(
                           query,
                           connection))
                {
                    command.Parameters.AddWithValue(
                        "@UserId",
                        userId
                    );


                    using (SqlDataReader reader =
                           command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Movie movie =
                                new Movie();


                            movie.MovieId =
                                Convert.ToInt32(
                                    reader["MovieId"]
                                );


                            movie.Title =
                                reader["Title"].ToString();


                            movie.Description =
                                reader["Description"].ToString();


                            movie.ReleaseYear =
                                reader["ReleaseYear"] ==
                                DBNull.Value
                                ? 0
                                : Convert.ToInt32(
                                    reader["ReleaseYear"]
                                );


                            movie.Genre =
                                reader["Genre"].ToString();


                            movie.Director =
                                reader["Director"].ToString();


                            movie.PosterPath =
                                reader["PosterPath"].ToString();


                            movies.Add(movie);
                        }
                    }
                }
            }


            return movies;
        }


        // =====================================================
        // REMOVE FROM WATCHLIST
        // =====================================================

        public bool RemoveFromWatchlist(
            int userId,
            int movieId)
        {
            using (SqlConnection connection =
                   db.GetConnection())
            {
                connection.Open();


                string query = @"
                    DELETE FROM Watchlist

                    WHERE UserId = @UserId

                    AND MovieId = @MovieId";


                using (SqlCommand command =
                       new SqlCommand(
                           query,
                           connection))
                {
                    command.Parameters.AddWithValue(
                        "@UserId",
                        userId
                    );

                    command.Parameters.AddWithValue(
                        "@MovieId",
                        movieId
                    );


                    int rows =
                        command.ExecuteNonQuery();


                    return rows > 0;
                }
            }
        }
    }
}