create database Tulane_Tech
use Tulane_Tech

create table Users(
ID int primary key identity (1,1),
First_name varchar(max),
Last_name varchar(max),
[Password] varchar(max),
Email varchar(max),
[Admin] bit
)

create table Majors(
Major_id int primary key identity(1,1),
Major_name varchar(max),
)

create table Subjects(
Subject_id int primary key identity(1,1),
Subject_name varchar(max),
Credit_hours int
)

create table Majors_Subjects(
Subjects_id int ,
Majors_id int,
FOREIGN KEY (Subjects_id) REFERENCES Subjects(Subject_id),
FOREIGN KEY (Majors_id) REFERENCES Majors(Major_id),
PRIMARY KEY (Subjects_id, Majors_id)
)

ALTER TABLE Personal_info
ADD FOREIGN KEY ([User_ID]) REFERENCES Users(ID)

ALTER TABLE Personal_info
ADD FOREIGN KEY (Major_ID) REFERENCES Majors(Major_id)

INSERT INTO Users(First_name, Last_name, Nationality, [Password], Email, Salt, [Admin])
VALUES ('Todor', 'Nedev', 'FinalProject100', 't.nedev24@acsbg.org', 1)

INSERT INTO Personal_info([User_ID], [Address], Phone_number, Major_ID)
VALUES (1, 'Mladost 3', 0878611879, 1)

INSERT INTO Majors (Major_name) VALUES 
    ('Computer Science'),
    ('Electrical Engineering'),
    ('Psychology')

INSERT INTO Subjects (Subject_name, Credit_hours) VALUES 
    ('Programming Fundamentals', 3),
    ('Digital Circuits', 4),
    ('Calculus AB', 3),
    ('Cognitive Psychology', 3),
    ('Data Structures and Algorithms', 4),
    ('Signals and Systems', 4)

drop database Tulane_Tech

UPDATE Users
SET [Password] = 'wFxFDJyUyxBReoYvh9j3mMD/DgrD0M2gABhVgS0MFAc='
WHERE ID = 1;

INSERT INTO Users(First_name, Last_name, Nationality, [Password], Email, [Admin])
VALUES ('Boris', 'Topalov', 'nFDdo7uBSX7RqzEqnS3dprk5cLeIoPuhn5dYJQ66LvI=', 'b.topalov24@acsbg.org', 0)

DELETE FROM Subjects where Subject_id = 12;

alter table Users add Majors varchar(max);
alter table Users add Main_Subject varchar(max);

insert into Majors_Subjects values (1,1),(1,2),(2,1),(2,2),(3,2),(4,3)

SELECT Subjects.Subject_name
FROM Subjects
JOIN Majors_Subjects ON Subjects.Subject_id = Majors_Subjects.Subjects_id
JOIN majors ON Majors_Subjects.Majors_id = Majors.Major_id
WHERE majors.major_name = 'Electrical Engineering';