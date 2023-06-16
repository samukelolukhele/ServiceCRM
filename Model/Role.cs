using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace server.Model
{
    public class Role
    {
        public int id { get; set; }
        public string name { get; set; } = default!;
        public ICollection<Staff> staff_members { get; set; } = default!;
    }
}