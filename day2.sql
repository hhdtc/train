--USE AdventureWorks2019
USE AdventureWorks2019
GO

--1
SELECT COUNT(1)
FROM Production.Product

--2
SELECT COUNT(1)
FROM Production.Product p
WHERE p.ProductSubcategoryID IS NOT NULL

--3
SELECT p.ProductSubcategoryID, COUNT(1) AS CountedProducts
FROM Production.Product p
GROUP BY p.ProductSubcategoryID
HAVING p.ProductSubcategoryID IS NOT NULL

--4
SELECT COUNT(1)
FROM Production.Product p
WHERE p.ProductSubcategoryID IS NULL

--5
SELECT p.ProductID,SUM(p.Quantity) Quantity
FROM Production.ProductInventory p
GROUP BY p.ProductID



--6
SELECT p.ProductID,SUM(p.Quantity) TheSum
FROM Production.ProductInventory p
WHERE p.LocationID = 40
GROUP BY p.ProductID
HAVING SUM(p.Quantity)<100

--7
SELECT p.ProductID,p.Shelf,SUM(p.Quantity) TheSum
FROM Production.ProductInventory p
WHERE p.LocationID = 40
GROUP BY p.ProductID, p.Shelf
HAVING SUM(p.Quantity)<100

--8
SELECT p.ProductID,AVG(p.Quantity) TheAvg
FROM Production.ProductInventory p
WHERE LocationID = 10
GROUP BY p.ProductID

--9
SELECT p.ProductID, p.Shelf, AVG(p.Quantity) TheAvg
FROM Production.ProductInventory p
GROUP BY p.ProductID, p.Shelf

--10
SELECT p.ProductID, p.Shelf, AVG(p.Quantity) TheAvg
FROM Production.ProductInventory p
WHERE p.Shelf != 'N/A'
GROUP BY p.ProductID, p.Shelf

--11
SELECT p.Color, p.Class, COUNT(1) TheCount, AVG(P.ListPrice) AvgPrice
FROM Production.Product p
GROUP BY p.Color, p.Class

--12
SELECT cr.Name Country, sp.Name Province
FROM person.CountryRegion cr
JOIN person.StateProvince sp
ON sp.CountryRegionCode = cr.CountryRegionCode

--13
SELECT cr.Name Country, sp.Name Province
FROM person.CountryRegion cr
JOIN person.StateProvince sp
ON sp.CountryRegionCode = cr.CountryRegionCode
WHERE cr.Name in ('Germany','Canada')


--USE Northwind
USE Northwind
GO

--14
SELECT DISTINCT p.ProductName
FROM Orders o
JOIN [Order Details] od
ON od.OrderID = o.OrderID
JOIN Products p
ON od.ProductID = p.ProductID
WHERE o.OrderDate >= DATEADD(YEAR, -25, GETDATE())

--15
SELECT TOP 5 o.ShipPostalCode
FROM Orders o
JOIN [Order Details] od
ON od.OrderID = o.OrderID
JOIN Products p
ON od.ProductID = p.ProductID
Group BY o.ShipPostalCode
HAVING o.ShipPostalCode IS NOT NULL
ORDER BY SUM(od.Quantity) DESC

--16
SELECT TOP 5 o.ShipPostalCode
FROM Orders o
JOIN [Order Details] od
ON od.OrderID = o.OrderID
JOIN Products p
ON od.ProductID = p.ProductID
WHERE o.OrderDate >= DATEADD(YEAR, -25, GETDATE())
Group BY o.ShipPostalCode
HAVING o.ShipPostalCode IS NOT NULL
ORDER BY SUM(od.Quantity) DESC

--17
SELECT c.City, COUNT(1) Num
FROM Customers c
GROUP BY c.City

--18
SELECT c.City, COUNT(1) Num
FROM Customers c
GROUP BY c.City
HAVING COUNT(1) > 2

--19
SELECT c.CompanyName, o.OrderDate
FROM Customers c
JOIN Orders o
ON o.CustomerID = c.CustomerID
WHERE o.OrderDate > '1998-01-01'

--20
SELECT c.CompanyName, MAX(o.OrderDate)
FROM Customers c
JOIN Orders o
ON o.CustomerID = c.CustomerID
Group BY c.CompanyName

--21
SELECT c.CompanyName, SUM(od.Quantity) quantity
FROM Customers c
JOIN Orders o
ON o.CustomerID = c.CustomerID
JOIN [Order Details] od
ON od.OrderID = o.OrderID
Group BY c.CompanyName

--22
SELECT c.CustomerID, SUM(od.Quantity)
FROM Customers c
JOIN Orders o
ON o.CustomerID = c.CustomerID
JOIN [Order Details] od
ON od.OrderID = o.OrderID
Group BY c.CustomerID
HAVING SUM(od.Quantity) > 100

--23
SELECT sup.CompanyName 'Supplier Company Name', ship.CompanyName 'Shipping Company Name'
FROM Suppliers sup, Shippers ship

--24
SELECT DISTINCT o.OrderDate,p.ProductName
FROM Orders o
JOIN [Order Details] od
ON od.OrderID = o.OrderID
JOIN Products p
ON od.ProductID = p.ProductID

--25
SELECT a.FirstName+' '+a.LastName AS 'Name1',  b.FirstName+' '+b.LastName AS 'Name2'
FROM Employees a
JOIN Employees b
ON a.Title = b.Title
WHERE a.EmployeeID != b.EmployeeID

--26
SELECT manager.FirstName+' '+manager.LastName AS 'Name', COUNT(reporter.EmployeeID) 'Employees Num'
FROM Employees manager
JOIN Employees reporter
ON reporter.ReportsTo = manager.EmployeeID
GROUP BY manager.FirstName+' '+manager.LastName
HAVING COUNT(reporter.EmployeeID) > 2

--27
SELECT c.City AS 'City', c.CompanyName AS 'Name', c.ContactName AS 'Contact Name', 'Customer' AS 'Type'
FROM Customers c
UNION ALL
SELECT s.City AS 'City', s.CompanyName AS 'Name', s.ContactName AS 'Contact Name', 'Supplier' AS 'Type'
FROM Suppliers s
