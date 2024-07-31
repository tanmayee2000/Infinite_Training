create database CC7
use CC7


--Q1. 
-- Books Table

Create Table Books(
ID int Primary Key,
Title varchar(50) Not null,
Author varchar(50) Not null,
isbn varchar(20) Unique Not null,
Published_Date Datetime
)

Insert into Books Values
(1,'My First SQL Book','Mary Parker',981483029127,'2012-02-22 12:08:17'),
(2,'My Second SQL Book','John Mayer',857300923713,'1972-07-03 09:22:45'),
(3,'My Third SQL Book','Cary Flint',523120967812,'2015-10-18 14:05:44')

select * from Books

--Query 1 : Author name ends with "er"

Select ID, Title, Author, isbn, Published_Date
From Books
Where Author Like '%er'

----------------------------------

--Reviews Table
Create Table Reviews(
ID int Primary Key,
Book_Id int not null,
Reviewer_Name varchar(50) not null,
Content varchar(50) not null,
Rating int not null,
Published_Date Datetime
)

Insert into Reviews Values
(1,1,'John Smith','My first review',4,'2017-12-10 05:50:11'),
(2,2,'John Smith','My Second Review',5,'2017-10-13 15:05:12'),
(3,2,'Alice Walker','Another Review',1,'2017-10-22 23:47:10')

select * from Reviews

--Query : Display the  reviewer name who reviewed more than one book.

Select Reviewer_Name From Reviews 
Group By Reviewer_Name Having Count(ID) > 1;

---------------------------------------------------------------------------------------


--Q2 : 
--Customer Table
Create Table Customer(
ID int Primary Key,
Name Varchar(20) not null,
Age int,
Address Varchar(200),
Salary Float
)
 
Insert into Customer Values
(1, 'Ramesh',32, 'Ahmedabad',2000.00),    
(2, 'Khilan',25, 'Delhi',1500.00),
(3, 'Kaushik',23, 'Kota',2000.00),
(4,'Chaitali',25,'Mumbai',6500.00),
(5,'Hardik',27,'Bhopal',8500.00),
(6,'Komal',22,'MP',4500.00),
(7,'Muffy',24,'Indore',10000.00)

--Display the Name for the customer from above customer table  who live in same address which has character o anywhere in address

Select Name, Address
From Customer
Where Address Like '%o%'

----------------------------------------------------------------

--ORDERS Table
Create Table ORDERS(
OID Int Primary Key,
ODATE Datetime,
CUSTOMER_ID Int not null,
AMOUNT Float,
)
 
Insert into ORDERS Values 
(102, '2009-10-08 00:00:00', 3, 3000),
(100, '2009-10-08 00:00:00', 3, 1500),
(101, '2008-05-20 00:00:00',2, 1560),
(103, '2008-05-20 00:00:00',4, 2060)

Select * from Orders

--Write a query to display the Date,Total no of customer placed order on same Date

Select ODate, Count(Customer_id) as 'Total Customers'
From ORDERS
Group By ODate

--------------------------------------------------------------------------------------------

--EMPLOYEE Table
Create Table Employee(
ID int Primary Key,
Name Varchar(20) not null,
Age int,
Address Varchar(200),
Salary Float
)

Insert into Employee Values
(1, 'Ramesh',32, 'Ahmedabad',2000.00),    
(2, 'Khilan',25, 'Delhi',1500.00),
(3, 'Kaushik',23, 'Kota',2000.00),
(4,'Chaitali',25,'Mumbai',6500.00),
(5,'Hardik',27,'Bhopal',8500.00),
(6,'Komal',22,'MP',null),
(7,'Muffy',24,'Indore',null)

Select * from Employee


--Query : Display the Names of the Employee in lower case, whose salary is null.

Select lower(Name) as 'Employee Name'
From Employee
Where Salary IS NULL

----------------------------------------------------------------------------------------------

--STUDENT DETAILS QUERY
Create Table Students (
R_No int Primary Key,
Name Varchar(100) not null,
Age int,
Qualification Varchar(50),
Mobile_no Varchar(15),
Mail_id Varchar(100),
Location Varchar(50),
Gender Char(1) not null
)
 
Insert into Students Values
(2, 'SAI', 22, 'BE', '9952836777', 'SAI@GMAIL.COM', 'CHENNAI', 'M'),
(3, 'KUMAR', 20, 'BSC', '7890125648', 'KUMAR@GMAIL.COM', 'MADURAI', 'M'),
(4, 'SELVI',  22, 'B  TECH', '8904567342', 'SELVI@GMAIL.COM', 'SELAM', 'F'),
(5, 'NISHA',  25, 'ME', '7834672310', 'NISHA@GMAIL.COM', 'THENI', 'F'),
(6, 'SAISARAN',  21, 'BA', '7890345678', 'SARAN@GMAIL.COM', 'MADURAI', 'F'),
(7, 'TOM',  23, 'BCA', '8901234675', 'TOM@GMAIL.COM', 'PUNE', 'M')

--Query : Write a sql server query to display the Gender,Total no of male and female from the above relation.
Select Gender, Count(*) as 'Total Count(Gender wise)'
From Students
Group By Gender

-----------------------------------------------------------------------------------------------