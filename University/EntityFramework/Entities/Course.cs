using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.EntityFramework.Entities
{
    class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Group> Groups { get; set; }
    }
}
