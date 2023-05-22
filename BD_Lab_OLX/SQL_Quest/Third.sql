--Retrieve the names of all users who have placed an order with a specific payment method:
SELECT u.Name
FROM Users u
JOIN Orders o ON u.Id = o.UsersId
JOIN Payment pay ON o.PaymentId = pay.Id
WHERE pay.Name = '@Bank';