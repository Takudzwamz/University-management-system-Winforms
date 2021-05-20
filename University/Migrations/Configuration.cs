namespace University.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using University.EntityFramework.Entities;

    internal sealed class Configuration : DbMigrationsConfiguration<University.EntityFramework.UniversityContext.UniversityContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(University.EntityFramework.UniversityContext.UniversityContext context)
        {
            //context.Course.Add(new Course { Name = "1" });
            context.Course.Add(new Course { Name = "2" });
            context.Course.Add(new Course { Name = "3" });
            context.Course.Add(new Course { Name = "4" });
            context.Course.Add(new Course { Name = "5" });
            context.Course.Add(new Course { Name = "6" });

            context.Faculty.Add(new Faculty { Name = "AMM" });
            context.Faculty.Add(new Faculty { Name = "Math" });
            context.Faculty.Add(new Faculty { Name = "Geography" });
            context.Faculty.Add(new Faculty { Name = "Physics" });
            context.Faculty.Add(new Faculty { Name = "Chemestry" });
            context.Faculty.Add(new Faculty { Name = "CSF" });

            context.SaveChanges();
        }
    }
}
