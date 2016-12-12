﻿using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Owin;

namespace BloombergReaderWeb.App_Start
{
    // http://kristianguevara.net/creating-your-asp-net-mvc-5-application-from-scratch-for-beginners-using-entity-framework-6-and-identity-with-crud-functionalities/
    // Adding Authentication Security and Unauthorized Page Placeholder
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType = "ApplicationCookie",
                LoginPath = new PathString("/auth/login")
            });
        }
    }
}