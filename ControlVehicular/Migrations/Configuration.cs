namespace ControlVehicular.Migrations
{
    using ControlVehicular.Constants;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Web.Security;
    using WebMatrix.WebData;

    internal sealed class Configuration : DbMigrationsConfiguration<ControlVehicular.Models.EntitiesContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(ControlVehicular.Models.EntitiesContext context)
        {

            if (!WebSecurity.Initialized)
            {
                WebSecurity.InitializeDatabaseConnection(ConnectionStrings.DataBaseConnectionName, "UserProfile", "UserId", "UserName", autoCreateTables: true);
            }

            if (!Roles.RoleExists(RolesConstants.Administrator))
            {
                Roles.CreateRole(RolesConstants.Administrator);
            }

            if (!Roles.RoleExists(RolesConstants.DepartmentChief))
            {
                Roles.CreateRole(RolesConstants.Security);
            }

            if (!Roles.RoleExists(RolesConstants.DepartmentChief))
            {
                Roles.CreateRole(RolesConstants.Security);
            }

            string admin="Admin";
            if (!WebSecurity.UserExists(admin))
            {
                WebSecurity.CreateUserAndAccount(admin, "nimdA", false);
            }

            if (!Roles.IsUserInRole(admin, RolesConstants.Administrator))
            {
                Roles.AddUserToRoles(admin, new string[] { RolesConstants.Administrator });
            }
        }
    }
}
