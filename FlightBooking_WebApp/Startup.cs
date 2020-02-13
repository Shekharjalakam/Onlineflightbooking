using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FlightBooking_WebApp.Startup))]
namespace FlightBooking_WebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
