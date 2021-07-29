using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONChallenge
{
    public class SecurityBadge
    {
        public int BadgeId { get; set; }
        public List<string> listOfDoors { get; set; }
        public bool HasSecurityClearance { get; set; }
        public int EmployeeId { get; set; }
        public DateTime CreatedOn { get; set; }

    }
}
