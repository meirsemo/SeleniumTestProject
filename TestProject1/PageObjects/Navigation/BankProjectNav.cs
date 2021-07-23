using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using TestProject1.PageObjects.BankProject;

namespace TestProject1.PageObjects.Navigation
{
    public class BankProjectNav : Base
    {
        public IWebElement Bank() => Driver.FindElement(By.LinkText("Bank Project"));
        public BankProjectNav(IWebDriver driver) : base(driver){}

        public LoginBankPage NavigateToBankPage()
        {
            Helper.BtnClick(Bank);
            return new LoginBankPage(Driver);
        }
      
    }
}
