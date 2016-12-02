using DirtySkunk.Core.Models;
using DirtySkunk.Core.Services;
using DirtySkunk.Core.Utils;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirtySkunk.Core.ViewModels
{
    public class SignInViewModel : MvxViewModel
    {
        private String _username;
        private String _password;
        private ILogger _logger;
        private IUserService _userService;

        public SignInViewModel(ILogger logger, IUserService userService)
        {
            _logger = logger;
            _userService = userService;
        }

        public string Password
        {
            get { return _password; }
            set
            {
                _password = value;
                RaisePropertyChanged();
            }
        }

        public string Username
        {
            get { return _username; }
            set
            {
                _username = value;
                RaisePropertyChanged();
            }
        }

        public void SignIn()
        {
            try
            {
                
                User user = _userService.signIn(Username, Password);

                //we should show view next model
                _logger.WriteLine(user.ToString());
            }catch(Exception e)
            {
                _logger.WriteLine(e.Message);
            }
        }

        public MvxCommand SignInButtonCommand
        {
            get { return new MvxCommand(SignIn); }
        }
    }
}
