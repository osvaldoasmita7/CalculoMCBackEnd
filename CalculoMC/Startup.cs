using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Owin;
using Owin;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web.Http;
using Microsoft.Owin.Security.OAuth;
using Newtonsoft.Json.Serialization;
using Microsoft.Owin.Cors;

[assembly: OwinStartup(typeof(CalculoMC.Startup))]

namespace CalculoMC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseCors(Microsoft.Owin.Cors.CorsOptions.AllowAll);
            ConfigureAuth(app);
        }
    }
}
