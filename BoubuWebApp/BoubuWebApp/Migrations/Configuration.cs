namespace BoubuWebApp.Migrations
{
    using BoubuWebApp.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<BoubuWebApp.Models.EmployeeContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(BoubuWebApp.Models.EmployeeContext context)
        {
            // Samples�e�[�u����2�̃��R�[�h��ǉ��܂��͍X�V����
            context.Employees.AddOrUpdate(
            p => p.Id,
            new Employee { Name = "����", Birth = DateTime.Parse("1995/04/28") },
            new Employee { Name = "�J���g", Birth = DateTime.Parse("1995/04/29") },
            new Employee { Name = "�n���t", Birth = DateTime.Parse("1995/04/30") }
            );
        }
    }
}
