using CRMRegressionPack.Wrappers;
using OpenQA.Selenium;

namespace CRMRegressionPack
{
    public class LocalDriverBuilder
    {
        private readonly WebDriverFactory factory;

        public LocalDriverBuilder() : this(new WebDriverFactory())
        {

        }
        internal LocalDriverBuilder(WebDriverFactory factory)
        {
            this.factory = factory;
        }
        public virtual IWebDriver Launch(string browserTarget, string startingURL)
        {
            var driver = CreateWebDriver(browserTarget);
            driver.Navigate().GoToUrl(startingURL);
            return driver;
        }

        private IWebDriver CreateWebDriver(string browserTarget)
        {
            switch (browserTarget)
            {
                case BrowserTarget.Edge:
                    return factory.CreateLocalEdgeDriver();
                default:
                    throw new NotSupportedException($"{browserTarget} is not a supported local browser type.");
            }
        }
    }
}
