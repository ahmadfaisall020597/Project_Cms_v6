USE [APICms]
GO
/****** Object:  StoredProcedure [dbo].[SP_RegisterInsert]    Script Date: 13/02/2023 14:35:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER   PROCEDURE [dbo].[SP_RegisterInsert]
    @NIK VARCHAR(MAX),
    @FirstName VARCHAR(MAX),
	@LastName VARCHAR(MAX),
    @Password VARCHAR(MAX),
    @Email VARCHAR(MAX),
    @BirthDate DATETIME2(7),
	@Salary INT,
    @Gender INT,
    @Phone VARCHAR(MAX),
	@RoleId INT,
	@Departments_Id INT
AS
BEGIN
    INSERT INTO Employees(NIK, FirstName, LastName, Email, BirthDate, Salary, Gender, Phone, Departments_Id)
    VALUES (
        @NIK,
		@FirstName,
		@LastName,
        @Email,
        @BirthDate,
		@Salary,
        @Gender,
        @Phone,
		@Departments_Id
    )

    INSERT INTO Accounts(NIK, Password)
    VALUES (
        @NIK,
        @Password
    )

	INSERT INTO AccountRoles(RoleId, AccountNIK)
    VALUES (
        @RoleId,
        @NIK
    )

END;