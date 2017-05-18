using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Firefox;
using PageObjectLibrary;

namespace FunctionLibrary
{
	public class Login
	{
		public void LoginToPatientInfo(string Username, string Password)
		{
			PatientLogin loginPage = new PatientLogin();
			//loginPage.btnmyAccount.ClickElement();
			//loginPage.btnPatientInfo.ClickElement();
			//loginPage.txtUsername.EnterText(Username);
			//loginPage.txtPassword.EnterText(Password);
			//loginPage.btnSignin.ClickElement();
			Report report = new Report();
			report.InitReport();
			report.CreateTestCase("Login");
			report.TestInfo("Entered Username");
			report.TestInfo("Entered Password");
			report.TestPass("Login", "Login to Patient Info Successful");
			report.CreateTestCase("Login01");
			report.TestInfo("Entered Username");
			report.TestInfo("Entered Password");
			report.TestPass("Login01", "Login to Patient Info Successful");
			report.CreateTestCase("Login02");
			report.TestInfo("Entered Username");
			report.TestInfo("Entered Password");
			report.TestPass("Login02", "Login to Patient Info Successful");
			report.CreateTestCase("Login03");
			report.TestInfo("Entered Username");
			report.TestInfo("Entered Password");
			report.TestPass("Login03", "Login to Patient Info Successful");
			report.CloseReport();

		}		
	}
}
