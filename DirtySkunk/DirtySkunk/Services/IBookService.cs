using DirtySkunk.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirtySkunk.Core.Services
{
    interface IBookService
    {
        List<Book> Books();
        List<Book> BooksSortedByParutionDate();
        void Add(Book book);
    }
}
