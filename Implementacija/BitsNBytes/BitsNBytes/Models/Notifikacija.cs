using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BitsNBytes.Models
{
    public class Notifikacija
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Status")]
        public int IdStatus { get; set; }
    }
}
