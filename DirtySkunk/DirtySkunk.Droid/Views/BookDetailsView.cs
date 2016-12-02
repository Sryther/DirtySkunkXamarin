using Android.App;
using Android.OS;
using MvvmCross.Droid.Views;
using DirtySkunk.Core.ViewModels;

namespace DirtySkunk.Droid.Views
{
    [Activity(Label = "View for BookDetailsModel")]
    public class BookDetailsView : MvxActivity
    {
        public new BookDetailsViewModel ViewModel
        {
            get { return (BookDetailsViewModel)base.ViewModel; }
            set { base.ViewModel = value; }
        }

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.BookDetailsView);
        }
    }
}
