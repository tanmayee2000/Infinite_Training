create database Employee_Management

use Employee_Management

--Table
Create Table Employee_Details (
    Emp_no int Primary Key,
    Emp_Name Varchar(50) Not null,
    Emp_Sal Numeric(10,2) CHECK (Emp_Sal >= 25000),
    Emp_Type char(1) CHECK (Emp_Type in ('F', 'P'))
)

Select * From Employee_Details


--Procedure
Create or alter proc sp_Add_Emp_Details (@emp_name Varchar(50), @emp_sal Numeric(10,2), @emp_type char(1))
as
Begin
  Declare @gen_emp_no int

  Select @gen_emp_no = case
                       when max(Emp_no) is null then 0
					   else 
					   max(Emp_no)
					   end
  From Employee_Details
  set @gen_emp_no = @gen_emp_no + 1

  Insert into Employee_Details Values (@gen_emp_no, @emp_name, @emp_sal, @emp_type)
End

--Checking the Procedure
execute sp_Add_Emp_Details 'Tanmayee', 33000, 'F'

Select * From Employee_Details
-----------------------------------------------------------------------------------------------------------------
--Displaying After Inserting through ADO Methods

Select * From Employee_Details


