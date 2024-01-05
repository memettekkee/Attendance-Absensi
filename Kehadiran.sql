CREATE DATABASE Kehadiran;

CREATE TABLE User_Table 
(
	User_ID INT IDENTITY(1,1),
	User_Name VARCHAR(150) UNIQUE,
	User_Pass VARCHAR(150),
	User_Pho VARCHAR(20),
	User_CNIC VARCHAR(21) UNIQUE,
	User_DOB VARCHAR(10),
	User_Gender VARCHAR (15),
	User_Email VARCHAR (30),
	User_Role VARCHAR(5),
	User_Add VARCHAR(30),
	CONSTRAINT User_ID_PK PRIMARY KEY (User_ID)
);

INSERT INTO User_Table VALUES 
	('mamet', '123456', '085708570857', '21106050020', '23/08/2003', 'Laki-Laki', 'ngawur@gmail.com', 'User', 'Indonesia'),
	('admin', '123456', '085608570858', '21100000000', '17/04/1989', 'Laki-laki', 'admin@gmail.com', 'Admin', 'Indonesia');

CREATE TABLE Class_Table
(
	Class_ID INT IDENTITY(1, 1),
	Class_Name VARCHAR(150) UNIQUE,
	Class_Total INT,
	Class_Male INT,
	Class_Female INT,
	CONSTRAINT Class_Table_PK PRIMARY KEY (Class_ID)
);

CREATE TABLE Student_Table
(
	Student_ID INT IDENTITY(1, 1),
	Student_Name VARCHAR(150),
	Student_Reg VARCHAR(50) UNIQUE,
	Student_Gender VARCHAR(12),
	Class_ID INT,
	CONSTRAINT Student_Table_PK PRIMARY KEY (Student_ID),
	CONSTRAINT Student_Table_FK FOREIGN KEY (Class_ID) REFERENCES Class_Table (Class_ID) ON DELETE CASCADE
);

CREATE TABLE Attendance_Table 
(
	Attendance_ID INT IDENTITY (1,1),
	Attendance_Date VARCHAR(10),
	Attendance_Status VARCHAR(25) DEFAULT 'Tidak Hadir',
	Student_ID INT,
	CONSTRAINT Attendance_Table_PK PRIMARY KEY (Attendance_ID),
	CONSTRAINT Attendance_Table_FK FOREIGN KEY (Student_ID) REFERENCES Student_Table (Student_ID) ON DELETE CASCADE
);