CREATE DATABASE MovieReviewDB;
GO

USE MovieReviewDB;
GO

CREATE TABLE Users
(
    UserId INT PRIMARY KEY IDENTITY(1,1),
    Name VARCHAR(100) NOT NULL,
    Email VARCHAR(150) NOT NULL UNIQUE,
    Password VARCHAR(255) NOT NULL
);
GO

CREATE TABLE Movies
(
    MovieId INT PRIMARY KEY IDENTITY(1,1),
    Title VARCHAR(200) NOT NULL,
    Description VARCHAR(MAX),
    ReleaseYear INT,
    Genre VARCHAR(100)
);
GO

CREATE TABLE Reviews
(
    ReviewId INT PRIMARY KEY IDENTITY(1,1),
    UserId INT NOT NULL,
    MovieId INT NOT NULL,
    Rating INT NOT NULL,
    ReviewText VARCHAR(MAX),
    
    CONSTRAINT FK_Reviews_Users
        FOREIGN KEY (UserId) REFERENCES Users(UserId),

    CONSTRAINT FK_Reviews_Movies
        FOREIGN KEY (MovieId) REFERENCES Movies(MovieId)
);
GO

CREATE TABLE Watchlist
(
    WatchlistId INT PRIMARY KEY IDENTITY(1,1),
    UserId INT NOT NULL,
    MovieId INT NOT NULL,

    CONSTRAINT FK_Watchlist_Users
        FOREIGN KEY (UserId) REFERENCES Users(UserId),

    CONSTRAINT FK_Watchlist_Movies
        FOREIGN KEY (MovieId) REFERENCES Movies(MovieId),

    CONSTRAINT UQ_Watchlist_User_Movie
        UNIQUE (UserId, MovieId)
);
GO