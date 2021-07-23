using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using TestProject1.PageObjects.BankProject.NavigationBank;

namespace TestProject1.PageObjects.BankProject
{
    public class DeleteCustomerPage : Base
    {
        public BankNavigations bankNavigations;
        
        public DeleteCustomerPage(IWebDriver driver) : base(driver)
        {
            bankNavigations = new BankNavigations(driver);
            Assert.IsTrue(Driver.Title.Equals("Gtpl Bank Delete Customer Page"));
        }
    }
}
