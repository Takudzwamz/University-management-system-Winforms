using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.EntityFramework.Entities
{
    class Cathedra
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int? FacultyId { get; set; }
        public Faculty Faculty { get; set; }

        public ICollection<Employee> Employees { get; set; }

        public ICollection<Group> Groups { get; set; }
    }
}
