-- 1. Hiç sipariş vermemiş müşterileri listeleyin.
SELECT 
c.CustomerID, COUNT( o.OrderID)
FROM Customers c 
JOIN Orders o ON c.CustomerID = o.CustomerID
WHERE o.CustomerID = NULL
GROUP BY c.CustomerID


-- 2. Her bir ürün için, o ürünü sipariş eden benzersiz müşteri sayısını bulun.
SELECT 
 p.ProductID,p.ProductName ,COUNT(DISTINCT o.CustomerID) AS [Benzersiz Müşteri Sayısı]
FROM Products p 
JOIN OrderDetails od ON p.ProductID = od.ProductID
    JOIN Orders o ON o.OrderID = od.OrderID
        JOIN Customers c ON c.CustomerID = o.CustomerID

        GROUP BY p.ProductID,p.ProductName
  
-- 3. Çalışanların yöneticilerini (FirstName ve LastName) listeleyin. Yöneticisi olmayan çalışanlar da listelenmelidir.
SELECT e.FirstName+ ' ' + e.LastName AS [Çalışan Ad-Soyad],
e.ReportsTo AS [Yönetici ID]
FROM Employees e 
ORDER BY 
[Çalışan Ad-Soyad]



-- 4. Her bir tedarikçinin sağladığı ürünlerin ortalama fiyatını hesaplayın, ancak sadece 10'dan fazla ürün sağlayan tedarikçileri listeleyin.
SELECT
s.SupplierID,
s.CompanyName,
AVG(p.UnitPrice) AS [Ortalama Fiyat],
 COUNT(p.ProductID) AS [Ürün Sayısı]

FROM Suppliers s 
JOIN Products p ON s.SupplierID=p.SupplierID
GROUP BY s.SupplierID,s.CompanyName
HAVING 
COUNT(p.ProductID) > 10;





-- 5. En az 3 farklı kategoriden ürün sipariş etmiş müşterileri bulun.
SELECT 
    c.CustomerID,
    c.CompanyName,
    COUNT(DISTINCT p.CategoryID) AS [Farklı Kategori Sayısı]
FROM 
    Customers c
JOIN 
    Orders o ON c.CustomerID = o.CustomerID
JOIN 
    OrderDetails od ON o.OrderID = od.OrderID
JOIN 
    Products p ON od.ProductID = p.ProductID
GROUP BY 
    c.CustomerID, c.CompanyName
HAVING 
    COUNT(DISTINCT p.CategoryID) >= 3;




-- 6. Her bir çalışanın sorumlu olduğu bölgedeki (Territory) toplam satış miktarını hesaplayın.
SELECT
e.EmployeeID,
e.FirstName + ' ' + e.LastName AS [Çalışan Adı],
et.TerritoryID,
SUM(od.Quantity*od.UnitPrice) AS [Toplam Satış Miktarı]
FROM Employees e 
JOIN EmployeeTerritories et ON e.EmployeeID = et.EmployeeID
JOIN Orders o ON o.EmployeeID=e.EmployeeID
JOIN OrderDetails od ON od.OrderID=o.OrderID
GROUP BY 
e.EmployeeID,
e.FirstName,
e.LastName,
et.TerritoryID




-- 7. 1997 yılının en yüksek cirolu ayını bulun.
SELECT
TOP 1 
MONTH(o.OrderDate) AS [Ay],
SUM(od.Quantity*od.UnitPrice) [Ciro]

FROM Orders o 
JOIN OrderDetails od ON o.OrderID=od.OrderID
WHERE YEAR(o.OrderDate) = 1997
GROUP BY MONTH(o.OrderDate)
ORDER BY [Ciro] DESC




-- 8. Siparişlerin ortalama teslimat süresini (ShippedDate - OrderDate) hesaplayın ve bu ortalamadan daha uzun sürede teslim edilen siparişleri listeleyin.
WITH AverageDeliveryTime AS (
    SELECT AVG(DATEDIFF(day, OrderDate, ShippedDate)) AS AvgDeliveryTime
    FROM Orders
    WHERE ShippedDate IS NOT NULL
)


SELECT OrderID, OrderDate, ShippedDate, DATEDIFF(day, OrderDate, ShippedDate) AS DeliveryDays
FROM Orders
WHERE ShippedDate IS NOT NULL
AND DATEDIFF(day, OrderDate, ShippedDate) > (SELECT AvgDeliveryTime FROM AverageDeliveryTime);


-- 9. Aynı gün içinde birden fazla sipariş veren müşterileri ve bu siparişlerin tarihlerini listeleyin.
SELECT
CustomerID,OrderDate,
COUNT(OrderID) AS [Sipariş Sayısı]
FROM Orders 
GROUP BY CustomerID,OrderDate
HAVING COUNT(OrderID)>1

-- 10. Çalışanların yaptığı satışları yıllık bazda karşılaştırın ve her yıl için en başarılı çalışanı bulun.




-- 11. Hem 1997 hem de 1998 yıllarında sipariş vermiş müşterileri listeleyin.




-- 12. Hiç sipariş almamış çalışanları bulun (eğer varsa).




-- 13. Her bir ülke için, o ülkedeki müşterilerin verdiği siparişlerin ortalama tutarını hesaplayın, ancak sadece toplam sipariş tutarı 5000'den fazla olan ülkeleri listeleyin.




-- 14. En az 5 farklı ürün sipariş etmiş ve toplam sipariş tutarı 10000'den fazla olan müşterileri bulun.



-- 15. Her bir çalışan için, o çalışanın aldığı siparişlerin ortalama gecikme süresini hesaplayın (RequiredDate ve ShippedDate arasındaki fark).




-- 16. Ürünleri, bulundukları kategorinin ortalama fiyatına göre "Ucuz", "Ortalama" veya "Pahalı" olarak sınıflandırın.





-- 17. Her bir kargo şirketi için, taşıdıkları siparişlerin ortalama ağırlığını hesaplayın (Freight).





-- 18. En az 10 farklı müşteriye satılmış ürünleri ve bu ürünlerin satıldığı benzersiz müşteri sayısını listeleyin.





-- 19. Her bir çalışanın, her bir müşteriye yaptığı toplam satış tutarını bulun ve sadece 5000'den fazla satış yapılan müşteri-çalışan çiftlerini listeleyin.





-- 20. Her bir tedarikçinin sağladığı ürünlerin toplam satış miktarını hesaplayın ve tedarikçileri bu miktara göre sıralayın.













