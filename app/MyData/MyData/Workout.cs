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
using Newtonsoft.Json;

namespace MyData
{
    public class Workout
    {
        [JsonProperty (PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty (PropertyName = "ExerciseDate")]
        public string ExerciseDate { get; set; }

        [JsonProperty (PropertyName = "WeightName")]
        public string WeightName { get; set; }

        [JsonProperty (PropertyName = "WeightAmount")]
        public string WeightAmount { get; set; }

        [JsonProperty (PropertyName = "WeightSets")]
        public string WeightSets { get; set; }

        [JsonProperty (PropertyName = "WeightReps")]
        public string WeightReps { get; set; }

        [JsonProperty (PropertyName = "CardioName")]
        public string CardioName { get; set; }

        [JsonProperty (PropertyName = "CardioDuration")]
        public string CardioDuration { get; set; }
    }
}