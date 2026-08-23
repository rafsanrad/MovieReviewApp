using System;
using System.Data.SqlClient;

namespace MovieReviewApp.Services
{
    public class WatchlistService
    {
        private readonly DatabaseHelper db =
            new DatabaseHelper();

        public bool AddToWatchlist(
            int userId,
            int movieId)
        {
            using (SqlConnection connection =
                   db.GetConnection())
            {
                connection.Open();

                // =========================================
                // CHECK IF ALREADY IN WATCHLIST
                // =========================================

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


                // =========================================
                // INSERT INTO WATCHLIST
                // =========================================

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
    }
}