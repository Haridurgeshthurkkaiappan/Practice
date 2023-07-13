/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [EmpId]
      ,[FirstName]
      ,[LastName]
  FROM [Employee].[dbo].[EmployeeRegisters]