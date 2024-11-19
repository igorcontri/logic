# SQL_NOTES

### WHERE x HAVING

**WHERE:** filter rows BEFORE "GROUP BY"  
**HAVING:** filter groups AFTER "GROUP BY"

Example: I need to show sales_person with more total_sales than 10k.

    SELECT sales_person,
    SUM(total_sales)
    FROM sales
    GROUP BY sales_person
    HAVING SUM(total_sales) > 10000;

"WHERE" cannot be used in this case, because it apply a filter before grouping and I NEED to group all sales by sales_person
