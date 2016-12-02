using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DirtySkunk.Core.Models;
using DirtySkunk.Core.Services;
using DirtySkunk.Core.Exceptions;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace DirtySkunk.Droid.Services
{
    class UserService : IUserService
    {
        private static UserService _instance;
        private static List<User> _Users;
        private static User _currentUser;

        public UserService()
        {
            _Users = new List<User>();
            //_Users.Add(new User("toto", "tata"));
        }

        public static UserService Get()
        {
            if (_instance == null)
            {
                _instance = new UserService();
            }

            return _instance;
        }

        public User signIn(string username, string password)
        {
            foreach (User User in _Users)
            {
                if (User.Username == username && User.Password == password)
                {
                    _currentUser = User;
                    return User;
                }
            }

            throw new SignInException();
        }

        public User CurrentUser
        {
            get
            {
                if (_currentUser == null) throw new NoCurrentUserException();
                return _currentUser;
            }
        }
    }
}