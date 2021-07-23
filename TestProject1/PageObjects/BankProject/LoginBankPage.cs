using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject1.PageObjects.BankProject
{
    public class LoginBankPage : Base
    {
        public IWebElement UserID() => Driver.FindElement(By.Name("uid"));
        public IWebElement Password() => Driver.FindElement(By.Name("password"));
        public IWebElement LoginBtn() => Driver.FindElement(By.Name("btnLogin"));
        public IWebElement ResetBtn() => Driver.FindElement(By.Name("btnReset"));
        public LoginBankPage(IWebDriver driver) : base(driver)
        {
            Assert.IsTrue(Driver.Title.Equals("GTPL Bank Home Page"));
        }

        private void InsertUserId(string userId, bool cleanField = true)
        {
            Helper.CheckTextField(UserID, userId, cleanField);
            Assert.IsTrue(UserID().GetAttribute("value").Equals(userId));
        }

        private void InsertPassword(string password, bool cleanField = true)
        {
            Helper.CheckTextField(Password, password, cleanField);
            Assert.IsTrue(Password().GetAttribute("value").Equals(password));
        }

        public ManagerHomePage LogIn(string userId = "mngr337517", string password = "apynyvY")
        {
            InsertUserId(userId);
            InsertPassword(password);
            Helper.BtnClick(LoginBtn);
            return new ManagerHomePage(Driver);
        }
        public void ClickReset()
        {
            Helper.BtnClick(ResetBtn);
            Assert.IsTrue(Password().GetAttribute("value").Equals(""));
            Assert.IsTrue(UserID().GetAttribute("value").Equals(""));
        }
    }
}