using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirtySkunk.Core.Exceptions
{
    public class NoCurrentUserException : Exception
    {
        public NoCurrentUserException() : base("No user already connected")
        {

        }
    }
}
