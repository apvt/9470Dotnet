Create procedure [dbo].[AddNewEmpDetails]  
(  
   @Id int, 
   @Name varchar (50),  
   @City varchar (50),  
   @Address varchar (50)  
)  
as  
begin  
   Insert into Employee values(@Id,@Name,@City,@Address)  
End


Create procedure [dbo].[GetEmployees] 
as 
begin 
 select * from Employee 
End


Create procedure [dbo].[UpdateEmpDetails] 
( 
 @Id int, 
 @Name varchar (50), 
 @City varchar (50), 
 @Address varchar (50) 
) 
as 
begin 
 Update Employee 
 set Name=@Name, 
 City=@City, 
 Address=@Address 
 where Id=@Id 
End


Create procedure [dbo].[DeleteEmpById] 
( 
 @EmpId int 
) 
as 
begin 
 Delete from Employee where Id=@EmpId 
End

select * from Employee