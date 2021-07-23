using NUnit.Framework;
using TestProject1.PageObjects.Navigation;
using TestProject1.PageObjects.Selenium;

namespace TestProject1.Tests
{
    public class RadioBtnCheakTest : BaseTest
    {
        [Test]
        public void Test()
        {
            SeleniumNav seleniumDropDown = new SeleniumNav(driver);
            RadioAndCheckboxDemoPage radio =  seleniumDropDown.NavigateToRadioAndCheckPage();
            radio.ClickRadio();
        }
    }
}
