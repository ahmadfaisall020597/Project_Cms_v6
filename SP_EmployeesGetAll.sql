USE [APICms]
GO
/****** Object:  StoredProcedure [dbo].[SP_EmployeesGetAll]    Script Date: 15/02/2023 14:24:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[SP_EmployeesGetAll] 
AS
BEGIN
SELECT e.NIK,
(e.FirstName + ' ' + e.LastName) as 'Employees_Name',
e.phone,
e.Email,
e.BirthDate,
e.Salary,
e.Gender,
r.Name 'RoleName',
d.Name 'Department_Name',
e.Manager_Id,
(em.FirstName + ' ' + em.LastName) as 'Manager_Name'
FROM Employees e
LEFT JOIN AccountRoles a ON a.AccountNIK = e.NIK
LEFT JOIN Roles r ON r.Id = e.Departments_Id
LEFT JOIN Departments d ON d.Id = e.Departments_Id
LEFT JOIN Employees em ON em.NIK = e.Manager_Id
END;


use APICms