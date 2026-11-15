using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreAssignment02.Models
{
    internal class OrganizerProfile
    {
        public int Id { get; set; }
        public string? Biography { get; set; }
        public string? Website { get; set; }
        public string? Logo { get; set; }

        #region Org v orgPro [1:1]

        public Organizer Organize { get; set; }
        public int OrganizeId { get; set; }

        #endregion
    }
}
