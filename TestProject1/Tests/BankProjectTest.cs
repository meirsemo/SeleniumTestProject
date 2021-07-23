using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using TestProject1.PageObjects.BankProject;
using TestProject1.PageObjects.Navigation;

namespace TestProject1.Tests
{
    public class BankProjectTest : BaseTest
    {
        [Test]
        public void Test()
        {
            BankProjectNav bankProjectNav = new BankProjectNav(driver);
            LoginBankPage loginBankPage =  bankProjectNav.NavigateToBankPage();
            ManagerHomePage managerHomePage =  loginBankPage.LogIn();
            managerHomePage.bankNavigations.NavigateToEditCustomerPage();
        }
    }
}
