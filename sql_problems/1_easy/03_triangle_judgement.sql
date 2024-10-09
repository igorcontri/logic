/*

Table: Triangle
+-------------+------+
| Column Name | Type |
+-------------+------+
| x           | int  |
| y           | int  |
| z           | int  |
+-------------+------+

The sum of the lengths of any two sides must be greater than the length of the third side to form a triangle.

Report for every three line segments whether they can form a triangle.
*/


SELECT 
    x,
    y,    
    z,
    CASE
        WHEN (x + y) > z
            AND (x + z) > y
            AND (z + y) > x
        THEN 'Yes'
        ELSE 'No'
    END AS triangle
FROM Triangle;
