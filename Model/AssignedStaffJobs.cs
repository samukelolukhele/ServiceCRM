using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace server.Model
{
    public class AssignedStaffJobs
    {
        public int staff_id { get; set; }
        public int job_id { get; set; }
        public Staff staff { get; set; } = default!;
        public Job job { get; set; } = default!;
    }
}