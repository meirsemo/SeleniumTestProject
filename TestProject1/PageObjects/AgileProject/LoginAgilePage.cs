using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject1.PageObjects.AgileProject
{
    public class LoginAgilePage : Base
    {
        public IWebElement UserID() => Driver.FindElement(By.Name("uid"));
        public IWebElement Password() => Driver.FindElement(By.Name("password"));
        public IWebElement LoginBtn() => Driver.FindElement(By.Name("btnLogin"));
        public IWebElement ResetBtn() => Driver.FindElement(By.Name("btnReset"));
        public LoginAgilePage(IWebDriver driver) : base(driver)
        {
            Assert.IsTrue(Driver.Title.Contains("Guru99 Bank Home Page"), "Page title doesn't match");
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
  /*      private CustomerPage ClickLogin()
        {
            Helper.BtnClick(LoginBtn);
            return new CustomerPage(Driver);
        }*/
        public CustomerPage LogIn(string userId = "1303", string password = "Guru99")
        {
            InsertUserId(userId);
            InsertPassword(password);
            Helper.BtnClick(LoginBtn);
            return new CustomerPage(Driver);
        }
        public void ClickReset()
        {
            Helper.BtnClick(ResetBtn);
            Assert.IsTrue(Password().GetAttribute("value").Equals(""));
            Assert.IsTrue(UserID().GetAttribute("value").Equals(""));
        }
    }
}
