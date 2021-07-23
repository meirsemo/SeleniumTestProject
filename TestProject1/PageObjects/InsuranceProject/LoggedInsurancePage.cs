using NUnit.Framework;
using OpenQA.Selenium;

namespace TestProject1.PageObjects.InsuranceProject
{
    public class LoggedInsurancePage : Base
    {
        IWebElement LogOutBtnEl() => Driver.FindElement(By.ClassName("btn-danger"));
        IWebElement RequestQuotationEl() => Driver.FindElement(By.LinkText("Request Quotation"));
        IWebElement BreakDownCoverComboEl() => Driver.FindElement(By.Id("quotation_breakdowncover"));
        IWebElement WindoScreenYesEl() => Driver.FindElement(By.Id("quotation_windscreenrepair_t"));
        IWebElement WindoScreenNoEl() => Driver.FindElement(By.Id("quotation_windscreenrepair_f"));
        IWebElement IncidentsBtnEl() => Driver.FindElement(By.Name("incidents"));
        
        public LoggedInsurancePage (IWebDriver driver) : base(driver)
        {
            Assert.IsTrue(Driver.Title.Contains("Insurance Broker System"), "Page title doesn't match");
        }

        public LoginInsurancePage ClickLogOut()
        {
            Helper.BtnClick(LogOutBtnEl);
            return new LoginInsurancePage(Driver);
        }
        public void ClickRequestQuotation()
        {
            Helper.BtnClick(RequestQuotationEl);
        }
        public void SelectBreakDownCover()
        {
            Helper.ComboBox(BreakDownCoverComboEl, "European");
        }
        public void ClickWindoScreenYes()
        {
            WindoScreenYesEl().Click();
        }
        public void ClickWindoScreenNo()
        {
            WindoScreenNoEl().Click();
        }
        public void InsertIncidents(string str)
        {
            Helper.CheckTextField(IncidentsBtnEl, str);
            Assert.IsTrue(IncidentsBtnEl().GetAttribute("value").Equals(str));
        }
    }
}
