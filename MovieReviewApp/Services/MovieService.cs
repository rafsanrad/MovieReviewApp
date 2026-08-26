using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using MovieReviewApp.Models;

namespace MovieReviewApp.Services
{
    public class MovieService
    {
        private readonly DatabaseHelper db =
            new DatabaseHelper();

        // =====================================================
        // GET ALL MOVIES
        // =====================================================

        public List<Movie> GetAll()
        {
            List<Movie> movies =
                new List<Movie>();

            using (SqlConnection connection =
                   db.GetConnection())
            {
                string query = @"
                    SELECT MovieId,
                           Title,
                           Description,
                           ReleaseYear,
                           Genre,
                           Director,
                           PosterPath
                    FROM Movies
                    ORDER BY Title";

                using (SqlCommand command =
                       new SqlCommand(query, connection))
                {
                    connection.Open();

                    using (SqlDataReader reader =
                           command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            movies.Add(MapMovie(reader));
                        }
                    }
                }
            }

            return movies;
        }

        // =====================================================
        // GET MOVIE BY ID
        // =====================================================

        public Movie GetById(int movieId)
        {
            using (SqlConnection connection =
                   db.GetConnection())
            {
                string query = @"
                    SELECT MovieId,
                           Title,
                           Description,
                           ReleaseYear,
                           Genre,
                           Director,
                           PosterPath
                    FROM Movies
                    WHERE MovieId = @MovieId";

                using (SqlCommand command =
                       new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue(
                        "@MovieId",
                        movieId
                    );

                    connection.Open();

                    using (SqlDataReader reader =
                           command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return MapMovie(reader);
                        }
                    }
                }
            }

            return null;
        }

        // =====================================================
        // SEARCH + GENRE FILTER
        // =====================================================

        public List<Movie> SearchMovies(
            string searchText,
            string genre)
        {
            List<Movie> movies =
                new List<Movie>();

            using (SqlConnection connection =
                   db.GetConnection())
            {
                string query = @"
                    SELECT MovieId,
                           Title,
                           Description,
                           ReleaseYear,
                           Genre,
                           Director,
                           PosterPath
                    FROM Movies
                    WHERE
                        (@SearchText = ''
                         OR Title LIKE '%' + @SearchText + '%')
                    AND
                        (@Genre = 'All'
                         OR Genre = @Genre)
                    ORDER BY Title";

                using (SqlCommand command =
                       new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue(
                        "@SearchText",
                        searchText == null
                            ? ""
                            : searchText.Trim()
                    );

                    command.Parameters.AddWithValue(
                        "@Genre",
                        string.IsNullOrEmpty(genre)
                            ? "All"
                            : genre
                    );

                    connection.Open();

                    using (SqlDataReader reader =
                           command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            movies.Add(MapMovie(reader));
                        }
                    }
                }
            }

            return movies;
        }

        // =====================================================
        // ADD MOVIE
        // =====================================================

        public bool Add(Movie movie)
        {
            if (movie == null)
            {
                return false;
            }

            using (SqlConnection connection =
                   db.GetConnection())
            {
                string query = @"
                    INSERT INTO Movies
                    (
                        Title,
                        Description,
                        ReleaseYear,
                        Genre,
                        Director,
                        PosterPath
                    )
                    VALUES
                    (
                        @Title,
                        @Description,
                        @ReleaseYear,
                        @Genre,
                        @Director,
                        @PosterPath
                    )";

                using (SqlCommand command =
                       new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue(
                        "@Title",
                        movie.Title ?? ""
                    );

                    command.Parameters.AddWithValue(
                        "@Description",
                        movie.Description ?? ""
                    );

                    command.Parameters.AddWithValue(
                        "@ReleaseYear",
                        movie.ReleaseYear
                    );

                    command.Parameters.AddWithValue(
                        "@Genre",
                        movie.Genre ?? ""
                    );

                    command.Parameters.AddWithValue(
                        "@Director",
                        movie.Director ?? ""
                    );

                    command.Parameters.AddWithValue(
                        "@PosterPath",
                        movie.PosterPath ?? ""
                    );

                    connection.Open();

                    int rows =
                        command.ExecuteNonQuery();

                    return rows > 0;
                }
            }
        }

        // =====================================================
        // UPDATE MOVIE
        // =====================================================

        public bool Update(Movie movie)
        {
            if (movie == null ||
                movie.MovieId <= 0)
            {
                return false;
            }

            using (SqlConnection connection =
                   db.GetConnection())
            {
                string query = @"
                    UPDATE Movies
                    SET
                        Title = @Title,
                        Description = @Description,
                        ReleaseYear = @ReleaseYear,
                        Genre = @Genre,
                        Director = @Director,
                        PosterPath = @PosterPath
                    WHERE MovieId = @MovieId";

                using (SqlCommand command =
                       new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue(
                        "@MovieId",
                        movie.MovieId
                    );

                    command.Parameters.AddWithValue(
                        "@Title",
                        movie.Title ?? ""
                    );

                    command.Parameters.AddWithValue(
                        "@Description",
                        movie.Description ?? ""
                    );

                    command.Parameters.AddWithValue(
                        "@ReleaseYear",
                        movie.ReleaseYear
                    );

                    command.Parameters.AddWithValue(
                        "@Genre",
                        movie.Genre ?? ""
                    );

                    command.Parameters.AddWithValue(
                        "@Director",
                        movie.Director ?? ""
                    );

                    command.Parameters.AddWithValue(
                        "@PosterPath",
                        movie.PosterPath ?? ""
                    );

                    connection.Open();

                    int rows =
                        command.ExecuteNonQuery();

                    return rows > 0;
                }
            }
        }

        // =====================================================
        // DELETE MOVIE
        // =====================================================

        public bool Delete(int movieId)
        {
            if (movieId <= 0)
            {
                return false;
            }

            using (SqlConnection connection =
                   db.GetConnection())
            {
                string query = @"
                    DELETE FROM Reviews
                    WHERE MovieId = @MovieId;

                    DELETE FROM Favorites
                    WHERE MovieId = @MovieId;

                    DELETE FROM Watchlist
                    WHERE MovieId = @MovieId;

                    DELETE FROM Movies
                    WHERE MovieId = @MovieId;";

                using (SqlCommand command =
                       new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue(
                        "@MovieId",
                        movieId
                    );

                    connection.Open();

                    int rows =
                        command.ExecuteNonQuery();

                    return rows > 0;
                }
            }
        }

        // =====================================================
        // MAP SQL DATA → MOVIE OBJECT
        // =====================================================

        private Movie MapMovie(
            SqlDataReader reader)
        {
            Movie movie =
                new Movie();

            movie.MovieId =
                (int)reader["MovieId"];

            movie.Title =
                reader["Title"] == DBNull.Value
                ? ""
                : reader["Title"].ToString();

            movie.Description =
                reader["Description"] == DBNull.Value
                ? ""
                : reader["Description"].ToString();

            movie.ReleaseYear =
                reader["ReleaseYear"] == DBNull.Value
                ? 0
                : Convert.ToInt32(
                    reader["ReleaseYear"]
                );

            movie.Genre =
                reader["Genre"] == DBNull.Value
                ? ""
                : reader["Genre"].ToString();

            movie.Director =
                reader["Director"] == DBNull.Value
                ? ""
                : reader["Director"].ToString();

            movie.PosterPath =
                reader["PosterPath"] == DBNull.Value
                ? ""
                : reader["PosterPath"].ToString();

            return movie;
        }
    }
}