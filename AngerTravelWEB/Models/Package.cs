using System.ComponentModel.DataAnnotations.Schema;

namespace AngerTravelWEB.Models
{
    public class Package:BaseEntities
    {
        public string Name { get; set; }
        public string Image { get; set; }
        public string Content { get; set; }
        [Column(TypeName ="money")]
        public decimal Price { get; set; }
        public string Rating { get; set; }
        [Column(TypeName ="tinyint")]
        public byte Day { get; set; }
        [Column(TypeName = "tinyint")]
        public byte Nigth { get; set; }

    }
}
