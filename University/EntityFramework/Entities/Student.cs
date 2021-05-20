using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.EntityFramework.Entities
{
    class Student
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public int Age { get; set; }

        public int? PaymentTypeId { get; set; }
        public PaymentType PaymentType { get; set; }

        public int? GroupId { get; set; }
        public Group Group { get; set; }

        public ICollection<Mark> Marks { get; set; }
    }
}
