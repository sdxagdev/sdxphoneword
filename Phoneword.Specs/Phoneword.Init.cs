using NUnit.Framework;
using TechTalk.SpecFlow;
using Xamarin.UITest;

namespace Phoneword.Specs
{
    [TestFixture(Platform.Android)]
    [TestFixture(Platform.iOS)]
    public partial class GettingTranslatedAlphanumericPhoneNumbersFeature
    {
        private readonly Platform _platform;
        private IApp _app;

        public GettingTranslatedAlphanumericPhoneNumbersFeature(Platform platform)
        {
            _platform = platform;
        }

        [SetUp]
        public void BeforeEachTest()
        {
            _app = AppInitializer.StartApp(_platform);

            if (!FeatureContext.Current.ContainsKey("App"))
            {
                FeatureContext.Current.Add("App", _app);
            }
        }
    }
}
