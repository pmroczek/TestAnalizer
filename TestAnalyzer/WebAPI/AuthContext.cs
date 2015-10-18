using Microsoft.AspNet.Identity.EntityFramework;

namespace WebAPI 
{
    public class AuthContext : IdentityDbContext<IdentityUser>
    {
        public AuthContext()
            : base("AuthContext")
        {

        }
    }
}