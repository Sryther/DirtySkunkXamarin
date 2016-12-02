using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirtySkunk.Core.Exceptions
{
    class WrongRatingException : Exception
    {
        public WrongRatingException(int rating) : base("The rating must be between 1 and 5. The rating provided is" + rating + ".")
        {

        }
    }
}
