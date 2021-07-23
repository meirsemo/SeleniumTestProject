using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using TestProject1.PageObjects.AgileProject.NavigationAgile;

namespace TestProject1.PageObjects.AgileProject
{
    public class MiniStatementAgilePage : Base
    {
        public AgileNavigations agileNavigations;
        public IWebElement ComboAccountNumber() => Driver.FindElement(By.Name("accountno"));
        public IWebElement SubmitBtn() => Driver.FindElement(By.Name("AccSubmit"));
        public IWebElement ResetBtn() => Driver.FindElement(By.Name("res"));
        public IWebElement HomeLink() => Driver.FindElement(By.LinkText("Home"));
        public IWebElement ContinueLink() => Driver.FindElement(By.LinkText("Continue"));

        public MiniStatementAgilePage(IWebDriver driver) : base(driver)
        {
            agileNavigations = new AgileNavigations(Driver);
            Assert.IsTrue(Driver.Title.Contains("Guru99 Bank Mini Statement Page"), "Page title doesn't match");
        }

        public void SelectNumberAcount(string accountNumber)
        {
            Helper.ComboBox(ComboAccountNumber, accountNumber);
            Assert.IsTrue(ComboAccountNumber().GetAttribute("value").Equals(accountNumber));
        }

        public void ClickSubmit()
        {
            Helper.BtnClick(SubmitBtn);
        }
        public void ClickReset()
        {
            Helper.BtnClick(ResetBtn);
            Assert.IsTrue(ComboAccountNumber().GetAttribute("value").Equals("Select Account"));
        }
        public CustomerPage ClickHome()
        {
            Helper.BtnClick(HomeLink);
            return new CustomerPage(Driver);
        }
        public CustomerPage ClickContinue()
        {
            Helper.BtnClick(ContinueLink);
            return new CustomerPage(Driver);
        }
        public void TableAccountCheck(string str)
        {
            Helper.SearchInTable(str);
        }
    }
}
