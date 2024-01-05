CREATE DATABASE Kehadiran;

CREATE TABLE User_Table
(
	User_ID INT IDENTITY(1, 1),
	User_Name VARCHAR(150) UNIQUE,
	User_Pass VARCHAR(150),
	User_Pho VARCHAR(55),
	User_CNIC VARCHAR(55) UNIQUE,
	User_DOB VARCHAR(50),
	User_Gender VARCHAR(20),
	User_Email VARCHAR(30),
	User_Role VARCHAR(5),
	User_ADD VARCHAR(150),
	CONSTRAINT User_Table_PK PRIMARY KEY (User_ID)
);

INSERT INTO User_Table VALUES
	('user', '12345', '+11 111 1111111', '11111-111111-1', '09/18/2021', 'Laki-Laki', 'user@gmail.com', 'User', 'Indonesia'),
	('admin', '12345678', '+11 111 1111111', '11111-111111-1', '12/18/2021', 'Perempuan', 'admin@gmail.com', 'Admin', 'Malaysia');