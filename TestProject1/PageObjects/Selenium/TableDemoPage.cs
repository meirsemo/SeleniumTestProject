using NUnit.Framework;
using OpenQA.Selenium;

namespace TestProject1.PageObjects.Selenium
{
    public class TableDemoPage : Base
    {
        public TableDemoPage (IWebDriver driver) : base(driver)
        {
            Assert.IsTrue(Driver.Title.Contains("Table Demo"), "Page title doesn't match");
        }

        public void SearchNumber(string num = "7")
        {
            Helper.SearchInTable(num);
        }
    }
}
