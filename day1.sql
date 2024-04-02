--1
SELECT p.ProductID, p.Name,p.Color,p.ListPrice
FROM Production.Product p

--2
SELECT p.ProductID, p.Name,p.Color,p.ListPrice
FROM Production.Product p
WHERE p.ListPrice = 0

--3
SELECT p.ProductID, p.Name,p.Color,p.ListPrice
FROM Production.Product p
WHERE p.Color IS NULL

--4
SELECT p.ProductID, p.Name,p.Color,p.ListPrice
FROM Production.Product p
WHERE p.Color IS NOT NULL

--5
SELECT p.ProductID, p.Name,p.Color,p.ListPrice
FROM Production.Product p
WHERE p.Color IS NOT NULL
AND p.ListPrice > 0


--6
SELECT p.Name +' '+ p.Color,p.ListPrice
FROM Production.Product p
WHERE p.Color IS NOT NULL

--7
SELECT TOP 6 'NAME: '+p.Name + ' -- COLOR: '+ p.Color
FROM Production.Product p
WHERE p.Color IS NOT NULL

--8
SELECT p.ProductID, p.Name
FROM Production.Product p
WHERE p.ProductID BETWEEN 400 AND 500

--9
SELECT p.ProductID, p.Name,p.Color
FROM Production.Product p
WHERE p.Color IN ('Black','Blue')

--10
SELECT *
FROM Production.Product p
WHERE p.Name LIKE 'S%'

--11
SELECT p.Name, p.ListPrice
FROM Production.Product p
WHERE p.Name LIKE 'S%'
ORDER BY p.Name

--12
SELECT p.Name, p.ListPrice
FROM Production.Product p
WHERE p.Name LIKE '[AS]%'
ORDER BY p.Name

--13
SELECT p.Name
FROM Production.Product p
WHERE p.Name LIKE 'SPO[^K]%'
ORDER BY p.Name

--14
SELECT DISTINCT p.Color
FROM Production.Product p
ORDER BY p.Color DESC

--15
SELECT DISTINCT p.ProductSubcategoryID, p.Color
FROM Production.Product p
WHERE p.ProductSubcategoryID IS NOT NULL AND p.Color IS NOT NULL
ORDER BY p.ProductSubcategoryID, p.Color
