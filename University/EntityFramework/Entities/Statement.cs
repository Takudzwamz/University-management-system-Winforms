using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.EntityFramework.Entities
{
    class Statement
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }

        public int? GroupId { get; set; }
        public Group Group { get; set; }

        public int? DisciplineId { get; set; }
        public Discipline Discipline { get; set; }

        public int? EmployeeId { get; set; }
        public Employee Employee { get; set; }

        public ICollection<Mark> Marks { get; set; }
    }
}
