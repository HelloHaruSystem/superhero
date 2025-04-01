using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace super_hero.Models 
{
        public class PostCode
    {
        [Key]
        public int PostalCode { get; set; }

        [Required(ErrorMessage = "An Key is required")]
        [MaxLength(100)]
        public string CityName { get; set; }

        // add a Icollection<Department> later? for ORM queries if needed later
        // this can be needed because postal codes have a one to many relationship with departments
    }
}