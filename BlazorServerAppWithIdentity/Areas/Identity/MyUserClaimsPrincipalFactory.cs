using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using System.Security.Claims;

namespace BlazorServerAppWithIdentity.Areas.Identity
{
    internal class MyUserClaimsPrincipalFactory : UserClaimsPrincipalFactory<IdentityUser>
    {
        public MyUserClaimsPrincipalFactory(UserManager<IdentityUser> userManager, IOptions<IdentityOptions> optionsAccessor) 
            : base(userManager, optionsAccessor)
        {
        }

        protected override async Task<ClaimsIdentity> GenerateClaimsAsync(IdentityUser user)
        {
            var identity = await base.GenerateClaimsAsync(user);
            var email = identity.Claims.First(o => o.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/emailaddress").Value;

            if (email.Equals("administrator@dh.com"))
            {
                identity.AddClaim(new Claim("customclaim", "customclaimvalue"));
                identity.AddClaim(new Claim(ClaimTypes.Role, "administrator"));
            }

            if (email.Equals("superadmin@dh.com"))
            {
                identity.AddClaim(new Claim("customclaim", "customclaimvalue"));
                identity.AddClaim(new Claim(ClaimTypes.Role, "superamdin"));
            }

            return identity;
        }
    }
}