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
using Toolbar = Android.Support.V7.Widget.Toolbar;
using Android.Support.V7.App;

namespace JwiRide.Droid
{
    [Activity(Label = "ActivityLocationSelection")]
    public class ActivityLocationSelection : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_location_select);
            // Create your application here
            Toolbar toolbar = FindViewById<Toolbar>(Resource.Id.alstoolbar);
                   

        }
    }
}