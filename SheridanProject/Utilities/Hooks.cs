using OpenQA.Selenium.Chrome;
using BoDi;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using AventStack.ExtentReports.Reporter;

namespace SheridanAutoProject.Utilities
{
    [Binding]
    public class Hooks
    {
        private readonly IObjectContainer _objectContainer;
        private static IWebDriver _driver;
        private static ExtentTest featureName;
        private static ExtentTest scenario;
        private static ExtentReports extent;
        public static string ReportPath;

        public Hooks(IObjectContainer objectContainer)
        {
            _objectContainer = objectContainer;
        }

        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory.Replace("\\bin\\Debug\\net6.0", "\\");
            path = path + "TestReport\\index.html";
            ExtentHtmlReporter htmlReporter = new ExtentHtmlReporter(path);
            htmlReporter.Config.Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Standard;
            extent = new ExtentReports();
            extent.AttachReporter(htmlReporter);
        }

        public static string TakeScreenshot()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory.Replace("\\bin\\Debug\\net6.0", "\\") + "Screenshot\\";
            if (!Directory.Exists(path)) Directory.CreateDirectory(path);
            path = path + Guid.NewGuid() + ".png";
            Screenshot screenshot = ((ITakesScreenshot)_driver).GetScreenshot();
            screenshot.SaveAsFile(path, ScreenshotImageFormat.Png);
            return path;
        }

        [BeforeFeature]
        public static void BeforeFeature()
        {
            featureName = extent.CreateTest<Feature>(FeatureContext.Current.FeatureInfo.Title);
        }

        [BeforeScenario]
        public void BeforeScenarioWithTag()
        {
            {
                scenario = featureName.CreateNode<Scenario>(ScenarioContext.Current.ScenarioInfo.Title);
            }
            _driver = new ChromeDriver();
            _driver.Manage().Window.Maximize();
            _objectContainer.RegisterInstanceAs(_driver, typeof(IWebDriver));
            var googlePage = new GooglePage(_driver);
            _objectContainer.RegisterInstanceAs(googlePage);
        }

        [AfterStep]
        public void InsertReportingSteps()
        {
            var stepType = ScenarioStepContext.Current.StepInfo.StepDefinitionType.ToString();
            if (ScenarioContext.Current.TestError == null)
            {
                if (stepType == "Given")
                    scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text);
                else if (stepType == "When")
                    scenario.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text);
                else if (stepType == "Then")
                    scenario.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text);
                else if (stepType == "And")
                    scenario.CreateNode<And>(ScenarioStepContext.Current.StepInfo.Text);
            }
            else if (ScenarioContext.Current.TestError != null)
            {
                if (stepType == "Given")
                {
                    scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text).Fail(ScenarioContext.Current.TestError.Message);
                    string path = TakeScreenshot();
                    scenario.AddScreenCaptureFromPath(path);
                }
                else if (stepType == "When")
                {
                    scenario.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text).Fail(ScenarioContext.Current.TestError.Message);
                    string path = TakeScreenshot();
                    scenario.AddScreenCaptureFromPath(path);
                }
                else if (stepType == "Then")
                {
                    scenario.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text).Fail(ScenarioContext.Current.TestError.Message);
                    string path = TakeScreenshot();
                    scenario.AddScreenCaptureFromPath(path);
                }
                else if (stepType == "And")
                {
                    scenario.CreateNode<And>(ScenarioStepContext.Current.StepInfo.Text).Fail(ScenarioContext.Current.TestError.Message);
                    string path = TakeScreenshot();
                    scenario.AddScreenCaptureFromPath(path);
                }
            }
        }

        [AfterScenario]
        public void AfterScenario()
        {
            _driver.Quit();
        }

        [AfterTestRun]
        public static void AfterTestRun()
        {
            extent.Flush();
        }
    }
}