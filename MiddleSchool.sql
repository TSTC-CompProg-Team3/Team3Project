CREATE TABLE [Class] (
  [ClassID] INT PRIMARY KEY,
  [TeacherID] INT,
  [SubjectID] INT,
  [ClassSize] INT
)
GO

CREATE TABLE [Student] (
  [StudentID] INT PRIMARY KEY,
  [LoginID] INT,
  [FirstName] VARCHAR(255),
  [MiddleName] VARCHAR(255),
  [LastName] VARCHAR(255),
  [DateOfBirth] Date,
  [MailingAddress] VARCHAR(255),
  [StreetAddress] VARCHAR(255),
  [City] VARCHAR(255),
  [State] VARCHAR(255),
  [Zip] VARCHAR(255),
  [PhoneNumber] VARCHAR(255),
  [EmergencyContactName] VARCHAR(255),
  [EmergencyContactPhone] VARCHAR(255),
  [Guardian1Name] VARCHAR(255),
  [Guardian1CellPhone] VARCHAR(255),
  [Guardian1WorkPhone] VARCHAR(255),
  [Guardian1WorkPlace] VARCHAR(255)
)
GO

CREATE TABLE [Parent] (
  [StudentID] INT,
  [LoginID] INT,
  [FirstName] VARCHAR(255),
  [LastName] VARCHAR(255)
)
GO

CREATE TABLE [RanSeatingChart] (
  [StudentID] INT,
  [SeatNumber] INT
)
GO

CREATE TABLE [Teacher] (
  [TeacherID] INT PRIMARY KEY,
  [LoginID] INT,
  [FirstName] VARCHAR(255),
  [LastName] VARCHAR(255)
)
GO

CREATE TABLE [Administrator] (
  [AdminID] INT PRIMARY KEY,
  [LoginID] INT,
  [FirstName] VARCHAR(255),
  [LastName] VARCHAR(255)
)
GO

CREATE TABLE [Subject] (
  [SubjectID] INT PRIMARY KEY,
  [SubjectName] VARCHAR(255)
)
GO

CREATE TABLE [Login] (
  [LoginID] INT PRIMARY KEY,
  [AccountType] VARCHAR(255),
  [UserName] VARCHAR(255),
  [Password] VARCHAR(255)
)
GO

CREATE TABLE [Grades] (
  [ClassID] INT,
  [AssignmentName] VARCHAR(255),
  [AssignmentType] VARCHAR(255),
  [StudentID] INT,
  [Grade] INT
)
GO

CREATE TABLE [Attendance] (
  [StudentID] INT,
  [Date] DATE,
  [Present] boolean
)
GO

ALTER TABLE [Login] ADD FOREIGN KEY ([LoginID]) REFERENCES [Administrator] ([LoginID])
GO

ALTER TABLE [Login] ADD FOREIGN KEY ([LoginID]) REFERENCES [Student] ([LoginID])
GO

ALTER TABLE [Class] ADD FOREIGN KEY ([TeacherID]) REFERENCES [Teacher] ([TeacherID])
GO

ALTER TABLE [Student] ADD FOREIGN KEY ([StudentID]) REFERENCES [Grades] ([StudentID])
GO

ALTER TABLE [Class] ADD FOREIGN KEY ([SubjectID]) REFERENCES [Subject] ([SubjectID])
GO

ALTER TABLE [Login] ADD FOREIGN KEY ([LoginID]) REFERENCES [Teacher] ([LoginID])
GO

ALTER TABLE [Class] ADD FOREIGN KEY ([ClassID]) REFERENCES [Grades] ([ClassID])
GO

ALTER TABLE [Student] ADD FOREIGN KEY ([StudentID]) REFERENCES [Attendance] ([StudentID])
GO

ALTER TABLE [Student] ADD FOREIGN KEY ([StudentID]) REFERENCES [Parent] ([StudentID])
GO

ALTER TABLE [Login] ADD FOREIGN KEY ([LoginID]) REFERENCES [Parent] ([LoginID])
GO

ALTER TABLE [Student] ADD FOREIGN KEY ([StudentID]) REFERENCES [RanSeatingChart] ([StudentID])
GO
