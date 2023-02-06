USE [APICms]
GO
/****** Object:  StoredProcedure [dbo].[SP_RegisterInsert]    Script Date: 06/02/2023 15:38:22 ******/
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
    @Gender INT,
    @Phone VARCHAR(MAX),
	@RoleId INT,
	@Departments_Id INT
AS
BEGIN
    INSERT INTO Employees(NIK, FirstName, LastName, Email, BirthDate, Gender, Phone, Departments_Id)
    VALUES (
        @NIK,
		@FirstName,
		@LastName,
        @Email,
        @BirthDate,
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