using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace CRMRegressionPack.PageObjects
{
    class DynamicsLogin
    {
        By PickAccount = By.XPath("//div[.='Moore, Gary']");
        By SignInWindow = By.XPath("//input[@placeholder='Email address, phone number or Skype']");
        By SignInWindowNextBtn = By.XPath("//input[@class='win-button button_primary button ext-button primary ext-primary']");
        By SignInWindowPassword = By.XPath("//input[@placeholder='Password']");
        By SignInButton = By.XPath("//input[@class='win-button button_primary button ext-button primary ext-primary']");
        By StaySignedInBtn = By.XPath("//input[@class='win-button button_primary button ext-button primary ext-primary']");
        By Title = By.XPath("//span[contains(text(),'Wakefield User App')]");


        [ThreadStatic]
        IWebDriver driver;
        WebDriverWait wait;

        public DynamicsLogin(IWebDriver driver)
        {
            this.driver = driver;
            this.wait = new WebDriverWait(driver, TimeSpan.FromSeconds(120));
        }

        public void LoginWindow()
        {
            try
            {
                Thread.Sleep(2000);
                if (driver.FindElement(SignInWindow).Displayed)
                {
                    Thread.Sleep(2000);
                    driver.FindElement(SignInWindow).Click();
                    Thread.Sleep(2000);
                    driver.FindElement(SignInWindow).SendKeys("garymoore@wakefield.gov.uk");
                    Thread.Sleep(2000);
                    driver.FindElement(SignInWindowNextBtn).Click();
                    Thread.Sleep(2000);
                    Actions action = new Actions(driver);
                    WebElement ele = (WebElement)driver.FindElement(SignInWindowPassword);
                    action.Click(ele).Click(ele).Click(ele).Perform();
                    driver.FindElement(SignInWindowPassword).SendKeys(Keys.Delete);
                    StreamReader streamReader = new StreamReader(@"C:\Users\garymoore\OneDrive - Wakefield Council\Desktop\dynamicspassword.txt");
                    string password = streamReader.ReadToEnd();
                    driver.FindElement(SignInWindowPassword).SendKeys(password);
                    Thread.Sleep(2000);
                    driver.FindElement(SignInButton).Click();
                    Thread.Sleep(2000);
                    driver.FindElement(StaySignedInBtn).Click();
                    wait.Until(ExpectedConditions.ElementExists((By)Title));
                    Assert.IsTrue(driver.FindElement(Title).Displayed);
                }
            }
            catch (Exception)
            {
                Thread.Sleep(4000);
                try
                {
                    if (driver.FindElement(PickAccount).Displayed)
                    {
                        wait.Until(ExpectedConditions.ElementExists((By)PickAccount));
                        Assert.IsTrue(driver.FindElement(PickAccount).Displayed);
                        driver.FindElement(PickAccount).Click();
                    }
                }

                catch (Exception)
                {
                    Console.WriteLine("No login screen shown");
                }
            }
        }
    }
}
