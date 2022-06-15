using System.ComponentModel.DataAnnotations;

namespace BitsNBytes.Models
{
    public class Status
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(maximumLength: 20, MinimumLength = 3, ErrorMessage = "Naziv predmeta smije imati između 3 i 20 karaktera!")]
        [RegularExpression(@"[ A-Z]*", ErrorMessage = "Dozvoljeno je samo korištenje velikih slova!")]
        public string Naziv { get; set; }
    }
}
