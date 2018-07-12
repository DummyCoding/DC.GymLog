using System;
using System.Collections.Generic;

namespace DC.GymLog.Data.Entities
{
    public class Activity
    {
        public Activity()
        {
            Participations = new HashSet<Participation>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime InsertTime { get; set; }
        public string AuthorId { get; set; }
        public virtual ApplicationUser Author { get; set; }
        public string LeaderId { get; set; }
        public virtual ApplicationUser Leader { get; set; }

        public virtual ICollection<Participation> Participations { get; set; }
    }
}
