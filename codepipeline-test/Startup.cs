using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(codepipeline_test.Startup))]
namespace codepipeline_test
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
