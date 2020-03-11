CREATE DATABASE library_mangement;

CREATE TABLE books (
booksID int auto_increment NOT NULL,
title varchar (255),
author varchar (255),
published_year varchar (255),
PRIMARY KEY (booksID)
);

CREATE TABLE members (
membersID int auto_increment NOT NULL,
PRIMARY KEY (membersID)
);

CREATE TABLE copies (
copiesID int auto_increment NOT NULL,
booksID int auto_increment NOT NULL,
membersID int auto_increment NOT NULL,
return_date datetime,
PRIMARY KEY (copiesID),
FOREIGN KEY (booksID) REFERENCES books(booksID),
FOREIGN KEY (membersID) REFERENCES members(membersID)
);