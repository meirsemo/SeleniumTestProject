using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject1.PageObjects.AgileProject.NavigationAgile
{
    public class AgileNavigations : Base
    {
        private IWebElement Customer() => Driver.FindElement(By.LinkText("Customer"));
        private IWebElement MiniStatement() => Driver.FindElement(By.LinkText("Mini Statement"));
        private IWebElement Logout() => Driver.FindElement(By.LinkText("Log out"));
        
        public AgileNavigations(IWebDriver driver) : base(driver){}

        public CustomerPage NavigateToCustomer()
        {
            Helper.BtnClick(Customer);
            return new CustomerPage(Driver);
        }

        public MiniStatementAgilePage NavigateToMiniStatement()
        {
            Helper.BtnClick(MiniStatement);
            return new MiniStatementAgilePage(Driver);
        }
        public LoginAgilePage ClickLogout()
        {
            Helper.BtnClick(Logout);
            Helper.ConfirmAlert();
            return new LoginAgilePage(Driver);
        }
    }
}
