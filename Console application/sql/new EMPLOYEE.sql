/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [EmpId]
      ,[FirstName]
      ,[LastName]
      ,[Age]
      ,[Email]
  FROM [Employee].[dbo].[EmployeeRegister]
