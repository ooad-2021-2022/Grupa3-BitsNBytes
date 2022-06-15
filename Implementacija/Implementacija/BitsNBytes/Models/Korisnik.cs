using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BitsNBytes.Models
{
    public class Korisnik
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("AspNetUsers")]
        public int IdAspNetUsers { get; set; }  
        
        public float Rejting { get; set; }
        public float EtfKredit { get; set; }
        [Required]
        [RegularExpression(@"[0-9| |a-z|A-Z]*", ErrorMessage = "Dozvoljeno je samo korištenje velikih i malih slova, brojeva i razmaka!")]
        public string Adresa { get; set; }
        [Required]
        public int PoštanskiBroj { get; set; }
        [Required]
        [RegularExpression(@"[|a-z|A-Z]*", ErrorMessage = "Dozvoljeno je samo korištenje velikih i malih slova!")]
        public string Ime { get; set; }
        [Required]
        [RegularExpression(@"[|a-z|A-Z]*", ErrorMessage = "Dozvoljeno je samo korištenje velikih i malih slova!")]
        public string Prezime { get; set; }


    }
}
