using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PageObjectLibrary;

namespace FunctionLibrary
{
	public class SymptomCheck
	{
		public void SelectElement(string searchText)
		{
			SymptomChecker symptom = new SymptomChecker();
			symptom.SelectAge(searchText);
		}
	}
}
