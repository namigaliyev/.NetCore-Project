using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NewsSystem.Data.Models
{
    [Table("News")]
    public class News
    {
        [Key]
        public int ID { get; set; }

        [Display(Name="News Title")]
        [MaxLength(255,ErrorMessage="You are entered too much!")]
        [Required]
        public string Title { get; set; }
        
        [Display(Name="Short Description")]
        public string shortDescription { get; set; }

        [Display(Name="Description")]
        public string Description { get; set; }
        
        public int Reads { get; set; }

        [Display(Name="is Active")]
        public bool isActive { get; set; }

        [Display(Name="Date Added")]
        public DateTime dateAdded { get; set; }

        [Display(Name="Images")]
        [MaxLength(255,ErrorMessage="You are entered too much!")]
        public string Image { get; set; }

        public virtual ICollection<Image> Images { get; set; }
    }
}