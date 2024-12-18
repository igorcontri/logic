/*

Table: Project

+-------------+---------+
| Column Name | Type    |
+-------------+---------+
| project_id  | int     | PK
| employee_id | int     | FK
+-------------+---------+

Table: Employee

+------------------+---------+
| Column Name      | Type    |
+------------------+---------+
| employee_id      | int     | PK
| name             | varchar |
| experience_years | int     |
+------------------+---------+

Write an SQL query that reports the average experience 
years of all the employees for each project, rounded to 2 digits. 

Return the result table in any order.
*/

SELECT p.project_id, ROUND(AVG(e.experience_years), 2) AS average_years
FROM Project AS p
LEFT JOIN Employee AS e
ON p.employee_id = e.employee_id
GROUP BY p.project_id