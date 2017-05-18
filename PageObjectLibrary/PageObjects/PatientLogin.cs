using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;
using PageObjectLibrary;

namespace PageObjectLibrary
{
	public class PatientLogin
	{
		public PatientLogin()
		{
			PageFactory.InitElements(PropertiesCollection.driver , this);
		}

		#region ObjectDefinitions

		[FindsBy(How = How.XPath, Using = ".//*[@id='account']/div[2]/span[1]/a")]
		public IWebElement btnmyAccount;

		[FindsBy(How = How.XPath, Using = ".//*[@id='account']/div[2]/ul/li[2]/a")]
		public IWebElement btnPatientInfo;

		[FindsBy(How = How.XPath, Using = ".//*[@id='email']")]
		public IWebElement txtUsername;

		[FindsBy(How = How.XPath, Using = ".//*[@id='password']")]
		public IWebElement txtPassword;

		[FindsBy(How = How.XPath, Using = ".//*[@id='container']/div[1]/div/form/div[3]/input")]
		public IWebElement btnSignin;

		#endregion

		#region PageInteractions

		public PatientInfoHome SignIntoPatient (string Username ,string Password)
		{
			btnmyAccount.Click();
			btnPatientInfo.Click();
			txtUsername.SendKeys(Username);
			txtPassword.SendKeys(Password);
			btnSignin.Click();
			return new PatientInfoHome();
		}

		#endregion
	}
}
