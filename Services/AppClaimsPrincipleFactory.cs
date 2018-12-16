using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using YourGameOfTheYear.Models;

namespace YourGameOfTheYear.Services
{
    public class AppClaimsPrincipleFactory : UserClaimsPrincipalFactory<UserInfo, IdentityRole>
    {
        public AppClaimsPrincipleFactory(
            UserManager<UserInfo> userManager,
            RoleManager<IdentityRole> roleManager,
            IOptions<IdentityOptions> optionsAccessor
            ) : base(userManager, roleManager, optionsAccessor)
        {

        }
        public async override Task<ClaimsPrincipal> CreateAsync(UserInfo user)
        {
            var principal = await base.CreateAsync(user);
            return principal;
        }
    }
}
