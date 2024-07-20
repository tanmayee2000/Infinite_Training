---ASSIGNMENT-4---

use Assignment2

--1. Write a T-SQL Program to find the factorial of a given number.

     Begin

      declare @number int
      declare @factorial int=1
      declare @i int =1

	  set @number = 10

      while @i <= @number
       begin
        set @factorial = @factorial * @i
        set @i = @i + 1
       end
     
	 print 'Factorial of ' + cast(@number as nvarchar(10)) + ' : ' + cast(@factorial as nvarchar(20));
     End

--------------------------------------------------------------------------------------------------------------------
--2. Create a stored procedure to generate multiplication that accepts a number and generates up to a given number. 

	 create or alter procedure MultiplicationTable(@num int, @upto_num int)
     as 
     begin
      declare @i int=1
      while @i <= @upto_num
	  begin
	    print cast(@num as varchar(10)) + ' x ' + cast(@i as varchar(10)) + ' = ' + cast(@num * @i as varchar(10))
	    set @i = @i + 1
	  end
     end

     exec MultiplicationTable 5,7

---------------------------------------------------------------------------------------------------------------------
      
--3. Create a trigger to restrict data manipulation on EMP table during General holidays. 
--   Display the error message like “Due to Independence day you cannot manipulate data” or "Due To Diwali", you cannot manipulate" etc.
--   Note: Create holiday table as (holiday_date,Holiday_name) store at least 4 holiday details. Try to match and stop manipulation. 

select * from EMP

create table holiday (
holiday_date date primary key,
holiday_name varchar(50) not null
)

insert into holiday values ('2024-08-15', 'Independence Day'),
('2024-10-27', 'Diwali'),
('2024-12-25', 'Christmas'),
('2025-01-01', 'New Year')

select * from holiday

