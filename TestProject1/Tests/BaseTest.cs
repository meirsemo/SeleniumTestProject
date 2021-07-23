using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using System;
using TestProject1.Helpers;

namespace TestProject1.Tests
{
    public class BaseTest 
    {
        protected IWebDriver driver;
        public HelpScreenShot helpScreenShot;
        //public TestContext TestContext {  get; set; }

        [SetUp]
        public void Setup()
        {
            driver = new HelpDriverBrowser().GetDriver();
            driver.Manage().Window.Maximize();
            driver.Url = HelpEnv.Url;
            helpScreenShot = new HelpScreenShot(driver);
        }

        [TearDown]
        public void Close()
        {
            if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
            {
                string path = HelpEnv.ScreenshotPath;
                helpScreenShot.TakeScreenShot(path, DateTime.Now.ToString("dddd, dd MMMM yyyy HH mm ss"));
            }
            driver.Quit();
        }
    }
}
