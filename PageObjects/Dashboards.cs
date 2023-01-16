using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace CRMRegressionPack.PageObjects
{
    public class Dashboards
    {
        By Title = By.XPath("//span[contains(text(),'Wakefield User App')]");
        By DashboardTitle = By.XPath("//span[contains(text(),'Wakefield Home')]");
        By Searchbox = By.XPath("//input[@id='txtCustomerSearch']");
        By SearchResult = By.XPath("//a[contains(text(),'AAA, Aaa')]");
        By SearchErrorMsg = By.XPath("//div[contains(text(),'No customers were found with the given criteria')]");
        By CustomersLHN = By.CssSelector("[Aria-label='Clients']");
        By DashboardsLHN = By.XPath("//span[contains(text(),'Dashboards')]");
        By ActiveContactsList = By.XPath("//span[contains(text(),'Active Contacts')]");
        By ExistingCustomerRecord = By.XPath("//h1[contains(text(),'AAA AAA')]");
        By ExistingCustomerEmail1 = By.XPath("//span[contains(text(),'Testing@testing.com')]");

        By NewCustomerButton = By.XPath("//span[contains(text(),'New')]");
        By NewCustomerForm = By.XPath("//h1[contains(text(),'New Customer')]");
        By NewCustomerFirstName = By.CssSelector("[aria-label='First Name']");
        By NewCustomerSurname = By.CssSelector("[Aria-label='Surname']");
        By NewCustomerAddress = By.XPath("//input[@placeholder='Search for an address']");
        By NewCustomerAddressDropdown = By.XPath("//option[contains(text(),'7 Sandhill Rise Pontefract WF8 1RA')]");
        By NewCustomerAddressDropdown1 = By.XPath("//option[contains(text(),'2 Sandhill Rise Pontefract WF8 1RA')]");
        By NewCustomerSaveandClose = By.XPath("//span[contains(text(),'Save & Close')]");
        By NewBusinessSaveBtn = By.XPath("//button[@aria-label='Save (CTRL+S)']//span[contains(text(),'Save')]");

        By ExistingCustomerSearchResult = By.XPath("//a[contains(text(),'Test Moore')]");
        By ExistingCustomerSearchDropdown = By.XPath("//a[contains(text(),'MOORE, Test 14 Pontefract Road Barnsley S71 1Aj')]");
        By AnonCustomerSearchDropdown = By.XPath("//a[.='ADDRESS, Unknown Unknown  (Tel: 07777777777)']");
        By CustomerNameInDropdown = By.XPath("//a[contains(text(),'MOORE, Gary 7 Sandhill Rise Pontefract WF8 1RA')]");
        By CustomerNameInAccessChannel = By.XPath("//a[normalize-space()='Gary Moore']");
        By ReportedByInAccessChannel = By.XPath("//div[@id='chosenReporterName']");
        By AnonAddressSearchResult = By.XPath("//a[contains(text(),'Unknown Address')]");
        By ManualAddressSearchDropdown = By.XPath("//a[contains(text(),'ADDRESS, Manual 80 SPRING AVENUE, ASHBY-DE-LA-ZOUC')]");
        By ManualAddressSearchResult = By.XPath("//a[contains(text(),'Manual Address')]");
        By OnBehalfOfInDropdown = By.XPath("//input[@type='checkbox']");
        By GaryTestInDropdown = By.XPath("//a[normalize-space()='TEST, Gary 6 Sandhill Rise Pontefract WF8 1RA']");
        By GaryTestInAccessChannel = By.XPath("//a[normalize-space()='Gary Test']");

        By ExistingBusinessSearchDropdown = By.XPath("//a[contains(text(),'Test Cafe 4 SANDHILL RISE, PONTEFRACT, WF8 1RA')]");
        By ModifiedBusinessSearchDropdown = By.XPath("//a[contains(text(),'Test Cafe')]");
        By ExistingBusinessSearchResult = By.XPath("//a[contains(text(),'Test Cafe')]");
        By NewCustomerAllowEmails = By.CssSelector("[title='Allow']");
        By NewCustomerNotAllowEmails = By.CssSelector("[title='Do Not Allow']");
        By TestCafeProfileTitle = By.XPath("//h1[@title='Test Cafe']");

        By HomeOnLHN = By.XPath("//span[contains(text(),'Home')]");
        By HomepageTitle = By.XPath("//span[contains(text(),'Wakefield Home')]");
        By SearchResultDeatils = By.XPath("//a[contains(text(),'AAA AAA')]");
        By CustomerInfoHeader = By.XPath("//h2[contains(text(),'CUSTOMER INFORMATION')]");
        By TestUserNameOnProfile = By.XPath("//h1[contains(text(),'Test Moore')]");
        By ManualAddressNameOnProfile = By.XPath("//h1[contains(text(),'Manual Address')]");

        By NewCustomerEmail = By.XPath("//input[@placeholder='Provide an email']");
        By NewCustomerOnList = By.XPath("//span[contains(text(),'AAA AAA')]");
        By NewCustomerEmailOnList1 = By.XPath("//span[contains(text(),'Testing@tester.com')]");
        By ActiveContactsDelete = By.XPath("//button[.='Delete']");
        By ActiveContactsDeleteOverlay = By.XPath("//body/section/div/div/div/div/div/div/div/button[1]");
        By DashboardSearchPanel = By.XPath("//div[@id='searchPanel']");

        By FAQSearchBox = By.XPath("//input[@placeholder='Enter keywords to search for a service or FAQ']");
        By FAQSearchServiceResult = By.XPath("//a[contains(text(),'MyAccount Help')]");
        By FAQSearchResult = By.XPath("//a[contains(text(),'Can I dispose of waste at the tips using a van')]");
        By FAQRecordAnswerGiven = By.XPath("//div[@id='faqSearchResults']/div[2]//a[.='Record as answer given']");
        By FAQAnswerRecorded = By.XPath("//span[contains(text(),'Answer has been recorded.')]");
        By FAQMoreInfo = By.XPath("//body/div[@id='container']/div[@id='searchPanel']/div[@id='faqSearchResults']/div[2]/div[1]/a[1]");
        By FAQMoreInfoPage = By.XPath("//h1[contains(text(),'Strategic Waste Disposal Partner')]");
        By FAQFoodAnswer = By.XPath("//a[contains(text(),'I would like to book myself on an Environmental He')]");
        By FAQRecordSignposted = By.XPath("//a[contains(text(),'Record as signposted')]");

        By DuplicateRecordOverlay = By.CssSelector("[aria-label='Duplicate records found']");
        By DuplicateRecordSelect = By.XPath("//section//section//section//section//div//div//div//div//div[2]//div[4]");
        By DuplicateRecordMerge = By.XPath("//button[.='Merge']");
        By MergeCustomersOverlay = By.XPath("//h1[.='Merge Customers']");
        By MergeCustomersOverlayButton = By.XPath("//span[.='OK']");

        By CreateNewContactOnDropdown = By.XPath("//a[contains(text(),'Create a new contact')]");
        By CreateCustomerOverlayYesBtn = By.XPath("//span[contains(text(),'Yes')]");

        By ServiceSearchResult = By.XPath("//a[contains(text(),'Dangerous Dog')]");
        By AccessChannelPopUpOk = By.XPath("//span[contains(text(),'OK')]");
        By AccessChannelDropdown = By.XPath("//select[@id='accessChannel']");
        By AccessChannelOptionPhone = By.XPath("//option[contains(text(),'Phone')]");
        By AccessChannelOptionEmail = By.XPath("//option[contains(text(),'Email')]");
        By AccessChannelOptionWeb = By.XPath("//option[contains(text(),'Web - Internal')]");
        By AccessChannelOptionFacebook = By.XPath("//option[contains(text(),'Facebook')]");
        By AccessChannelOptionTwitter = By.XPath("//option[contains(text(),'Twitter')]");
        By AccessChannelOptionPost = By.XPath("//option[contains(text(),'Post')]");
        By AccessChannelOptionFace = By.XPath("//option[contains(text(),'Face to face')]");
        By AccessChannelOptionME = By.XPath("//option[contains(text(),'ME Service')]");
        By SelectYesOnServiceOverlay = By.XPath("//span[contains(text(),'Yes')]");
        By ServiceForm = By.XPath("//h1[contains(text(),'Dangerous Dog Form')]");

        By AdvancedFindFilter = By.CssSelector(".AdvFind-symbol");
        By FilterLookFor = By.XPath("//td[@class='ms-crm-AdvFind-EntityList']");
        By LookForOptionOnDropdown = By.XPath("//option[contains(text(),'FAQ Activities')]");
        By ResultsIconOnLookForBanner = By.XPath("//span[@class='ms-cui-ctl-largelabel'][contains(text(),'Results')]");
        By ResultsCreatedOnColumn = By.XPath("//label[contains(text(),'Created On')]");
        By FAQResultOnTable = By.XPath("//table[@id='gridBodyTable']//tr[1]//a[@href='javascript:;']");

        By BlindAlert = By.XPath("//span[contains(text(),'B')]");
        By DeafAlert = By.XPath("//span[contains(text(),'D')]");
        By AbusiveAlert = By.XPath("//span[contains(text(),'A')]");
        By PersistentComplainerAlert = By.XPath("//span[contains(text(),'PC')]");
        By ManagingBehaviourAlert = By.XPath("//span[contains(text(),'MB')]");
        By TerryAlertDetailsOnDropdown = By.XPath("//a[contains(text(),'ALERT, Terry 32 Redhill Drive Castleford WF10 3AJ')]");
        By TerryAlertSearchResult = By.XPath("//a[contains(text(),'Terry Alert')]");
        By OOACasehistoryDetailsOnDropdown = By.XPath("//a[contains(text(),'CASEHISTORY, Ooa 6 Pontefract Road Barnsley S71 1A')]");
        By OOACasehistorySearchResult = By.XPath("//a[contains(text(),'Ooa Casehistory')]");
        By UADetailsOnDropdown = By.XPath("//a[@title='ADDRESS, Unknown - Unknown']");
        By UASearchResult = By.XPath("//a[contains(text(),'Unknown Address')]");

        By AnonCustomerOnNewCaseOverlay = By.XPath("//h2[contains(text(),'ANONYMOUS CUSTOMER')]");
        By ServiceOnNewCaseOverlay = By.XPath("//span[contains(text(),'Dog Fouling')]");
        By YesBtnOnNewCaseOverlay = By.XPath("//span[contains(text(),'Yes')]");
        By DogFoulingFormTitle = By.XPath("//h1[contains(text(),'Dog Fouling Form')]");
        By AddressSearchBox = By.XPath("//input[@placeholder='Search for an address']");
        By AddressSearchBtn = By.XPath("//button[@id='btnAddressSearch']");
        By AddressSearchBoxResult = By.XPath("//option[contains(text(),'6 Sandhill Rise Pontefract WF8 1RA')]");
        By DogFoulingLandType = By.CssSelector("[aria-label='Land Type']");
        By DogFoulingLandDropdown = By.XPath("//option[contains(text(),'Public')]");
        By ExactLocationTxt = By.XPath("//label[contains(text(),'Can you give us an exact location of the dog fouli')]");
        By DogFoulingExactLocation = By.CssSelector("[aria-label='Can you give us an exact location of the dog fouling?']");
        By DogFoulingRecurringProblem = By.CssSelector("[aria-label='Is this a recurring problem?']");
        By DogFoulingWhoDropdown = By.CssSelector("[aria-label='Do you know who is letting their dog foul?']");
        By DogFoulingWhoLabel = By.XPath("//label[contains(text(),'Do you know who is letting their dog foul?')]");
        By AllocateBtn = By.XPath("//button[contains(text(),'Allocate')]");

        By CasesOnLHN = By.XPath("//span[.='Cases']");
        By AnonCustomerOnCasesList = By.XPath("(//span[text()='ANONYMOUS CUSTOMER'])[1]");
        By ActiveCasesTitle = By.XPath("//span[contains(text(),'Active Cases')]");
        By DogSearchResult = By.XPath("//a[.='Dog Fouling']");

        By WasteCollectionsTab = By.XPath("//li[@title='Waste Collections']");
        By WasteCollectionDates = By.XPath("//h2[normalize-space()='Next bin collections dates for this customer']");

        By CustomerReporterOverlay = By.XPath("//h1[@aria-label='Customer same as Reporter']");
        By CustomerReporterOverlayOk = By.XPath("//button[@aria-label='OK']");
        By AccessChannelClear = By.XPath("//button[normalize-space()='Clear']");

        By UpdateAddressLink = By.XPath("//a[normalize-space()='Update this address?']");
        By UpdateAddressUndoBtn = By.XPath("//span//button[@type='button'][normalize-space()='Undo']");
        By NewBusinessAddress = By.XPath("//input[@placeholder='Search for an address']");
        By NewBusinessAddressDropdown = By.XPath("//option[contains(text(),'4 Sandhill Rise Pontefract WF8 1RA')]");
        By ModifiedBusinessAddress = By.XPath("//div[normalize-space()='4 Sandhill Rise Pontefract WF8 1RA']");
        By ModifiedBusinessAddressOOADropdown = By.XPath("//option[text()='18 Pontefract Road Barnsley S71 1Aj']");
        By ModifiedBusinessAddressOOA = By.XPath("//div[normalize-space()='18 Pontefract Road Barnsley S71 1Aj']");

        By CantFindAddressLink = By.XPath("//a[@id='lnkManualAddress']");
        By UnderstandBtnOnOverlay = By.XPath("//span[contains(text(),'I Understand')]");
        By ManualAddressHouseNumber = By.XPath("//input[@placeholder='House name/number']");
        By ManualAddressStreetName = By.XPath("//input[@placeholder='Street name']");
        By ManualAddressTown = By.XPath("//input[@placeholder='Town/city']");
        By ManualAddressPostcode = By.XPath("//input[@placeholder='Postcode']");
        By ConfirmManualAdressBtn = By.XPath("//button[@id='btnManualAddress']");

        By UnknownAddressLink = By.XPath("//a[contains(text(),'Unknown address?')]");
        By UnknownAdressSelected = By.XPath("//div[contains(text(),'Unknown')]");
        By PreviousAddressOnProfile = By.XPath("//div[@title='4 SANDHILL RISE, PONTEFRACT, WF8 1RA']");
        By HistoryTabOnCustomer = By.XPath("//li[contains(text(),'History')]");
        By PreviousBusinessAddresses = By.XPath("//h2[normalize-space()='PREVIOUS BUSINESS ADDRESSES']");
        By PreviousAddressInTable = By.XPath("//span[normalize-space()='18 Pontefract Road Barnsley S71 1Aj']");
        By AddressStartDateLabel = By.XPath("(//label[normalize-space()='Start Date'])[1]");
        By AddressEndDateLabel = By.XPath("(//label[normalize-space()='End Date'])[1]");
        By ModifiedBusinessAddressCaps = By.XPath("//div[normalize-space()='4 SANDHILL RISE, PONTEFRACT, WF8 1RA']");
        By TestBusinessInDropdown = By.XPath("//a[normalize-space()='Test Business 16 Pontefract Road Barnsley S71 1Aj']");
        By TestBusinessInAccessChannel = By.XPath("//a[normalize-space()='Test Business']");



        [ThreadStatic]
        IWebDriver driver;
        WebDriverWait wait;

        public Dashboards(IWebDriver driver)
        {
            this.driver = driver;
            this.wait = new WebDriverWait(driver, TimeSpan.FromSeconds(120));
        }

        public void VerifyPageTitle()
        {
            try
            {
                Thread.Sleep(2000);
                wait.Until(ExpectedConditions.ElementExists((By)Title));
                Assert.IsTrue(driver.FindElement(Title).Displayed);
            }
            catch (Exception)
            {
                Console.WriteLine("Page title is incorrect");
                Assert.Fail();
            }
        }

        public void SearchFAQ()
        {
            //Verify Home dashboard is displayed
            Thread.Sleep(4000);
            wait.Until(ExpectedConditions.ElementExists((By)DashboardTitle));
            Assert.IsTrue(driver.FindElement(DashboardTitle).Displayed);
            //Search FAQ section
            Thread.Sleep(1000);
            driver.SwitchTo().Frame(driver.FindElement(By.Id("9532b1de-41a1-456c-b21c-805faca15573_WebResource_customeradvisorstart")));
            Thread.Sleep(1000);
            driver.FindElement(FAQSearchBox).Click();
            Thread.Sleep(1000);
            driver.FindElement(FAQSearchBox).SendKeys("My account");
            Thread.Sleep(2000);
            //Verify service result is shown
            wait.Until(ExpectedConditions.ElementExists((By)FAQSearchServiceResult));
            Assert.IsTrue(driver.FindElement(FAQSearchServiceResult).Displayed);
            //Select access channel
            Thread.Sleep(1000);
            driver.FindElement(AccessChannelDropdown).Click();
            Thread.Sleep(1000);
            driver.FindElement(AccessChannelOptionPhone).Click();
            //Search another term
            Thread.Sleep(1000);
            driver.FindElement(FAQSearchBox).Click();
            Thread.Sleep(1000);
            Actions action = new Actions(driver);
            WebElement ele = (WebElement)driver.FindElement(FAQSearchBox);
            action.Click(ele).Click(ele).Click(ele).Perform();
            driver.FindElement(FAQSearchBox).SendKeys(Keys.Delete);
            driver.FindElement(FAQSearchBox).SendKeys("Tip");
            Thread.Sleep(2000);
            //Verify FAQ result is shown
            wait.Until(ExpectedConditions.ElementExists((By)FAQSearchResult));
            Assert.IsTrue(driver.FindElement(FAQSearchResult).Displayed);
            driver.FindElement(FAQSearchResult).Click();
            Thread.Sleep(2000);
            //Verify record answer appears
            wait.Until(ExpectedConditions.ElementExists((By)FAQRecordAnswerGiven));
            Assert.IsTrue(driver.FindElement(FAQRecordAnswerGiven).Displayed);
            driver.FindElement(FAQRecordAnswerGiven).Click();
            Thread.Sleep(2000);
            //Verify answer has been recorded
            wait.Until(ExpectedConditions.ElementExists((By)FAQAnswerRecorded));
            Assert.IsTrue(driver.FindElement(FAQAnswerRecorded).Displayed);
            //Select more information
            Thread.Sleep(1000);
            driver.FindElement(FAQMoreInfo).Click();
            Thread.Sleep(2000);
            //Verify more info page is shown
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            wait.Until(ExpectedConditions.ElementExists((By)FAQMoreInfoPage));
            Assert.IsTrue(driver.FindElement(FAQMoreInfoPage).Displayed);
            Thread.Sleep(2000);
            driver.Close();
            driver.SwitchTo().Window(driver.WindowHandles.First());
            //search for food
            driver.SwitchTo().Frame(driver.FindElement(By.Id("9532b1de-41a1-456c-b21c-805faca15573_WebResource_customeradvisorstart")));
            Thread.Sleep(2000);
            WebElement ele1 = (WebElement)driver.FindElement(FAQSearchBox);
            action.Click(ele1).Click(ele1).Click(ele1).Perform();
            driver.FindElement(FAQSearchBox).SendKeys(Keys.Delete);
            driver.FindElement(FAQSearchBox).SendKeys("Food");
            driver.FindElement(FAQSearchBox).SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            //click answer that is displayed
            driver.FindElement(FAQFoodAnswer).Click();
            Thread.Sleep(2000);
            //click record as signposted
            driver.FindElement(FAQRecordSignposted).Click();
            Thread.Sleep(4000);
            //Verify answer has been recorded
            wait.Until(ExpectedConditions.ElementExists((By)FAQAnswerRecorded));
            Assert.IsTrue(driver.FindElement(FAQAnswerRecorded).Displayed);
            //Click filter icon in header
            driver.SwitchTo().DefaultContent();
            Thread.Sleep(2000);
            driver.FindElement(AdvancedFindFilter).Click();
            Thread.Sleep(15000);
            //Click look for dropdown
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            Thread.Sleep(2000);
            driver.SwitchTo().Frame(driver.FindElement(By.XPath("//iframe[@id='contentIFrame0']")));
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)FilterLookFor));
            driver.FindElement(FilterLookFor).Click();
            Thread.Sleep(2000);
            //Click FAQ Activities
            driver.FindElement(LookForOptionOnDropdown).Click();
            Thread.Sleep(2000);
            //Click results icon
            driver.SwitchTo().DefaultContent();
            driver.FindElement(ResultsIconOnLookForBanner).Click();
            Thread.Sleep(3000);
            //Sort created on column to newest first
            driver.SwitchTo().Frame(driver.FindElement(By.XPath("//iframe[@id='contentIFrame0']")));
            driver.SwitchTo().Frame("resultFrame");
            Thread.Sleep(5000);
            driver.FindElement(ResultsCreatedOnColumn).Click();
            Thread.Sleep(2000);
            driver.FindElement(ResultsCreatedOnColumn).Click();
            Thread.Sleep(2000);
            //Verify FAQ just added is shown
            wait.Until(ExpectedConditions.ElementExists((By)FAQResultOnTable));
            Assert.IsTrue(driver.FindElement(FAQResultOnTable).Displayed);

        }

        public void SearchServices()
        {
            //Verify Home dashboard is displayed
            Thread.Sleep(4000);
            wait.Until(ExpectedConditions.ElementExists((By)DashboardTitle));
            Assert.IsTrue(driver.FindElement(DashboardTitle).Displayed);
            //Search FAQ section
            Thread.Sleep(1000);
            driver.SwitchTo().Frame(driver.FindElement(By.Id("9532b1de-41a1-456c-b21c-805faca15573_WebResource_customeradvisorstart")));
            Thread.Sleep(1000);
            driver.FindElement(FAQSearchBox).Click();
            Thread.Sleep(1000);
            driver.FindElement(FAQSearchBox).SendKeys("Dog");
            Thread.Sleep(2000);
            //Verify services are displayed
            wait.Until(ExpectedConditions.ElementExists((By)ServiceSearchResult));
            Assert.IsTrue(driver.FindElement(ServiceSearchResult).Displayed);
            //Click on a service
            driver.FindElement(ServiceSearchResult).Click();
            //Verify access channel pop up is shown
            Thread.Sleep(2000);
            driver.SwitchTo().DefaultContent();
            wait.Until(ExpectedConditions.ElementExists((By)AccessChannelPopUpOk));
            driver.FindElement(AccessChannelPopUpOk).Click();
            //Click access channel dropdown
            driver.SwitchTo().Frame(driver.FindElement(By.Id("9532b1de-41a1-456c-b21c-805faca15573_WebResource_customeradvisorstart")));
            Thread.Sleep(2000);
            driver.FindElement(AccessChannelDropdown).Click();
            Thread.Sleep(2000);
            //Verify options are displayed in list
            wait.Until(ExpectedConditions.ElementExists((By)AccessChannelOptionPhone));
            Assert.IsTrue(driver.FindElement(AccessChannelOptionPhone).Displayed);
            wait.Until(ExpectedConditions.ElementExists((By)AccessChannelOptionEmail));
            Assert.IsTrue(driver.FindElement(AccessChannelOptionEmail).Displayed);
            wait.Until(ExpectedConditions.ElementExists((By)AccessChannelOptionWeb));
            Assert.IsTrue(driver.FindElement(AccessChannelOptionWeb).Displayed);
            wait.Until(ExpectedConditions.ElementExists((By)AccessChannelOptionFacebook));
            Assert.IsTrue(driver.FindElement(AccessChannelOptionFacebook).Displayed);
            wait.Until(ExpectedConditions.ElementExists((By)AccessChannelOptionTwitter));
            Assert.IsTrue(driver.FindElement(AccessChannelOptionTwitter).Displayed);
            wait.Until(ExpectedConditions.ElementExists((By)AccessChannelOptionPost));
            Assert.IsTrue(driver.FindElement(AccessChannelOptionPost).Displayed);
            wait.Until(ExpectedConditions.ElementExists((By)AccessChannelOptionFace));
            Assert.IsTrue(driver.FindElement(AccessChannelOptionFace).Displayed);
            wait.Until(ExpectedConditions.ElementExists((By)AccessChannelOptionME));
            Assert.IsTrue(driver.FindElement(AccessChannelOptionME).Displayed);
            //Select access channel
            driver.FindElement(AccessChannelOptionPhone).Click();
            Thread.Sleep(2000);
            //Select a service
            driver.FindElement(ServiceSearchResult).Click();
            Thread.Sleep(2000);
            //Click yes on overlay
            driver.SwitchTo().DefaultContent();
            wait.Until(ExpectedConditions.ElementExists((By)SelectYesOnServiceOverlay));
            driver.FindElement(SelectYesOnServiceOverlay).Click();
            Thread.Sleep(2000);
            //Verify correct page loads
            wait.Until(ExpectedConditions.ElementExists((By)ServiceForm));
            Assert.IsTrue(driver.FindElement(ServiceForm).Displayed);
        }

        public void SearchUsers()
        {
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)DashboardTitle));
            Assert.IsTrue(driver.FindElement(DashboardTitle).Displayed);
            Thread.Sleep(3000);
            driver.SwitchTo().Frame(driver.FindElement(By.Id("9532b1de-41a1-456c-b21c-805faca15573_WebResource_customeradvisorstart")));
            wait.Until(ExpectedConditions.ElementExists((By)Searchbox));
            Assert.IsTrue(driver.FindElement(Searchbox).Displayed);
            //Fullname
            driver.FindElement(Searchbox).Click();
            driver.FindElement(Searchbox).SendKeys("Test Moore");
            driver.FindElement(Searchbox).SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)ExistingCustomerSearchDropdown));
            Assert.IsTrue(driver.FindElement(ExistingCustomerSearchDropdown).Displayed);
            driver.FindElement(ExistingCustomerSearchDropdown).Click();
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)ExistingCustomerSearchResult));
            Assert.IsTrue(driver.FindElement(ExistingCustomerSearchResult).Displayed);
            //Surname
            Actions action = new Actions(driver);
            WebElement ele = (WebElement)driver.FindElement(Searchbox);
            action.Click(ele).Click(ele).Click(ele).Perform();
            driver.FindElement(Searchbox).SendKeys(Keys.Delete);
            driver.FindElement(Searchbox).SendKeys("Moore");
            driver.FindElement(Searchbox).SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)ExistingCustomerSearchDropdown));
            Assert.IsTrue(driver.FindElement(ExistingCustomerSearchDropdown).Displayed);
            driver.FindElement(ExistingCustomerSearchDropdown).Click();
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)ExistingCustomerSearchResult));
            Assert.IsTrue(driver.FindElement(ExistingCustomerSearchResult).Displayed);
            //Mobile number
            WebElement ele1 = (WebElement)driver.FindElement(Searchbox);
            action.Click(ele1).Click(ele1).Click(ele1).Perform();
            driver.FindElement(Searchbox).SendKeys(Keys.Delete);
            driver.FindElement(Searchbox).SendKeys("07777777777");
            driver.FindElement(Searchbox).SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)ExistingCustomerSearchDropdown));
            Assert.IsTrue(driver.FindElement(ExistingCustomerSearchDropdown).Displayed);
            driver.FindElement(ExistingCustomerSearchDropdown).Click();
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)ExistingCustomerSearchResult));
            Assert.IsTrue(driver.FindElement(ExistingCustomerSearchResult).Displayed);
            //Postcode
            WebElement ele2 = (WebElement)driver.FindElement(Searchbox);
            action.Click(ele2).Click(ele2).Click(ele2).Perform();
            driver.FindElement(Searchbox).SendKeys(Keys.Delete);
            driver.FindElement(Searchbox).SendKeys("S71 1Aj");
            driver.FindElement(Searchbox).SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)ExistingCustomerSearchDropdown));
            Assert.IsTrue(driver.FindElement(ExistingCustomerSearchDropdown).Displayed);
            driver.FindElement(ExistingCustomerSearchDropdown).Click();
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)ExistingCustomerSearchResult));
            Assert.IsTrue(driver.FindElement(ExistingCustomerSearchResult).Displayed);
            //Surname & Postcode
            WebElement ele3 = (WebElement)driver.FindElement(Searchbox);
            action.Click(ele3).Click(ele3).Click(ele3).Perform();
            driver.FindElement(Searchbox).SendKeys(Keys.Delete);
            driver.FindElement(Searchbox).SendKeys("moore s711aj");
            driver.FindElement(Searchbox).SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)ExistingCustomerSearchDropdown));
            Assert.IsTrue(driver.FindElement(ExistingCustomerSearchDropdown).Displayed);
            driver.FindElement(ExistingCustomerSearchDropdown).Click();
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)ExistingCustomerSearchResult));
            Assert.IsTrue(driver.FindElement(ExistingCustomerSearchResult).Displayed);
            //House number & Postcode
            WebElement ele4 = (WebElement)driver.FindElement(Searchbox);
            action.Click(ele4).Click(ele4).Click(ele4).Perform();
            driver.FindElement(Searchbox).SendKeys(Keys.Delete);
            driver.FindElement(Searchbox).SendKeys("14 s711aj");
            driver.FindElement(Searchbox).SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)ExistingCustomerSearchDropdown));
            Assert.IsTrue(driver.FindElement(ExistingCustomerSearchDropdown).Displayed);
            driver.FindElement(ExistingCustomerSearchDropdown).Click();
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)ExistingCustomerSearchResult));
            Assert.IsTrue(driver.FindElement(ExistingCustomerSearchResult).Displayed);
            //Street name
            WebElement ele5 = (WebElement)driver.FindElement(Searchbox);
            action.Click(ele5).Click(ele5).Click(ele5).Perform();
            driver.FindElement(Searchbox).SendKeys(Keys.Delete);
            driver.FindElement(Searchbox).SendKeys("Pontefract Road");
            driver.FindElement(Searchbox).SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)ExistingCustomerSearchDropdown));
            Assert.IsTrue(driver.FindElement(ExistingCustomerSearchDropdown).Displayed);
            driver.FindElement(ExistingCustomerSearchDropdown).Click();
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)ExistingCustomerSearchResult));
            Assert.IsTrue(driver.FindElement(ExistingCustomerSearchResult).Displayed);
            //House number & Street name
            WebElement ele6 = (WebElement)driver.FindElement(Searchbox);
            action.Click(ele6).Click(ele6).Click(ele6).Perform();
            driver.FindElement(Searchbox).SendKeys(Keys.Delete);
            driver.FindElement(Searchbox).SendKeys("14 Pontefract Road");
            driver.FindElement(Searchbox).SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)ExistingCustomerSearchDropdown));
            Assert.IsTrue(driver.FindElement(ExistingCustomerSearchDropdown).Displayed);
            driver.FindElement(ExistingCustomerSearchDropdown).Click();
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)ExistingCustomerSearchResult));
            Assert.IsTrue(driver.FindElement(ExistingCustomerSearchResult).Displayed);
            //Email address - Customer
            WebElement ele7 = (WebElement)driver.FindElement(Searchbox);
            action.Click(ele7).Click(ele7).Click(ele7).Perform();
            driver.FindElement(Searchbox).SendKeys(Keys.Delete);
            driver.FindElement(Searchbox).SendKeys("test@test.com");
            driver.FindElement(Searchbox).SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)ExistingCustomerSearchDropdown));
            Assert.IsTrue(driver.FindElement(ExistingCustomerSearchDropdown).Displayed);
            driver.FindElement(ExistingCustomerSearchDropdown).Click();
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)ExistingCustomerSearchResult));
            Assert.IsTrue(driver.FindElement(ExistingCustomerSearchResult).Displayed);
            //Invalid Characters
            WebElement ele8 = (WebElement)driver.FindElement(Searchbox);
            action.Click(ele8).Click(ele8).Click(ele8).Perform();
            driver.FindElement(Searchbox).SendKeys(Keys.Delete);
            driver.FindElement(Searchbox).SendKeys("£$%%££");
            driver.FindElement(Searchbox).SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            Assert.IsTrue(driver.FindElement(SearchErrorMsg).Displayed);
            //Business name
            WebElement ele9 = (WebElement)driver.FindElement(Searchbox);
            action.Click(ele9).Click(ele9).Click(ele9).Perform();
            driver.FindElement(Searchbox).SendKeys(Keys.Delete);
            driver.FindElement(Searchbox).SendKeys("test cafe");
            driver.FindElement(Searchbox).SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)ExistingBusinessSearchDropdown));
            Assert.IsTrue(driver.FindElement(ExistingBusinessSearchDropdown).Displayed);
            driver.FindElement(ExistingBusinessSearchDropdown).Click();
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)ExistingBusinessSearchResult));
            Assert.IsTrue(driver.FindElement(ExistingBusinessSearchResult).Displayed);
            //Business street name and postcode
            WebElement ele11 = (WebElement)driver.FindElement(Searchbox);
            action.Click(ele11).Click(ele11).Click(ele11).Perform();
            driver.FindElement(Searchbox).SendKeys(Keys.Delete);
            driver.FindElement(Searchbox).SendKeys("Test WF8 1RA");
            driver.FindElement(Searchbox).SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)ExistingBusinessSearchDropdown));
            Assert.IsTrue(driver.FindElement(ExistingBusinessSearchDropdown).Displayed);
            driver.FindElement(ExistingBusinessSearchDropdown).Click();
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)ExistingBusinessSearchResult));
            Assert.IsTrue(driver.FindElement(ExistingBusinessSearchResult).Displayed);
            //Select Customer from link below access channel
            WebElement ele12 = (WebElement)driver.FindElement(Searchbox);
            action.Click(ele12).Click(ele12).Click(ele12).Perform();
            driver.FindElement(Searchbox).SendKeys(Keys.Delete);
            driver.FindElement(Searchbox).SendKeys("Test Moore");
            driver.FindElement(Searchbox).SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)ExistingCustomerSearchDropdown));
            Assert.IsTrue(driver.FindElement(ExistingCustomerSearchDropdown).Displayed);
            driver.FindElement(ExistingCustomerSearchDropdown).Click();
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)ExistingCustomerSearchResult));
            Assert.IsTrue(driver.FindElement(ExistingCustomerSearchResult).Displayed);
            driver.FindElement(ExistingCustomerSearchResult).Click();
            driver.SwitchTo().DefaultContent();
            //Verify customer profile loads
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)TestUserNameOnProfile));
            Assert.IsTrue(driver.FindElement(TestUserNameOnProfile).Displayed);
        }

        public void SearchUsersUnknownAddress()
        {
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)DashboardTitle));
            Assert.IsTrue(driver.FindElement(DashboardTitle).Displayed);
            Thread.Sleep(3000);
            driver.SwitchTo().Frame(driver.FindElement(By.Id("9532b1de-41a1-456c-b21c-805faca15573_WebResource_customeradvisorstart")));
            wait.Until(ExpectedConditions.ElementExists((By)Searchbox));
            Assert.IsTrue(driver.FindElement(Searchbox).Displayed);
            //Fullname
            driver.FindElement(Searchbox).Click();
            driver.FindElement(Searchbox).SendKeys("Unknown Address");
            driver.FindElement(Searchbox).SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)AnonCustomerSearchDropdown));
            Assert.IsTrue(driver.FindElement(AnonCustomerSearchDropdown).Displayed);
            driver.FindElement(AnonCustomerSearchDropdown).Click();
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)AnonAddressSearchResult));
            Assert.IsTrue(driver.FindElement(AnonAddressSearchResult).Displayed);
            //Surname
            Actions action = new Actions(driver);
            WebElement ele = (WebElement)driver.FindElement(Searchbox);
            action.Click(ele).Click(ele).Click(ele).Perform();
            driver.FindElement(Searchbox).SendKeys(Keys.Delete);
            driver.FindElement(Searchbox).SendKeys("Address");
            driver.FindElement(Searchbox).SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)AnonCustomerSearchDropdown));
            Assert.IsTrue(driver.FindElement(AnonCustomerSearchDropdown).Displayed);
            driver.FindElement(AnonCustomerSearchDropdown).Click();
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)AnonAddressSearchResult));
            Assert.IsTrue(driver.FindElement(AnonAddressSearchResult).Displayed);
            //Mobile number
            action.Click(ele).Click(ele).Click(ele).Perform();
            driver.FindElement(Searchbox).SendKeys(Keys.Delete);
            driver.FindElement(Searchbox).SendKeys("07777777777");
            driver.FindElement(Searchbox).SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)AnonCustomerSearchDropdown));
            Assert.IsTrue(driver.FindElement(AnonCustomerSearchDropdown).Displayed);
            driver.FindElement(AnonCustomerSearchDropdown).Click();
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)AnonAddressSearchResult));
            Assert.IsTrue(driver.FindElement(AnonAddressSearchResult).Displayed);
            //Unknown address
            action.Click(ele).Click(ele).Click(ele).Perform();
            driver.FindElement(Searchbox).SendKeys(Keys.Delete);
            driver.FindElement(Searchbox).SendKeys("Unknown");
            driver.FindElement(Searchbox).SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)AnonCustomerSearchDropdown));
            Assert.IsTrue(driver.FindElement(AnonCustomerSearchDropdown).Displayed);
            driver.FindElement(AnonCustomerSearchDropdown).Click();
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)AnonAddressSearchResult));
            Assert.IsTrue(driver.FindElement(AnonAddressSearchResult).Displayed);
        }

        public void SearchUsersManualAddress()
        {
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)DashboardTitle));
            Assert.IsTrue(driver.FindElement(DashboardTitle).Displayed);
            Thread.Sleep(4000);
            driver.SwitchTo().Frame(driver.FindElement(By.Id("9532b1de-41a1-456c-b21c-805faca15573_WebResource_customeradvisorstart")));
            wait.Until(ExpectedConditions.ElementExists((By)Searchbox));
            Assert.IsTrue(driver.FindElement(Searchbox).Displayed);
            //Fullname
            driver.FindElement(Searchbox).Click();
            driver.FindElement(Searchbox).SendKeys("Manual Address");
            driver.FindElement(Searchbox).SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)ManualAddressSearchDropdown));
            Assert.IsTrue(driver.FindElement(ManualAddressSearchDropdown).Displayed);
            driver.FindElement(ManualAddressSearchDropdown).Click();
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)ManualAddressSearchResult));
            Assert.IsTrue(driver.FindElement(ManualAddressSearchResult).Displayed);
            //Surname
            Actions action = new Actions(driver);
            WebElement ele = (WebElement)driver.FindElement(Searchbox);
            action.Click(ele).Click(ele).Click(ele).Perform();
            driver.FindElement(Searchbox).SendKeys(Keys.Delete);
            driver.FindElement(Searchbox).SendKeys("Address");
            driver.FindElement(Searchbox).SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)ManualAddressSearchDropdown));
            Assert.IsTrue(driver.FindElement(ManualAddressSearchDropdown).Displayed);
            driver.FindElement(ManualAddressSearchDropdown).Click();
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)ManualAddressSearchResult));
            Assert.IsTrue(driver.FindElement(ManualAddressSearchResult).Displayed);
            //Mobile number
            WebElement ele1 = (WebElement)driver.FindElement(Searchbox);
            action.Click(ele1).Click(ele1).Click(ele1).Perform();
            driver.FindElement(Searchbox).SendKeys(Keys.Delete);
            driver.FindElement(Searchbox).SendKeys("07777777777");
            driver.FindElement(Searchbox).SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)ManualAddressSearchDropdown));
            Assert.IsTrue(driver.FindElement(ManualAddressSearchDropdown).Displayed);
            driver.FindElement(ManualAddressSearchDropdown).Click();
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)ManualAddressSearchResult));
            Assert.IsTrue(driver.FindElement(ManualAddressSearchResult).Displayed);
            //Postcode
            WebElement ele2 = (WebElement)driver.FindElement(Searchbox);
            action.Click(ele2).Click(ele2).Click(ele2).Perform();
            driver.FindElement(Searchbox).SendKeys(Keys.Delete);
            driver.FindElement(Searchbox).SendKeys("LE65 2RB");
            driver.FindElement(Searchbox).SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)ManualAddressSearchDropdown));
            Assert.IsTrue(driver.FindElement(ManualAddressSearchDropdown).Displayed);
            driver.FindElement(ManualAddressSearchDropdown).Click();
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)ManualAddressSearchResult));
            Assert.IsTrue(driver.FindElement(ManualAddressSearchResult).Displayed);
            //Surname & Postcode
            WebElement ele3 = (WebElement)driver.FindElement(Searchbox);
            action.Click(ele3).Click(ele3).Click(ele3).Perform();
            driver.FindElement(Searchbox).SendKeys(Keys.Delete);
            driver.FindElement(Searchbox).SendKeys("Address LE65 2RB");
            driver.FindElement(Searchbox).SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)ManualAddressSearchDropdown));
            Assert.IsTrue(driver.FindElement(ManualAddressSearchDropdown).Displayed);
            driver.FindElement(ManualAddressSearchDropdown).Click();
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)ManualAddressSearchResult));
            Assert.IsTrue(driver.FindElement(ManualAddressSearchResult).Displayed);
            //House number & Postcode
            WebElement ele4 = (WebElement)driver.FindElement(Searchbox);
            action.Click(ele4).Click(ele4).Click(ele4).Perform();
            driver.FindElement(Searchbox).SendKeys(Keys.Delete);
            driver.FindElement(Searchbox).SendKeys("80 LE65 2RB");
            driver.FindElement(Searchbox).SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)ManualAddressSearchDropdown));
            Assert.IsTrue(driver.FindElement(ManualAddressSearchDropdown).Displayed);
            driver.FindElement(ManualAddressSearchDropdown).Click();
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)ManualAddressSearchResult));
            Assert.IsTrue(driver.FindElement(ManualAddressSearchResult).Displayed);
            //Street name
            WebElement ele5 = (WebElement)driver.FindElement(Searchbox);
            action.Click(ele5).Click(ele5).Click(ele5).Perform();
            driver.FindElement(Searchbox).SendKeys(Keys.Delete);
            driver.FindElement(Searchbox).SendKeys("SPRING AVENUE");
            driver.FindElement(Searchbox).SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)ManualAddressSearchDropdown));
            Assert.IsTrue(driver.FindElement(ManualAddressSearchDropdown).Displayed);
            driver.FindElement(ManualAddressSearchDropdown).Click();
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)ManualAddressSearchResult));
            Assert.IsTrue(driver.FindElement(ManualAddressSearchResult).Displayed);
            //House number & Street name
            WebElement ele6 = (WebElement)driver.FindElement(Searchbox);
            action.Click(ele6).Click(ele6).Click(ele6).Perform();
            driver.FindElement(Searchbox).SendKeys(Keys.Delete);
            driver.FindElement(Searchbox).SendKeys("80 SPRING AVENUE");
            driver.FindElement(Searchbox).SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)ManualAddressSearchDropdown));
            Assert.IsTrue(driver.FindElement(ManualAddressSearchDropdown).Displayed);
            driver.FindElement(ManualAddressSearchDropdown).Click();
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)ManualAddressSearchResult));
            Assert.IsTrue(driver.FindElement(ManualAddressSearchResult).Displayed);
            //Email address - Customer
            WebElement ele7 = (WebElement)driver.FindElement(Searchbox);
            action.Click(ele7).Click(ele7).Click(ele7).Perform();
            driver.FindElement(Searchbox).SendKeys(Keys.Delete);
            driver.FindElement(Searchbox).SendKeys("manual@address.com");
            driver.FindElement(Searchbox).SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)ManualAddressSearchDropdown));
            Assert.IsTrue(driver.FindElement(ManualAddressSearchDropdown).Displayed);
            driver.FindElement(ManualAddressSearchDropdown).Click();
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)ManualAddressSearchResult));
            Assert.IsTrue(driver.FindElement(ManualAddressSearchResult).Displayed);
            //Invalid Characters
            WebElement ele8 = (WebElement)driver.FindElement(Searchbox);
            action.Click(ele8).Click(ele8).Click(ele8).Perform();
            driver.FindElement(Searchbox).SendKeys(Keys.Delete);
            driver.FindElement(Searchbox).SendKeys("£$%%££");
            driver.FindElement(Searchbox).SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            Assert.IsTrue(driver.FindElement(SearchErrorMsg).Displayed);
            //Select Customer from link below access channel
            WebElement ele9 = (WebElement)driver.FindElement(Searchbox);
            action.Click(ele9).Click(ele9).Click(ele9).Perform();
            driver.FindElement(Searchbox).SendKeys(Keys.Delete);
            driver.FindElement(Searchbox).SendKeys("Manual Address");
            driver.FindElement(Searchbox).SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)ManualAddressSearchDropdown));
            Assert.IsTrue(driver.FindElement(ManualAddressSearchDropdown).Displayed);
            driver.FindElement(ManualAddressSearchDropdown).Click();
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)ManualAddressSearchResult));
            Assert.IsTrue(driver.FindElement(ManualAddressSearchResult).Displayed);
            driver.FindElement(ManualAddressSearchResult).Click();
            driver.SwitchTo().DefaultContent();
            //Verify customer profile loads
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)ManualAddressNameOnProfile));
            Assert.IsTrue(driver.FindElement(ManualAddressNameOnProfile).Displayed);
        }

        public void EditCustomerFromSearch()
        {
            //Create customer
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
            Thread.Sleep(2000);
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
            driver.SwitchTo().Frame(driver.FindElement(By.Id("WebResource_WMDCCustomerAddressSearch")));
            Thread.Sleep(1000);
            //Address
            driver.FindElement(NewCustomerAddress).Click();
            driver.FindElement(NewCustomerAddress).SendKeys("2 Sandhill Rise Pontefract WF8 1RA");
            driver.FindElement(NewCustomerAddress).SendKeys(Keys.Enter);
            wait.Until(ExpectedConditions.ElementExists((By)NewCustomerAddressDropdown1));
            driver.FindElement(NewCustomerAddressDropdown1).Click();
            driver.SwitchTo().DefaultContent();
            //Save and close
            driver.FindElement(NewCustomerSaveandClose).Click();
            Thread.Sleep(3000);
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
            //Navigate to home screen
            driver.FindElement(HomeOnLHN).Click();
            wait.Until(ExpectedConditions.ElementExists((By)HomepageTitle));
            Thread.Sleep(1000);
            Assert.IsTrue(driver.FindElement(HomepageTitle).Displayed);
            //Switch driver to searchbox iframe
            Thread.Sleep(2000);
            driver.SwitchTo().Frame(driver.FindElement(By.Id("9532b1de-41a1-456c-b21c-805faca15573_WebResource_customeradvisorstart")));
            wait.Until(ExpectedConditions.ElementExists((By)Searchbox));
            Assert.IsTrue(driver.FindElement(Searchbox).Displayed);
            //Enter fullname in search
            driver.FindElement(Searchbox).Click();
            driver.FindElement(Searchbox).SendKeys("AAA AAA");
            driver.FindElement(Searchbox).SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            Assert.IsTrue(driver.FindElement(SearchResult).Displayed);
            driver.FindElement(SearchResult).Click();
            //Search result details
            wait.Until(ExpectedConditions.ElementExists((By)SearchResultDeatils));
            Thread.Sleep(2000);
            driver.FindElement(SearchResultDeatils).Click();
            Thread.Sleep(1000);
            driver.SwitchTo().DefaultContent();
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)CustomerInfoHeader));
            Assert.IsTrue(driver.FindElement(CustomerInfoHeader).Displayed);
            //Edit information on user record
            //Email address
            Thread.Sleep(1000);
            driver.FindElement(NewCustomerEmail).Click();
            Thread.Sleep(1000);
            WebElement ele2 = (WebElement)driver.FindElement(NewCustomerEmail);
            action.Click(ele2).Click(ele2).Click(ele2).Perform();
            driver.FindElement(NewCustomerEmail).SendKeys(Keys.Delete);
            driver.FindElement(NewCustomerEmail).SendKeys("Testing@tester.com");
            Thread.Sleep(1000);
            //Save and close
            driver.FindElement(NewCustomerSaveandClose).Click();
            Thread.Sleep(3000);
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
                if (driver.FindElement(DashboardTitle).Displayed)
                {
                    Console.WriteLine("No duplicates found");
                }
            }
            Thread.Sleep(3000);
            //Navigate from dashboard to active customers list
            driver.SwitchTo().Frame(driver.FindElement(By.Id("9532b1de-41a1-456c-b21c-805faca15573_WebResource_customeradvisorstart")));
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)DashboardSearchPanel));
            driver.SwitchTo().DefaultContent();
            Thread.Sleep(1000);
            driver.FindElement(CustomersLHN).Click();
            //Active customers list
            wait.Until(ExpectedConditions.ElementExists((By)ActiveContactsList));
            Thread.Sleep(1000);
            Assert.IsTrue(driver.FindElement(ActiveContactsList).Displayed);
            Thread.Sleep((1000));
            wait.Until(ExpectedConditions.ElementExists((By)NewCustomerEmailOnList1));
            Assert.IsTrue(driver.FindElement(NewCustomerEmailOnList1).Displayed);
            Thread.Sleep((1000));
            driver.FindElement(NewCustomerOnList).Click();
            Thread.Sleep((1000));
            //Delete customer
            driver.FindElement(ActiveContactsDelete).Click();
            wait.Until(ExpectedConditions.ElementExists((By)ActiveContactsDeleteOverlay));
            Thread.Sleep(1000);
            driver.FindElement(ActiveContactsDeleteOverlay).Click();
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

        public void CreateCustomerFromSearch()
        {
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)DashboardsLHN));
            driver.FindElement(DashboardsLHN).Click();
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)DashboardTitle));
            Assert.IsTrue(driver.FindElement(DashboardTitle).Displayed);
            Thread.Sleep(3000);
            driver.SwitchTo().Frame(driver.FindElement(By.Id("9532b1de-41a1-456c-b21c-805faca15573_WebResource_customeradvisorstart")));
            wait.Until(ExpectedConditions.ElementExists((By)Searchbox));
            Thread.Sleep(2000);
            Assert.IsTrue(driver.FindElement(Searchbox).Displayed);
            //Fullname
            driver.FindElement(Searchbox).Click();
            driver.FindElement(Searchbox).SendKeys("Test Moore");
            driver.FindElement(Searchbox).SendKeys(Keys.Enter);
            //Click create customer on dropdown
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)CreateNewContactOnDropdown));
            Assert.IsTrue(driver.FindElement(CreateNewContactOnDropdown).Displayed);
            driver.FindElement(CreateNewContactOnDropdown).Click();
            Thread.Sleep(2000);
            driver.SwitchTo().DefaultContent();
            Thread.Sleep(2000);
            //Click yes on overlay
            wait.Until(ExpectedConditions.ElementExists((By)CreateCustomerOverlayYesBtn));
            driver.FindElement(CreateCustomerOverlayYesBtn).Click();
            Thread.Sleep(3000);
            //Verify new customer form is displayed
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
            //Address
            driver.SwitchTo().Frame(driver.FindElement(By.Id("WebResource_WMDCCustomerAddressSearch")));
            Thread.Sleep(1000);
            driver.FindElement(NewCustomerAddress).Click();
            driver.FindElement(NewCustomerAddress).SendKeys("7 Sandhill Rise Pontefract WF8 1RA");
            driver.FindElement(NewCustomerAddress).SendKeys(Keys.Enter);
            wait.Until(ExpectedConditions.ElementExists((By)NewCustomerAddressDropdown));
            driver.FindElement(NewCustomerAddressDropdown).Click();
            driver.SwitchTo().DefaultContent();
            //verify emails set to not allow
            Thread.Sleep(2000);
            Assert.IsTrue(driver.FindElement(NewCustomerNotAllowEmails).Displayed);
            //Email address
            driver.FindElement(NewCustomerEmail).Click();
            Thread.Sleep(1000);
            driver.FindElement(NewCustomerEmail).Clear();
            driver.FindElement(NewCustomerEmail).SendKeys("Testing@testing.com");
            driver.FindElement(NewCustomerEmail).SendKeys(Keys.Tab);
            Thread.Sleep(1000);
            //Verify 'do not allow emails' is changed to 'allow'
            Assert.IsTrue(driver.FindElement(NewCustomerAllowEmails).Displayed);
            //Save and close
            driver.FindElement(NewCustomerSaveandClose).Click();
            Thread.Sleep(3000);
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
                if (driver.FindElement(DashboardTitle).Displayed)
                {
                    Console.WriteLine("No duplicates found");
                }
            }
            //Click customers LHN
            Thread.Sleep((2000));
            driver.FindElement(CustomersLHN).Click();
            //Verify user added
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

        public void CustomerAlerts()
        {
            //Verify Home dashboard is displayed
            Thread.Sleep(4000);
            wait.Until(ExpectedConditions.ElementExists((By)DashboardTitle));
            Assert.IsTrue(driver.FindElement(DashboardTitle).Displayed);
            Thread.Sleep(3000);
            //Switch to searchbox iframe
            driver.SwitchTo().Frame(driver.FindElement(By.Id("9532b1de-41a1-456c-b21c-805faca15573_WebResource_customeradvisorstart")));
            wait.Until(ExpectedConditions.ElementExists((By)Searchbox));
            Assert.IsTrue(driver.FindElement(Searchbox).Displayed);
            //Enter fullname in search
            driver.FindElement(Searchbox).Click();
            driver.FindElement(Searchbox).SendKeys("Terry Alert");
            driver.FindElement(Searchbox).SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            //Check result shows on the dropdown
            wait.Until(ExpectedConditions.ElementExists((By)TerryAlertDetailsOnDropdown));
            Assert.IsTrue(driver.FindElement(TerryAlertDetailsOnDropdown).Displayed);
            driver.FindElement(TerryAlertDetailsOnDropdown).Click();
            Thread.Sleep(2000);
            //Check result is shown under access channel after selecting from dropdown
            wait.Until(ExpectedConditions.ElementExists((By)TerryAlertSearchResult));
            Assert.IsTrue(driver.FindElement(TerryAlertSearchResult).Displayed);
            //Verify Warnings are displayed
            try
            {
                //Deaf alert
                Assert.IsTrue(driver.FindElement(DeafAlert).Displayed);
                //Abusive behavoiour
                Assert.IsTrue(driver.FindElement(AbusiveAlert).Displayed);
                //Persistent complainer
                Assert.IsTrue(driver.FindElement(PersistentComplainerAlert).Displayed);
                //Managing behaviour
                Assert.IsTrue(driver.FindElement(ManagingBehaviourAlert).Displayed);
            }
            catch (Exception)
            {
                Console.WriteLine("Alerts not displayed");
            }
        }

        public void OOACustomerAlerts()
        {
            //Verify Home dashboard is displayed
            Thread.Sleep(4000);
            wait.Until(ExpectedConditions.ElementExists((By)DashboardTitle));
            Assert.IsTrue(driver.FindElement(DashboardTitle).Displayed);
            Thread.Sleep(3000);
            //Switch to searchbox iframe
            driver.SwitchTo().Frame(driver.FindElement(By.Id("9532b1de-41a1-456c-b21c-805faca15573_WebResource_customeradvisorstart")));
            wait.Until(ExpectedConditions.ElementExists((By)Searchbox));
            Assert.IsTrue(driver.FindElement(Searchbox).Displayed);
            //Enter fullname in search
            driver.FindElement(Searchbox).Click();
            driver.FindElement(Searchbox).SendKeys("Ooa Casehistory");
            driver.FindElement(Searchbox).SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            //Check result shows on the dropdown
            wait.Until(ExpectedConditions.ElementExists((By)OOACasehistoryDetailsOnDropdown));
            Assert.IsTrue(driver.FindElement(OOACasehistoryDetailsOnDropdown).Displayed);
            driver.FindElement(OOACasehistoryDetailsOnDropdown).Click();
            Thread.Sleep(2000);
            //Check result is shown under access channel after selecting from dropdown
            wait.Until(ExpectedConditions.ElementExists((By)OOACasehistorySearchResult));
            Assert.IsTrue(driver.FindElement(OOACasehistorySearchResult).Displayed);
            //Verify Warnings are displayed
            try
            {
                //Deaf alert
                Assert.IsTrue(driver.FindElement(DeafAlert).Displayed);
                //Abusive behavoiour
                Assert.IsTrue(driver.FindElement(AbusiveAlert).Displayed);
                //Persistent complainer
                Assert.IsTrue(driver.FindElement(PersistentComplainerAlert).Displayed);
                //Managing behaviour
                Assert.IsTrue(driver.FindElement(ManagingBehaviourAlert).Displayed);
            }
            catch (Exception)
            {
                Console.WriteLine("Alerts not displayed");
            }
        }

        public void ManualAddressCustomerAlerts()
        {
            //Verify Home dashboard is displayed
            Thread.Sleep(4000);
            wait.Until(ExpectedConditions.ElementExists((By)DashboardTitle));
            Assert.IsTrue(driver.FindElement(DashboardTitle).Displayed);
            Thread.Sleep(3000);
            //Switch to searchbox iframe
            driver.SwitchTo().Frame(driver.FindElement(By.Id("9532b1de-41a1-456c-b21c-805faca15573_WebResource_customeradvisorstart")));
            wait.Until(ExpectedConditions.ElementExists((By)Searchbox));
            Assert.IsTrue(driver.FindElement(Searchbox).Displayed);
            //Enter fullname in search
            driver.FindElement(Searchbox).Click();
            driver.FindElement(Searchbox).SendKeys("Manual Address");
            driver.FindElement(Searchbox).SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            //Check result shows on the dropdown
            wait.Until(ExpectedConditions.ElementExists((By)ManualAddressSearchDropdown));
            Assert.IsTrue(driver.FindElement(ManualAddressSearchDropdown).Displayed);
            driver.FindElement(ManualAddressSearchDropdown).Click();
            Thread.Sleep(2000);
            //Check result is shown under access channel after selecting from dropdown
            wait.Until(ExpectedConditions.ElementExists((By)ManualAddressSearchResult));
            Assert.IsTrue(driver.FindElement(ManualAddressSearchResult).Displayed);
            //Verify Warnings are displayed
            try
            {
                //Deaf alert
                Assert.IsTrue(driver.FindElement(DeafAlert).Displayed);
                //Abusive behavoiour
                Assert.IsTrue(driver.FindElement(AbusiveAlert).Displayed);
                //Persistent complainer
                Assert.IsTrue(driver.FindElement(PersistentComplainerAlert).Displayed);
                //Managing behaviour
                Assert.IsTrue(driver.FindElement(ManagingBehaviourAlert).Displayed);
            }
            catch (Exception)
            {
                Console.WriteLine("Alerts not displayed");
            }
        }

        public void UnknownAddressCustomerAlerts()
        {
            //Verify Home dashboard is displayed
            Thread.Sleep(4000);
            wait.Until(ExpectedConditions.ElementExists((By)DashboardTitle));
            Assert.IsTrue(driver.FindElement(DashboardTitle).Displayed);
            Thread.Sleep(3000);
            //Switch to searchbox iframe
            driver.SwitchTo().Frame(driver.FindElement(By.Id("9532b1de-41a1-456c-b21c-805faca15573_WebResource_customeradvisorstart")));
            wait.Until(ExpectedConditions.ElementExists((By)Searchbox));
            Assert.IsTrue(driver.FindElement(Searchbox).Displayed);
            //Enter fullname in search
            driver.FindElement(Searchbox).Click();
            driver.FindElement(Searchbox).SendKeys("Unknown Address");
            driver.FindElement(Searchbox).SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            //Check result shows on the dropdown
            wait.Until(ExpectedConditions.ElementExists((By)UADetailsOnDropdown));
            Assert.IsTrue(driver.FindElement(UADetailsOnDropdown).Displayed);
            driver.FindElement(UADetailsOnDropdown).Click();
            Thread.Sleep(2000);
            //Check result is shown under access channel after selecting from dropdown
            wait.Until(ExpectedConditions.ElementExists((By)UASearchResult));
            Assert.IsTrue(driver.FindElement(UASearchResult).Displayed);
            //Verify Warnings are displayed
            try
            {
                //Deaf alert
                Assert.IsTrue(driver.FindElement(DeafAlert).Displayed);
                //Abusive behavoiour
                Assert.IsTrue(driver.FindElement(AbusiveAlert).Displayed);
                //Persistent complainer
                Assert.IsTrue(driver.FindElement(PersistentComplainerAlert).Displayed);
                //Managing behaviour
                Assert.IsTrue(driver.FindElement(ManagingBehaviourAlert).Displayed);
            }
            catch (Exception)
            {
                Console.WriteLine("Alerts not displayed");
            }
        }

        public void CreateCaseAnonCustomer()
        {
            //Verify Home dashboard is displayed
            Thread.Sleep(4000);
            driver.FindElement(DashboardsLHN).Click();
            Thread.Sleep(2000);
            driver.FindElement(DashboardsLHN).Click();
            wait.Until(ExpectedConditions.ElementExists((By)DashboardTitle));
            Assert.IsTrue(driver.FindElement(DashboardTitle).Displayed);
            Thread.Sleep(3000);
            //Switch to searchbox iframe
            driver.SwitchTo().Frame(driver.FindElement(By.Id("9532b1de-41a1-456c-b21c-805faca15573_WebResource_customeradvisorstart")));
            wait.Until(ExpectedConditions.ElementExists((By)AccessChannelDropdown));
            //Select access channel
            Thread.Sleep(1000);
            driver.FindElement(AccessChannelDropdown).Click();
            Thread.Sleep(1000);
            driver.FindElement(AccessChannelOptionPhone).Click();
            //Enter search term
            Thread.Sleep(1000);
            driver.FindElement(FAQSearchBox).Click();
            Thread.Sleep(1000);
            driver.FindElement(FAQSearchBox).SendKeys("Dog");
            Thread.Sleep(2000);
            //Verify service result is shown and click on it
            wait.Until(ExpectedConditions.ElementExists((By)DogSearchResult));
            Assert.IsTrue(driver.FindElement(DogSearchResult).Displayed);
            driver.FindElement(DogSearchResult).Click();
            Thread.Sleep(2000);
            //Verify customer name and service shown on the create new case overlay
            driver.SwitchTo().DefaultContent();
            wait.Until(ExpectedConditions.ElementExists((By)AnonCustomerOnNewCaseOverlay));
            Assert.IsTrue(driver.FindElement(AnonCustomerOnNewCaseOverlay).Displayed);
            wait.Until(ExpectedConditions.ElementExists((By)ServiceOnNewCaseOverlay));
            Assert.IsTrue(driver.FindElement(ServiceOnNewCaseOverlay).Displayed);
            //Click yes on overlay
            wait.Until(ExpectedConditions.ElementExists((By)YesBtnOnNewCaseOverlay));
            driver.FindElement(YesBtnOnNewCaseOverlay).Click();
            Thread.Sleep(3000);
            //Verify dog fouling form loads
            wait.Until(ExpectedConditions.ElementExists((By)DogFoulingFormTitle));
            Assert.IsTrue(driver.FindElement(DogFoulingFormTitle).Displayed);
            //Enter address for location
            driver.SwitchTo().Frame("WebResource_WMDCAddressSearch");
            driver.FindElement(AddressSearchBox).Click();
            driver.FindElement(AddressSearchBox).SendKeys("6 Sandhill Rise Pontefract WF8 1RA");
            Thread.Sleep(2000);
            driver.FindElement(AddressSearchBtn).Click();
            wait.Until(ExpectedConditions.ElementExists((By)AddressSearchBoxResult));
            driver.FindElement(AddressSearchBoxResult).Click();
            driver.SwitchTo().DefaultContent();
            Thread.Sleep(5000);
            // Select public land type
            Actions actions = new Actions(driver);
            actions.SendKeys(Keys.PageDown).Build().Perform();
            Thread.Sleep(2000);
            driver.FindElement(DogFoulingLandType).Click();
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)DogFoulingLandDropdown));
            driver.FindElement(DogFoulingLandDropdown).Click();
            Thread.Sleep(2000);
            driver.FindElement(ExactLocationTxt).Click();
            //Enter no in exact location box
            wait.Until(ExpectedConditions.ElementExists((By)DogFoulingExactLocation));
            driver.FindElement(DogFoulingExactLocation).Click();
            driver.FindElement(DogFoulingExactLocation).SendKeys("No");
            //Select no on recurring problem dropdown
            wait.Until(ExpectedConditions.ElementExists((By)DogFoulingRecurringProblem));
            driver.FindElement(DogFoulingRecurringProblem).Click();
            Thread.Sleep(2000);
            SelectElement select = new SelectElement(driver.FindElement(DogFoulingRecurringProblem));
            select.SelectByText("No");
            //Select no on do you know who dropdown
            wait.Until(ExpectedConditions.ElementExists((By)DogFoulingWhoDropdown));
            driver.FindElement(DogFoulingWhoDropdown).Click();
            Thread.Sleep(2000);
            SelectElement select1 = new SelectElement(driver.FindElement(DogFoulingWhoDropdown));
            select1.SelectByText("No");
            Thread.Sleep(2000);
            driver.FindElement(DogFoulingWhoLabel).Click();
            Thread.Sleep(2000);
            Actions action = new Actions(driver);
            action.SendKeys(Keys.PageDown).Build().Perform();
            Thread.Sleep(2000);
            //Click allocate box
            driver.SwitchTo().Frame("WebResource_allocatingpanel");
            wait.Until(ExpectedConditions.ElementExists((By)AllocateBtn));
            driver.FindElement(AllocateBtn).Click();
            Thread.Sleep(2000);
            driver.SwitchTo().DefaultContent();
            Thread.Sleep(5000);
            //Click cases on LHN
            wait.Until(ExpectedConditions.ElementExists((By)CasesOnLHN));
            Thread.Sleep(2000);
            driver.FindElement(CasesOnLHN).Click();
            Thread.Sleep(3000);
            wait.Until(ExpectedConditions.ElementExists((By)ActiveCasesTitle));
            Assert.IsTrue(driver.FindElement(ActiveCasesTitle).Displayed);
            Thread.Sleep(2000);
            //verify anon customer name is on the list
            wait.Until(ExpectedConditions.ElementExists((By)AnonCustomerOnCasesList));
            Assert.IsTrue(driver.FindElement(AnonCustomerOnCasesList).Displayed);

        }

        public void BinCollection()
        {
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)DashboardTitle));
            Assert.IsTrue(driver.FindElement(DashboardTitle).Displayed);
            Thread.Sleep(3000);
            driver.SwitchTo().Frame(driver.FindElement(By.Id("9532b1de-41a1-456c-b21c-805faca15573_WebResource_customeradvisorstart")));
            wait.Until(ExpectedConditions.ElementExists((By)Searchbox));
            Assert.IsTrue(driver.FindElement(Searchbox).Displayed);
            //Fullname
            driver.FindElement(Searchbox).Click();
            driver.FindElement(Searchbox).SendKeys("Gary Moore");
            driver.FindElement(Searchbox).SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)CustomerNameInDropdown));
            Assert.IsTrue(driver.FindElement(CustomerNameInDropdown).Displayed);
            driver.FindElement(CustomerNameInDropdown).Click();
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)CustomerNameInAccessChannel));
            Assert.IsTrue(driver.FindElement(CustomerNameInAccessChannel).Displayed);
            driver.FindElement(CustomerNameInAccessChannel).Click();
            driver.SwitchTo().DefaultContent();
            Thread.Sleep(2000);
            // Click waste collections tab
            wait.Until(ExpectedConditions.ElementExists((By)WasteCollectionsTab));
            driver.FindElement(WasteCollectionsTab).Click();
            Thread.Sleep(5000);
            //Verify bin collection dates are shown
            driver.SwitchTo().Frame(driver.FindElement(By.Id("WebResource_GetDomesticRefuseCollectionDates_Customer")));
            wait.Until(ExpectedConditions.ElementExists((By)WasteCollectionDates));
            Assert.IsTrue(driver.FindElement(WasteCollectionDates).Displayed);
        }

        public void OnBehalfOf()
        {
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)DashboardTitle));
            Assert.IsTrue(driver.FindElement(DashboardTitle).Displayed);
            Thread.Sleep(3000);
            driver.SwitchTo().Frame(driver.FindElement(By.Id("9532b1de-41a1-456c-b21c-805faca15573_WebResource_customeradvisorstart")));
            wait.Until(ExpectedConditions.ElementExists((By)Searchbox));
            Assert.IsTrue(driver.FindElement(Searchbox).Displayed);
            //Fullname
            driver.FindElement(Searchbox).Click();
            driver.FindElement(Searchbox).SendKeys("Gary Moore");
            driver.FindElement(Searchbox).SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)CustomerNameInDropdown));
            Assert.IsTrue(driver.FindElement(CustomerNameInDropdown).Displayed);
            driver.FindElement(OnBehalfOfInDropdown).Click();
            driver.FindElement(CustomerNameInDropdown).Click();
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)ReportedByInAccessChannel));
            Assert.IsTrue(driver.FindElement(ReportedByInAccessChannel).Displayed);
            //Remove search term from box
            driver.FindElement(Searchbox).Click();
            Actions action = new Actions(driver);
            WebElement ele = (WebElement)driver.FindElement(Searchbox);
            action.Click(ele).Click(ele).Click(ele).Perform();
            driver.FindElement(Searchbox).SendKeys(Keys.Delete);
            //Re search for same customer
            Thread.Sleep(2000);
            driver.FindElement(Searchbox).SendKeys("Gary Moore");
            driver.FindElement(Searchbox).SendKeys(Keys.Enter);
            wait.Until(ExpectedConditions.ElementExists((By)CustomerNameInDropdown));
            driver.FindElement(CustomerNameInDropdown).Click();
            Thread.Sleep(2000);
            //Verify overlay appears
            driver.SwitchTo().DefaultContent();
            wait.Until(ExpectedConditions.ElementExists((By)CustomerReporterOverlay));
            Assert.IsTrue(driver.FindElement(CustomerReporterOverlay).Displayed);
            driver.FindElement(CustomerReporterOverlayOk).Click();
            Thread.Sleep(2000);
            //Clear customer details from access channel
            driver.SwitchTo().Frame(driver.FindElement(By.Id("9532b1de-41a1-456c-b21c-805faca15573_WebResource_customeradvisorstart")));
            wait.Until(ExpectedConditions.ElementExists((By)AccessChannelClear));
            driver.FindElement(AccessChannelClear).Click();
            //Remove search term from box
            driver.FindElement(Searchbox).Click();
            WebElement ele1 = (WebElement)driver.FindElement(Searchbox);
            action.Click(ele1).Click(ele1).Click(ele1).Perform();
            driver.FindElement(Searchbox).SendKeys(Keys.Delete);
            //Re search for same customer
            Thread.Sleep(2000);
            driver.FindElement(Searchbox).SendKeys("Gary Moore");
            driver.FindElement(Searchbox).SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)CustomerNameInDropdown));
            Assert.IsTrue(driver.FindElement(CustomerNameInDropdown).Displayed);
            driver.FindElement(OnBehalfOfInDropdown).Click();
            driver.FindElement(CustomerNameInDropdown).Click();
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)ReportedByInAccessChannel));
            Assert.IsTrue(driver.FindElement(ReportedByInAccessChannel).Displayed);
            //Remove search term from box
            driver.FindElement(Searchbox).Click();
            WebElement ele2 = (WebElement)driver.FindElement(Searchbox);
            action.Click(ele2).Click(ele2).Click(ele2).Perform();
            driver.FindElement(Searchbox).SendKeys(Keys.Delete);
            //Search for different customer
            Thread.Sleep(2000);
            driver.FindElement(Searchbox).SendKeys("Gary Test");
            driver.FindElement(Searchbox).SendKeys(Keys.Enter);
            wait.Until(ExpectedConditions.ElementExists((By)GaryTestInDropdown));
            Assert.IsTrue(driver.FindElement(GaryTestInDropdown).Displayed);
            driver.FindElement(GaryTestInDropdown).Click();
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)GaryTestInAccessChannel));
            Assert.IsTrue(driver.FindElement(GaryTestInAccessChannel).Displayed);
            Thread.Sleep(2000);
            //Verify Alerts shown
            wait.Until(ExpectedConditions.ElementExists((By)BlindAlert));
            Assert.IsTrue(driver.FindElement(BlindAlert).Displayed);
            wait.Until(ExpectedConditions.ElementExists((By)DeafAlert));
            Assert.IsTrue(driver.FindElement(DeafAlert).Displayed);
        }

        public void SearchFAQOnBehalfOf()
        {
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)DashboardTitle));
            Assert.IsTrue(driver.FindElement(DashboardTitle).Displayed);
            Thread.Sleep(3000);
            driver.SwitchTo().Frame(driver.FindElement(By.Id("9532b1de-41a1-456c-b21c-805faca15573_WebResource_customeradvisorstart")));
            wait.Until(ExpectedConditions.ElementExists((By)Searchbox));
            Assert.IsTrue(driver.FindElement(Searchbox).Displayed);
            //Fullname
            driver.FindElement(Searchbox).Click();
            driver.FindElement(Searchbox).SendKeys("Gary Moore");
            driver.FindElement(Searchbox).SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)CustomerNameInDropdown));
            Assert.IsTrue(driver.FindElement(CustomerNameInDropdown).Displayed);
            driver.FindElement(OnBehalfOfInDropdown).Click();
            driver.FindElement(CustomerNameInDropdown).Click();
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)ReportedByInAccessChannel));
            Assert.IsTrue(driver.FindElement(ReportedByInAccessChannel).Displayed);
            //Remove search term from box
            driver.FindElement(Searchbox).Click();
            Actions action = new Actions(driver);
            WebElement ele = (WebElement)driver.FindElement(Searchbox);
            action.Click(ele).Click(ele).Click(ele).Perform();
            driver.FindElement(Searchbox).SendKeys(Keys.Delete);
            //Search for different customer
            Thread.Sleep(2000);
            driver.FindElement(Searchbox).SendKeys("Gary Test");
            driver.FindElement(Searchbox).SendKeys(Keys.Enter);
            wait.Until(ExpectedConditions.ElementExists((By)GaryTestInDropdown));
            Assert.IsTrue(driver.FindElement(GaryTestInDropdown).Displayed);
            driver.FindElement(GaryTestInDropdown).Click();
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)GaryTestInAccessChannel));
            Assert.IsTrue(driver.FindElement(GaryTestInAccessChannel).Displayed);
            Thread.Sleep(2000);
            //Search for FAQ
            driver.FindElement(FAQSearchBox).Click();
            Thread.Sleep(1000);
            driver.FindElement(FAQSearchBox).SendKeys("My account");
            Thread.Sleep(2000);
            //Verify service result is shown
            wait.Until(ExpectedConditions.ElementExists((By)FAQSearchServiceResult));
            Assert.IsTrue(driver.FindElement(FAQSearchServiceResult).Displayed);
            //Select access channel
            Thread.Sleep(1000);
            driver.FindElement(AccessChannelDropdown).Click();
            Thread.Sleep(1000);
            driver.FindElement(AccessChannelOptionPhone).Click();
            //Search another term
            Thread.Sleep(1000);
            driver.FindElement(FAQSearchBox).Click();
            Thread.Sleep(1000);
            WebElement ele1 = (WebElement)driver.FindElement(FAQSearchBox);
            action.Click(ele1).Click(ele1).Click(ele1).Perform();
            driver.FindElement(FAQSearchBox).SendKeys(Keys.Delete);
            driver.FindElement(FAQSearchBox).SendKeys("Tip");
            Thread.Sleep(2000);
            //Verify FAQ result is shown
            wait.Until(ExpectedConditions.ElementExists((By)FAQSearchResult));
            Assert.IsTrue(driver.FindElement(FAQSearchResult).Displayed);
            driver.FindElement(FAQSearchResult).Click();
            Thread.Sleep(2000);
            //Verify record answer appears
            wait.Until(ExpectedConditions.ElementExists((By)FAQRecordAnswerGiven));
            Assert.IsTrue(driver.FindElement(FAQRecordAnswerGiven).Displayed);
            driver.FindElement(FAQRecordAnswerGiven).Click();
            Thread.Sleep(2000);
            //Verify answer has been recorded
            wait.Until(ExpectedConditions.ElementExists((By)FAQAnswerRecorded));
            Assert.IsTrue(driver.FindElement(FAQAnswerRecorded).Displayed);
            //Select more information
            Thread.Sleep(1000);
            driver.FindElement(FAQMoreInfo).Click();
            Thread.Sleep(2000);
            //Verify more info page is shown
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            wait.Until(ExpectedConditions.ElementExists((By)FAQMoreInfoPage));
            Assert.IsTrue(driver.FindElement(FAQMoreInfoPage).Displayed);
            Thread.Sleep(2000);
            driver.Close();
            driver.SwitchTo().Window(driver.WindowHandles.First());
            //search for food
            driver.SwitchTo().Frame(driver.FindElement(By.Id("9532b1de-41a1-456c-b21c-805faca15573_WebResource_customeradvisorstart")));
            Thread.Sleep(2000);
            WebElement ele2 = (WebElement)driver.FindElement(FAQSearchBox);
            action.Click(ele2).Click(ele2).Click(ele2).Perform();
            driver.FindElement(FAQSearchBox).SendKeys(Keys.Delete);
            driver.FindElement(FAQSearchBox).SendKeys("Food");
            driver.FindElement(FAQSearchBox).SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            //click answer that is displayed
            driver.FindElement(FAQFoodAnswer).Click();
            Thread.Sleep(2000);
            //click record as signposted
            driver.FindElement(FAQRecordSignposted).Click();
            Thread.Sleep(4000);
            //Verify answer has been recorded
            wait.Until(ExpectedConditions.ElementExists((By)FAQAnswerRecorded));
            Assert.IsTrue(driver.FindElement(FAQAnswerRecorded).Displayed);
        }

        public void PreviousBusinessHistory()
        {
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)DashboardTitle));
            Assert.IsTrue(driver.FindElement(DashboardTitle).Displayed);
            Thread.Sleep(3000);
            driver.SwitchTo().Frame(driver.FindElement(By.Id("9532b1de-41a1-456c-b21c-805faca15573_WebResource_customeradvisorstart")));
            wait.Until(ExpectedConditions.ElementExists((By)Searchbox));
            Assert.IsTrue(driver.FindElement(Searchbox).Displayed);
            //Business name
            Actions action = new Actions(driver);
            WebElement ele9 = (WebElement)driver.FindElement(Searchbox);
            action.Click(ele9).Click(ele9).Click(ele9).Perform();
            driver.FindElement(Searchbox).SendKeys(Keys.Delete);
            driver.FindElement(Searchbox).SendKeys("test cafe");
            driver.FindElement(Searchbox).SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)ModifiedBusinessSearchDropdown));
            Assert.IsTrue(driver.FindElement(ModifiedBusinessSearchDropdown).Displayed);
            driver.FindElement(ModifiedBusinessSearchDropdown).Click();
            Thread.Sleep(2000);
            //Select Business from link below access channel
            wait.Until(ExpectedConditions.ElementExists((By)ExistingBusinessSearchResult));
            Assert.IsTrue(driver.FindElement(ExistingBusinessSearchResult).Displayed);
            driver.FindElement(ExistingBusinessSearchResult).Click();
            driver.SwitchTo().DefaultContent();
            //Verify business profile loads
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)TestCafeProfileTitle));
            //Click update address
            driver.SwitchTo().Frame(driver.FindElement(By.Id("WebResource_WMDCCustomerAddressSearch")));
            wait.Until(ExpectedConditions.ElementExists((By)UpdateAddressLink));
            driver.FindElement(UpdateAddressLink).Click();
            //Enter new in area address
            wait.Until(ExpectedConditions.ElementExists((By)NewBusinessAddress));
            driver.FindElement(NewBusinessAddress).Click();
            driver.FindElement(NewBusinessAddress).SendKeys("4 Sandhill Rise Pontefract WF8 1RA");
            driver.FindElement(NewBusinessAddress).SendKeys(Keys.Enter);
            wait.Until(ExpectedConditions.ElementExists((By)NewBusinessAddressDropdown));
            driver.FindElement(NewBusinessAddressDropdown).Click();
            driver.SwitchTo().DefaultContent();
            //Click save
            wait.Until(ExpectedConditions.ElementExists((By)NewBusinessSaveBtn));
            driver.FindElement(NewBusinessSaveBtn).Click();
            //Navigate back to dashboards
            wait.Until(ExpectedConditions.ElementExists((By)DashboardsLHN));
            driver.FindElement(DashboardsLHN).Click();
            wait.Until(ExpectedConditions.ElementExists((By)DashboardTitle));
            //Search for business
            Thread.Sleep(3000);
            driver.SwitchTo().Frame(driver.FindElement(By.Id("9532b1de-41a1-456c-b21c-805faca15573_WebResource_customeradvisorstart")));
            wait.Until(ExpectedConditions.ElementExists((By)Searchbox));
            Assert.IsTrue(driver.FindElement(Searchbox).Displayed);
            //Business name
            WebElement ele = (WebElement)driver.FindElement(Searchbox);
            action.Click(ele).Click(ele).Click(ele).Perform();
            driver.FindElement(Searchbox).SendKeys(Keys.Delete);
            driver.FindElement(Searchbox).SendKeys("test cafe");
            driver.FindElement(Searchbox).SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)ModifiedBusinessSearchDropdown));
            Assert.IsTrue(driver.FindElement(ModifiedBusinessSearchDropdown).Displayed);
            driver.FindElement(ModifiedBusinessSearchDropdown).Click();
            Thread.Sleep(2000);
            //Verify address is correct
            wait.Until(ExpectedConditions.ElementExists((By)ModifiedBusinessAddress));
            Assert.IsTrue(driver.FindElement(ModifiedBusinessAddress).Displayed);
            //Select Business from link below access channel
            wait.Until(ExpectedConditions.ElementExists((By)ExistingBusinessSearchResult));
            Assert.IsTrue(driver.FindElement(ExistingBusinessSearchResult).Displayed);
            driver.FindElement(ExistingBusinessSearchResult).Click();
            driver.SwitchTo().DefaultContent();
            //Verify business profile loads
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)TestCafeProfileTitle));
            //Click update address
            driver.SwitchTo().Frame(driver.FindElement(By.Id("WebResource_WMDCCustomerAddressSearch")));
            wait.Until(ExpectedConditions.ElementExists((By)UpdateAddressLink));
            driver.FindElement(UpdateAddressLink).Click();
            //Enter new out of area address
            wait.Until(ExpectedConditions.ElementExists((By)NewBusinessAddress));
            driver.FindElement(NewBusinessAddress).Click();
            driver.FindElement(NewBusinessAddress).SendKeys("Pontefract");
            driver.FindElement(NewBusinessAddress).SendKeys(Keys.Enter);
            wait.Until(ExpectedConditions.ElementExists((By)ModifiedBusinessAddressOOADropdown));
            driver.FindElement(ModifiedBusinessAddressOOADropdown).Click();
            driver.SwitchTo().DefaultContent();
            //Click save
            wait.Until(ExpectedConditions.ElementExists((By)NewBusinessSaveBtn));
            driver.FindElement(NewBusinessSaveBtn).Click();
            //Navigate back to dashboards
            wait.Until(ExpectedConditions.ElementExists((By)DashboardsLHN));
            driver.FindElement(DashboardsLHN).Click();
            wait.Until(ExpectedConditions.ElementExists((By)DashboardTitle));
            //Search for business
            Thread.Sleep(3000);
            driver.SwitchTo().Frame(driver.FindElement(By.Id("9532b1de-41a1-456c-b21c-805faca15573_WebResource_customeradvisorstart")));
            wait.Until(ExpectedConditions.ElementExists((By)Searchbox));
            Assert.IsTrue(driver.FindElement(Searchbox).Displayed);
            //Business name
            WebElement ele1 = (WebElement)driver.FindElement(Searchbox);
            action.Click(ele1).Click(ele1).Click(ele1).Perform();
            driver.FindElement(Searchbox).SendKeys(Keys.Delete);
            driver.FindElement(Searchbox).SendKeys("test cafe");
            driver.FindElement(Searchbox).SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)ModifiedBusinessSearchDropdown));
            Assert.IsTrue(driver.FindElement(ModifiedBusinessSearchDropdown).Displayed);
            driver.FindElement(ModifiedBusinessSearchDropdown).Click();
            Thread.Sleep(2000);
            //Verify address is correct
            wait.Until(ExpectedConditions.ElementExists((By)ModifiedBusinessAddressOOA));
            Assert.IsTrue(driver.FindElement(ModifiedBusinessAddressOOA).Displayed);
            //Select Business from link below access channel
            wait.Until(ExpectedConditions.ElementExists((By)ExistingBusinessSearchResult));
            Assert.IsTrue(driver.FindElement(ExistingBusinessSearchResult).Displayed);
            driver.FindElement(ExistingBusinessSearchResult).Click();
            driver.SwitchTo().DefaultContent();
            //Verify business profile loads
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)TestCafeProfileTitle));
            //Click update address
            driver.SwitchTo().Frame(driver.FindElement(By.Id("WebResource_WMDCCustomerAddressSearch")));
            wait.Until(ExpectedConditions.ElementExists((By)UpdateAddressLink));
            driver.FindElement(UpdateAddressLink).Click();
            //Enter new manual address
            //Click can't find address link
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
            //Click save
            wait.Until(ExpectedConditions.ElementExists((By)NewBusinessSaveBtn));
            driver.FindElement(NewBusinessSaveBtn).Click();
            //Navigate back to dashboards
            wait.Until(ExpectedConditions.ElementExists((By)DashboardsLHN));
            driver.FindElement(DashboardsLHN).Click();
            wait.Until(ExpectedConditions.ElementExists((By)DashboardTitle));
            //Search for business
            Thread.Sleep(3000);
            driver.SwitchTo().Frame(driver.FindElement(By.Id("9532b1de-41a1-456c-b21c-805faca15573_WebResource_customeradvisorstart")));
            wait.Until(ExpectedConditions.ElementExists((By)Searchbox));
            Assert.IsTrue(driver.FindElement(Searchbox).Displayed);
            //Business name
            WebElement ele2 = (WebElement)driver.FindElement(Searchbox);
            action.Click(ele2).Click(ele2).Click(ele2).Perform();
            driver.FindElement(Searchbox).SendKeys(Keys.Delete);
            driver.FindElement(Searchbox).SendKeys("test cafe");
            driver.FindElement(Searchbox).SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)ModifiedBusinessSearchDropdown));
            Assert.IsTrue(driver.FindElement(ModifiedBusinessSearchDropdown).Displayed);
            driver.FindElement(ModifiedBusinessSearchDropdown).Click();
            Thread.Sleep(2000);
            //Verify address is correct
            wait.Until(ExpectedConditions.ElementExists(ModifiedBusinessAddressCaps));
            Assert.IsTrue(driver.FindElement(ModifiedBusinessAddressCaps).Displayed);
            //Select Business from link below access channel
            wait.Until(ExpectedConditions.ElementExists((By)ExistingBusinessSearchResult));
            Assert.IsTrue(driver.FindElement(ExistingBusinessSearchResult).Displayed);
            driver.FindElement(ExistingBusinessSearchResult).Click();
            driver.SwitchTo().DefaultContent();
            //Verify business profile loads
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)TestCafeProfileTitle));
            //Click update address
            driver.SwitchTo().Frame(driver.FindElement(By.Id("WebResource_WMDCCustomerAddressSearch")));
            wait.Until(ExpectedConditions.ElementExists((By)UpdateAddressLink));
            driver.FindElement(UpdateAddressLink).Click();
            //Enter new unknown address
            wait.Until(ExpectedConditions.ElementExists((By)UnknownAddressLink));
            driver.FindElement(UnknownAddressLink).Click();
            driver.SwitchTo().DefaultContent();
            wait.Until(ExpectedConditions.ElementExists((By)UnderstandBtnOnOverlay));
            driver.FindElement(UnderstandBtnOnOverlay).Click();
            driver.SwitchTo().Frame(driver.FindElement(By.Id("WebResource_WMDCCustomerAddressSearch")));
            wait.Until(ExpectedConditions.ElementExists((By)UnknownAdressSelected));
            Assert.IsTrue(driver.FindElement(UnknownAdressSelected).Displayed);
            //Click Undon button
            wait.Until(ExpectedConditions.ElementExists((By)UpdateAddressUndoBtn));
            driver.FindElement(UpdateAddressUndoBtn).Click();
            //verify previous address is shown
            driver.SwitchTo().DefaultContent();
            wait.Until(ExpectedConditions.ElementExists((By)PreviousAddressOnProfile));
            Assert.IsTrue(driver.FindElement(PreviousAddressOnProfile).Displayed);
            //Click save
            wait.Until(ExpectedConditions.ElementExists((By)NewBusinessSaveBtn));
            driver.FindElement(NewBusinessSaveBtn).Click();
            //Click history tab
            wait.Until(ExpectedConditions.ElementExists((By)HistoryTabOnCustomer));
            driver.FindElement(HistoryTabOnCustomer).Click();
            //Check start and end date shown on previous history
            wait.Until(ExpectedConditions.ElementExists((By)PreviousBusinessAddresses));
            wait.Until(ExpectedConditions.ElementExists((By)PreviousAddressInTable));
            driver.FindElement(PreviousAddressInTable).Click();
            wait.Until(ExpectedConditions.ElementExists((By)AddressStartDateLabel));
            Assert.IsTrue(driver.FindElement(AddressStartDateLabel).Displayed);
            Assert.IsTrue(driver.FindElement(AddressEndDateLabel).Displayed);

        }

        public void OnBehalfOfBusiness()
        {
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)DashboardTitle));
            Assert.IsTrue(driver.FindElement(DashboardTitle).Displayed);
            Thread.Sleep(3000);
            driver.SwitchTo().Frame(driver.FindElement(By.Id("9532b1de-41a1-456c-b21c-805faca15573_WebResource_customeradvisorstart")));
            wait.Until(ExpectedConditions.ElementExists((By)Searchbox));
            Assert.IsTrue(driver.FindElement(Searchbox).Displayed);
            //Business Name
            driver.FindElement(Searchbox).Click();
            driver.FindElement(Searchbox).SendKeys("Test Cafe");
            driver.FindElement(Searchbox).SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)ExistingBusinessSearchDropdown));
            Assert.IsTrue(driver.FindElement(ExistingBusinessSearchDropdown).Displayed);
            driver.FindElement(OnBehalfOfInDropdown).Click();
            driver.FindElement(ExistingBusinessSearchDropdown).Click();
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)ReportedByInAccessChannel));
            Assert.IsTrue(driver.FindElement(ReportedByInAccessChannel).Displayed);
            //Remove search term from box
            driver.FindElement(Searchbox).Click();
            Actions action = new Actions(driver);
            WebElement ele = (WebElement)driver.FindElement(Searchbox);
            action.Click(ele).Click(ele).Click(ele).Perform();
            driver.FindElement(Searchbox).SendKeys(Keys.Delete);
            //Re search for same customer
            Thread.Sleep(2000);
            driver.FindElement(Searchbox).SendKeys("Test Cafe");
            driver.FindElement(Searchbox).SendKeys(Keys.Enter);
            wait.Until(ExpectedConditions.ElementExists((By)ExistingBusinessSearchDropdown));
            driver.FindElement(ExistingBusinessSearchDropdown).Click();
            Thread.Sleep(2000);
            //Verify overlay appears
            driver.SwitchTo().DefaultContent();
            wait.Until(ExpectedConditions.ElementExists((By)CustomerReporterOverlay));
            Assert.IsTrue(driver.FindElement(CustomerReporterOverlay).Displayed);
            driver.FindElement(CustomerReporterOverlayOk).Click();
            Thread.Sleep(2000);
            //Clear customer details from access channel
            driver.SwitchTo().Frame(driver.FindElement(By.Id("9532b1de-41a1-456c-b21c-805faca15573_WebResource_customeradvisorstart")));
            wait.Until(ExpectedConditions.ElementExists((By)AccessChannelClear));
            driver.FindElement(AccessChannelClear).Click();
            //Remove search term from box
            driver.FindElement(Searchbox).Click();
            WebElement ele1 = (WebElement)driver.FindElement(Searchbox);
            action.Click(ele1).Click(ele1).Click(ele1).Perform();
            driver.FindElement(Searchbox).SendKeys(Keys.Delete);
            //Re search for same customer
            Thread.Sleep(2000);
            driver.FindElement(Searchbox).SendKeys("Test Cafe");
            driver.FindElement(Searchbox).SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)ExistingBusinessSearchDropdown));
            Assert.IsTrue(driver.FindElement(ExistingBusinessSearchDropdown).Displayed);
            driver.FindElement(OnBehalfOfInDropdown).Click();
            driver.FindElement(ExistingBusinessSearchDropdown).Click();
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)ReportedByInAccessChannel));
            Assert.IsTrue(driver.FindElement(ReportedByInAccessChannel).Displayed);
            //Remove search term from box
            driver.FindElement(Searchbox).Click();
            WebElement ele2 = (WebElement)driver.FindElement(Searchbox);
            action.Click(ele2).Click(ele2).Click(ele2).Perform();
            driver.FindElement(Searchbox).SendKeys(Keys.Delete);
            //Search for different customer
            Thread.Sleep(2000);
            driver.FindElement(Searchbox).SendKeys("Test Business");
            driver.FindElement(Searchbox).SendKeys(Keys.Enter);
            wait.Until(ExpectedConditions.ElementExists((By)TestBusinessInDropdown));
            Assert.IsTrue(driver.FindElement(TestBusinessInDropdown).Displayed);
            driver.FindElement(TestBusinessInDropdown).Click();
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)TestBusinessInAccessChannel));
            Assert.IsTrue(driver.FindElement(TestBusinessInAccessChannel).Displayed);
            Thread.Sleep(2000);
        }

        public void BusinessSearchFAQOnBehalfOf()
        {
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)DashboardTitle));
            Assert.IsTrue(driver.FindElement(DashboardTitle).Displayed);
            Thread.Sleep(3000);
            driver.SwitchTo().Frame(driver.FindElement(By.Id("9532b1de-41a1-456c-b21c-805faca15573_WebResource_customeradvisorstart")));
            wait.Until(ExpectedConditions.ElementExists((By)Searchbox));
            Assert.IsTrue(driver.FindElement(Searchbox).Displayed);
            //Fullname
            driver.FindElement(Searchbox).Click();
            driver.FindElement(Searchbox).SendKeys("Test Cafe");
            driver.FindElement(Searchbox).SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)ExistingBusinessSearchDropdown));
            Assert.IsTrue(driver.FindElement(ExistingBusinessSearchDropdown).Displayed);
            driver.FindElement(OnBehalfOfInDropdown).Click();
            driver.FindElement(ExistingBusinessSearchDropdown).Click();
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)ReportedByInAccessChannel));
            Assert.IsTrue(driver.FindElement(ReportedByInAccessChannel).Displayed);
            //Remove search term from box
            driver.FindElement(Searchbox).Click();
            WebElement ele = (WebElement)driver.FindElement(Searchbox);
            Actions action = new Actions(driver);
            action.Click(ele).Click(ele).Click(ele).Perform();
            driver.FindElement(Searchbox).SendKeys(Keys.Delete);
            //Search for different customer
            Thread.Sleep(2000);
            driver.FindElement(Searchbox).SendKeys("Test Business");
            driver.FindElement(Searchbox).SendKeys(Keys.Enter);
            wait.Until(ExpectedConditions.ElementExists((By)TestBusinessInDropdown));
            Assert.IsTrue(driver.FindElement(TestBusinessInDropdown).Displayed);
            driver.FindElement(TestBusinessInDropdown).Click();
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)TestBusinessInAccessChannel));
            Assert.IsTrue(driver.FindElement(TestBusinessInAccessChannel).Displayed);
            Thread.Sleep(2000);
            //Search for FAQ
            driver.FindElement(FAQSearchBox).Click();
            Thread.Sleep(1000);
            driver.FindElement(FAQSearchBox).SendKeys("My account");
            Thread.Sleep(2000);
            //Verify service result is shown
            wait.Until(ExpectedConditions.ElementExists((By)FAQSearchServiceResult));
            Assert.IsTrue(driver.FindElement(FAQSearchServiceResult).Displayed);
            //Select access channel
            Thread.Sleep(1000);
            driver.FindElement(AccessChannelDropdown).Click();
            Thread.Sleep(1000);
            driver.FindElement(AccessChannelOptionPhone).Click();
            //Search another term
            Thread.Sleep(1000);
            driver.FindElement(FAQSearchBox).Click();
            Thread.Sleep(1000);
            ele = (WebElement)driver.FindElement(FAQSearchBox);
            action.Click(ele).Click(ele).Click(ele).Perform();
            driver.FindElement(FAQSearchBox).SendKeys(Keys.Delete);
            driver.FindElement(FAQSearchBox).SendKeys("Tip");
            Thread.Sleep(2000);
            //Verify FAQ result is shown
            wait.Until(ExpectedConditions.ElementExists((By)FAQSearchResult));
            Assert.IsTrue(driver.FindElement(FAQSearchResult).Displayed);
            driver.FindElement(FAQSearchResult).Click();
            Thread.Sleep(2000);
            //Verify record answer appears
            wait.Until(ExpectedConditions.ElementExists((By)FAQRecordAnswerGiven));
            Assert.IsTrue(driver.FindElement(FAQRecordAnswerGiven).Displayed);
            driver.FindElement(FAQRecordAnswerGiven).Click();
            Thread.Sleep(2000);
            //Verify answer has been recorded
            wait.Until(ExpectedConditions.ElementExists((By)FAQAnswerRecorded));
            Assert.IsTrue(driver.FindElement(FAQAnswerRecorded).Displayed);
            //Select more information
            Thread.Sleep(1000);
            driver.FindElement(FAQMoreInfo).Click();
            Thread.Sleep(2000);
            //Verify more info page is shown
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            wait.Until(ExpectedConditions.ElementExists((By)FAQMoreInfoPage));
            Assert.IsTrue(driver.FindElement(FAQMoreInfoPage).Displayed);
            Thread.Sleep(2000);
            driver.Close();
            driver.SwitchTo().Window(driver.WindowHandles.First());
            //search for food
            driver.SwitchTo().Frame(driver.FindElement(By.Id("9532b1de-41a1-456c-b21c-805faca15573_WebResource_customeradvisorstart")));
            Thread.Sleep(2000);
            ele = (WebElement)driver.FindElement(FAQSearchBox);
            action.Click(ele).Click(ele).Click(ele).Perform();
            driver.FindElement(FAQSearchBox).SendKeys(Keys.Delete);
            driver.FindElement(FAQSearchBox).SendKeys("Food");
            driver.FindElement(FAQSearchBox).SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            //click answer that is displayed
            driver.FindElement(FAQFoodAnswer).Click();
            Thread.Sleep(2000);
            //click record as signposted
            driver.FindElement(FAQRecordSignposted).Click();
            Thread.Sleep(4000);
            //Verify answer has been recorded
            wait.Until(ExpectedConditions.ElementExists((By)FAQAnswerRecorded));
            Assert.IsTrue(driver.FindElement(FAQAnswerRecorded).Displayed);
        }
    }
}
