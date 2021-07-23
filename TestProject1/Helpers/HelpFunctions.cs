using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;

namespace TestProject1.Helpers
{
    public class HelpFunctions 
    {
        IWebDriver driver;
        IJavaScriptExecutor jsExecutor;
        Actions actions;
        public HelpFunctions(IWebDriver driver)
        {
            this.driver = driver;
            jsExecutor = (IJavaScriptExecutor)driver;
        }

        public void CheckTextField(Func<IWebElement> field, string input, bool clean = true)
        {
            if (clean)
            {
                field().Clear();
            }
            field().SendKeys(input);
        }

        public bool WaitForElement(Func<IWebElement> element, int timeOutInSeconds = 20, bool thEx = true)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeOutInSeconds));
                wait.Until((d) =>
                {
                    try
                    {
                        return element().Displayed;
                    }
                    catch
                    {
                        return false;
                    }
                });
            }
            catch 
            {
                if (thEx)
                {
                    throw new Exception(String.Format("Following element wasn't exist: {0}", element));
                }
                return false;
            }
            return true;
        }

        public void BtnClick(Func<IWebElement> btnEl, int timeOutInSeconds = 20, bool thEx = true)
        {
            if(WaitForElement(btnEl, timeOutInSeconds, thEx))
            {
                btnEl().Click();
            }
            else
            {
                Assert.Fail();
            }
        }

        public void ComboBox(Func<IWebElement> element, string text) 
        {
            SelectElement selectedElement = new SelectElement(element());
            selectedElement.SelectByText(text);
        }

        public void MoveScrollBar(Func<IWebElement> element)
        {
            jsExecutor.ExecuteScript("arguments[0].scrollLeft = arguments[0].offsetWidth", element());
        }

        public void MoveCursorToElement(Func<IWebElement> element)
        {
            if(WaitForElement(element))
            {
                actions = new Actions(driver);
                actions.MoveToElement(element()).Build().Perform();
            }
        }

        public void DragAndDropElement(Func<IWebElement> element, Func<IWebElement> moveTo)
        {
            actions = new Actions(driver);
            actions.DragAndDrop(element(), moveTo()).Build().Perform();
        }

        public void SearchInTable(string str)
        {
            IWebElement td = driver.FindElement(By.XPath($"//td[contains(., '{str}')]"));
            Assert.IsTrue(td.Displayed);
        }
        public void ConfirmAlert()
        {
            var alert = driver.SwitchTo().Alert();
            alert.Accept();
        }
    }
}
