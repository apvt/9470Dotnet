--create proc
create procedure pro_emp 
AS 
BEGIN
SELECT 
empname,empcity,empphno
FROM emp
order by empname asc;
end;

--using declare
DECLARE @empid SMALLINT;
SET @empid = '4';
SELECT
empname,
empcity,
empphno
FROM
emp
WHERE
empid = @empid
ORDER BY
empname;