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

        [Display(Name="Title of news")]
        [MaxLength(255,ErrorMessage="You have enreted to much")]
        [Required]
        public string Title { get; set; }

        [Display(Name="Short Description")]
        public string shortDescription { get; set; }

        [Display(Name="Description")]
        public string Description { get; set; }

        public int Reads { get; set; }
        
        [Display(Name="is Avtive")]
        public bool isActive { get; set; }

        [Display(Name="Insertion Date")]
        public DateTime insertionDate { get; set; }

        public virtual User  User { get; set; }

        [Display(Name="Image")]
        [MaxLength(255,ErrorMessage="You have enreted to much")]
        public string Image { get; set; }

        public virtual ICollection<Image> Images { get; set; }
    }
}