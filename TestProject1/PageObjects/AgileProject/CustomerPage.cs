using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using TestProject1.PageObjects.AgileProject.NavigationAgile;

namespace TestProject1.PageObjects.AgileProject
{
    public class CustomerPage : Base
    {
        public AgileNavigations agileNavigations;
        public CustomerPage(IWebDriver driver) : base(driver)
        {
            agileNavigations = new AgileNavigations(Driver);
            Assert.IsTrue(Driver.Title.Contains("Guru99 Bank Customer HomePage"), "Page title doesn't match");
        }

    }
}
