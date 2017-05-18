using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using UtilityLibrary;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Firefox;
using PageObjectLibrary;

namespace FunctionLibrary
{
	public class SearchResults
	{
		public void SelectCheapestElement(string searchText)
		{
			PropertiesCollection.driver.SwitchTo().Window(PropertiesCollection.driver.WindowHandles[1]);

		}
	}
}
