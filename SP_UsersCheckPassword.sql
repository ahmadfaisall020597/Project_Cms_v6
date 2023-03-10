USE [APICms]
GO
/****** Object:  StoredProcedure [dbo].[SP_UsersCheckPassword]    Script Date: 06/02/2023 15:22:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[SP_UsersCheckPassword] @Email VARCHAR(MAX)
AS
BEGIN
    SELECT a.NIK, a.Password
	FROM Employees e
	LEFT JOIN Accounts a ON a.NIK = e.NIK
	WHERE e.Email = @Email
END