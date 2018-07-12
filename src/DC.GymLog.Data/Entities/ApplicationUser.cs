using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace DC.GymLog.Data.Entities
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public ApplicationUser()
        {
            AuthoredActivities = new HashSet<Activity>();
            LeadActivities = new HashSet<Activity>();
            Participations = new HashSet<Participation>();
        }

        public virtual ICollection<Activity> AuthoredActivities { get; set; }
        public virtual ICollection<Activity> LeadActivities { get; set; }
        public virtual ICollection<Participation> Participations { get; set; }
    }
}
