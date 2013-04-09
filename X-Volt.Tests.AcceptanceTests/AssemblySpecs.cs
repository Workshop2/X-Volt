using NUnit.Framework;
using SpecsFor.Mvc;
using Xvolt.App_Start;

namespace Xvolt.Tests.AcceptanceTests
{
    [SetUpFixture]
    public class AssemblySpecs
    {
        private SpecsForIntegrationHost _host;

        [SetUp]
        public void SetupTestRun()
        {
            var config = new SpecsForMvcConfig();
            config.UseIISExpress()
                .With(Project.Named("X-Volt"));
                //.ApplyWebConfigTransformForConfig("Test");

            config.BuildRoutesUsing(RouteConfig.RegisterRoutes);

            //NOTE: You can use whatever browser you want.  For build servers, you can check an environment
            //		variable to determine which browser to use, enabling you to re-run the same suite of
            //		tests once for each browser. 
            //config.UseBrowser(BrowserDriver.InternetExplorer);
            config.UseBrowser(BrowserDriver.Chrome);
            //config.UseBrowser(BrowserDriver.Firefox);

            config.InterceptEmailMessagesOnPort(13565);
            
            _host = new SpecsForIntegrationHost(config);
            _host.Start();
        }

        [TearDown]
        public void TearDownTestRun()
        {
            _host.Shutdown();
        }
    }
}