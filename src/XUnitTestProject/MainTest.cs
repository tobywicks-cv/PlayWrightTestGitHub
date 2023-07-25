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
            var browserTypeLaunchOptions = new BrowserTypeLaunchOptions()
            {
//#if DEBUG
//                Headless = false,
//#endif
            };

            Console.WriteLine("Before Playwright.CreateAsync");

            using (var playwright = await Playwright.CreateAsync())
            {
                Console.WriteLine("After Playwright.CreateAsync");

                using (var browserTask = playwright.Chromium.LaunchAsync(browserTypeLaunchOptions))
                {
                    var browser = await browserTask;
                    var page = await browser.NewPageAsync();

                    await page.GotoAsync("https://playwright.dev");
                }
            }
        }
    }
}
