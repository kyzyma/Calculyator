using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace Calc2
{
    [Activity(Label = "Calc2", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
       // int count = 1;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it

            Button btnadd = FindViewById<Button>(Resource.Id.addition);
            Button btnsub = FindViewById<Button>(Resource.Id.subtraction);
            Button btnmult = FindViewById<Button>(Resource.Id.multiplication);
            Button btnequal = FindViewById<Button>(Resource.Id.equal);

            EditText firstvalue = FindViewById<EditText>(Resource.Id.FVeditbox);
            EditText secondvalue = FindViewById<EditText>(Resource.Id.SVeditbox);
            EditText result = FindViewById<EditText>(Resource.Id.Redittbox);

            TextView errormsg = FindViewById<TextView>(Resource.Id.error);

            double a, b, c;
            int operation = 0;

            btnadd.Click += delegate
            {
                operation = 1;            
            };

            btnsub.Click += delegate
            {
                operation = 2;
            };

            btnmult.Click += delegate
            {
                operation = 3;
            };

            btnequal.Click += delegate
            {
                try
                {
                    a = double.Parse(firstvalue.Text);
                    b = double.Parse(secondvalue.Text);
                    switch(operation)
                    {
                        case 1:
                            c = a + b;
                            result.Text = c.ToString();
                            break;
                        case 2:
                            c = a - b;
                            result.Text = c.ToString();
                            break;
                        case 3:
                            c = a * b;
                            result.Text = c.ToString();
                            break;
                        default:
                            errormsg.Text = "You don't select the operation";
                            break;
                    }
                    
                }
                catch (Exception ex)
                {
                    errormsg.Text = ex.Message;
                }
            };

        }

    }
}
