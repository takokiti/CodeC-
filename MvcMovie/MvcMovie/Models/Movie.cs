using System;
using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Cenre { get; set; }
        public decimal Revenue { get; set; }
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

    }
}
