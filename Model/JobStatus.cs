using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace server.Model
{
    public class JobStatus
    {
        public int id { get; set; }
        public string title { get; set; } = default!;
        public string description { get; set; } = default!;
        public ICollection<Job> jobs { get; set; } = default!;
    }
}