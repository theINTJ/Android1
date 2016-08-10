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
        const string keyValue = "value";

        private void SetupResources()
        {
            btnIncrease = FindViewById<Button>(Resource.Id.btnIncrease);
            btnIncrease.Click += (s, e) =>
            {
                SetValue(++Value);
            };
            btnDecrease = FindViewById<Button>(Resource.Id.btnDecrease);
            btnDecrease.Click += (s, e) =>
            {
                SetValue(--Value);
            };
            lblValue = FindViewById<TextView>(Resource.Id.lblValue);
        }

        private void SetValue(int AValue)
        {
            lblValue.Text = AValue.ToString();
        }

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            SetupResources();

            if (bundle != null)
            {
                Value = bundle.GetInt(keyValue);
                SetValue(Value);
            }            
        }

        protected override void OnSaveInstanceState(Bundle outState)
        {     
            base.OnSaveInstanceState(outState);
            outState.PutInt(keyValue, Value);
        }

    }
}

