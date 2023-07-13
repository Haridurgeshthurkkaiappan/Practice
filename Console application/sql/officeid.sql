Create table Register
(

EmpId Int not null,
FirstName varchar(500) not null,
LastName nvarchar(500) not null,
Age nvarchar(500) not null,
Email nvarchar(100) null

)
insert into Register values (101,'hari','durgesh',21,'haridurgesh@gmail.com'),
 (102,'hari 1','durgesh 1',21,'haridurgesh1@gmail.com'),
  (103,'hari 2','durgesh 2',21,'haridurgesh2@gmail.com'),
   (104,'hari 3','durgesh 3',21,'haridurgesh3@gmail.com')

   select * from Register

   --Create,Alter, Drop and Truncate

   --Alter

--adding new column

--select * from Register
--Alter table Register
--add Phonenumber bigint not null default(0)


--remove exisiting column

--Alter table Register
--drop column lastname

--modify the DataType

--Alter table Register
--alter column phonenumber int null

--truncate
truncate table Register
--Drop
drop table Register

--Data Manipulation Query Language
--Select
insert into Register values (101,'hari',21,'haridurgesh@gmail.com',123456789),
(102,'hari 1',21,'haridurgesh1@gmail.com',5784358),
  (103,'hari 2',21,'haridurgesh2@gmail.com',78465),
   (104,'hari 3',21,'haridurgesh3@gmail.com',75986)


  --Logical OPerator

select * from Register where
Email='haridurgesh@gmail.com' and firstName='hari'


select * from Register where
Email='haridurgesh2@gmail.com' or firstName='hari'

-- Not in
select * from Register where EmpId not in (101,103)

select * from Register where EmpId!=101 and EmpId!=103

-- in
select * from Register where EmpId  in (104)

--between
select * from Register where EmpId between 100 and 130
--like

select * from Register where Email like '%i%'
select * from Register where firstName like '_a_'

--Distinct

select distinct firstname from Register

