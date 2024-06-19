## Вопрос№ 2 - директория Geometry.Figures (для Unit-тестов использовался xUnit)
## Вопрос№ 3 - директория sql (для Unit-тестов использовался xUnit)
```sql
-- Многие ко многие, неужели это действительно правда?
SELECT
    P.ProductName,
    C.CategoryName
FROM
    Products P
    LEFT JOIN Categories C ON P.CategoryID = C.CategoryID;
```
