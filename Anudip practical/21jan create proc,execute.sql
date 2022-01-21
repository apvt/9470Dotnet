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

exec pro_emp;
