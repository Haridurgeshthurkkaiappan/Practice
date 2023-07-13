--Data Definition Query Language

--Create,Alter, Drop and Truncate

Create table Registration
(

EmpId Int not null,
FirstName varchar(500) not null,
LastName nvarchar(500) not null,
Email nvarchar(100) null

)

--Data Manipulation Query Language
--Select
Select * from Registration

Select 
	* 
from 
	Registration 
where 
	EmpId=6789

select empid,FirstName from Registration

--Insert 
insert into Registration values(10,'modric','rm','modric@gmail.com')

insert into Registration values(7,'ronaldo','al nasser','cr7@gmail.com')

insert into Registration values(8,'kroos','rm')

--Update 

update Registration 
set
FirstName ='Sourav'

update Registration 
set
 FirstName ='Dhoni',
 Email='dhoni@gmail.com'
where
 EmpId=10

 --delete

 Delete from Registration where FirstName='dhoni'

  Delete from Registration