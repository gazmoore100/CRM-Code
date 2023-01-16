using OpenQA.Selenium;
using OpenQA.Selenium.Edge;

namespace CRMRegressionPack.Wrappers
{
    internal class WebDriverFactory
    {
        public virtual IWebDriver CreateLocalEdgeDriver()
        {
            EdgeOptions options = new EdgeOptions();
            options.SetLoggingPreference(LogType.Browser, LogLevel.All);
        //    options.AddArgument("headless");
            return new EdgeDriver(options);
        }

    }
}
