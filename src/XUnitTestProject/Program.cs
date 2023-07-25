using System.Threading.Tasks;

namespace XUnitTestProject
{
    public static class Program
    {
        public static async Task Main()
        {
            var mainClass = new MainTest();
            await mainClass.TestPlayWright();
        }
    }
}
