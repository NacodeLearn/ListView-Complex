using Android.App;
using Android.Widget;
using Android.OS;
using ListViewComplex.Services;
using System.Collections.Generic;

namespace ListViewComplex
{
    [Activity(Label = "ListViewComplex", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            myServices theService = new myServices();
            List<myData> myItems = theService.GetMyData();
            
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            
            TextView txt_Header = FindViewById<TextView>(Resource.Id.txt_header);
            ImageView img_Header = FindViewById<ImageView>(Resource.Id.img_header);
            
            txt_Header.Text = "NacodeLearn";
            img_Header.SetImageResource(Resource.Drawable.RBNHShot);

            ListView listView = FindViewById<ListView>(Resource.Id.lv_pics);
            listView.Adapter = new MainScreenAdapter(this, myItems);
            listView.ItemClick += (s, e) => { Toast.MakeText(this, myItems[e.Position].Description, ToastLength.Short).Show(); };
        }


    }
}

