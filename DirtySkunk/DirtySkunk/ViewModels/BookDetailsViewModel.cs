using DirtySkunk.Core.Exceptions;
using DirtySkunk.Core.Models;
using DirtySkunk.Core.Services;
using MvvmCross.Core.ViewModels;
using System;

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

        protected override void InitFromBundle(IMvxBundle parameters)
        {
            base.InitFromBundle(parameters);
            try
            {
                _book = BookService.GetInstance().GetBookByGuid(parameters.Data["Id"]);
                Title = _book.Title;
                Author = _book.Author;
                ParutionDate = _book.ParutionDate.ToString();
                Synopsis = _book.Synopsis;
                Rating = _book.Rating.ToString() + "/5";

            }
            catch (BookNotFoundException e)
            {
                // TODO Handle error
            }
        }

        public BookDetailsViewModel()
        {

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
                _rating = value;
                RaisePropertyChanged();
            }
        }
    }
}
