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
	public class Home
	{
		public void SearchPatientInfo(string searchText)
		{
			PatientInfoHome home = new PatientInfoHome();
			//home.ClickSymptoms();
			//home.SearchPatientInfo(searchText);
		}
		//public void SelectCheapestElement(IWebDriver driver)
		//{
		//	driver.SwitchTo().Window(driver.WindowHandles[1]);

		//}
	}
}
