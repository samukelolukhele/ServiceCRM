using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace server.Model
{
    public class Job
    {
        public int id { get; set; }
        public string title { get; set; } = default!;
        public string job_description { get; set; } = default!;
        public JobStatus status { get; set; } = default!;
        public Client client { get; set; } = default!;
        public ICollection<JobTags> tags { get; set; } = default!;
        public ICollection<AssignedStaffJobs> staff { get; set; } = default!;
    }
}