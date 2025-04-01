using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace super_hero.Models 
{
    public class Department
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "An description is required")]
        public string Description { get; set; }

        [ForeignKey("PostCode")]
        public int PostCode { get; set; }


        // add Icollections for one to many relationships (Problems, Superheroes, leaders)
    }
}