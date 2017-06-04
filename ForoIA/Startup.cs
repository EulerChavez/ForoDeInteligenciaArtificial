using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ForoIA.Startup))]
namespace ForoIA {

    public partial class Startup {

        public void Configuration(IAppBuilder app) {

            app.MapSignalR();
            ConfigureAuth(app);

        }

    }

}
