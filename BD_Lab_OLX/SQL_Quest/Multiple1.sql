--Find the names and descriptions of all categories that have products with prices greater than the average price of products in those categories:
SELECT C.Name
FROM Categories C
WHERE EXISTS (
    SELECT 1
    FROM Product P
    WHERE P.CategoryId = C.Id AND P.Price > (
        SELECT AVG(Price)
        FROM Product
        WHERE CategoryId = C.Id
    )
);