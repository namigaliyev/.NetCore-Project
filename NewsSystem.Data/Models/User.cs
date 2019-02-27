using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NewsSystem.Data.Models
{
    [Table("Users")]
    public class User
    {
        [Key]
        public int ID { get; set; }
        
        [MaxLength(150,ErrorMessage = "Please do not enter more than 150 characters ")]
        public string NameSurname { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [DataType(DataType.Password)]
        [Required]
        [MaxLength(16, ErrorMessage = "Please do not enter more than 16 characters ")]
        public string Password { get; set; }
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$",ErrorMessage = "Please enter a valid email address !")]
        public DateTime DateOFRegistration { get; set; }

        public bool IsActive { get; set; }

        public virtual Role Role { get; set; }
    }
}
