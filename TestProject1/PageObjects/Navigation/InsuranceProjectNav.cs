using OpenQA.Selenium;
using TestProject1.PageObjects.InsuranceProject;

namespace TestProject1.PageObjects.Navigation
{
    public class InsuranceProjectNav : Base
    {
        public IWebElement Insurance() => Driver.FindElement(By.LinkText("Insurance Project"));
        public InsuranceProjectNav (IWebDriver driver) : base(driver){}

        public LoginInsurancePage NavigateToInsurancePage()
        {
            Helper.BtnClick(Insurance);
            return new LoginInsurancePage(Driver);
        }
    }
}
