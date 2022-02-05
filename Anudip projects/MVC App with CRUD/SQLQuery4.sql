Create procedure [dbo].[AddNewEmpDetails]  
(  
	@Id int, 
   @Name varchar (50),  
   @City varchar (50),  
   @Address varchar (50)  
)  
as  
begin  
   Insert into Employee1 values(@Id,@Name,@City,@Address)  
End


Create procedure [dbo].[GetEmployees] 
as 
begin 
 select * from Employee1 
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
 Update Employee1 
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
 Delete from Employee1 where Id=@EmpId 
End

select * from Employee1