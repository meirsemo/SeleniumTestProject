using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using System;
using TestProject1.Configuration;

namespace TestProject1.Helpers
{
    public class HelpDriverBrowser
    {
        public IWebDriver GetDriver()
        {
            switch (HelpEnv.GetBrowserType())
            {
                case BrowserTypes.Chrome:
                    return new ChromeDriver();
                case BrowserTypes.InternetExplorer:
                    return new InternetExplorerDriver();
                default:
                    return new ChromeDriver();
            }
        }
    }
}
