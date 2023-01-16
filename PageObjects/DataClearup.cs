using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace CRMRegressionPack.PageObjects
{
    public class DataClearup
    {
        By CustomersLHN = By.CssSelector("[Aria-label='Clients']");
        By ActiveContactsList = By.XPath("//span[contains(text(),'Active Contacts')]");
        By NewCustomerOnList = By.XPath("//span[contains(text(),'AAA AAA')]");
        By NewBusinessOnList = By.XPath("//span[contains(text(),'AAA')]");
        By ModifiedCustomerOnList = By.XPath("//span[contains(text(),'1111 1111')]");
        By ModifiedBusinessOnList = By.XPath("//span[contains(text(),'1111')]");
        By ModifiedBusinessOnList2 = By.XPath("//span[contains(text(),'BBB')]");
        By DuplicateUser1 = By.XPath("//span[contains(text(),'1111 AAA')]");
        By DuplicateUser2 = By.XPath("//span[contains(text(),'AAA 1111')]");
        By DuplicateUser3 = By.XPath("//span[contains(text(),'2222 2222')]");

        By ActiveContactsDelete = By.XPath("//html//body//div//div//div//div//div//div//div//div//div//div//div//div//div//div//div//ul//li//button//span//span[contains(text(),'Delete')]");
        By ActiveContactsDeleteOverlay = By.XPath("//body/section/div/div/div/div/div/div/div/button[1]");
        By BusinessesLHN = By.CssSelector("[Aria-label='Businesses']");
        By ActiveAccountsList = By.XPath("//span[contains(text(),'Active Accounts')]");
        By ActiveBusinessesDelete = By.XPath("//button[.='Delete']");
        By ActiveBusinessesDeleteOverlay = By.XPath("//html//body//section//div//div//div//div//div//div//div//button//span[contains(text(),'Delete')]");

        [ThreadStatic]
        IWebDriver driver;
        WebDriverWait wait;

        public DataClearup(IWebDriver driver)
        {
            this.driver = driver;
            this.wait = new WebDriverWait(driver, TimeSpan.FromSeconds(120));
        }
        public void ClearDataCustomer()
        {
            //Verify form loads
            Thread.Sleep(4000);
            wait.Until(ExpectedConditions.ElementExists((By)CustomersLHN));
            Thread.Sleep(4000);
            driver.FindElement(CustomersLHN).Click();
            Thread.Sleep(4000);
            wait.Until(ExpectedConditions.ElementExists((By)ActiveContactsList));
            Thread.Sleep(4000);
            Assert.IsTrue(driver.FindElement(ActiveContactsList).Displayed);
            Thread.Sleep(4000);
            //verify customer not present
            var customer = 0;
            try
            {
                if (driver.FindElement(NewCustomerOnList).Displayed)
                {
                    customer++;
                }
                while (customer > 0)
                {
                    //Delete customer
                    driver.FindElement(NewCustomerOnList).Click();
                    Thread.Sleep(4000);
                    driver.FindElement(ActiveContactsDelete).Click();
                    wait.Until(ExpectedConditions.ElementExists((By)ActiveContactsDeleteOverlay));
                    Thread.Sleep(1000);
                    driver.FindElement(ActiveContactsDeleteOverlay).Click();
                    Thread.Sleep(4000);
                    Console.WriteLine("Customer has been deleted");
                }
            }
            catch (Exception)
            {

                Console.WriteLine("No customer present");
            }

            //verify modified customer not present
            try
            {
                if (driver.FindElement(ModifiedCustomerOnList).Displayed)
                {
                    customer++;
                }
                while (customer > 0)
                {
                    //Delete modified customer
                    driver.FindElement(ModifiedCustomerOnList).Click();
                    Thread.Sleep(4000);
                    driver.FindElement(ActiveContactsDelete).Click();
                    wait.Until(ExpectedConditions.ElementExists((By)ActiveContactsDeleteOverlay));
                    Thread.Sleep(1000);
                    driver.FindElement(ActiveContactsDeleteOverlay).Click();
                    Thread.Sleep(4000);
                    Console.WriteLine("Modified customer has been deleted");
                }
            }
            catch (Exception)
            {

                Console.WriteLine("No modified customer present");
            }

            //verify duplicate customer not present
            try
            {
                if (driver.FindElement(DuplicateUser1).Displayed)
                {
                    customer++;
                }
                while (customer > 0)
                {
                    //Delete modified customer
                    driver.FindElement(DuplicateUser1).Click();
                    Thread.Sleep(4000);
                    driver.FindElement(ActiveContactsDelete).Click();
                    wait.Until(ExpectedConditions.ElementExists((By)ActiveContactsDeleteOverlay));
                    Thread.Sleep(1000);
                    driver.FindElement(ActiveContactsDeleteOverlay).Click();
                    Thread.Sleep(4000);
                    Console.WriteLine("Modified customer has been deleted");
                }
            }
            catch (Exception)
            {

                Console.WriteLine("No modified customer present");
            }

            //verify duplicate customer 2 not present
            try
            {
                if (driver.FindElement(DuplicateUser2).Displayed)
                {
                    customer++;
                }
                while (customer > 0)
                {
                    //Delete modified customer
                    driver.FindElement(DuplicateUser2).Click();
                    Thread.Sleep(4000);
                    driver.FindElement(ActiveContactsDelete).Click();
                    wait.Until(ExpectedConditions.ElementExists((By)ActiveContactsDeleteOverlay));
                    Thread.Sleep(1000);
                    driver.FindElement(ActiveContactsDeleteOverlay).Click();
                    Thread.Sleep(4000);
                    Console.WriteLine("Modified customer has been deleted");
                }
            }
            catch (Exception)
            {

                Console.WriteLine("No modified customer present");
            }

            //verify duplicate customer 3 not present
            try
            {
                if (driver.FindElement(DuplicateUser3).Displayed)
                {
                    customer++;
                }
                while (customer > 0)
                {
                    //Delete modified customer
                    driver.FindElement(DuplicateUser3).Click();
                    Thread.Sleep(4000);
                    driver.FindElement(ActiveContactsDelete).Click();
                    wait.Until(ExpectedConditions.ElementExists((By)ActiveContactsDeleteOverlay));
                    Thread.Sleep(1000);
                    driver.FindElement(ActiveContactsDeleteOverlay).Click();
                    Thread.Sleep(4000);
                    Console.WriteLine("Modified customer has been deleted");
                }
            }
            catch (Exception)
            {

                Console.WriteLine("No modified customer present");
            }
        }

        public void DataClearBusiness()
        {
            //Verify form loads
            Thread.Sleep(4000);
            wait.Until(ExpectedConditions.ElementExists((By)BusinessesLHN));
            Thread.Sleep(4000);
            driver.FindElement(BusinessesLHN).Click();
            Thread.Sleep(4000);
            wait.Until(ExpectedConditions.ElementExists((By)ActiveAccountsList));
            Thread.Sleep(4000);
            Assert.IsTrue(driver.FindElement(ActiveAccountsList).Displayed);
            Thread.Sleep(4000);
            //verify business not present
            var business = 0;
            try
            {
                if (driver.FindElement(NewBusinessOnList).Displayed)
                {
                    business++;
                }
                while (business > 0)
                {
                        //Delete business
                        driver.FindElement(NewBusinessOnList).Click();
                        Thread.Sleep(4000);
                        driver.FindElement(ActiveBusinessesDelete).Click();
                        wait.Until(ExpectedConditions.ElementExists((By)ActiveBusinessesDeleteOverlay));
                        Thread.Sleep(1000);
                        driver.FindElement(ActiveBusinessesDeleteOverlay).Click();
                        Thread.Sleep(4000);
                        Console.WriteLine("Business has been deleted");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("No business present");
            }

            //verify modified business not present
            try
            {
                if (driver.FindElement(ModifiedBusinessOnList).Displayed)
                {
                    business++;
                }
                while (business > 0)
                {
                    //Delete modified business
                    driver.FindElement(ModifiedBusinessOnList).Click();
                    Thread.Sleep(4000);
                    driver.FindElement(ActiveBusinessesDelete).Click();
                    wait.Until(ExpectedConditions.ElementExists((By)ActiveBusinessesDeleteOverlay));
                    Thread.Sleep(1000);
                    driver.FindElement(ActiveBusinessesDeleteOverlay).Click();
                    Thread.Sleep(4000);
                    Console.WriteLine("Modified business has been deleted");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("No modified business present");
            }

            //verify modified business not present
            try
            {
                if (driver.FindElement(ModifiedBusinessOnList2).Displayed)
                {
                    business++;
                }
                while (business > 0)
                {
                    //Delete modified business
                    driver.FindElement(ModifiedBusinessOnList2).Click();
                    Thread.Sleep(4000);
                    driver.FindElement(ActiveBusinessesDelete).Click();
                    wait.Until(ExpectedConditions.ElementExists((By)ActiveBusinessesDeleteOverlay));
                    Thread.Sleep(1000);
                    driver.FindElement(ActiveBusinessesDeleteOverlay).Click();
                    Thread.Sleep(4000);
                    Console.WriteLine("Modified business has been deleted");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("No modified business present");
            }
        }
    }
}

