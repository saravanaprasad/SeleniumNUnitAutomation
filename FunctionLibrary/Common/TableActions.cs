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
	public class TableActions
	{
		static List<TableDataCollection> _tableDataCollection = new List<TableDataCollection>();

		public void ReadTable(IWebElement table)
		{
			var columns = table.FindElements(By.TagName("th"));
			var rows = table.FindElements(By.TagName("tr"));
			int rowIndex = 0;
			foreach (var row in rows)
			{
				int ColumnIndex = 0;
				var colDatas = row.FindElements(By.TagName("td"));
				foreach (var colValue in colDatas)
				{
					_tableDataCollection.Add(new TableDataCollection
					{
						RowNumber = rowIndex,
						ColumnName = columns[ColumnIndex].Text != "" ?
									columns[ColumnIndex].Text : ColumnIndex.ToString() ,
						ColumnValue = colValue.Text,
						//ColumnSpecialValues = colValue.Text != "" ? null :colValue.FindElements(By.TagName("input"))
					});
					ColumnIndex++;
				}
				rowIndex++;
			}
		}

		public static string ReadCell(string columnName , int rowNumber )
		{
			var data = (from e in _tableDataCollection
                        where e.ColumnName == columnName && e.RowNumber == rowNumber
                        select e.ColumnValue).SingleOrDefault();
 
            return data;
		}		
	}


	public class TableDataCollection
	{
		public int RowNumber {get ; set ;}
		public string  ColumnName {get ; set ;}
		public string ColumnValue { get; set; }
	//	public IEnumerable  <IWebElement> ColumnSpecialValues { get; set; }
	}
}
