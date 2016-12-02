using Android.App;
using Android.OS;
using MvvmCross.Droid.Views;
using DirtySkunk.Core.ViewModels;

namespace DirtySkunk.Droid.Views
{
    [Activity(Label = "View for FirstViewModel")]
    public class SignInView : MvxActivity
    {

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.LoginView);
        }
    }
}
