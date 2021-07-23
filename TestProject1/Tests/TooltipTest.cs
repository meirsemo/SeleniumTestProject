using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using TestProject1.PageObjects.Navigation;
using TestProject1.PageObjects.Selenium;

namespace TestProject1.Tests
{
    class TooltipTest : BaseTest
    {
        [Test]
        public void Test()
        {
            SeleniumNav seleniumDropDown = new SeleniumNav(driver);
            TooltipPage tooltip = seleniumDropDown.NavigateToTooltipPage();
            tooltip.GetTooltipInfo();
        }
    }
}
