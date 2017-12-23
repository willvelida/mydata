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

SELECT [ExerciseId],
		[Exercise Name]
FROM [MyDataDB].[dbo].GymWorkouts
WHERE [Weight] >= 90.00;