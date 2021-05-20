using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using University.EntityFramework.Entities;

namespace University.EntityFramework.UniversityContext
{
    class UniversityContext : DbContext
    {
        static UniversityContext()
        {
            Database.SetInitializer<UniversityContext>(new UniversityInit());
        }

        public UniversityContext() : base("UniversityDb") { }
        

        public DbSet<Cathedra> Cathedra { get; set; }
        public DbSet<Course> Course { get; set; }
        public DbSet<Discipline> Discipline { get; set; }
        public DbSet<Faculty> Faculty { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Group> Group { get; set; }
        public DbSet<Mark> Mark { get; set; }
        public DbSet<PaymentType> PaymentType { get; set; }
        public DbSet<Statement> Statement { get; set; }
        public DbSet<Student> Student { get; set; }
    }
}
