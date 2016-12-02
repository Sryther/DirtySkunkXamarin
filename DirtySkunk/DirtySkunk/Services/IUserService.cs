using DirtySkunk.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirtySkunk.Core.Services
{
    public interface IUserService
    {
        User signIn(string username, string password);
    }
}
