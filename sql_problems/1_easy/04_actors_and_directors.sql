/*
Table: ActorDirector
+-------------+---------+
| Column Name | Type    |
+-------------+---------+
| actor_id    | int     |
| director_id | int     |
| timestamp   | int     |
+-------------+---------+

Write a solution to find all the pairs (actor_id, director_id)
where the actor has cooperated with the director at least three times.
*/

SELECT actor_id,
    director_id
FROM ActorDirector
GROUP BY actor_id, director_id
HAVING count(timestamp) >= 3