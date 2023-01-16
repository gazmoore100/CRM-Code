using Microsoft.Edge.SeleniumTools;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace CRMRegressionPack.PageObjects
{
    public class NewCustomer
    {
        By CustomersLHN = By.CssSelector("[Aria-label='Clients']");
        By DashboardsLHN = By.XPath("//span[contains(text(),'Dashboards')]");
        By ActiveContactsList = By.XPath("//span[contains(text(),'Active Contacts')]");
        By NewCustomerButton = By.XPath("//span[contains(text(),'New')]");
        By NewCustomerForm = By.XPath("//h1[contains(text(),'New Customer')]");
        By NewCustomerTitle = By.CssSelector("[Aria-label='Title']");
        By NewCustomerTitleDropdown = By.XPath("//option[.='Mr']");
        By NewCustomerFirstName = By.CssSelector("[aria-label='First Name']");
        By NewCustomerSurname = By.CssSelector("[Aria-label='Surname']");
        By NewCustomerContactMethod = By.CssSelector("[aria-label='Preferred Method of Contact']");
        By NewCustomerContactMethodDropdown = By.XPath("//option[.='Email']");
        By NewCustomerMobile = By.CssSelector("[aria-label='Mobile Phone']");
        By NewCustomerHomePhone = By.CssSelector("[aria-label='Home Phone']");
        By NewCustomerWorkPhone = By.CssSelector("[aria-label='Work Phone']");
        By NewCustomerEmail = By.CssSelector("[placeholder='Provide an email']");
        By NewCustomerEmailLabel = By.XPath("//label[.='Email']");
        By NewCustomerEmailValidationError = By.XPath("//span[.='Email: Enter a valid email address.']");
        By NewCustomerAddress = By.XPath("//input[@placeholder='Search for an address']");
        By NewCustomerAddressDropdown = By.XPath("//option[contains(text(),'4 Sandhill Rise Pontefract WF8 1RA')]");
        By NewCustomerSaveandClose = By.XPath("//span[contains(text(),'Save & Close')]");
        By NewCustomerSaveBtn = By.XPath("//button[.='Save']");
        By NewCustomerOnList = By.XPath("//span[contains(text(),'AAA AAA')]");
        
        By CustomerSearch = By.XPath("//input[@placeholder='Filter by keyword']");
        By SearchResultOnList = By.XPath("//span[contains(text(),'Test Moore')]");
        By ActiveContactsDelete = By.XPath("//html//body//div//div//div//div//div//div//div//div//div//div//div//div//div//div//div//ul//li//button//span//span[contains(text(),'Delete')]");
        By ActiveContactsDeleteOverlay = By.XPath("//body/section/div/div/div/div/div/div/div/button[1]");
        By NewCustomerErrorMsg = By.XPath("//div[@id='notificationMessageAndButtons']");
        By NewCustomerInlineErrorMsg = By.XPath("//span[contains(text(),'Surname: Required fields must be filled in.')]");
        By DuplicateRecordOverlay = By.CssSelector("[aria-label='Duplicate records found']");
        By DuplicateRecordSelect = By.XPath("//section//section//section//section//div//div//div//div//div[2]//div[4]");
        By DuplicateRecordMerge = By.XPath("//button[.='Merge']");
        By MergeCustomersOverlay = By.XPath("//h1[.='Merge Customers']");
        By MergeCustomersOverlayButton = By.XPath("//span[.='OK']");
        By ExistingCustomerRecord = By.XPath("//h1[contains(text(),'AAA AAA')]");
        By ExistingCustomerEmail = By.XPath("//span[contains(text(),'Test@test.com')]");
        By ExistingCustomerEmail1 = By.XPath("//span[contains(text(),'Testing@testing.com')]");
        By ExistingCustomerEmail2 = By.XPath("//span[contains(text(),'Testing@tester.com')]");
        By ContinueCustomerBtn = By.XPath("//button[contains(text(),'Continue with Customer')]");

        By DashboardTitle = By.XPath("//span[contains(text(),'Wakefield Home')]");
        By NewCustomerInAccessChannel = By.XPath("//a[contains(text(),'AAA AAA')]");
        By AccessChannelCustomerDetails = By.XPath("//div[@id='chosenCustomerDetails']");
        By CustomerAddressInAccessChannel = By.XPath("//div[contains(text(),'4 Sandhill Rise Pontefract WF8 1RA')]");
        By CustomerAddressInAccessChannel1 = By.XPath("//div[contains(text(),'80 SPRING AVENUE, ASHBY-DE-LA-ZOUCH, LE65 2RB')]");
        By UnknownAddressInAccessChannel = By.XPath("//div[.='Unknown']");
        By CustomerEmailInAccessChannel1 = By.XPath("//div[contains(text(),'Testing@testing.com')]");
        By CustomerEmailInAccessChannel2 = By.XPath("//div[contains(text(),'tester@tester.com')]");
        By CaseHistoryInAccessChannel = By.XPath("//i[contains(text(),'option has been used')]");

        By AdvancedFindFilter = By.CssSelector(".AdvFind-symbol");
        By FilterLookFor = By.XPath("//td[@class='ms-crm-AdvFind-EntityList']");
        By LookForOptionOnDropdown = By.XPath("//option[.='Addressable Locations']");
        By ResultsIconOnLookForBanner = By.XPath("//span[@class='ms-cui-ctl-largelabel'][contains(text(),'Results')]");
        By ResultsCreatedOnColumn = By.XPath("//label[contains(text(),'Created On')]");
        By AddressResultOnTable = By.XPath("//a[contains(text(),'6 Sandhill Rise Pontefract WF8 1RA')]");
        By AddressResultOnTable1 = By.XPath("//a[contains(text(),'ASHBY-DE-LA-ZOUCH')]");

        By Searchbox = By.XPath("//input[@id='txtCustomerSearch']");
        By SearchDropdownCreateNew = By.XPath("//a[contains(text(),'Create a new contact')]");
        By CreateCustomerOverlayYesBtn = By.XPath("//span[contains(text(),'Yes')]");
        By CantFindAddressLink = By.XPath("//a[@id='lnkManualAddress']");
        By UnderstandBtnOnOverlay = By.XPath("//span[contains(text(),'I Understand')]");
        By ManualAddressHouseNumber = By.XPath("//input[@placeholder='House name/number']");
        By ManualAddressStreetName = By.XPath("//input[@placeholder='Street name']");
        By ManualAddressTown = By.XPath("//input[@placeholder='Town/city']");
        By ManualAddressPostcode = By.XPath("//input[@placeholder='Postcode']");
        By OutOfAreaTickbox = By.XPath("//input[@placeholder='Out of area']");
        By ConfirmManualAdressBtn = By.XPath("//button[@id='btnManualAddress']");
        By ManualAddressOnAdvancedFind = By.XPath("//a[contains(text(),'ASHBY-DE-LA-ZOUCH')]");
        By InvalidPostcodeMessage = By.XPath("//h1[contains(text(),'Valid postcode required')]");
        By InvalidPostcodeMessageOK = By.XPath("//span[contains(text(),'OK')]");

        By StartNewBtn = By.XPath("//button[contains(text(),'Start New')]");
        By ChosenCustomerOnDashboard = By.XPath("//a[contains(text(),'New User')]");
        By SelectedAddressBanner = By.XPath("//strong[contains(text(),'Selected address:')]");
        By UnknownAddressLink = By.XPath("//a[contains(text(),'Unknown address?')]");
        By UnknownAdressSelected = By.XPath("//div[contains(text(),'Unknown')]");
        By UnknownAddressOnProfile = By.XPath("//div[@title='Unknown']");
        By AddressableLocationTitle = By.XPath("//span[text()='Addressable Location']");
        By AddressUPRN = By.XPath("//input[@value='99999999']");
        By BackButton = By.XPath("//span[contains(@class,'symbolFont BackButton-symbol')]");
        By FullAddressTitle = By.XPath("//h2[contains(text(),'FULL ADDRESS (Will be automatically created)')]");

        [ThreadStatic]
        IWebDriver driver;
        WebDriverWait wait;

        public NewCustomer(IWebDriver driver)
        {
            this.driver = driver;
            this.wait = new WebDriverWait(driver, TimeSpan.FromSeconds(120));
        }

        public void VerifyEmailInput()
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
            driver.FindElement(NewCustomerButton).Click();
            wait.Until(ExpectedConditions.ElementExists((By)NewCustomerForm));
            Assert.IsTrue(driver.FindElement(NewCustomerForm).Displayed);
            //Enter invalid email
            driver.FindElement(NewCustomerEmail).Click();
            Thread.Sleep(1000);
            driver.FindElement(NewCustomerEmail).Clear();
            driver.FindElement(NewCustomerEmail).SendKeys("erreiifucom");
            driver.FindElement(NewCustomerEmailLabel).Click();
            Thread.Sleep(1000);
            wait.Until(ExpectedConditions.ElementExists((By)NewCustomerEmailValidationError));
            Assert.IsTrue(driver.FindElement(NewCustomerEmailValidationError).Displayed);
            driver.FindElement(NewCustomerEmail).Click();
            Thread.Sleep(1000);
            Actions action = new Actions(driver);
            WebElement ele = (WebElement)driver.FindElement(NewCustomerEmail);
            action.Click(ele).Click(ele).Click(ele).Perform();
            driver.FindElement(NewCustomerEmail).SendKeys(Keys.Delete);
            driver.FindElement(NewCustomerEmail).SendKeys("$%%$%$@%^$%%com");
            driver.FindElement(NewCustomerEmailLabel).Click();
            Thread.Sleep(1000);
            wait.Until(ExpectedConditions.ElementExists((By)NewCustomerEmailValidationError));
            Assert.IsTrue(driver.FindElement(NewCustomerEmailValidationError).Displayed);
            driver.FindElement(NewCustomerEmail).Click();
            Thread.Sleep(1000);
            action.Click(ele).Click(ele).Click(ele).Perform();
            driver.FindElement(NewCustomerEmail).SendKeys(Keys.Delete);
            driver.FindElement(NewCustomerEmail).SendKeys("Test@test.com");
            driver.FindElement(NewCustomerEmailLabel).Click();
            Thread.Sleep(1000);
            //verify error message not present
            var ErrorMsg = 0;
            try
            {
                WebElement errorMsg = (WebElement)driver.FindElement(NewCustomerEmailValidationError);
                if (errorMsg.Displayed)
                {
                    ErrorMsg = 1;
                    Assert.Fail();
                }
            }
            catch (Exception)
            {
                if (ErrorMsg > 0)
                {
                    Console.WriteLine("Error message still visible");
                }
                else
                {
                    Console.WriteLine("Error message removed");
                }
            }
        }

        public void AddNewCustomer()
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
            driver.FindElement(NewCustomerButton).Click();
            wait.Until(ExpectedConditions.ElementExists((By)NewCustomerForm));
            Assert.IsTrue(driver.FindElement(NewCustomerForm).Displayed);
            //Fill non mandatory fields
            //Title
            driver.FindElement(NewCustomerTitle).Click();
            Thread.Sleep(1000);
            driver.FindElement(NewCustomerTitleDropdown).Click();
            Thread.Sleep(1000);
            //First name
            driver.FindElement(NewCustomerFirstName).Click();
            Thread.Sleep(1000);
            Actions action = new Actions(driver);
            WebElement ele = (WebElement)driver.FindElement(NewCustomerFirstName);
            action.Click(ele).Click(ele).Click(ele).Perform();
            driver.FindElement(NewCustomerFirstName).SendKeys(Keys.Delete);
            driver.FindElement(NewCustomerFirstName).SendKeys("AAA");
            //Contact method
            driver.FindElement(NewCustomerContactMethod).Click();
            Thread.Sleep(1000);
            driver.FindElement(NewCustomerContactMethodDropdown).Click();
            Thread.Sleep(1000);
            //Mobile number
            driver.FindElement(NewCustomerMobile).Click();
            Thread.Sleep(1000);
            driver.FindElement(NewCustomerMobile).Clear();
            driver.FindElement(NewCustomerMobile).SendKeys("07777777777");
            Thread.Sleep(1000);
            //Home phone number
            driver.FindElement(NewCustomerHomePhone).Click();
            Thread.Sleep(1000);
            driver.FindElement(NewCustomerHomePhone).Clear();
            driver.FindElement(NewCustomerHomePhone).SendKeys("08888888888");
            Thread.Sleep(1000);
            //Work number
            driver.FindElement(NewCustomerWorkPhone).Click();
            Thread.Sleep(1000);
            driver.FindElement(NewCustomerWorkPhone).Clear();
            driver.FindElement(NewCustomerWorkPhone).SendKeys("09999999999");
            Thread.Sleep(1000);
            //Email address
            driver.FindElement(NewCustomerEmail).Click();
            Thread.Sleep(1000);
            driver.FindElement(NewCustomerEmail).Clear();
            driver.FindElement(NewCustomerEmail).SendKeys("Testing@testing.com");
            Thread.Sleep(1000);
            //Fill mandatory fields
            driver.FindElement(NewCustomerSurname).Click();
            Thread.Sleep(1000);
            WebElement ele1 = (WebElement)driver.FindElement(NewCustomerSurname);
            action.Click(ele1).Click(ele1).Click(ele1).Perform();
            driver.FindElement(NewCustomerSurname).SendKeys(Keys.Delete);
            driver.FindElement(NewCustomerSurname).SendKeys("AAA");
            driver.SwitchTo().Frame(driver.FindElement(By.Id("WebResource_WMDCCustomerAddressSearch")));
            Thread.Sleep(1000);
            driver.FindElement(NewCustomerAddress).Click();
            driver.FindElement(NewCustomerAddress).SendKeys("4 Sandhill Rise Pontefract WF8 1RA");
            driver.FindElement(NewCustomerAddress).SendKeys(Keys.Enter);
            wait.Until(ExpectedConditions.ElementExists((By)NewCustomerAddressDropdown));
            driver.FindElement(NewCustomerAddressDropdown).Click();
            driver.SwitchTo().DefaultContent();
            //Save and close
            driver.FindElement(NewCustomerSaveandClose).Click();
            Thread.Sleep(3000);
            //Duplicate record
            try { 
            if (driver.FindElement(DuplicateRecordOverlay).Displayed)
            {
                Thread.Sleep(2000);
                driver.FindElement(DuplicateRecordSelect).Click();
                Thread.Sleep(2000);
                driver.FindElement(DuplicateRecordMerge).Click();
                Thread.Sleep(2000);
                wait.Until(ExpectedConditions.ElementExists((By)MergeCustomersOverlay));
                Thread.Sleep(2000);
                driver.FindElement(MergeCustomersOverlayButton).Click();
                Thread.Sleep(2000);
                driver.FindElement(CustomersLHN).Click();
                Thread.Sleep(2000);
            }
                }
            catch (Exception)
            {
                if (driver.FindElement(ActiveContactsList).Displayed)
                {
                    Console.WriteLine("No duplicates found");
                }
            }
            wait.Until(ExpectedConditions.ElementExists((By)ActiveContactsList));
            Thread.Sleep(1000);
            Assert.IsTrue(driver.FindElement(ActiveContactsList).Displayed);
            Thread.Sleep((1000));
            driver.FindElement(NewCustomerOnList).Click();
            Thread.Sleep((2000));
            Assert.IsTrue(driver.FindElement(ExistingCustomerRecord).Displayed);
            //Delete customer
            driver.FindElement(ActiveContactsDelete).Click();
            wait.Until(ExpectedConditions.ElementExists((By)ActiveContactsDeleteOverlay));
            Thread.Sleep(1000);
            driver.FindElement(ActiveContactsDeleteOverlay).Click();
            Thread.Sleep((4000));
            //add verification that user is deleted
            wait.Until(ExpectedConditions.ElementExists((By)ActiveContactsList));
            Assert.IsTrue(driver.FindElement(ActiveContactsList).Displayed);
            Thread.Sleep((2000));
            //verify user not present
            var Customer = 0;
            try
            {

                WebElement customer = (WebElement)driver.FindElement(ExistingCustomerEmail1);
                if (customer.Displayed)
                {
                    Customer = 1;
                    Assert.Fail();
                }
            }
            catch (Exception)
            {
                if (Customer > 0)
                {
                    Console.WriteLine("User not removed");
                }
                else
                {
                    Console.WriteLine("User removed");
                }
            }
        }

        public void AddNewCustomerUnknownAddress()
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
            driver.FindElement(NewCustomerButton).Click();
            wait.Until(ExpectedConditions.ElementExists((By)NewCustomerForm));
            Assert.IsTrue(driver.FindElement(NewCustomerForm).Displayed);
            Thread.Sleep(1000);
            //First name
            driver.FindElement(NewCustomerFirstName).Click();
            Thread.Sleep(1000);
            Actions action = new Actions(driver);
            WebElement ele = (WebElement)driver.FindElement(NewCustomerFirstName);
            action.Click(ele).Click(ele).Click(ele).Perform();
            driver.FindElement(NewCustomerFirstName).SendKeys(Keys.Delete);
            driver.FindElement(NewCustomerFirstName).SendKeys("AAA");
            //Surname
            driver.FindElement(NewCustomerSurname).Click();
            Thread.Sleep(1000);
            WebElement ele1 = (WebElement)driver.FindElement(NewCustomerSurname);
            action.Click(ele1).Click(ele1).Click(ele1).Perform();
            driver.FindElement(NewCustomerSurname).SendKeys(Keys.Delete);
            driver.FindElement(NewCustomerSurname).SendKeys("AAA");
            //Email address
            driver.FindElement(NewCustomerEmail).Click();
            Thread.Sleep(1000);
            driver.FindElement(NewCustomerEmail).Clear();
            driver.FindElement(NewCustomerEmail).SendKeys("Testing@testing.com");
            Thread.Sleep(1000);
            //Address
            driver.SwitchTo().Frame(driver.FindElement(By.Id("WebResource_WMDCCustomerAddressSearch")));
            Thread.Sleep(1000);
            driver.FindElement(UnknownAddressLink).Click();
            driver.SwitchTo().DefaultContent();
            wait.Until(ExpectedConditions.ElementExists((By)UnderstandBtnOnOverlay));
            driver.FindElement(UnderstandBtnOnOverlay).Click();
            driver.SwitchTo().Frame(driver.FindElement(By.Id("WebResource_WMDCCustomerAddressSearch")));
            wait.Until(ExpectedConditions.ElementExists((By)UnknownAdressSelected));
            Assert.IsTrue(driver.FindElement(UnknownAdressSelected).Displayed);
            driver.SwitchTo().DefaultContent();
            //Save and close
            driver.FindElement(NewCustomerSaveandClose).Click();
            Thread.Sleep(4000);
            //Duplicate record
            try
            {
                if (driver.FindElement(DuplicateRecordOverlay).Displayed)
                {
                    Thread.Sleep(2000);
                    driver.FindElement(DuplicateRecordSelect).Click();
                    Thread.Sleep(2000);
                    driver.FindElement(DuplicateRecordMerge).Click();
                    Thread.Sleep(2000);
                    wait.Until(ExpectedConditions.ElementExists((By)MergeCustomersOverlay));
                    Thread.Sleep(2000);
                    driver.FindElement(MergeCustomersOverlayButton).Click();
                    Thread.Sleep(2000);
                    driver.FindElement(CustomersLHN).Click();
                    Thread.Sleep(2000);
                }
            }
            catch (Exception)
            {
                if (driver.FindElement(ActiveContactsList).Displayed)
                {
                    Console.WriteLine("No duplicates found");
                }
            }
            wait.Until(ExpectedConditions.ElementExists((By)ActiveContactsList));
            Thread.Sleep(1000);
            Assert.IsTrue(driver.FindElement(ActiveContactsList).Displayed);
            Thread.Sleep((1000));
            //Slect customer on active customer list
            driver.FindElement(NewCustomerOnList).Click();
            Thread.Sleep((2000));
            Assert.IsTrue(driver.FindElement(ExistingCustomerRecord).Displayed);
            //Verify address showns as unknown and click it
            wait.Until(ExpectedConditions.ElementExists((By)UnknownAddressOnProfile));
            Assert.IsTrue(driver.FindElement(UnknownAddressOnProfile).Displayed);
            driver.FindElement(UnknownAddressOnProfile).Click();
            //Verify addressable location form loads
            wait.Until(ExpectedConditions.ElementExists((By)AddressableLocationTitle));
            Assert.IsTrue(driver.FindElement(AddressableLocationTitle).Displayed);
            Thread.Sleep(2000);
            driver.FindElement(FullAddressTitle).Click();
            Thread.Sleep(1000);
            Actions actions = new Actions(driver);
            actions.SendKeys(Keys.PageDown).Build().Perform();
            Thread.Sleep(1000);
            actions.SendKeys(Keys.PageDown).Build().Perform();
            //Verify UPRN = 99999999
            wait.Until(ExpectedConditions.ElementExists((By)AddressUPRN));
            Assert.IsTrue(driver.FindElement(AddressUPRN).Displayed);
            //Click back button to return to customer profile
            driver.FindElement(BackButton).Click();
            wait.Until(ExpectedConditions.ElementExists((By)ExistingCustomerRecord));
            Assert.IsTrue(driver.FindElement(ExistingCustomerRecord).Displayed);
            //Delete customer
            wait.Until(ExpectedConditions.ElementExists((By)ActiveContactsDelete));
            driver.FindElement(ActiveContactsDelete).Click();
            wait.Until(ExpectedConditions.ElementExists((By)ActiveContactsDeleteOverlay));
            Thread.Sleep(1000);
            driver.FindElement(ActiveContactsDeleteOverlay).Click();
            Thread.Sleep((4000));
            //add verification that user is deleted
            wait.Until(ExpectedConditions.ElementExists((By)ActiveContactsList));
            Assert.IsTrue(driver.FindElement(ActiveContactsList).Displayed);
            Thread.Sleep((2000));
            //verify user not present
            var Customer = 0;
            try
            {

                WebElement customer = (WebElement)driver.FindElement(ExistingCustomerEmail1);
                if (customer.Displayed)
                {
                    Customer = 1;
                    Assert.Fail();
                }
            }
            catch (Exception)
            {
                if (Customer > 0)
                {
                    Console.WriteLine("User not removed");
                }
                else
                {
                    Console.WriteLine("User removed");
                }
            }
        }

        public void AddNewCustomerWithoutMandatoryFields()
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
            driver.FindElement(NewCustomerButton).Click();
            wait.Until(ExpectedConditions.ElementExists((By)NewCustomerForm));
            Assert.IsTrue(driver.FindElement(NewCustomerForm).Displayed);
            //Fill non mandatory fields
            //Title
            driver.FindElement(NewCustomerTitle).Click();
            Thread.Sleep(1000);
            driver.FindElement(NewCustomerTitleDropdown).Click();
            Thread.Sleep(1000);
            //First name
            driver.FindElement(NewCustomerFirstName).Click();
            Thread.Sleep(1000);
            driver.FindElement(NewCustomerFirstName).Clear();
            driver.FindElement(NewCustomerFirstName).SendKeys("AAA");
            //Contact method
            driver.FindElement(NewCustomerContactMethod).Click();
            Thread.Sleep(1000);
            driver.FindElement(NewCustomerContactMethodDropdown).Click();
            Thread.Sleep(1000);
            //Mobile number
            driver.FindElement(NewCustomerMobile).Click();
            Thread.Sleep(1000);
            driver.FindElement(NewCustomerMobile).Clear();
            driver.FindElement(NewCustomerMobile).SendKeys("07777777777");
            Thread.Sleep(1000);
            //Home phone number
            driver.FindElement(NewCustomerHomePhone).Click();
            Thread.Sleep(1000);
            driver.FindElement(NewCustomerHomePhone).Clear();
            driver.FindElement(NewCustomerHomePhone).SendKeys("08888888888");
            Thread.Sleep(1000);
            //Work number
            driver.FindElement(NewCustomerWorkPhone).Click();
            Thread.Sleep(1000);
            driver.FindElement(NewCustomerWorkPhone).Clear();
            driver.FindElement(NewCustomerWorkPhone).SendKeys("09999999999");
            Thread.Sleep(1000);
            //Email address
            driver.FindElement(NewCustomerEmail).Click();
            Thread.Sleep(1000);
            driver.FindElement(NewCustomerEmail).Clear();
            driver.FindElement(NewCustomerEmail).SendKeys("test@test.com");
            Thread.Sleep(1000);
            //Save and close
            driver.FindElement(NewCustomerSaveandClose).Click();
            Thread.Sleep((2000));
            wait.Until(ExpectedConditions.ElementExists((By)NewCustomerErrorMsg));
            Assert.IsTrue(driver.FindElement(NewCustomerErrorMsg).Displayed);
            Thread.Sleep((2000));
            wait.Until(ExpectedConditions.ElementExists((By)NewCustomerInlineErrorMsg));
            Assert.IsTrue(driver.FindElement(NewCustomerInlineErrorMsg).Displayed);
        }

        public void SearchCustomerOnActiveContacts()
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
            //Enter search term
            driver.FindElement(CustomerSearch).Click();
            Thread.Sleep(2000);
            driver.FindElement(CustomerSearch).SendKeys("Moore");
            Thread.Sleep(1000);
            driver.FindElement(CustomerSearch).SendKeys(Keys.Enter);
            Thread.Sleep(4000);
            //Check search results
            try
            {
                if (driver.FindElement(SearchResultOnList).Displayed)
                {
                    Console.WriteLine("Search results correct");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Search results not correct");
                Assert.Fail();
            }
        }

        public void ContinueWithCustomer()
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
            driver.FindElement(NewCustomerButton).Click();
            wait.Until(ExpectedConditions.ElementExists((By)NewCustomerForm));
            Assert.IsTrue(driver.FindElement(NewCustomerForm).Displayed);
            //First name
            driver.FindElement(NewCustomerFirstName).Click();
            Thread.Sleep(1000);
            Actions action = new Actions(driver);
            WebElement ele = (WebElement)driver.FindElement(NewCustomerFirstName);
            action.Click(ele).Click(ele).Click(ele).Perform();
            driver.FindElement(NewCustomerFirstName).SendKeys(Keys.Delete);
            driver.FindElement(NewCustomerFirstName).SendKeys("AAA");
            //Surname
            driver.FindElement(NewCustomerSurname).Click();
            Thread.Sleep(1000);
            WebElement ele1 = (WebElement)driver.FindElement(NewCustomerSurname);
            action.Click(ele1).Click(ele1).Click(ele1).Perform();
            driver.FindElement(NewCustomerSurname).SendKeys(Keys.Delete);
            driver.FindElement(NewCustomerSurname).SendKeys("AAA");
            Thread.Sleep(1000);
            //Email address
            driver.FindElement(NewCustomerEmail).Click();
            Thread.Sleep(1000);
            driver.FindElement(NewCustomerEmail).Clear();
            driver.FindElement(NewCustomerEmail).SendKeys("tester@tester.com");
            Thread.Sleep(1000);
            //Address
            driver.SwitchTo().Frame(driver.FindElement(By.Id("WebResource_WMDCCustomerAddressSearch")));
            driver.FindElement(NewCustomerAddress).Click();
            driver.FindElement(NewCustomerAddress).SendKeys("4 Sandhill Rise Pontefract WF8 1RA");
            driver.FindElement(NewCustomerAddress).SendKeys(Keys.Enter);
            wait.Until(ExpectedConditions.ElementExists((By)NewCustomerAddressDropdown));
            driver.FindElement(NewCustomerAddressDropdown).Click();
            driver.SwitchTo().DefaultContent();
            //Click save btn
            driver.FindElement(NewCustomerSaveBtn).Click();
            Thread.Sleep((2000));
            //Duplicate record check
            try
            {
                if (driver.FindElement(DuplicateRecordOverlay).Displayed)
                {
                    Thread.Sleep(2000);
                    driver.FindElement(DuplicateRecordSelect).Click();
                    Thread.Sleep(2000);
                    driver.FindElement(DuplicateRecordMerge).Click();
                    Thread.Sleep(2000);
                    wait.Until(ExpectedConditions.ElementExists((By)MergeCustomersOverlay));
                    Thread.Sleep(2000);
                    driver.FindElement(MergeCustomersOverlayButton).Click();
                    Thread.Sleep(2000);
                    driver.FindElement(CustomersLHN).Click();
                    Thread.Sleep(2000);
                    driver.FindElement(NewCustomerOnList).Click();
                    Thread.Sleep(2000);
                }
            }
            catch (Exception)
            {
                    Console.WriteLine("No duplicates found");
            }
            //Click continue with customer button
            Thread.Sleep(2000);
            driver.SwitchTo().Frame(driver.FindElement(By.Id("WebResource_continuewithcustomer")));
            Thread.Sleep(2000);
            driver.FindElement(ContinueCustomerBtn).Click();
            Thread.Sleep(2000);
            //Verify dashboard is displayed
            wait.Until(ExpectedConditions.ElementExists((By)DashboardTitle));
            Assert.IsTrue(driver.FindElement(DashboardTitle).Displayed);
            //Check customer details on dashboard
            driver.SwitchTo().Frame(driver.FindElement(By.Id("9532b1de-41a1-456c-b21c-805faca15573_WebResource_customeradvisorstart")));
            wait.Until(ExpectedConditions.ElementExists((By)NewCustomerInAccessChannel));
            Assert.IsTrue(driver.FindElement(NewCustomerInAccessChannel).Displayed);
            wait.Until(ExpectedConditions.ElementExists((By)AccessChannelCustomerDetails));
            Assert.IsTrue(driver.FindElement(AccessChannelCustomerDetails).Displayed);
            wait.Until(ExpectedConditions.ElementExists((By)CustomerAddressInAccessChannel));
            Assert.IsTrue(driver.FindElement(CustomerAddressInAccessChannel).Displayed);
            wait.Until(ExpectedConditions.ElementExists((By)CustomerEmailInAccessChannel2));
            Assert.IsTrue(driver.FindElement(CustomerEmailInAccessChannel2).Displayed);
            wait.Until(ExpectedConditions.ElementExists((By)CaseHistoryInAccessChannel));
            Assert.IsTrue(driver.FindElement(CaseHistoryInAccessChannel).Displayed);
            //Click customer from LHN
            driver.SwitchTo().DefaultContent();
            driver.FindElement(CustomersLHN).Click();
            wait.Until(ExpectedConditions.ElementExists((By)ActiveContactsList));
            Thread.Sleep(1000);
            Assert.IsTrue(driver.FindElement(ActiveContactsList).Displayed);
            Thread.Sleep((1000));
            driver.FindElement(NewCustomerOnList).Click();
            Thread.Sleep((2000));
            Assert.IsTrue(driver.FindElement(ExistingCustomerRecord).Displayed);
            //Delete customer
            driver.FindElement(ActiveContactsDelete).Click();
            wait.Until(ExpectedConditions.ElementExists((By)ActiveContactsDeleteOverlay));
            Thread.Sleep(1000);
            driver.FindElement(ActiveContactsDeleteOverlay).Click();
            Thread.Sleep((4000));
            //add verification that user is deleted
            wait.Until(ExpectedConditions.ElementExists((By)ActiveContactsList));
            Assert.IsTrue(driver.FindElement(ActiveContactsList).Displayed);
            Thread.Sleep((2000));
            //verify user not present
            var Customer = 0;
            try
            {

                WebElement customer = (WebElement)driver.FindElement(ExistingCustomerEmail);
                if (customer.Displayed)
                {
                    Customer = 1;
                    Assert.Fail();
                }
            }
            catch (Exception)
            {
                if (Customer > 0)
                {
                    Console.WriteLine("User not removed");
                }
                else
                {
                    Console.WriteLine("User removed");
                }
            }
        }

        public void ContinueWithManualCustomer()
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
            driver.FindElement(NewCustomerButton).Click();
            wait.Until(ExpectedConditions.ElementExists((By)NewCustomerForm));
            Assert.IsTrue(driver.FindElement(NewCustomerForm).Displayed);
            //First name
            driver.FindElement(NewCustomerFirstName).Click();
            Thread.Sleep(1000);
            Actions action = new Actions(driver);
            WebElement ele = (WebElement)driver.FindElement(NewCustomerFirstName);
            action.Click(ele).Click(ele).Click(ele).Perform();
            driver.FindElement(NewCustomerFirstName).SendKeys(Keys.Delete);
            driver.FindElement(NewCustomerFirstName).SendKeys("AAA");
            //Surname
            driver.FindElement(NewCustomerSurname).Click();
            Thread.Sleep(1000);
            WebElement ele1 = (WebElement)driver.FindElement(NewCustomerSurname);
            action.Click(ele1).Click(ele1).Click(ele1).Perform();
            driver.FindElement(NewCustomerSurname).SendKeys(Keys.Delete);
            driver.FindElement(NewCustomerSurname).SendKeys("AAA");
            Thread.Sleep(1000);
            //Email address
            driver.FindElement(NewCustomerEmail).Click();
            Thread.Sleep(1000);
            driver.FindElement(NewCustomerEmail).Clear();
            driver.FindElement(NewCustomerEmail).SendKeys("Testing@testing.com");
            Thread.Sleep(1000);
            //Address
            driver.SwitchTo().Frame(driver.FindElement(By.Id("WebResource_WMDCCustomerAddressSearch")));
            Thread.Sleep(1000);
            driver.FindElement(NewCustomerAddress).Click();
            driver.FindElement(NewCustomerAddress).SendKeys("80 Spring Avenue Ashby-De-La-Zouch LE65 2RB");
            driver.FindElement(NewCustomerAddress).SendKeys(Keys.Enter);
            //Click can't find address link
            wait.Until(ExpectedConditions.ElementExists((By)CantFindAddressLink));
            driver.FindElement(CantFindAddressLink).Click();
            Thread.Sleep(2000);
            driver.SwitchTo().DefaultContent();
            //Click I understand on overlay
            wait.Until(ExpectedConditions.ElementExists((By)UnderstandBtnOnOverlay));
            driver.FindElement(UnderstandBtnOnOverlay).Click();
            Thread.Sleep(2000);
            //Try to add address without postcode
            driver.SwitchTo().Frame(driver.FindElement(By.Id("WebResource_WMDCCustomerAddressSearch")));
            Thread.Sleep(1000);
            driver.FindElement(ManualAddressHouseNumber).Click();
            driver.FindElement(ManualAddressHouseNumber).SendKeys("80");
            Thread.Sleep(1000);
            driver.FindElement(ManualAddressStreetName).Click();
            driver.FindElement(ManualAddressStreetName).SendKeys("Spring Avenue");
            Thread.Sleep(1000);
            driver.FindElement(ManualAddressTown).Click();
            driver.FindElement(ManualAddressTown).SendKeys("Ashby-De-La-Zouch");
            Thread.Sleep(1000);
            driver.FindElement(ManualAddressPostcode).Click();
            driver.FindElement(ManualAddressPostcode).SendKeys("LE65 2RB");
            Thread.Sleep(1000);
            //Select out of area tickbox
            driver.FindElement(OutOfAreaTickbox).Click();
            Thread.Sleep(1000);
            //Click confirm button
            driver.FindElement(ConfirmManualAdressBtn).Click();
            Thread.Sleep(1000);
            driver.SwitchTo().DefaultContent();
            //Click save btn
            driver.FindElement(NewCustomerSaveBtn).Click();
            Thread.Sleep((2000));
            //Duplicate record check
            try
            {
                if (driver.FindElement(DuplicateRecordOverlay).Displayed)
                {
                    Thread.Sleep(2000);
                    driver.FindElement(DuplicateRecordSelect).Click();
                    Thread.Sleep(2000);
                    driver.FindElement(DuplicateRecordMerge).Click();
                    Thread.Sleep(2000);
                    wait.Until(ExpectedConditions.ElementExists((By)MergeCustomersOverlay));
                    Thread.Sleep(2000);
                    driver.FindElement(MergeCustomersOverlayButton).Click();
                    Thread.Sleep(2000);
                    driver.FindElement(CustomersLHN).Click();
                    Thread.Sleep(2000);
                    driver.FindElement(NewCustomerOnList).Click();
                    Thread.Sleep(2000);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("No duplicates found");
            }
            //Click continue with customer button
            Thread.Sleep(2000);
            driver.SwitchTo().Frame(driver.FindElement(By.Id("WebResource_continuewithcustomer")));
            Thread.Sleep(2000);
            driver.FindElement(ContinueCustomerBtn).Click();
            Thread.Sleep(2000);
            //Verify dashboard is displayed
            wait.Until(ExpectedConditions.ElementExists((By)DashboardTitle));
            Assert.IsTrue(driver.FindElement(DashboardTitle).Displayed);
            //Check customer details on dashboard
            driver.SwitchTo().Frame(driver.FindElement(By.Id("9532b1de-41a1-456c-b21c-805faca15573_WebResource_customeradvisorstart")));
            wait.Until(ExpectedConditions.ElementExists((By)NewCustomerInAccessChannel));
            Assert.IsTrue(driver.FindElement(NewCustomerInAccessChannel).Displayed);
            wait.Until(ExpectedConditions.ElementExists((By)AccessChannelCustomerDetails));
            Assert.IsTrue(driver.FindElement(AccessChannelCustomerDetails).Displayed);
            wait.Until(ExpectedConditions.ElementExists((By)CustomerAddressInAccessChannel1));
            Assert.IsTrue(driver.FindElement(CustomerAddressInAccessChannel1).Displayed);
            wait.Until(ExpectedConditions.ElementExists((By)CustomerEmailInAccessChannel1));
            Assert.IsTrue(driver.FindElement(CustomerEmailInAccessChannel1).Displayed);
            wait.Until(ExpectedConditions.ElementExists((By)CaseHistoryInAccessChannel));
            Assert.IsTrue(driver.FindElement(CaseHistoryInAccessChannel).Displayed);
            driver.SwitchTo().DefaultContent();
            //Click filter icon in header
            Thread.Sleep(2000);
            driver.FindElement(AdvancedFindFilter).Click();
            Thread.Sleep(7000);
            //Click look for dropdown
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            driver.SwitchTo().Frame(driver.FindElement(By.XPath("//iframe[@id='contentIFrame0']")));
            Thread.Sleep(2000);
            driver.FindElement(FilterLookFor).Click();
            Thread.Sleep(2000);
            //Click addressable locations
            driver.FindElement(LookForOptionOnDropdown).Click();
            Thread.Sleep(2000);
            //Click results icon
            driver.SwitchTo().DefaultContent();
            driver.FindElement(ResultsIconOnLookForBanner).Click();
            Thread.Sleep(2000);
            //Sort created on column to newest first
            driver.SwitchTo().Frame(driver.FindElement(By.XPath("//iframe[@id='contentIFrame0']")));
            driver.SwitchTo().Frame("resultFrame");
            Thread.Sleep(5000);
            driver.FindElement(ResultsCreatedOnColumn).Click();
            Thread.Sleep(2000);
            driver.FindElement(ResultsCreatedOnColumn).Click();
            Thread.Sleep(2000);
            //Verify address just added is shown
            wait.Until(ExpectedConditions.ElementExists((By)AddressResultOnTable1));
            Assert.IsTrue(driver.FindElement(AddressResultOnTable1).Displayed);
            //Close pop up
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            Thread.Sleep(2000);
            driver.Close();
            //Click customers on LHN
            driver.SwitchTo().Window(driver.WindowHandles.First());
            driver.SwitchTo().DefaultContent();
            driver.FindElement(CustomersLHN).Click();
            wait.Until(ExpectedConditions.ElementExists((By)ActiveContactsList));
            Thread.Sleep(1000);
            Assert.IsTrue(driver.FindElement(ActiveContactsList).Displayed);
            Thread.Sleep((1000));
            driver.FindElement(NewCustomerOnList).Click();
            Thread.Sleep((2000));
            Assert.IsTrue(driver.FindElement(ExistingCustomerRecord).Displayed);
            //Delete customer
            driver.FindElement(ActiveContactsDelete).Click();
            wait.Until(ExpectedConditions.ElementExists((By)ActiveContactsDeleteOverlay));
            Thread.Sleep(1000);
            driver.FindElement(ActiveContactsDeleteOverlay).Click();
            Thread.Sleep((4000));
            //add verification that user is deleted
            wait.Until(ExpectedConditions.ElementExists((By)ActiveContactsList));
            Assert.IsTrue(driver.FindElement(ActiveContactsList).Displayed);
            Thread.Sleep((2000));
            //verify user not present
            var Customer = 0;
            try
            {

                WebElement customer = (WebElement)driver.FindElement(ExistingCustomerEmail1);
                if (customer.Displayed)
                {
                    Customer = 1;
                    Assert.Fail();
                }
            }
            catch (Exception)
            {
                if (Customer > 0)
                {
                    Console.WriteLine("User not removed");
                }
                else
                {
                    Console.WriteLine("User removed");
                }
            }
        }

        public void ContinueWithCustomerUnknownAddress()
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
            driver.FindElement(NewCustomerButton).Click();
            wait.Until(ExpectedConditions.ElementExists((By)NewCustomerForm));
            Assert.IsTrue(driver.FindElement(NewCustomerForm).Displayed);
            //First name
            driver.FindElement(NewCustomerFirstName).Click();
            Thread.Sleep(1000);
            Actions action = new Actions(driver);
            WebElement ele = (WebElement)driver.FindElement(NewCustomerFirstName);
            action.Click(ele).Click(ele).Click(ele).Perform();
            driver.FindElement(NewCustomerFirstName).SendKeys(Keys.Delete);
            driver.FindElement(NewCustomerFirstName).SendKeys("AAA");
            //Surname
            driver.FindElement(NewCustomerSurname).Click();
            Thread.Sleep(1000);
            WebElement ele1 = (WebElement)driver.FindElement(NewCustomerSurname);
            action.Click(ele1).Click(ele1).Click(ele1).Perform();
            driver.FindElement(NewCustomerSurname).SendKeys(Keys.Delete);
            driver.FindElement(NewCustomerSurname).SendKeys("AAA");
            Thread.Sleep(1000);
            //Email address
            driver.FindElement(NewCustomerEmail).Click();
            Thread.Sleep(1000);
            driver.FindElement(NewCustomerEmail).Clear();
            driver.FindElement(NewCustomerEmail).SendKeys("tester@tester.com");
            Thread.Sleep(1000);
            //Address
            driver.SwitchTo().Frame(driver.FindElement(By.Id("WebResource_WMDCCustomerAddressSearch")));
            Thread.Sleep(1000);
            driver.FindElement(UnknownAddressLink).Click();
            driver.SwitchTo().DefaultContent();
            wait.Until(ExpectedConditions.ElementExists((By)UnderstandBtnOnOverlay));
            driver.FindElement(UnderstandBtnOnOverlay).Click();
            driver.SwitchTo().Frame(driver.FindElement(By.Id("WebResource_WMDCCustomerAddressSearch")));
            wait.Until(ExpectedConditions.ElementExists((By)UnknownAdressSelected));
            Assert.IsTrue(driver.FindElement(UnknownAdressSelected).Displayed);
            driver.SwitchTo().DefaultContent();
            //Click save btn
            driver.FindElement(NewCustomerSaveBtn).Click();
            Thread.Sleep((2000));
            //Duplicate record check
            try
            {
                if (driver.FindElement(DuplicateRecordOverlay).Displayed)
                {
                    Thread.Sleep(2000);
                    driver.FindElement(DuplicateRecordSelect).Click();
                    Thread.Sleep(2000);
                    driver.FindElement(DuplicateRecordMerge).Click();
                    Thread.Sleep(2000);
                    wait.Until(ExpectedConditions.ElementExists((By)MergeCustomersOverlay));
                    Thread.Sleep(2000);
                    driver.FindElement(MergeCustomersOverlayButton).Click();
                    Thread.Sleep(2000);
                    driver.FindElement(CustomersLHN).Click();
                    Thread.Sleep(2000);
                    driver.FindElement(NewCustomerOnList).Click();
                    Thread.Sleep(2000);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("No duplicates found");
            }
            //Click continue with customer button
            Thread.Sleep(2000);
            driver.SwitchTo().Frame(driver.FindElement(By.Id("WebResource_continuewithcustomer")));
            Thread.Sleep(2000);
            driver.FindElement(ContinueCustomerBtn).Click();
            Thread.Sleep(2000);
            //Verify dashboard is displayed
            wait.Until(ExpectedConditions.ElementExists((By)DashboardTitle));
            Assert.IsTrue(driver.FindElement(DashboardTitle).Displayed);
            //Check customer details on dashboard
            driver.SwitchTo().Frame(driver.FindElement(By.Id("9532b1de-41a1-456c-b21c-805faca15573_WebResource_customeradvisorstart")));
            wait.Until(ExpectedConditions.ElementExists((By)NewCustomerInAccessChannel));
            Assert.IsTrue(driver.FindElement(NewCustomerInAccessChannel).Displayed);
            wait.Until(ExpectedConditions.ElementExists((By)AccessChannelCustomerDetails));
            Assert.IsTrue(driver.FindElement(AccessChannelCustomerDetails).Displayed);
            wait.Until(ExpectedConditions.ElementExists((By)UnknownAddressInAccessChannel));
            Assert.IsTrue(driver.FindElement(UnknownAddressInAccessChannel).Displayed);
            driver.SwitchTo().DefaultContent();
            driver.FindElement(CustomersLHN).Click();
            wait.Until(ExpectedConditions.ElementExists((By)ActiveContactsList));
            Thread.Sleep(1000);
            Assert.IsTrue(driver.FindElement(ActiveContactsList).Displayed);
            Thread.Sleep((1000));
            driver.FindElement(NewCustomerOnList).Click();
            Thread.Sleep((2000));
            Assert.IsTrue(driver.FindElement(ExistingCustomerRecord).Displayed);
            //Delete customer
            driver.FindElement(ActiveContactsDelete).Click();
            wait.Until(ExpectedConditions.ElementExists((By)ActiveContactsDeleteOverlay));
            Thread.Sleep(1000);
            driver.FindElement(ActiveContactsDeleteOverlay).Click();
            Thread.Sleep((4000));
            //add verification that user is deleted
            wait.Until(ExpectedConditions.ElementExists((By)ActiveContactsList));
            Assert.IsTrue(driver.FindElement(ActiveContactsList).Displayed);
            Thread.Sleep((2000));
            //verify user not present
            var Customer = 0;
            try
            {

                WebElement customer = (WebElement)driver.FindElement(ExistingCustomerEmail);
                if (customer.Displayed)
                {
                    Customer = 1;
                    Assert.Fail();
                }
            }
            catch (Exception)
            {
                if (Customer > 0)
                {
                    Console.WriteLine("User not removed");
                }
                else
                {
                    Console.WriteLine("User removed");
                }
            }
        }

        public void OutOfAreaAddress()
        {
            //Verify Home dashboard is displayed
            Thread.Sleep(4000);
            wait.Until(ExpectedConditions.ElementExists((By)DashboardsLHN));
            driver.FindElement(DashboardsLHN).Click();
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)DashboardTitle));
            Assert.IsTrue(driver.FindElement(DashboardTitle).Displayed);
            Thread.Sleep(3000);
            //Switch to searchbox iframe
            driver.SwitchTo().Frame(driver.FindElement(By.Id("9532b1de-41a1-456c-b21c-805faca15573_WebResource_customeradvisorstart")));
            wait.Until(ExpectedConditions.ElementExists((By)Searchbox));
            Assert.IsTrue(driver.FindElement(Searchbox).Displayed);
            //Enter fullname in search
            driver.FindElement(Searchbox).Click();
            driver.FindElement(Searchbox).SendKeys("New User");
            driver.FindElement(Searchbox).SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)SearchDropdownCreateNew));
            Assert.IsTrue(driver.FindElement(SearchDropdownCreateNew).Displayed);
            driver.FindElement(SearchDropdownCreateNew).Click();
            Thread.Sleep(2000);
            driver.SwitchTo().DefaultContent();
            //Click yes on overlay
            wait.Until(ExpectedConditions.ElementExists((By)CreateCustomerOverlayYesBtn));
            driver.FindElement(CreateCustomerOverlayYesBtn).Click();
            Thread.Sleep(3000);
            //Verify new customer form is displayed
            wait.Until(ExpectedConditions.ElementExists((By)NewCustomerForm));
            Assert.IsTrue(driver.FindElement(NewCustomerForm).Displayed);
            //Fill mandatory fields
            //Surname
            driver.FindElement(NewCustomerSurname).Click();
            Thread.Sleep(1000);
            Actions action = new Actions(driver);
            WebElement ele = (WebElement)driver.FindElement(NewCustomerSurname);
            action.Click(ele).Click(ele).Click(ele).Perform();
            driver.FindElement(NewCustomerSurname).SendKeys(Keys.Delete);
            driver.FindElement(NewCustomerSurname).SendKeys("AAA");
            //First name
            Thread.Sleep(2000);
            driver.FindElement(NewCustomerFirstName).Click();
            Thread.Sleep(1000);
            WebElement ele1 = (WebElement)driver.FindElement(NewCustomerFirstName);
            action.Click(ele1).Click(ele1).Click(ele1).Perform();
            driver.FindElement(NewCustomerFirstName).SendKeys(Keys.Delete);
            driver.FindElement(NewCustomerFirstName).SendKeys("AAA");
            //Email
            Thread.Sleep(2000);
            driver.FindElement(NewCustomerEmail).Click();
            Thread.Sleep(1000);
            WebElement ele2 = (WebElement)driver.FindElement(NewCustomerEmail);
            action.Click(ele2).Click(ele2).Click(ele2).Perform();
            driver.FindElement(NewCustomerEmail).SendKeys(Keys.Delete);
            driver.FindElement(NewCustomerEmail).SendKeys("Testing@tester.com");
            //Address
            driver.SwitchTo().Frame(driver.FindElement(By.Id("WebResource_WMDCCustomerAddressSearch")));
            Thread.Sleep(1000);
            driver.FindElement(NewCustomerAddress).Click();
            driver.FindElement(NewCustomerAddress).SendKeys("80 Spring Avenue Ashby-De-La-Zouch LE65 2RB");
            driver.FindElement(NewCustomerAddress).SendKeys(Keys.Enter);
            //Click can't find address link
            wait.Until(ExpectedConditions.ElementExists((By)CantFindAddressLink));
            driver.FindElement(CantFindAddressLink).Click();
            Thread.Sleep(2000);
            driver.SwitchTo().DefaultContent();
            //Click I understand on overlay
            wait.Until(ExpectedConditions.ElementExists((By)UnderstandBtnOnOverlay));
            driver.FindElement(UnderstandBtnOnOverlay).Click();
            Thread.Sleep(2000);
            //Enter address manually
            driver.SwitchTo().Frame(driver.FindElement(By.Id("WebResource_WMDCCustomerAddressSearch")));
            Thread.Sleep(1000);
            driver.FindElement(ManualAddressHouseNumber).Click();
            driver.FindElement(ManualAddressHouseNumber).SendKeys("80");
            Thread.Sleep(1000);
            driver.FindElement(ManualAddressStreetName).Click();
            driver.FindElement(ManualAddressStreetName).SendKeys("Spring Avenue");
            Thread.Sleep(1000);
            driver.FindElement(ManualAddressTown).Click();
            driver.FindElement(ManualAddressTown).SendKeys("Ashby-De-La-Zouch");
            Thread.Sleep(1000);
            driver.FindElement(ManualAddressPostcode).Click();
            driver.FindElement(ManualAddressPostcode).SendKeys("LE65 2RB");
            Thread.Sleep(1000);
            //Select out of area tickbox
            driver.FindElement(OutOfAreaTickbox).Click();
            Thread.Sleep(1000);
            //Click confirm button
            driver.FindElement(ConfirmManualAdressBtn).Click();
            Thread.Sleep(1000);
            driver.SwitchTo().DefaultContent();
            //Click save button
            driver.FindElement(NewCustomerSaveBtn).Click();
            Thread.Sleep(2000);
            //Duplicate record check
            try
            {
                if (driver.FindElement(DuplicateRecordOverlay).Displayed)
                {
                    Thread.Sleep(2000);
                    driver.FindElement(DuplicateRecordSelect).Click();
                    Thread.Sleep(2000);
                    driver.FindElement(DuplicateRecordMerge).Click();
                    Thread.Sleep(2000);
                    wait.Until(ExpectedConditions.ElementExists((By)MergeCustomersOverlay));
                    Thread.Sleep(2000);
                    driver.FindElement(MergeCustomersOverlayButton).Click();
                    Thread.Sleep(2000);
                    driver.FindElement(CustomersLHN).Click();
                    Thread.Sleep(2000);
                    driver.FindElement(NewCustomerOnList).Click();
                    Thread.Sleep(2000);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("No duplicates found");
            }
            //Click filter icon in header
            Thread.Sleep(2000);
            driver.FindElement(AdvancedFindFilter).Click();
            Thread.Sleep(15000);
            //Click look for dropdown
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            driver.SwitchTo().Frame(driver.FindElement(By.XPath("//iframe[@id='contentIFrame0']")));
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)FilterLookFor));
            driver.FindElement(FilterLookFor).Click();
            Thread.Sleep(2000);
            //Click addressable locations
            driver.FindElement(LookForOptionOnDropdown).Click();
            Thread.Sleep(2000);
            //Click results icon
            driver.SwitchTo().DefaultContent();
            driver.FindElement(ResultsIconOnLookForBanner).Click();
            Thread.Sleep(2000);
            //Sort created on column to newest first
            driver.SwitchTo().Frame(driver.FindElement(By.XPath("//iframe[@id='contentIFrame0']")));
            driver.SwitchTo().Frame("resultFrame");
            Thread.Sleep(5000);
            driver.FindElement(ResultsCreatedOnColumn).Click();
            Thread.Sleep(2000);
            driver.FindElement(ResultsCreatedOnColumn).Click();
            Thread.Sleep(2000);
            //Verify address just added is shown
            wait.Until(ExpectedConditions.ElementExists((By)ManualAddressOnAdvancedFind));
            Assert.IsTrue(driver.FindElement(ManualAddressOnAdvancedFind).Displayed);
            //Close pop up
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            Thread.Sleep(2000);
            driver.Close();
            //Click customers on LHN
            driver.SwitchTo().Window(driver.WindowHandles.First());
            driver.SwitchTo().DefaultContent();
            driver.FindElement(CustomersLHN).Click();
            wait.Until(ExpectedConditions.ElementExists((By)ActiveContactsList));
            Thread.Sleep(1000);
            Assert.IsTrue(driver.FindElement(ActiveContactsList).Displayed);
            Thread.Sleep((1000));
            driver.FindElement(NewCustomerOnList).Click();
            Thread.Sleep((2000));
            Assert.IsTrue(driver.FindElement(ExistingCustomerRecord).Displayed);
            //Delete customer
            driver.FindElement(ActiveContactsDelete).Click();
            wait.Until(ExpectedConditions.ElementExists((By)ActiveContactsDeleteOverlay));
            Thread.Sleep(1000);
            driver.FindElement(ActiveContactsDeleteOverlay).Click();
            Thread.Sleep((4000));
            //add verification that user is deleted
            wait.Until(ExpectedConditions.ElementExists((By)ActiveContactsList));
            Assert.IsTrue(driver.FindElement(ActiveContactsList).Displayed);
            Thread.Sleep((2000));
            //verify user not present
            var Customer = 0;
            try
            {

                WebElement customer = (WebElement)driver.FindElement(ExistingCustomerEmail2);
                if (customer.Displayed)
                {
                    Customer = 1;
                    Assert.Fail();
                }
            }
            catch (Exception)
            {
                if (Customer > 0)
                {
                    Console.WriteLine("User not removed");
                }
                else
                {
                    Console.WriteLine("User removed");
                }
            }

        }

        public void AddAddressManualCustomer()
        {
            //Verify Home dashboard is displayed
            Thread.Sleep(4000);
            driver.FindElement(DashboardsLHN).Click();
            Thread.Sleep(3000);
            wait.Until(ExpectedConditions.ElementExists((By)DashboardTitle));
            Assert.IsTrue(driver.FindElement(DashboardTitle).Displayed);
            Thread.Sleep(3000);
            //Switch to searchbox iframe
            driver.SwitchTo().Frame(driver.FindElement(By.Id("9532b1de-41a1-456c-b21c-805faca15573_WebResource_customeradvisorstart")));
            wait.Until(ExpectedConditions.ElementExists((By)Searchbox));
            Assert.IsTrue(driver.FindElement(Searchbox).Displayed);
            //Enter fullname in search
            driver.FindElement(Searchbox).Click();
            driver.FindElement(Searchbox).SendKeys("New User");
            driver.FindElement(Searchbox).SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            //Click create new customer
            wait.Until(ExpectedConditions.ElementExists((By)SearchDropdownCreateNew));
            Assert.IsTrue(driver.FindElement(SearchDropdownCreateNew).Displayed);
            driver.FindElement(SearchDropdownCreateNew).Click();
            Thread.Sleep(2000);
            driver.SwitchTo().DefaultContent();
            //Click yes on overlay
            wait.Until(ExpectedConditions.ElementExists((By)CreateCustomerOverlayYesBtn));
            driver.FindElement(CreateCustomerOverlayYesBtn).Click();
            Thread.Sleep(3000);
            //Verify new customer form is displayed
            wait.Until(ExpectedConditions.ElementExists((By)NewCustomerForm));
            Assert.IsTrue(driver.FindElement(NewCustomerForm).Displayed);
            //Fill mandatory fields
            //Surname
            driver.FindElement(NewCustomerSurname).Click();
            Thread.Sleep(1000);
            Actions action = new Actions(driver);
            WebElement ele = (WebElement)driver.FindElement(NewCustomerSurname);
            action.Click(ele).Click(ele).Click(ele).Perform();
            driver.FindElement(NewCustomerSurname).SendKeys(Keys.Delete);
            driver.FindElement(NewCustomerSurname).SendKeys("AAA");
            //First name
            Thread.Sleep(2000);
            driver.FindElement(NewCustomerFirstName).Click();
            Thread.Sleep(1000);
            WebElement ele1 = (WebElement)driver.FindElement(NewCustomerFirstName);
            action.Click(ele1).Click(ele1).Click(ele1).Perform();
            driver.FindElement(NewCustomerFirstName).SendKeys(Keys.Delete);
            driver.FindElement(NewCustomerFirstName).SendKeys("AAA");
            //Email
            Thread.Sleep(2000);
            driver.FindElement(NewCustomerEmail).Click();
            Thread.Sleep(1000);
            WebElement ele2 = (WebElement)driver.FindElement(NewCustomerEmail);
            action.Click(ele2).Click(ele2).Click(ele2).Perform();
            driver.FindElement(NewCustomerEmail).SendKeys(Keys.Delete);
            driver.FindElement(NewCustomerEmail).SendKeys("Testing@testing.com");
            //Address
            driver.SwitchTo().Frame(driver.FindElement(By.Id("WebResource_WMDCCustomerAddressSearch")));
            Thread.Sleep(1000);
            driver.FindElement(NewCustomerAddress).Click();
            driver.FindElement(NewCustomerAddress).SendKeys("80 Spring Avenue Ashby-De-La-Zouch LE65 2RB");
            driver.FindElement(NewCustomerAddress).SendKeys(Keys.Enter);
            //Click can't find address link
            wait.Until(ExpectedConditions.ElementExists((By)CantFindAddressLink));
            driver.FindElement(CantFindAddressLink).Click();
            Thread.Sleep(2000);
            driver.SwitchTo().DefaultContent();
            //Click I understand on overlay
            wait.Until(ExpectedConditions.ElementExists((By)UnderstandBtnOnOverlay));
            driver.FindElement(UnderstandBtnOnOverlay).Click();
            Thread.Sleep(2000);
            //Try to add address without postcode
            driver.SwitchTo().Frame(driver.FindElement(By.Id("WebResource_WMDCCustomerAddressSearch")));
            Thread.Sleep(1000);
            driver.FindElement(ManualAddressHouseNumber).Click();
            driver.FindElement(ManualAddressHouseNumber).SendKeys("80");
            Thread.Sleep(1000);
            driver.FindElement(ManualAddressStreetName).Click();
            driver.FindElement(ManualAddressStreetName).SendKeys("Spring Avenue");
            Thread.Sleep(1000);
            driver.FindElement(ManualAddressTown).Click();
            driver.FindElement(ManualAddressTown).SendKeys("Ashby-De-La-Zouch");
            Thread.Sleep(1000);
            //Select out of area tickbox
            driver.FindElement(OutOfAreaTickbox).Click();
            Thread.Sleep(1000);
            //Click confirm button
            driver.FindElement(ConfirmManualAdressBtn).Click();
            Thread.Sleep(1000);
            //Verify green selected address banner is not displayed
            Thread.Sleep(2000);
            try
            {
                Assert.IsTrue(driver.FindElement(SelectedAddressBanner).Displayed);
                Console.WriteLine("Selected address banner was shown");
                Assert.Fail();
            }
            catch
            {
                Console.WriteLine("Selected address banner was not displayed");
            }
            //Enter invalid postcode
            Thread.Sleep(2000);
            driver.FindElement(ManualAddressPostcode).Click();
            driver.FindElement(ManualAddressPostcode).SendKeys("LE65 2CC");
            Thread.Sleep(1000);
            driver.FindElement(ConfirmManualAdressBtn).Click();
            //Verify error message is shown
            driver.SwitchTo().DefaultContent();
            Thread.Sleep(1000);
            wait.Until(ExpectedConditions.ElementExists((By)InvalidPostcodeMessage));
            Assert.IsTrue(driver.FindElement(InvalidPostcodeMessage).Displayed);
            //Click ok
            driver.FindElement(InvalidPostcodeMessageOK).Click();
            Thread.Sleep(1000);
            //Enter Valid postcode
            driver.SwitchTo().Frame(driver.FindElement(By.Id("WebResource_WMDCCustomerAddressSearch")));
            WebElement ele3 = (WebElement)driver.FindElement(ManualAddressPostcode);
            action.Click(ele3).Click(ele3).Click(ele3).Perform();
            driver.FindElement(ManualAddressPostcode).SendKeys(Keys.Delete);
            driver.FindElement(ManualAddressPostcode).SendKeys("LE65 2RB");
            Thread.Sleep(1000);
            //Select out of area tickbox
            driver.FindElement(OutOfAreaTickbox).Click();
            Thread.Sleep(1000);
            //Click confirm button
            driver.FindElement(ConfirmManualAdressBtn).Click();
            Thread.Sleep(1000);
            driver.SwitchTo().DefaultContent();
            //Click save button
            driver.FindElement(NewCustomerSaveBtn).Click();
            Thread.Sleep(2000);
            //Duplicate record check
            try
            {
                if (driver.FindElement(DuplicateRecordOverlay).Displayed)
                {
                    Thread.Sleep(2000);
                    driver.FindElement(DuplicateRecordSelect).Click();
                    Thread.Sleep(2000);
                    driver.FindElement(DuplicateRecordMerge).Click();
                    Thread.Sleep(2000);
                    wait.Until(ExpectedConditions.ElementExists((By)MergeCustomersOverlay));
                    Thread.Sleep(2000);
                    driver.FindElement(MergeCustomersOverlayButton).Click();
                    Thread.Sleep(2000);
                    driver.FindElement(CustomersLHN).Click();
                    Thread.Sleep(2000);
                    driver.FindElement(NewCustomerOnList).Click();
                    Thread.Sleep(2000);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("No duplicates found");
            }
            //Click filter icon in header
            Thread.Sleep(2000);
            driver.FindElement(AdvancedFindFilter).Click();
            Thread.Sleep(15000);
            //Click look for dropdown
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            driver.SwitchTo().Frame(driver.FindElement(By.XPath("//iframe[@id='contentIFrame0']")));
            Thread.Sleep(4000);
            wait.Until(ExpectedConditions.ElementExists((By)FilterLookFor));
            driver.FindElement(FilterLookFor).Click();
            Thread.Sleep(2000);
            //Click addressable locations
            driver.FindElement(LookForOptionOnDropdown).Click();
            Thread.Sleep(2000);
            //Click results icon
            driver.SwitchTo().DefaultContent();
            driver.FindElement(ResultsIconOnLookForBanner).Click();
            Thread.Sleep(2000);
            //Sort created on column to newest first
            driver.SwitchTo().Frame(driver.FindElement(By.XPath("//iframe[@id='contentIFrame0']")));
            driver.SwitchTo().Frame("resultFrame");
            Thread.Sleep(5000);
            driver.FindElement(ResultsCreatedOnColumn).Click();
            Thread.Sleep(2000);
            driver.FindElement(ResultsCreatedOnColumn).Click();
            Thread.Sleep(2000);
            //Verify address just added is shown
            wait.Until(ExpectedConditions.ElementExists((By)ManualAddressOnAdvancedFind));
            Assert.IsTrue(driver.FindElement(ManualAddressOnAdvancedFind).Displayed);
            //Close pop up
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            Thread.Sleep(2000);
            driver.Close();
            //Click customers on LHN
            driver.SwitchTo().Window(driver.WindowHandles.First());
            driver.SwitchTo().DefaultContent();
            driver.FindElement(CustomersLHN).Click();
            wait.Until(ExpectedConditions.ElementExists((By)ActiveContactsList));
            Thread.Sleep(1000);
            Assert.IsTrue(driver.FindElement(ActiveContactsList).Displayed);
            Thread.Sleep((1000));
            driver.FindElement(NewCustomerOnList).Click();
            Thread.Sleep((2000));
            Assert.IsTrue(driver.FindElement(ExistingCustomerRecord).Displayed);
            //Delete customer
            driver.FindElement(ActiveContactsDelete).Click();
            wait.Until(ExpectedConditions.ElementExists((By)ActiveContactsDeleteOverlay));
            Thread.Sleep(1000);
            driver.FindElement(ActiveContactsDeleteOverlay).Click();
            Thread.Sleep((4000));
            //add verification that user is deleted
            wait.Until(ExpectedConditions.ElementExists((By)ActiveContactsList));
            Assert.IsTrue(driver.FindElement(ActiveContactsList).Displayed);
            Thread.Sleep((2000));
            //verify user not present
            var Customer = 0;
            try
            {

                WebElement customer = (WebElement)driver.FindElement(ExistingCustomerEmail1);
                if (customer.Displayed)
                {
                    Customer = 1;
                    Assert.Fail();
                }
            }
            catch (Exception)
            {
                if (Customer > 0)
                {
                    Console.WriteLine("User not removed");
                }
                else
                {
                    Console.WriteLine("User removed");
                }
            }

        }

        public void StartNewCustomer()
        {
            //Select customers on LHN
            Thread.Sleep(4000);
            wait.Until(ExpectedConditions.ElementExists((By)CustomersLHN));
            Thread.Sleep(4000);
            driver.FindElement(CustomersLHN).Click();
            Thread.Sleep(4000);
            //Verify active contacts list is displayed
            wait.Until(ExpectedConditions.ElementExists((By)ActiveContactsList));
            Thread.Sleep(4000);
            Assert.IsTrue(driver.FindElement(ActiveContactsList).Displayed);
            Thread.Sleep(4000);
            //Click new customer button
            driver.FindElement(NewCustomerButton).Click();
            //Verify new customer form is displayed
            wait.Until(ExpectedConditions.ElementExists((By)NewCustomerForm));
            Assert.IsTrue(driver.FindElement(NewCustomerForm).Displayed);
            Thread.Sleep(2000);
            //First name
            Thread.Sleep(2000);
            driver.FindElement(NewCustomerFirstName).Click();
            Thread.Sleep(1000);
            WebElement ele1 = (WebElement)driver.FindElement(NewCustomerFirstName);
            Actions action = new Actions(driver);
            action.Click(ele1).Click(ele1).Click(ele1).Perform();
            driver.FindElement(NewCustomerFirstName).SendKeys(Keys.Delete);
            driver.FindElement(NewCustomerFirstName).SendKeys("New");
            //Surname
            driver.FindElement(NewCustomerSurname).Click();
            Thread.Sleep(1000);
            WebElement ele = (WebElement)driver.FindElement(NewCustomerSurname);
            action.Click(ele).Click(ele).Click(ele).Perform();
            driver.FindElement(NewCustomerSurname).SendKeys(Keys.Delete);
            driver.FindElement(NewCustomerSurname).SendKeys("User");
            //Address
            driver.SwitchTo().Frame(driver.FindElement(By.Id("WebResource_WMDCCustomerAddressSearch")));
            driver.FindElement(NewCustomerAddress).Click();
            driver.FindElement(NewCustomerAddress).SendKeys("4 Sandhill Rise Pontefract WF8 1RA");
            driver.FindElement(NewCustomerAddress).SendKeys(Keys.Enter);
            wait.Until(ExpectedConditions.ElementExists((By)NewCustomerAddressDropdown));
            driver.FindElement(NewCustomerAddressDropdown).Click();
            driver.SwitchTo().DefaultContent();
            Thread.Sleep(4000);
            //Click start new button
            driver.SwitchTo().Frame(driver.FindElement(By.Id("WebResource_continuewithcustomer")));
            wait.Until(ExpectedConditions.ElementExists((By)StartNewBtn));
            driver.FindElement(StartNewBtn).Click();
            Thread.Sleep(5000);
            //Click leave on overlay
            driver.SwitchTo().Alert().Accept(); 
            Thread.Sleep(4000);
            //Verify Home dashboard is displayed
            Thread.Sleep(4000);
            wait.Until(ExpectedConditions.ElementExists((By)DashboardTitle));
            Assert.IsTrue(driver.FindElement(DashboardTitle).Displayed);
            Thread.Sleep(3000);
            //Verify user not shown
            driver.SwitchTo().Frame(driver.FindElement(By.Id("9532b1de-41a1-456c-b21c-805faca15573_WebResource_customeradvisorstart")));
            var Customer = 0;
            try
            {

                WebElement customer = (WebElement)driver.FindElement(ChosenCustomerOnDashboard);
                if (customer.Displayed)
                {
                    Customer = 1;
                    Assert.Fail();
                }
            }
            catch (Exception)
            {
                if (Customer > 0)
                {
                    Console.WriteLine("User added incorrectly");
                }
                else
                {
                    Console.WriteLine("User not added");
                }
            }
        }
    }
}
