using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Onion.Domain.Core
{
    public class City
    {
        [Key]
        public int CityID { get; set; }

        [Required]
        [StringLength(250)]
        public string Name { get; set; }

        [Required]
        public bool IsDeleted { get; set; }

        public virtual ICollection<User> Users { get; set; }

        public City()
        {
            IsDeleted = false;
        }
    }
}
