using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Onion.Domain.Core
{
    public class User
    {
        [Key]
        public int UserID { get; set; }

        [StringLength(250)]
        public string FullName { get; set; }

        [Required]
        [StringLength(12)]
        public string Phone { get; set; }

        [Required]
        [StringLength(250)]
        public string Email { get; set; }

        [ForeignKey("City")]
        public int CityID { get; set; }

        public virtual City City { get; set; }
    }
}
