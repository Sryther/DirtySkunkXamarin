using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirtySkunk.Core.Exceptions
{
    public class SignInException: Exception
    {
        public SignInException() : base ("Cannot sign in with this credentials.")
        {
             
        }
    }
}
