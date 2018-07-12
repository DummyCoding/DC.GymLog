using System;
using System.Collections.Generic;
using System.Text;

namespace DC.GymLog.Data.Entities
{
    public class Participation
    {
        public int ActivityId { get; set; }
        public string ParticipantId { get; set; }

        public virtual Activity Activity { get; set; }
        public virtual ApplicationUser Participant { get; set; }
    }
}
