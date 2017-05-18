using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium ;

namespace UtilityLibrary
{
	public class Switcher
	{
		public IWebDriver SwitchToTab(IWebDriver driver)
		{
			var popup = driver.WindowHandles[1]; // handler for the new tab
			driver.SwitchTo().Window(driver.WindowHandles[1]).Close(); // close the tab
			driver.SwitchTo().Window(driver.WindowHandles[0]); // get back to the main window
			return driver;
		}
	}
}
