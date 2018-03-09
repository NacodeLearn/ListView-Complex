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
using ListViewComplex.Services;

namespace ListViewComplex
{
    public class MainScreenAdapter : BaseAdapter<myData>
    {
        List<myData> MyItems;
        Activity context;

        public MainScreenAdapter(Activity context, List<myData> items) : base()
        {
            this.context = context;
            this.MyItems = items;
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override myData this[int position]
        {
            get { return MyItems[position]; }
        }

        public override int Count
        {
            get { return MyItems.Count; }
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var myItem = MyItems[position];
            View view = convertView;
            if (view == null)
            {
                view = context.LayoutInflater.Inflate(Resource.Layout.myComplexLayout, null);
            }
            view.FindViewById<TextView>(Resource.Id.txt_name).Text = myItem.Name;
            view.FindViewById<TextView>(Resource.Id.txt_description).Text = myItem.Description;
            view.FindViewById<ImageView>(Resource.Id.image).SetImageResource(myItem.Pic_Id);
            return view;
        }
    }
}