using DirtySkunk.Core.Models;
using DirtySkunk.Core.Services;
using MvvmCross.Core.ViewModels;
using System.Collections.Generic;

namespace DirtySkunk.Core.ViewModels
{
    public class BooksViewModel : MvxViewModel
    {
        private List<Book> _books;

        public MvxCommand<Book> ViewBookDetailsCommand
        {
            get { return new MvxCommand<Book>(ViewBookDetails); }
        }

        public BooksViewModel()
        {
            // Loads the books by calling the BookService and sort them by parution date to have a coherent list.
            Books = BookService.GetInstance().BooksSortedByParutionDate();
        }

        public void ViewBookDetails(Book book)
        {
            Dictionary<string, string> data = new Dictionary<string, string>
            {
                { "Id", book.Id }
            };

            MvxBundle bundle = new MvxBundle(data);
            ShowViewModel<BookDetailsViewModel>(bundle);
        }

        public List<Book> Books
        {
            get { return _books; }
            set
            {
                _books = value;
                RaisePropertyChanged();
            }
        }

    }
}
