using System.Collections.Generic;
using NUnit.Framework;
using Should;
using SpecsFor;
using Xvolt.Domain.Cache.Services;
using Xvolt.Domain.Entities;
using Xvolt.Tests.UnitTests.Stubs;

namespace Xvolt.Tests.UnitTests.Cache.Services
{
    public class when_calling_get_news_articles_once_given_articles : SpecsFor<NewsServiceCache>
    {
        private readonly NewsServiceStub _newsServiceStub = new NewsServiceStub();
        private IEnumerable<NewsArticle> _articles;

        protected override void InitializeClassUnderTest()
        {
            SUT = new NewsServiceCache(_newsServiceStub);
        }

        protected override void Given()
        {
            _newsServiceStub.GetNewsArticlesValues = new List<NewsArticle>
            {
                new NewsArticle { Title = "Test Title" }
            };
        }

        protected override void When()
        {
            _articles = SUT.GetNewsArticles();
        }

        [Test]
        public void then_should_return_expected_article()
        {
            _articles.ShouldEqual(_newsServiceStub.GetNewsArticlesValues);
        }

        [Test]
        public void then_should_only_call_child_service_once()
        {
            _newsServiceStub.GetNewsArticlesCallCount.ShouldEqual(1);
        }
    }

    public class when_calling_get_news_articles_twice_given_articles : SpecsFor<NewsServiceCache>
    {
        private readonly NewsServiceStub _newsServiceStub = new NewsServiceStub();
        private IEnumerable<NewsArticle> _articles;

        protected override void InitializeClassUnderTest()
        {
            SUT = new NewsServiceCache(_newsServiceStub);
        }

        protected override void Given()
        {
            _newsServiceStub.GetNewsArticlesValues = new List<NewsArticle>
            {
                new NewsArticle { Title = "Test Title" }
            };
        }

        protected override void When()
        {
            SUT.GetNewsArticles();
            _articles = SUT.GetNewsArticles();
        }

        [Test]
        public void then_should_return_expected_article()
        {
            _articles.ShouldEqual(_newsServiceStub.GetNewsArticlesValues);
        }

        [Test]
        public void then_should_only_call_child_service_once()
        {
            _newsServiceStub.GetNewsArticlesCallCount.ShouldEqual(1);
        }
    }

    public class when_testing_dispose : SpecsFor<NewsServiceCache>
    {
        private readonly NewsServiceStub _newsServiceStub = new NewsServiceStub();
        protected override void InitializeClassUnderTest()
        {
            SUT = new NewsServiceCache(_newsServiceStub);
        }

        protected override void When()
        {
            SUT.Dispose();
        }

        [Test]
        public void then_should_dispose_child_service()
        {
            _newsServiceStub.Disposed.ShouldBeTrue();
        }
    }
}