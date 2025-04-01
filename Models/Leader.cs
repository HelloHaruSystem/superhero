using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace super_hero.Models
{
    public class leader
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "A name of the leader is required")]
        [MaxLength(75)]
        public string Name { get; set; }

        [ForeignKey("Department")]
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
    }
}