using System.Diagnostics;
using NUnit.Framework;
using MvcContrib.TestHelper;
using SpecsFor.Mvc;
using SpecsFor;
using Xvolt.Web.Controllers;

namespace Xvolt.Tests.AcceptanceTests.Routing
{
    public static class HomeTests
    {
        public class when_testing_routing_to_index : SpecsFor<MvcWebApp>
        {
            protected override void When()
            {
                SUT.NavigateTo<HomeController>(x => x.Index());
            }

            [Test]
            public void then_route_should_map_to_index_page()
            {
                SUT.Route.ShouldMapTo<HomeController>(x => x.Index());
            }
        }
    }
}