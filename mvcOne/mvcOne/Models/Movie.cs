using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace mvcOne.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        
        [Required]
        public DateTime DateAdded { get; set; }

        [Required]
        public DateTime DateReleased { get; set; }

        [Required]
        [Range(1,20)]
        public byte NumberInStock { get; set; }
        public byte NumberAvailable { get; set; }

        public MovieType MovieType { get; set; }
        public byte MovieTypeId { get; set; }
    }
}