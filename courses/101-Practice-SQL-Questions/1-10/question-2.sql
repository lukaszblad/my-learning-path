-- QUESTION 2
-- a. Write a SQL Statement that will show a count of schemas, tables, and columns
-- (do not include views) in the AdventureWorks database.

SELECT
    COUNT(DISTINCT t.name) AS TableName,
    COUNT(DISTINCT s.name) AS SchemaName,
    COUNT(c.name) AS ColumnName
FROM sys.tables t
JOIN sys.columns c
    ON t.object_id = c.object_id
JOIN sys.schemas s
    ON t.schema_id = s.schema_id;

-- b. Write a similar statement as part a but list each schema, table, and column
-- (do not include views). This table can be used later in the course.

SELECT
    t.name AS TableName,
    s.name AS SchemaName,
    c.name AS ColumnName
FROM sys.tables t
JOIN sys.columns c
    ON t.object_id = c.object_id
JOIN sys.schemas s
    ON t.schema_id = s.schema_id;
