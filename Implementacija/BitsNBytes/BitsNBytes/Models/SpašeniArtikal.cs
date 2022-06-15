

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BitsNBytes.Models
{
    public class SpašeniArtikal
    {
       [Key]
       [ForeignKey("Artikal")]
       public int Id { get; set; }

        [ForeignKey("Korisnik")]
        public int IdKorisnik { get; set; }

    }
}
