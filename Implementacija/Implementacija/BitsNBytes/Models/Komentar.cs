using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BitsNBytes.Models
{
    public class Komentar
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(maximumLength: 100, MinimumLength = 3, ErrorMessage = "Naziv predmeta smije imati između 3 i 100 karaktera!")]
        [RegularExpression(@"[0-9| |a-z|A-Z]*", ErrorMessage = "Dozvoljeno je samo korištenje velikih i malih slova, brojeva i razmaka!")]
        public string Sadržaj { get; set; }
        [Required]
        [Range(1,5)]
        [RegularExpression(@"[1-5|", ErrorMessage = "Dozvoljeno je samo korištenje brojeva!")]
        public int Ocjena { get; set; } 

        [ForeignKey("Artikal")]
        public int IdArtikal { get; set; } 

    }
}
