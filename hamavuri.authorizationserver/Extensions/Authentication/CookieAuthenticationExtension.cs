using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hamavuri.authorizationserver
{
    public static class CookieAuthenticationExtension
    {
        public static AuthenticationBuilder AddCookieAuthentication(this AuthenticationBuilder authenticationBuilder)
        {
            authenticationBuilder
                    .AddCookie(CookieAuthenticationScheme.Internal, options =>
                    {
                        options.SlidingExpiration = true;
                        options.ExpireTimeSpan = new TimeSpan(1000 * 1000 * 60 * 20);//20mins
                        options.Cookie.Name = "haCookie";
                        options.Cookie.IsEssential = true;
                        options.Cookie.SameSite = SameSiteMode.None;

                        options.LoginPath = new PathString("/Account/Login");
                        options.LogoutPath = new PathString("/Account/Logout");
                    })
                    .AddCookie(CookieAuthenticationScheme.External, options =>
                    {
                        options.Cookie.Name = CookieAuthenticationScheme.External;
                        options.Cookie.IsEssential = true;
                        options.Cookie.SameSite = SameSiteMode.None;
                    });
            return authenticationBuilder;
        }
    }
}
