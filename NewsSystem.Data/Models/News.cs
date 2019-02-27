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

<<<<<<< HEAD
        [Display(Name="News Title")]
        [MaxLength(255,ErrorMessage="You are entered too much!")]
        [Required]
        public string Title { get; set; }
        
=======
        [Display(Name="Title of news")]
        [MaxLength(255,ErrorMessage="You have enreted to much")]
        [Required]
        public string Title { get; set; }

>>>>>>> 8c2dd74f6bf7b628cc081114ca58de1060e0108d
        [Display(Name="Short Description")]
        public string shortDescription { get; set; }

        [Display(Name="Description")]
        public string Description { get; set; }
<<<<<<< HEAD
        
        public int Reads { get; set; }

        [Display(Name="is Active")]
        public bool isActive { get; set; }

        [Display(Name="Date Added")]
        public DateTime dateAdded { get; set; }

        [Display(Name="Images")]
        [MaxLength(255,ErrorMessage="You are entered too much!")]
=======

        public int Reads { get; set; }
        
        [Display(Name="is Avtive")]
        public bool isActive { get; set; }

        [Display(Name="Insertion Date")]
        public DateTime insertionDate { get; set; }

        public virtual User  User { get; set; }

        [Display(Name="Image")]
        [MaxLength(255,ErrorMessage="You have enreted to much")]
>>>>>>> 8c2dd74f6bf7b628cc081114ca58de1060e0108d
        public string Image { get; set; }

        public virtual ICollection<Image> Images { get; set; }
    }
}