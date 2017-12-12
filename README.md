# My Data Project

Contents

- [Overview](https://github.com/willvelida/mydata/blob/master/README.md#overview)
- [Datasets](https://github.com/willvelida/mydata/blob/master/README.md#datasets)

## Overview

I have been collecting fitness information through my Fitbit Blaze wearable device and I'm creating this project to gain some insights into my fitness behaviours over time. The current objectives for this project are:

* Visualize my fitness data to communicate results to end-users.
* Predict future insights from exisiting data.
* Provide a means of interacting with the data in real time.

These objectives will evolve and change over time.

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
