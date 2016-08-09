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
        TextView lblValue;
        int Value = 0;

        private void SetupResources()
        {
            btnIncrease = FindViewById<Button>(Resource.Id.btnIncrease);
            btnDecrease = FindViewById<Button>(Resource.Id.btnDecrease);
            lblValue = FindViewById<TextView>(Resource.Id.lblValue);
        }

        private void SetValue()
        {
            lblValue.Text = Value.ToString();
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

