--Get the details of all orders along with the associated user and delivery information:
SELECT u.Name AS UserName, d.Name AS DeliveryName, d.Description AS DeliveryDescription
FROM Orders o
LEFT JOIN Users u ON o.UsersId = u.Id
LEFT JOIN Delivery d ON o.DesliveryId = d.Id;