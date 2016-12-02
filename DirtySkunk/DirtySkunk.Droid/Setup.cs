using Android.Content;
using MvvmCross.Droid.Platform;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform.Platform;
using DirtySkunk.Droid.Utils;
using DirtySkunk.Core.Utils;
using MvvmCross.Platform;
using DirtySkunk.Droid.Services;
using DirtySkunk.Core.Services;

namespace DirtySkunk.Droid
{
    public class Setup : MvxAndroidSetup
    {
        public Setup(Context applicationContext) : base(applicationContext)
        {
        }

        protected override IMvxApplication CreateApp()
        {
            return new Core.App();
        }

        protected override IMvxTrace CreateDebugTrace()
        {
            return new DebugTrace();
        }

        protected override void InitializeFirstChance()
        {
            
            Mvx.RegisterType<ILogger, AndroidLogger>();
            Mvx.RegisterType<IUserService, UserService>();
            base.InitializeFirstChance();
        }
    }
}
