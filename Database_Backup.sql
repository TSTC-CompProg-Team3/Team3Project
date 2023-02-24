-- Create the Login table
CREATE TABLE team3sp232330.Login (
    LoginID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    Email VARCHAR(255) NOT NULL,
	UserName VARCHAR(255) NOT NULL,
    Password VARCHAR(255) NOT NULL,
	[ResetCode] VARCHAR(255),
    AccountType VARCHAR(50) NOT NULL
);

-- Create the Administrator table
CREATE TABLE team3sp232330.Administrator (
    AdministratorID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    LoginID INT NOT NULL,
    FirstName VARCHAR(50) NOT NULL,
    LastName VARCHAR(50) NOT NULL,
    CONSTRAINT FK_Administrator_Login FOREIGN KEY (LoginID) REFERENCES team3sp232330.Login (LoginID)
);

-- Create the Officer table
CREATE TABLE team3sp232330.Officer (
    OfficerID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    LoginID INT NOT NULL,
    FirstName VARCHAR(50) NOT NULL,
    LastName VARCHAR(50) NOT NULL,
    CONSTRAINT FK_Officer_Login FOREIGN KEY (LoginID) REFERENCES team3sp232330.Login (LoginID)
);

-- Create the Student table
CREATE TABLE team3sp232330.Student (
    StudentID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    LoginID INT NOT NULL,
    FirstName VARCHAR(255),
	MiddleName VARCHAR(255),
	LastName VARCHAR(255),
	DateOfBirth Date,
	MailingAddress VARCHAR(255),
	StreetAddress VARCHAR(255),
	City VARCHAR(255),
	State VARCHAR(255),
	Zip VARCHAR(255),
	PhoneNumber VARCHAR(255),
	EmergencyContactName VARCHAR(255),
	EmergencyContactPhone VARCHAR(255),
	Guardian1Name VARCHAR(255),
	Guardian1CellPhone VARCHAR(255),
	Guardian1WorkPhone VARCHAR(255),
	Guardian1WorkPlace VARCHAR(255)
    CONSTRAINT FK_Student_Login FOREIGN KEY (LoginID) REFERENCES team3sp232330.Login (LoginID)
);

-- Create the Teacher table
CREATE TABLE team3sp232330.Teacher (
    TeacherID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    LoginID INT NOT NULL,
    FirstName VARCHAR(50) NOT NULL,
    LastName VARCHAR(50) NOT NULL,
    CONSTRAINT FK_Teacher_Login FOREIGN KEY (LoginID) REFERENCES team3sp232330.Login (LoginID)
);


-- Create the Class table
CREATE TABLE team3sp232330.Subject (
    SubjectID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    SubjectName VARCHAR(50) NOT NULL,
    );


-- Create the Class table
CREATE TABLE team3sp232330.Class (
    ClassID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    ClassName VARCHAR(50) NOT NULL,
    TeacherID INT NOT NULL,
	SubjectID INT NOT NULL,
	ClassSize INT NOT NULL,
    CONSTRAINT FK_Class_Teacher FOREIGN KEY (TeacherID) REFERENCES team3sp232330.Teacher (TeacherID),
	CONSTRAINT FK_Class_Subject FOREIGN KEY (SubjectID) REFERENCES team3sp232330.Subject (SubjectID)

);



-- Create the Grades table
CREATE TABLE team3sp232330.Grades (
    GradesID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    StudentID INT NOT NULL,
    ClassID INT NOT NULL,
    Grade DECIMAL(5,2) NOT NULL,
	Percentage DECIMAL(5,2) NOT NULL,
    AssignmentType VARCHAR(50) NOT NULL
    CONSTRAINT FK_Grades_Student FOREIGN KEY (StudentID) REFERENCES team3sp232330.Student (StudentID),
    CONSTRAINT FK_Grades_Class FOREIGN KEY (ClassID) REFERENCES team3sp232330.Class (ClassID)
);


-- Create the Attendance table
CREATE TABLE team3sp232330.Attendance (
    AttendanceID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    StudentID INT NOT NULL,
    ClassID INT NOT NULL,
    AttendanceDate DATETIME NOT NULL,
    CONSTRAINT FK_Attendance_Student FOREIGN KEY (StudentID) REFERENCES team3sp232330.Student (StudentID),
    CONSTRAINT FK_Attendance_Class FOREIGN KEY (ClassID) REFERENCES team3sp232330.Class (ClassID)
);

-- Create the Parent table
CREATE TABLE team3sp232330.Parent (
    ParentID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	LoginID INT NOT NULL, 
    FirstName VARCHAR(50) NOT NULL,
    LastName VARCHAR(50) NOT NULL,
	CONSTRAINT FK_Parent_Login FOREIGN KEY (LoginID) REFERENCES team3sp232330.Login (LoginID)
);


-- Create the StudentParent table
CREATE TABLE team3sp232330.StudentParent (
    StudentID INT NOT NULL,
    ParentID INT NOT NULL,
    CONSTRAINT FK_StudentParent_Student FOREIGN KEY (StudentID) REFERENCES team3sp232330.Student (StudentID),
    CONSTRAINT FK_StudentParent_Parent FOREIGN KEY (ParentID) REFERENCES team3sp232330.Parent (ParentID)
);

---- Create the RanSeatingChart table
--CREATE TABLE team3sp232330.RanSeatingChart (
--    RanSeatingChartID INT
--	SeatNumber INT
	
--);
