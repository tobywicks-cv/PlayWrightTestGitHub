using System;
using System.Threading.Tasks;
using Microsoft.Playwright;
using Xunit;

namespace XUnitTestProject
{
    public class MainTest
    {
        [Fact]
        public async Task TestPlayWright()
        {
            Console.WriteLine("Before Playwright.CreateAsync");

            using (var playwright = await Playwright.CreateAsync())
            {
                Console.WriteLine("After Playwright.CreateAsync");

                using (var browserTask = playwright.Chromium.LaunchAsync())
                {
                    var browser = await browserTask;
                    var page = await browser.NewPageAsync();

                    await page.GotoAsync("https://playwright.dev");
                }
            }
        }
    }
}
