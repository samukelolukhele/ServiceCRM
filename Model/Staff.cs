using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace server.Model
{
    public class Staff
    {
        public int id { get; set; }
        public string name { get; set; } = default!;
        public Role role { get; set; } = default!;
        public string email { get; set; } = default!;
        public string password { get; set; } = default!;
        public string profile_img { get; set; } = default!;
        public ICollection<AssignedStaffJobs> jobs { get; set; } = default!;
    }
}