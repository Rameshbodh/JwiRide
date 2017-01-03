using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;
using Toolbar = Android.Support.V7.Widget.Toolbar;
using System.Collections.Generic;
using static Android.Widget.ImageView;

namespace JwiRide.Droid
{
	[Activity (Label = "Jwi Ride", MainLauncher = true, Icon = "@drawable/jwilogo",Theme ="@style/MyTheme.NoActionBar")]
	public class ActivityJwiStartPage : AppCompatActivity
	{

        List<int> todoimageList = new List<int>();   
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

            SetContentView(Resource.Layout.activity_start_page);
            todoimageList.Add(Resource.Raw.todoimage1);
            todoimageList.Add(Resource.Raw.todoimage2);
            todoimageList.Add(Resource.Raw.todoimage3);
            todoimageList.Add(Resource.Raw.todoimage4);

            View activityLocationSelectionbtn = FindViewById<TextView>(Resource.Id.asplocationbtn);

            activityLocationSelectionbtn.Click += ActivityLocationSelectionbtn_Click;



            ToDolistHorizontalImageView();
           


          
        }

        private void ActivityLocationSelectionbtn_Click(object sender, EventArgs e)
        {
            StartActivity(typeof(ActivityLocationSelection));
        }

        private void ToDolistHorizontalImageView()
        {
            LinearLayout layout = (LinearLayout)FindViewById(Resource.Id.asplinearLayoutImageView);
            for (int i = 0; i <4; i++)
            {
                ImageView imageView = new ImageView(this);
                imageView.Id = i;
                imageView.SetPadding(5, 5, 5, 5);
                imageView.SetImageResource(todoimageList[i]);
                          
                imageView.SetScaleType(ScaleType.FitXy);
                layout.AddView(imageView);
            }
        }
    }

}


