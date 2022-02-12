CREATE TABLE [dbo].[StudentDetails](
[SId] INT IDENTITY (1, 1) NOT NULL,
[SName] VARCHAR (50) NULL,
[Location] VARCHAR (50) NULL,
[Gender] VARCHAR (20) NULL,
[Age] VARCHAR (5) NULL
PRIMARY KEY CLUSTERED ([SId] ASC)
);

Insert into StudentDetails(SName,Location,Gender,Age) values('Sonal','Mumbai','Female',22);

Select * from StudentDetails;

