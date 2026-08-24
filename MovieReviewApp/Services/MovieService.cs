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
                            Movie movie =
                                new Movie();

                            movie.MovieId =
                                (int)reader["MovieId"];

                            movie.Title =
                                reader["Title"].ToString();

                            movie.Description =
                                reader["Description"] == System.DBNull.Value
                                ? ""
                                : reader["Description"].ToString();

                            movie.ReleaseYear =
                                reader["ReleaseYear"] == System.DBNull.Value
                                ? 0
                                : (int)reader["ReleaseYear"];

                            movie.Genre =
                                reader["Genre"] == System.DBNull.Value
                                ? ""
                                : reader["Genre"].ToString();

                            movie.Director =
                                reader["Director"] == System.DBNull.Value
                                ? ""
                                : reader["Director"].ToString();

                            movie.PosterPath =
                                reader["PosterPath"] == System.DBNull.Value
                                ? ""
                                : reader["PosterPath"].ToString();

                            movies.Add(movie);
                        }
                    }
                }
            }

            return movies;
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
                            Movie movie =
                                new Movie();

                            movie.MovieId =
                                (int)reader["MovieId"];

                            movie.Title =
                                reader["Title"].ToString();

                            movie.Description =
                                reader["Description"] == System.DBNull.Value
                                ? ""
                                : reader["Description"].ToString();

                            movie.ReleaseYear =
                                reader["ReleaseYear"] == System.DBNull.Value
                                ? 0
                                : (int)reader["ReleaseYear"];

                            movie.Genre =
                                reader["Genre"] == System.DBNull.Value
                                ? ""
                                : reader["Genre"].ToString();

                            movie.Director =
                                reader["Director"] == System.DBNull.Value
                                ? ""
                                : reader["Director"].ToString();

                            movie.PosterPath =
                                reader["PosterPath"] == System.DBNull.Value
                                ? ""
                                : reader["PosterPath"].ToString();

                            movies.Add(movie);
                        }
                    }
                }
            }

            return movies;
        }
    }
}