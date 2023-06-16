using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace server.Model
{
    public class JobTags
    {
        public int job_id { get; set; }
        public int tag_id { get; set; }
        public ICollection<Job> jobs { get; set; } = default!;
        public ICollection<Tag> tags { get; set; } = default!;
    }
}