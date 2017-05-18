using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;

namespace FunctionLibrary
{
	public class Report
	{
		public static ExtentReports extent;
		public static ExtentTest test;

		public void InitReport()
		{
			string path = System.Reflection.Assembly.GetCallingAssembly().CodeBase;
			string actualPath = path.Substring(0, path.LastIndexOf("bin"));
			string projectPath = new Uri(actualPath).LocalPath;			
			string reportPath = projectPath + "Reports\\ExtentStepLogs.html";
			ExtentHtmlReporter htmlReporter = new ExtentHtmlReporter(reportPath);
			extent = new ExtentReports();        

			extent.AddSystemInfo("Host Name", "Saravana Prasad_VM-11");
			extent.AddSystemInfo("Environment", "QA");
			extent.AddSystemInfo("User Name", "Saravana Prasad");		
			extent.AttachReporter(htmlReporter);	
			
		}

		public void CreateTestCase(string TestCaseName)
		{
			test = extent.CreateTest(TestCaseName, "");
		}

		public void TestPass(string TestCaseName,string LogMessage)
		{
			////var test = extent.CreateTest(TestCaseName);
			test.Log(Status.Pass, LogMessage,MediaEntityBuilder.CreateScreenCaptureFromPath("screenshot.png").Build());
		}

		public void TestFail(string TestCaseName, string LogMessage)
		{
			//var test = extent.CreateTest(TestCaseName);
			test.Log(Status.Fail , LogMessage,MediaEntityBuilder.CreateScreenCaptureFromPath("screenshot.png").Build());
		}
		public void TestInfo(string LogMessage)
		{
			test.Log(Status.Info, LogMessage);
		}

		public void Screenshot()
		{
			test.AddScreenCaptureFromPath("screenshot.png");
		}

		public void CloseReport()
		{
			extent.Flush();		
		}


	}
}
