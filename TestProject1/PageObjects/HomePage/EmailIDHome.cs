using NUnit.Framework;
using OpenQA.Selenium;

namespace TestProject1.PageObjects.HomePage
{
    public class EmailIDHome : Base
    {
        public IWebElement EmailFieldEl() => Driver.FindElement(By.Name("emailid"));
        public IWebElement SubmitBtnEl() => Driver.FindElement(By.Name("btnLogin"));
        public EmailIDHome(IWebDriver driver) : base(driver)
        {
            Assert.IsTrue(Driver.Title.Contains("Guru99 Bank Home Page"), "Page title doesn't match");
        }
        public void InsertText(string email = "blabla21@gmail.com", bool cleanField = true)
        {
            Helper.CheckTextField(EmailFieldEl, email, cleanField);
        }
        public void ClickSubmit()
        {
            Helper.BtnClick(SubmitBtnEl);
        }
    }
}