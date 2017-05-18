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
	public class PatientInfoHome
	{
		public PatientInfoHome()
		{
			PageFactory.InitElements(PropertiesCollection.driver , this);
		}

		#region ObjectDefinitions

		[FindsBy(How = How.XPath, Using = ".//*[@id='container']//fieldset/label/span[2]/input")]
		public IWebElement txtSearch;

		[FindsBy(How = How.XPath, Using = ".//*[@id='container']//fieldset/input[2]")]
		public IWebElement btnSearch;

		[FindsBy(How = How.XPath, Using = ".//*[@id='site_head']/div[2]/p/a[2]")]
		public IWebElement btnSymptoms;

		#endregion

		
	}
}
