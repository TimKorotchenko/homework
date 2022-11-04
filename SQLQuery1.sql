USE HomeWork;
CREATE TABLE Customers
(
    Id INT PRIMARY KEY IDENTITY,
    Age INT,
    FirstName NVARCHAR(20) NOT NULL,
    LastName NVARCHAR(20) NOT NULL,
    Phone VARCHAR(20) UNIQUE,
	
);
 CREATE TABLE Orders
(
    Id INT PRIMARY KEY IDENTITY,
    CustomerId INT REFERENCES Customers (Id),
    CreatedAt Date,
	FOREIGN KEY (CustomerId)  REFERENCES Customers (Id)
);
ALTER TABLE Customers
ADD Address NVARCHAR(50) NULL;
ALTER TABLE Customers
DROP COLUMN Address;
ALTER TABLE Customers
ADD CHECK (Age > 21);
ALTER TABLE Customers
ADD CONSTRAINT CK_Age_Greater CHECK (Age > 0);
INSERT INTO Customers VALUES ( 30, 'Тима', 'Коротченко', 123),
(25,'Ира', 'Иванова', 258)
SELECT * FROM Customers
UPDATE Customers
SET Age = Age + 1
DELETE Customers
WHERE Id=9
CREATE TABLE Products
(
    Id INT IDENTITY PRIMARY KEY,
    ProductName NVARCHAR(30) NOT NULL,
    Manufacturer NVARCHAR(20) NOT NULL,
    ProductCount INT DEFAULT 0,
    Price MONEY NOT NULL
);
ALTER TABLE Orders
ADD ProductId INT NOT NULL REFERENCES Products(Id) ON DELETE CASCADE,
ProductCount INT DEFAULT 1;
INSERT Products VALUES ('iPhone 7', 'Apple', 5, 52000)
INSERT INTO Orders (CustomerId, CreatedAt, ProductId, ProductCount) VALUES (1, '2022-12-01', 1, 100);
SELECT Orders.CreatedAt, Orders.ProductCount, Products.ProductName 
FROM Orders
JOIN Products ON Products.Id = Orders.ProductId

SELECT Orders.CreatedAt, Customers.FirstName, Products.ProductName 
FROM Orders
JOIN Products ON Products.Id = Orders.ProductId
JOIN Customers ON Customers.Id=Orders.CustomerId
SELECT Customers.FirstName, COUNT(Customers.FirstName)
FROM Orders
JOIN Products ON Products.Id = Orders.ProductId
JOIN Customers ON Customers.Id=Orders.CustomerId
GROUP BY Customers.FirstName
HAVING COUNT(Customers.FirstName) >2
USE HomeWork;
GO
CREATE PROCEDURE ProductSummary AS
SELECT ProductName AS Product, Manufacturer, Price
FROM Products
GO
CREATE TRIGGER Products_INSERT_UPDATE
ON Products
AFTER INSERT, UPDATE
AS
UPDATE Products
SET Price = Price + Price * 2