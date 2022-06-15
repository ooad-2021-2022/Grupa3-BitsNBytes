using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BitsNBytes.Models
{
    public class Artikal
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [RegularExpression(@"[0-9| |a-z|A-Z]*", ErrorMessage = "Dozvoljeno je samo korištenje velikih i malih slova, brojeva i razmaka!")]
        [StringLength(maximumLength: 20, MinimumLength = 3, ErrorMessage ="Naziv predmeta smije imati između 3 i 20 karaktera!")]

        public string Naziv { get; set; }
        [Required]    
        [StringLength(maximumLength: 100, MinimumLength = 3, ErrorMessage = "Naziv predmeta smije imati između 3 i 100 karaktera!")]
        [RegularExpression(@"[0-9| |a-z|A-Z]*", ErrorMessage = "Dozvoljeno je samo korištenje velikih i malih slova, brojeva i razmaka!")]
        public string Opis { get; set; }
        [Required]
        public float Cijena { get; set; }
        [ForeignKey("Kategorija")]
        public int IdKategorija { get; set; }
        [ForeignKey("Pošiljka")]
        public int IdPošiljka { get; set; }
        [ForeignKey("Prodavač")]
        public int IdProdavač { get; set; }

    }
}
