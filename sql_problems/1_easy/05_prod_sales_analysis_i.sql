/*
Table: Sales
+-------------+-------+
| Column Name | Type  |
+-------------+-------+
| sale_id     | int   | PK
| product_id  | int   | FK
| year        | int   |
| quantity    | int   |
| price       | int   |
+-------------+-------+

Table: Product 
+--------------+---------+
| Column Name  | Type    |
+--------------+---------+
| product_id   | int     | PK
| product_name | varchar |
+--------------+---------+

Report the product_name, year and price for each sale_id in the "Sales" table
*/

SELECT p.product_name, s.year, s.price
FROM Sales as s
LEFT JOIN Product as p 
ON s.product_id = p.product_id