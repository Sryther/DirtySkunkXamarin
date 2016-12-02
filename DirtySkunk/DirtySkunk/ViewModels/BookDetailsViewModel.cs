using System;
using DirtySkunk.Core.Exceptions;
using DirtySkunk.Core.Models;
using DirtySkunk.Core.Services;
using MvvmCross.Core.ViewModels;

namespace DirtySkunk.Core.ViewModels
{
    public class BookDetailsViewModel : MvxViewModel
    {
        private Book _book;
        private string _title;
        private string _author;
        private string _synopsis;
        private string _parutionDate;
        private string _rating;
        private string _action;
        private string _removeVisibility;
        private string _confirmVisibility;
        public MvxCommand ConfirmButtonCommand
        {
            get { return new MvxCommand(ConfirmBook);  }
        }

        public  MvxCommand RemoveButtonCommand
        {
            get { return new MvxCommand(RemoveBook);  }
        }

        protected override void InitFromBundle(IMvxBundle parameters)
        {
            base.InitFromBundle(parameters);
            try
            {
                // Retrieve the book using its Id.
                _book = BookService.GetInstance().GetBookByGuid(parameters.Data["Id"]);

                // Choose the action to do on button click.
                Action = parameters.Data["Action"];

                if (Action == "Delete")
                {
                    ConfirmVisibility = "invisible";
                    RemoveVisibility = "visible";
                } else
                {
                    ConfirmVisibility = "visible";
                    RemoveVisibility = "invisible";
                }

                // Define the book details
                Title = _book.Title;
                Author = _book.Author;
                ParutionDate = _book.ParutionDate.ToString();
                Synopsis = _book.Synopsis;
                Rating = _book.Rating.ToString();

            }
            catch (BookNotFoundException e)
            {
                // TODO Handle error
            }
        }

        public BookDetailsViewModel()
        {

        }

        public void RemoveBook()
        {
            BookService.GetInstance().Remove(_book.Id);
            ShowViewModel<BooksViewModel>();
        }

        public void ConfirmBook()
        {
            BookService.GetInstance().Add(_book);
            ShowViewModel<BooksViewModel>();
        }

        public string ParutionDate
        {
            get { return _parutionDate; }
            set {
                _parutionDate = value;
                RaisePropertyChanged();
            }
        }

        public string Synopsis
        {
            get { return _synopsis; }
            set {
                _synopsis = value;
                RaisePropertyChanged();
            }
        }

        public string Author
        {
            get { return _author; }
            set {
                _author = value;
                RaisePropertyChanged();
            }
        }

        public string Title
        {
            get { return _title; }
            set {
                _title = value;
                RaisePropertyChanged();
            }
        }

        public string Rating
        {
            get { return _rating; }
            set
            {
                _rating = value + "/5";
                RaisePropertyChanged();
            }
        }

        public string Action
        {
            get { return _action; }
            set
            {
                _action = value;
                RaisePropertyChanged();
            }
        }

        public string ConfirmVisibility
        {
            get { return _confirmVisibility; }
            set {
                _confirmVisibility = value;
                RaisePropertyChanged();
            }
        }


        public string RemoveVisibility
        {
            get { return _removeVisibility; }
            set {
                _removeVisibility = value;
                RaisePropertyChanged();
            }
        }

    }
}
