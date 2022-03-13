--Backup the database
BACKUP DATABASE NCS2020
TO DISK= 'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\Backup\NCS2020DDL.bak'
GO

--Restore the database
RESTORE DATABASE NCS2020
FROM DISK= 'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\Backup\NCS2020DDL.bak'
GO