using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Web.UI.WebControls;

namespace PageObjectLibrary
{
	public class SymptomChecker
	{
		public SymptomChecker()
		{
			PageFactory.InitElements(PropertiesCollection.driver, this);
		}

		#region ObjectDefinitions

		[FindsBy(How = How.XPath, Using = ".//*[@id='agegroup-input']")]
		public IWebElement cmbxAge;
		
		[FindsBy(How = How.XPath , Using = ".//*[@id='ap_email']")]
		public IWebElement txtUserName;

		[FindsBy(How = How.XPath, Using = ".//*[@id='ap_password']")]
		public IWebElement txtPassword;

		[FindsBy(How = How.XPath, Using = ".//*[@id='signInSubmit']")]
		public IWebElement btnLogin;

		#endregion

		#region PageInteractions

		public void SelectAge(string searchText)
			{

				//PropertiesCollection.driver.FindElement(By.XPath(".//option[@Name = '" + searchText + "']")).Click();
					
			}
		

		}

		#endregion
	}
