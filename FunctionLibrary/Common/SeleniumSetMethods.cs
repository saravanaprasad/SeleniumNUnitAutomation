using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using FunctionLibrary;
using OpenQA.Selenium.Support.UI;
using PageObjectLibrary;

namespace FunctionLibrary
{
	public static class SeleniumSetMethods
	{
		public static void EnterText(this IWebElement element, string textToEnter)
		{
			element.SendKeys(textToEnter);
		}
		public static void ClickElement(this IWebElement element)
		{
			element.Click();
		}
		public static void SelectDropDown(this IWebElement element, string textToSelect)
		{
			new SelectElement(element).SelectByText(textToSelect);
		}


	}
}
