using System.Collections.Generic;
using System.Data.SqlClient;
using MovieReviewApp;
using MovieReviewApp.Models;

namespace MovieReviewApp.Services
{
    public class MovieService
    {
        private readonly DatabaseHelper db = new DatabaseHelper();

        public List<Movie> GetAll()
        {
            List<Movie> movies = new List<Movie>();

            using (SqlConnection connection = db.GetConnection())
            {
                string query = @"
                    SELECT MovieId,
                           Title,
                           Description,
                           ReleaseYear,
                           Genre,
                           Director,
                           PosterPath
                    FROM Movies";

                using (SqlCommand command =
                       new SqlCommand(query, connection))
                {
                    connection.Open();

                    using (SqlDataReader reader =
                           command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Movie movie = new Movie();

                            movie.MovieId =
                                (int)reader["MovieId"];

                            movie.Title =
                                reader["Title"].ToString();

                            movie.Description =
                                reader["Description"].ToString();

                            movie.ReleaseYear =
                                reader["ReleaseYear"] == System.DBNull.Value
                                ? 0
                                : (int)reader["ReleaseYear"];

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
    }
}