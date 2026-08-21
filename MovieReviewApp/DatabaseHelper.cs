using System;
using System.Data.SqlClient;

namespace MovieReviewApp
{
    internal class DatabaseHelper
    {
        private string serverConnectionString =
            @"Server=.\SQLEXPRESS;Database=master;Trusted_Connection=True;";

        private string databaseConnectionString =
            @"Server=.\SQLEXPRESS;Database=MovieReviewDB;Trusted_Connection=True;";

        public void InitializeDatabase()
        {
            // ==============================
            // 1. CREATE DATABASE IF NEEDED
            // ==============================

            using (SqlConnection connection =
                   new SqlConnection(serverConnectionString))
            {
                connection.Open();

                string createDatabaseQuery = @"
                    IF NOT EXISTS
                    (
                        SELECT name
                        FROM sys.databases
                        WHERE name = 'MovieReviewDB'
                    )
                    BEGIN
                        CREATE DATABASE MovieReviewDB;
                    END";

                using (SqlCommand command =
                       new SqlCommand(createDatabaseQuery, connection))
                {
                    command.ExecuteNonQuery();
                }
            }


            // ==============================
            // 2. CREATE TABLES IF NEEDED
            // ==============================

            using (SqlConnection connection =
                   new SqlConnection(databaseConnectionString))
            {
                connection.Open();

                string createTablesQuery = @"

                -- USERS TABLE
                IF NOT EXISTS
                (
                    SELECT *
                    FROM sys.tables
                    WHERE name = 'Users'
                )
                BEGIN
                    CREATE TABLE Users
                    (
                        UserId INT PRIMARY KEY IDENTITY(1,1),
                        Name VARCHAR(100) NOT NULL,
                        Email VARCHAR(150) NOT NULL UNIQUE,
                        Password VARCHAR(255) NOT NULL
                    );
                END;


                -- MOVIES TABLE
                IF NOT EXISTS
                (
                    SELECT *
                    FROM sys.tables
                    WHERE name = 'Movies'
                )
                BEGIN
                    CREATE TABLE Movies
                    (
                        MovieId INT PRIMARY KEY IDENTITY(1,1),
                        Title VARCHAR(200) NOT NULL,
                        Description VARCHAR(MAX),
                        ReleaseYear INT,
                        Genre VARCHAR(100),
                        Director VARCHAR(100),
                        PosterPath VARCHAR(500)
                    );
                END;


                -- REVIEWS TABLE
                IF NOT EXISTS
                (
                    SELECT *
                    FROM sys.tables
                    WHERE name = 'Reviews'
                )
                BEGIN
                    CREATE TABLE Reviews
                    (
                        ReviewId INT PRIMARY KEY IDENTITY(1,1),
                        UserId INT NOT NULL,
                        MovieId INT NOT NULL,
                        Rating INT NOT NULL,
                        ReviewText VARCHAR(MAX),

                        CONSTRAINT FK_Reviews_Users
                            FOREIGN KEY (UserId)
                            REFERENCES Users(UserId),

                        CONSTRAINT FK_Reviews_Movies
                            FOREIGN KEY (MovieId)
                            REFERENCES Movies(MovieId)
                    );
                END;


                -- WATCHLIST TABLE
                IF NOT EXISTS
                (
                    SELECT *
                    FROM sys.tables
                    WHERE name = 'Watchlist'
                )
                BEGIN
                    CREATE TABLE Watchlist
                    (
                        WatchlistId INT PRIMARY KEY IDENTITY(1,1),
                        UserId INT NOT NULL,
                        MovieId INT NOT NULL,

                        CONSTRAINT FK_Watchlist_Users
                            FOREIGN KEY (UserId)
                            REFERENCES Users(UserId),

                        CONSTRAINT FK_Watchlist_Movies
                            FOREIGN KEY (MovieId)
                            REFERENCES Movies(MovieId),

                        CONSTRAINT UQ_Watchlist_User_Movie
                            UNIQUE (UserId, MovieId)
                    );
                END;
                ";

                using (SqlCommand command =
                       new SqlCommand(createTablesQuery, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        public SqlConnection GetConnection()
        {
            return new SqlConnection(databaseConnectionString);
        }
    }
}