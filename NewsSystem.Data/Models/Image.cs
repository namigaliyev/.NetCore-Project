using System.ComponentModel.DataAnnotations.Schema;

namespace NewsSystem.Data.Models
{
    [Table("Images")]
    public class Image
    {
        public int ID { get; set; }

        public string imageUrl { get; set; }

        public News News { get; set; }

    }
}