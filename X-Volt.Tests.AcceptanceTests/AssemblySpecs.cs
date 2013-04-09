using NUnit.Framework;
using SpecsFor.Mvc;
using Xvolt;
using Xvolt.App_Start;

namespace X_Volt.Tests.AcceptanceTests
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

            //TODO: The order of registration matters right now, but it shouldn't. 
            //config.RegisterArea<TasksAreaRegistration>();
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