create table emp(
empid int primary key not null,
empname varchar(25) not null,
empcity varchar(25) not null,
empsal varchar(25) not null,
empphno varchar(10));

insert into emp values(1,'apoorva','asd',50000,9568324175);
insert into emp values(2,'ap','avd',30000,9568324175);
insert into emp values(3,'qwe','aud',40000,9568114175);
insert into emp values(4,'fds','atd',20000,9547324175);
insert into emp values(5,'jsh','asd',10000,9568376175);

select * from emp;

--update 

update emp set empphno=2222222222 where empid=2;

--like clause
select * from emp where empphno like '2%';

--order by
select empid,empname from emp order by empid desc;

select empid,empname from emp order by empid;

--group by 
select empname,sum(empid) from emp group by empname;

--distinct(removing duplicate value)
select distinct empphno from emp order by empphno;









