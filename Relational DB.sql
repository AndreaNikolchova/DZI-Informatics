--Problem 3.7
CREATE DATABASE [Library];

USE [Library];

CREATE TABLE Authors(
	ID INT PRIMARY KEY,
	[Name] VARCHAR(50) NOT NULL
);
CREATE TABLE Books(
	ID INT PRIMARY KEY,
	Title VARCHAR(200) NOT NULL,
	ISBN VARCHAR(50) NOT NULL,
	Published INT NOT NULL,
);


CREATE TABLE [Library](
	AuthorID INT REFERENCES Authors(ID),
	BookID INT REFERENCES Books(ID),
	Rented DATETIME2,
	PRIMARY KEY(AuthorID,BookID,Rented)
);

--Problem 3.8
INSERT INTO Authors(ID,[Name])
VALUES (1,'Bjarne Stroustrup'),
	   (2,'Stanley Lippman'),
       (3,'Paul Deitel'),
       (4,'Harvey Deitel'),
       (5,'Herb Sutter'),
       (6,'Mike Hendrickson'),
       (7,'Andrew Koenig'),
       (8,'Barbara Moo');

--Problem 3.9
INSERT INTO Books(ID,Title,ISBN,Published)
VALUES (1,'The C++ Programing Language, 4th Edition','9780275967307',2013),
       (2,'Tour of C++, A 3rd Edition','0136816487',2022),
	   (3,'C++ Primer 5th Edition','9780321714144',2012),
	   (4,'Essential C++ 1st Edition','9780201485189',1999),
	   (5,'C++ Gems: Programing Pearls from The C++ Report 320th Edition','9780135705810',1997),
	   (6,'A Tour of C++ (C++ In-Depth Series) 1st Edition','9780321958310',2013),
	   (7,'C++ How to Program 10th Edition','9780134448237',2016),
	   (8,'Exceptional C++: 47 Engineering Puzzles, Programming Problems, and Solutions','9780201615623',1999),
	   (9,'More Exceptional C++: 40 New Engineering Puzzles, Programming Problems, and Solutions 1st Edition','9780201704341',2001),
	   (10,'Accelerated C++: Practical Programming by Example 1st Edition','9780201703535',2000);
--Problem 3.10
INSERT INTO [Library](AuthorID,BookID,Rented)
VALUES (1,1,'1/1/2023'),
	   (1,2,'1/1/2023'),
	   (2,3,'1/1/2023'),
	   (2,4,'1/1/2023'),
	   (2,5,'1/1/2023'),
	   (1,6,'1/2/2023'),
	   (3,7,'1/2/2023'),
	   (4,7,'1/2/2023'),
	   (5,8,'1/2/2023'),
	   (5,9,'1/2/2023'),
	   (6,10,'1/3/2023'),
	   (7,10,'1/3/2023'),
	   (8,10,'1/3/2023');
--Problem 3.11

SELECT Title FROM Books;

--Problem 3.12

SELECT [Name] FROM Authors;

--Problem 3.13

SELECT A.Name, COUNT(L.AuthorID) AS [Count] FROM [Library] AS L
JOIN Authors AS A ON A.ID = L.AuthorID
GROUP BY A.Name
HAVING COUNT(L.AuthorID) > 1

--Problem 3.14
SELECT B.Title, COUNT(L.AuthorID) AS [Count] FROM [Library] AS L
JOIN Books AS B ON b.ID = l.BookID
GROUP BY B.Title
HAVING COUNT(L.AuthorID) > 1

--Problem 3.15
SELECT B.Title, COUNT(L.AuthorID) AS [Count] FROM [Library] AS L
JOIN Books AS B ON b.ID = l.BookID
GROUP BY B.Title
HAVING COUNT(L.AuthorID) = 1

--Problem 3.16

DELETE FROM Books
WHERE Title  = 'Accelerated C++: Practical Programming by Example 1st Edition'

DELETE FROM [Library]
WHERE BookID IN (SELECT ID FROM Books
WHERE Title  = 'Accelerated C++: Practical Programming by Example 1st Edition')

--Problem 3.17

UPDATE Books
SET Title =  REPLACE(Title,'C++','C#')


--Problem 3.25
CREATE DATABASE Sales;
USE Sales;
CREATE TABLE Shops(
	ID INT PRIMARY KEY,
	[Name] VARCHAR(50) NOT NULL
);
CREATE TABLE Products(
	ID INT PRIMARY KEY,
	[Name] VARCHAR(200) NOT NULL,
	Price MONEY NOT NULL
);


CREATE TABLE Sales(
	ShopID INT REFERENCES Shops(ID),
	ProductID INT REFERENCES Products(ID),
	Quantity INT,
	PRIMARY KEY(ShopID,ProductID,Quantity)
);

--Problem 3.26

INSERT INTO Shops
VALUES (1,'Sofia'),
       (2,'Plovdiv'),
	   (3,'Varna'),
	   (4,'Burgas'),
	   (5,'Ruse');

--Problem 3.27
INSERT INTO Products
VALUES (1,'Lemonade',$1.20),
       (2,'Fries',$2.40),
	   (3,'Hamburger',$3.20),
	   (4,'Sandvich',$2.80),
	   (5,'Apple juice',$2.00),
	   (6,'Tomato juice',$1.80),
	   (7,'Pepsi',$2.70),
	   (8,'Shepherds salad',$3.50),
	   (9,'Greek salad',$3.10),
	   (10,'Coca Cola',$2.50);

--Problem 3.28

INSERT INTO Sales
VALUES (1,1,4),
	   (1,2,2),
	   (2,6,4),
	   (2,7,4),
	   (3,7,3),
	   (3,9,3),
	   (3,10,3),
	   (4,3,2),
	   (4,5,2),
	   (4,4,1),
	   (4,5,1),
	   (5,1,6),
	   (5,2,3),
	   (5,3,4),
	   (5,5,4),
	   (5,6,2),
	   (5,7,2),
	   (5,9,2),
	   (4,3,1),
	   (4,4,3);

--Problem 3.29

SELECT [Name],Price FROM Products;

--Problem 3.30
 
SELECT Sh.[Name], P.[Name], S.Quantity,P.Price, s.Quantity*p.Price AS Cost FROM Sales AS S
JOIN Products AS P ON p.ID = s.ProductID
JOIN Shops AS Sh on Sh.ID = s.ShopID

--Problem 3.31

SELECT Sh.[Name],SUM(S.Quantity) AS [All sales] FROM Sales AS S
JOIN Shops AS Sh on Sh.ID = s.ShopID
GROUP BY sh.[Name]

--Problem 3.32

SELECT p.[Name],SUM(S.Quantity) AS [All sales] FROM Sales AS S
JOIN Products AS P ON p.ID = s.ProductID
GROUP BY p.Name

--Problem 3.33

SELECT Sh.[Name],SUM(p.Price*s.Quantity) AS [All sales] FROM Sales AS S
JOIN Shops AS Sh on Sh.ID = s.ShopID
JOIN Products AS P ON p.ID = s.ProductID
GROUP BY sh.[Name]
ORDER BY SUM(p.Price*s.Quantity) DESC

--Problem 3.34

SELECT p.[Name],SUM(p.Price*s.Quantity) AS [All sales] FROM Sales AS S
JOIN Products AS P ON p.ID = s.ProductID
GROUP BY p.Name
ORDER BY SUM(p.Price*s.Quantity) DESC

--Problem 3.35

DELETE FROM Sales
WHERE ProductID = (SELECT ID FROM Products WHERE Name = 'Pepsi');

--Problem 3.36
UPDATE Products
SET Price += Price * 0.10;

