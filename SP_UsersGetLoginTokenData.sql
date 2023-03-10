USE [APICms]
GO
/****** Object:  StoredProcedure [dbo].[SP_UsersGetLoginTokenData]    Script Date: 06/02/2023 15:38:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[SP_UsersGetLoginTokenData] @NIK VARCHAR(MAX)
AS
BEGIN
    SELECT a.NIK, e.Email, r.Id as RoleId, r.Name as RoleName
    FROM Accounts a
    LEFT JOIN Employees e ON e.NIK = a.NIK
	LEFT JOIN AccountRoles ar ON ar.AccountNIK = a.NIK
    LEFT JOIN Roles r ON r.Id = ar.RoleId
    WHERE a.NIK = @NIK
END