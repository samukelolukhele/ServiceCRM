using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace server.Model
{
    public class Client
    {
        public int id { get; set; }
        public string name { get; set; } = default!;
        public string email { get; set; } = default!;
        public int revenue_generated { get; set; }
        public int phone_number { get; set; }
        public ClientStatus status { get; set; } = default!;
        public ICollection<Job> jobs { get; set; } = default!;
    }
}