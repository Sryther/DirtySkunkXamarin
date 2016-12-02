using DirtySkunk.Core.Services;
using MvvmCross.Core.ViewModels;

namespace DirtySkunk.Core.ViewModels
{
    class HomeViewModel : MvxViewModel
    {
        private string _welcome;

        public string Welcome
        {
            get { return _welcome; }
            set {
                _welcome = value;
                RaisePropertyChanged();
            }
        }

        public MvxCommand ViewBooksButtonCommand
        {
            get { return new MvxCommand(ViewBooks); }
        }

        private IUserService _userService;

        public HomeViewModel( IUserService userService)
        {
            _userService = userService;

            Welcome = "Welcome " +_userService.CurrentUser().Username + "!";
        }

        public void ViewBooks()
        {
            ShowViewModel<BooksViewModel>();
        }

    }
}
