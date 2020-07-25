using NUnit.Framework;
using Xamarin.UITest;

namespace MobileAppTest
{
    [TestFixture(Platform.Android)]
    public class Tests
    {
        IApp app;
        Platform platform;
        public string _path = @"D:\Logs\test.apk";

        public Tests(Platform platform)
        {
            this.platform = platform;
        }

        [SetUp]
        public void BeforeEachTest()
        {
            app = AppInitializer.StartApp(platform, _path);
        }

        [Test]
        public void WelcomeTextIsDisplayed()
        {
            app.Repl();
        }
    }
}