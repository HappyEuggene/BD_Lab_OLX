--Find the names and email addresses of users who have made orders with a payment option that has been used by at least two other users:
SELECT U.Name, U.Email
FROM Users U
WHERE EXISTS (
    SELECT 1
    FROM Orders O1
    INNER JOIN Payment PA ON O1.PaymentId = PA.Id
    WHERE O1.UsersId = U.Id
      AND PA.Id IN (
          SELECT PA2.Id
          FROM Orders O2
          INNER JOIN Payment PA2 ON O2.PaymentId = PA2.Id
          WHERE O2.UsersId <> U.Id
          GROUP BY PA2.Id
          HAVING COUNT(DISTINCT O2.UsersId) >= 2
      )
);