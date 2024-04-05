--1
SELECT DISTINCT e.City
FROM Employees e
INNER JOIN Customers c
ON e.City = c.City

--2.a
SELECT DISTINCT c.City
FROM Customers c
LEFT JOIN Employees e
ON e.City = c.City
WHERE e.EmployeeID IS NULL

--2.b
SELECT DISTINCT c.City
FROM Customers c
WHERE c.City NOT IN (
    SELECT DISTINCT e.City
    FROM Employees e
)

--3
SELECT p.ProductName, SUM(od.Quantity) AS Sum
FROM Orders o
JOIN [Order Details] od
ON o.OrderID = od.OrderID
JOIN Products p
ON od.ProductID = p.ProductID
GROUP BY p.ProductName

--4
SELECT c.City, SUM(od.Quantity) AS Sum
FROM Orders o
JOIN [Order Details] od
ON o.OrderID = od.OrderID
JOIN Customers c
ON o.CustomerID = c.CustomerID
GROUP BY c.City

--5.a
SELECT DISTINCT c1.City
FROM Customers c1
JOIN Customers c2
ON c1.City = c2.City
WHERE c1.CustomerID != c2.CustomerID

--5.b
SELECT DISTINCT c1.City
FROM Customers c1
WHERE c1.City NOT IN (
    SELECT c2.City
    FROM Customers c2
    GROUP BY c2.City
    HAVING COUNT(c2.CustomerID)<2
)

--6
SELECT DISTINCT c.City
FROM Customers c
JOIN Orders o
ON o.CustomerID = c.CustomerID
JOIN [Order Details] od
ON od.OrderID = o.OrderID
GROUP by c.City
HAVING COUNT(DISTINCT od.ProductID)>= 2

--7
SELECT DISTINCT c.CompanyName
FROM Customers c
JOIN Orders o
ON o.CustomerID = c.CustomerID
WHERE o.ShipCity != c.City

--8
--STEPS:
--Average Price
SELECT od.ProductID,SUM(od.Quantity*od.UnitPrice*od.Quantity)/SUM(od.Quantity) AS AveragePrice
FROM [Order Details] od
GROUP BY od.ProductID

--CustomersCity
SELECT od.ProductID, c.City, RANK( ) OVER(PARTITION BY od.ProductID ORDER BY SUM(od.Quantity) DESC) AS Rank, SUM(od.Quantity) as sum
FROM Orders o
JOIN [Order Details] od
ON o.OrderID = od.OrderID
Join Customers c
ON c.CustomerID = o.CustomerID
GROUP BY od.ProductID,  c.City

--TOP 5 popular product
SELECT TOP 5 od.ProductID, RANK() OVER(ORDER BY SUM(od.Quantity)DESC) AS Rank
FROM [Order Details] od
GROUP BY od.ProductID
ORDER BY SUM(od.Quantity)DESC

--FINAL
SELECT p.ProductName, AveragePrice.AveragePrice, CustomerCity.City
FROM Products p
JOIN (SELECT TOP 5 od.ProductID, RANK() OVER(ORDER BY SUM(od.Quantity)DESC) AS Rank
FROM [Order Details] od
GROUP BY od.ProductID
ORDER BY SUM(od.Quantity)DESC) Top5
ON p.ProductID = Top5.ProductID
JOIN (SELECT od.ProductID,SUM(od.Quantity*od.UnitPrice*od.Quantity)/SUM(od.Quantity) AS AveragePrice
FROM [Order Details] od
GROUP BY od.ProductID) AveragePrice
ON AveragePrice.ProductID = p.ProductID
JOIN (SELECT od.ProductID, c.City, RANK( ) OVER(PARTITION BY od.ProductID ORDER BY SUM(od.Quantity) DESC) AS Rank, SUM(od.Quantity) as sum
FROM Orders o
JOIN [Order Details] od
ON o.OrderID = od.OrderID
Join Customers c
ON c.CustomerID = o.CustomerID
GROUP BY od.ProductID,  c.City) CustomerCity
ON CustomerCity.ProductID = p.ProductID
WHERE CustomerCity.Rank = 1
ORDER BY Top5.Rank


--9.A
SELECT DISTINCT e.City
FROM Employees e
WHERE e.City NOT IN (
    SELECT DISTINCT c.City 
    FROM Customers c
    JOIN Orders o
    ON c.CustomerID = o.CustomerID

)


--9.B
SELECT DISTINCT e.City
FROM Customers c
JOIN Orders o
ON C.CustomerID = o.CustomerID
RIGHT JOIN Employees e
ON e.City = c.City
WHERE O.CustomerID is NULL AND e.City IS NOT NULL


--10
--employee sold most
SELECT TOP 1 e.city
FROM Orders o
JOIN Employees e
ON o.EmployeeID = e.EmployeeID
GROUP BY e.City

--customer order most

SELECT TOP 1 c.city
FROM Orders o
JOIN Customers c
ON o.CustomerID = c.CustomerID
GROUP BY c.City

--Final:
SELECT CityOrderMost.City
FROM (SELECT TOP 1 e.city
FROM Orders o
JOIN Employees e
ON o.EmployeeID = e.EmployeeID
GROUP BY e.City) CitySellMost
JOIN (SELECT TOP 1 c.city
FROM Orders o
JOIN Customers c
ON o.CustomerID = c.CustomerID
GROUP BY c.City) CityOrderMost
ON CitySellMost.City = CityOrderMost.City

--11

-- DELETE FROM TableName
-- WHERE pk in (
-- SELECT t1.id 
-- FROM TableName t1
-- JOIN TableName t2
-- ON t1.DuplicatedColumn1 = t2.DuplicatedColumn1 AND t1.DuplicatedColumn2 = t2.DuplicatedColumn2
-- where t1.pk != t2.pk
-- )

WITH CTE AS (
    SELECT 
        *,
        ROW_NUMBER() OVER (PARTITION BY column1, column2, ... ORDER BY (SELECT NULL)) AS RowNumber
    FROM 
        YourTableName
)
DELETE FROM CTE WHERE RowNumber > 1;