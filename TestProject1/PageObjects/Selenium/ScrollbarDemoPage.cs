using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject1.PageObjects.Navigation
{
    public class ScrollbarDemoPage : Base
    {
        IWebElement VBScriptBtn() => Driver.FindElement(By.ClassName("icon-code-fork"));
        IWebElement ScorlBar() => Driver.FindElement(By.Id("rt-feature"));
        public ScrollbarDemoPage(IWebDriver driver) : base(driver)
        {
            Assert.IsTrue(Driver.Title.Contains("Scrolling Demo page"), "Page title doesn't match");
        }

        public void ClickVBSBtn()
        {
            Helper.BtnClick(VBScriptBtn);
        }
        public void MoveScroll()
        {
            Helper.MoveScrollBar(ScorlBar);
        }
    }
}
