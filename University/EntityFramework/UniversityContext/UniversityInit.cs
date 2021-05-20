using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using University.EntityFramework.Entities;

namespace University.EntityFramework.UniversityContext
{
    class UniversityInit : DropCreateDatabaseIfModelChanges<UniversityContext>
    {
        protected override void Seed(UniversityContext context)
        {
            context.SaveChanges();
        }
    }
}
