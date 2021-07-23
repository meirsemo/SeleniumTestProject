using OpenQA.Selenium;
using TestProject1.PageObjects.Selenium;

namespace TestProject1.PageObjects.Navigation
{
   public class SeleniumNav : Base
    {
        public IWebElement SeleniumDropdown() => Driver.FindElement(By.ClassName("dropdown-toggle"));
        public IWebElement RadioAndCheckBox() => Driver.FindElement(By.LinkText("Radio & Checkbox Demo"));
        public IWebElement Table() => Driver.FindElement(By.LinkText("Table Demo"));
        public IWebElement DragAndDropAction() => Driver.FindElement(By.LinkText("Drag and Drop Action"));
        public IWebElement ScrollbarDemo() => Driver.FindElement(By.LinkText("Scrollbar Demo"));
        public IWebElement TooltipDemo() => Driver.FindElement(By.LinkText("Tooltip"));
        public SeleniumNav(IWebDriver driver) : base(driver)
        {
            this.Driver = driver;
            Helper.BtnClick(SeleniumDropdown);
        }
        public RadioAndCheckboxDemoPage NavigateToRadioAndCheckPage()
        {
            Helper.BtnClick(RadioAndCheckBox);
            return new RadioAndCheckboxDemoPage(Driver);
        }

        public TableDemoPage NavigateToTableDemoPage()
        {
            Helper.BtnClick(Table);
            return new TableDemoPage(Driver);
        }

        public DragAndDropActionPage NavigateToDargAndDropPage()
        {
            Helper.BtnClick(DragAndDropAction);
            return new DragAndDropActionPage(Driver);
        }
        public ScrollbarDemoPage NavigateToScrollbarPage()
        {
            Helper.BtnClick(ScrollbarDemo);
            return new ScrollbarDemoPage(Driver);
        }
        public TooltipPage NavigateToTooltipPage()
        {
            Helper.BtnClick(TooltipDemo);
            return new TooltipPage(Driver);
        }
    }
}
