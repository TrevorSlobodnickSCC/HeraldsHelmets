using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HeraldsHelmets.Models
{
    public class Helmet
    {
        public int Id { get; set; }
        [Required]
        public string Type { get; set; }
        [Required]
        public string Size { get; set; }
        [Required]
        public string Brand { get; set; }
        [Required]
        public string Model { get; set; }
        [Required]
        public string Colour { get; set; }
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(10, 2)")] //10 numbers total, 2 after the decimal
        public decimal Price { get; set; }
        [Range(1, 5, ErrorMessage = "Value must be between 1 and 5")] // Only allow values between 1 and 5
        [Column(TypeName = "decimal(2, 1)")] //2 numbers total, 1 after the decimal place
        [RegularExpression(@"^[1-5](?:\.5|\.0)?$", ErrorMessage = "Value must be between 1 and 5 that ends in .0, .5, or contain no decimal")] //Numbers 1-5 that end in no decimal, .0, or .5
        [Display(Name = "Rating (Stars)")] // Change display from Rating -> Rating (Stars)
        public double Rating { get; set; } // Since range is specified as a half scale, it must include decimals
        //decimals and ints are required by default
    }
}
