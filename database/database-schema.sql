--defining the tables

CREATE TABLE BOOKSHELVES (
	bookshelfID int IDENTITY(100, 1) PRIMARY KEY NOT NULL,
	shelfName varchar(50) NOT NULL
);


CREATE TABLE USER1 (
	userName varchar(50) NOT NULL,
	userEmail varchar(50) PRIMARY KEY NOT NULL,
	passwordd varchar(50) NOT NULL,
	profilePicture image,
	dateOfBirth date,
	friends varchar(50),
	bookshelfID int

	FOREIGN KEY (friends) REFERENCES USER1 (userEmail),
	FOREIGN KEY (bookshelfID) REFERENCES BOOKSHELVES (bookshelfID)
);


CREATE TABLE BOOK (
	ISBN int PRIMARY KEY NOT NULL,
	title varchar(50) NOT NULL,
	genre varchar(50) NOT NULL,
	publicationDate date NOT NULL,
	coverImage image,
	userEmail varchar(50),
	bookshelfID int

	FOREIGN KEY (userEmail) REFERENCES USER1 (userEmail),
	FOREIGN KEY (bookshelfID) REFERENCES BOOKSHELVES (bookshelfID)
);


CREATE TABLE AUTHOR (
	authorName varchar(50) NOT NULL,
	passwordd varchar(50) NOT NULL,
	authorEmail varchar(50),
	bookID int NOT NULL,
	profilePicture image,
	dateOfBirth date

	FOREIGN KEY (bookID) REFERENCES BOOK (ISBN)
);


CREATE TABLE REVIEWS (
	reviewID int IDENTITY(10, 1) PRIMARY KEY NOT NULL,
	userEmail varchar(50) NOT NULL,
	bookID int NOT NULL,
	reviewText varchar(250),
	rating int CHECK (rating >= 0 AND rating <= 5) NOT NULL,
	reviewDate date NOT NULL

	FOREIGN KEY (userEmail) REFERENCES USER1 (userEmail),
	FOREIGN KEY (bookID) REFERENCES BOOK (ISBN)
);