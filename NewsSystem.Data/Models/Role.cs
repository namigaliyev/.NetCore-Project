using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NewsSystem.Data.Models
{
    [Table("Role")]
    public class Role
    {
        [Key]
        public int ID { get; set; }

        [Display(Name = "Role Name :")]
        [MinLength(3, ErrorMessage = "Please enter more than 3 characters !"), MaxLength(150, ErrorMessage = "Please do not enter more than 150 characters !")]
        public string RoleName { get; set; }
    }
}
