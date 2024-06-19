-- Многие ко многие, неужели это действительно правда?
SELECT
    P.ProductName,
    C.CategoryName
FROM
    Products P
    LEFT JOIN Categories C ON P.CategoryID = C.CategoryID;