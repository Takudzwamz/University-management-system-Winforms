using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.EntityFramework.Entities
{
    class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int? CathedraID { get; set; }
        public Cathedra Cathedra { get; set; }

        public int? CourseID { get; set; }
        public Course Course {get; set; }
        
        public ICollection<Student> Students { get; set; }

        public ICollection<Statement> Statements { get; set; }
    }
}
