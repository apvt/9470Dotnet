--create procedure

create procedure pro_emp 
AS 
BEGIN
SELECT 
empname,empcity,empphno
FROM emp
order by empname asc;
end;

--using like
ALTER PROCEDURE pro_emp(
@min_empsal AS DECIMAL
,@max_empsal AS DECIMAL,
@name AS VARCHAR(max)
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
empsal <= @max_empsal AND
empname LIKE '%' + @name + '%'
ORDER BY
empsal;
END;

--execute
EXECUTE pro_emp
@min_empsal = 20000,
@max_empsal = 50000,
@name = 'abc';
