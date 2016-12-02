using DirtySkunk.Core.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirtySkunk.Core.Models
{
    public class Book
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Synopsis { get; set; }
        public DateTime ParutionDate { get; set; }
        public int Rating { get; set; }

        public Book(string title, string author, string synopsis, DateTime parutionDate, int rating)
        {
            if (rating < 1 || rating > 5)
            {
                throw new WrongRatingException(rating);
            }

            Id = Guid.NewGuid().ToString();

            Title = title;
            Author = author;
            Synopsis = synopsis;
            ParutionDate = parutionDate;
            Rating = rating;
        }
    }
}
