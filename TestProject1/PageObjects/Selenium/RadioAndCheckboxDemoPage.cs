using NUnit.Framework;
using OpenQA.Selenium;

namespace TestProject1.PageObjects.Selenium
{
    public class RadioAndCheckboxDemoPage : Base
    {
        public IWebElement RadioOption() => Driver.FindElement(By.Id("vfb-7-2"));
        public RadioAndCheckboxDemoPage(IWebDriver driver) : base(driver)
        {
            Assert.IsTrue(Driver.Title.Contains("Radio"), "Page title doesn't match");
        }

        public void ClickRadio()
        {
            Helper.BtnClick(RadioOption);
            Assert.IsTrue(RadioOption().Selected);
        }
    }
}
