using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace TestProject1.PageObjects.Selenium
{
    public class DragAndDropActionPage : Base
    {
        public IWebElement Bank() => Driver.FindElement(By.Id("credit2"));
        public IWebElement Sales() => Driver.FindElement(By.Id("credit1"));
        public IWebElement Five() => Driver.FindElement(By.Id("fourth"));
        public IWebElement FirstAccount() => Driver.FindElement(By.Id("bank"));
        public IWebElement SecondAccount() => Driver.FindElement(By.Id("loan"));
        public IWebElement FirstAmount() => Driver.FindElement(By.Id("amt7"));
        public IWebElement SecondAmount() => Driver.FindElement(By.Id("amt8"));
        public IWebElement PerfectBtnEl() => Driver.FindElement(By.ClassName("button-green"));

        public DragAndDropActionPage(IWebDriver driver) : base(driver)
        {
            Assert.IsTrue(Driver.Title.Contains("Drag and Drop Action"), "Page title doesn't match");
        }

        public void BankToAccount()
        {
            Helper.DragAndDropElement(Bank, FirstAccount);
        }
        public void SalesToAccount()
        {
            Helper.DragAndDropElement(Sales, SecondAccount);
        }
        public void PriceToAmount()
        {
            Helper.DragAndDropElement(Five, FirstAmount);
            Helper.DragAndDropElement(Five, SecondAmount);
        }
        public void ClickPerfectBtn()
        {
            Helper.BtnClick(PerfectBtnEl);
        }
    }
}
