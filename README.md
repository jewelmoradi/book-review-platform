# Book Review Platform

A database-backed book review platform designed and implemented with C#, SQL Server, and database modeling as part of my undergraduate Computer Engineering coursework.

## Overview

This project explores the design and implementation of a book-related platform with functionality for users, books, authors, reviews, and personal bookshelves.

The project combines relational database design with desktop application development using C# and Windows Forms.

## Features

The application includes functionality related to:

- User registration and sign-in
- User and author profiles
- Book management
- Book viewing
- Personal bookshelves
- Friends
- Book reviews and ratings
- Book cover image handling

## Database

The database was designed using Microsoft SQL Server.

The schema includes tables for:

- Users
- Books
- Authors
- Reviews
- Bookshelves

The `database/` directory contains the SQL schema and database design diagrams.

## C# Application

The application was developed as a Windows Forms application using C# and .NET Framework.

The application communicates with SQL Server using ADO.NET, including `SqlConnection` and `SqlCommand` for database operations.

The project also includes Windows Forms Designer files and application resources.

## Database Design

The repository includes:

- Entity-Relationship Diagram (ERD)
- Table relationship diagram
- SQL database schema

## Project Structure

<pre>database/
├── database-schema.sql
├── erd-diagram.jpg
└── table-relations.jpg

csharp/
├── neginmoradi_DBlab_project.sln
└── neginmoradi_DBlab_project/
    ├── Properties/
    ├── Resources/
    ├── App.config
    ├── Program.cs
    ├── Windows Forms source files
    └── neginmoradi_DBlab_project.csproj
</pre>

## Project Context

This project was developed as part of my undergraduate Computer Engineering coursework at Shiraz University of Technology.

The project focused on relational database design, SQL Server, C# application development, and integrating a desktop application with a database.

## Status

Completed university project.
