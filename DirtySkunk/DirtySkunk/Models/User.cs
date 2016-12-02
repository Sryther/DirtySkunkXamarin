using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirtySkunk.Core.Models
{
    public class User
    {
        public string Username;
        public string Password;
        private string _id;

        public string Id
        {
            get { return _id; }
            private set { _id = value; }
        }


        public User(string username, string password)
        {
            Id = Guid.NewGuid().ToString();
            Username = username;
            Password = password;
        }
    }
}
