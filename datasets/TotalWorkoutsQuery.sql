SELECT *
FROM TotalExercise;

/* Alter Calories Burned */
ALTER TABLE [MyDataDB].[dbo].[TotalExercise]
ALTER COLUMN [Calories Burned] int;

ALTER TABLE [MyDataDB].[dbo].[TotalExercise]
ALTER COLUMN [Steps] int;

ALTER TABLE [MyDataDB].[dbo].[TotalExercise]
ALTER COLUMN [Floors] int;

ALTER TABLE [MyDataDB].[dbo].[TotalExercise]
ALTER COLUMN [Minutes Sedentary] int;

ALTER TABLE [MyDataDB].[dbo].[TotalExercise]
ALTER COLUMN [Minutes Lightly Active] int;

ALTER TABLE [MyDataDB].[dbo].[TotalExercise]
ALTER COLUMN [Minutes Fairly Active] int;

ALTER TABLE [MyDataDB].[dbo].[TotalExercise]
ALTER COLUMN [Minutes Very Active] int;

ALTER TABLE [MyDataDB].[dbo].[TotalExercise]
ALTER COLUMN [Activity Calories] int;

ALTER TABLE [MyDataDB].[dbo].[TotalExercise]
ALTER COLUMN [Distance] float;

/* TODO: Convert Date */

/* How many times did we burn over 4000 calories */
SELECT * FROM TotalExercise
WHERE [Calories Burned] >= 4000;