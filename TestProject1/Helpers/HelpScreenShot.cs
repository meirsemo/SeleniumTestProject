using OpenQA.Selenium;
using System.IO;

namespace TestProject1.Helpers
{
    public class HelpScreenShot
    {
        IWebDriver driver;
        public HelpScreenShot(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void TakeScreenShot(string folderPath, string fileName)
        {
            Screenshot screenShot = ((ITakesScreenshot)driver).GetScreenshot();
            string path = @$"{folderPath}\{fileName}.png";
            Directory.CreateDirectory(folderPath);
            screenShot.SaveAsFile(path, ScreenshotImageFormat.Png);
        }
    }
}
