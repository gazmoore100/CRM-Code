using NUnit.Framework;
using OpenQA.Selenium;
using Microsoft.Edge.SeleniumTools;

namespace CRMRegressionPack
{
    [TestFixture(BrowserTarget.Edge)]

    public abstract class BaseTest
    {
        protected LocalDriverBuilder builder;
        protected string startingURL;
        protected string epochStartTime;
        protected string targetBrowser;
        protected CommonUtils commonUtils = new CommonUtils();

        protected BaseTest(string browser)
        {
            this.targetBrowser = browser;
            this.epochStartTime = DateTimeOffset.Now.ToUnixTimeMilliseconds().ToString(); 
        }

        public IWebDriver InitialiseDriver()
        {
            LocalDriverBuilder builder = new LocalDriverBuilder();
            //\\Wave Environment//\\
            //  this.startingURL = "https://wmdcwave.crm11.dynamics.com/main.aspx?appid=9ad87dee-5622-ea11-a814-00224801cd38&pagetype=dashboard&id=323a6277-86e6-e911-a812-000d3a7ed30d&type=system&_canOverride=true";
            //\\Test Environment//\\
             this.startingURL = "https://wmdctest.crm11.dynamics.com/main.aspx?appid=9ad87dee-5622-ea11-a814-00224801cd38&forceUCI=1&pagetype=dashboard&id=323a6277-86e6-e911-a812-000d3a7ed30d&type=system&_canOverride=true";
            var driver = builder.Launch(targetBrowser, this.startingURL);
            driver.Manage().Window.Maximize();
            Thread.Sleep(1000);
            return driver;
        }
        public IWebDriver InitialiseMyAccountDriver()
        {
            LocalDriverBuilder builder = new LocalDriverBuilder();
            this.startingURL = "https://web-iat-uks-test-umbraco.azurewebsites.net";
            var driver = builder.Launch(targetBrowser, this.startingURL);
            driver.Manage().Window.Maximize();
            Thread.Sleep(1000);
            return driver;
        }
    }
}
