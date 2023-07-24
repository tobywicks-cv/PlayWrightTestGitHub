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
            }
        }
    }
}
