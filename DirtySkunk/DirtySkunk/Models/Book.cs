using DirtySkunk.Core.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirtySkunk.Core.Models
{
    class Book
    {
        public string Title;
        public string Author;
        public string Synopsis;
        public DateTime ParutionDate;
        public int Rating;

        public Book(string title, string author, string synopsis, DateTime parutionDate, int rating)
        {
            if (rating < 1 || rating > 5)
            {
                throw new WrongRatingException(rating);
            }

            Title = title;
            Author = author;
            Synopsis = synopsis;
            ParutionDate = parutionDate;
            Rating = rating;
        }
    }
}
