--Find the names of all categories that have at least one product with a price less than u want:
SELECT Name
FROM Categories
WHERE EXISTS (
    SELECT 1
    FROM Product
    WHERE CategoryId = Categories.Id AND Price < @Price
);