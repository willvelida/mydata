USE MyDataDB
GO
ALTER TABLE [dbo].[GymWorkouts] DROP COLUMN [ExerciseId];

SELECT *
FROM dbo.GymWorkouts;