create database BAN_HANG
GO
USE BAN_HANG
GO

CREATE TABLE USERS 
(
	ID INT PRIMARY KEY NOT NULL,
	URNAME NVARCHAR(50) NOT NULL,
	PHONE VARCHAR(30) ,
	USERNAME NVARCHAR(50) NOT NULL,
	URPASSWORD NVARCHAR(50) NOT NULL,
	ABOUT NVARCHAR(50),
	URROLE NVARCHAR(50),
	FAVOURITE NVARCHAR(30)
)

INSERT INTO USERS VALUES(0, 'ADMIN', '0984', 'ADMIN', 'ADMIN', 'QUAN LY', 'ROLE_ADMIN', 'CODE')
INSERT INTO USERS VALUES(1, 'ASSIST', '0123', 'ASSIST', 'ASSIST', 'PHU TRO', 'ASSIST','' )
INSERT INTO USERS VALUES(3, 'THANH', '4567', 'THANH03', 'THANH03', 'KHACH HANG' ,'','')
INSERT INTO USERS VALUES(5, 'SANG', '789', 'SANG', 'SANG' ,'','','')

