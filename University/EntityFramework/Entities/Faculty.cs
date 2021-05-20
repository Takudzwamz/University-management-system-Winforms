using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.EntityFramework.Entities
{
    class Faculty
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Cathedra> Cathedras { get; set; }
    }
}
