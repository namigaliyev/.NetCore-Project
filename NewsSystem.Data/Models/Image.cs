using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NewsSystem.Data.Models
{
    [Table("Image")]
    public class Image
    {
        public int ID { get; set; }

        public string ImageUrl { get; set; }

        public News News { get; set; }


    }
}