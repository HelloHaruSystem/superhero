using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace super_hero.Models 
{
    public class Department
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "A department name is required")]
        [MaxLength(100)]
        public string Name { get; set; }

        [ForeignKey("PostCode")]
        public int PostCode { get; set; }
        public PostCode PostCodeNav { get; set; } 
        

        // add Icollections for one to many relationships (Problems, Superheroes, leaders)
    }
}