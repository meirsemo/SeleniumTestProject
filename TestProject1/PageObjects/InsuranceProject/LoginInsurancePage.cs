using NUnit.Framework;
using OpenQA.Selenium;

namespace TestProject1.PageObjects.InsuranceProject
{
    public class LoginInsurancePage : Base
    {
        public IWebElement RegisterBtnEl() => Driver.FindElement(By.LinkText("Register"));
        public IWebElement EmailFieldEl() => Driver.FindElement(By.Id("email"));
        public IWebElement PasswordFieldEl() => Driver.FindElement(By.Id("password"));
        public IWebElement LoginBtnEl() => Driver.FindElement(By.Name("submit"));

        public LoginInsurancePage(IWebDriver driver) : base(driver)
        {
            Assert.IsTrue(Driver.Title.Contains("Login"), "Page title doesn't match");
        }

        public RegisterInsurancePage ClickRegister()
        {
            Helper.BtnClick(RegisterBtnEl);
            return new RegisterInsurancePage(Driver);
        }

        public LoggedInsurancePage ClickLogin()
        {
            Helper.BtnClick(LoginBtnEl);
            return new LoggedInsurancePage(Driver);
        }

        public void InsertEmail(string email = "blabla21@gmail.com")
        {
            Helper.CheckTextField(EmailFieldEl, email);
        }

        public void InsertPassword(string password = "123")
        {
            Helper.CheckTextField(PasswordFieldEl, password);
        }

        public LoggedInsurancePage LoginProcess(string email = "blabla@gmail.com", string password = "123456")
        {
            InsertEmail(email);
            InsertPassword(password);
            ClickLogin();
            return new LoggedInsurancePage(Driver);
        }
    }
}
