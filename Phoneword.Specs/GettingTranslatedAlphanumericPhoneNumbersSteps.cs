using TechTalk.SpecFlow;
using Xamarin.UITest;

namespace Phoneword.Specs
{
    [Binding]
    public class GettingTranslatedAlphanumericPhoneNumbersSteps
    {
        private readonly IApp _app;

        public GettingTranslatedAlphanumericPhoneNumbersSteps()
        {
            _app = FeatureContext.Current.Get<IApp>("App");
        }

        [Given(@"I have entered ""(.*)"" into Phoneword")]
        public void GivenIHaveEnteredIntoPhoneword(string alphanumString)
        {
            _app.WaitForElement(c => c.Marked("phoneNumberText").Text(alphanumString));
        }
        
        [When(@"I press Translate")]
        public void WhenIPressTranslate()
        {
            _app.Tap(c => c.Marked("translateButton"));
        }
        
        [Then(@"the result should be ""(.*)""")]
        public void ThenTheResultShouldBe(string translatedNumber)
        {
            _app.WaitForElement(c => c.Marked("callButton")
                .Text("Call " + translatedNumber));
        }
    }
}
