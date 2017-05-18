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
	public class Initialize
	{
		IWebDriver driver;
		public  void  InitializeDriver(Browser browser , string url)
		{
			switch (browser)
			{
				case Browser.Chrome :
					
					ChromeOptions chromeOptions = new ChromeOptions();				
				//	options.AddExtension("--load-extension=" + @"C:\Users\Saravana Prasad\AppData\Local\Google\Chrome\User Data\Default\Extensions\gighmmpiobklfepjocnamgkkbiglidom\3.10.0_0");
					chromeOptions.AddArgument("start-maximized");
					driver = new ChromeDriver(chromeOptions);					
					break;
				case Browser.Firefox :
					FirefoxOptions fireFoxOptions = new FirefoxOptions();
					fireFoxOptions.AddArgument("--start-maximized");
					driver = new FirefoxDriver(fireFoxOptions);
					break;
				case Browser.IE:									
					driver = new InternetExplorerDriver(); 
					break;
				default :
					driver = new FirefoxDriver();
					break;
			}
			PropertiesCollection.driver = driver;
			PropertiesCollection.driver.Navigate().GoToUrl(url);
			
		}
	}
}
