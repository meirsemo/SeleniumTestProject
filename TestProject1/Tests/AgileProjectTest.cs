using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using TestProject1.PageObjects.AgileProject;
using TestProject1.PageObjects.Navigation;

namespace TestProject1.Tests
{
    class AgileProjectTest : BaseTest
    {
        [Test]
        public void Test()
        {
            AgileProjectNav agile = new AgileProjectNav(driver);
            LoginAgilePage agilePage = agile.NavigateToAgilePage();
            CustomerPage customerPage = agilePage.LogIn();
            MiniStatementAgilePage miniStatementPage = customerPage.agileNavigations.NavigateToMiniStatement();
            miniStatementPage.SelectNumberAcount("3309"); //3308, 3309
            miniStatementPage.ClickSubmit();
            miniStatementPage.TableAccountCheck("CreditTansfer To3308"); //DiwaliTansfer To3309, CreditTansfer To3308
            miniStatementPage.agileNavigations.ClickLogout();
        }
    }
}
