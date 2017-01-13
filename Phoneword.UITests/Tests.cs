using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace Phoneword.UITests
{
    [TestFixture(Platform.Android)]
    [TestFixture(Platform.iOS)]
    public class Tests
    {
        IApp app;
        Platform platform; 

        public Tests(Platform platform)
        {
            this.platform = platform;
        }
         
        [SetUp]
        public void BeforeEachTest()
        {
            app = AppInitializer.StartApp(platform);
        }

        [Test]
        public void ScreenContainsDefaultInputText()
        {
            app.WaitForElement(c => c.Marked("phoneNumberText").Text("1-855-XAMARIN"));
        }
            
        [Test]
        public void TappingOnButtonTranslatesDefaultText()
        {
            app.WaitForElement(c => c.Marked("phoneNumberText").Text("1-855-XAMARIN"));
            app.Tap(c => c.Marked("translateButton"));
            app.WaitForElement(c => c.Marked("callButton").Text("Call 1-855-9262746"));
        }
    }
}

