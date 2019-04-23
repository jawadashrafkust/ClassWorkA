using ClassWork2.Models;

namespace ClassWork2.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ClassWork2.Models.UniDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ClassWork2.Models.UniDBContext db)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

//            db.Students.AddOrUpdate(s => s.Id,
//                new Student()
//                {
//                    FullName = "ABC",
//                    FatherName = "XYZ",
//                    DoB = new DateTime(2000,1,1),
//                    Percentage = (decimal)66.0
//                },
//                new Student()
//                {
//                    FullName = "AAA",
//                    FatherName = "ZZZ",
//                    DoB = new DateTime(1995, 1, 1),
//                    Percentage = (decimal)65.0
//                }
//
//                );

        }
    }
}
