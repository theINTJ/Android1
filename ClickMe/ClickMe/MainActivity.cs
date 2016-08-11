﻿using System;
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
        Button btnIncrease, btnDecrease, btnInfo;
        TextView lblValue;
        int Value = 0;

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
            btnInfo = FindViewById<Button>(Resource.Id.btnInfo);
            btnInfo.Click += (s, e) =>
            {
                Intent i = new Intent(this, typeof(InfoActivity));
                i.PutExtra("value", Value);
                StartActivity(i);
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
        }
    }
}

