<<<<<<< HEAD
=======
using System.ComponentModel.DataAnnotations;
>>>>>>> 8c2dd74f6bf7b628cc081114ca58de1060e0108d
using System.ComponentModel.DataAnnotations.Schema;

namespace NewsSystem.Data.Models
{
<<<<<<< HEAD
    [Table("Images")]
=======
    [Table("Image")]
>>>>>>> 8c2dd74f6bf7b628cc081114ca58de1060e0108d
    public class Image
    {
        public int ID { get; set; }

<<<<<<< HEAD
        public string imageUrl { get; set; }

        public News News { get; set; }

=======
        public string ImageUrl { get; set; }

        public News News { get; set; }


>>>>>>> 8c2dd74f6bf7b628cc081114ca58de1060e0108d
    }
}