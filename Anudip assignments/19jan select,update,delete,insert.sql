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


select * from emp where empid IN (select empid from emp where empsal > 20000) ;


INSERT INTO dept SELECT * FROM emp WHERE empid IN (SELECT empid

FROM emp);
 

 UPDATE emp SET empsal = empsal * 0.25 WHERE empid IN (SELECT empid FROM emp1
 WHERE empid = 1 );
 
 
 DELETE FROM emp WHERE empcity IN (SELECT empcity FROM emp1 WHERE empcity="aud" );
 
 
