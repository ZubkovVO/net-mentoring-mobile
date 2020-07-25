using Xamarin.UITest;

namespace MobileAppTest
{
    class AppInitializer
    {
        public static IApp StartApp(Platform platform, string pathToApp)
        {
            if (platform == Platform.Android)
            {
                return ConfigureApp.Android.ApkFile(pathToApp).StartApp();
            }

            return ConfigureApp.iOS.StartApp();
        }
    }
}
