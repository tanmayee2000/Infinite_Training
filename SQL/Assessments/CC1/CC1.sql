use Assignment2

-- Q1. Write a query to display your birthday( day of week).

	   Select '2000-10-27' as My_Birthday;
       Select DateName(weekday, '2000-10-27') as 'Day of BirthDate'

-----------------------------------------------------------------------------------------------------------------------------------

-- Q2. Write a query to display your age in days.
       
	   Select '23' as 'Age(In Years)'
	   Select datediff(day, '2000-10-27', getdate()) as 'Age(In Days)'

------------------------------------------------------------------------------------------------------------------------------------

-- Q3.	Write a query to display all employees information those who joined before 5 years in the current month.
--     (Hint : If required update some HireDates in your EMP table of the assignment)
       
	   Update EMP Set HireDate = '2020-07-24' where Empno= 7369 
	   Update EMP Set HireDate = '2019-07-11' where EName='ALLEN' 
	   Update EMP Set HireDate = '2015-07-01' where EName='WARD'

       Select * From EMP
       Where datediff(yy, HireDate, getdate()) >= 5
         and month(HireDate) = month(getdate())

-------------------------------------------------------------------------------------------------------------------------------------

-- Q4. Create table Employee with empno, ename, sal, doj columns and perform the following operations in a single transaction
	 --a. First insert 3 rows 
	 --b. Update the second row sal with 15% increment  
     --c. Delete first row.
     --After completing above all actions how to recall the deleted row without losing increment of second row.

	 Create Table Employee (
            EmpNo int PRIMARY KEY,
            EName varchar(50),
            Sal float,
            DOJ DATE )
	 
	 Begin transaction
	 --a. First insert 3 rows
     Insert into Employee Values (111, 'Tanmayee', 25000, '2024-05-30'),
                                 (222, 'Raghu', 26000, '2024-06-07'),
                                 (333, 'Jahnavi', 20000, '2024-05-30')

     -- b. Update the second row sal with 15% increment
     Update Employee Set Sal = Sal * 1.15
     where Empno = 222
	 
	 save tran t1

     -- c. Delete first row
     Delete From Employee  
     where empno = 111

	 --Recalling the deleted row without losing increment of second row.
	 rollback tran t1
     Commit

	 Select * from Employee

-----------------------------------------------------------------------------------------------------------------------

-- Q5. Create a user defined function calculate Bonus for all employees of a  given job using 	following conditions
--  a. For Deptno 10 employees 15% of sal as bonus.
--	b. For Deptno 20 employees  20% of sal as bonus
--	c. For Others employees 5%of sal as bonus

	   create or alter function fn_Salary_Bonus(@Deptno int)
       returns float
       as
       begin
         declare @bonus float

            if @Deptno = 10
             Set @bonus = 0.15;  -- 15% bonus - Deptno 10

            else if @Deptno = 20
             Set @bonus = 0.20;  -- 20% bonus - Deptno 20

            else
             Set @bonus = 0.05;  -- 5% bonus - others
            Return @bonus;
       end

	   Select Empno as'EmployeeID', EName as 'Emp Name', Sal as 'Salary', Deptno as 'Dept No',
       Sal * dbo.fn_Salary_Bonus(Deptno) as 'Bonus'
       From EMP 
    
----------------------------------------------------------------------------------------------------------------------------------
Select * from EMP
Select * from DEPT
