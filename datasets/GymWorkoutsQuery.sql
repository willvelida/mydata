/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [ExerciseId]
      ,[DateId]
      ,[Exercise Date]
      ,[Exercise Week]
      ,[Exercise Month]
      ,[Exercise Year]
      ,[Exercise Day]
      ,[Exercise Name]
      ,[Weight]
      ,[Sets]
      ,[Reps]
  FROM [MyDataDB].[dbo].[GymWorkouts]

/* Alter Weight Column to change type to float */
ALTER TABLE [MyDataDB].[dbo].[GymWorkouts]
ALTER COLUMN [Weight] Float;

ALTER TABLE [MyDataDB].[dbo].[GymWorkouts]
ALTER COLUMN [Sets] int;

ALTER TABLE [MyDataDB].[dbo].[GymWorkouts]
ALTER COLUMN [Reps] int;

ALTER TABLE [MyDataDB].[dbo].[GymWorkouts]
ALTER COLUMN [DateId] int;

ALTER TABLE [MyDataDB].[dbo].[GymWorkouts]
ALTER COLUMN [ExerciseId] int;

SELECT [ExerciseId],
		[Exercise Name],
		[Exercise Date],
		[Weight],
		[Sets],
		[Reps]
FROM [MyDataDB].[dbo].GymWorkouts
WHERE [Weight] >= 90.00;