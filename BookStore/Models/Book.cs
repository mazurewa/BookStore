using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BookStore.Models
{
    public class Book
    {
        public int ID { get; set; }
        [Required(AllowEmptyStrings =false, ErrorMessage ="You must enter a name")]
        [StringLength(60, MinimumLength =3, ErrorMessage = "Must be between 3 and 60")]
        public string Name { get; set; }
        [Display(Name="Pub Date")]
        [DataType(DataType.Date)]
        public DateTime PubDate { get; set; }
        [DataType(DataType.Currency)]
        [Range(1,100, ErrorMessage = "Must be between $1 and $100")]
        public decimal Price { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "You must enter a genre")]
        public string Genre { get; set; }
    }
}