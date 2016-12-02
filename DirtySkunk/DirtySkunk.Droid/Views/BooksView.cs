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
using MvvmCross.Droid.Views;
using DirtySkunk.Core.ViewModels;

namespace DirtySkunk.Droid.Views
{
    [Activity(Label = "View for BooksModel")]
    public class BooksView : MvxActivity
    {
        public new BooksViewModel ViewModel
        {
            get { return (BooksViewModel)base.ViewModel; }
            set { base.ViewModel = value; }
        }

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.BooksView);
        }
    }
}