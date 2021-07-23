using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject1.PageObjects.Selenium
{
    public class TooltipPage : Base
    {
        IWebElement DownloadNowBtn() => Driver.FindElement(By.Id("download_now"));

        IWebElement Tooltip() => Driver.FindElement(By.ClassName("tooltip"));

        public TooltipPage(IWebDriver driver) : base(driver)
        {
            Assert.IsTrue(Driver.Title.Contains("Tooltip Demo"), "Page title doesn't match");
        }

        public void ClickDownLoadNowBtn()
        {
            Helper.BtnClick(DownloadNowBtn);
        }

        public void GetTooltipInfo()
        {
            Helper.MoveCursorToElement(DownloadNowBtn);
            bool isDisplay = Tooltip().GetAttribute("style").Contains("display: block;");
            Assert.IsTrue(isDisplay, "tooltip is not display");
        }
    }
}
