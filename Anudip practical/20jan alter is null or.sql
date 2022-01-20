--create procedure

create procedure pro_emp 
AS 
BEGIN
SELECT 
empname,empcity,empphno
FROM emp
order by empname asc;
end;

--using is null or

ALTER PROCEDURE pro_emp(
@min_empsal AS DECIMAL = 0
,@max_empsal AS DECIMAL = NULL
,@name AS VARCHAR(max)
)
AS
BEGIN
SELECT
empname,
empsal
FROM
emp
WHERE
empsal >= @min_empsal AND
(@max_empsal IS NULL OR empsal <= @max_empsal) AND
empname LIKE '%' + @name + '%'
ORDER BY
empsal;
END;

--execute
EXECUTE pro_emp
@min_empsal = 1000,
@name = 'qwe';