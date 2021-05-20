using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.EntityFramework.Entities
{
    class Mark
    {
        public int Id { get; set; }
        public int Value { get; set; }

        public int? StudentId { get; set; }
        public Student Student { get; set; }

        public int? StatementId { get; set; }
        public Statement Statement { get; set; }
    }
}
