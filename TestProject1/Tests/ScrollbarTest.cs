using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using TestProject1.PageObjects.Navigation;

namespace TestProject1.Tests
{
    class ScrollbarTest : BaseTest
    {
        [Test]
        public void Test()
        {
            SeleniumNav seleniumDropDown = new SeleniumNav(driver);
            ScrollbarDemoPage scrollbarPage = seleniumDropDown.NavigateToScrollbarPage();
            scrollbarPage.MoveScroll();
            scrollbarPage.ClickVBSBtn();
        }
    }
}
