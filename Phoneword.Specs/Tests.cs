//using System;
//using System.IO;
//using System.Linq;
//using NUnit.Framework;
//using TechTalk.SpecFlow;
//using Xamarin.UITest;
//using Xamarin.UITest.Queries;

//namespace Phoneword.Specs
//{
//    [TestFixture(Platform.Android)]
//    [TestFixture(Platform.iOS)]
//    public class Tests
//    {
//        IApp app;
//        Platform platform;

//        public Tests(Platform platform)
//        {
//            this.platform = platform;
//        }

//        [SetUp]
//        public void BeforeEachTest()
//        {
//            app = AppInitializer.StartApp(platform);

//            if (!FeatureContext.Current.ContainsKey("App"))
//            {
//                FeatureContext.Current.Add("App", app);
//            }
//        }

//        [Test]
//        public void AppLaunches()
//        {
//            app.Screenshot("First screen.");
//        }
//    }
//}

