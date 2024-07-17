use Assignment2

select * from EMP 

--1. Retrieve a list of MANAGERS. 

     Select * From EMP 
     where Job = 'Manager'
  ----------------------------------------------------------------------------------------
--2. Find out the names and salaries of all employees earning more than 1000 per 
--   month.

     Select EName as 'Employee Name', Sal as 'Salary'
     From EMP
     Where Sal > 1000
  ----------------------------------------------------------------------------------------
--3. Display the names and salaries of all employees except JAMES. 
    
	 Select EName as 'Employee Name', Sal as 'Salary'
     From EMP
     Where EName != 'JAMES'
  ----------------------------------------------------------------------------------------
--4. Find out the details of employees whose names begin with ‘S’. 
  
     Select * From EMP where EName like 'S%'
  ----------------------------------------------------------------------------------------
--5. Find out the names of all employees that have ‘A’ anywhere in their name. 
  
     Select EName as 'Employee Name' From EMP where EName like '%A%'
  ----------------------------------------------------------------------------------------
--6. Find out the names of all employees that have ‘L’ as their third character in 
--   their name. 
   
     Select EName as 'Employee Name' From EMP where EName like '__L%'
  ----------------------------------------------------------------------------------------
--7. Compute daily salary of JONES.

     Select EName as 'Employee Name', Sal as 'Salary', Sal/30 as 'Daily Salary' 
     From EMP where EName = 'JONES'
  ----------------------------------------------------------------------------------------
--8. Calculate the total monthly salary of all employees. 
    
     Select SUM(Sal) as 'Total Salary of all Employees per Month' From EMP
  ----------------------------------------------------------------------------------------
--9. Print the average annual salary.

     Select Avg(Sal*12) as 'Avg annual salary' from EMP
  ----------------------------------------------------------------------------------------
--10. Select the name, job, salary, department number of all employees except 
--    SALESMAN from department number 30. 

      Select EName as 'Employee Name', Job as 'Job', Sal as 'Salary', Deptno as 'Dept No.'  
      From EMP where Job != 'SALESMAN' and Deptno != 30 
  ----------------------------------------------------------------------------------------
--11. List unique departments of the EMP table.
   
      Select distinct Dname as 'Unique Dept', emp.Deptno 
	  From DEPT 
	  join EMP on emp.Deptno = dept.Deptno
  ----------------------------------------------------------------------------------------
--12. List the name and salary of employees who earn more than 1500 and are in department 10 or 30. 
--    Label the columns Employee and Monthly Salary respectively.

      Select EName as 'Employee', Sal as 'Monthly Salary' from EMP 
	  where Sal > 1500 and Deptno in (10,30)
  ----------------------------------------------------------------------------------------
--13. Display the name, job, and salary of all the employees whose job is MANAGER or 
--    ANALYST and their salary is not equal to 1000, 3000, or 5000. 

      Select EName as 'Emp Name', Job as 'Job', Sal as 'Salary' 
	  From EMP 
	  where (Job like'MANAGER' or Job like 'ANALYST') and (Sal!=1000 or Sal!=3000 or Sal!=5000)
  ----------------------------------------------------------------------------------------
--14. Display the name, salary and commission for all employees whose commission 
--    amount is greater than their salary increased by 10%. 

	  Select EName as 'Emp Name', Sal as 'Salary',Comm as 'Commission' 
	  From EMP
      where Comm > Sal + (Sal*0.1)
  ----------------------------------------------------------------------------------------
--15. Display the name of all employees who have two Ls in their name and are in 
--    department 30 or their manager is 7782. 

      Select Empno as 'Employee ID', EName as 'Employee Name', Deptno as 'Dept No.', Mgr_id as 'Manager Id' 
	  From EMP
      where EName like '%L%L%' and Deptno = 30 or Mgr_id = 7782
  ----------------------------------------------------------------------------------------
--16. Display the names of employees with experience of over 30 years and under 40 yrs.
--    Count the total number of employees.

      Select EName as 'Employee Name', datediff(yy,HireDate,getdate()) as 'Years of Experience' 
	  From EMP
      where datediff(yy,HireDate,getdate()) between 30 and 40
	  --Count
	  Select Count(*) as 'Count' 
	  From EMP
      where datediff(yy,HireDate,getdate()) between 30 and 40

	  --or another way 
	  Select EName as 'Emp Name', (year(getdate()) -year(HireDate)) as 'Years of Experience' 
	  From EMP 
	  where (year(getdate())-year(HireDate))>30 
        and (year(getdate())-year(HireDate))<40
  ----------------------------------------------------------------------------------------
--17. Retrieve the names of departments in ascending order and their employees in 
--    descending order. 
      
	  Select d.Dname as 'Department', e.Empno as 'EmployeeID',e.EName as 'Employee Name' 
	  From DEPT d 
	  join 
	  EMP e on d.Deptno = e.Deptno
      Order By d.Dname asc, e.EName desc
  ----------------------------------------------------------------------------------------
--18. Find out experience of MILLER. 

	  Select EName as 'Employee', datediff(yy,HireDate,getdate()) as 'Years of Experience' 
	  From EMP
      where EName = 'MILLER'

	  --or
	  Select EName as 'Employee', year(getdate())-year(hiredate) as 'Years of Experience' 
	  From emp 
	  where EName like 'MILLER'
  ----------------------------------------------------------------------------------------