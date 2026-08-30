CineVerse - Movie Review, Rating & Watchlist Application
Setup & Installation Guide
Overview

CineVerse is a Movie Review, Rating, Favorites, and Watchlist Management application developed using:

C# Windows Forms
SQL Server (SSMS)
3-Layer Architecture
Object-Oriented Programming (OOP)

This guide explains how to run the project properly.

Requirements

Before running the project, make sure the following software is installed:

Visual Studio 2022
.NET Framework
SQL Server Express / SQL Server
SQL Server Management Studio (SSMS)
Step 1: Open the Project
Open the solution file (MovieReviewApp.sln) in Visual Studio.
Build the project.
Run the application once.
Step 2: Automatic Database Creation

When the application runs for the first time:

The database MovieReviewDB will be created automatically.
Necessary tables will also be created automatically.

After the database is created:

Close the application.
Open SQL Server Management Studio (SSMS).
Step 3: Insert Sample Movies

Run the following SQL query:

USE MovieReviewDB;

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
    'Inception',
    'A skilled thief who steals corporate secrets through dream-sharing technology is given a chance to erase his past.',
    2010,
    'Sci-Fi',
    'Christopher Nolan',
    'Posters\inception.jpg'
),
(
    'Interstellar',
    'A team of explorers travels through a wormhole in space in search of a new home for humanity.',
    2014,
    'Sci-Fi',
    'Christopher Nolan',
    'Posters\interstellar.jpg'
),
(
    'The Dark Knight',
    'Batman faces a criminal mastermind who plunges Gotham City into chaos.',
    2008,
    'Action',
    'Christopher Nolan',
    'Posters\dark-knight.jpg'
),
(
    'Avengers: Endgame',
    'The Avengers gather once again to undo the devastating consequences of the previous battle.',
    2019,
    'Action',
    'Anthony Russo, Joe Russo',
    'Posters\endgame.jpg'
),
(
    'Avengers: Infinity War',
    'The Avengers and their allies attempt to defeat Thanos before he can collect all the Infinity Stones.',
    2018,
    'Action',
    'Anthony Russo, Joe Russo',
    'Posters\infinity-war.jpg'
),
(
    'The Matrix',
    'A computer hacker discovers that reality is not what it seems and joins a rebellion against machines.',
    1999,
    'Sci-Fi',
    'The Wachowskis',
    'Posters\matrix.jpg'
),
(
    'Titanic',
    'A young couple from different social backgrounds fall in love aboard the ill-fated RMS Titanic.',
    1997,
    'Romance',
    'James Cameron',
    'Posters\titanic.jpg'
),
(
    'The Shawshank Redemption',
    'A banker is sentenced to life in prison and forms an unlikely friendship while maintaining hope for freedom.',
    1994,
    'Drama',
    'Frank Darabont',
    'Posters\shawshank.jpg'
),
(
    'The Godfather',
    'The aging patriarch of an organized crime dynasty transfers control of his empire to his reluctant son.',
    1972,
    'Crime',
    'Francis Ford Coppola',
    'Posters\godfather.jpg'
),
(
    'Avatar',
    'A former Marine becomes part of a new world and must choose between following orders and protecting the people he comes to care about.',
    2009,
    'Fantasy',
    'James Cameron',
    'Posters\avatar.jpg'
);
Step 4: Create Admin Account

Run the following SQL query:

USE MovieReviewDB;
GO

INSERT INTO Users
(Name, Email, Password, Role)
VALUES
('Admin', 'admin@gmail.com', 'password as you like', 'Admin');
Step 5: Login Information

Use the following credentials to access the Admin Panel:

Email:admin@gmail.com 
Password: your given password

***Important Note***

Since this project uses SQL Server Local Database, every user who runs the project must:

Run the application once to create the database.
Execute the sample movie query.
Execute the admin account query.

Without these steps, the application will run, but there will be:

No movies
No admin account
No sample data

Features

User Features----

User Registration & Login
Browse Movies
Search Movies
Add Reviews & Ratings
Add to Favorites
Add to Watchlist
View Profile

Admin Features----

Dashboard Overview
Movie Management
User Management
Review Management
Delete Movies
Delete Users
