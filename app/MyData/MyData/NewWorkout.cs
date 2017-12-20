using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace MyData
{
    [Activity(Label = "NewWorkout")]
    public class NewWorkout : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.NewExercise);

            // Set UI Elements
            EditText exerciseDate = FindViewById<EditText>(Resource.Id.exerciseDate);
            LinearLayout weightsLayout = FindViewById<LinearLayout>(Resource.Id.weightsLayout);
            EditText weightName = FindViewById<EditText>(Resource.Id.weightName);
            EditText weightAmount = FindViewById<EditText>(Resource.Id.weightAmount);
            EditText weightSets = FindViewById<EditText>(Resource.Id.weightSets);
            EditText weightReps = FindViewById<EditText>(Resource.Id.weightReps);
            LinearLayout cardioLayout = FindViewById<LinearLayout>(Resource.Id.cardioLayout);
            EditText cardioName = FindViewById<EditText>(Resource.Id.cardioName);
            EditText cardioDuration = FindViewById<EditText>(Resource.Id.cardioDuration);
            Button addWeightButton = FindViewById<Button>(Resource.Id.addNewWeightExerciseButton);
            Button addCardioButton = FindViewById<Button>(Resource.Id.addNewCardioExerciseButton);
            Button submitExerciseButton = FindViewById<Button>(Resource.Id.SubmitExerciseButton);


            // Event handler for addWeightButton
            addWeightButton.Click += (sender, e) =>
            {
                // Create a new element with all EditText inside them
                // Append the new elements to weightsLayout
            };

            // Event handler for addCardioButton
            addCardioButton.Click += (sender, e) =>
            {
                // Create a new element with all EditText inside them
                // Append the new elements to cardioLayout
            };

            // Event handler for submitExercise
            submitExerciseButton.Click += (sender, e) =>
            {
                // Create new intent
                var intent = new Intent(this, typeof(MainActivity));
                // TODO: Submit new data to DB
                // Go back to Main activity
                StartActivity(intent);
            };
            
        }
    }
}