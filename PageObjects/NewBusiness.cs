using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace CRMRegressionPack.PageObjects
{
    public class NewBusiness
    {
        By BusinessesLHN = By.CssSelector("[Aria-label='Businesses']");
        By DashboardsLHN = By.XPath("//span[contains(text(),'Dashboards')]");
        By ActiveAccountsList = By.XPath("//span[contains(text(),'Active Accounts')]");
        By NewBusinessButton = By.XPath("//span[contains(text(),'New')]");
        By NewBusinessForm = By.XPath("//h1[contains(text(),'New Business')]");
        By NewBusinessTitle = By.XPath("//h1[@title='AAA']");
        By NewBusinessName = By.CssSelector("[Aria-label='Business Name']");
        By NewBusinessContactMethod = By.CssSelector("[Aria-label='Preferred Method of Contact']");
        By NewBusinessContactDropdown = By.XPath("//option[contains(text(),'Email')]");
        By NewBusinessPhone = By.CssSelector("[placeholder='Provide a telephone number']");
        By NewBusinessEmail = By.CssSelector("[placeholder='Provide an email']");
        By NewBusinessEmailLabel = By.XPath("//label[contains(text(),'Email')]");
        By NewBusinessEmailError = By.XPath("//span[contains(text(),'Email: Enter a valid email address.')]");
        By NewBusinessWebsite = By.CssSelector("[placeholder='Provide a URL']");
        By NewBusinessAddress = By.XPath("//input[@placeholder='Search for an address']");
        By NewBusinessAddressDropdown = By.XPath("//option[contains(text(),'4 Sandhill Rise Pontefract WF8 1RA')]");
        By NewBusinessAddressDropdown2 = By.XPath("//option[contains(text(),'5 Sandhill Rise Pontefract WF8 1RA')]");
        By NewBusinessSaveandClose = By.XPath("//span[contains(text(),'Save & Close')]");
        By NewBusinessSaveBtn = By.XPath("//button[@aria-label='Save (CTRL+S)']//span[contains(text(),'Save')]");
        By ContinueWithCustomer = By.XPath("//button[text()='Continue with Customer']");

        By NewBusinessOnList = By.XPath("//span[contains(text(),'AAA')]");
        By NewBusinessOnList2 = By.XPath("//span[normalize-space()='BBB']");
        By SearchForBusinessOnList = By.XPath("//input[@placeholder='Filter by keyword']");
        By SearchResultOnList = By.XPath("//span[contains(text(),'Test Cafe')]");
        By NewBusinessErrorMsg = By.XPath("//div[@id='notificationMessageAndButtons']");
        By NewBusinessInlineErrorMsg = By.XPath("//span[contains(text(),'Business Name: Required fields must be filled in.')]");
        By DuplicateRecordOverlay = By.CssSelector("[aria-label='Duplicate records found']");
        By DuplicateRecordSelect = By.XPath("//section//section//section//section//div//div//div//div//div[2]//div[4]");
        By DuplicateRecordMerge = By.XPath("//button[.='Merge']");
        By IgnoreAndSave = By.XPath("//span[text()='Ignore and save']");

        By MergeBusinessOverlay = By.XPath("//h1[contains(text(),'Merge Businesses')]");
        By MergeCustomersOverlayButton = By.XPath("//span[.='OK']");

        By DashboardTitle = By.XPath("//span[normalize-space()='Wakefield Home']");
        By BusinessNameInAccessChannel = By.XPath("//a[normalize-space()='AAA']");
        By DeleteOnProfile = By.XPath("//span[text()='Delete']");
        By DeleteOnProfileOverlay = By.XPath("//div[@role='dialog']//button[@aria-label='Delete']//span[contains(text(),'Delete')]");

        By CantFindAddressLink = By.XPath("//a[@id='lnkManualAddress']");
        By UnderstandBtnOnOverlay = By.XPath("//span[contains(text(),'I Understand')]");
        By ManualAddressHouseNumber = By.XPath("//input[@placeholder='House name/number']");
        By ManualAddressStreetName = By.XPath("//input[@placeholder='Street name']");
        By ManualAddressTown = By.XPath("//input[@placeholder='Town/city']");
        By ManualAddressPostcode = By.XPath("//input[@placeholder='Postcode']");
        By OutOfAreaTickbox = By.XPath("//input[@placeholder='Out of area']");
        By ConfirmManualAdressBtn = By.XPath("//button[@id='btnManualAddress']");

        By AdvancedFindFilter = By.CssSelector(".AdvFind-symbol");
        By FilterLookFor = By.XPath("//td[@class='ms-crm-AdvFind-EntityList']");
        By LookForOptionOnDropdown = By.XPath("//option[.='Addressable Locations']");
        By ResultsIconOnLookForBanner = By.XPath("//span[@class='ms-cui-ctl-largelabel'][contains(text(),'Results')]");
        By ResultsCreatedOnColumn = By.XPath("//label[contains(text(),'Created On')]");
        By AddressResultOnTable1 = By.XPath("//a[contains(text(),'ASHBY-DE-LA-ZOUCH')]");

        By NewBusinessInAccessChannel = By.XPath("//a[contains(text(),'AAA')]");
        By AccessChannelCustomerDetails = By.XPath("//div[@id='chosenCustomerDetails']");
        By BusinessAddressInAccessChannel = By.XPath("//div[normalize-space()='4 SANDHILL RISE, PONTEFRACT, WF8 1RA']");
        By BusinessAddressInAccessChannel2 = By.XPath("//div[normalize-space()='4 Sandhill Rise Pontefract WF8 1RA']");
        By CaseHistoryInAccessChannel = By.XPath("//i[contains(text(),'option has been used')]");
        By CustomerEmailInAccessChannel1 = By.XPath("//div[contains(text(),'Testing@testing.com')]");

        By SelectedAddressBanner = By.XPath("//strong[contains(text(),'Selected address:')]");
        By InvalidPostcodeMessage = By.XPath("//h1[contains(text(),'Valid postcode required')]");
        By InvalidPostcodeMessageOK = By.XPath("//span[contains(text(),'OK')]");
        By ManualAddressOnAdvancedFind = By.XPath("//a[contains(text(),'ASHBY-DE-LA-ZOUCH')]");

        By UnknownAddressLink = By.XPath("//a[contains(text(),'Unknown address?')]");
        By UnknownAdressSelected = By.XPath("//div[contains(text(),'Unknown')]");
        By UnknownAddressOnProfile = By.XPath("//div[@title='Unknown']");
        By AddressableLocationTitle = By.XPath("//span[text()='Addressable Location']");
        By AddressUPRN = By.XPath("//input[@value='99999999']");
        By BackButton = By.XPath("//span[contains(@class,'symbolFont BackButton-symbol')]");
        By FullAddressTitle = By.XPath("//h2[contains(text(),'FULL ADDRESS (Will be automatically created)')]");
        By UnknownBusinessAddressInAccessChannel = By.XPath("//div[text()='Unknown']");

        By DuplicateRecordOverlayCancel = By.XPath("//span[normalize-space()='Cancel']");
        By TestCafeOnList = By.CssSelector("[aria-label='BBB']");
        By TestCafeTitle = By.XPath("//h1[@title='BBB']");
        By ProfileDeactivate = By.XPath("//span[@aria-hidden='true']//span[contains(text(),'Deactivate')]");
        By ProfileDeactivateConfirm = By.XPath("//div[@data-id='dialogFooter']//span[contains(text(),'Deactivate')]");
        By NewBusinessButtonOnProfile = By.XPath("//span[contains(text(),'New')]");

        By NewCustomerGeneralInfo = By.XPath("//li[contains(text(),'General Information')]");
        By NewCustomerTimelineTitle = By.XPath("//h3[contains(text(),'Timeline')]");
        By CustomerTimelineAddNote = By.XPath("//span[normalize-space()='Enter a note...']");
        By CustomerAddNoteSubHeading = By.XPath("//h4[contains(text(),'Create a note')]");
        By CustomerNoteTitle = By.XPath("//input[@placeholder='Title']");
        By CustomerNoteBody = By.XPath("/html[1]/body[1]/div[1]");
        By AddNoteButton = By.XPath("//button[contains(text(),'Add note')]");
        By NewTimelineNoteAdded = By.XPath("//li[1]//div[1]//div[2]//div[2]//div[1]//div[1]");
        By NewTimelineNoteDelete = By.XPath("//button[@title='Delete note']//span");
        By NewTimelineNoteOverlayDelete = By.XPath("//span[contains(text(),'OK')]");
        By CustomerTimelineMoreCommands = By.CssSelector("[aria-label='More commands']");
        By CustomerTimelineSortBy = By.XPath("//li[.='Sort older to newer']");

        [ThreadStatic]
        IWebDriver driver;
        WebDriverWait wait;

        public NewBusiness(IWebDriver driver)
        {
            this.driver = driver;
            this.wait = new WebDriverWait(driver, TimeSpan.FromSeconds(120));
        }

        public void VerifyEmailInput()
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
            //Enter invalid email
            driver.FindElement(NewBusinessEmail).Click();
            Thread.Sleep(1000);
            driver.FindElement(NewBusinessEmail).Clear();
            driver.FindElement(NewBusinessEmail).SendKeys("erreiifucom");
            driver.FindElement(NewBusinessEmailLabel).Click();
            Thread.Sleep(1000);
            wait.Until(ExpectedConditions.ElementExists((By)NewBusinessEmailError));
            Assert.IsTrue(driver.FindElement(NewBusinessEmailError).Displayed);
            driver.FindElement(NewBusinessEmail).Click();
            Thread.Sleep(1000);
            Actions action = new Actions(driver);
            WebElement ele = (WebElement)driver.FindElement(NewBusinessEmail);
            action.Click(ele).Click(ele).Click(ele).Perform();
            driver.FindElement(NewBusinessEmail).SendKeys(Keys.Delete);
            driver.FindElement(NewBusinessEmail).SendKeys("$%%$%$@%^$%%");
            driver.FindElement(NewBusinessEmailLabel).Click();
            Thread.Sleep(1000);
            wait.Until(ExpectedConditions.ElementExists((By)NewBusinessEmailError));
            Assert.IsTrue(driver.FindElement(NewBusinessEmailError).Displayed);
            driver.FindElement(NewBusinessEmail).Click();
            Thread.Sleep(1000);
            action.Click(ele).Click(ele).Click(ele).Perform();
            driver.FindElement(NewBusinessEmail).SendKeys(Keys.Delete);
            driver.FindElement(NewBusinessEmail).SendKeys("Test@test.com");
            driver.FindElement(NewBusinessEmailLabel).Click();
            Thread.Sleep(1000);
            //verify error message not present
            var ErrorMsg = 0;
            try
            {

                WebElement errorMsg = (WebElement)driver.FindElement(NewBusinessEmailError);
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

        public void AddNewBusiness()
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
            //Fill mandatory fields
            driver.FindElement(NewBusinessName).Click();
            Thread.Sleep(1000);
            Actions action = new Actions(driver);
            WebElement ele = (WebElement)driver.FindElement(NewBusinessName);
            action.Click(ele).Click(ele).Click(ele).Perform();
            driver.FindElement(NewBusinessName).SendKeys(Keys.Delete);
            driver.FindElement(NewBusinessName).SendKeys("AAA");
            driver.SwitchTo().Frame(driver.FindElement(By.Id("WebResource_WMDCCustomerAddressSearch")));
            Thread.Sleep(1000);
            driver.FindElement(NewBusinessAddress).Click();
            driver.FindElement(NewBusinessAddress).SendKeys("4 Sandhill Rise Pontefract WF8 1RA");
            driver.FindElement(NewBusinessAddress).SendKeys(Keys.Enter);
            wait.Until(ExpectedConditions.ElementExists((By)NewBusinessAddressDropdown));
            driver.FindElement(NewBusinessAddressDropdown).Click();
            driver.SwitchTo().DefaultContent();
            //Fill non mandatory fields
            //Preferred contact method
            Thread.Sleep(1000);
            driver.FindElement(NewBusinessContactMethod).Click();
            Thread.Sleep(1000);
            driver.FindElement(NewBusinessContactDropdown).Click();
            Thread.Sleep(1000);
            //Phone number
            driver.FindElement(NewBusinessPhone).Click();
            Thread.Sleep(1000);
            driver.FindElement(NewBusinessPhone).Clear();
            driver.FindElement(NewBusinessPhone).SendKeys("07777777777");
            Thread.Sleep(1000);
            //Email address
            driver.FindElement(NewBusinessEmail).Click();
            Thread.Sleep(1000);
            WebElement ele1 = (WebElement)driver.FindElement(NewBusinessEmail);
            action.Click(ele1).Click(ele1).Click(ele1).Perform();
            driver.FindElement(NewBusinessEmail).SendKeys(Keys.Delete);
            driver.FindElement(NewBusinessEmail).SendKeys("Test@test.com");
            Thread.Sleep(1000);
            //Website
            driver.FindElement(NewBusinessWebsite).Click();
            Thread.Sleep(1000);
            driver.FindElement(NewBusinessWebsite).Clear();
            driver.FindElement(NewBusinessWebsite).SendKeys("www.Test.com");
            Thread.Sleep(1000);
            //Save
            driver.FindElement(NewBusinessSaveBtn).Click();
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
                    wait.Until(ExpectedConditions.ElementExists((By)MergeBusinessOverlay));
                    Thread.Sleep(2000);
                    driver.FindElement(MergeCustomersOverlayButton).Click();
                    Thread.Sleep(2000);
                    driver.FindElement(BusinessesLHN).Click();
                    Thread.Sleep(2000);
                    driver.FindElement(NewBusinessOnList).Click();
                    Thread.Sleep(2000);
                }
            }
            catch (Exception)
            {
                if (driver.FindElement(NewBusinessTitle).Displayed)
                {
                    Console.WriteLine("No duplicates found");
                }
            }
            //Click Continue with customer
            driver.SwitchTo().Frame(driver.FindElement(By.Id("WebResource_ContinueWithNewBusiness")));
            wait.Until(ExpectedConditions.ElementExists((By)ContinueWithCustomer));
            driver.FindElement(ContinueWithCustomer).Click();
            driver.SwitchTo().DefaultContent();
            Thread.Sleep((4000));
            //Verify new business is displayed on dashboard
            wait.Until(ExpectedConditions.ElementExists((By)DashboardTitle));
            driver.SwitchTo().Frame(driver.FindElement(By.Id("9532b1de-41a1-456c-b21c-805faca15573_WebResource_customeradvisorstart")));
            wait.Until(ExpectedConditions.ElementExists((By)BusinessNameInAccessChannel));
            Assert.IsTrue(driver.FindElement(BusinessNameInAccessChannel).Displayed);
            //Delete business
            driver.FindElement(BusinessNameInAccessChannel).Click();
            wait.Until(ExpectedConditions.ElementExists((By)DeleteOnProfile));
            driver.FindElement(DeleteOnProfile).Click();
            driver.SwitchTo().DefaultContent();
            wait.Until(ExpectedConditions.ElementExists((By)DeleteOnProfileOverlay));
            driver.FindElement(DeleteOnProfileOverlay).Click();
            //add verification that user is deleted
            wait.Until(ExpectedConditions.ElementExists((By)DashboardTitle));
            wait.Until(ExpectedConditions.ElementExists((By)BusinessesLHN));
            driver.FindElement(BusinessesLHN).Click();
            wait.Until(ExpectedConditions.ElementExists((By)ActiveAccountsList));
            Assert.IsTrue(driver.FindElement(ActiveAccountsList).Displayed);
            Thread.Sleep((2000));
            //verify business not present
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

        public void AddNewBusinessWithoutMandatoryFields()
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
            //Fill non mandatory fields
            //Preferred contact method
            Thread.Sleep(1000);
            driver.FindElement(NewBusinessContactMethod).Click();
            Thread.Sleep(1000);
            driver.FindElement(NewBusinessContactDropdown).Click();
            Thread.Sleep(1000);
            //Phone number
            driver.FindElement(NewBusinessPhone).Click();
            Thread.Sleep(1000);
            driver.FindElement(NewBusinessPhone).Clear();
            driver.FindElement(NewBusinessPhone).SendKeys("07777777777");
            Thread.Sleep(1000);
            //Email address
            driver.FindElement(NewBusinessEmail).Click();
            Thread.Sleep(1000);
            driver.FindElement(NewBusinessEmail).Clear();
            driver.FindElement(NewBusinessEmail).SendKeys("Test@test.com");
            Thread.Sleep(1000);
            //Website
            driver.FindElement(NewBusinessWebsite).Click();
            Thread.Sleep(1000);
            driver.FindElement(NewBusinessWebsite).Clear();
            driver.FindElement(NewBusinessWebsite).SendKeys("www.Test.com");
            Thread.Sleep(1000);
            //Save and close
            driver.FindElement(NewBusinessSaveandClose).Click();
            Thread.Sleep(3000);
            wait.Until(ExpectedConditions.ElementExists((By)NewBusinessErrorMsg));
            Assert.IsTrue(driver.FindElement(NewBusinessErrorMsg).Displayed);
            Thread.Sleep((2000));
            wait.Until(ExpectedConditions.ElementExists((By)NewBusinessInlineErrorMsg));
            Assert.IsTrue(driver.FindElement(NewBusinessInlineErrorMsg).Displayed);

        }

        public void SearchBusinessOnActiveAccounts()
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
            //Enter search term
            driver.FindElement(SearchForBusinessOnList).Click();
            Thread.Sleep(2000);
            driver.FindElement(SearchForBusinessOnList).SendKeys("Test Cafe");
            Thread.Sleep(1000);
            driver.FindElement(SearchForBusinessOnList).SendKeys(Keys.Enter);
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

        public void OutOfAreaBusiness()
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
            //Fill mandatory fields
            driver.FindElement(NewBusinessName).Click();
            Thread.Sleep(1000);
            Actions action = new Actions(driver);
            WebElement ele = (WebElement)driver.FindElement(NewBusinessName);
            action.Click(ele).Click(ele).Click(ele).Perform();
            driver.FindElement(NewBusinessName).SendKeys(Keys.Delete);
            driver.FindElement(NewBusinessName).SendKeys("AAA");
            //Address
            driver.SwitchTo().Frame(driver.FindElement(By.Id("WebResource_WMDCCustomerAddressSearch")));
            Thread.Sleep(1000);
            driver.FindElement(NewBusinessAddress).Click();
            driver.FindElement(NewBusinessAddress).SendKeys("80 Spring Avenue Ashby-De-La-Zouch LE65 2RB");
            driver.FindElement(NewBusinessAddress).SendKeys(Keys.Enter);
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
            driver.FindElement(NewBusinessSaveBtn).Click();
            Thread.Sleep(7000);
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
                    driver.FindElement(NewBusinessOnList).Click();
                    Thread.Sleep(2000);
                }
            }
            catch (Exception)
            {
                if (driver.FindElement(NewBusinessTitle).Displayed)
                {
                    Console.WriteLine("No duplicates found");
                }
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
            wait.Until(ExpectedConditions.ElementExists((By)AddressResultOnTable1));
            Assert.IsTrue(driver.FindElement(AddressResultOnTable1).Displayed);
            //Close pop up
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            Thread.Sleep(2000);
            driver.Close();
            //Click Business on LHN
            driver.SwitchTo().Window(driver.WindowHandles.First());
            driver.SwitchTo().DefaultContent();
            wait.Until(ExpectedConditions.ElementExists((By)BusinessesLHN));
            driver.FindElement(BusinessesLHN).Click();
            wait.Until(ExpectedConditions.ElementExists((By)ActiveAccountsList));
            Thread.Sleep(1000);
            Assert.IsTrue(driver.FindElement(ActiveAccountsList).Displayed);
            Thread.Sleep((1000));
            //Click on new business
            driver.FindElement(NewBusinessOnList).Click();
            Thread.Sleep((2000));
            wait.Until(ExpectedConditions.ElementExists((By)NewBusinessTitle));
            Assert.IsTrue(driver.FindElement(NewBusinessTitle).Displayed);
            //Delete business
            driver.FindElement(DeleteOnProfile).Click();
            wait.Until(ExpectedConditions.ElementExists((By)DeleteOnProfileOverlay));
            Thread.Sleep(1000);
            driver.FindElement(DeleteOnProfileOverlay).Click();
            Thread.Sleep((4000));
            //add verification that business is deleted
            wait.Until(ExpectedConditions.ElementExists((By)ActiveAccountsList));
            Assert.IsTrue(driver.FindElement(ActiveAccountsList).Displayed);
            Thread.Sleep((2000));
            //verify business not present
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
                    Console.WriteLine("User not removed");
                }
                else
                {
                    Console.WriteLine("User removed");
                }
            }

        }

        public void ContinueWithCustomerBusiness()
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
            Assert.IsTrue(driver.FindElement(NewBusinessForm).Displayed);
            //Business name
            driver.FindElement(NewBusinessName).Click();
            Thread.Sleep(1000);
            Actions action = new Actions(driver);
            WebElement ele = (WebElement)driver.FindElement(NewBusinessName);
            action.Click(ele).Click(ele).Click(ele).Perform();
            driver.FindElement(NewBusinessName).SendKeys(Keys.Delete);
            driver.FindElement(NewBusinessName).SendKeys("AAA");
            //Email address
            driver.FindElement(NewBusinessEmail).Click();
            Thread.Sleep(1000);
            driver.FindElement(NewBusinessEmail).Clear();
            driver.FindElement(NewBusinessEmail).SendKeys("Testing@testing.com");
            Thread.Sleep(1000);
            //Address
            driver.SwitchTo().Frame(driver.FindElement(By.Id("WebResource_WMDCCustomerAddressSearch")));
            driver.FindElement(NewBusinessAddress).Click();
            driver.FindElement(NewBusinessAddress).SendKeys("4 Sandhill Rise Pontefract WF8 1RA");
            driver.FindElement(NewBusinessAddress).SendKeys(Keys.Enter);
            wait.Until(ExpectedConditions.ElementExists((By)NewBusinessAddressDropdown));
            driver.FindElement(NewBusinessAddressDropdown).Click();
            driver.SwitchTo().DefaultContent();
            //Click save btn
            driver.FindElement(NewBusinessSaveBtn).Click();
            Thread.Sleep((5000));
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
                    driver.FindElement(NewBusinessOnList).Click();
                    Thread.Sleep(9000);
                }
            }
            catch (Exception)
            {
                if (driver.FindElement(NewBusinessTitle).Displayed)
                {
                    Console.WriteLine("No duplicates found");
                }
            }
            //Click continue with customer button
            Thread.Sleep(2000);
            driver.SwitchTo().Frame(driver.FindElement(By.Id("WebResource_ContinueWithNewBusiness")));
            Thread.Sleep(2000);
            driver.FindElement(ContinueWithCustomer).Click();
            Thread.Sleep(2000);
            //Verify dashboard is displayed
            wait.Until(ExpectedConditions.ElementExists((By)DashboardTitle));
            Assert.IsTrue(driver.FindElement(DashboardTitle).Displayed);
            //Check customer details on dashboard
            driver.SwitchTo().Frame(driver.FindElement(By.Id("9532b1de-41a1-456c-b21c-805faca15573_WebResource_customeradvisorstart")));
            wait.Until(ExpectedConditions.ElementExists((By)NewBusinessInAccessChannel));
            Assert.IsTrue(driver.FindElement(NewBusinessInAccessChannel).Displayed);
            wait.Until(ExpectedConditions.ElementExists((By)AccessChannelCustomerDetails));
            Assert.IsTrue(driver.FindElement(AccessChannelCustomerDetails).Displayed);
            wait.Until(ExpectedConditions.ElementExists((By)BusinessAddressInAccessChannel2));
            Assert.IsTrue(driver.FindElement(BusinessAddressInAccessChannel2).Displayed);
            wait.Until(ExpectedConditions.ElementExists((By)CustomerEmailInAccessChannel1));
            Assert.IsTrue(driver.FindElement(CustomerEmailInAccessChannel1).Displayed);
            wait.Until(ExpectedConditions.ElementExists((By)CaseHistoryInAccessChannel));
            Assert.IsTrue(driver.FindElement(CaseHistoryInAccessChannel).Displayed);
            //Click Business name in access channel
            driver.FindElement(NewBusinessInAccessChannel).Click();
            driver.SwitchTo().DefaultContent();
            wait.Until(ExpectedConditions.ElementExists((By)NewBusinessTitle));
            //Delete business
            wait.Until(ExpectedConditions.ElementExists((By)DeleteOnProfile));
            driver.FindElement(DeleteOnProfile).Click();
            wait.Until(ExpectedConditions.ElementExists((By)DeleteOnProfileOverlay));
            Thread.Sleep(1000);
            driver.FindElement(DeleteOnProfileOverlay).Click();
            Thread.Sleep((4000));
            //add verification that business is deleted
            wait.Until(ExpectedConditions.ElementExists((By)BusinessesLHN));
            driver.FindElement(BusinessesLHN).Click();
            wait.Until(ExpectedConditions.ElementExists((By)ActiveAccountsList));
            Assert.IsTrue(driver.FindElement(ActiveAccountsList).Displayed);
            Thread.Sleep((2000));
            //verify business not present
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
                    Console.WriteLine("User not removed");
                }
                else
                {
                    Console.WriteLine("User removed");
                }
            }
        }

        public void ContinueWithBusinessManualAddress()
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
            Assert.IsTrue(driver.FindElement(NewBusinessForm).Displayed);
            //Business name
            driver.FindElement(NewBusinessName).Click();
            Thread.Sleep(1000);
            Actions action = new Actions(driver);
            WebElement ele = (WebElement)driver.FindElement(NewBusinessName);
            action.Click(ele).Click(ele).Click(ele).Perform();
            driver.FindElement(NewBusinessName).SendKeys(Keys.Delete);
            driver.FindElement(NewBusinessName).SendKeys("AAA");
            //Click can't find address link
            driver.SwitchTo().Frame(driver.FindElement(By.Id("WebResource_WMDCCustomerAddressSearch")));
            wait.Until(ExpectedConditions.ElementExists((By)CantFindAddressLink));
            driver.FindElement(CantFindAddressLink).Click();
            Thread.Sleep(2000);
            driver.SwitchTo().DefaultContent();
            //Click I understand on overlay
            wait.Until(ExpectedConditions.ElementExists((By)UnderstandBtnOnOverlay));
            driver.FindElement(UnderstandBtnOnOverlay).Click();
            Thread.Sleep(2000);
            //add address manually
            driver.SwitchTo().Frame(driver.FindElement(By.Id("WebResource_WMDCCustomerAddressSearch")));
            Thread.Sleep(1000);
            driver.FindElement(ManualAddressHouseNumber).Click();
            driver.FindElement(ManualAddressHouseNumber).SendKeys("4");
            Thread.Sleep(1000);
            driver.FindElement(ManualAddressStreetName).Click();
            driver.FindElement(ManualAddressStreetName).SendKeys("Sandhill Rise");
            Thread.Sleep(1000);
            driver.FindElement(ManualAddressTown).Click();
            driver.FindElement(ManualAddressTown).SendKeys("Pontefract");
            Thread.Sleep(1000);
            driver.FindElement(ManualAddressPostcode).Click();
            driver.FindElement(ManualAddressPostcode).SendKeys("WF8 1RA");
            Thread.Sleep(1000);
            driver.FindElement(ConfirmManualAdressBtn).Click();
            driver.SwitchTo().DefaultContent();
            //Click save btn
            driver.FindElement(NewBusinessSaveBtn).Click();
            Thread.Sleep((5000));
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
                    driver.FindElement(NewBusinessOnList).Click();
                    Thread.Sleep(9000);
                }
            }
            catch (Exception)
            {
                if (driver.FindElement(NewBusinessTitle).Displayed)
                {
                    Console.WriteLine("No duplicates found");
                }
            }
            //Click continue with customer button
            Thread.Sleep(2000);
            driver.SwitchTo().Frame(driver.FindElement(By.Id("WebResource_ContinueWithNewBusiness")));
            Thread.Sleep(2000);
            driver.FindElement(ContinueWithCustomer).Click();
            Thread.Sleep(2000);
            //Verify dashboard is displayed
            wait.Until(ExpectedConditions.ElementExists((By)DashboardsLHN));
            driver.FindElement(DashboardsLHN).Click();
            wait.Until(ExpectedConditions.ElementExists((By)DashboardTitle));
            Thread.Sleep(5000);
            //Check business details on dashboard
            driver.SwitchTo().Frame(driver.FindElement(By.Id("9532b1de-41a1-456c-b21c-805faca15573_WebResource_customeradvisorstart")));
            wait.Until(ExpectedConditions.ElementExists((By)NewBusinessInAccessChannel));
            Assert.IsTrue(driver.FindElement(NewBusinessInAccessChannel).Displayed);
            wait.Until(ExpectedConditions.ElementExists((By)AccessChannelCustomerDetails));
            Assert.IsTrue(driver.FindElement(AccessChannelCustomerDetails).Displayed);
            wait.Until(ExpectedConditions.ElementExists((By)BusinessAddressInAccessChannel));
            Assert.IsTrue(driver.FindElement(BusinessAddressInAccessChannel).Displayed);
            wait.Until(ExpectedConditions.ElementExists((By)CaseHistoryInAccessChannel));
            Assert.IsTrue(driver.FindElement(CaseHistoryInAccessChannel).Displayed);
            //Click Business name in access channel
            driver.FindElement(NewBusinessInAccessChannel).Click();
            driver.SwitchTo().DefaultContent();
            wait.Until(ExpectedConditions.ElementExists((By)NewBusinessTitle));
            //Delete business
            wait.Until(ExpectedConditions.ElementExists((By)DeleteOnProfile));
            driver.FindElement(DeleteOnProfile).Click();
            wait.Until(ExpectedConditions.ElementExists((By)DeleteOnProfileOverlay));
            Thread.Sleep(1000);
            driver.FindElement(DeleteOnProfileOverlay).Click();
            Thread.Sleep((4000));
            //add verification that business is deleted
            wait.Until(ExpectedConditions.ElementExists((By)BusinessesLHN));
            driver.FindElement(BusinessesLHN).Click();
            wait.Until(ExpectedConditions.ElementExists((By)ActiveAccountsList));
            Assert.IsTrue(driver.FindElement(ActiveAccountsList).Displayed);
            Thread.Sleep((2000));
            //verify business not present
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
                    Console.WriteLine("User not removed");
                }
                else
                {
                    Console.WriteLine("User removed");
                }
            }
        }

        public void AddBusinessManualAddress()
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
            //Business name
            driver.FindElement(NewBusinessName).Click();
            Thread.Sleep(1000);
            Actions action = new Actions(driver);
            WebElement ele = (WebElement)driver.FindElement(NewBusinessName);
            action.Click(ele).Click(ele).Click(ele).Perform();
            driver.FindElement(NewBusinessName).SendKeys(Keys.Delete);
            driver.FindElement(NewBusinessName).SendKeys("AAA");
            //Address
            driver.SwitchTo().Frame(driver.FindElement(By.Id("WebResource_WMDCCustomerAddressSearch")));
            Thread.Sleep(1000);
            driver.FindElement(NewBusinessAddress).Click();
            driver.FindElement(NewBusinessAddress).SendKeys("80 Spring Avenue Ashby-De-La-Zouch LE65 2RB");
            driver.FindElement(NewBusinessAddress).SendKeys(Keys.Enter);
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
            driver.FindElement(NewBusinessSaveBtn).Click();
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
                    wait.Until(ExpectedConditions.ElementExists((By)MergeBusinessOverlay));
                    Thread.Sleep(2000);
                    driver.FindElement(MergeCustomersOverlayButton).Click();
                    Thread.Sleep(2000);
                    driver.FindElement(BusinessesLHN).Click();
                    Thread.Sleep(2000);
                    driver.FindElement(NewBusinessOnList).Click();
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
            //Click Business on LHN
            driver.SwitchTo().Window(driver.WindowHandles.First());
            driver.SwitchTo().DefaultContent();
            driver.FindElement(BusinessesLHN).Click();
            wait.Until(ExpectedConditions.ElementExists((By)ActiveAccountsList));
            Thread.Sleep(1000);
            driver.FindElement(NewBusinessOnList).Click();
            Thread.Sleep((2000));
            Assert.IsTrue(driver.FindElement(NewBusinessTitle).Displayed);
            //Delete business
            wait.Until(ExpectedConditions.ElementExists((By)DeleteOnProfile));
            driver.FindElement(DeleteOnProfile).Click();
            wait.Until(ExpectedConditions.ElementExists((By)DeleteOnProfileOverlay));
            driver.FindElement(DeleteOnProfileOverlay).Click();
            Thread.Sleep((5000));
            //add verification that user is deleted
            wait.Until(ExpectedConditions.ElementExists((By)BusinessesLHN));
            driver.FindElement(BusinessesLHN).Click();
            Thread.Sleep((2000));
            wait.Until(ExpectedConditions.ElementExists((By)ActiveAccountsList));
            Assert.IsTrue(driver.FindElement(ActiveAccountsList).Displayed);
            Thread.Sleep((2000));
            //verify business not present
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

        public void AddNewBusinessUnknownAddress()
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
            //Business name
            wait.Until(ExpectedConditions.ElementExists((By)NewBusinessName));
            driver.FindElement(NewBusinessName).Click();
            Thread.Sleep(1000);
            Actions action = new Actions(driver);
            WebElement ele = (WebElement)driver.FindElement(NewBusinessName);
            action.Click(ele).Click(ele).Click(ele).Perform();
            driver.FindElement(NewBusinessName).SendKeys(Keys.Delete);
            driver.FindElement(NewBusinessName).SendKeys("AAA");
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
            driver.FindElement(NewBusinessSaveandClose).Click();
            Thread.Sleep(4000);
            //Duplicate record check
            try
            {
                if (driver.FindElement(DuplicateRecordOverlay).Displayed)
                {
                    Thread.Sleep(2000);
                    driver.FindElement(IgnoreAndSave).Click();
                    Thread.Sleep(2000);
                    wait.Until(ExpectedConditions.ElementExists((By)BusinessesLHN));
                    Thread.Sleep(2000);
                    driver.FindElement(BusinessesLHN).Click();
                    Thread.Sleep(2000);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("No duplicates found");
            }
            wait.Until(ExpectedConditions.ElementExists((By)ActiveAccountsList));
            Thread.Sleep(1000);
            Assert.IsTrue(driver.FindElement(ActiveAccountsList).Displayed);
            Thread.Sleep((1000));
            //Slect business on active customer list
            driver.FindElement(NewBusinessOnList).Click();
            wait.Until(ExpectedConditions.ElementExists((By)NewBusinessTitle));
            Assert.IsTrue(driver.FindElement(NewBusinessTitle).Displayed);
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
            wait.Until(ExpectedConditions.ElementExists((By)NewBusinessTitle));
            //Delete business
            wait.Until(ExpectedConditions.ElementExists((By)DeleteOnProfile));
            driver.FindElement(DeleteOnProfile).Click();
            wait.Until(ExpectedConditions.ElementExists((By)DeleteOnProfileOverlay));
            driver.FindElement(DeleteOnProfileOverlay).Click();
            Thread.Sleep((5000));
            //add verification that user is deleted
            wait.Until(ExpectedConditions.ElementExists((By)BusinessesLHN));
            driver.FindElement(BusinessesLHN).Click();
            Thread.Sleep((2000));
            wait.Until(ExpectedConditions.ElementExists((By)ActiveAccountsList));
            Assert.IsTrue(driver.FindElement(ActiveAccountsList).Displayed);
            Thread.Sleep((2000));
            //verify business not present
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

        public void ContinueWithBusinessUnknownAddress()
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
            Assert.IsTrue(driver.FindElement(NewBusinessForm).Displayed);
            //Business name
            driver.FindElement(NewBusinessName).Click();
            Thread.Sleep(1000);
            Actions action = new Actions(driver);
            WebElement ele = (WebElement)driver.FindElement(NewBusinessName);
            action.Click(ele).Click(ele).Click(ele).Perform();
            driver.FindElement(NewBusinessName).SendKeys(Keys.Delete);
            driver.FindElement(NewBusinessName).SendKeys("AAA");
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
            driver.FindElement(NewBusinessSaveBtn).Click();
            Thread.Sleep((5000));
            //Duplicate record check
            try
            {
                if (driver.FindElement(DuplicateRecordOverlay).Displayed)
                {
                    Thread.Sleep(2000);
                    driver.FindElement(IgnoreAndSave).Click();
                    Thread.Sleep(2000);
                    wait.Until(ExpectedConditions.ElementExists((By)BusinessesLHN));
                    Thread.Sleep(2000);
                    driver.FindElement(BusinessesLHN).Click();
                    Thread.Sleep(2000);
                    wait.Until(ExpectedConditions.ElementExists((By)NewBusinessOnList));
                    driver.FindElement(NewBusinessOnList).Click();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("No duplicates found");
            }
            //Click continue with customer button
            Thread.Sleep(4000);
            driver.SwitchTo().Frame(driver.FindElement(By.Id("WebResource_ContinueWithNewBusiness")));
            Thread.Sleep(2000);
            driver.FindElement(ContinueWithCustomer).Click();
            Thread.Sleep(2000);
            //Verify dashboard is displayed
            wait.Until(ExpectedConditions.ElementExists((By)DashboardsLHN));
            driver.FindElement(DashboardsLHN).Click();
            wait.Until(ExpectedConditions.ElementExists((By)DashboardTitle));
            Thread.Sleep(5000);
            //Check business details on dashboard
            driver.SwitchTo().Frame(driver.FindElement(By.Id("9532b1de-41a1-456c-b21c-805faca15573_WebResource_customeradvisorstart")));
            wait.Until(ExpectedConditions.ElementExists((By)NewBusinessInAccessChannel));
            Assert.IsTrue(driver.FindElement(NewBusinessInAccessChannel).Displayed);
            wait.Until(ExpectedConditions.ElementExists((By)AccessChannelCustomerDetails));
            Assert.IsTrue(driver.FindElement(AccessChannelCustomerDetails).Displayed);
            wait.Until(ExpectedConditions.ElementExists((By)UnknownBusinessAddressInAccessChannel));
            Assert.IsTrue(driver.FindElement(UnknownBusinessAddressInAccessChannel).Displayed);
            wait.Until(ExpectedConditions.ElementExists((By)CaseHistoryInAccessChannel));
            Assert.IsTrue(driver.FindElement(CaseHistoryInAccessChannel).Displayed);
            //Click Business name in access channel
            driver.FindElement(NewBusinessInAccessChannel).Click();
            driver.SwitchTo().DefaultContent();
            wait.Until(ExpectedConditions.ElementExists((By)NewBusinessTitle));
            //Delete business
            wait.Until(ExpectedConditions.ElementExists((By)DeleteOnProfile));
            driver.FindElement(DeleteOnProfile).Click();
            wait.Until(ExpectedConditions.ElementExists((By)DeleteOnProfileOverlay));
            Thread.Sleep(1000);
            driver.FindElement(DeleteOnProfileOverlay).Click();
            Thread.Sleep((4000));
            //add verification that business is deleted
            wait.Until(ExpectedConditions.ElementExists((By)BusinessesLHN));
            driver.FindElement(BusinessesLHN).Click();
            wait.Until(ExpectedConditions.ElementExists((By)ActiveAccountsList));
            Assert.IsTrue(driver.FindElement(ActiveAccountsList).Displayed);
            Thread.Sleep((2000));
            //verify business not present
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
                    Console.WriteLine("User not removed");
                }
                else
                {
                    Console.WriteLine("User removed");
                }
            }
        }

        public void DuplicateBusiness()
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
            //Create new Business
            wait.Until(ExpectedConditions.ElementExists((By)NewBusinessButton));
            driver.FindElement(NewBusinessButton).Click();
            wait.Until(ExpectedConditions.ElementExists((By)NewBusinessForm));
            Assert.IsTrue(driver.FindElement(NewBusinessForm).Displayed);
            //Business name
            wait.Until(ExpectedConditions.ElementExists((By)NewBusinessName));
            driver.FindElement(NewBusinessName).Click();
            Thread.Sleep(1000);
            WebElement ele = (WebElement)driver.FindElement(NewBusinessName);
            Actions action = new Actions(driver);
            action.Click(ele).Click(ele).Click(ele).Perform();
            driver.FindElement(NewBusinessName).SendKeys(Keys.Delete);
            driver.FindElement(NewBusinessName).SendKeys("AAA");
            //Phone Number
            wait.Until(ExpectedConditions.ElementExists((By)NewBusinessPhone));
            driver.FindElement(NewBusinessPhone).Click();
            Thread.Sleep(1000);
            driver.FindElement(NewBusinessPhone).SendKeys("0000");
            //Email Address
            wait.Until(ExpectedConditions.ElementExists((By)NewBusinessEmail));
            driver.FindElement(NewBusinessEmail).Click();
            Thread.Sleep(1000);
            driver.FindElement(NewBusinessEmail).SendKeys("test@tester.com");
            //Address
            driver.SwitchTo().Frame(driver.FindElement(By.Id("WebResource_WMDCCustomerAddressSearch")));
            Thread.Sleep(1000);
            driver.FindElement(NewBusinessAddress).Click();
            driver.FindElement(NewBusinessAddress).SendKeys("4 Sandhill Rise Pontefract WF8 1RA");
            driver.FindElement(NewBusinessAddress).SendKeys(Keys.Enter);
            wait.Until(ExpectedConditions.ElementExists((By)NewBusinessAddressDropdown));
            driver.FindElement(NewBusinessAddressDropdown).Click();
            driver.SwitchTo().DefaultContent();
            //Click Save and close
            wait.Until(ExpectedConditions.ElementExists((By)NewBusinessSaveandClose));
            driver.FindElement(NewBusinessSaveandClose).Click();
            Thread.Sleep(3000);
            wait.Until(ExpectedConditions.ElementExists((By)ActiveAccountsList));
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
                if (driver.FindElement(ActiveAccountsList).Displayed)
                {
                    Console.WriteLine("No duplicates found");
                }
            }
            //Create new Business
            wait.Until(ExpectedConditions.ElementExists((By)NewBusinessButton));
            driver.FindElement(NewBusinessButton).Click();
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)NewBusinessForm));
            Assert.IsTrue(driver.FindElement(NewBusinessForm).Displayed);
            //Business name
            wait.Until(ExpectedConditions.ElementExists((By)NewBusinessName));
            driver.FindElement(NewBusinessName).Click();
            Thread.Sleep(1000);
            ele = (WebElement)driver.FindElement(NewBusinessName);
            action.Click(ele).Click(ele).Click(ele).Perform();
            driver.FindElement(NewBusinessName).SendKeys(Keys.Delete);
            driver.FindElement(NewBusinessName).SendKeys("AAA");
            //Address
            driver.SwitchTo().Frame(driver.FindElement(By.Id("WebResource_WMDCCustomerAddressSearch")));
            Thread.Sleep(1000);
            driver.FindElement(NewBusinessAddress).Click();
            driver.FindElement(NewBusinessAddress).SendKeys("4 Sandhill Rise Pontefract WF8 1RA");
            driver.FindElement(NewBusinessAddress).SendKeys(Keys.Enter);
            wait.Until(ExpectedConditions.ElementExists((By)NewBusinessAddressDropdown));
            driver.FindElement(NewBusinessAddressDropdown).Click();
            driver.SwitchTo().DefaultContent();
            //Click Save and close
            wait.Until(ExpectedConditions.ElementExists((By)NewBusinessSaveandClose));
            driver.FindElement(NewBusinessSaveandClose).Click();
            Thread.Sleep(3000);
            wait.Until(ExpectedConditions.ElementExists((By)DuplicateRecordOverlay));
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
                if (driver.FindElement(ActiveAccountsList).Displayed)
                {
                    Console.WriteLine("No duplicates found");
                    Assert.Fail();
                }
            }
            //Business name
            wait.Until(ExpectedConditions.ElementExists((By)NewBusinessName));
            driver.FindElement(NewBusinessName).Click();
            Thread.Sleep(1000);
            ele = (WebElement)driver.FindElement(NewBusinessName);
            action.Click(ele).Click(ele).Click(ele).Perform();
            driver.FindElement(NewBusinessName).SendKeys(Keys.Delete);
            driver.FindElement(NewBusinessName).SendKeys("AAA");
            //Email Address
            wait.Until(ExpectedConditions.ElementExists((By)NewBusinessEmail));
            driver.FindElement(NewBusinessEmail).Click();
            Thread.Sleep(1000);
            driver.FindElement(NewBusinessEmail).SendKeys("test@tester.com");
            //Address
            driver.SwitchTo().Frame(driver.FindElement(By.Id("WebResource_WMDCCustomerAddressSearch")));
            Thread.Sleep(1000);
            driver.FindElement(NewBusinessAddress).Click();
            ele = (WebElement)driver.FindElement(NewBusinessAddress);
            action.Click(ele).Click(ele).Click(ele).Perform();
            driver.FindElement(NewBusinessAddress).SendKeys(Keys.Delete);
            driver.FindElement(NewBusinessAddress).SendKeys("4 Sandhill Rise Pontefract WF8 1RA");
            driver.FindElement(NewBusinessAddress).SendKeys(Keys.Enter);
            wait.Until(ExpectedConditions.ElementExists((By)NewBusinessAddressDropdown));
            driver.FindElement(NewBusinessAddressDropdown).Click();
            driver.SwitchTo().DefaultContent();
            //Click Save and close
            wait.Until(ExpectedConditions.ElementExists((By)NewBusinessSaveandClose));
            driver.FindElement(NewBusinessSaveandClose).Click();
            Thread.Sleep(3000);
            wait.Until(ExpectedConditions.ElementExists((By)DuplicateRecordOverlay));
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
                if (driver.FindElement(ActiveAccountsList).Displayed)
                {
                    Console.WriteLine("No duplicates found");
                    Assert.Fail();
                }
            }
            //Business name
            wait.Until(ExpectedConditions.ElementExists((By)NewBusinessName));
            driver.FindElement(NewBusinessName).Click();
            Thread.Sleep(1000);
            ele = (WebElement)driver.FindElement(NewBusinessName);
            action.Click(ele).Click(ele).Click(ele).Perform();
            driver.FindElement(NewBusinessName).SendKeys(Keys.Delete);
            driver.FindElement(NewBusinessName).SendKeys("AAA");
            //Phone Number
            wait.Until(ExpectedConditions.ElementExists((By)NewBusinessPhone));
            driver.FindElement(NewBusinessPhone).Click();
            Thread.Sleep(1000);
            driver.FindElement(NewBusinessPhone).SendKeys("1111");
            //Address
            driver.SwitchTo().Frame(driver.FindElement(By.Id("WebResource_WMDCCustomerAddressSearch")));
            Thread.Sleep(1000);
            driver.FindElement(NewBusinessAddress).Click();
            ele = (WebElement)driver.FindElement(NewBusinessAddress);
            action.Click(ele).Click(ele).Click(ele).Perform();
            driver.FindElement(NewBusinessAddress).SendKeys(Keys.Delete);
            driver.FindElement(NewBusinessAddress).SendKeys("14 Sandhill Rise Pontefract WF8 1RA");
            driver.FindElement(NewBusinessAddress).SendKeys(Keys.Enter);
            wait.Until(ExpectedConditions.ElementExists((By)NewBusinessAddressDropdown));
            driver.FindElement(NewBusinessAddressDropdown).Click();
            driver.SwitchTo().DefaultContent();
            //Click Save and close
            wait.Until(ExpectedConditions.ElementExists((By)NewBusinessSaveandClose));
            driver.FindElement(NewBusinessSaveandClose).Click();
            Thread.Sleep(3000);
            wait.Until(ExpectedConditions.ElementExists((By)ActiveAccountsList));
            //Duplicate record check
            try
            {
                if (driver.FindElement(DuplicateRecordOverlay).Displayed)
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                if (driver.FindElement(ActiveAccountsList).Displayed)
                {
                    Console.WriteLine("No duplicates found");
                }
            }
            //Delete business
            wait.Until(ExpectedConditions.ElementExists((By)NewBusinessOnList));
            driver.FindElement(NewBusinessOnList).Click();
            wait.Until(ExpectedConditions.ElementExists((By)DeleteOnProfile));
            Thread.Sleep(3000);
            driver.FindElement(DeleteOnProfile).Click();
            wait.Until(ExpectedConditions.ElementExists((By)DeleteOnProfileOverlay));
            driver.FindElement(DeleteOnProfileOverlay).Click();
            Thread.Sleep(3000);
            wait.Until(ExpectedConditions.ElementExists((By)ActiveAccountsList));
            //Verify business deleted
            var Business = 0;
            try
            {

                WebElement business = (WebElement)driver.FindElement(NewBusinessOnList);
                if (business.Displayed)
                {
                    Business = 1;
                    throw new Exception();
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
            //Create new Business
            wait.Until(ExpectedConditions.ElementExists((By)NewBusinessButton));
            driver.FindElement(NewBusinessButton).Click();
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)NewBusinessForm));
            Assert.IsTrue(driver.FindElement(NewBusinessForm).Displayed);
            //Business name
            wait.Until(ExpectedConditions.ElementExists((By)NewBusinessName));
            driver.FindElement(NewBusinessName).Click();
            Thread.Sleep(1000);
            ele = (WebElement)driver.FindElement(NewBusinessName);
            action.Click(ele).Click(ele).Click(ele).Perform();
            driver.FindElement(NewBusinessName).SendKeys(Keys.Delete);
            driver.FindElement(NewBusinessName).SendKeys("BBB");
            //Address
            driver.SwitchTo().Frame(driver.FindElement(By.Id("WebResource_WMDCCustomerAddressSearch")));
            Thread.Sleep(1000);
            driver.FindElement(NewBusinessAddress).Click();
            driver.FindElement(NewBusinessAddress).SendKeys("5 Sandhill Rise Pontefract WF8 1RA");
            driver.FindElement(NewBusinessAddress).SendKeys(Keys.Enter);
            wait.Until(ExpectedConditions.ElementExists((By)NewBusinessAddressDropdown2));
            driver.FindElement(NewBusinessAddressDropdown2).Click();
            driver.SwitchTo().DefaultContent();
            //Click Save and close
            wait.Until(ExpectedConditions.ElementExists((By)NewBusinessSaveandClose));
            driver.FindElement(NewBusinessSaveandClose).Click();
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
                if (driver.FindElement(ActiveAccountsList).Displayed)
                {
                    Console.WriteLine("No duplicates found");
                }
            }
            //Select user from list
            wait.Until(ExpectedConditions.ElementExists((By)ActiveAccountsList));
            Thread.Sleep(4000);
            wait.Until(ExpectedConditions.ElementExists((By)TestCafeOnList));
            driver.FindElement(TestCafeOnList).Click();
            //Verify customer profile loads
            wait.Until(ExpectedConditions.ElementExists((By)TestCafeTitle));
            Assert.IsTrue(driver.FindElement(TestCafeTitle).Displayed);
            //Click deactivate
            wait.Until(ExpectedConditions.ElementExists((By)ProfileDeactivate));
            driver.FindElement(ProfileDeactivate).Click();
            wait.Until(ExpectedConditions.ElementExists((By)ProfileDeactivateConfirm));
            driver.FindElement(ProfileDeactivateConfirm).Click();
            Thread.Sleep(2000);
            //Navigate to business list
            wait.Until(ExpectedConditions.ElementExists((By)BusinessesLHN));
            Thread.Sleep(2000);
            driver.FindElement(BusinessesLHN).Click();
            //Create new Business
            wait.Until(ExpectedConditions.ElementExists((By)NewBusinessButton));
            Thread.Sleep(2000);
            driver.FindElement(NewBusinessButton).Click();
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)NewBusinessForm));
            Assert.IsTrue(driver.FindElement(NewBusinessForm).Displayed);
            //Verify new customer form loads
            wait.Until(ExpectedConditions.ElementExists((By)NewBusinessForm));
            //Business name
            wait.Until(ExpectedConditions.ElementExists((By)NewBusinessName));
            driver.FindElement(NewBusinessName).Click();
            Thread.Sleep(1000);
            ele = (WebElement)driver.FindElement(NewBusinessName);
            action.Click(ele).Click(ele).Click(ele).Perform();
            driver.FindElement(NewBusinessName).SendKeys(Keys.Delete);
            driver.FindElement(NewBusinessName).SendKeys("BBB");
            //Address
            driver.SwitchTo().Frame(driver.FindElement(By.Id("WebResource_WMDCCustomerAddressSearch")));
            Thread.Sleep(1000);
            driver.FindElement(NewBusinessAddress).Click();
            ele = (WebElement)driver.FindElement(NewBusinessAddress);
            action.Click(ele).Click(ele).Click(ele).Perform();
            driver.FindElement(NewBusinessAddress).SendKeys(Keys.Delete);
            driver.FindElement(NewBusinessAddress).SendKeys("5 Sandhill Rise Pontefract WF8 1RA");
            driver.FindElement(NewBusinessAddress).SendKeys(Keys.Enter);
            wait.Until(ExpectedConditions.ElementExists((By)NewBusinessAddressDropdown2));
            driver.FindElement(NewBusinessAddressDropdown2).Click();
            driver.SwitchTo().DefaultContent();
            //Click Save and close
            wait.Until(ExpectedConditions.ElementExists((By)NewBusinessSaveandClose));
            driver.FindElement(NewBusinessSaveandClose).Click();
            Thread.Sleep(3000);
            wait.Until(ExpectedConditions.ElementExists((By)ActiveAccountsList));
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
                if (driver.FindElement(ActiveAccountsList).Displayed)
                {
                    Console.WriteLine("No duplicates found");
                }
            }
            //Delete business
            wait.Until(ExpectedConditions.ElementExists((By)NewBusinessOnList2));
            driver.FindElement(NewBusinessOnList2).Click();
            wait.Until(ExpectedConditions.ElementExists((By)DeleteOnProfile));
            Thread.Sleep(2000);
            driver.FindElement(DeleteOnProfile).Click();
            wait.Until(ExpectedConditions.ElementExists((By)DeleteOnProfileOverlay));
            driver.FindElement(DeleteOnProfileOverlay).Click();
            Thread.Sleep(3000);
            wait.Until(ExpectedConditions.ElementExists((By)ActiveAccountsList));
            //Verify business deleted
            Business = 0;
            try
            {

                WebElement business = (WebElement)driver.FindElement(NewBusinessOnList2);
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

                //Delete business
                wait.Until(ExpectedConditions.ElementExists((By)NewBusinessOnList));
                driver.FindElement(NewBusinessOnList).Click();
                wait.Until(ExpectedConditions.ElementExists((By)DeleteOnProfile));
                Thread.Sleep(2000);
                driver.FindElement(DeleteOnProfile).Click();
                wait.Until(ExpectedConditions.ElementExists((By)DeleteOnProfileOverlay));
                driver.FindElement(DeleteOnProfileOverlay).Click();
                Thread.Sleep(3000);
                wait.Until(ExpectedConditions.ElementExists((By)ActiveAccountsList));
                //Verify business deleted
                Business = 0;
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
        }

        public void SortOrderBusinessTimeline()
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
            //Create new Business
            wait.Until(ExpectedConditions.ElementExists((By)NewBusinessButton));
            driver.FindElement(NewBusinessButton).Click();
            wait.Until(ExpectedConditions.ElementExists((By)NewBusinessForm));
            Assert.IsTrue(driver.FindElement(NewBusinessForm).Displayed);
            //Business name
            wait.Until(ExpectedConditions.ElementExists((By)NewBusinessName));
            driver.FindElement(NewBusinessName).Click();
            Thread.Sleep(1000);
            WebElement ele = (WebElement)driver.FindElement(NewBusinessName);
            Actions action = new Actions(driver);
            action.Click(ele).Click(ele).Click(ele).Perform();
            driver.FindElement(NewBusinessName).SendKeys(Keys.Delete);
            driver.FindElement(NewBusinessName).SendKeys("AAA");
            //Address
            driver.SwitchTo().Frame(driver.FindElement(By.Id("WebResource_WMDCCustomerAddressSearch")));
            Thread.Sleep(1000);
            driver.FindElement(NewBusinessAddress).Click();
            driver.FindElement(NewBusinessAddress).SendKeys("4 Sandhill Rise Pontefract WF8 1RA");
            driver.FindElement(NewBusinessAddress).SendKeys(Keys.Enter);
            wait.Until(ExpectedConditions.ElementExists((By)NewBusinessAddressDropdown));
            driver.FindElement(NewBusinessAddressDropdown).Click();
            driver.SwitchTo().DefaultContent();
            //Click Save and close
            wait.Until(ExpectedConditions.ElementExists((By)NewBusinessSaveBtn));
            driver.FindElement(NewBusinessSaveBtn).Click();
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
                    wait.Until(ExpectedConditions.ElementExists((By)MergeBusinessOverlay));
                    Thread.Sleep(2000);
                    driver.FindElement(MergeBusinessOverlay).Click();
                    Thread.Sleep(2000);
                    driver.FindElement(BusinessesLHN).Click();
                    Thread.Sleep(2000);
                    wait.Until(ExpectedConditions.ElementExists((By)ActiveAccountsList));
                    Thread.Sleep(1000);
                    Assert.IsTrue(driver.FindElement(ActiveAccountsList).Displayed);
                    Thread.Sleep((2000));
                    wait.Until(ExpectedConditions.ElementExists((By)NewBusinessOnList));
                    Thread.Sleep(1000);
                    Assert.IsTrue(driver.FindElement(NewBusinessOnList).Displayed);
                    driver.FindElement(NewBusinessOnList).Click();

                }
            }
            catch (Exception)
            {
                if (driver.FindElement(NewBusinessTitle).Displayed)
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
            //Delete business
            wait.Until(ExpectedConditions.ElementExists((By)DeleteOnProfile));
            Thread.Sleep(3000);
            driver.FindElement(DeleteOnProfile).Click();
            wait.Until(ExpectedConditions.ElementExists((By)DeleteOnProfileOverlay));
            driver.FindElement(DeleteOnProfileOverlay).Click();
            Thread.Sleep(3000);
            wait.Until(ExpectedConditions.ElementExists((By)ActiveAccountsList));
            //Verify business deleted
            var Business = 0;
            try
            {

                WebElement business = (WebElement)driver.FindElement(NewBusinessOnList);
                if (business.Displayed)
                {
                    Business = 1;
                    throw new Exception();
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
    }
}
