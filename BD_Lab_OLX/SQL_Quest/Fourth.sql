--Retrieve the names of users and products, the names of users  who have placed orders for products in categories with the highest average price:
SELECT DISTINCT u.Name AS UserName, p.Name AS ProductName
FROM Users u
JOIN Orders o ON u.Id = o.UsersId
JOIN OrdersProduct op ON o.Id = op.OrdersId
JOIN Product p ON op.ProductId = p.Id
JOIN Categories c ON p.CategoryId = c.Id
WHERE c.Id IN (
    SELECT c2.Id
    FROM Categories c2
    JOIN Product p2 ON c2.Id = p2.CategoryId
    GROUP BY c2.Id
    HAVING AVG(p2.Price) = (
        SELECT MAX(avg_price)
        FROM (
            SELECT AVG(p3.Price) AS avg_price
            FROM Categories c3
            JOIN Product p3 ON c3.Id = p3.CategoryId
            GROUP BY c3.Id
        ) subquery
    )
);