using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace ClickMe
{
    [Activity(Label = "ClickMe", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        Button btnIncrease, btnDecrease;


        private void SetupResources()
        {
            btnIncrease = (Button)FindViewById(Resource.Id.btnIncrease);
            btnDecrease = (Button)FindViewById(Resource.Id.btnDecrease);
        }

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            SetupResources();
        }
    }
}

