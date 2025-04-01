using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace super_hero.Models
{
    public class Superheroes
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "A name is required for the superhero")]
        [MaxLength(75)]
        public string Name { get; set; }

        [MaxLength(100)]
        public string HeroPower { get; set; }

        public int HeroLevel { get; set; }

        public string Weakness { get; set; }

        [ForeignKey("Department")]
        public int DepartmentId { get; set; }
        public Department Department { get; set; }

        // add a Icollection<HeroicAct> HeroicActs for one to many relationship
    }
}