using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;

namespace MyData
{
    [Activity(Label = "MyData", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get UI Controls from layout
            Button newWorkoutButton = FindViewById<Button>(Resource.Id.newExerciseButton);

            //
            newWorkoutButton.Click += (sender, e) =>
            {
                var intent = new Intent(this, typeof(NewWorkout));
                StartActivity(intent);
            };


        }
    }
}

