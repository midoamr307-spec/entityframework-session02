using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreAssignment02.Models
{
    [Table("EventOrganizers")]
    internal class Organizer
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [MaxLength(150)]
        public string? CompanyName { get; set; }
        public bool IsVerified { get; set; }


        #region Org v orgPro [1:1]

        public OrganizerProfile? organizeProfile  { get; set; }


        #endregion

        #region 1:M   
        public ICollection<Event> EventAttend { get; set; }

        #endregion

    }
}
