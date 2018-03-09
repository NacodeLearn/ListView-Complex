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



namespace ListViewComplex.Services

{

    class myServices

    {

        public List<myData> GetMyData()

        {

            List<myData> myDataList = new List<myData>

            {

                // Idealy, your own app will go off and retrieve this information from a remote source. The exposed

                // method (GetDataSet) and the myData class should be the only items the caller should care about.

                new myData { Name = "John", Description = "This is the picture of a man", Pic_Id = Resource.Drawable.Pic00},

                new myData { Name = "Mary", Description = "This is the picture of a woman", Pic_Id = Resource.Drawable.Pic01 },

                new myData { Name = "Peter", Description = "This is the picture of a man", Pic_Id = Resource.Drawable.Pic02 },

                new myData { Name = "Nancy", Description = "This is the picture of a woman", Pic_Id = Resource.Drawable.Pic03 },

                new myData { Name = "James", Description = "This is the picture of a man", Pic_Id = Resource.Drawable.Pic04 },

                new myData { Name = "Wanda", Description = "This is the picture of a woman", Pic_Id = Resource.Drawable.Pic05 },

                new myData { Name = "Laura", Description = "This is the picture of a woman", Pic_Id = Resource.Drawable.Pic06 },

                new myData { Name = "Anna", Description = "This is the picture of a woman", Pic_Id = Resource.Drawable.Pic07 },

                new myData { Name = "Beatrice", Description = "This is the picture of a woman", Pic_Id = Resource.Drawable.Pic08 },

                new myData { Name = "Ellen", Description = "This is the picture of a woman", Pic_Id = Resource.Drawable.Pic09 }

            };

            return myDataList;

        }

    }



    public class myData

    {

        public string Name { get; set; }

        public string Description { get; set; }

        public int Pic_Id { get; set; }

    }

}