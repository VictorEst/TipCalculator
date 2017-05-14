using Android.App;
using Android.Widget;
using Android.OS;
using System;

namespace TipCalculator
{
    [Activity(Label = "TipCalculator", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {
        //This are the elements that have a visual representation and I will make the interact with the UI
        EditText enterText;
        Button calcuButton;
        TextView tipText;
        TextView totalText;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            //Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            enterText = FindViewById<EditText>(Resource.Id.enterText);
            calcuButton = FindViewById<Button>(Resource.Id.calcuButton);
            tipText = FindViewById<TextView>(Resource.Id.tipText);
            totalText = FindViewById<TextView>(Resource.Id.totalText);

            calcuButton.Click += OnCalcuClick;
     
        }

        void OnCalcuClick(object sender, EventArgs e)
        {
            string text = enterText.Text;
            double importe;
            if(double.TryParse(text, out importe)){
                double tip = (0.10 * importe);
                double total = (importe + tip);

                tipText.Text = tip.ToString("C");
                totalText.Text = total.ToString("C");
            }
        }

    }
}

