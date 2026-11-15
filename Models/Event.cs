using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreAssignment02.Models
{
    internal class Event
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime? EndDate { get; set; }
        public int MaxNumAttendees { get; set; }

        #region 1:M

        public Organizer? organizers { get; set; }
        public int organizersId { get; set; }

        #endregion


    }
}
