using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace super_hero.Models
{
    public class HeroicAct
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "A description of the heroic act is required")]
        public string Description { get; set; }

        [ForeignKey("Superhero")]
        public int HeroId { get; set; }
        public Superhero Superhero { get; set; }
    }
}