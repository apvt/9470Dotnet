--create procedure

create procedure pro_emp 
AS 
BEGIN
SELECT 
empname,empcity,empphno
FROM emp
order by empname asc;
end;

--alter using min,max

ALTER PROCEDURE pro_emp(
@min_empsal AS DECIMAL
,@max_empsal AS DECIMAL
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
empsal <= @max_empsal
ORDER BY
empsal;
END;

--execute
execute pro_emp 20000,50000;