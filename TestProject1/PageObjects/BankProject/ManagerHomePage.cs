using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using TestProject1.PageObjects.BankProject.NavigationBank;

namespace TestProject1.PageObjects.BankProject
{
    public class ManagerHomePage : Base
    {
        public BankNavigations bankNavigations;
       
        public ManagerHomePage(IWebDriver driver) : base(driver)
        {
            bankNavigations = new BankNavigations(driver);
            Assert.IsTrue(Driver.Title.Equals("GTPL Bank Manager HomePage"));
        }
    }
}
