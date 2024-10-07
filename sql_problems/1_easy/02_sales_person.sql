/*
Table: SalesPerson
+-----------------+---------+
| Column Name     | Type    |
+-----------------+---------+
| sales_id        | int     | PK
| name            | varchar |
| salary          | int     |
| commission_rate | int     |
| hire_date       | date    |
+-----------------+---------+

Table: Company
+-------------+---------+
| Column Name | Type    |
+-------------+---------+
| com_id      | int     | PK
| name        | varchar |
| city        | varchar |
+-------------+---------+

Table: Orders
+-------------+------+
| Column Name | Type |
+-------------+------+
| order_id    | int  |
| order_date  | date |
| com_id      | int  |
| sales_id    | int  |
| amount      | int  |
+-------------+------+

Write a solution to find the names of all the salespersons who did not have any orders related to the company with the name "RED".
Return the result table in any order.
*/

SELECT sp.name
FROM SalesPerson sp
WHERE sp.name NOT IN 
    (
        SELECT sp.name
        FROM SalesPerson sp
        LEFT JOIN Orders o ON o.sales_id = sp.sales_id
        LEFT JOIN Company c ON o.com_id = c.com_id
        WHERE c.name = "RED"
    )
