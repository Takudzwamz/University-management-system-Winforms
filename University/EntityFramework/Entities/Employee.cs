using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.EntityFramework.Entities
{
    class Employee
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Position { get; set; }
        
        public int? CathedraId { get; set; }
        public Cathedra Cathedra { get; set; }
    }
}
