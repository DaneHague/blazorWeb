using BlazorApp2.Pages;
using Bunit;

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

            cut.Find("p").MarkupMatches("<p role=\"status\">Current count: 1111</p>");
        }
    }
}