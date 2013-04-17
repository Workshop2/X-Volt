namespace Xvolt.Tests.AcceptanceTests.Routing.Api
{
    public class NewsArticleTests
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