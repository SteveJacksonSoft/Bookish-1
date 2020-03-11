CREATE DATABASE library_mangement;

CREATE TABLE books (
booksID int auto_increment NOT NULL,
title varchar (255),
author varchar (255),
published_year varchar (255),
PRIMARY KEY (booksID)
);

INSERT INTO books (title, author, published_year) VALUES
("Harry Potter and the Chamber of Secrets", "J.K Rowling", 1998),
("Harry Potter and the Prisoner of Azkaban", "J.K Rowling", 1999),
("Harry Potter and the Goblet of Fire", "J.K Rowling", 2000),
("Harry Potter and the Order of Phoenix", "J.K Rowling", 2003),
("Harry Potter and the Half-Blood Prince", "J.K Rowling", 2005),
("Harry Potter and the Deathly Hallows Part 1", "J.K Rowling", 2007);

SELECT * FROM books;

CREATE TABLE members (
membersID int auto_increment NOT NULL,
first_name varchar(255),
last_name varchar(255),
-- --D.O.B
PRIMARY KEY (membersID)
);

INSERT INTO members (first_name, last_name) VALUES
("John", "Smith");

SELECT * FROM members;

CREATE TABLE copies (
copiesID int auto_increment NOT NULL,
booksID int NOT NULL,
membersID int NOT NULL,
amount_copies int,
return_date datetime,
PRIMARY KEY (copiesID),
FOREIGN KEY (booksID) REFERENCES books(booksID),
FOREIGN KEY (membersID) REFERENCES members(membersID)
);

SELECT * FROM copies;


