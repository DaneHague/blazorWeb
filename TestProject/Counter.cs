using AngleSharp;
using BlazorApp2.Data;
using BlazorApp2.Pages;
using Bunit;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace TestProject
{
    public class CounterTest
    {
        [Fact]
        public void CounterIncr()
        {
            using var ctx = new TestContext();

            var cut = ctx.RenderComponent<Counter>();
            cut.Find("button").Click();

            cut.Find("p").MarkupMatches("<p role=\"status\">Current count: 1</p>");
        }
    }
}