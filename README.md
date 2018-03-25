# MyData Project - Insights into my health data.

Contents

- [Overview](https://github.com/willvelida/mydata/blob/master/README.md#overview)
- [Developer Log](https://github.com/willvelida/mydata/blob/master/README.md#developer-log)
- [Website](https://github.com/willvelida/mydata/blob/master/README.md#website)
- [Datasets](https://github.com/willvelida/mydata/blob/master/README.md#datasets)

## Overview

I have been collecting fitness information through my Fitbit Blaze wearable device and I'm creating this project to gain some insights into my fitness behaviours over time. The current objectives for this project are:

* Visualize my fitness data to communicate results to end-users.
* Predict future insights from exisiting data.
* Provide a means of interacting with the data in real time.

These objectives will evolve and change over time.

## Developer Log

If you want to read about the development of this project, you can do so by checking out my [blog](https://williamvelida.com/category/mydata-project/).

## Website

[MyData project website](http://mydataproject.azurewebsites.net/)

This project has a seperate web application that will be used to communicate insights into the data to end users. The GitHub repository for the website has been kept seperate for deployment reasons and can be found [here](https://github.com/willvelida/mydataweb).

## Datasets

These are the datasets used within the 'My Data' project. They are currently stored as xlsx and csv files. The following tables provide the fields used, a description of those fields and how they are calculated (if applicable).

**Total Exercise**

| Field Name | Description | Calculation (If applicable) |
|----------- | ----------- | ----------------------------|
| Date | Date of exercise | None |
| Calories Burned | The amount of calories burned within a day | None |
| Steps | Number of steps taken in one day | None |
| Distance | Distance covered in one day (miles) | None |
| Floors | Number of floors climbed in one day | None |
| Minutes Sedentary | Minutes recorded as sedentary activity | None |
| Minutes Lightly Active | Minutes recorded as light activity | None |
| Minutes Fairly Active | Minutes recorded as fairly active activity | None |
| Minutes Very Active | Minutes recorded as very active activity | None |
| Activity Calories | Amount of calories burned through combined activity | None |
| Step Target Achieved | Has the step target been achieved today | If Steps > 8,000, then yes |
| Calorie Target Achieved | Has the calorie target been achieved today | If Calories Burned > 3,400, then yes |
| Activity Target Achieved | Has the activity target been achieved today | If Minutes Very Active > 30, then yes |
| Distance Target Achieved | Has the distance target been achieved today | If Distance > 5.00, then yes |
| Rest Day | Was today a rest day? | If Minutes Very Active + Minutes Fairly Active < 30, then yes |

**Total Sleep**

| Field Name | Description | Calculation (If applicable) |
|----------- | ----------- | ----------------------------|
| Start Date | Start time for sleep | None |
| End Date | End time for sleep | None |
| Minutes Asleep | Minutes during sleep time spent sleeping | None |
| Minutes Awake | Minutes during sleep time spent awake | None |
| Number of Awakenings | Number of times woken up during sleep | None |
| Time in Bed | Total time spent in bed | None |
| Minutes REM Sleep | Minutes counted as REM sleep | None |
| Minutes Light Sleep | Minutes counted as Light sleep | None |
| Minutes Deep Sleep | Minutes counted as Deep sleep | None |
| Sleep Target Achieved | Has the sleep target been achieved today | If Minutes Asleep > 420, then yes |
| % Asleep | Percentage of total time in bed asleep | Round((Minutes Asleep / Time in Bed) * 100, 2 decimal places) |
| % Awake | Percentage of total time in bed awake | Round((Minutes Awake / Time in Bed) * 100, 2 decimal places) |
| % Light sleep | Percentage of total time of sleep counted as light | Round((Minutes Light Sleep / Time in Bed) * 100, 2 decimal places) |
| % REM sleep | Percentage of total time of sleep counted as REM | Round((Minutes REM Sleep / Time in Bed) * 100, 2 decimal places) |
| % Deep sleep | Percentage of total time of sleep counted as deep | Round((Minutes Deep Sleep / Time in Bed) * 100, 2 decimal places) |
| % Unclassified | Percentage of total time of sleep unclassified by Fitbit device | 100 - (% Light Sleep - % REM Sleep - % Deep sleep) |

**Gym Workouts**

| Field Name | Description | Calculation (If applicable) |
|----------- | ----------- | ----------------------------|
| ExerciseID | ExerciseId | None |
| DateID | DateId | None |
| Exercise Month | The month in the year | None |
| Exercise Year | The year that the workout took place in | None |
| Exercise Day | The day that the workout took place on | None |
| Exercise Date | The date that the workout took place on (dd-mm-yyyy) | None |
| Exercise Name | The name of the exercise | None |
| Weight | The amount of weight lifted (In KG) | None |
| Sets | Number of sets | None |
| Reps | Number of reps | None |
| TrainingArea | Area of body trained | None |

**Weight Measurements**

| Field Name | Description | Calculation (If applicable) |
|----------- | ----------- | ----------------------------|
| WeightID | ID for weight measurement | None |
| Weight Date | Date of measurement | None |
| Weight (Stone) | The amount I weighed in stone | None |
| Weight (Kg) | The amount I weighed in KG | None |
| Weight (lbs) | The amount I weighed in pounds | None |
| Gain/Loss Amount | The amount of total gain or loss achieved in that weight | current Weight in Pounds - Last Week Weight in Pounds |
| BMI | BMI Value | ROUND((Weight (KG) / 1.88) / 1.88, 2)  |

**Food Logs**

| Field Name | Description | Calculation (If applicable) |
|----------- | ----------- | ----------------------------|
| FoodID | ID for food measurement | None |
| Date | Date of food log | None |
| Calories In | The amount of calories consumed | None |
| Fat (g) | Fat consumed for the day (in grams) | None |
| Carbs (g) | Carbs consumed for the day (in grams) | None |
| Sodium (mg) | Fat consumed for the day (in milligrams) | None |
| Protein (g) | Protein consumed for the day (in grams) | None |
| Water (ml) | Water consumed for the day (in millilitres) | None |
| WaterTargetAchieved | Have I consumed enough water today? | IF Water > 2500 then "Yes" else "No" |
| UnderEaten | Have I eaten enough today? | IF Calories In < 1800 then "Yes" else "No" |

**Cardio Workouts**

| Field Name | Description | Calculation (If applicable) |
|----------- | ----------- | ----------------------------|
| CardioID | ID for Cardio Workout | None |
| CardioDate | Date for the cardio workout | None |
| CardioMonth | Month that the cardio workout took place | None |
| CardioYear | Year that the cardio workout took place | None |
| CardioDay | Day that the cardio workout took place | None |
| CardioExercise | The cardio exercise name | None |
| CardioSpeed | Speed of the cardio exercise | None |
| CardioLevel | Level of resistance for the cardio exercise | None |