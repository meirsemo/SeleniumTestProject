using System;
using System.Linq;
using System.Xml;
using System.Xml.Linq;
using TestProject1.Configuration;

namespace TestProject1.Helpers
{
    public static class HelpEnv
    {
        static XElement xElement;

        private static string GetValue(string key)
        {
            if(xElement == null) //Load the file for the first time
            {
                xElement = XElement.Load("C:\\Users\\Meirs\\source\\repos\\TestProject1\\TestProject1\\Configuration\\Env.xml");
            }

            var element = xElement.Elements().SingleOrDefault(el => el.Name.LocalName == key);

            if (element != null)
            {
                return element.Value;
            }
            return null;
        }

        public static BrowserTypes GetBrowserType()
        {
            var browserValue = (BrowserTypes)Enum.Parse(typeof(BrowserTypes), GetValue("browser"));
            return browserValue;
        }

        public static string Url => GetValue("url");

        public static string ScreenshotPath => GetValue("screenshotPath");
    }
}
