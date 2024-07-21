--- ASSIGNMENT-5 ---
use Functions
select * from Emptable
-------------------------------------------

create or alter proc Generate_PaySlip(@Empid int)
as 
begin
declare @empname varchar(30), @salary float, @HRA float, @DA float, @PF float,
@IT float, @deductions float, @gross_salary float, @net_salary float

select @empname = empname, @salary = salary from Emptable where Empid = @empid

set @HRA = @salary * 0.1
set @DA = @salary * 0.2
set @PF = @salary * 0.08
set @IT = @salary * 0.05
set @deductions = @PF + @IT
set @gross_salary = @salary + @HRA + @DA
set @net_salary = @gross_salary - @deductions

print'Employee ID : ' + cast(@empid AS varchar(10))
print'Employee Name : ' + @empname
print'Salary : ' + cast(@salary as varchar(10))

print'----------------------- Payslip -------------------------'

print 'HRA[10%] = ' + cast(@HRA as varchar(10))
print 'DA[20%] = ' + cast(@DA as varchar(10))
print 'PF[8%] = ' + cast(@PF as varchar(10))
print 'IT[5%] = ' + cast(@IT as varchar(10))
print 'Deductions = ' + cast(@deductions as varchar(10))
print 'Gross Salary = ' + cast(@gross_salary as varchar(10))
print 'Net Salary = ' + cast(@net_salary as varchar(10))

end

Generate_PaySlip 111