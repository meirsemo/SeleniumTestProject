using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using TestProject1.PageObjects.AgileProject;

namespace TestProject1.PageObjects.Navigation
{
    public class AgileProjectNav : Base
    {
        public IWebElement Agile() => Driver.FindElement(By.LinkText("Agile Project"));
        public AgileProjectNav(IWebDriver driver) : base(driver){}

        public LoginAgilePage NavigateToAgilePage()
        {
            Helper.BtnClick(Agile);
            return new LoginAgilePage(Driver);
        }
    }
}
