--create procedure

create procedure pro_emp 
AS 
BEGIN
SELECT 
empname,empcity,empphno
FROM emp
order by empname asc;
end;

--execute
execute pro_emp;

exec dbo.pro_emp;

--alter 
ALTER PROCEDURE pro_emp
AS
BEGIN
SELECT
empname,empcity,empsal
FROM
emp
WHERE
empsal=20000;
END;

select * from proc_emp;
