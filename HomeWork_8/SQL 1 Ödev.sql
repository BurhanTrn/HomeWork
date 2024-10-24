-- 1.Sorgu
--  Tüm
-- ürünlerin adlarını ve birim fiyatlarını listeleyin.

SELECT
    p.ProductName, p.UnitPrice
FROM Products p

--2.Sorgu 
--Müşterilerin şirket adlarını
-- ve bulundukları şehirleri alfabetik sırayla listeleyin.

SELECT
    c.CompanyName, c.City
FROM Customers c
ORDER BY c.City ASC

--3.Sorgu
SELECT
    e.FirstName+' '+e.LastName AS [Çalışan İsim]
FROM Employees e

--4.Sorgu
SELECT
    *
FROM Products p
WHERE p.UnitsInStock<10

--5.Sorgu
SELECT
    *
FROM Orders o
WHERE o.OrderDate BETWEEN '1998-01-01' AND '1998-12-31'

--6.Sorgu
SELECT
    c.CategoryName,
    COUNT(p.CategoryID) AS [Ürün Sayısı]
FROM Categories c
    JOIN Products p ON c.CategoryID = p.CategoryID
GROUP BY CategoryName

--7.Sorgu 
SELECT TOP 5
    p.ProductName, p.UnitPrice
FROM Products p
ORDER BY UnitPrice DESC



--8.Sorgu
SELECT c.Country, COUNT(c.CustomerID) AS [Müşteri Sayısı]
FROM Customers c
GROUP BY c.Country
ORDER BY [Müşteri Sayısı] DESC

--9.Sorgu
SELECT
    *
FROM Orders o
WHERE o.Freight>50

--10.Sorgu 
SELECT
    e.EmployeeID,
    e.FirstName+' '+ e.LastName AS [Çalışan Ad-Soyad],
    COUNT
(o.OrderID) AS [Toplam Sipariş Sayısı]
FROM Employees e
    JOIN Orders o ON e.EmployeeID = o.EmployeeID
GROUP BY e.EmployeeID,e.FirstName,e.LastName
ORDER BY [Toplam Sipariş Sayısı] DESC

--11.Sorgu 
SELECT
    p.ProductID, p.ProductName, c.CategoryName, c.CategoryID
FROM Products p
    JOIN Categories c ON p.CategoryID = c.CategoryID

--12.Sorgu
SELECT
    od.OrderID,
    SUM(od.UnitPrice*od.Quantity) AS [Toplam Tutar]
FROM OrderDetails od
GROUP BY od.OrderID

--13.Sorgu

SELECT TOP 5
    p.ProductID,
    P.ProductName,
    od.Quantity AS [Satılan Ürün Mik],
    od.UnitPrice

FROM OrderDetails od
    JOIN Products p ON OD.ProductID = P.ProductID
GROUP BY p.ProductID,p.ProductName,od.UnitPrice,od.Quantity
ORDER BY [Satılan Ürün Mik] DESC

--14.Sorgu

SELECT c.CompanyName, COUNT(c.CustomerID) AS [Sipariş Sayısı]
FROM Customers c
    JOIN Orders o ON c.CustomerID = o.CustomerID
GROUP BY c.CompanyName

--15.Sorgu
-- Hangi kargo şirketinin
-- kaç sipariş taşıdığını listeleyin.
SELECT
    s.CompanyName , COUNT(o.OrderID) AS [Sipariş Sayısı]
FROM Shippers s
    JOIN Orders o ON s.ShipperID = o.ShipVia
GROUP BY s.CompanyName

--16.Sorgu
-- Her bir çalışanın
-- toplam satış tutarını hesaplayın.
SELECT
    e.FirstName+' '+e.LastName AS [Çalışan İsim],
    COUNT(o.OrderID) [Satış Adedi],
    SUM(od.UnitPrice*od.Quantity*(1-od.Discount)) AS [Toplam Satış Tutarı]
FROM Employees e
    JOIN Orders o ON e.EmployeeID = o.EmployeeID
    JOIN OrderDetails od ON o.OrderID = od.OrderID
GROUP BY e.FirstName,e.LastName

--17.Soru 
-- Her bir kategorideki
-- ürünlerin ortalama fiyatını bulun.
SELECT
c.CategoryName, AVG(p.UnitPrice) AS [Kategori Ortalama Fiyat]
FROM Categories c 
JOIN Products p ON c.CategoryID = p.CategoryID
GROUP BY c.CategoryName


-- 18. En az 5 sipariş veren müşterileri ve sipariş sayılarını listeleyin.
SELECT 
c.CustomerID,
COUNT(o.OrderID) AS [Sipariş Sayısı]
FROM Customers c 
JOIN Orders o ON c.CustomerID = o.CustomerID
GROUP BY c.CustomerID
HAVING COUNT(o.OrderID)>5
ORDER BY [Sipariş Sayısı] DESC

-- 19. Her bir ülke için toplam satış tutarını hesaplayın.
SELECT
c.Country,
SUM(od.Quantity*od.UnitPrice*(1-od.Discount))
FROM Customers c
    JOIN Orders o ON c.CustomerID = o.CustomerID
        JOIN OrderDetails od ON o.OrderID=od.OrderID
            GROUP BY c.Country

-- 20. Siparişleri, sipariş tarihine göre yıllar ve aylar bazında gruplayarak toplam satış tutarlarını listeleyin.
SELECT
YEAR(o.OrderDate) AS [Yıl],MONTH(o.OrderDate) AS [Ay],
 SUM(od.Quantity*od.UnitPrice*(1-od.Discount)) AS   [Satış Tutarı]
FROM Orders o JOIN OrderDetails od ON o.OrderID = od.OrderID
GROUP BY o.OrderDate
ORDER BY YEAR(o.OrderDate) , MONTH(o.OrderDate) 




























