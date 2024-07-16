create database Assignment2


--Department Table
Create Table DEPT (
    Deptno int primary key, 
    Dname varchar(20) not null, 
    Loc varchar(20) not null
);

Insert into DEPT Values(10,'ACCOUNTING','NEW YORK'),
                       (20,'RESEARCH','DALLAS' ),
					   (30,'SALES','CHICAGO'),
					   (40,'OPERATIONS','BOSTON')

Select * from DEPT


--Employee Table
Create Table EMP (
    EmpNo int primary key,
    EName varchar(50) not null,
    Job varchar(50),
    Mgr_id int,
    HireDate date,
    Sal float,
    Comm float,
    Deptno int
);

Insert into EMP Values(7369,'SMITH','CLERK',7902,'17-DEC-80',800,null, 20),
                      (7499,'ALLEN','SALESMAN',7698,'20-FEB-81',1600,300,30),
					  (7521,'WARD','SALESMAN',7698,'22-FEB-81',1250,500,30),
					  (7566,'JONES','MANAGER',7839,'02-APR-81',2975,null,20),
					  (7654,'MARTIN','SALESMAN',7698,'28-SEP-81',1250,1400,30),
					  (7698,'BLAKE','MANAGER',7839,'01-MAY-81',2850,null,30),
					  (7782,'CLARK','MANAGER',7839,'09-JUN-81',2450,null,10),
					  (7788,'SCOTT','ANALYST',7566,'19-APR-87',3000,null,20),
					  (7839,'KING','PRESIDENT',null,'17-NOV-81',5000,null,10),
					  (7844,'TURNER','SALESMAN',7698,'08-SEP-81',1500,0,30),
					  (7876,'ADAMS','CLERK',7788,'23-MAY-87',1100,null,20),
					  (7900,'JAMES','CLERK',7698,'03-DEC-81',950,null,30),
					  (7902,'FORD','ANALYST',7566,'03-DEC-81',3000,null,20),
					  (7934,'MILLER','CLERK',7782,'23-JAN-82',1300,null,10)

Select * from EMP


--QUERIES

--1. List all employees whose name begins with 'A'. 

  Select * from EMP where EName like 'A%'


--2. Select all those employees who don't have a manager. 

  Select * from EMP where Mgr_id IS NUll


--3. List employee name, number and salary for those employees who earn in the range 1200 to 1400. 

  Select EmpNo as 'Employee Number', EName as 'Employee Name', Sal as 'Salary' 
  From EMP where Sal between 1200 and 1400


--4. Give all the employees in the RESEARCH department a 10% pay rise. Verify that this has been done by listing 
--   all their details before and after the rise. 

  -- Before the pay rise
  Select * From EMP Where Deptno = 20

  -- 10% pay rise
  Update EMP
  Set Sal = Sal * 1.1
  Where Deptno = 20

  -- After the pay rise
  Select * From EMP Where Deptno = 20


--5. Find the number of CLERKS employed. Give it a descriptive heading. 

  Select Count(EmpNo) as 'Number Of Clerks' from EMP where Job = 'CLERK'


--6. Find the average salary for each job type and the number of people employed in each job. 

  Select Job, AVG(Sal) as "Average Salary", 
  COUNT(*) as "Number of Employees"
  From EMP
  Group By Job


--7. List the employees with the lowest and highest salary. 

  Select * From EMP where Sal = (Select max(Sal) from EMP) 
                       or Sal = (Select min(Sal) from EMP)


--8. List full details of departments that don't have any employees. 

  Select d.* 
  From DEPT d 
  left join EMP e on d.Deptno = e.Deptno
  where e.EmpNo is Null


--9. Get the names and salaries of all the analysts earning more than 1200 who are based in department 20. 
--   Sort the answer by ascending order of name. 

  Select EName as 'Employee Name', Sal as 'Salary' 
  From EMP where Job = 'ANALYST' and Sal > 1200 and Deptno = 20
  Order By EName Asc


--10. For each department, list its name and number together with the total salary paid to employees in that department. 

  Select d.Deptno, d.Dname, Sum(e.Sal) as 'Total Salary paid by the Department' 
  From DEPT d 
  Left Join EMP e on d.Deptno = e.Deptno
  Group By d.Deptno, d.Dname


--11. Find out salary of both MILLER and SMITH.

  Select EName as 'Employee Name', Sal as 'Salary' 
  From EMP
  Where EName in ('MILLER','SMITH')


--12. Find out the names of the employees whose name begin with ‘A’ or ‘M’. 

  Select EName as 'Employees name starting with "A" or "M"' 
  From EMP
  Where EName like 'A%' or EName like 'M%'


--13. Compute yearly salary of SMITH. 

  Select EName as 'Employee Name', Sal * 12 as 'Annual Salary' 
  From EMP where EName = 'SMITH'

--14. List the name and salary for all employees whose salary is not in the range of 1500 and 2850.
  
  Select EName as 'Employee Name', Sal as 'Salary' 
  From EMP 
  Where Sal not between 1200 and 1400


--15. Find all managers who have more than 2 employees reporting to them.
  
