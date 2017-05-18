using System;
using TechTalk.SpecFlow;
using FunctionLibrary;
using TechTalk.SpecFlow.Assist;

namespace NUnit.Tests1.Implementations
{
    [Binding]
    public class PatientInfoSteps
    {
		
		[Given(@"I have logged into my Patient Account using my credentials")]
        public void GivenIHaveLoggedIntoMyPatientAccountUsingMyCredentials(Table table)
        {			
			var userdata = table.CreateInstance<UserData>();

			Initialize initdriver = new Initialize();
			initdriver.InitializeDriver(Browser.Chrome, userdata.url);

			Login loginPage = new Login();		
			loginPage.LoginToPatientInfo(userdata.Username, userdata.Password);			
        }
		
		[Given(@"I search for the item (.*)")]
		public void GivenISearchForTheItem(string itemDescription)
		{
			Home home = new Home();
			home.SearchPatientInfo(itemDescription);
			//driver.Manage().Timeouts().ImplicitlyWait(System.TimeSpan.FromMillisecond);
			SymptomCheck check = new SymptomCheck();
			
			check.SelectElement(itemDescription);

		}


        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int p0)
        {
            ScenarioContext.Current.Pending();
        }
    }

	class UserData
	{
		public string Username { get; set; }
		public string Password { get; set; }
		public string url { get; set; }
	}
}
