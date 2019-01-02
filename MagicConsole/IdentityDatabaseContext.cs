using Microsoft.AspNet.Identity.EntityFramework;

namespace MagicConsole
{
    public class IdentityDatabaseContext : IdentityDbContext
    {
        public IdentityDatabaseContext() : base("name = Lundgren84ConnectionString") { }
    }
}