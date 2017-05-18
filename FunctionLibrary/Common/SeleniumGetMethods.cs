using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using FunctionLibrary;
using OpenQA.Selenium.Support.UI ;
using PageObjectLibrary;

namespace FunctionLibrary
{

	public static class SeleniumGetMethods
	{
		/// <summary>
		/// Extention method for get methods
		/// </summary>
		public static string GetText(this IWebElement element)
		{
			return element.GetAttribute("value");
		}

		public static string GetTextfromDropDown(this IWebElement element)
		{			
			return new SelectElement(element).AllSelectedOptions.SingleOrDefault().Text.ToString().Trim();				
				
		}

		public static string GetCellValue()
		{
			return string.Empty;
		}

		
	
	}
}
