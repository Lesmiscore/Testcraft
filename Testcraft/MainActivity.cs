using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace Testcraft
{
    [Activity(Label = "Testcraft", MainLauncher = true, Icon = "@drawable/icon", Theme = "@android:style/Theme.Material.Light")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            /*
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            Button button = FindViewById<Button>(Resource.Id.MyButton);

            button.Click += delegate { button.Text = string.Format("{0} clicks!", count++); };
            */
            ListView lv = new ListView(this);
            lv.Adapter = new MyListAdapter(this, new String[] { "LesMiselables25", "LesMiselables24" });
            SetContentView(lv);
        }

        class MyListAdapter : ArrayAdapter<String>
        {
            public MyListAdapter(MainActivity ma, String[] texts) : base(ma, 0, texts)
            {

            }
            public override View GetView(int position, View convertView, ViewGroup parent)
            {
                TextView tv = new TextView(Context);
                tv.Text = GetItem(position);
                return tv;
            }
        }
    }
}

