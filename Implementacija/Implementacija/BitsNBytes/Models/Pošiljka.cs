using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BitsNBytes.Models
{
    public class Pošiljka
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Kupac")]
        public int IdKupac { get; set; }
        [ForeignKey("Prodavač")]
        public int IdProdavač { get; set; }

        [ForeignKey("Artikal")]
        public int IdArtikal { get; set; }
    }
}
