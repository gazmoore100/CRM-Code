using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace CRMRegressionPack.PageObjects
{
    public class ClientMenu
    {
        //Customer elements
        By CustomersLHN = By.CssSelector("[Aria-label='Clients']");
        By ActiveContactsList = By.XPath("//span[contains(text(),'Active Contacts')]");
        By NewCustomerButton = By.XPath("//span[contains(text(),'New')]");
        By NewCustomerForm = By.XPath("//h1[contains(text(),'New Customer')]");
        By NewCustomerFirstName = By.CssSelector("[aria-label='First Name']");
        By AnonCustomerFirstName = By.XPath("//input[@value='ANONYMOUS']");
        By NewCustomerSurname = By.CssSelector("[Aria-label='Surname']");
        By AnonCustomerSurname = By.XPath("//input[@value='CUSTOMER']");
        By NewCustomerMobile = By.CssSelector("[aria-label='Mobile Phone']");
        By NewCustomerAddress = By.XPath("//input[@placeholder='Search for an address']");
        By AnonCustomerAddressField = By.CssSelector("[data-id='wmdc_addressid-locked-icon']");
        By NewCustomerAddressDropdown = By.XPath("//body//option[3]");
        By AddressSearchBoxResult = By.XPath("//option[contains(text(),'6 Sandhill Rise Pontefract WF8 1RA')]");
        By AddressSearchBoxResult2 = By.XPath("//option[contains(text(),'8 Sandhill Rise Pontefract WF8 1RA')]");
        By AddressSearchBoxResult3 = By.XPath("//option[contains(text(),'9 Sandhill Rise Pontefract WF8 1RA')]");

        By NewCustomerEmailAddress = By.XPath("//input[@placeholder='Provide an email']");
        By ExistingCustomerTitle = By.XPath("//h1[@title='AAA AAA']");
        By DeactivatedCustomerTitle = By.XPath("//h1[@title='2222 2222']");
        By ProfileDeactivate = By.XPath("//span[@aria-hidden='true']//span[contains(text(),'Deactivate')]");
        By ProfileDeactivateConfirm = By.XPath("//div[@data-id='dialogFooter']//span[contains(text(),'Deactivate')]");
        By NewCustomerButtonOnProfile = By.XPath("//span[contains(text(),'New')]");

        By NewCustomerGeneralInfo = By.XPath("//li[contains(text(),'General Information')]");
        By NewCustomerTimelineTitle = By.XPath("//h3[contains(text(),'Timeline')]");
        By CustomerTimelineAddNote = By.XPath("//span[contains(text(),'Enter a note...')]");
        By CustomerAddNoteSubHeading = By.XPath("//h4[contains(text(),'Create a note')]");
        By CustomerNoteTitle = By.XPath("//input[@placeholder='Title']");
        By CustomerNoteBody = By.XPath("/html[1]/body[1]/div[1]");
        By AddNoteButton = By.XPath("//button[contains(text(),'Add note')]");
        By NewTimelineNoteAdded = By.XPath("//li[1]//div[1]//div[2]//div[2]//div[1]//div[1]");
        By NewTimelineNoteDelete = By.XPath("//button[@title='Delete note']//span");
        By NewTimelineNoteOverlayDelete = By.XPath("//span[contains(text(),'OK')]");
        By CustomerTimelineSearchBox = By.XPath("//input[@placeholder='Search timeline']");
        By CustomerTimelineFilter = By.XPath("//span[contains(@class,'symbolFont GlobalFilter-symbol')]");
        By CustomerTimelineFilterOptions = By.XPath("//div[.='Record type']");
        By CustomerTimelineFilterNote = By.XPath("//span[contains(text(),'Notes (1)')]");
        By CustomerTimelineFilterPost = By.XPath("//label[contains(text(),'Auto-post on')]");
        By CustomerTimelineMoreCommands = By.CssSelector("[aria-label='More commands']");
        By CustomerTimelineSortBy = By.XPath("//li[.='Sort older to newer']");
        By DuplicateRecordOverlayCancel = By.XPath("//span[normalize-space()='Cancel']");

        By DuplicateRecordOverlay = By.CssSelector("[aria-label='Duplicate records found']");
        By DuplicateRecordSelect = By.XPath("//section//section//section//section//div//div//div//div//div[2]//div[4]");
        By DuplicateRecordMerge = By.XPath("//button[.='Merge']");
        By MergeCustomersOverlay = By.XPath("//h1[.='Merge Customers']");
        By MergeBusinessOverlay = By.XPath("//h1[contains(text(),'Merge Businesses')]");
        By MergeCustomersOverlayButton = By.XPath("//span[.='OK']");
        By ExistingCustomerRecord = By.XPath("//html//body//div//div//div//div//div//div//div//div//div//div//div//div//div//div//div//div//span[contains(text(),'Customer')]");
        By ExistingCustomerEmail = By.XPath("//span[contains(text(),'Test@test.com')]");
        By ExistingCustomerOnList = By.XPath("//span[contains(text(),'AAA AAA')]");
        By DeactivateCustomerOnList = By.XPath("//span[contains(text(),'2222 2222')]");
        By NewCustomerSave = By.XPath("//span[text()='Save']");
        By NewCustomerSaveandClose = By.XPath("//span[contains(text(),'Save & Close')]");
        By NewCustomerOnList = By.XPath("//span[contains(text(),'1111 1111')]");
        By AnonCustomerOnList = By.XPath("//span[contains(text(),'ANONYMOUS CUSTOMER')]");
        By DontDeleteCustomerOnList = By.XPath("//span[.='dont delete']");
        By CustomerInfoHeader = By.XPath("//h2[contains(text(),'CUSTOMER INFORMATION')]");
        By ActiveContactsDelete = By.XPath("//button[.='Delete']");
        By ActiveContactsDeleteOverlay = By.XPath("//body/section/div/div/div/div/div/div/div/button[1]");

        //Business elements
        By BusinessesLHN = By.CssSelector("[Aria-label='Businesses']");
        By ActiveAccountsList = By.XPath("//span[contains(text(),'Active Accounts')]");
        By NewBusinessButton = By.XPath("//span[contains(text(),'New')]");
        By NewBusinessForm = By.XPath("//h1[contains(text(),'New Business')]");
        By NewBusinessName = By.CssSelector("[Aria-label='Business Name']");
        By NewBusinessPhone = By.CssSelector("[placeholder='Provide a telephone number']");
        By NewBusinessAddress = By.XPath("//input[@placeholder='Search for an address']");
        By NewBusinessAddressDropdown = By.XPath("//body//option[3]");
        By NewBusinessSaveandClose = By.XPath("//span[contains(text(),'Save & Close')]");
        By BusinessInfoHeader = By.XPath("//h2[contains(text(),'BUSINESS INFORMATION')]");

        By NewBusinessOnList = By.XPath("//span[contains(text(),'1111')]");
        By SearchBoxOnActiveContacts = By.XPath("//input[@placeholder='Filter by keyword']");
        By ActiveBusinessesDelete = By.XPath("//button[.='Delete']");
        By ActiveBusinessesDeleteOverlay = By.XPath("//html//body//section//div//div//div//div//div//div//div//button//span[contains(text(),'Delete')]");

        By HistoryTabOnProfile = By.XPath("//li[.='HistoryHistory']");
        By PreviousAddressOnHistory = By.XPath("//h2[.='PREVIOUS ADDRESS HISTORY']");
        By CustomerCasesOnHistory = By.XPath("//h2[.='CUSTOMERS CASES']");
        By CasesBySomeoneElseOnHistory = By.XPath("//h2[.='CASES REPORTED BY CUSTOMER FOR SOMEBODY ELSE']");
        By CaseTitle = By.XPath("(//label[@title='Case Title'])[1]");
        By ReportedAddressLocation = By.XPath("//label[@title='Reported Address Location']");
        By CaseNumber = By.XPath("(//label[text()='Case Number'])[1]");
        By Customer = By.XPath("(//label[text()='Customer'])[1]");
        By Origin = By.XPath("(//label[text()='Origin'])[1]");
        By StatusReason = By.XPath("(//label[text()='Status Reason'])[1]");
        By CreatedOn = By.XPath("(//label[text()='Created On'])[2]");
        By SLATarget = By.XPath("(//label[text()='SLA Target Date'])[1]");
        By ReportedBy = By.XPath("(//label[text()='Reported By'])[1]");
        By ReportedByBusiness = By.XPath("(//label[@title='Reported By (Business)'])[1]");

        By SomeoneElseCaseTitle = By.XPath("(//label[text()='Case Title'])[2]");
        By SomeoneElseCaseNumber = By.XPath("(//label[text()='Case Number'])[2]");
        By SomeoneElseCustomer = By.XPath("(//label[text()='Customer'])[2]");
        By SomeoneElseOrigin = By.XPath("(//label[text()='Origin'])[2]");
        By SomeoneElseStatusReason = By.XPath("(//label[text()='Status Reason'])[2]");
        By SomeoneElseCreatedOn = By.XPath("(//label[text()='Created On'])[3]");
        By SomeoneElseSLATarget = By.XPath("(//label[text()='SLA Target Date'])[2]");
        By SomeoneElseReportedBy = By.XPath("(//label[text()='Reported By'])[2]");
        By SomeoneElseReportedByBusiness = By.XPath("(//label[@title='Reported By (Business)'])[2]");

        By AdditionalAlertInfo = By.XPath("//textarea[@aria-label='Additional Alert Information']");
        By GeneralInfoAlerts = By.XPath("//h2[normalize-space()='ALERTS']");
        By AddExistingAlertType = By.XPath("//span[contains(text(),'Add Existing Entity Alert Type')]");
        By LookForAlerts = By.XPath("//input[@placeholder='Look for records']");
        By BlindAlertOnList = By.XPath("//span[normalize-space()='Blind']");
        By AddBtnOnAlertsList = By.XPath("//button[@aria-label='Add']");
        By BlindAlertAddedToProfile = By.XPath("//label[@aria-label='B']");
        By MoreOptionsBtn = By.XPath("//button[@title='More commands for Entity Alert Type']");
        By DeleteAlert = By.XPath("//span[text()='Remove']");

        [ThreadStatic]
        IWebDriver driver;
        WebDriverWait wait;

        public ClientMenu(IWebDriver driver)
        {
            this.driver = driver;
            this.wait = new WebDriverWait(driver, TimeSpan.FromSeconds(120));
        }

        public void EditCustomerDetails()
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
            //Fill mandatory fields
            //Surname
            driver.FindElement(NewCustomerSurname).Click();
            Thread.Sleep(1000);
            Actions action = new Actions(driver);
            WebElement ele = (WebElement)driver.FindElement(NewCustomerSurname);
            action.Click(ele).Click(ele).Click(ele).Perform();
            driver.FindElement(NewCustomerSurname).SendKeys(Keys.Delete);
            driver.FindElement(NewCustomerSurname).SendKeys("AAA");
            //Address
            driver.SwitchTo().Frame(driver.FindElement(By.Id("WebResource_WMDCCustomerAddressSearch")));
            Thread.Sleep(1000);
            driver.FindElement(NewCustomerAddress).Click();
            driver.FindElement(NewCustomerAddress).SendKeys("pontefract");
            driver.FindElement(NewCustomerAddress).SendKeys(Keys.Enter);
            wait.Until(ExpectedConditions.ElementExists((By)NewCustomerAddressDropdown));
            driver.FindElement(NewCustomerAddressDropdown).Click();
            driver.SwitchTo().DefaultContent();
            //Fill non mandatory fields
            //First name
            driver.FindElement(NewCustomerFirstName).Click();
            Thread.Sleep(1000);
            WebElement ele1 = (WebElement)driver.FindElement(NewCustomerFirstName);
            action.Click(ele1).Click(ele1).Click(ele1).Perform();
            driver.FindElement(NewCustomerFirstName).SendKeys(Keys.Delete);
            driver.FindElement(NewCustomerFirstName).SendKeys("AAA");
            //Mobile number
            driver.FindElement(NewCustomerMobile).Click();
            Thread.Sleep(1000);
            driver.FindElement(NewCustomerMobile).Clear();
            driver.FindElement(NewCustomerMobile).SendKeys("07777777777");
            //Save and close
            driver.FindElement(NewCustomerSaveandClose).Click();
            Thread.Sleep(3000);
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
            Thread.Sleep((2000));
            //Edit user details
            driver.FindElement(ExistingCustomerOnList).Click();
            Thread.Sleep((2000));
            wait.Until(ExpectedConditions.ElementExists((By)CustomerInfoHeader));
            Assert.IsTrue(driver.FindElement(CustomerInfoHeader).Displayed);
            //First name
            driver.FindElement(NewCustomerFirstName).Click();
            Thread.Sleep(1000);
            WebElement ele2 = (WebElement)driver.FindElement(NewCustomerFirstName);
            action.Click(ele2).Click(ele2).Click(ele2).Perform();
            driver.FindElement(NewCustomerFirstName).SendKeys(Keys.Delete);
            driver.FindElement(NewCustomerFirstName).SendKeys("1111");
            //Surname
            driver.FindElement(NewCustomerSurname).Click();
            Thread.Sleep(1000);
            WebElement ele3 = (WebElement)driver.FindElement(NewCustomerSurname);
            action.Click(ele3).Click(ele3).Click(ele3).Perform();
            driver.FindElement(NewCustomerSurname).SendKeys(Keys.Delete);
            driver.FindElement(NewCustomerSurname).SendKeys("1111");
            //Save and close
            driver.FindElement(NewCustomerSaveandClose).Click();
            Thread.Sleep(3000);
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
            Thread.Sleep((2000));
            wait.Until(ExpectedConditions.ElementExists((By)NewCustomerOnList));
            Thread.Sleep(1000);
            Assert.IsTrue(driver.FindElement(NewCustomerOnList).Displayed);
            //Delete customer
            driver.FindElement(NewCustomerOnList).Click();
            Thread.Sleep(2000);
            driver.FindElement(ActiveContactsDelete).Click();
            wait.Until(ExpectedConditions.ElementExists((By)ActiveContactsDeleteOverlay));
            Thread.Sleep(1000);
            driver.FindElement(ActiveContactsDeleteOverlay).Click();
            Thread.Sleep((2000));
            //add verification that user is deleted
            wait.Until(ExpectedConditions.ElementExists((By)ActiveContactsList));
            Assert.IsTrue(driver.FindElement(ActiveContactsList).Displayed);
            Thread.Sleep((2000));
            //verify user not present
            var Customer = 0;
            try
            {

                WebElement customer = (WebElement)driver.FindElement(NewCustomerOnList);
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

        public void EditBusinessDetails()
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
            driver.FindElement(NewBusinessButton).Click();
            wait.Until(ExpectedConditions.ElementExists((By)NewBusinessForm));
            Thread.Sleep(4000);
            Assert.IsTrue(driver.FindElement(NewBusinessForm).Displayed);
            //Fill mandatory and non fields
            driver.FindElement(NewBusinessName).Click();
            Thread.Sleep(1000);
            Actions action = new Actions(driver);
            WebElement ele = (WebElement)driver.FindElement(NewBusinessName);
            action.Click(ele).Click(ele).Click(ele).Perform();
            driver.FindElement(NewBusinessName).SendKeys(Keys.Delete);
            driver.FindElement(NewBusinessName).SendKeys("1111");
            Thread.Sleep(1000);
            //Phone number
            driver.FindElement(NewBusinessPhone).Click();
            Thread.Sleep(1000);
            driver.FindElement(NewBusinessPhone).Clear();
            driver.FindElement(NewBusinessPhone).SendKeys("07777777777");
            Thread.Sleep(1000);
            //Address
            driver.SwitchTo().Frame(driver.FindElement(By.Id("WebResource_WMDCCustomerAddressSearch")));
            Thread.Sleep(1000);
            driver.FindElement(NewBusinessAddress).Click();
            driver.FindElement(NewBusinessAddress).SendKeys("pontefract");
            driver.FindElement(NewBusinessAddress).SendKeys(Keys.Enter);
            wait.Until(ExpectedConditions.ElementExists((By)NewBusinessAddressDropdown));
            driver.FindElement(NewBusinessAddressDropdown).Click();
            driver.SwitchTo().DefaultContent();
            //Save and close
            driver.FindElement(NewBusinessSaveandClose).Click();
            Thread.Sleep(3000);
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
                    wait.Until(ExpectedConditions.ElementExists((By)MergeBusinessOverlay));
                    Thread.Sleep(2000);
                    driver.FindElement(MergeCustomersOverlayButton).Click();
                    Thread.Sleep(2000);
                    driver.FindElement(BusinessesLHN).Click();
                    Thread.Sleep(2000);
                }
            }
            catch (Exception)
            {
                if (driver.FindElement(ActiveAccountsList).Displayed)
                {
                    Console.WriteLine("No duplicates found");
                }
            }
            wait.Until(ExpectedConditions.ElementExists((By)ActiveAccountsList));
            Thread.Sleep(1000);
            Assert.IsTrue(driver.FindElement(ActiveAccountsList).Displayed);
            //Edit user details
            driver.FindElement(NewBusinessOnList).Click();
            Thread.Sleep((2000));
            wait.Until(ExpectedConditions.ElementExists((By)BusinessInfoHeader));
            Assert.IsTrue(driver.FindElement(BusinessInfoHeader).Displayed);
            Thread.Sleep((2000));
            //Business name
            driver.FindElement(NewBusinessName).Click();
            Thread.Sleep(1000);
            WebElement ele1 = (WebElement)driver.FindElement(NewBusinessName);
            action.Click(ele1).Click(ele1).Click(ele1).Perform();
            driver.FindElement(NewBusinessName).SendKeys(Keys.Delete);
            driver.FindElement(NewBusinessName).SendKeys("1111");
            Thread.Sleep(1000);
            //Phone number
            driver.FindElement(NewBusinessPhone).Click();
            Thread.Sleep(1000);
            WebElement ele2 = (WebElement)driver.FindElement(NewBusinessPhone);
            action.Click(ele2).Click(ele2).Click(ele2).Perform();
            driver.FindElement(NewBusinessPhone).SendKeys(Keys.Delete);
            driver.FindElement(NewBusinessPhone).SendKeys("0888888888");
            Thread.Sleep(1000);
            //Save and close
            driver.FindElement(NewBusinessSaveandClose).Click();
            Thread.Sleep(3000);
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
                    wait.Until(ExpectedConditions.ElementExists((By)MergeBusinessOverlay));
                    Thread.Sleep(2000);
                    driver.FindElement(MergeCustomersOverlayButton).Click();
                    Thread.Sleep(2000);
                    driver.FindElement(BusinessesLHN).Click();
                    Thread.Sleep(2000);
                }
            }
            catch (Exception)
            {
                if (driver.FindElement(ActiveAccountsList).Displayed)
                {
                    Console.WriteLine("No duplicates found");
                }
            }
            wait.Until(ExpectedConditions.ElementExists((By)ActiveAccountsList));
            Thread.Sleep(3000);
            Assert.IsTrue(driver.FindElement(NewBusinessOnList).Displayed);
            //Delete customer
            driver.FindElement(NewBusinessOnList).Click();
            Thread.Sleep(3000);
            driver.FindElement(ActiveBusinessesDelete).Click();
            wait.Until(ExpectedConditions.ElementExists((By)ActiveBusinessesDeleteOverlay));
            Thread.Sleep(1000);
            driver.FindElement(ActiveBusinessesDeleteOverlay).Click();
            Thread.Sleep((2000));
            //add verification that user is deleted
            wait.Until(ExpectedConditions.ElementExists((By)ActiveAccountsList));
            Assert.IsTrue(driver.FindElement(ActiveAccountsList).Displayed);
            Thread.Sleep((2000));
            var Business = 0;
            try
            {

                WebElement business = (WebElement)driver.FindElement(NewBusinessOnList);
                if (business.Displayed)
                {
                    Business = 1;
                    Assert.Fail();
                }
            }
            catch (Exception)
            {
                if (Business > 0)
                {
                    Console.WriteLine("Business not removed");
                }
                else
                {
                    Console.WriteLine("Business removed");
                }
            }
        }

        public void SearchCustomerOnActiveContactsList()
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
            //Create new customer
            driver.FindElement(NewCustomerButton).Click();
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
            driver.FindElement(NewCustomerSurname).SendKeys("1111");
            //Address
            driver.SwitchTo().Frame(driver.FindElement(By.Id("WebResource_WMDCCustomerAddressSearch")));
            Thread.Sleep(1000);
            driver.FindElement(NewCustomerAddress).Click();
            driver.FindElement(NewCustomerAddress).SendKeys("pontefract");
            driver.FindElement(NewCustomerAddress).SendKeys(Keys.Enter);
            wait.Until(ExpectedConditions.ElementExists((By)NewCustomerAddressDropdown));
            driver.FindElement(NewCustomerAddressDropdown).Click();
            driver.SwitchTo().DefaultContent();
            //Fill non mandatory fields
            //First name
            driver.FindElement(NewCustomerFirstName).Click();
            Thread.Sleep(1000);
            WebElement ele1 = (WebElement)driver.FindElement(NewCustomerFirstName);
            action.Click(ele1).Click(ele1).Click(ele1).Perform();
            driver.FindElement(NewCustomerFirstName).SendKeys(Keys.Delete);
            driver.FindElement(NewCustomerFirstName).SendKeys("1111");
            //Mobile number
            driver.FindElement(NewCustomerMobile).Click();
            Thread.Sleep(1000);
            WebElement ele2 = (WebElement)driver.FindElement(NewCustomerMobile);
            action.Click(ele2).Click(ele2).Click(ele2).Perform();
            driver.FindElement(NewCustomerMobile).SendKeys(Keys.Delete);
            driver.FindElement(NewCustomerMobile).SendKeys("07777777777");
            //Save and close
            driver.FindElement(NewCustomerSaveandClose).Click();
            Thread.Sleep(3000);
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
            Thread.Sleep((2000));
            //Enter search term in search box
            driver.FindElement(SearchBoxOnActiveContacts).Click();
            Thread.Sleep((2000));
            driver.FindElement(SearchBoxOnActiveContacts).SendKeys("1111");
            Thread.Sleep((1000));
            driver.FindElement(SearchBoxOnActiveContacts).SendKeys(Keys.Enter);
            Thread.Sleep((2000));
            //Verify user shows on active contacts list
            wait.Until(ExpectedConditions.ElementExists((By)NewCustomerOnList));
            Thread.Sleep((1000));
            Assert.IsTrue(driver.FindElement(NewCustomerOnList).Displayed);
            //Delete customer
            driver.FindElement(NewCustomerOnList).Click();
            Thread.Sleep(2000);
            driver.FindElement(ActiveContactsDelete).Click();
            wait.Until(ExpectedConditions.ElementExists((By)ActiveContactsDeleteOverlay));
            Thread.Sleep(1000);
            driver.FindElement(ActiveContactsDeleteOverlay).Click();
            Thread.Sleep((2000));
            //add verification that user is deleted
            wait.Until(ExpectedConditions.ElementExists((By)ActiveContactsList));
            Assert.IsTrue(driver.FindElement(ActiveContactsList).Displayed);
            Thread.Sleep((2000));
            //verify user not present
            var Customer = 0;
            try
            {

                WebElement customer = (WebElement)driver.FindElement(NewCustomerOnList);
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

        public void EditAnonCustomer()
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
            //Search for anonymous customer
            driver.FindElement(SearchBoxOnActiveContacts).Click();
            Thread.Sleep((2000));
            driver.FindElement(SearchBoxOnActiveContacts).SendKeys("Anonymous Customer");
            Thread.Sleep((1000));
            driver.FindElement(SearchBoxOnActiveContacts).SendKeys(Keys.Enter);
            Thread.Sleep((2000));
            //Verify user shows on active contacts list
            wait.Until(ExpectedConditions.ElementExists((By)AnonCustomerOnList));
            Thread.Sleep((1000));
            Assert.IsTrue(driver.FindElement(AnonCustomerOnList).Displayed);
            driver.FindElement(AnonCustomerOnList).Click();
            wait.Until(ExpectedConditions.ElementExists((By)CustomerInfoHeader));
            //Try to edit first name
            driver.FindElement(NewCustomerFirstName).Click();
            Thread.Sleep((2000));
            driver.FindElement(NewCustomerFirstName).SendKeys("NewName");
            Thread.Sleep((2000));
            Assert.IsTrue(driver.FindElement(AnonCustomerFirstName).Displayed);
            //Try to edit surname
            driver.FindElement(NewCustomerSurname).Click();
            Thread.Sleep((2000));
            driver.FindElement(NewCustomerSurname).SendKeys("NewName");
            Thread.Sleep((2000));
            Assert.IsTrue(driver.FindElement(AnonCustomerSurname).Displayed);
            //Verify address field locked
            wait.Until(ExpectedConditions.ElementExists((By)AnonCustomerAddressField));
            Assert.IsTrue(driver.FindElement(AnonCustomerAddressField).Displayed);

        }

        public void SearchBusinessOnActiveContactsList()
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
            //Create new business
            driver.FindElement(NewBusinessButton).Click();
            wait.Until(ExpectedConditions.ElementExists((By)NewBusinessForm));
            Thread.Sleep(1000);
            Assert.IsTrue(driver.FindElement(NewBusinessForm).Displayed);
            //Fill mandatory and non fields
            driver.FindElement(NewBusinessName).Click();
            Thread.Sleep(1000);
            Actions action = new Actions(driver);
            WebElement ele = (WebElement)driver.FindElement(NewBusinessName);
            action.Click(ele).Click(ele).Click(ele).Perform();
            driver.FindElement(NewBusinessName).SendKeys(Keys.Delete);
            driver.FindElement(NewBusinessName).SendKeys("1111");
            Thread.Sleep(1000);
            //Address
            driver.SwitchTo().Frame(driver.FindElement(By.Id("WebResource_WMDCCustomerAddressSearch")));
            Thread.Sleep(1000);
            driver.FindElement(NewBusinessAddress).Click();
            driver.FindElement(NewBusinessAddress).SendKeys("pontefract");
            driver.FindElement(NewBusinessAddress).SendKeys(Keys.Enter);
            wait.Until(ExpectedConditions.ElementExists((By)NewBusinessAddressDropdown));
            driver.FindElement(NewBusinessAddressDropdown).Click();
            driver.SwitchTo().DefaultContent();
            //Save and close
            driver.FindElement(NewBusinessSaveandClose).Click();
            Thread.Sleep(3000);
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
                    wait.Until(ExpectedConditions.ElementExists((By)MergeBusinessOverlay));
                    Thread.Sleep(2000);
                    driver.FindElement(MergeCustomersOverlayButton).Click();
                    Thread.Sleep(2000);
                    driver.FindElement(BusinessesLHN).Click();
                    Thread.Sleep(2000);
                }
            }
            catch (Exception)
            {
                if (driver.FindElement(ActiveAccountsList).Displayed)
                {
                    Console.WriteLine("No duplicates found");
                }
            }
            wait.Until(ExpectedConditions.ElementExists((By)ActiveAccountsList));
            Thread.Sleep(1000);
            Assert.IsTrue(driver.FindElement(ActiveAccountsList).Displayed);
            //Enter search term in search box
            driver.FindElement(SearchBoxOnActiveContacts).Click();
            Thread.Sleep((2000));
            driver.FindElement(SearchBoxOnActiveContacts).SendKeys("1111");
            Thread.Sleep((1000));
            driver.FindElement(SearchBoxOnActiveContacts).SendKeys(Keys.Enter);
            Thread.Sleep((2000));
            //Verify user shows on active contacts list
            wait.Until(ExpectedConditions.ElementExists((By)NewBusinessOnList));
            Thread.Sleep((1000));
            Assert.IsTrue(driver.FindElement(NewBusinessOnList).Displayed);
            //Delete customer
            driver.FindElement(NewBusinessOnList).Click();
            Thread.Sleep((2000));
            driver.FindElement(ActiveBusinessesDelete).Click();
            wait.Until(ExpectedConditions.ElementExists((By)ActiveBusinessesDeleteOverlay));
            Thread.Sleep(1000);
            driver.FindElement(ActiveBusinessesDeleteOverlay).Click();
            Thread.Sleep((2000));
            //add verification that user is deleted
            wait.Until(ExpectedConditions.ElementExists((By)ActiveAccountsList));
            Assert.IsTrue(driver.FindElement(ActiveAccountsList).Displayed);
            Thread.Sleep((2000));
            var Business = 0;
            try
            {

                WebElement business = (WebElement)driver.FindElement(NewBusinessOnList);
                if (business.Displayed)
                {
                    Business = 1;
                    Assert.Fail();
                }
            }
            catch (Exception)
            {
                if (Business > 0)
                {
                    Console.WriteLine("Business not removed");
                }
                else
                {
                    Console.WriteLine("Business removed");
                }
            }
        }

        public void AddNoteToClientTimeline()
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
            //Create new customer
            driver.FindElement(NewCustomerButton).Click();
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)NewCustomerForm));
            Assert.IsTrue(driver.FindElement(NewCustomerForm).Displayed);
            Thread.Sleep(1000);
            //Fill mandatory fields
            //First name
            driver.FindElement(NewCustomerFirstName).Click();
            Thread.Sleep(1000);
            Actions action = new Actions(driver);
            WebElement ele1 = (WebElement)driver.FindElement(NewCustomerFirstName);
            action.Click(ele1).Click(ele1).Click(ele1).Perform();
            driver.FindElement(NewCustomerFirstName).SendKeys(Keys.Delete);
            driver.FindElement(NewCustomerFirstName).SendKeys("1111");
            //Surname
            driver.FindElement(NewCustomerSurname).Click();
            Thread.Sleep(1000);
            WebElement ele = (WebElement)driver.FindElement(NewCustomerSurname);
            action.Click(ele).Click(ele).Click(ele).Perform();
            driver.FindElement(NewCustomerSurname).SendKeys(Keys.Delete);
            driver.FindElement(NewCustomerSurname).SendKeys("1111");
            //Address
            driver.SwitchTo().Frame(driver.FindElement(By.Id("WebResource_WMDCCustomerAddressSearch")));
            Thread.Sleep(1000);
            driver.FindElement(NewCustomerAddress).Click();
            driver.FindElement(NewCustomerAddress).SendKeys("pontefract");
            driver.FindElement(NewCustomerAddress).SendKeys(Keys.Enter);
            wait.Until(ExpectedConditions.ElementExists((By)NewCustomerAddressDropdown));
            driver.FindElement(NewCustomerAddressDropdown).Click();
            driver.SwitchTo().DefaultContent();
            //Save customer
            Thread.Sleep(2000);
            driver.FindElement(NewCustomerSave).Click();
            Thread.Sleep(5000);
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
                    wait.Until(ExpectedConditions.ElementExists((By)ActiveContactsList));
                    Thread.Sleep(1000);
                    Assert.IsTrue(driver.FindElement(ActiveContactsList).Displayed);
                    Thread.Sleep((2000));
                    wait.Until(ExpectedConditions.ElementExists((By)NewCustomerOnList));
                    Thread.Sleep(1000);
                    Assert.IsTrue(driver.FindElement(NewCustomerOnList).Displayed);
                    driver.FindElement(NewCustomerOnList).Click();

                }
            }
            catch (Exception)
            {
                if (driver.FindElement(ExistingCustomerRecord).Displayed)
                {
                    Console.WriteLine("No duplicates found");
                }
            }
            Thread.Sleep(4000);
            //Switch to general info tab
            driver.FindElement(NewCustomerGeneralInfo).Click();
            Thread.Sleep(1000);
            wait.Until(ExpectedConditions.ElementExists((By)NewCustomerTimelineTitle));
            Assert.IsTrue(driver.FindElement(NewCustomerTimelineTitle).Displayed);
            Thread.Sleep(1000);
            //Create new note
            driver.FindElement(CustomerTimelineAddNote).Click();
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)CustomerAddNoteSubHeading));
            Assert.IsTrue(driver.FindElement(CustomerAddNoteSubHeading).Displayed);
            //Enter title
            driver.FindElement(CustomerNoteTitle).Click();
            Thread.Sleep(2000);
            driver.FindElement(CustomerNoteTitle).SendKeys("This is a test");
            WebElement ele2 = (WebElement)driver.FindElement(CustomerNoteTitle);
            action.Click(ele2).Click(ele2).Click(ele2).Perform();
            Thread.Sleep(3000);
            action.KeyDown(Keys.Control);
            action.SendKeys("c");
            action.KeyUp(Keys.Control);
            action.Build().Perform();
            //Enter text body
            driver.SwitchTo().Frame(driver.FindElement(By.XPath("//iframe[@class='fullPageContentEditorFrame']")));
            driver.FindElement(CustomerNoteBody).Click();
            Thread.Sleep(3000);
            action.KeyDown(Keys.Control);
            action.SendKeys("v");
            action.KeyUp(Keys.Control);
            action.Build().Perform();
            Thread.Sleep(2000);
            driver.SwitchTo().DefaultContent();
            //Click add note
            Thread.Sleep(2000);
            driver.FindElement(AddNoteButton).Click();
            Thread.Sleep(3000);
            //Verify note is added to top of the list
            wait.Until(ExpectedConditions.ElementExists((By)NewTimelineNoteAdded));
            Assert.IsTrue(driver.FindElement(NewTimelineNoteAdded).Displayed);
            //Delete customer
            driver.FindElement(ActiveContactsDelete).Click();
            wait.Until(ExpectedConditions.ElementExists((By)ActiveContactsDeleteOverlay));
            Thread.Sleep(1000);
            driver.FindElement(ActiveContactsDeleteOverlay).Click();
            Thread.Sleep((3000));
            //add verification that user is deleted
            wait.Until(ExpectedConditions.ElementExists((By)ActiveContactsList));
            Assert.IsTrue(driver.FindElement(ActiveContactsList).Displayed);
            Thread.Sleep((2000));
            //verify user not present
            var Customer = 0;
            try
            {
                WebElement customer = (WebElement)driver.FindElement(NewCustomerOnList);
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

        public void SearchClientTimeline()
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
            //Create new customer
            driver.FindElement(NewCustomerButton).Click();
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)NewCustomerForm));
            Assert.IsTrue(driver.FindElement(NewCustomerForm).Displayed);
            Thread.Sleep(1000);
            //Fill mandatory fields
            Actions action = new Actions(driver);
            WebElement ele1 = (WebElement)driver.FindElement(NewCustomerFirstName);
            action.Click(ele1).Click(ele1).Click(ele1).Perform();
            driver.FindElement(NewCustomerFirstName).SendKeys(Keys.Delete);
            driver.FindElement(NewCustomerFirstName).SendKeys("1111");
            //Surname
            driver.FindElement(NewCustomerSurname).Click();
            Thread.Sleep(1000);
            WebElement ele = (WebElement)driver.FindElement(NewCustomerSurname);
            action.Click(ele).Click(ele).Click(ele).Perform();
            driver.FindElement(NewCustomerSurname).SendKeys(Keys.Delete);
            driver.FindElement(NewCustomerSurname).SendKeys("1111");
            //Address
            driver.SwitchTo().Frame(driver.FindElement(By.Id("WebResource_WMDCCustomerAddressSearch")));
            Thread.Sleep(1000);
            driver.FindElement(NewCustomerAddress).Click();
            driver.FindElement(NewCustomerAddress).SendKeys("pontefract");
            driver.FindElement(NewCustomerAddress).SendKeys(Keys.Enter);
            wait.Until(ExpectedConditions.ElementExists((By)NewCustomerAddressDropdown));
            driver.FindElement(NewCustomerAddressDropdown).Click();
            driver.SwitchTo().DefaultContent();
            //Save customer
            driver.FindElement(NewCustomerSave).Click();
            Thread.Sleep(3000);
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
                    wait.Until(ExpectedConditions.ElementExists((By)ActiveContactsList));
                    Thread.Sleep(1000);
                    Assert.IsTrue(driver.FindElement(ActiveContactsList).Displayed);
                    Thread.Sleep((2000));
                    wait.Until(ExpectedConditions.ElementExists((By)NewCustomerOnList));
                    Thread.Sleep(1000);
                    Assert.IsTrue(driver.FindElement(NewCustomerOnList).Displayed);
                    driver.FindElement(NewCustomerOnList).Click();

                }
            }
            catch (Exception)
            {
                if (driver.FindElement(ExistingCustomerRecord).Displayed)
                {
                    Console.WriteLine("No duplicates found");
                }
            }
            Thread.Sleep(4000);
            //Switch to general info tab
            driver.FindElement(NewCustomerGeneralInfo).Click();
            Thread.Sleep(1000);
            wait.Until(ExpectedConditions.ElementExists((By)NewCustomerTimelineTitle));
            Assert.IsTrue(driver.FindElement(NewCustomerTimelineTitle).Displayed);
            Thread.Sleep(1000);
            //Create new note
            driver.FindElement(CustomerTimelineAddNote).Click();
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)CustomerAddNoteSubHeading));
            Assert.IsTrue(driver.FindElement(CustomerAddNoteSubHeading).Displayed);
            //Enter title
            driver.FindElement(CustomerNoteTitle).Click();
            Thread.Sleep(2000);
            driver.FindElement(CustomerNoteTitle).SendKeys("This is a test");
            WebElement ele2 = (WebElement)driver.FindElement(CustomerNoteTitle);
            action.Click(ele2).Click(ele2).Click(ele2).Perform();
            Thread.Sleep(3000);
            action.KeyDown(Keys.Control);
            action.SendKeys("c");
            action.KeyUp(Keys.Control);
            action.Build().Perform();
            //Enter text body
            driver.SwitchTo().Frame(driver.FindElement(By.XPath("//iframe[@class='fullPageContentEditorFrame']")));
            driver.FindElement(CustomerNoteBody).Click();
            Thread.Sleep(3000);
            action.KeyDown(Keys.Control);
            action.SendKeys("v");
            action.KeyUp(Keys.Control);
            action.Build().Perform();
            Thread.Sleep(2000);
            driver.SwitchTo().DefaultContent();
            //Click add note
            driver.FindElement(AddNoteButton).Click();
            Thread.Sleep(3000);
            //Verify note is added to top of the list
            wait.Until(ExpectedConditions.ElementExists((By)NewTimelineNoteAdded));
            Assert.IsTrue(driver.FindElement(NewTimelineNoteAdded).Displayed);
            //Enter note title in searchbox
            driver.FindElement(CustomerTimelineSearchBox).Click();
            Thread.Sleep(2000);
            action.KeyDown(Keys.Control);
            action.SendKeys("v");
            action.KeyUp(Keys.Control);
            action.Build().Perform();
            Thread.Sleep(2000);
            driver.FindElement(CustomerTimelineSearchBox).SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            //Verify note is displayed on the list
            wait.Until(ExpectedConditions.ElementExists((By)NewTimelineNoteAdded));
            Assert.IsTrue(driver.FindElement(NewTimelineNoteAdded).Displayed);
            Assert.IsTrue(driver.FindElement(NewTimelineNoteAdded).Text == "This is a test");
            //Delete customer
            driver.FindElement(ActiveContactsDelete).Click();
            wait.Until(ExpectedConditions.ElementExists((By)ActiveContactsDeleteOverlay));
            Thread.Sleep(1000);
            driver.FindElement(ActiveContactsDeleteOverlay).Click();
            Thread.Sleep((3000));
            //add verification that user is deleted
            wait.Until(ExpectedConditions.ElementExists((By)ActiveContactsList));
            Assert.IsTrue(driver.FindElement(ActiveContactsList).Displayed);
            Thread.Sleep((2000));
            //verify user not present
            var Customer = 0;
            try
            {

                WebElement customer = (WebElement)driver.FindElement(NewCustomerOnList);
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

        public void FilterClientTimeline()
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
            //Create new customer
            driver.FindElement(NewCustomerButton).Click();
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)NewCustomerForm));
            Assert.IsTrue(driver.FindElement(NewCustomerForm).Displayed);
            Thread.Sleep(1000);
            //Fill mandatory fields
            Actions action = new Actions(driver);
            WebElement ele1 = (WebElement)driver.FindElement(NewCustomerFirstName);
            action.Click(ele1).Click(ele1).Click(ele1).Perform();
            driver.FindElement(NewCustomerFirstName).SendKeys(Keys.Delete);
            driver.FindElement(NewCustomerFirstName).SendKeys("1111");
            //Surname
            driver.FindElement(NewCustomerSurname).Click();
            Thread.Sleep(1000);
            WebElement ele = (WebElement)driver.FindElement(NewCustomerSurname);
            action.Click(ele).Click(ele).Click(ele).Perform();
            driver.FindElement(NewCustomerSurname).SendKeys(Keys.Delete);
            driver.FindElement(NewCustomerSurname).SendKeys("1111");
            //Address
            driver.SwitchTo().Frame(driver.FindElement(By.Id("WebResource_WMDCCustomerAddressSearch")));
            Thread.Sleep(1000);
            driver.FindElement(NewCustomerAddress).Click();
            driver.FindElement(NewCustomerAddress).SendKeys("pontefract");
            driver.FindElement(NewCustomerAddress).SendKeys(Keys.Enter);
            wait.Until(ExpectedConditions.ElementExists((By)NewCustomerAddressDropdown));
            driver.FindElement(NewCustomerAddressDropdown).Click();
            driver.SwitchTo().DefaultContent();
            //Save customer
            driver.FindElement(NewCustomerSave).Click();
            Thread.Sleep(3000);
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
                    wait.Until(ExpectedConditions.ElementExists((By)ActiveContactsList));
                    Thread.Sleep(1000);
                    Assert.IsTrue(driver.FindElement(ActiveContactsList).Displayed);
                    Thread.Sleep((2000));
                    wait.Until(ExpectedConditions.ElementExists((By)NewCustomerOnList));
                    Thread.Sleep(1000);
                    Assert.IsTrue(driver.FindElement(NewCustomerOnList).Displayed);
                    driver.FindElement(NewCustomerOnList).Click();

                }
            }
            catch (Exception)
            {
                if (driver.FindElement(ExistingCustomerRecord).Displayed)
                {
                    Console.WriteLine("No duplicates found");
                }
            }
            Thread.Sleep(4000);
            //Switch to general info tab
            driver.FindElement(NewCustomerGeneralInfo).Click();
            Thread.Sleep(1000);
            wait.Until(ExpectedConditions.ElementExists((By)NewCustomerTimelineTitle));
            Assert.IsTrue(driver.FindElement(NewCustomerTimelineTitle).Displayed);
            Thread.Sleep(1000);
            //Create new note
            driver.FindElement(CustomerTimelineAddNote).Click();
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)CustomerAddNoteSubHeading));
            Assert.IsTrue(driver.FindElement(CustomerAddNoteSubHeading).Displayed);
            //Enter title
            driver.FindElement(CustomerNoteTitle).Click();
            Thread.Sleep(2000);
            driver.FindElement(CustomerNoteTitle).SendKeys("This is a test");
            WebElement ele2 = (WebElement)driver.FindElement(CustomerNoteTitle);
            action.Click(ele2).Click(ele2).Click(ele2).Perform();
            Thread.Sleep(3000);
            action.KeyDown(Keys.Control);
            action.SendKeys("c");
            action.KeyUp(Keys.Control);
            action.Build().Perform();
            //Enter text body
            driver.SwitchTo().Frame(driver.FindElement(By.XPath("//iframe[@class='fullPageContentEditorFrame']")));
            driver.FindElement(CustomerNoteBody).Click();
            Thread.Sleep(3000);
            action.KeyDown(Keys.Control);
            action.SendKeys("v");
            action.KeyUp(Keys.Control);
            action.Build().Perform();
            Thread.Sleep(2000);
            driver.SwitchTo().DefaultContent();
            //Click add note
            driver.FindElement(AddNoteButton).Click();
            Thread.Sleep(3000);
            //Verify note is added to top of the list
            wait.Until(ExpectedConditions.ElementExists((By)NewTimelineNoteAdded));
            Assert.IsTrue(driver.FindElement(NewTimelineNoteAdded).Displayed);
            //Click filter icon on timeline
            Thread.Sleep(2000);
            driver.FindElement(CustomerTimelineFilter).Click();
            Thread.Sleep(3000);
            wait.Until(ExpectedConditions.ElementExists((By)CustomerTimelineFilterOptions));
            Assert.IsTrue(driver.FindElement(CustomerTimelineFilterOptions).Displayed);
            //Select record type filter
            Thread.Sleep(2000);
            driver.FindElement(CustomerTimelineFilterNote).Click();
            Thread.Sleep(2000);
            //Verify note is displayed in timeline
            wait.Until(ExpectedConditions.ElementExists((By)NewTimelineNoteAdded));
            Assert.IsTrue(driver.FindElement(NewTimelineNoteAdded).Displayed);
            Thread.Sleep(2000);
            //Verify post is not shown on timeline
            var Post = 0;
            try
            {

                WebElement customer = (WebElement)driver.FindElement(CustomerTimelineFilterPost);
                if (customer.Displayed)
                {
                    Post = 1;
                    Assert.Fail();
                }
            }
            catch (Exception)
            {
                if (Post > 0)
                {
                    Console.WriteLine("Posts not filtered out");
                }
                else
                {
                    Console.WriteLine("Posts filtered out");
                }
                //Delete customer
                driver.FindElement(ActiveContactsDelete).Click();
                wait.Until(ExpectedConditions.ElementExists((By)ActiveContactsDeleteOverlay));
                Thread.Sleep(1000);
                driver.FindElement(ActiveContactsDeleteOverlay).Click();
                Thread.Sleep((3000));
                //add verification that user is deleted
                wait.Until(ExpectedConditions.ElementExists((By)ActiveContactsList));
                Assert.IsTrue(driver.FindElement(ActiveContactsList).Displayed);
                Thread.Sleep((2000));
                //verify user not present
                var Customer = 0;
                try
                {

                    WebElement customer = (WebElement)driver.FindElement(NewCustomerOnList);
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
        }

        public void SortOrderClientTimeline()
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
            //Create new customer
            driver.FindElement(NewCustomerButton).Click();
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)NewCustomerForm));
            Assert.IsTrue(driver.FindElement(NewCustomerForm).Displayed);
            Thread.Sleep(1000);
            //Fill mandatory fields
            Actions action = new Actions(driver);
            WebElement ele1 = (WebElement)driver.FindElement(NewCustomerFirstName);
            action.Click(ele1).Click(ele1).Click(ele1).Perform();
            driver.FindElement(NewCustomerFirstName).SendKeys(Keys.Delete);
            driver.FindElement(NewCustomerFirstName).SendKeys("1111");
            //Surname
            driver.FindElement(NewCustomerSurname).Click();
            Thread.Sleep(1000);
            WebElement ele = (WebElement)driver.FindElement(NewCustomerSurname);
            action.Click(ele).Click(ele).Click(ele).Perform();
            driver.FindElement(NewCustomerSurname).SendKeys(Keys.Delete);
            driver.FindElement(NewCustomerSurname).SendKeys("1111");
            //Address
            driver.SwitchTo().Frame(driver.FindElement(By.Id("WebResource_WMDCCustomerAddressSearch")));
            Thread.Sleep(1000);
            driver.FindElement(NewCustomerAddress).Click();
            driver.FindElement(NewCustomerAddress).SendKeys("pontefract");
            driver.FindElement(NewCustomerAddress).SendKeys(Keys.Enter);
            wait.Until(ExpectedConditions.ElementExists((By)NewCustomerAddressDropdown));
            driver.FindElement(NewCustomerAddressDropdown).Click();
            driver.SwitchTo().DefaultContent();
            //Save customer
            driver.FindElement(NewCustomerSave).Click();
            Thread.Sleep(5000);
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
                    wait.Until(ExpectedConditions.ElementExists((By)ActiveContactsList));
                    Thread.Sleep(1000);
                    Assert.IsTrue(driver.FindElement(ActiveContactsList).Displayed);
                    Thread.Sleep((2000));
                    wait.Until(ExpectedConditions.ElementExists((By)NewCustomerOnList));
                    Thread.Sleep(1000);
                    Assert.IsTrue(driver.FindElement(NewCustomerOnList).Displayed);
                    driver.FindElement(NewCustomerOnList).Click();

                }
            }
            catch (Exception)
            {
                if (driver.FindElement(ExistingCustomerRecord).Displayed)
                {
                    Console.WriteLine("No duplicates found");
                }
            }
            Thread.Sleep(4000);
            //Switch to general info tab
            driver.FindElement(NewCustomerGeneralInfo).Click();
            Thread.Sleep(1000);
            wait.Until(ExpectedConditions.ElementExists((By)NewCustomerTimelineTitle));
            Assert.IsTrue(driver.FindElement(NewCustomerTimelineTitle).Displayed);
            Thread.Sleep(1000);
            //Create new note
            driver.FindElement(CustomerTimelineAddNote).Click();
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)CustomerAddNoteSubHeading));
            Assert.IsTrue(driver.FindElement(CustomerAddNoteSubHeading).Displayed);
            //Enter title
            driver.FindElement(CustomerNoteTitle).Click();
            Thread.Sleep(2000);
            driver.FindElement(CustomerNoteTitle).SendKeys("This is a test");
            WebElement ele2 = (WebElement)driver.FindElement(CustomerNoteTitle);
            action.Click(ele2).Click(ele2).Click(ele2).Perform();
            Thread.Sleep(3000);
            action.KeyDown(Keys.Control);
            action.SendKeys("c");
            action.KeyUp(Keys.Control);
            action.Build().Perform();
            //Enter text body
            driver.SwitchTo().Frame(driver.FindElement(By.XPath("//iframe[@class='fullPageContentEditorFrame']")));
            Thread.Sleep(2000);
            driver.FindElement(CustomerNoteBody).Click();
            Thread.Sleep(3000);
            action.KeyDown(Keys.Control);
            action.SendKeys("v");
            action.KeyUp(Keys.Control);
            action.Build().Perform();
            Thread.Sleep(2000);
            driver.SwitchTo().DefaultContent();
            //Click add note
            driver.FindElement(AddNoteButton).Click();
            Thread.Sleep(3000);
            //Select more commands button
            driver.FindElement(CustomerTimelineMoreCommands).Click();
            Thread.Sleep(3000);
            //Select older to newer
            driver.FindElement(CustomerTimelineSortBy).Click();
            Thread.Sleep(4000);
            //Delete newest note
            driver.FindElement(NewTimelineNoteDelete).Click();
            Thread.Sleep(3000);
            wait.Until(ExpectedConditions.ElementExists((By)NewTimelineNoteOverlayDelete));
            Thread.Sleep(3000);
            driver.FindElement(NewTimelineNoteOverlayDelete).Click();
            //Check note is deleted
            var Note = 0;
            try
            {

                WebElement note = (WebElement)driver.FindElement(NewTimelineNoteAdded);
                if (note.Displayed)
                {
                    Note = 1;
                    Assert.Fail();
                }
            }
            catch (Exception)
            {
                if (Note > 0)
                {
                    Console.WriteLine("Note not removed");
                }
                else
                {
                    Console.WriteLine("Note removed");
                }
            }
            //Delete customer
            driver.FindElement(ActiveContactsDelete).Click();
            wait.Until(ExpectedConditions.ElementExists((By)ActiveContactsDeleteOverlay));
            Thread.Sleep(1000);
            driver.FindElement(ActiveContactsDeleteOverlay).Click();
            Thread.Sleep((3000));
            //add verification that user is deleted
            wait.Until(ExpectedConditions.ElementExists((By)ActiveContactsList));
            Assert.IsTrue(driver.FindElement(ActiveContactsList).Displayed);
            Thread.Sleep((2000));
            //verify user not present
            var Customer = 0;
            try
            {

                WebElement customer = (WebElement)driver.FindElement(NewCustomerOnList);
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

        public void CustomerProfileRecentCases()
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
            //Search for anonymous customer
            driver.FindElement(SearchBoxOnActiveContacts).Click();
            Thread.Sleep((2000));
            driver.FindElement(SearchBoxOnActiveContacts).SendKeys("dont delete");
            Thread.Sleep((1000));
            driver.FindElement(SearchBoxOnActiveContacts).SendKeys(Keys.Enter);
            Thread.Sleep((2000));
            //Verify user shows on active contacts list
            wait.Until(ExpectedConditions.ElementExists((By)DontDeleteCustomerOnList));
            Thread.Sleep((1000));
            Assert.IsTrue(driver.FindElement(DontDeleteCustomerOnList).Displayed);
            driver.FindElement(DontDeleteCustomerOnList).Click();
            wait.Until(ExpectedConditions.ElementExists((By)CustomerInfoHeader));
            //Click history tab
            wait.Until(ExpectedConditions.ElementExists((By)HistoryTabOnProfile));
            driver.FindElement(HistoryTabOnProfile).Click();
            //Verify previous addreses, customer cases and cases reported for someone else blocks show
            wait.Until(ExpectedConditions.ElementExists((By)PreviousAddressOnHistory));
            Assert.IsTrue(driver.FindElement(PreviousAddressOnHistory).Displayed);
            wait.Until(ExpectedConditions.ElementExists((By)CustomerCasesOnHistory));
            Assert.IsTrue(driver.FindElement(CustomerCasesOnHistory).Displayed);
            Actions actions = new Actions(driver);
            actions.SendKeys(Keys.PageDown).Build().Perform();
            wait.Until(ExpectedConditions.ElementExists((By)CasesBySomeoneElseOnHistory));
            Assert.IsTrue(driver.FindElement(CasesBySomeoneElseOnHistory).Displayed);
            Thread.Sleep(2000);
            //Verify case headings are correct
            Assert.IsTrue(driver.FindElement(CaseTitle).Displayed);
            Assert.IsTrue(driver.FindElement(ReportedAddressLocation).Displayed);
            Assert.IsTrue(driver.FindElement(CaseNumber).Displayed);
            Assert.IsTrue(driver.FindElement(Customer).Displayed);
            Assert.IsTrue(driver.FindElement(Origin).Displayed);
            Assert.IsTrue(driver.FindElement(StatusReason).Displayed);
            Assert.IsTrue(driver.FindElement(CreatedOn).Displayed);
            Assert.IsTrue(driver.FindElement(SLATarget).Displayed);
            Assert.IsTrue(driver.FindElement(ReportedBy).Displayed);
            Assert.IsTrue(driver.FindElement(ReportedByBusiness).Displayed);
            Thread.Sleep(2000);
            //Verify cases reported by someone else headings are correct
            Assert.IsTrue(driver.FindElement(SomeoneElseCaseTitle).Displayed);
            Assert.IsTrue(driver.FindElement(SomeoneElseCaseNumber).Displayed);
            Assert.IsTrue(driver.FindElement(SomeoneElseCustomer).Displayed);
            Assert.IsTrue(driver.FindElement(SomeoneElseOrigin).Displayed);
            Assert.IsTrue(driver.FindElement(SomeoneElseStatusReason).Displayed);
            Assert.IsTrue(driver.FindElement(SomeoneElseCreatedOn).Displayed);
            Assert.IsTrue(driver.FindElement(SomeoneElseSLATarget).Displayed);
            Assert.IsTrue(driver.FindElement(SomeoneElseReportedBy).Displayed);
            Assert.IsTrue(driver.FindElement(SomeoneElseReportedByBusiness).Displayed);
        }

        public void CustomerProfileAlerts()
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
            //Search for anonymous customer
            driver.FindElement(SearchBoxOnActiveContacts).Click();
            Thread.Sleep((2000));
            driver.FindElement(SearchBoxOnActiveContacts).SendKeys("dont delete");
            Thread.Sleep((1000));
            driver.FindElement(SearchBoxOnActiveContacts).SendKeys(Keys.Enter);
            Thread.Sleep((2000));
            //Verify user shows on active contacts list
            wait.Until(ExpectedConditions.ElementExists((By)DontDeleteCustomerOnList));
            Thread.Sleep((1000));
            Assert.IsTrue(driver.FindElement(DontDeleteCustomerOnList).Displayed);
            //Select user on list
            driver.FindElement(DontDeleteCustomerOnList).Click();
            wait.Until(ExpectedConditions.ElementExists((By)CustomerInfoHeader));
            //Add text to additional alert info box
            wait.Until(ExpectedConditions.ElementExists((By)AdditionalAlertInfo));
            driver.FindElement(AdditionalAlertInfo).Click();
            Thread.Sleep(1000);
            driver.FindElement(AdditionalAlertInfo).SendKeys("Additional alert info for test user");
            Thread.Sleep(2000);
            //Click save
            driver.FindElement(NewCustomerSave).Click();
            Thread.Sleep(3000);
            //Click general info tab
            driver.FindElement(NewCustomerGeneralInfo).Click();
            Thread.Sleep(3000);
            wait.Until(ExpectedConditions.ElementExists((By)GeneralInfoAlerts));
            //Click add existing entity alert
            wait.Until(ExpectedConditions.ElementExists((By)AddExistingAlertType));
            driver.FindElement(AddExistingAlertType).Click();
            Thread.Sleep(1000);
            //Click in to searchbox
            wait.Until(ExpectedConditions.ElementExists((By)LookForAlerts));
            driver.FindElement(LookForAlerts).Click();
            Thread.Sleep(1000);
            driver.FindElement(LookForAlerts).SendKeys(Keys.Enter);
            //Click blind alert
            wait.Until(ExpectedConditions.ElementExists((By)BlindAlertOnList));
            driver.FindElement(BlindAlertOnList).Click();
            Thread.Sleep(1000);
            //Click add button
            wait.Until(ExpectedConditions.ElementExists((By)AddBtnOnAlertsList));
            driver.FindElement(AddBtnOnAlertsList).Click();
            Thread.Sleep(1000);
            //Verify alert is added
            wait.Until(ExpectedConditions.ElementExists((By)BlindAlertAddedToProfile));
            Assert.IsTrue(driver.FindElement(BlindAlertAddedToProfile).Displayed);
            Thread.Sleep(1000);
            //Delete newly added alert
            driver.FindElement(BlindAlertAddedToProfile).Click();
            Thread.Sleep(1000);
            driver.FindElement(MoreOptionsBtn).Click();
            Thread.Sleep(1000);
            wait.Until(ExpectedConditions.ElementExists((By)DeleteAlert));
            driver.FindElement(DeleteAlert).Click();
            Thread.Sleep(3000);
        }

        public void DuplicateUser()
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
            //Create new customer
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
            ele = (WebElement)driver.FindElement(NewCustomerSurname);
            action.Click(ele).Click(ele).Click(ele).Perform();
            driver.FindElement(NewCustomerSurname).SendKeys(Keys.Delete);
            driver.FindElement(NewCustomerSurname).SendKeys("AAA");
            //Address
            driver.SwitchTo().Frame(driver.FindElement(By.Id("WebResource_WMDCCustomerAddressSearch")));
            Thread.Sleep(1000);
            driver.FindElement(NewCustomerAddress).Click();
            driver.FindElement(NewCustomerAddress).SendKeys("6 Sandhill Rise Pontefract WF8 1RA");
            driver.FindElement(NewCustomerAddress).SendKeys(Keys.Enter);
            wait.Until(ExpectedConditions.ElementExists((By)AddressSearchBoxResult));
            driver.FindElement(AddressSearchBoxResult).Click();
            driver.SwitchTo().DefaultContent();
            //Click Save and close
            driver.FindElement(NewCustomerSaveandClose).Click();
            Thread.Sleep(3000);
            //Duplicate record check
            try
            {
                if (driver.FindElement(DuplicateRecordOverlay).Displayed)
                {
                    Assert.Fail();
                }
            }
            catch (Exception)
            {
                if (driver.FindElement(ActiveContactsList).Displayed)
                {
                    Console.WriteLine("No duplicates found");
                }
            }
            //Create new customer
            driver.FindElement(NewCustomerButton).Click();
            wait.Until(ExpectedConditions.ElementExists((By)NewCustomerForm));
            Assert.IsTrue(driver.FindElement(NewCustomerForm).Displayed);
            //First name
            driver.FindElement(NewCustomerFirstName).Click();
            Thread.Sleep(1000);
            ele = (WebElement)driver.FindElement(NewCustomerFirstName);
            action.Click(ele).Click(ele).Click(ele).Perform();
            driver.FindElement(NewCustomerFirstName).SendKeys(Keys.Delete);
            driver.FindElement(NewCustomerFirstName).SendKeys("1111");
            //Surname
            driver.FindElement(NewCustomerSurname).Click();
            Thread.Sleep(1000);
            ele = (WebElement)driver.FindElement(NewCustomerSurname);
            action.Click(ele).Click(ele).Click(ele).Perform();
            driver.FindElement(NewCustomerSurname).SendKeys(Keys.Delete);
            driver.FindElement(NewCustomerSurname).SendKeys("AAA");
            //Address
            driver.SwitchTo().Frame(driver.FindElement(By.Id("WebResource_WMDCCustomerAddressSearch")));
            Thread.Sleep(1000);
            driver.FindElement(NewCustomerAddress).Click();
            ele = (WebElement)driver.FindElement(NewCustomerAddress);
            action.Click(ele).Click(ele).Click(ele).Perform();
            driver.FindElement(NewCustomerAddress).SendKeys(Keys.Delete);
            driver.FindElement(NewCustomerAddress).SendKeys("6 Sandhill Rise Pontefract WF8 1RA");
            driver.FindElement(NewCustomerAddress).SendKeys(Keys.Enter);
            wait.Until(ExpectedConditions.ElementExists((By)AddressSearchBoxResult));
            driver.FindElement(AddressSearchBoxResult).Click();
            driver.SwitchTo().DefaultContent();
            //Click Save and close
            driver.FindElement(NewCustomerSaveandClose).Click();
            Thread.Sleep(3000);
            //Duplicate record check
            try
            {
                if (driver.FindElement(DuplicateRecordOverlay).Displayed)
                {
                    Assert.Fail();
                }
            }
            catch (Exception)
            {
                if (driver.FindElement(ActiveContactsList).Displayed)
                {
                    Console.WriteLine("No duplicates found");
                }
            }
            //Create new customer
            driver.FindElement(NewCustomerButton).Click();
            wait.Until(ExpectedConditions.ElementExists((By)NewCustomerForm));
            Assert.IsTrue(driver.FindElement(NewCustomerForm).Displayed);
            //First name
            driver.FindElement(NewCustomerFirstName).Click();
            Thread.Sleep(1000);
            ele = (WebElement)driver.FindElement(NewCustomerFirstName);
            action.Click(ele).Click(ele).Click(ele).Perform();
            driver.FindElement(NewCustomerFirstName).SendKeys(Keys.Delete);
            driver.FindElement(NewCustomerFirstName).SendKeys("AAA");
            //Surname
            driver.FindElement(NewCustomerSurname).Click();
            Thread.Sleep(1000);
            ele = (WebElement)driver.FindElement(NewCustomerSurname);
            action.Click(ele).Click(ele).Click(ele).Perform();
            driver.FindElement(NewCustomerSurname).SendKeys(Keys.Delete);
            driver.FindElement(NewCustomerSurname).SendKeys("1111");
            //Address
            driver.SwitchTo().Frame(driver.FindElement(By.Id("WebResource_WMDCCustomerAddressSearch")));
            Thread.Sleep(1000);
            driver.FindElement(NewCustomerAddress).Click();
            ele = (WebElement)driver.FindElement(NewCustomerAddress);
            action.Click(ele).Click(ele).Click(ele).Perform();
            driver.FindElement(NewCustomerAddress).SendKeys(Keys.Delete);
            driver.FindElement(NewCustomerAddress).SendKeys("6 Sandhill Rise Pontefract WF8 1RA");
            driver.FindElement(NewCustomerAddress).SendKeys(Keys.Enter);
            wait.Until(ExpectedConditions.ElementExists((By)AddressSearchBoxResult));
            driver.FindElement(AddressSearchBoxResult).Click();
            driver.SwitchTo().DefaultContent();
            //Click Save and close
            driver.FindElement(NewCustomerSaveandClose).Click();
            Thread.Sleep(3000);
            //Duplicate record check
            try
            {
                if (driver.FindElement(DuplicateRecordOverlay).Displayed)
                {
                    Assert.Fail();
                }
            }
            catch (Exception)
            {
                if (driver.FindElement(ActiveContactsList).Displayed)
                {
                    Console.WriteLine("No duplicates found");
                }
            }
            //Create new customer
            driver.FindElement(NewCustomerButton).Click();
            wait.Until(ExpectedConditions.ElementExists((By)NewCustomerForm));
            Assert.IsTrue(driver.FindElement(NewCustomerForm).Displayed);
            //First name
            driver.FindElement(NewCustomerFirstName).Click();
            Thread.Sleep(1000);
            ele = (WebElement)driver.FindElement(NewCustomerFirstName);
            action.Click(ele).Click(ele).Click(ele).Perform();
            driver.FindElement(NewCustomerFirstName).SendKeys(Keys.Delete);
            driver.FindElement(NewCustomerFirstName).SendKeys("AAA");
            //Surname
            driver.FindElement(NewCustomerSurname).Click();
            Thread.Sleep(1000);
            ele = (WebElement)driver.FindElement(NewCustomerSurname);
            action.Click(ele).Click(ele).Click(ele).Perform();
            driver.FindElement(NewCustomerSurname).SendKeys(Keys.Delete);
            driver.FindElement(NewCustomerSurname).SendKeys("AAA");
            //Email address
            driver.FindElement(NewCustomerEmailAddress).Click();
            Thread.Sleep(1000);
            ele = (WebElement)driver.FindElement(NewCustomerEmailAddress);
            action.Click(ele).Click(ele).Click(ele).Perform();
            driver.FindElement(NewCustomerEmailAddress).SendKeys(Keys.Delete);
            driver.FindElement(NewCustomerEmailAddress).SendKeys("Email@wakefield.gov.uk");
            //Address
            driver.SwitchTo().Frame(driver.FindElement(By.Id("WebResource_WMDCCustomerAddressSearch")));
            Thread.Sleep(1000);
            driver.FindElement(NewCustomerAddress).Click();
            ele = (WebElement)driver.FindElement(NewCustomerAddress);
            action.Click(ele).Click(ele).Click(ele).Perform();
            driver.FindElement(NewCustomerAddress).SendKeys(Keys.Delete);
            driver.FindElement(NewCustomerAddress).SendKeys("8 Sandhill Rise Pontefract WF8 1RA");
            driver.FindElement(NewCustomerAddress).SendKeys(Keys.Enter);
            wait.Until(ExpectedConditions.ElementExists((By)AddressSearchBoxResult2));
            driver.FindElement(AddressSearchBoxResult2).Click();
            driver.SwitchTo().DefaultContent();
            //Click Save and close
            driver.FindElement(NewCustomerSaveandClose).Click();
            Thread.Sleep(3000);
            //Duplicate record check
            try
            {
                if (driver.FindElement(DuplicateRecordOverlay).Displayed)
                {
                    Assert.Fail();
                }
            }
            catch (Exception)
            {
                if (driver.FindElement(ActiveContactsList).Displayed)
                {
                    Console.WriteLine("No duplicates found");
                }
            }
            //Create new customer
            driver.FindElement(NewCustomerButton).Click();
            wait.Until(ExpectedConditions.ElementExists((By)NewCustomerForm));
            Assert.IsTrue(driver.FindElement(NewCustomerForm).Displayed);
            //First name
            driver.FindElement(NewCustomerFirstName).Click();
            Thread.Sleep(1000);
            ele = (WebElement)driver.FindElement(NewCustomerFirstName);
            action.Click(ele).Click(ele).Click(ele).Perform();
            driver.FindElement(NewCustomerFirstName).SendKeys(Keys.Delete);
            driver.FindElement(NewCustomerFirstName).SendKeys("AAA");
            //Surname
            driver.FindElement(NewCustomerSurname).Click();
            Thread.Sleep(1000);
            ele = (WebElement)driver.FindElement(NewCustomerSurname);
            action.Click(ele).Click(ele).Click(ele).Perform();
            driver.FindElement(NewCustomerSurname).SendKeys(Keys.Delete);
            driver.FindElement(NewCustomerSurname).SendKeys("AAA");
            //Address
            driver.SwitchTo().Frame(driver.FindElement(By.Id("WebResource_WMDCCustomerAddressSearch")));
            Thread.Sleep(1000);
            driver.FindElement(NewCustomerAddress).Click();
            ele = (WebElement)driver.FindElement(NewCustomerAddress);
            action.Click(ele).Click(ele).Click(ele).Perform();
            driver.FindElement(NewCustomerAddress).SendKeys(Keys.Delete);
            driver.FindElement(NewCustomerAddress).SendKeys("6 Sandhill Rise Pontefract WF8 1RA");
            driver.FindElement(NewCustomerAddress).SendKeys(Keys.Enter);
            wait.Until(ExpectedConditions.ElementExists((By)AddressSearchBoxResult));
            driver.FindElement(AddressSearchBoxResult).Click();
            driver.SwitchTo().DefaultContent();
            //Click Save and close
            driver.FindElement(NewCustomerSaveandClose).Click();
            Thread.Sleep(3000);
            //Duplicate record check
            try
            {
                if (driver.FindElement(DuplicateRecordOverlay).Displayed)
                {
                    Thread.Sleep(2000);
                    driver.FindElement(DuplicateRecordOverlayCancel).Click(); 
                }
            }
            catch (Exception)
            {
                if (driver.FindElement(ActiveContactsList).Displayed)
                {
                    Console.WriteLine("No duplicates found");
                    Assert.Fail();
                }
            }
            //First name
            driver.FindElement(NewCustomerFirstName).Click();
            Thread.Sleep(1000);
            ele = (WebElement)driver.FindElement(NewCustomerFirstName);
            action.Click(ele).Click(ele).Click(ele).Perform();
            driver.FindElement(NewCustomerFirstName).SendKeys(Keys.Delete);
            driver.FindElement(NewCustomerFirstName).SendKeys("AAA");
            //Surname
            driver.FindElement(NewCustomerSurname).Click();
            Thread.Sleep(1000);
            ele = (WebElement)driver.FindElement(NewCustomerSurname);
            action.Click(ele).Click(ele).Click(ele).Perform();
            driver.FindElement(NewCustomerSurname).SendKeys(Keys.Delete);
            driver.FindElement(NewCustomerSurname).SendKeys("AAA");
            //Email address
            driver.FindElement(NewCustomerEmailAddress).Click();
            Thread.Sleep(1000);
            ele = (WebElement)driver.FindElement(NewCustomerEmailAddress);
            action.Click(ele).Click(ele).Click(ele).Perform();
            driver.FindElement(NewCustomerEmailAddress).SendKeys(Keys.Delete);
            driver.FindElement(NewCustomerEmailAddress).SendKeys("Email@wakefield.gov.uk");
            //Address
            driver.SwitchTo().Frame(driver.FindElement(By.Id("WebResource_WMDCCustomerAddressSearch")));
            Thread.Sleep(1000);
            driver.FindElement(NewCustomerAddress).Click();
            ele = (WebElement)driver.FindElement(NewCustomerAddress);
            action.Click(ele).Click(ele).Click(ele).Perform();
            driver.FindElement(NewCustomerAddress).SendKeys(Keys.Delete);
            driver.FindElement(NewCustomerAddress).SendKeys("6 Sandhill Rise Pontefract WF8 1RA");
            driver.FindElement(NewCustomerAddress).SendKeys(Keys.Enter);
            wait.Until(ExpectedConditions.ElementExists((By)AddressSearchBoxResult));
            driver.FindElement(AddressSearchBoxResult).Click();
            driver.SwitchTo().DefaultContent();
            //Click Save and close
            driver.FindElement(NewCustomerSaveandClose).Click();
            Thread.Sleep(3000);
            //Duplicate record check
            try
            {
                if (driver.FindElement(DuplicateRecordOverlay).Displayed)
                {
                    Thread.Sleep(2000);
                    driver.FindElement(DuplicateRecordOverlayCancel).Click();
                }
            }
            catch (Exception)
            {
                if (driver.FindElement(ActiveContactsList).Displayed)
                {
                    Console.WriteLine("No duplicates found");
                    Assert.Fail();
                }
            }
            //First name
            driver.FindElement(NewCustomerFirstName).Click();
            Thread.Sleep(1000);
            ele = (WebElement)driver.FindElement(NewCustomerFirstName);
            action.Click(ele).Click(ele).Click(ele).Perform();
            driver.FindElement(NewCustomerFirstName).SendKeys(Keys.Delete);
            driver.FindElement(NewCustomerFirstName).SendKeys("AAA");
            //Surname
            driver.FindElement(NewCustomerSurname).Click();
            Thread.Sleep(1000);
            ele = (WebElement)driver.FindElement(NewCustomerSurname);
            action.Click(ele).Click(ele).Click(ele).Perform();
            driver.FindElement(NewCustomerSurname).SendKeys(Keys.Delete);
            driver.FindElement(NewCustomerSurname).SendKeys("AAA");
            //Email address
            driver.FindElement(NewCustomerEmailAddress).Click();
            Thread.Sleep(1000);
            ele = (WebElement)driver.FindElement(NewCustomerEmailAddress);
            action.Click(ele).Click(ele).Click(ele).Perform();
            driver.FindElement(NewCustomerEmailAddress).SendKeys(Keys.Delete);
            driver.FindElement(NewCustomerEmailAddress).SendKeys("EmailAddress@wakefield.gov.uk");
            //Address
            driver.SwitchTo().Frame(driver.FindElement(By.Id("WebResource_WMDCCustomerAddressSearch")));
            Thread.Sleep(1000);
            driver.FindElement(NewCustomerAddress).Click();
            ele = (WebElement)driver.FindElement(NewCustomerAddress);
            action.Click(ele).Click(ele).Click(ele).Perform();
            driver.FindElement(NewCustomerAddress).SendKeys(Keys.Delete);
            driver.FindElement(NewCustomerAddress).SendKeys("6 Sandhill Rise Pontefract WF8 1RA");
            driver.FindElement(NewCustomerAddress).SendKeys(Keys.Enter);
            wait.Until(ExpectedConditions.ElementExists((By)AddressSearchBoxResult));
            driver.FindElement(AddressSearchBoxResult).Click();
            driver.SwitchTo().DefaultContent();
            //Click Save and close
            driver.FindElement(NewCustomerSaveandClose).Click();
            Thread.Sleep(3000);
            //Duplicate record check
            try
            {
                if (driver.FindElement(DuplicateRecordOverlay).Displayed)
                {
                    Thread.Sleep(2000);
                    driver.FindElement(DuplicateRecordOverlayCancel).Click();
                }
            }
            catch (Exception)
            {
                if (driver.FindElement(ActiveContactsList).Displayed)
                {
                    Console.WriteLine("No duplicates found");
                    Assert.Fail();
                }
            }
            //First name
            driver.FindElement(NewCustomerFirstName).Click();
            Thread.Sleep(1000);
            ele = (WebElement)driver.FindElement(NewCustomerFirstName);
            action.Click(ele).Click(ele).Click(ele).Perform();
            driver.FindElement(NewCustomerFirstName).SendKeys(Keys.Delete);
            driver.FindElement(NewCustomerFirstName).SendKeys("2222");
            //Surname
            driver.FindElement(NewCustomerSurname).Click();
            Thread.Sleep(1000);
            ele = (WebElement)driver.FindElement(NewCustomerSurname);
            action.Click(ele).Click(ele).Click(ele).Perform();
            driver.FindElement(NewCustomerSurname).SendKeys(Keys.Delete);
            driver.FindElement(NewCustomerSurname).SendKeys("2222");
            //Address
            driver.SwitchTo().Frame(driver.FindElement(By.Id("WebResource_WMDCCustomerAddressSearch")));
            Thread.Sleep(1000);
            driver.FindElement(NewCustomerAddress).Click();
            ele = (WebElement)driver.FindElement(NewCustomerAddress);
            action.Click(ele).Click(ele).Click(ele).Perform();
            driver.FindElement(NewCustomerAddress).SendKeys(Keys.Delete);
            driver.FindElement(NewCustomerAddress).SendKeys("9 Sandhill Rise Pontefract WF8 1RA");
            driver.FindElement(NewCustomerAddress).SendKeys(Keys.Enter);
            wait.Until(ExpectedConditions.ElementExists((By)AddressSearchBoxResult3));
            driver.FindElement(AddressSearchBoxResult3).Click();
            driver.SwitchTo().DefaultContent();
            //Click Save and close
            driver.FindElement(NewCustomerSaveandClose).Click();
            Thread.Sleep(3000);
            //Duplicate record check
            try
            {
                if (driver.FindElement(DuplicateRecordOverlay).Displayed)
                {
                    Assert.Fail();
                }
            }
            catch (Exception)
            {
                if (driver.FindElement(ActiveContactsList).Displayed)
                {
                    Console.WriteLine("No duplicates found");
                }
            }
            //Select user from list
            wait.Until(ExpectedConditions.ElementExists((By)ActiveContactsList));
            Thread.Sleep(4000);
            wait.Until(ExpectedConditions.ElementExists((By)DeactivateCustomerOnList));
            driver.FindElement(DeactivateCustomerOnList).Click();
            //Verify customer profile loads
            wait.Until(ExpectedConditions.ElementExists((By)DeactivatedCustomerTitle));
            Assert.IsTrue(driver.FindElement(DeactivatedCustomerTitle).Displayed);
            //Click deactivate
            wait.Until(ExpectedConditions.ElementExists((By)ProfileDeactivate));
            driver.FindElement(ProfileDeactivate).Click();
            wait.Until(ExpectedConditions.ElementExists((By)ProfileDeactivateConfirm));
            driver.FindElement(ProfileDeactivateConfirm).Click();
            //Click new customer
            wait.Until(ExpectedConditions.ElementExists((By)NewCustomerButtonOnProfile));
            driver.FindElement(NewCustomerButtonOnProfile).Click();
            //Verify new customer form loads
            wait.Until(ExpectedConditions.ElementExists((By)NewCustomerForm));
            //First name
            driver.FindElement(NewCustomerFirstName).Click();
            Thread.Sleep(1000);
            ele = (WebElement)driver.FindElement(NewCustomerFirstName);
            action.Click(ele).Click(ele).Click(ele).Perform();
            driver.FindElement(NewCustomerFirstName).SendKeys(Keys.Delete);
            driver.FindElement(NewCustomerFirstName).SendKeys("2222");
            //Surname
            driver.FindElement(NewCustomerSurname).Click();
            Thread.Sleep(1000);
            ele = (WebElement)driver.FindElement(NewCustomerSurname);
            action.Click(ele).Click(ele).Click(ele).Perform();
            driver.FindElement(NewCustomerSurname).SendKeys(Keys.Delete);
            driver.FindElement(NewCustomerSurname).SendKeys("2222");
            //Address
            driver.SwitchTo().Frame(driver.FindElement(By.Id("WebResource_WMDCCustomerAddressSearch")));
            Thread.Sleep(1000);
            driver.FindElement(NewCustomerAddress).Click();
            ele = (WebElement)driver.FindElement(NewCustomerAddress);
            action.Click(ele).Click(ele).Click(ele).Perform();
            driver.FindElement(NewCustomerAddress).SendKeys(Keys.Delete);
            driver.FindElement(NewCustomerAddress).SendKeys("9 Sandhill Rise Pontefract WF8 1RA");
            driver.FindElement(NewCustomerAddress).SendKeys(Keys.Enter);
            wait.Until(ExpectedConditions.ElementExists((By)AddressSearchBoxResult3));
            driver.FindElement(AddressSearchBoxResult3).Click();
            driver.SwitchTo().DefaultContent();
            //Click Save and close
            driver.FindElement(NewCustomerSaveandClose).Click();
            Thread.Sleep(3000);
            //Duplicate record check
            try
            {
                if (driver.FindElement(DuplicateRecordOverlay).Displayed)
                {
                    Assert.Fail();
                }
            }
            catch (Exception)
            {
                if (driver.FindElement(DeactivatedCustomerTitle).Displayed)
                {
                    Console.WriteLine("No duplicates found");
                }
            }
        }
    }
}
