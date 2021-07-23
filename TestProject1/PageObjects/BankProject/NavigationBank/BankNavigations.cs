using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using TestProject1.PageObjects.AgileProject;

namespace TestProject1.PageObjects.BankProject.NavigationBank
{
    public class BankNavigations : Base
    {
        private IWebElement Manager() => Driver.FindElement(By.LinkText("Manager"));
        private IWebElement NewCustomer() => Driver.FindElement(By.LinkText("New Customer"));
        private IWebElement EditCustomer() => Driver.FindElement(By.LinkText("Edit Customer"));
        private IWebElement DeleteCustomer() => Driver.FindElement(By.LinkText("Delete Customer"));
        private IWebElement NewAccount() => Driver.FindElement(By.LinkText("New Account"));
        private IWebElement EditAccount() => Driver.FindElement(By.LinkText("Edit Account"));
        private IWebElement DeleteAccount() => Driver.FindElement(By.LinkText("Delete Account"));
        private IWebElement MiniStatement() => Driver.FindElement(By.LinkText("Mini Statement"));
        private IWebElement CustomisedStatement() => Driver.FindElement(By.LinkText("Customised Statement"));
        private IWebElement Logout() => Driver.FindElement(By.LinkText("Log out"));


        public BankNavigations(IWebDriver driver) : base(driver)
        {

        }
      
        public ManagerHomePage NavigateToManagerHomePage()
        {
            Helper.BtnClick(Manager);
            return  new ManagerHomePage(Driver);
        }
        public NewCustomerPage NavigateToNewCustomerPage()
        {
            Helper.BtnClick(NewCustomer);
            return new NewCustomerPage(Driver);
        }
        public EditCustomerPage NavigateToEditCustomerPage()
        {
            Helper.BtnClick(EditCustomer);
            return new EditCustomerPage(Driver);
        }
        public DeleteCustomerPage NavigateToDeleteCustomerPage()
        {
            Helper.BtnClick(DeleteCustomer);
            return new DeleteCustomerPage(Driver);
        }
        public NewAccountPage NavigateToNewAccountPage()
        {
            Helper.BtnClick(NewAccount);
            return new NewAccountPage(Driver);
        }
        public EditAccountPage NavigateToEditAccountPage()
        {
            Helper.BtnClick(EditAccount);
            return new EditAccountPage(Driver);
        }
        public DeleteAccountPage NavigateToDeleteAccountPage()
        {
            Helper.BtnClick(DeleteAccount);
            return new DeleteAccountPage(Driver);
        }

        public MiniStatementBankPage NavigateToMiniStatement()
        {
            Helper.BtnClick(MiniStatement);
            return new MiniStatementBankPage(Driver);
        }
        public CustomizedStatementPage NavigateToCustomizedStatementPage()
        {
            Helper.BtnClick(CustomisedStatement);
            return new CustomizedStatementPage(Driver);
        }
        public LoginBankPage ClickLogout()
        {
            Helper.BtnClick(Logout);
            Helper.ConfirmAlert();
            return new LoginBankPage(Driver);
        }
    }
}
