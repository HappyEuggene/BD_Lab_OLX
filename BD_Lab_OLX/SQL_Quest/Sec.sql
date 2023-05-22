--Retrieve the total revenue generated from each payment method:
SELECT u.Name, u.Email
FROM Users u
JOIN Orders o ON u.Id = o.UsersId
JOIN Delivery d ON o.DeliveryId = d.Id
WHERE d.Name = '@Delivery';