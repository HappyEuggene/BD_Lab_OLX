--Find the names of users who have a product price of less than you want
SELECT DISTINCT u.Name AS UserName, p.Name AS ProductName, p.Price
FROM Users u
JOIN Orders o ON u.Id = o.UsersId
JOIN OrdersProduct op ON o.Id = op.OrdersId
JOIN Product p ON op.ProductId = p.Id
WHERE p.Price < @Price;