using System;
using System.ComponentModel.DataAnnotations;

namespace RazorMovies.Models
{
    public enum Genres
    {
        Action, Comedy, Horror, Thriller, Fiction
    }

    public class Movie
    {
        [Key]

        public int ID { get; set; }
        [StringLength(60)]
        public string Title { get; set; }

        [DataType(DataType.Date)]

        public DateTime ReleaseDate { get; set; }

        public string Genre { get; set; }

        public decimal Price { get; set; }
    }
}
