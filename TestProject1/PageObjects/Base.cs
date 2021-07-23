using OpenQA.Selenium;
using TestProject1.Helpers;

namespace TestProject1.PageObjects
{
    public class Base
    {
        protected IWebDriver Driver;
        
        protected HelpFunctions Helper;

        public Base(IWebDriver driver)
        {
            this.Driver = driver;
            this.Helper = new HelpFunctions(driver);
        }
    }
}
