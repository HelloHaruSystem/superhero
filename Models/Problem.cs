using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace super_hero.Models 
{
    public class Problems
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "A description is required")]
        public string description { get; set; }

        [ForeignKey("Department")]
        public int DepartmentID { get; set; }
        public Department Department { get; set; }
    }
}