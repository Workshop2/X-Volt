using MvcContrib.TestHelper;
using NUnit.Framework;
using SpecsFor;
using SpecsFor.Mvc;
using Xvolt.Web.Controllers;

namespace Xvolt.Tests.AcceptanceTests.Routing
{
    public static class RootTest
    {
        public class when_testing_routing_for_website_route : SpecsFor<MvcWebApp>
        {
            protected override void When()
            {
                SUT.Browser.Navigate().GoToUrl(MvcWebApp.BaseUrl);
            }

            [Test]
            public void then_route_should_map_to_home_index_page()
            {
                SUT.Route.ShouldMapTo<HomeController>(x => x.Index());
            }
        }
    }
}