using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirtySkunk.Core.Exceptions
{
    public class BookNotFoundException : Exception
    {
        public BookNotFoundException(string id) : base("The book wasn't found using the following id: " + id +".")
        {

        }
    }
}
