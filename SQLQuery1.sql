CREATE TABLE registration(
	id INT IDENTITY (1,1) NOT NULL,
	FirstName VARCHAR(50) NOT NULL,
	LastNAme VARCHAR(50) NOT NULL,
	Birthday Date NOT NULL,
	Gender CHAR(7) NOT NULL,
	Phone VARCHAR(14) NOT NULL,
	Email VARCHAR(50) NOT NULL,
	Address_ VARCHAR(100) NOT NULL,
	Picture VARCHAR(100) NOT NULL,
	date_ smalldatetime 
)