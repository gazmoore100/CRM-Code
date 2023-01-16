using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace CRMRegressionPack.PageObjects
{
    public class CaseSummary
    {
        By DashboardsLHN = By.XPath("//span[contains(text(),'Dashboards')]");
        By DashboardTitle = By.XPath("//span[contains(text(),'Wakefield Home')]");
        By Searchbox = By.XPath("//input[@id='txtCustomerSearch']");
        By ExistingCustomerSearchDropdown = By.XPath("//a[contains(.,'MOORE, Gary 7 Sandhill Rise Pontefract WF8 1RA  (Email: garymoore@wakefield.gov.')]");
        By TestUserDetailsOnDropdown = By.XPath("//a[contains(text(),'TEST, Gary 6 Sandhill Rise Pontefract WF8 1RA')]");
        By CaseHistoryDetailsOnDropdown = By.XPath("//a[contains(text(),'CASEHISTORY, Gary 1 Sandhill Rise Pontefract WF8 1')]");
        By OutOfareaDetailsOnDropdown = By.XPath("//a[contains(text(),'OFAREA, Out 6 Pontefract Road Barnsley S71 1Aj')]");
        By OOACasehistoryDetailsOnDropdown = By.XPath("//a[contains(text(),'CASEHISTORY, Ooa 6 Pontefract Road Barnsley S71 1A')]");
        By UACaseHistoryDetailsOnDropdown = By.XPath("//a[contains(text(),'CASEHISTORY, Unknownaddress Unknown')]");
        By ManualAddressSearchDropdown = By.XPath("//a[contains(text(),'ADDRESS, Manual 80 SPRING AVENUE, ASHBY-DE-LA-ZOUC')]");
        By MASearchDropdown = By.XPath("//a[contains(text(),'CASEHISTORY, Manualaddress 90 SPRING AVENUE, ASHBY-DE-LA-ZOUC')]");
        By AnonCustomerSearchDropdown = By.XPath("//a[.='ADDRESS, Unknown Unknown  (Tel: 07777777777)']");
        By OnBehalfOfInDropdown = By.XPath("//input[@type='checkbox']");
        By GaryTestInDropdown = By.XPath("//a[normalize-space()='TEST, Gary 6 Sandhill Rise Pontefract WF8 1RA']");
        By GaryTestInAccessChannel = By.XPath("//a[normalize-space()='Gary Test']");
        By ExistingBusinessSearchDropdown = By.XPath("//a[contains(text(),'Test Cafe')]");
        By ExistingBusinessSearchResult = By.XPath("//a[contains(text(),'Test Cafe')]");
        By BusinessHistoryDetailsOnDropdown = By.XPath("//a[contains(text(),'Business Casehistory 6 Sandhill Rise Pontefract WF')]");
        By UABusinessSearchDropdown = By.XPath("//a[contains(.,'Unknown Business Unknown')]");
        By UABusinessSearchResult = By.XPath("//a[.='Unknown Business']");
        By UACasesSearchDropdown = By.XPath("//a[contains(.,'Unknown AddressCases Unknown')]");
        By UACasesSearchResult = By.XPath("//a[.='Unknown AddressCases']");
        By CaseStatusOnDropdown = By.XPath("//a[normalize-space()='STATUS, Case 9 Sandhill Rise Pontefract WF8 1RA']");
        By CaseStatusSearchResult = By.XPath("//a[normalize-space()='case status']");


        By ExistingCustomerSearchResult = By.XPath("//a[contains(text(),'Gary Moore')]");
        By TestUserSearchResult = By.XPath("//a[contains(text(),'Gary Test')]");
        By OutOfareaSearchResult = By.XPath("//a[contains(text(),'Out Ofarea')]");
        By CasehistorySearchResult = By.XPath("//a[contains(text(),'Gary Casehistory')]");
        By OOACasehistorySearchResult = By.XPath("//a[contains(text(),'Ooa Casehistory')]");
        By ManualAddressSearchResult = By.XPath("//a[contains(text(),'Manual Address')]");
        By MACasehistorySearchResult = By.XPath("//a[contains(text(),'Manualaddress Casehistory')]");
        By AnonAddressSearchResult = By.XPath("//a[contains(text(),'Unknown Address')]");
        By UnknownAddressSearchResult = By.XPath("//a[contains(text(),'Unknownaddress Casehistory')]");
        By BusinessHistorySearchResult = By.XPath("//a[normalize-space()='Business Casehistory']");



        By FAQSearchBox = By.XPath("//input[@placeholder='Enter keywords to search for a service or FAQ']");
        By FAQSearchServiceResult = By.XPath("//a[.='Dog Fouling']");
        By FAQSearchNoiseResult = By.XPath("//a[normalize-space()='Noise']");
        By AccessChannelDropdown = By.XPath("//select[@id='accessChannel']");
        By AccessChannelOptionPhone = By.XPath("//option[contains(text(),'Phone')]");
        By CaseHistoryUnderAcessChannel = By.XPath("//td[.='Dog Fouling']");
        By DiscardedCaseUnderAcessChannel = By.XPath("//td[normalize-space()='Litter/Dog Bin']");
        By CaseHistoryAsterisk = By.XPath("//tbody[1]/tr[1]//sup[@class='asterisk']");

        By CaseHistoryStatus = By.XPath("//tr[2]/td[.='Active']");
        By CaseHistoryCancelled = By.XPath("//td[contains(text(),'Cancelled')]");
        By CaseHistoryResolved = By.XPath("//td[contains(text(),'Resolved')]");

        By CustomerNameOnNewCaseOverlay = By.XPath("//h2[contains(text(),'Gary Moore')]");
        By TestNameOnNewCaseOverlay = By.XPath("//h2[contains(text(),'Gary Test')]");
        By OOANameOnNewCaseOverlay = By.XPath("//h2[contains(text(),'Out Ofarea')]");
        By ManualAddressOnNewCaseOverlay = By.XPath("//h2[contains(text(),'Manual Address')]");
        By AnonCustomerOnNewCaseOverlay = By.XPath("//h2[contains(text(),'ANONYMOUS CUSTOMER')]");
        By UnknownAddressOnNewCaseOverlay = By.XPath("//h2[contains(text(),'Unknown Address')]");
        By BusinessNameOnNewCaseOverlay = By.XPath("//h2[contains(text(),'Test Cafe')]");
        By UABusinessOnNewCaseOverlay = By.XPath("//h2[text()='Unknown Business']");

        By ServiceOnNewCaseOverlay = By.XPath("//span[contains(text(),'Dog Fouling')]");
        By YesBtnOnNewCaseOverlay = By.XPath("//span[normalize-space()='Yes']");

        By DogFoulingFormTitle = By.XPath("//h1[contains(text(),'Dog Fouling Form')]");
        By DogLitterBinFormTitle = By.XPath("//h1[@title='Litter/Dog Bin Form']");
        By NoiseFormTitle = By.XPath("//h1[@title='Noise Form']");


        By AddressSearchBox = By.XPath("//input[@placeholder='Search for an address']");
        By AddressSearchBtn = By.XPath("//button[@id='btnAddressSearch']");
        By AddressSearchBoxResult = By.XPath("//option[contains(text(),'6 Sandhill Rise Pontefract WF8 1RA')]");
        By DiscardedAddressSearchBoxResult = By.XPath("//option[.='Acacia Avenue South Elmsall Pontefract']");
        By NewCustomerAddressDropdown = By.XPath("//option[.='6 Pontefract Road Barnsley S71 1Aj']");
        By DogFoulingLandType = By.CssSelector("[aria-label='Land Type']");
        By DogFoulingLandDropdown = By.XPath("//option[contains(text(),'Public')]");
        By DogFoulingLandPrivate = By.XPath("//option[contains(text(),'Private')]");
        By ExactLocationTxt = By.XPath("//label[contains(text(),'Can you give us an exact location of the dog fouli')]");
        By DogFoulingExactLocation = By.CssSelector("[aria-label='Can you give us an exact location of the dog fouling?']");
        By DogFoulingRecurringProblem = By.CssSelector("[aria-label='Is this a recurring problem?']");
        By DogFoulingWhoDropdown = By.CssSelector("[aria-label='Do you know who is letting their dog foul?']");
        By DogFoulingWhoLabel = By.XPath("//label[contains(text(),'Do you know who is letting their dog foul?')]");
        By DomesticNoiseType = By.XPath("//option[normalize-space()='Domestic']");
        By AnimalNoiseType = By.XPath("//option[.='Dogs and other Animals/Birds']");
        By AnimalNoiseTypeFreeTextBox = By.XPath("//textarea[@aria-label='Where exactly is the noise coming from?']");
        By NoiseFrequencyFreeTextBox = By.XPath("//textarea[@aria-label='How often does the noise occur?']");
        By NoiseTimeFreeTextBox = By.XPath("//textarea[@aria-label='At what time does the noise occur?']");
        By NoiseSpokenToThemDropdown = By.XPath("//option[.='No']");
        By NoiseWillingToSpeakDropdown = By.XPath("//select[@aria-label='Are you willing to talk to the person?']//option[@value='762210001'][normalize-space()='No']");
        By ReasonFreeTextBox = By.XPath("//textarea[@aria-label='What is your reason for not wanting to talk to the person?']");


        By AllocateBtn = By.XPath("//button[contains(text(),'Allocate')]");
        By RejectBtn = By.XPath("//button[contains(text(),'Reject')]");
        By ResolveBtn = By.XPath("//button[contains(text(),'Resolve')]");
        By SignpostBtn = By.XPath("//button[contains(text(),'Signpost')]");
        By ResolveDropdown = By.XPath("//div[@class='chooseStatus']//select");
        By ImmediateleyResolveOption = By.XPath("//option[.='Immediately Resolve']");
        By BespokeSignposting = By.XPath("//option[contains(text(),'Bespoke Signposting')]");
        By BespokeSignpostingTextBox = By.XPath("//div[@class='chooseStatus']//div//textarea");
        By RejectReasonDropdown = By.XPath("//div[@class='chooseStatus']//select");
        By RejectReasonCustomerRejected = By.XPath("//option[.='Customer Rejecting']");
        By RejectCustomerMsg = By.XPath("//textarea[@id='customMessage']");
        By StatusSubmitBtn = By.XPath("//button[contains(text(),'Submit')]");

        By JobStatus = By.XPath("//div[contains(text(),'In Progress')]");
        By ResolvedJobStatus = By.XPath("//div[contains(text(),'Immediately Resolved')]");
        By SignpostedJobStatus = By.XPath("//div[contains(text(),'Signposted')]");
        By JobStatusOnCaseSummary = By.XPath("//div[contains(text(),'Customer Rejected')]");
        By SLATimer = By.CssSelector("[title='Time remaining to complete the action']");
        By SLATimerPaused = By.XPath("//label[@title='The timer is paused']");
        By SLATimerSucceeded = By.XPath("//label[@title='Action is completed']");


        By DefaultCustomerUpdate = By.XPath("//textarea[contains(text(),'fouling')]");
        By BespokePausingCustomerUpdate = By.XPath("(//label[contains(text(),'Status Update Added')])[1]");

        By AllocatedCaseForm = By.XPath("//span[contains(text(),'Allocated Case Form')]");
        By AllocatedCaseDropdownWakefield = By.XPath("//span[text()='Wakefield Council Case']");

        By CaseDetailsForm = By.XPath("//h2[contains(text(),'CASE DETAILS')]");
        By CaseDetailsRejectedUpdateMsg = By.XPath("//textarea[contains(text(),'This job has been rejected by the customer')]");
        By CaseDetailsResolvedUpdateMsg = By.XPath("//textarea[contains(text(),'This job has been immediately resolved')]");
        By StatusUpdateAdded = By.XPath("//label[text()='Status Update']");
        By CaseDetailsCustomerUpdate = By.XPath("//li[contains(text(),'Customer Updates')]");
        By CaseDetailsBespokePausing = By.XPath("//span[normalize-space()='Bespoke Pausing']");
        By CaseDetailsClosed = By.XPath("//span[.='Closing - Fouling Cleared']");
        By CaseDetailsRestarting = By.XPath("(//span[@aria-hidden='true'][normalize-space()='Restarting - Test'])[1]");


        By CustomerUpdateStatusMessage = By.XPath("//div[contains(text(),'Thank you for your enquiry. We will attempt to the clear the fouling as soon as possible')]");
        By CaseDetailsSummaryTab = By.XPath("//li[contains(text(),'Summary')]");
        By EmailMessageOnTimeline = By.XPath("//label[contains(text(),'Regarding your enquiry:')]");
        By EmailNotificationOnTimeline = By.XPath("//label[contains(text(),'Service : Dog Fouling Case ID :')]");
        By EmailMessageContentOnTimeline = By.XPath("//div[contains(text(),'fouling')]");
        By TimelineStatusClosed = By.XPath("//div[text()='Closed']");
        By CaseDetailsCurrentQueue = By.XPath("(//div[@title='SS Pontefract and Knottingley'])[1]");
        By OOACaseCurrentQueue = By.XPath("(//div[@title='Street Scene - Default'])[1]");
        By ManualAddressCaseCurrentQueue = By.XPath("(//div[@title='Street Scene - Default'])[1]");
        By CustomerNameCaseDetails = By.XPath("//div[@title='Gary Test']");
        By BusinessNameCaseDetails = By.XPath("//div[@title='Test Cafe']");
        By CustomerNameOnCustomerCases = By.XPath("(//span[text()='Gary Test'])[1]");
        By BusinessNameOnCustomerCases = By.XPath("(//span[text()='Test Cafe'])[1]");

        By ReporterNameOnCustomerCases = By.XPath("(//span[text()='Gary Moore'])[1]");
        By ReporterBusinessOnCustomerCases = By.XPath("(//span[text()='Test Business'])[1]");
        By ReporterNameOnCaseSummary = By.XPath("//div[@title='Gary Moore']");
        By ReporterBusinessOnCaseSummary = By.XPath("//div[@title='Test Business']");


        By ServiceFormLink = By.XPath("//div[contains(text(),'Dog Fouling Form')]");
        By RefreshButtonOnCaseDetails = By.XPath("//span[contains(text(),'Refresh')]");
        By DogFoulingFormStatusInactive = By.XPath("//span[text()='Read-only  This record’s status: Inactive']");

        By CasesOnLHN = By.XPath("//span[.='Cases']");
        By CustomerNameOnCasesList = By.XPath("(//span[text()='Gary Moore'])");
        By OutOfareaNameOnCaseList = By.XPath("(//span[text()='Out Ofarea'])[1]");
        By ManualAddressOnCasesList = By.XPath("(//span[text()='Manual Address'])[1]");
        By AnonNameOnCasesList = By.XPath("(//span[text()='Unknown Address'])[1]");
        By GaryTestOnCasesList = By.XPath("(//span[text()='Gary Test'])[1]");

        By BusinessNameOnCasesList = By.XPath("(//span[text()='Test Cafe'])[1]");
        By UABusinessOnCasesList = By.XPath("(//span[text()='Unknown Business'])[1]");
        By ActiveCasesTitle = By.XPath("//span[contains(text(),'Active Cases')]");
        By DeleteCasesOverlayBtn = By.XPath("//body/section/div/div/div/div/div/div/div/button[1]");
        By HistoryTabOnCustomer = By.XPath("//li[contains(text(),'History')]");
        By BespokeMsgOnHistoryTab = By.XPath("//div[contains(text(),'This is a signpost message')]");
        By CustomerStatusOnHistoryTab = By.XPath("//div[contains(text(),'This job has been rejected by the customer')]");
        By CustomerResolvedOnHistoryTab = By.XPath("//div[contains(text(),'This job has been immediately resolved')]");
        By SelectAllCasesBtn = By.XPath("//section[2]//div[1]//div[1]//div[1]//div[1]//div[1]//div[1]//div[2]//div[1]//div[1]//div[2]//div[1]//div[1]//div[1]//div[1]//div[1]//div[1]//div[1]//div[1]//div[1]//div[2]//div[2]//div[1]//div[2]//div[1]//div[1]//div[1]//div[3]//div[1]//span[2]//div[1]//i[2]");
        By MoreOptionsDotsOnCustomerCases = By.XPath("(//span[contains(@class,'pa-cx pa-cw')]//span)[3]");
        By DeleteCasesFromMoreOptions = By.XPath("//span[text()='Delete Case']");
        By CustomerNameOnCustomerHistory = By.XPath("//span[text()='Gary Moore']");
        By TestNameOnCustomerHistory = By.XPath("//span[text()='Gary Test']");
        By TestBusinessOnCustomerHistory = By.XPath("//span[text()='Test Business']");


        By OOANameOnCustomerHistory = By.XPath("//span[text()='Out Ofarea']");
        By ManualAddressOnCustomerHistory = By.XPath("//span[text()='Manual Address']");
        By AnonOnCustomerHistory = By.XPath("(//span[text()='Unknown Address'])[1]");
        By BusinessNameOnCustomerHistory = By.XPath("//span[text()='Test Cafe']");
        By UABusinessOnCustomerHistory = By.XPath("//span[text()='Unknown Business']");
        By CaseStatusOnCustomerHistory = By.XPath("//span[text()='Case Status']");


        By CustomerInfoTitleOnCaseSummary = By.XPath("//h2[contains(text(),'CUSTOMER INFORMATION')]");
        By EmptySLAOnCaseSummary = By.XPath("//input[@placeholder='---']");
        By CustomerCasesTitle = By.XPath("//h2[contains(text(),'CUSTOMERS CASES')]");
        By CaseHistoryTable = By.XPath("/html[1]/body[1]/div[1]/div[1]/div[5]/table[1]");
        By CaseHistoryTableHeader1 = By.XPath("/html[1]/body[1]/div[1]/div[1]/div[5]/table[1]/thead[1]/tr[1]/th[1]");
        By CaseHistoryTableHeader2 = By.XPath("/html[1]/body[1]/div[1]/div[1]/div[5]/table[1]/thead[1]/tr[1]/th[2]");
        By CaseHistoryTableHeader3 = By.XPath("/html[1]/body[1]/div[1]/div[1]/div[5]/table[1]/thead[1]/tr[1]/th[3]");
        By CaseHistoryTableHeader4 = By.XPath("/html[1]/body[1]/div[1]/div[1]/div[5]/table[1]/thead[1]/tr[1]/th[4]");
        By CaseHistoryTableData1 = By.XPath("/html[1]/body[1]/div[1]/div[1]/div[5]/table[1]/tbody[1]/tr[1]/td[1]");
        By CaseHistoryTableData2 = By.XPath("/html[1]/body[1]/div[1]/div[1]/div[5]/table[1]/tbody[1]/tr[2]/td[1]");

        By TopCaseOnList = By.XPath("//td[contains(text(),'CAS-13738')]");
        By TopCaseOnList2 = By.XPath("//td[contains(text(),'CAS-14252')]"); //Test environment
        By OOATopCaseOnList = By.XPath("//td[contains(text(),'CAS-13580')]");
        By OOATopCaseOnList2 = By.XPath("//td[contains(text(),'CAS-14257')]");//Test environment
        By MATopCaseOnList = By.XPath("//td[contains(text(),'CAS-13856')]");
        By MATopCaseOnList2 = By.XPath("//td[contains(text(),'CAS-14254')]"); //Test environment
        By UATopCaseOnList = By.XPath("//td[contains(text(),'CAS-14032')]");
        By UATopCaseOnList2 = By.XPath("//td[contains(text(),'CAS-14259')]"); //Test environment
        By BusinessTopCaseOnList = By.XPath("//td[contains(text(),'CAS-14830')]");
        By BusinessTopCaseOnList2 = By.XPath("//td[contains(text(),'CAS-14389')]"); //Test environment
        By UABusinessTopCaseOnList = By.XPath("//td[contains(text(),'CAS-14980')]");
        By UABusinessTopCaseOnList2 = By.XPath("//td[contains(text(),'CAS-14416')]"); //Test environment


        By CantFindAddressLink = By.XPath("//a[@id='lnkManualAddress']");
        By UnderstandBtnOnOverlay = By.XPath("//span[contains(text(),'I Understand')]");
        By FindAddressSearchBox = By.XPath("//input[@placeholder='Type in the address including a postcode']");
        By AddressConfirmBtn = By.XPath("//button[@id='btnManualAddress']");
        By ContinueCustomerBtn = By.XPath("//button[contains(text(),'Continue with Customer')]");
        By RecordStatusCancelled = By.XPath("//span[text()='Read-only  This record’s status: Cancelled']");

        By BackBtn = By.XPath("//button[@title='Go back']//span");
        By DiscardBtnOnOverlay = By.XPath("//span[text()='Discard changes']");
        By LitterDogBinService = By.XPath("//a[.='Litter/Dog Bin']");
        By CaseHistoryTitle = By.XPath("//strong[.='Case History']");

        By TestBusinessInDropdown = By.XPath("//a[normalize-space()='Test Business 16 Pontefract Road Barnsley S71 1Aj']");
        By TestBusinessInAccessChannel = By.XPath("//a[normalize-space()='Test Business']");
        By AddTimelineRecord = By.XPath("//button[@title='Create a timeline record.']//span[@aria-hidden='true']");
        By AddStatusUpdate = By.XPath("//div[text()='Status Update']");
        By AddEscalate = By.XPath("//div[text()='Escalate']");
        By AddBespokePausing = By.XPath("//input[@aria-label='Status Update Message, Lookup']");
        By AddComplaintsType = By.XPath("//input[@aria-label='Complaints Type, Lookup']");
        By AddEscalationStage = By.XPath("//input[@aria-label='Escalation Stage, Lookup']");
        By AddComplaintOverview = By.XPath("//input[@aria-label='Complaint Overview, Lookup']");
        By AddDetailsOfComplaint = By.XPath("//textarea[@aria-label='Detail of Complaint']");
        By AddDesiredOutcome = By.XPath("//textarea[@aria-label='Desired Complaint Outcome']");
        By ComplaintTitle = By.XPath("//input[@title='Social Care Complaint - Dog Fouling']");
        By CustomerNameOnComplaintForm = By.XPath("//div[@title='Gary Moore']");


        By AddBespokePausingOnDropdown = By.XPath("//li[@aria-label='Bespoke Pausing, Pausing']");
        By SocialCareComplaintOnDropdown = By.XPath("//li[@aria-label='Social Care Complaint, 16/03/2020 10:52']");
        By AdultLocalResolutionOnDropdown = By.XPath("//li[@aria-label='Adult Local Resolution, 16/03/2020 10:52']");
        By AccessChannelPhoneOnDropdown = By.XPath("//select[@aria-required='true']//option[@value='1'][normalize-space()='Phone']");
        By LinkedCaseOnComplaintsForm = By.XPath("//div[@title='Social Care Complaint - Dog Fouling']");
        By AddClosingOnDropdown = By.XPath("//li[@aria-label='Closing - Fouling Cleared, Closing']");
        By AddRestartingOnDropdown = By.XPath("//li[@aria-label='Restarting - Test, Restarting']");
        By ComplaintOverviewDropdown = By.XPath("//li[@aria-label='Dissatisfied with previous complaint response, 19/03/2020 12:07']");
        By SourceOnDropdown = By.XPath("//option[normalize-space()='Member of Public']");
        By ComplaintTypeOnDropdown = By.XPath("//option[normalize-space()='Charges and Fees for Services']");
        By AdultStage1OnDropdown = By.XPath("//li[@aria-label='Adult Stage 1, 16/03/2020 10:52']");
        By AdultStage2OnDropdown = By.XPath("//li[@aria-label='Adult Stage 2, 16/03/2020 10:52']");
        By AdultProDisagreementOnDropdown = By.XPath("//li[@aria-label='Professional Disagreement - Adult, 03/06/2020 06:48']");
        By ChildrensLocalResolutionOnDropdown = By.XPath("//li[@aria-label='Children Local Resolution, 16/03/2020 10:52']");
        By ChildrenStage2OnDropdown = By.XPath("//li[@aria-label='Children Stage 2, 16/03/2020 10:52']");
        By ChildProDisagreementOnDropdown = By.XPath("//li[@aria-label='Professional Disagreement - Children, 03/06/2020 06:48']");
        By CorporateComplaintOnDropdown = By.XPath("//li[@aria-label='Corporate Complaint, 09/11/2022 10:52']");


        By ComplaintStage1OnForm = By.XPath("//select[@title='Adult Stage 1']");
        By ComplaintStage2OnForm = By.XPath("//select[@title='Adult Stage 2']");
        By ProDisagreementOnForm = By.XPath("//select[@title='Professional Disagreement - Adult']");
        By ChildrenLocalComplaintOnForm = By.XPath("//select[@title='Children Local Resolution']");
        By ComplaintStage2ChildrenOnForm = By.XPath("//select[@title='Children Stage 2']");
        By ProDisagreementChildOnForm = By.XPath("//select[@title='Professional Disagreement - Children']");



        By BespokePausingMsgBox = By.XPath("//textarea[@aria-label='Bespoke Status Update Message']");
        By BespokePausingSave = By.XPath("//span[contains(text(),'Save and Close')]");
        By LatestCustomerUpdate = By.XPath("//textarea[@aria-label='Latest Customer Update']");
        By ResolvedInPause = By.XPath("//label[@title='The timer is paused']");
        By CaseStatusNameOnProfile = By.XPath("//h1[@title='case status']");
        By PausedCaseOnHistory = By.XPath("//div[contains(text(),'Paused')]");
        By EditPausedCaseHistory = By.XPath("(//span[contains(text(),'Edit')])[1]");
        By LatestCustomerUpdateClosed = By.XPath("//textarea[contains(.,'Further to your enquiry we can now confirm we have visited the site and have cle')]");
        By ClosedCaseRibbonMsg = By.XPath("//span[text()='Read-only  This record’s status: Resolved']");
        By CaseStatusNameOnForm = By.XPath("//div[@title='case status']");
        By StatusCompleted = By.XPath("//div[text()='Completed']");

        By LocationTab = By.XPath("//li[@title='Location']");
        By ReportedLocation = By.XPath("//div[@title='6 Sandhill Rise Pontefract WF8 1RA']");
        By LinkedRecordsTab = By.XPath("//li[@title='Linked Records']");
        By LinkedCaseOnTable = By.XPath("(//span[@aria-hidden='true'][normalize-space()='Dog Fouling'])[1]");



        [ThreadStatic]
        IWebDriver driver;
        WebDriverWait wait;

        public CaseSummary(IWebDriver driver)
        {
            this.driver = driver;
            this.wait = new WebDriverWait(driver, TimeSpan.FromSeconds(120));
        }

        public void AllocatingCaseStatus()
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
            wait.Until(ExpectedConditions.ElementExists((By)Searchbox));
            Assert.IsTrue(driver.FindElement(Searchbox).Displayed);
            //Enter fullname in search
            driver.FindElement(Searchbox).Click();
            driver.FindElement(Searchbox).SendKeys("Gary Moore");
            driver.FindElement(Searchbox).SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            //Check result shows on the dropdown
            wait.Until(ExpectedConditions.ElementExists((By)ExistingCustomerSearchDropdown));
            Assert.IsTrue(driver.FindElement(ExistingCustomerSearchDropdown).Displayed);
            driver.FindElement(ExistingCustomerSearchDropdown).Click();
            Thread.Sleep(2000);
            //Check result is shown under access channel after selecting from dropdown
            wait.Until(ExpectedConditions.ElementExists((By)ExistingCustomerSearchResult));
            Assert.IsTrue(driver.FindElement(ExistingCustomerSearchResult).Displayed);
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
            wait.Until(ExpectedConditions.ElementExists((By)FAQSearchServiceResult));
            Assert.IsTrue(driver.FindElement(FAQSearchServiceResult).Displayed);
            driver.FindElement(FAQSearchServiceResult).Click();
            Thread.Sleep(2000);
            //Verify customer name and service shown on the create new case overlay
            driver.SwitchTo().DefaultContent();
            wait.Until(ExpectedConditions.ElementExists((By)CustomerNameOnNewCaseOverlay));
            Assert.IsTrue(driver.FindElement(CustomerNameOnNewCaseOverlay).Displayed);
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
            //Verify Job status shows in progress
            wait.Until(ExpectedConditions.ElementExists((By)JobStatus));
            Assert.IsTrue(driver.FindElement(JobStatus).Displayed);
            //Verify SLA timer starts from 7 days
            Thread.Sleep(2000);
            IWebElement element = driver.FindElement(SLATimer);
            string time = element.Text;
            Thread.Sleep(2000);
            Console.WriteLine(time);
            try
            {
                if (time.Contains("6d"))
                {
                    Console.WriteLine("SLA Correct");
                }
            }
            catch
            {
                Console.WriteLine("SLA incorrect");
                Assert.Fail();
            }
            //Verify default customer update is displayed
            wait.Until(ExpectedConditions.ElementExists((By)DefaultCustomerUpdate));
            Assert.IsTrue(driver.FindElement(DefaultCustomerUpdate).Displayed);
            //Click allocated case form
            driver.FindElement(AllocatedCaseForm).Click();
            Thread.Sleep(2000);
            //Select wakefield case on dropdown
            wait.Until(ExpectedConditions.ElementExists((By)AllocatedCaseDropdownWakefield));
            driver.FindElement(AllocatedCaseDropdownWakefield).Click();
            Thread.Sleep(10000);
            //Verify case details page is displayed
            wait.Until(ExpectedConditions.ElementExists((By)CaseDetailsForm));
            Assert.IsTrue(driver.FindElement(CaseDetailsForm).Displayed);
            //Click customer updates/history tab
            wait.Until(ExpectedConditions.ElementExists((By)CaseDetailsCustomerUpdate));
            driver.FindElement(CaseDetailsCustomerUpdate).Click();
            Thread.Sleep(2000);
            //Verify status message is shown
            wait.Until(ExpectedConditions.ElementExists((By)CustomerUpdateStatusMessage));
            Assert.IsTrue(driver.FindElement(CustomerUpdateStatusMessage).Displayed);
            //Click summary tab
            driver.FindElement(CaseDetailsSummaryTab).Click();
            Thread.Sleep(2000);
            //click email message on timeline
            var Email = 0;
            try
            {
                if (driver.FindElements(EmailMessageOnTimeline).Count() != 0)
                {
                    Console.WriteLine("Email message displayed on timeline");
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                do
                {
                    driver.FindElement(RefreshButtonOnCaseDetails).Click();
                    Thread.Sleep(5000);
                    Email++;
                    if (driver.FindElements(EmailMessageOnTimeline).Count() != 0)
                    {
                        break;
                    }
                    else if (Email == 10)
                    {
                        Console.WriteLine("Email message not displayed on timeline");
                        Assert.Fail();
                    }
                } while (driver.FindElements(EmailMessageOnTimeline).Count() == 0);
            }
            wait.Until(ExpectedConditions.ElementExists((By)EmailMessageOnTimeline));
            Thread.Sleep(2000);
            driver.FindElement(EmailMessageOnTimeline).Click();
            Thread.Sleep(3000);
            //Verify message is correct
            wait.Until(ExpectedConditions.ElementExists((By)EmailMessageContentOnTimeline));
            Thread.Sleep(2000);
            Assert.IsTrue(driver.FindElement(EmailMessageContentOnTimeline).Displayed);
            Thread.Sleep(2000);
            //Verify current queue is correct
            wait.Until(ExpectedConditions.ElementExists((By)CaseDetailsCurrentQueue));
            Assert.IsTrue(driver.FindElement(CaseDetailsCurrentQueue).Displayed);
            //Click service form link on service details box
            driver.FindElement(ServiceFormLink).Click();
            Thread.Sleep(3000);
            //click dashboards in LHN
            driver.FindElement(DashboardsLHN).Click();
            Thread.Sleep(2000);
            //Search for customer//
            //Switch to searchbox iframe
            driver.SwitchTo().Frame(driver.FindElement(By.Id("9532b1de-41a1-456c-b21c-805faca15573_WebResource_customeradvisorstart")));
            wait.Until(ExpectedConditions.ElementExists((By)Searchbox));
            Assert.IsTrue(driver.FindElement(Searchbox).Displayed);
            //Enter fullname in search
            driver.FindElement(Searchbox).Click();
            driver.FindElement(Searchbox).SendKeys("Gary Moore");
            driver.FindElement(Searchbox).SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            //Select customer on dropdown 
            wait.Until(ExpectedConditions.ElementExists((By)ExistingCustomerSearchDropdown));
            Assert.IsTrue(driver.FindElement(ExistingCustomerSearchDropdown).Displayed);
            driver.FindElement(ExistingCustomerSearchDropdown).Click();
            Thread.Sleep(2000);
            //Check result is shown under access channel after selecting from dropdown
            wait.Until(ExpectedConditions.ElementExists((By)ExistingCustomerSearchResult));
            Assert.IsTrue(driver.FindElement(ExistingCustomerSearchResult).Displayed);
            //Verify case status shows as active
            wait.Until(ExpectedConditions.ElementExists((By)CaseHistoryUnderAcessChannel));
            Assert.IsTrue(driver.FindElement(CaseHistoryUnderAcessChannel).Displayed);
            wait.Until(ExpectedConditions.ElementExists((By)CaseHistoryStatus));
            Assert.IsTrue(driver.FindElement(CaseHistoryStatus).Displayed);
            driver.SwitchTo().DefaultContent();
            //Click cases on LHN
            driver.FindElement(CasesOnLHN).Click();
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)ActiveCasesTitle));
            Assert.IsTrue(driver.FindElement(ActiveCasesTitle).Displayed);
            Thread.Sleep(2000);
            //click customer name
            driver.FindElement(CustomerNameOnCasesList).Click();
            Thread.Sleep(2000);
            //Click history tab
            wait.Until(ExpectedConditions.ElementExists((By)HistoryTabOnCustomer));
            driver.FindElement(HistoryTabOnCustomer).Click();
            Thread.Sleep(2000);
            try
            {
                do
                {
                    //Click select all cases
                    wait.Until(ExpectedConditions.ElementExists((By)SelectAllCasesBtn));
                    Thread.Sleep(3000);
                    driver.FindElement(SelectAllCasesBtn).Click();
                    Thread.Sleep(2000);
                    //Click more options dots
                    wait.Until(ExpectedConditions.ElementExists((By)MoreOptionsDotsOnCustomerCases));
                    Thread.Sleep(2000);
                    driver.FindElement(MoreOptionsDotsOnCustomerCases).Click();
                    Thread.Sleep(2000);
                    //Click delete cases
                    wait.Until(ExpectedConditions.ElementExists((By)DeleteCasesFromMoreOptions));
                    Thread.Sleep(2000);
                    driver.FindElement(DeleteCasesFromMoreOptions).Click();
                    Thread.Sleep(2000);
                    //Click delete on the overlay
                    wait.Until(ExpectedConditions.ElementExists((By)DeleteCasesOverlayBtn));
                    Thread.Sleep(2000);
                    driver.FindElement(DeleteCasesOverlayBtn).Click();
                    Thread.Sleep(10000);
                    wait.Until(ExpectedConditions.ElementExists((By)CustomerCasesTitle));
                }
                while (driver.FindElement(CustomerNameOnCustomerHistory).Displayed);
            }
            catch (Exception)
            {
                Console.WriteLine("All cases removed from history screen");
            }
            //Verify cases deleted
            var Cases = 0;
            try
            {
                WebElement cases = (WebElement)driver.FindElement(CustomerNameOnCustomerHistory);
                if (cases.Displayed)
                {
                    Cases = 1;
                    Assert.Fail();
                }
            }
            catch (Exception)
            {
                if (Cases > 0)
                {
                    Console.WriteLine("Cases not removed");
                }
                else
                {
                    Console.WriteLine("Cases removed");
                }
            }
        }

        public void AllocateCaseStatusOOACustomer()
        {
            //Verify Home dashboard is displayed
            Thread.Sleep(4000);
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
            driver.FindElement(Searchbox).SendKeys("Out Ofarea");
            driver.FindElement(Searchbox).SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            //Check result shows on the dropdown
            wait.Until(ExpectedConditions.ElementExists((By)OutOfareaDetailsOnDropdown));
            Assert.IsTrue(driver.FindElement(OutOfareaDetailsOnDropdown).Displayed);
            driver.FindElement(OutOfareaDetailsOnDropdown).Click();
            Thread.Sleep(2000);
            //Check result is shown under access channel after selecting from dropdown
            wait.Until(ExpectedConditions.ElementExists((By)OutOfareaSearchResult));
            Assert.IsTrue(driver.FindElement(OutOfareaSearchResult).Displayed);
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
            wait.Until(ExpectedConditions.ElementExists((By)FAQSearchServiceResult));
            Assert.IsTrue(driver.FindElement(FAQSearchServiceResult).Displayed);
            driver.FindElement(FAQSearchServiceResult).Click();
            Thread.Sleep(2000);
            //Verify customer name and service shown on the create new case overlay
            driver.SwitchTo().DefaultContent();
            wait.Until(ExpectedConditions.ElementExists((By)OOANameOnNewCaseOverlay));
            Assert.IsTrue(driver.FindElement(OOANameOnNewCaseOverlay).Displayed);
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
            driver.FindElement(AddressSearchBox).SendKeys("pontefract");
            Thread.Sleep(1000);
            driver.FindElement(AddressSearchBox).SendKeys(Keys.Enter);
            wait.Until(ExpectedConditions.ElementExists((By)NewCustomerAddressDropdown));
            driver.FindElement(NewCustomerAddressDropdown).Click();
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
            //Verify Job status shows in progress
            wait.Until(ExpectedConditions.ElementExists((By)JobStatus));
            Assert.IsTrue(driver.FindElement(JobStatus).Displayed);
            //Verify SLA timer starts from 7 days
            Thread.Sleep(2000);
            IWebElement element = driver.FindElement(SLATimer);
            string time = element.Text;
            Thread.Sleep(2000);
            Console.WriteLine(time);
            try
            {
                if (time.Contains("6d"))
                {
                    Console.WriteLine("SLA Correct");
                }
            }
            catch
            {
                Console.WriteLine("SLA incorrect");
                Assert.Fail();
            }
            //Verify default customer update is displayed
            wait.Until(ExpectedConditions.ElementExists((By)DefaultCustomerUpdate));
            Assert.IsTrue(driver.FindElement(DefaultCustomerUpdate).Displayed);
            //Click allocated case form
            driver.FindElement(AllocatedCaseForm).Click();
            Thread.Sleep(2000);
            //Select wakefield case on dropdown
            wait.Until(ExpectedConditions.ElementExists((By)AllocatedCaseDropdownWakefield));
            driver.FindElement(AllocatedCaseDropdownWakefield).Click();
            Thread.Sleep(10000);
            //Verify case details page is displayed
            wait.Until(ExpectedConditions.ElementExists((By)CaseDetailsForm));
            Assert.IsTrue(driver.FindElement(CaseDetailsForm).Displayed);
            //Click customer updates/history tab
            wait.Until(ExpectedConditions.ElementExists((By)CaseDetailsCustomerUpdate));
            driver.FindElement(CaseDetailsCustomerUpdate).Click();
            Thread.Sleep(2000);
            //Verify status message is shown
            wait.Until(ExpectedConditions.ElementExists((By)CustomerUpdateStatusMessage));
            Assert.IsTrue(driver.FindElement(CustomerUpdateStatusMessage).Displayed);
            //Click summary tab
            driver.FindElement(CaseDetailsSummaryTab).Click();
            Thread.Sleep(2000);
            //click email message on timeline
           /* var Email = 0;  //Emails not turned on
            try
            {
                if (driver.FindElements(EmailMessageOnTimeline).Count() != 0)
                {
                    Console.WriteLine("Email message displayed on timeline");
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                do
                {
                    driver.FindElement(RefreshButtonOnCaseDetails).Click();
                    Thread.Sleep(5000);
                    Email++;
                    if (driver.FindElements(EmailMessageOnTimeline).Count() != 0)
                    {
                        break;
                    }
                    else if (Email == 10)
                    {
                        Console.WriteLine("Email message not displayed on timeline");
                        Assert.Fail();
                    }
                } while (driver.FindElements(EmailMessageOnTimeline).Count() == 0);
            }
            wait.Until(ExpectedConditions.ElementExists((By)EmailMessageOnTimeline));
            Thread.Sleep(2000);
            driver.FindElement(EmailMessageOnTimeline).Click();
            Thread.Sleep(4000);
            //Verify message is correct
            wait.Until(ExpectedConditions.ElementExists((By)EmailMessageContentOnTimeline));
            Thread.Sleep(2000);
            Assert.IsTrue(driver.FindElement(EmailMessageContentOnTimeline).Displayed);
            Thread.Sleep(2000); */
            //Verify current queue is correct
            action.SendKeys(Keys.PageDown).Build().Perform();
            wait.Until(ExpectedConditions.ElementExists((By)OOACaseCurrentQueue));
            Assert.IsTrue(driver.FindElement(OOACaseCurrentQueue).Displayed);
            //Click service form link on service details box
            driver.FindElement(ServiceFormLink).Click();
            Thread.Sleep(3000);
            //click dashboards in LHN
            driver.FindElement(DashboardsLHN).Click();
            Thread.Sleep(2000);
            //Search for customer//
            //Switch to searchbox iframe
            driver.SwitchTo().Frame(driver.FindElement(By.Id("9532b1de-41a1-456c-b21c-805faca15573_WebResource_customeradvisorstart")));
            wait.Until(ExpectedConditions.ElementExists((By)Searchbox));
            Assert.IsTrue(driver.FindElement(Searchbox).Displayed);
            //Enter fullname in search
            driver.FindElement(Searchbox).Click();
            driver.FindElement(Searchbox).SendKeys("Out Ofarea");
            driver.FindElement(Searchbox).SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            //Select customer on dropdown 
            wait.Until(ExpectedConditions.ElementExists((By)OutOfareaDetailsOnDropdown));
            Assert.IsTrue(driver.FindElement(OutOfareaDetailsOnDropdown).Displayed);
            driver.FindElement(OutOfareaDetailsOnDropdown).Click();
            Thread.Sleep(2000);
            //Check result is shown under access channel after selecting from dropdown
            wait.Until(ExpectedConditions.ElementExists((By)OutOfareaSearchResult));
            Assert.IsTrue(driver.FindElement(OutOfareaSearchResult).Displayed);
            //Verify case status shows as active
            wait.Until(ExpectedConditions.ElementExists((By)CaseHistoryUnderAcessChannel));
            Assert.IsTrue(driver.FindElement(CaseHistoryUnderAcessChannel).Displayed);
            wait.Until(ExpectedConditions.ElementExists((By)CaseHistoryStatus));
            Assert.IsTrue(driver.FindElement(CaseHistoryStatus).Displayed);
            driver.SwitchTo().DefaultContent();
            //Click cases on LHN
            driver.FindElement(CasesOnLHN).Click();
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)ActiveCasesTitle));
            Assert.IsTrue(driver.FindElement(ActiveCasesTitle).Displayed);
            Thread.Sleep(2000);
            //click customer name
            driver.FindElement(OutOfareaNameOnCaseList).Click();
            Thread.Sleep(2000);
            //Click history tab
            wait.Until(ExpectedConditions.ElementExists((By)HistoryTabOnCustomer));
            driver.FindElement(HistoryTabOnCustomer).Click();
            Thread.Sleep(2000);
            var Cases = 0;
            try
            {
                if (driver.FindElements(OOANameOnCustomerHistory).Count() != 0)
                    Console.WriteLine("Cases present on customer history");
                {
                    do
                    {
                        //Click select all cases
                        wait.Until(ExpectedConditions.ElementExists((By)SelectAllCasesBtn));
                        Thread.Sleep(3000);
                        driver.FindElement(SelectAllCasesBtn).Click();
                        Thread.Sleep(2000);
                        //Click more options dots
                        wait.Until(ExpectedConditions.ElementExists((By)MoreOptionsDotsOnCustomerCases));
                        Thread.Sleep(2000);
                        driver.FindElement(MoreOptionsDotsOnCustomerCases).Click();
                        Thread.Sleep(2000);
                        //Click delete cases
                        wait.Until(ExpectedConditions.ElementExists((By)DeleteCasesFromMoreOptions));
                        Thread.Sleep(2000);
                        driver.FindElement(DeleteCasesFromMoreOptions).Click();
                        Thread.Sleep(2000);
                        //Click delete on the overlay
                        wait.Until(ExpectedConditions.ElementExists((By)DeleteCasesOverlayBtn));
                        Thread.Sleep(2000);
                        driver.FindElement(DeleteCasesOverlayBtn).Click();
                        Thread.Sleep(10000);
                        wait.Until(ExpectedConditions.ElementExists((By)CustomerCasesTitle));
                        Cases++;
                        if (driver.FindElements(OOANameOnCustomerHistory).Count() == 0)
                        {
                            Console.WriteLine("All cases removed");
                            break;
                        }
                    }
                    while (driver.FindElements(OOANameOnCustomerHistory).Count() != 0);
                }
            }
            catch (Exception)
            {
                if (Cases == 0)
                {
                    Console.WriteLine("No cases were added to customer history");
                    Assert.Fail();
                }
            }
        }

        public void AllocatingCaseStatusManualAddress()
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
            wait.Until(ExpectedConditions.ElementExists((By)FAQSearchServiceResult));
            Assert.IsTrue(driver.FindElement(FAQSearchServiceResult).Displayed);
            driver.FindElement(FAQSearchServiceResult).Click();
            Thread.Sleep(2000);
            //Verify customer name and service shown on the create new case overlay
            driver.SwitchTo().DefaultContent();
            wait.Until(ExpectedConditions.ElementExists((By)ManualAddressOnNewCaseOverlay));
            Assert.IsTrue(driver.FindElement(ManualAddressOnNewCaseOverlay).Displayed);
            wait.Until(ExpectedConditions.ElementExists((By)ServiceOnNewCaseOverlay));
            Assert.IsTrue(driver.FindElement(ServiceOnNewCaseOverlay).Displayed);
            //Click yes on overlay
            wait.Until(ExpectedConditions.ElementExists((By)YesBtnOnNewCaseOverlay));
            driver.FindElement(YesBtnOnNewCaseOverlay).Click();
            Thread.Sleep(3000);
            //Verify dog fouling form loads
            wait.Until(ExpectedConditions.ElementExists((By)DogFoulingFormTitle));
            Assert.IsTrue(driver.FindElement(DogFoulingFormTitle).Displayed);
            Thread.Sleep(2000);
            //Enter address for location
            driver.SwitchTo().Frame("WebResource_WMDCAddressSearch");
            Thread.Sleep(2000);
            //Click can't find address link
            wait.Until(ExpectedConditions.ElementExists((By)CantFindAddressLink));
            driver.FindElement(CantFindAddressLink).Click();
            Thread.Sleep(2000);
            driver.SwitchTo().DefaultContent();
            //Click I understand on overlay
            wait.Until(ExpectedConditions.ElementExists((By)UnderstandBtnOnOverlay));
            driver.FindElement(UnderstandBtnOnOverlay).Click();
            Thread.Sleep(2000);
            //Enter address
            driver.SwitchTo().Frame("WebResource_WMDCAddressSearch");
            wait.Until(ExpectedConditions.ElementExists((By)FindAddressSearchBox));
            driver.FindElement(FindAddressSearchBox).Click();
            driver.FindElement(FindAddressSearchBox).SendKeys("80 spring avenue, ashby-de-la-zouch, le65 2rb");
            Thread.Sleep(2000);
            driver.FindElement(AddressConfirmBtn).Click();
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
            //Verify Job status shows in progress
            wait.Until(ExpectedConditions.ElementExists((By)JobStatus));
            Assert.IsTrue(driver.FindElement(JobStatus).Displayed);
            //Verify SLA timer starts from 7 days
            Thread.Sleep(2000);
            IWebElement element = driver.FindElement(SLATimer);
            string time = element.Text;
            Thread.Sleep(2000);
            Console.WriteLine(time);
            try
            {
                if (time.Contains("6d"))
                {
                    Console.WriteLine("SLA Correct");
                }
            }
            catch
            {
                Console.WriteLine("SLA incorrect");
                Assert.Fail();
            }
            //Verify default customer update is displayed
            wait.Until(ExpectedConditions.ElementExists((By)DefaultCustomerUpdate));
            Assert.IsTrue(driver.FindElement(DefaultCustomerUpdate).Displayed);
            //Click allocated case form
            driver.FindElement(AllocatedCaseForm).Click();
            Thread.Sleep(2000);
            //Select wakefield case on dropdown
            wait.Until(ExpectedConditions.ElementExists((By)AllocatedCaseDropdownWakefield));
            driver.FindElement(AllocatedCaseDropdownWakefield).Click();
            Thread.Sleep(10000);
            //Verify case details page is displayed
            wait.Until(ExpectedConditions.ElementExists((By)CaseDetailsForm));
            Assert.IsTrue(driver.FindElement(CaseDetailsForm).Displayed);
            //Click customer updates/history tab
            wait.Until(ExpectedConditions.ElementExists((By)CaseDetailsCustomerUpdate));
            driver.FindElement(CaseDetailsCustomerUpdate).Click();
            Thread.Sleep(2000);
            //Verify status message is shown
            wait.Until(ExpectedConditions.ElementExists((By)CustomerUpdateStatusMessage));
            Assert.IsTrue(driver.FindElement(CustomerUpdateStatusMessage).Displayed);
            //Click summary tab
            driver.FindElement(CaseDetailsSummaryTab).Click();
            Thread.Sleep(2000);
            //click email message on timeline
            /* var Email = 0;   //Emails not turned on
            try
            {
                if (driver.FindElements(EmailMessageOnTimeline).Count() != 0)
                {
                    Console.WriteLine("Email message displayed on timeline");
                }
                else
                {
                    Assert.Fail();
                }
            }
            catch (Exception)
            {
                do
                {
                    driver.FindElement(RefreshButtonOnCaseDetails).Click();
                    Thread.Sleep(5000);
                    Email++;
                    if (driver.FindElements(EmailMessageOnTimeline).Count() != 0)
                    {
                        break;
                    }
                    else if (Email == 10)
                    {
                        Console.WriteLine("Email message not displayed on timeline");
                        Assert.Fail();
                    }
                } while (driver.FindElements(EmailMessageOnTimeline).Count() == 0);
            }
            wait.Until(ExpectedConditions.ElementExists((By)EmailMessageOnTimeline));
            Thread.Sleep(2000);
            driver.FindElement(EmailMessageOnTimeline).Click();
            Thread.Sleep(3000);
            //Verify message is correct
            wait.Until(ExpectedConditions.ElementExists((By)EmailMessageContentOnTimeline));
            Thread.Sleep(2000);
            Assert.IsTrue(driver.FindElement(EmailMessageContentOnTimeline).Displayed);
            Thread.Sleep(2000); */
            //Verify current queue is correct
            wait.Until(ExpectedConditions.ElementExists((By)ManualAddressCaseCurrentQueue));
            Assert.IsTrue(driver.FindElement(ManualAddressCaseCurrentQueue).Displayed);
            //Click service form link on service details box
            driver.FindElement(ServiceFormLink).Click();
            Thread.Sleep(3000);
            //click dashboards in LHN
            driver.FindElement(DashboardsLHN).Click();
            Thread.Sleep(2000);
            //Search for customer//
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
            //Verify case status shows as active
            wait.Until(ExpectedConditions.ElementExists((By)CaseHistoryUnderAcessChannel));
            Assert.IsTrue(driver.FindElement(CaseHistoryUnderAcessChannel).Displayed);
            wait.Until(ExpectedConditions.ElementExists((By)CaseHistoryStatus));
            Assert.IsTrue(driver.FindElement(CaseHistoryStatus).Displayed);
            driver.SwitchTo().DefaultContent();
            //Click cases on LHN
            driver.FindElement(CasesOnLHN).Click();
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)ActiveCasesTitle));
            Assert.IsTrue(driver.FindElement(ActiveCasesTitle).Displayed);
            Thread.Sleep(2000);
            //click customer name
            driver.FindElement(ManualAddressOnCasesList).Click();
            Thread.Sleep(2000);
            //Click history tab
            wait.Until(ExpectedConditions.ElementExists((By)HistoryTabOnCustomer));
            driver.FindElement(HistoryTabOnCustomer).Click();
            Thread.Sleep(2000);
            var Cases = 0;
            try
            {
                if (driver.FindElements(ManualAddressOnCustomerHistory).Count() != 0)
                    Console.WriteLine("Cases present on customer history");
                {
                    do
                    {
                        //Click select all cases
                        wait.Until(ExpectedConditions.ElementExists((By)SelectAllCasesBtn));
                        Thread.Sleep(3000);
                        driver.FindElement(SelectAllCasesBtn).Click();
                        Thread.Sleep(2000);
                        //Click more options dots
                        wait.Until(ExpectedConditions.ElementExists((By)MoreOptionsDotsOnCustomerCases));
                        Thread.Sleep(2000);
                        driver.FindElement(MoreOptionsDotsOnCustomerCases).Click();
                        Thread.Sleep(2000);
                        //Click delete cases
                        wait.Until(ExpectedConditions.ElementExists((By)DeleteCasesFromMoreOptions));
                        Thread.Sleep(2000);
                        driver.FindElement(DeleteCasesFromMoreOptions).Click();
                        Thread.Sleep(2000);
                        //Click delete on the overlay
                        wait.Until(ExpectedConditions.ElementExists((By)DeleteCasesOverlayBtn));
                        Thread.Sleep(2000);
                        driver.FindElement(DeleteCasesOverlayBtn).Click();
                        Thread.Sleep(10000);
                        wait.Until(ExpectedConditions.ElementExists((By)CustomerCasesTitle));
                        Cases++;
                        if (driver.FindElements(OOANameOnCustomerHistory).Count() == 0)
                        {
                            Console.WriteLine("All cases removed");
                            break;
                        }
                    }
                    while (driver.FindElements(ManualAddressOnCustomerHistory).Count() != 0);
                }
            }
            catch (Exception)
            {
                if (Cases == 0)
                {
                    Console.WriteLine("No cases were added to customer history");
                    Assert.Fail();
                }
            }
        }

        public void AllocatingCaseStatusAnonCustomer()
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
            wait.Until(ExpectedConditions.ElementExists((By)Searchbox));
            Assert.IsTrue(driver.FindElement(Searchbox).Displayed);
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
            wait.Until(ExpectedConditions.ElementExists((By)FAQSearchServiceResult));
            Assert.IsTrue(driver.FindElement(FAQSearchServiceResult).Displayed);
            driver.FindElement(FAQSearchServiceResult).Click();
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
            //Verify Job status shows in progress
            wait.Until(ExpectedConditions.ElementExists((By)JobStatus));
            Assert.IsTrue(driver.FindElement(JobStatus).Displayed);
            //Verify SLA timer starts from 7 days
            Thread.Sleep(2000);
            IWebElement element = driver.FindElement(SLATimer);
            string time = element.Text;
            Thread.Sleep(2000);
            Console.WriteLine(time);
            try
            {
                if (time.Contains("6d"))
                {
                    Console.WriteLine("SLA Correct");
                }
            }
            catch
            {
                Console.WriteLine("SLA incorrect");
                Assert.Fail();
            }
            //Verify default customer update is displayed
            wait.Until(ExpectedConditions.ElementExists((By)DefaultCustomerUpdate));
            Assert.IsTrue(driver.FindElement(DefaultCustomerUpdate).Displayed);
            //Click allocated case form
            driver.FindElement(AllocatedCaseForm).Click();
            Thread.Sleep(2000);
            //Select wakefield case on dropdown
            wait.Until(ExpectedConditions.ElementExists((By)AllocatedCaseDropdownWakefield));
            driver.FindElement(AllocatedCaseDropdownWakefield).Click();
            Thread.Sleep(10000);
            //Verify case details page is displayed
            wait.Until(ExpectedConditions.ElementExists((By)CaseDetailsForm));
            Assert.IsTrue(driver.FindElement(CaseDetailsForm).Displayed);
            //Click customer updates/history tab
            wait.Until(ExpectedConditions.ElementExists((By)CaseDetailsCustomerUpdate));
            driver.FindElement(CaseDetailsCustomerUpdate).Click();
            Thread.Sleep(2000);
            //Verify status message is shown
            wait.Until(ExpectedConditions.ElementExists((By)CustomerUpdateStatusMessage));
            Assert.IsTrue(driver.FindElement(CustomerUpdateStatusMessage).Displayed);
            //Click summary tab
            driver.FindElement(CaseDetailsSummaryTab).Click();
            Thread.Sleep(3000);
            actions.SendKeys(Keys.PageDown).Build().Perform();
            Thread.Sleep(3000);
            //Verify current queue is correct
            driver.FindElement(RefreshButtonOnCaseDetails).Click();
            wait.Until(ExpectedConditions.ElementExists((By)CaseDetailsCurrentQueue));
            Assert.IsTrue(driver.FindElement(CaseDetailsCurrentQueue).Displayed);
            //Click allocated case form
            wait.Until(ExpectedConditions.ElementExists((By)AllocatedCaseDropdownWakefield));
            driver.FindElement(AllocatedCaseDropdownWakefield).Click();
            Thread.Sleep(2000);
            driver.FindElement(AllocatedCaseForm).Click();
            //Click continue with customer button
            Thread.Sleep(2000);
            driver.SwitchTo().Frame(driver.FindElement(By.Id("WebResource_continuewithcustomer")));
            Thread.Sleep(2000);
            driver.FindElement(ContinueCustomerBtn).Click();
            Thread.Sleep(2000);
            //Verify dashboard is displayed
            wait.Until(ExpectedConditions.ElementExists((By)DashboardTitle));
            Assert.IsTrue(driver.FindElement(DashboardTitle).Displayed);
        }

        public void AllocatingCaseStatusUnknownAddress()
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
            wait.Until(ExpectedConditions.ElementExists((By)Searchbox));
            Assert.IsTrue(driver.FindElement(Searchbox).Displayed);
            //Enter fullname in search
            driver.FindElement(Searchbox).Click();
            driver.FindElement(Searchbox).SendKeys("Unknown Address");
            driver.FindElement(Searchbox).SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            //Check result shows on the dropdown
            wait.Until(ExpectedConditions.ElementExists((By)AnonCustomerSearchDropdown));
            Assert.IsTrue(driver.FindElement(AnonCustomerSearchDropdown).Displayed);
            driver.FindElement(AnonCustomerSearchDropdown).Click();
            Thread.Sleep(2000);
            //Check result is shown under access channel after selecting from dropdown
            wait.Until(ExpectedConditions.ElementExists((By)AnonAddressSearchResult));
            Assert.IsTrue(driver.FindElement(AnonAddressSearchResult).Displayed);
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
            wait.Until(ExpectedConditions.ElementExists((By)FAQSearchServiceResult));
            Assert.IsTrue(driver.FindElement(FAQSearchServiceResult).Displayed);
            driver.FindElement(FAQSearchServiceResult).Click();
            Thread.Sleep(2000);
            //Verify customer name and service shown on the create new case overlay
            driver.SwitchTo().DefaultContent();
            wait.Until(ExpectedConditions.ElementExists((By)UnknownAddressOnNewCaseOverlay));
            Assert.IsTrue(driver.FindElement(UnknownAddressOnNewCaseOverlay).Displayed);
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
            //Verify Job status shows in progress
            wait.Until(ExpectedConditions.ElementExists((By)JobStatus));
            Assert.IsTrue(driver.FindElement(JobStatus).Displayed);
            //Verify SLA timer starts from 7 days
            Thread.Sleep(2000);
            IWebElement element = driver.FindElement(SLATimer);
            string time = element.Text;
            Thread.Sleep(2000);
            Console.WriteLine(time);
            try
            {
                if (time.Contains("6d"))
                {
                    Console.WriteLine("SLA Correct");
                }
            }
            catch
            {
                Console.WriteLine("SLA incorrect");
                Assert.Fail();
            }
            //Verify default customer update is displayed
            wait.Until(ExpectedConditions.ElementExists((By)DefaultCustomerUpdate));
            Assert.IsTrue(driver.FindElement(DefaultCustomerUpdate).Displayed);
            //Click allocated case form
            driver.FindElement(AllocatedCaseForm).Click();
            Thread.Sleep(2000);
            //Select wakefield case on dropdown
            wait.Until(ExpectedConditions.ElementExists((By)AllocatedCaseDropdownWakefield));
            driver.FindElement(AllocatedCaseDropdownWakefield).Click();
            Thread.Sleep(10000);
            //Verify case details page is displayed
            wait.Until(ExpectedConditions.ElementExists((By)CaseDetailsForm));
            Assert.IsTrue(driver.FindElement(CaseDetailsForm).Displayed);
            //Click customer updates/history tab
            wait.Until(ExpectedConditions.ElementExists((By)CaseDetailsCustomerUpdate));
            driver.FindElement(CaseDetailsCustomerUpdate).Click();
            Thread.Sleep(2000);
            //Verify status message is shown
            wait.Until(ExpectedConditions.ElementExists((By)CustomerUpdateStatusMessage));
            Assert.IsTrue(driver.FindElement(CustomerUpdateStatusMessage).Displayed);
            //Click summary tab
            driver.FindElement(CaseDetailsSummaryTab).Click();
            Thread.Sleep(2000);
            //click email message on timeline
           /* var Email = 0; //Emails not turned on
            try
            {
                if (driver.FindElements(EmailNotificationOnTimeline).Count() != 0)
                {
                    Console.WriteLine("Email message displayed on timeline");
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                do
                {
                    driver.FindElement(RefreshButtonOnCaseDetails).Click();
                    Thread.Sleep(5000);
                    Email++;
                    if (driver.FindElements(EmailNotificationOnTimeline).Count() != 0)
                    {
                        break;
                    }
                    else if (Email == 10)
                    {
                        Console.WriteLine("Email message not displayed on timeline");
                        Assert.Fail();
                    }
                } while (driver.FindElements(EmailNotificationOnTimeline).Count() == 0);
            }
            wait.Until(ExpectedConditions.ElementExists((By)EmailNotificationOnTimeline));
            Assert.IsTrue(driver.FindElement(EmailNotificationOnTimeline).Displayed);
            Thread.Sleep(2000); */
            //Verify current queue is correct
            driver.FindElement(CaseDetailsForm).Click();
            action.SendKeys(Keys.PageDown).Build().Perform();
            wait.Until(ExpectedConditions.ElementExists((By)CaseDetailsCurrentQueue));
            Assert.IsTrue(driver.FindElement(CaseDetailsCurrentQueue).Displayed);
            //Click service form link on service details box
            driver.FindElement(ServiceFormLink).Click();
            Thread.Sleep(3000);
            //click dashboards in LHN
            driver.FindElement(DashboardsLHN).Click();
            Thread.Sleep(2000);
            //Search for customer//
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
            wait.Until(ExpectedConditions.ElementExists((By)AnonCustomerSearchDropdown));
            Assert.IsTrue(driver.FindElement(AnonCustomerSearchDropdown).Displayed);
            driver.FindElement(AnonCustomerSearchDropdown).Click();
            Thread.Sleep(2000);
            //Check result is shown under access channel after selecting from dropdown
            wait.Until(ExpectedConditions.ElementExists((By)AnonAddressSearchResult));
            Assert.IsTrue(driver.FindElement(AnonAddressSearchResult).Displayed);
            //Verify case status shows as active
            wait.Until(ExpectedConditions.ElementExists((By)CaseHistoryUnderAcessChannel));
            Assert.IsTrue(driver.FindElement(CaseHistoryUnderAcessChannel).Displayed);
            wait.Until(ExpectedConditions.ElementExists((By)CaseHistoryStatus));
            Assert.IsTrue(driver.FindElement(CaseHistoryStatus).Displayed);
            driver.SwitchTo().DefaultContent();
            //Click cases on LHN
            driver.FindElement(CasesOnLHN).Click();
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)ActiveCasesTitle));
            Assert.IsTrue(driver.FindElement(ActiveCasesTitle).Displayed);
            Thread.Sleep(2000);
            //click customer name
            driver.FindElement(AnonNameOnCasesList).Click();
            Thread.Sleep(2000);
            //Click history tab
            wait.Until(ExpectedConditions.ElementExists((By)HistoryTabOnCustomer));
            driver.FindElement(HistoryTabOnCustomer).Click();
            Thread.Sleep(2000);
            try
            {
                do
                {
                    //Click select all cases
                    wait.Until(ExpectedConditions.ElementExists((By)SelectAllCasesBtn));
                    Thread.Sleep(3000);
                    driver.FindElement(SelectAllCasesBtn).Click();
                    Thread.Sleep(2000);
                    //Click more options dots
                    wait.Until(ExpectedConditions.ElementExists((By)MoreOptionsDotsOnCustomerCases));
                    Thread.Sleep(2000);
                    driver.FindElement(MoreOptionsDotsOnCustomerCases).Click();
                    Thread.Sleep(2000);
                    //Click delete cases
                    wait.Until(ExpectedConditions.ElementExists((By)DeleteCasesFromMoreOptions));
                    Thread.Sleep(2000);
                    driver.FindElement(DeleteCasesFromMoreOptions).Click();
                    Thread.Sleep(2000);
                    //Click delete on the overlay
                    wait.Until(ExpectedConditions.ElementExists((By)DeleteCasesOverlayBtn));
                    Thread.Sleep(2000);
                    driver.FindElement(DeleteCasesOverlayBtn).Click();
                    Thread.Sleep(10000);
                    wait.Until(ExpectedConditions.ElementExists((By)CustomerCasesTitle));
                }
                while (driver.FindElement(AnonOnCustomerHistory).Displayed);
            }
            catch (Exception)
            {
                Console.WriteLine("All cases removed from history screen");
            }
            //Verify cases deleted
            var Cases = 0;
            try
            {
                WebElement cases = (WebElement)driver.FindElement(AnonOnCustomerHistory);
                if (cases.Displayed)
                {
                    Cases = 1;
                    Assert.Fail();
                }
            }
            catch (Exception)
            {
                if (Cases > 0)
                {
                    Console.WriteLine("Cases not removed");
                }
                else
                {
                    Console.WriteLine("Cases removed");
                }
            }
        }

        public void AllocatingCaseStatusOnBehalfOf()
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
            wait.Until(ExpectedConditions.ElementExists((By)Searchbox));
            Assert.IsTrue(driver.FindElement(Searchbox).Displayed);
            //Enter fullname in search
            driver.FindElement(Searchbox).Click();
            driver.FindElement(Searchbox).SendKeys("Gary Moore");
            driver.FindElement(Searchbox).SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            //Check result shows on the dropdown
            wait.Until(ExpectedConditions.ElementExists((By)ExistingCustomerSearchDropdown));
            driver.FindElement(OnBehalfOfInDropdown).Click();
            driver.FindElement(ExistingCustomerSearchDropdown).Click();
            Thread.Sleep(2000);
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
            wait.Until(ExpectedConditions.ElementExists((By)FAQSearchServiceResult));
            Assert.IsTrue(driver.FindElement(FAQSearchServiceResult).Displayed);
            driver.FindElement(FAQSearchServiceResult).Click();
            Thread.Sleep(2000);
            //Verify customer name and service shown on the create new case overlay
            driver.SwitchTo().DefaultContent();
            wait.Until(ExpectedConditions.ElementExists((By)TestNameOnNewCaseOverlay));
            Assert.IsTrue(driver.FindElement(TestNameOnNewCaseOverlay).Displayed);
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
            action.SendKeys(Keys.PageDown).Build().Perform();
            Thread.Sleep(2000);
            //Click allocate box
            driver.SwitchTo().Frame("WebResource_allocatingpanel");
            wait.Until(ExpectedConditions.ElementExists((By)AllocateBtn));
            driver.FindElement(AllocateBtn).Click();
            Thread.Sleep(2000);
            driver.SwitchTo().DefaultContent();
            //Verify Job status shows in progress
            wait.Until(ExpectedConditions.ElementExists((By)JobStatus));
            Assert.IsTrue(driver.FindElement(JobStatus).Displayed);
            //Verify SLA timer starts from 7 days
            Thread.Sleep(2000);
            IWebElement element = driver.FindElement(SLATimer);
            string time = element.Text;
            Thread.Sleep(2000);
            Console.WriteLine(time);
            try
            {
                if (time.Contains("6d"))
                {
                    Console.WriteLine("SLA Correct");
                }
            }
            catch
            {
                Console.WriteLine("SLA incorrect");
                Assert.Fail();
            }
            //Verify default customer update is displayed
            wait.Until(ExpectedConditions.ElementExists((By)CustomerNameCaseDetails));
            Assert.IsTrue(driver.FindElement(CustomerNameCaseDetails).Displayed);
            //Click allocated case form
            driver.FindElement(AllocatedCaseForm).Click();
            Thread.Sleep(2000);
            //Select wakefield case on dropdown
            wait.Until(ExpectedConditions.ElementExists((By)AllocatedCaseDropdownWakefield));
            driver.FindElement(AllocatedCaseDropdownWakefield).Click();
            Thread.Sleep(10000);
            //Verify case details page is displayed
            wait.Until(ExpectedConditions.ElementExists((By)CaseDetailsForm));
            Assert.IsTrue(driver.FindElement(CaseDetailsForm).Displayed);
            //Click customer updates/history tab
            wait.Until(ExpectedConditions.ElementExists((By)CaseDetailsCustomerUpdate));
            driver.FindElement(CaseDetailsCustomerUpdate).Click();
            Thread.Sleep(2000);
            //Verify customer and reporter names are displayed
            wait.Until(ExpectedConditions.ElementExists((By)CustomerNameOnCustomerCases));
            Assert.IsTrue(driver.FindElement(CustomerNameOnCustomerCases).Displayed);
            wait.Until(ExpectedConditions.ElementExists((By)ReporterNameOnCustomerCases));
            Assert.IsTrue(driver.FindElement(ReporterNameOnCustomerCases).Displayed);
            //Verify status message is shown
            wait.Until(ExpectedConditions.ElementExists((By)CustomerUpdateStatusMessage));
            Assert.IsTrue(driver.FindElement(CustomerUpdateStatusMessage).Displayed);
            //Click summary tab
            driver.FindElement(CaseDetailsSummaryTab).Click();
            Thread.Sleep(2000);
            //click email message on timeline
            var Email = 0;
            try
            {
                if (driver.FindElements(EmailMessageOnTimeline).Count() != 0)
                {
                    Console.WriteLine("Email message displayed on timeline");
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                do
                {
                    driver.FindElement(RefreshButtonOnCaseDetails).Click();
                    Thread.Sleep(5000);
                    Email++;
                    if (driver.FindElements(EmailMessageOnTimeline).Count() != 0)
                    {
                        break;
                    }
                    else if (Email == 10)
                    {
                        Console.WriteLine("Email message not displayed on timeline");
                        Assert.Fail();
                    }
                } while (driver.FindElements(EmailMessageOnTimeline).Count() == 0);
            }
            wait.Until(ExpectedConditions.ElementExists((By)EmailMessageOnTimeline));
            Thread.Sleep(2000);
            driver.FindElement(EmailMessageOnTimeline).Click();
            Thread.Sleep(3000);
            //Verify message is correct
            wait.Until(ExpectedConditions.ElementExists((By)EmailMessageContentOnTimeline));
            Thread.Sleep(2000);
            Assert.IsTrue(driver.FindElement(EmailMessageContentOnTimeline).Displayed);
            Thread.Sleep(2000);
            //Verify current queue is correct
            driver.FindElement(RefreshButtonOnCaseDetails).Click();
            actions.SendKeys(Keys.PageDown).Build().Perform();
            wait.Until(ExpectedConditions.ElementExists((By)CaseDetailsCurrentQueue));
            Assert.IsTrue(driver.FindElement(CaseDetailsCurrentQueue).Displayed);
            //Select reporters name
            wait.Until(ExpectedConditions.ElementExists((By)ReporterNameOnCaseSummary));
            driver.FindElement(ReporterNameOnCaseSummary).Click();
            Thread.Sleep(2000);
            //Verify case shows in the history tab
            wait.Until(ExpectedConditions.ElementExists((By)HistoryTabOnCustomer));
            driver.FindElement(HistoryTabOnCustomer).Click();
            Thread.Sleep(2000);
            actions.SendKeys(Keys.PageDown).Build().Perform();
            wait.Until(ExpectedConditions.ElementExists((By)TestNameOnCustomerHistory));
            Assert.IsTrue(driver.FindElement(TestNameOnCustomerHistory).Displayed);
            //click dashboards in LHN
            driver.FindElement(DashboardsLHN).Click();
            Thread.Sleep(2000);
            //Search for customer//
            //Switch to searchbox iframe
            driver.SwitchTo().Frame(driver.FindElement(By.Id("9532b1de-41a1-456c-b21c-805faca15573_WebResource_customeradvisorstart")));
            wait.Until(ExpectedConditions.ElementExists((By)Searchbox));
            Assert.IsTrue(driver.FindElement(Searchbox).Displayed);
            //Enter fullname in search
            driver.FindElement(Searchbox).Click();
            driver.FindElement(Searchbox).SendKeys("Gary Moore");
            driver.FindElement(Searchbox).SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            //Select customer on dropdown 
            wait.Until(ExpectedConditions.ElementExists((By)ExistingCustomerSearchDropdown));
            Assert.IsTrue(driver.FindElement(ExistingCustomerSearchDropdown).Displayed);
            driver.FindElement(ExistingCustomerSearchDropdown).Click();
            Thread.Sleep(2000);
            //Check result is shown under access channel after selecting from dropdown
            wait.Until(ExpectedConditions.ElementExists((By)ExistingCustomerSearchResult));
            Assert.IsTrue(driver.FindElement(ExistingCustomerSearchResult).Displayed);
            //Verify case status shows as active
            wait.Until(ExpectedConditions.ElementExists((By)CaseHistoryUnderAcessChannel));
            Assert.IsTrue(driver.FindElement(CaseHistoryUnderAcessChannel).Displayed);
            wait.Until(ExpectedConditions.ElementExists((By)CaseHistoryStatus));
            Assert.IsTrue(driver.FindElement(CaseHistoryStatus).Displayed);
            //Verify on behalf of asterisk is shown
            wait.Until(ExpectedConditions.ElementExists((By)CaseHistoryAsterisk));
            Assert.IsTrue(driver.FindElement(CaseHistoryAsterisk).Displayed);
            driver.SwitchTo().DefaultContent();
            //Click cases on LHN
            driver.FindElement(CasesOnLHN).Click();
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)ActiveCasesTitle));
            Assert.IsTrue(driver.FindElement(ActiveCasesTitle).Displayed);
            Thread.Sleep(2000);
            //click customer name
            driver.FindElement(GaryTestOnCasesList).Click();
            Thread.Sleep(2000);
            //Click history tab
            wait.Until(ExpectedConditions.ElementExists((By)HistoryTabOnCustomer));
            driver.FindElement(HistoryTabOnCustomer).Click();
            Thread.Sleep(2000);
            try
            {
                do
                {
                    //Click select all cases
                    wait.Until(ExpectedConditions.ElementExists((By)SelectAllCasesBtn));
                    Thread.Sleep(3000);
                    driver.FindElement(SelectAllCasesBtn).Click();
                    Thread.Sleep(2000);
                    //Click more options dots
                    wait.Until(ExpectedConditions.ElementExists((By)MoreOptionsDotsOnCustomerCases));
                    Thread.Sleep(2000);
                    driver.FindElement(MoreOptionsDotsOnCustomerCases).Click();
                    Thread.Sleep(2000);
                    //Click delete cases
                    wait.Until(ExpectedConditions.ElementExists((By)DeleteCasesFromMoreOptions));
                    Thread.Sleep(2000);
                    driver.FindElement(DeleteCasesFromMoreOptions).Click();
                    Thread.Sleep(2000);
                    //Click delete on the overlay
                    wait.Until(ExpectedConditions.ElementExists((By)DeleteCasesOverlayBtn));
                    Thread.Sleep(2000);
                    driver.FindElement(DeleteCasesOverlayBtn).Click();
                    Thread.Sleep(10000);
                    wait.Until(ExpectedConditions.ElementExists((By)CustomerCasesTitle));
                }
                while (driver.FindElement(TestNameOnCustomerHistory).Displayed);
            }
            catch (Exception)
            {
                Console.WriteLine("All cases removed from history screen");
            }
            //Verify cases deleted
            var Cases = 0;
            try
            {
                WebElement cases = (WebElement)driver.FindElement(TestNameOnCustomerHistory);
                if (cases.Displayed)
                {
                    Cases = 1;
                    Assert.Fail();
                }
            }
            catch (Exception)
            {
                if (Cases > 0)
                {
                    Console.WriteLine("Cases not removed");
                }
                else
                {
                    Console.WriteLine("Cases removed");
                }
            }
        }

        public void AllocatingCaseStatusBusiness()
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
            wait.Until(ExpectedConditions.ElementExists((By)Searchbox));
            Assert.IsTrue(driver.FindElement(Searchbox).Displayed);
            //Enter fullname in search
            driver.FindElement(Searchbox).Click();
            driver.FindElement(Searchbox).SendKeys("Test Cafe");
            driver.FindElement(Searchbox).SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            //Check result shows on the dropdown
            wait.Until(ExpectedConditions.ElementExists((By)ExistingBusinessSearchDropdown));
            Assert.IsTrue(driver.FindElement(ExistingBusinessSearchDropdown).Displayed);
            driver.FindElement(ExistingBusinessSearchDropdown).Click();
            Thread.Sleep(2000);
            //Check result is shown under access channel after selecting from dropdown
            wait.Until(ExpectedConditions.ElementExists((By)ExistingBusinessSearchResult));
            Assert.IsTrue(driver.FindElement(ExistingBusinessSearchResult).Displayed);
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
            wait.Until(ExpectedConditions.ElementExists((By)FAQSearchServiceResult));
            Assert.IsTrue(driver.FindElement(FAQSearchServiceResult).Displayed);
            driver.FindElement(FAQSearchServiceResult).Click();
            Thread.Sleep(2000);
            //Verify customer name and service shown on the create new case overlay
            driver.SwitchTo().DefaultContent();
            wait.Until(ExpectedConditions.ElementExists((By)BusinessNameOnNewCaseOverlay));
            Assert.IsTrue(driver.FindElement(BusinessNameOnNewCaseOverlay).Displayed);
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
            //Verify Job status shows in progress
            wait.Until(ExpectedConditions.ElementExists((By)JobStatus));
            Assert.IsTrue(driver.FindElement(JobStatus).Displayed);
            //Verify SLA timer starts from 7 days
            Thread.Sleep(2000);
            IWebElement element = driver.FindElement(SLATimer);
            string time = element.Text;
            Thread.Sleep(2000);
            Console.WriteLine(time);
            try
            {
                if (time.Contains("6d"))
                {
                    Console.WriteLine("SLA Correct");
                }
            }
            catch
            {
                Console.WriteLine("SLA incorrect");
                Assert.Fail();
            }
            //Verify default customer update is displayed
            wait.Until(ExpectedConditions.ElementExists((By)DefaultCustomerUpdate));
            Assert.IsTrue(driver.FindElement(DefaultCustomerUpdate).Displayed);
            //Click allocated case form
            driver.FindElement(AllocatedCaseForm).Click();
            Thread.Sleep(2000);
            //Select wakefield case on dropdown
            wait.Until(ExpectedConditions.ElementExists((By)AllocatedCaseDropdownWakefield));
            driver.FindElement(AllocatedCaseDropdownWakefield).Click();
            Thread.Sleep(10000);
            //Verify case details page is displayed
            wait.Until(ExpectedConditions.ElementExists((By)CaseDetailsForm));
            Assert.IsTrue(driver.FindElement(CaseDetailsForm).Displayed);
            //Click customer updates/history tab
            wait.Until(ExpectedConditions.ElementExists((By)CaseDetailsCustomerUpdate));
            driver.FindElement(CaseDetailsCustomerUpdate).Click();
            Thread.Sleep(2000);
            //Verify status message is shown
            wait.Until(ExpectedConditions.ElementExists((By)CustomerUpdateStatusMessage));
            Assert.IsTrue(driver.FindElement(CustomerUpdateStatusMessage).Displayed);
            //Click summary tab
            driver.FindElement(CaseDetailsSummaryTab).Click();
            Thread.Sleep(2000);
            //click email message on timeline
           /* var Email = 0;        ///Emails turned off in wave environment
            try
            {
                if (driver.FindElements(EmailMessageOnTimeline).Count() != 0)
                {
                    Console.WriteLine("Email message displayed on timeline");
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                do
                {
                    driver.FindElement(RefreshButtonOnCaseDetails).Click();
                    Thread.Sleep(5000);
                    Email++;
                    if (driver.FindElements(EmailMessageOnTimeline).Count() != 0)
                    {
                        break;
                    }
                    else if (Email == 10)
                    {
                        Console.WriteLine("Email message not displayed on timeline");
                        Assert.Fail();
                    }
                } while (driver.FindElements(EmailMessageOnTimeline).Count() == 0);
            }
            wait.Until(ExpectedConditions.ElementExists((By)EmailMessageOnTimeline));
            Thread.Sleep(2000);
            driver.FindElement(EmailMessageOnTimeline).Click();
            Thread.Sleep(3000);
            //Verify message is correct
            wait.Until(ExpectedConditions.ElementExists((By)EmailMessageContentOnTimeline));
            Thread.Sleep(2000);
            Assert.IsTrue(driver.FindElement(EmailMessageContentOnTimeline).Displayed);
            Thread.Sleep(2000);*/
            //Verify current queue is correct
            wait.Until(ExpectedConditions.ElementExists((By)CaseDetailsCurrentQueue));
            Assert.IsTrue(driver.FindElement(CaseDetailsCurrentQueue).Displayed);
            //Click service form link on service details box
            driver.FindElement(ServiceFormLink).Click();
            Thread.Sleep(3000);
            //click dashboards in LHN
            driver.FindElement(DashboardsLHN).Click();
            Thread.Sleep(4000);
            //Search for customer//
            //Switch to searchbox iframe
            driver.SwitchTo().Frame(driver.FindElement(By.Id("9532b1de-41a1-456c-b21c-805faca15573_WebResource_customeradvisorstart")));
            wait.Until(ExpectedConditions.ElementExists((By)Searchbox));
            Assert.IsTrue(driver.FindElement(Searchbox).Displayed);
            //Enter fullname in search
            driver.FindElement(Searchbox).Click();
            driver.FindElement(Searchbox).SendKeys("Test Cafe");
            driver.FindElement(Searchbox).SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            //Check result shows on the dropdown
            wait.Until(ExpectedConditions.ElementExists((By)ExistingBusinessSearchDropdown));
            Assert.IsTrue(driver.FindElement(ExistingBusinessSearchDropdown).Displayed);
            driver.FindElement(ExistingBusinessSearchDropdown).Click();
            Thread.Sleep(2000);
            //Check result is shown under access channel after selecting from dropdown
            wait.Until(ExpectedConditions.ElementExists((By)ExistingBusinessSearchResult));
            Assert.IsTrue(driver.FindElement(ExistingBusinessSearchResult).Displayed);
            //Verify case status shows as active
            wait.Until(ExpectedConditions.ElementExists((By)CaseHistoryUnderAcessChannel));
            Assert.IsTrue(driver.FindElement(CaseHistoryUnderAcessChannel).Displayed);
            wait.Until(ExpectedConditions.ElementExists((By)CaseHistoryStatus));
            Assert.IsTrue(driver.FindElement(CaseHistoryStatus).Displayed);
            driver.SwitchTo().DefaultContent();
            //Click cases on LHN
            driver.FindElement(CasesOnLHN).Click();
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)ActiveCasesTitle));
            Assert.IsTrue(driver.FindElement(ActiveCasesTitle).Displayed);
            Thread.Sleep(2000);
            //click customer name
            driver.FindElement(BusinessNameOnCasesList).Click();
            Thread.Sleep(2000);
            //Click history tab
            wait.Until(ExpectedConditions.ElementExists((By)HistoryTabOnCustomer));
            driver.FindElement(HistoryTabOnCustomer).Click();
            Thread.Sleep(2000);
            try
            {
                do
                {
                    //Click select all cases
                    wait.Until(ExpectedConditions.ElementExists((By)SelectAllCasesBtn));
                    Thread.Sleep(3000);
                    driver.FindElement(SelectAllCasesBtn).Click();
                    Thread.Sleep(2000);
                    //Click more options dots
                    wait.Until(ExpectedConditions.ElementExists((By)MoreOptionsDotsOnCustomerCases));
                    Thread.Sleep(2000);
                    driver.FindElement(MoreOptionsDotsOnCustomerCases).Click();
                    Thread.Sleep(2000);
                    //Click delete cases
                    wait.Until(ExpectedConditions.ElementExists((By)DeleteCasesFromMoreOptions));
                    Thread.Sleep(2000);
                    driver.FindElement(DeleteCasesFromMoreOptions).Click();
                    Thread.Sleep(2000);
                    //Click delete on the overlay
                    wait.Until(ExpectedConditions.ElementExists((By)DeleteCasesOverlayBtn));
                    Thread.Sleep(2000);
                    driver.FindElement(DeleteCasesOverlayBtn).Click();
                    Thread.Sleep(10000);
                    wait.Until(ExpectedConditions.ElementExists((By)CustomerCasesTitle));
                }
                while (driver.FindElement(BusinessNameOnCustomerHistory).Displayed);
            }
            catch (Exception)
            {
                Console.WriteLine("All cases removed from history screen");
            }
            //Verify cases deleted
            var Cases = 0;
            try
            {
                WebElement cases = (WebElement)driver.FindElement(BusinessNameOnCustomerHistory);
                if (cases.Displayed)
                {
                    Cases = 1;
                    Assert.Fail();
                }
            }
            catch (Exception)
            {
                if (Cases > 0)
                {
                    Console.WriteLine("Cases not removed");
                }
                else
                {
                    Console.WriteLine("Cases removed");
                }
            }
        }

        public void AllocatingCaseStatusBusinessUA()
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
            wait.Until(ExpectedConditions.ElementExists((By)Searchbox));
            Assert.IsTrue(driver.FindElement(Searchbox).Displayed);
            //Enter fullname in search
            driver.FindElement(Searchbox).Click();
            driver.FindElement(Searchbox).SendKeys("Unknown Business");
            driver.FindElement(Searchbox).SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            //Check result shows on the dropdown
            wait.Until(ExpectedConditions.ElementExists((By)UABusinessSearchDropdown));
            Assert.IsTrue(driver.FindElement(UABusinessSearchDropdown).Displayed);
            driver.FindElement(UABusinessSearchDropdown).Click();
            Thread.Sleep(2000);
            //Check result is shown under access channel after selecting from dropdown
            wait.Until(ExpectedConditions.ElementExists((By)UABusinessSearchResult));
            Assert.IsTrue(driver.FindElement(UABusinessSearchResult).Displayed);
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
            wait.Until(ExpectedConditions.ElementExists((By)FAQSearchServiceResult));
            Assert.IsTrue(driver.FindElement(FAQSearchServiceResult).Displayed);
            driver.FindElement(FAQSearchServiceResult).Click();
            Thread.Sleep(2000);
            //Verify customer name and service shown on the create new case overlay
            driver.SwitchTo().DefaultContent();
            wait.Until(ExpectedConditions.ElementExists((By)UABusinessOnNewCaseOverlay));
            Assert.IsTrue(driver.FindElement(UABusinessOnNewCaseOverlay).Displayed);
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
            //Verify Job status shows in progress
            wait.Until(ExpectedConditions.ElementExists((By)JobStatus));
            Assert.IsTrue(driver.FindElement(JobStatus).Displayed);
            //Verify SLA timer starts from 7 days
            Thread.Sleep(2000);
            IWebElement element = driver.FindElement(SLATimer);
            string time = element.Text;
            Thread.Sleep(2000);
            Console.WriteLine(time);
            try
            {
                if (time.Contains("6d"))
                {
                    Console.WriteLine("SLA Correct");
                }
            }
            catch
            {
                Console.WriteLine("SLA incorrect");
                Assert.Fail();
            }
            //Verify default customer update is displayed
            wait.Until(ExpectedConditions.ElementExists((By)DefaultCustomerUpdate));
            Assert.IsTrue(driver.FindElement(DefaultCustomerUpdate).Displayed);
            //Click allocated case form
            driver.FindElement(AllocatedCaseForm).Click();
            Thread.Sleep(2000);
            //Select wakefield case on dropdown
            wait.Until(ExpectedConditions.ElementExists((By)AllocatedCaseDropdownWakefield));
            driver.FindElement(AllocatedCaseDropdownWakefield).Click();
            Thread.Sleep(10000);
            //Verify case details page is displayed
            wait.Until(ExpectedConditions.ElementExists((By)CaseDetailsForm));
            Assert.IsTrue(driver.FindElement(CaseDetailsForm).Displayed);
            //Click customer updates/history tab
            wait.Until(ExpectedConditions.ElementExists((By)CaseDetailsCustomerUpdate));
            driver.FindElement(CaseDetailsCustomerUpdate).Click();
            Thread.Sleep(2000);
            //Verify status message is shown
            wait.Until(ExpectedConditions.ElementExists((By)CustomerUpdateStatusMessage));
            Assert.IsTrue(driver.FindElement(CustomerUpdateStatusMessage).Displayed);
            //Click summary tab
            driver.FindElement(CaseDetailsSummaryTab).Click();
            Thread.Sleep(2000);
            //click email message on timeline
         /*   var Email = 0; //Emails not turned on
            try
            {
                if (driver.FindElements(EmailMessageOnTimeline).Count() != 0)
                {
                    Console.WriteLine("Email message displayed on timeline");
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                do
                {
                    driver.FindElement(RefreshButtonOnCaseDetails).Click();
                    Thread.Sleep(5000);
                    Email++;
                    if (driver.FindElements(EmailMessageOnTimeline).Count() != 0)
                    {
                        break;
                    }
                    else if (Email == 10)
                    {
                        Console.WriteLine("Email message not displayed on timeline");
                        Assert.Fail();
                    }
                } while (driver.FindElements(EmailMessageOnTimeline).Count() == 0);
            }
            wait.Until(ExpectedConditions.ElementExists((By)EmailMessageOnTimeline));
            Thread.Sleep(2000);
            driver.FindElement(EmailMessageOnTimeline).Click();
            Thread.Sleep(3000);
            //Verify message is correct
            wait.Until(ExpectedConditions.ElementExists((By)EmailMessageContentOnTimeline));
            Thread.Sleep(2000);
            Assert.IsTrue(driver.FindElement(EmailMessageContentOnTimeline).Displayed);
            Thread.Sleep(2000); */
            //Verify current queue is correct
            wait.Until(ExpectedConditions.ElementExists((By)CaseDetailsCurrentQueue));
            Assert.IsTrue(driver.FindElement(CaseDetailsCurrentQueue).Displayed);
            //Click service form link on service details box
            driver.FindElement(ServiceFormLink).Click();
            Thread.Sleep(3000);
            //click dashboards in LHN
            driver.FindElement(DashboardsLHN).Click();
            Thread.Sleep(4000);
            //Search for customer//
            //Switch to searchbox iframe
            driver.SwitchTo().Frame(driver.FindElement(By.Id("9532b1de-41a1-456c-b21c-805faca15573_WebResource_customeradvisorstart")));
            wait.Until(ExpectedConditions.ElementExists((By)Searchbox));
            Assert.IsTrue(driver.FindElement(Searchbox).Displayed);
            //Enter fullname in search
            driver.FindElement(Searchbox).Click();
            driver.FindElement(Searchbox).SendKeys("Unknown Business");
            driver.FindElement(Searchbox).SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            //Check result shows on the dropdown
            wait.Until(ExpectedConditions.ElementExists((By)UABusinessSearchDropdown));
            Assert.IsTrue(driver.FindElement(UABusinessSearchDropdown).Displayed);
            driver.FindElement(UABusinessSearchDropdown).Click();
            Thread.Sleep(2000);
            //Check result is shown under access channel after selecting from dropdown
            wait.Until(ExpectedConditions.ElementExists((By)UABusinessSearchResult));
            Assert.IsTrue(driver.FindElement(UABusinessSearchResult).Displayed);
            //Verify case status shows as active
            wait.Until(ExpectedConditions.ElementExists((By)CaseHistoryUnderAcessChannel));
            Assert.IsTrue(driver.FindElement(CaseHistoryUnderAcessChannel).Displayed);
            wait.Until(ExpectedConditions.ElementExists((By)CaseHistoryStatus));
            Assert.IsTrue(driver.FindElement(CaseHistoryStatus).Displayed);
            driver.SwitchTo().DefaultContent();
            //Click cases on LHN
            driver.FindElement(CasesOnLHN).Click();
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)ActiveCasesTitle));
            Assert.IsTrue(driver.FindElement(ActiveCasesTitle).Displayed);
            Thread.Sleep(2000);
            //click customer name
            driver.FindElement(UABusinessOnCasesList).Click();
            Thread.Sleep(2000);
            //Click history tab
            wait.Until(ExpectedConditions.ElementExists((By)HistoryTabOnCustomer));
            driver.FindElement(HistoryTabOnCustomer).Click();
            Thread.Sleep(2000);
            try
            {
                do
                {
                    //Click select all cases
                    wait.Until(ExpectedConditions.ElementExists((By)SelectAllCasesBtn));
                    Thread.Sleep(3000);
                    driver.FindElement(SelectAllCasesBtn).Click();
                    Thread.Sleep(2000);
                    //Click more options dots
                    wait.Until(ExpectedConditions.ElementExists((By)MoreOptionsDotsOnCustomerCases));
                    Thread.Sleep(2000);
                    driver.FindElement(MoreOptionsDotsOnCustomerCases).Click();
                    Thread.Sleep(2000);
                    //Click delete cases
                    wait.Until(ExpectedConditions.ElementExists((By)DeleteCasesFromMoreOptions));
                    Thread.Sleep(2000);
                    driver.FindElement(DeleteCasesFromMoreOptions).Click();
                    Thread.Sleep(2000);
                    //Click delete on the overlay
                    wait.Until(ExpectedConditions.ElementExists((By)DeleteCasesOverlayBtn));
                    Thread.Sleep(2000);
                    driver.FindElement(DeleteCasesOverlayBtn).Click();
                    Thread.Sleep(10000);
                    wait.Until(ExpectedConditions.ElementExists((By)CustomerCasesTitle));
                }
                while (driver.FindElement(UABusinessOnCustomerHistory).Displayed);
            }
            catch (Exception)
            {
                Console.WriteLine("All cases removed from history screen");
            }
            //Verify cases deleted
            var Cases = 0;
            try
            {
                WebElement cases = (WebElement)driver.FindElement(UABusinessOnCustomerHistory);
                if (cases.Displayed)
                {
                    Cases = 1;
                    Assert.Fail();
                }
            }
            catch (Exception)
            {
                if (Cases > 0)
                {
                    Console.WriteLine("Cases not removed");
                }
                else
                {
                    Console.WriteLine("Cases removed");
                }
            }
        }

        public void AllocatingCaseStatusOnBehalfOfBusiness()
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
            wait.Until(ExpectedConditions.ElementExists((By)Searchbox));
            Assert.IsTrue(driver.FindElement(Searchbox).Displayed);
            //Enter fullname in search
            driver.FindElement(Searchbox).Click();
            driver.FindElement(Searchbox).SendKeys("Test Business");
            driver.FindElement(Searchbox).SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            //Check result shows on the dropdown
            wait.Until(ExpectedConditions.ElementExists((By)TestBusinessInDropdown));
            driver.FindElement(OnBehalfOfInDropdown).Click();
            driver.FindElement(TestBusinessInDropdown).Click();
            Thread.Sleep(2000);
            //Remove search term from box
            driver.FindElement(Searchbox).Click();
            Actions action = new Actions(driver);
            WebElement ele = (WebElement)driver.FindElement(Searchbox);
            action.Click(ele).Click(ele).Click(ele).Perform();
            driver.FindElement(Searchbox).SendKeys(Keys.Delete);
            //Search for different customer
            Thread.Sleep(2000);
            driver.FindElement(Searchbox).SendKeys("Test cafe");
            driver.FindElement(Searchbox).SendKeys(Keys.Enter);
            wait.Until(ExpectedConditions.ElementExists((By)ExistingBusinessSearchDropdown));
            Assert.IsTrue(driver.FindElement(ExistingBusinessSearchDropdown).Displayed);
            driver.FindElement(ExistingBusinessSearchDropdown).Click();
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)ExistingBusinessSearchResult));
            Assert.IsTrue(driver.FindElement(ExistingBusinessSearchResult).Displayed);
            Thread.Sleep(2000);
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
            wait.Until(ExpectedConditions.ElementExists((By)FAQSearchServiceResult));
            Assert.IsTrue(driver.FindElement(FAQSearchServiceResult).Displayed);
            driver.FindElement(FAQSearchServiceResult).Click();
            Thread.Sleep(2000);
            //Verify customer name and service shown on the create new case overlay
            driver.SwitchTo().DefaultContent();
            wait.Until(ExpectedConditions.ElementExists((By)BusinessNameOnNewCaseOverlay));
            Assert.IsTrue(driver.FindElement(BusinessNameOnNewCaseOverlay).Displayed);
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
            action.SendKeys(Keys.PageDown).Build().Perform();
            Thread.Sleep(2000);
            //Click allocate box
            driver.SwitchTo().Frame("WebResource_allocatingpanel");
            wait.Until(ExpectedConditions.ElementExists((By)AllocateBtn));
            driver.FindElement(AllocateBtn).Click();
            Thread.Sleep(2000);
            driver.SwitchTo().DefaultContent();
            //Verify Job status shows in progress
            wait.Until(ExpectedConditions.ElementExists((By)JobStatus));
            Assert.IsTrue(driver.FindElement(JobStatus).Displayed);
            //Verify SLA timer starts from 7 days
            Thread.Sleep(2000);
            IWebElement element = driver.FindElement(SLATimer);
            string time = element.Text;
            Thread.Sleep(2000);
            Console.WriteLine(time);
            try
            {
                if (time.Contains("6d"))
                {
                    Console.WriteLine("SLA Correct");
                }
            }
            catch
            {
                Console.WriteLine("SLA incorrect");
                Assert.Fail();
            }
            //Verify default customer update is displayed
            wait.Until(ExpectedConditions.ElementExists((By)BusinessNameCaseDetails));
            Assert.IsTrue(driver.FindElement(BusinessNameCaseDetails).Displayed);
            //Click allocated case form
            driver.FindElement(AllocatedCaseForm).Click();
            Thread.Sleep(2000);
            //Select wakefield case on dropdown
            wait.Until(ExpectedConditions.ElementExists((By)AllocatedCaseDropdownWakefield));
            driver.FindElement(AllocatedCaseDropdownWakefield).Click();
            Thread.Sleep(10000);
            //Verify case details page is displayed
            wait.Until(ExpectedConditions.ElementExists((By)CaseDetailsForm));
            Assert.IsTrue(driver.FindElement(CaseDetailsForm).Displayed);
            //Click customer updates/history tab
            wait.Until(ExpectedConditions.ElementExists((By)CaseDetailsCustomerUpdate));
            driver.FindElement(CaseDetailsCustomerUpdate).Click();
            Thread.Sleep(2000);
            actions.SendKeys(Keys.PageDown).Build().Perform();
            //Verify customer and reporter names are displayed
            wait.Until(ExpectedConditions.ElementExists((By)BusinessNameOnCustomerCases));
            Assert.IsTrue(driver.FindElement(BusinessNameOnCustomerCases).Displayed);
            //Verify status message is shown
            wait.Until(ExpectedConditions.ElementExists((By)CustomerUpdateStatusMessage));
            Assert.IsTrue(driver.FindElement(CustomerUpdateStatusMessage).Displayed);
            //Click summary tab
            driver.FindElement(CaseDetailsSummaryTab).Click();
            Thread.Sleep(2000);
            //click email message on timeline
            /*var Email = 0;  //Emails not currently switched on in wave
            try
            {
                if (driver.FindElements(EmailMessageOnTimeline).Count() != 0)
                {
                    Console.WriteLine("Email message displayed on timeline");
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                do
                {
                    driver.FindElement(RefreshButtonOnCaseDetails).Click();
                    Thread.Sleep(5000);
                    Email++;
                    if (driver.FindElements(EmailMessageOnTimeline).Count() != 0)
                    {
                        break;
                    }
                    else if (Email == 10)
                    {
                        Console.WriteLine("Email message not displayed on timeline");
                        Assert.Fail();
                    }
                } while (driver.FindElements(EmailMessageOnTimeline).Count() == 0);
            }
            wait.Until(ExpectedConditions.ElementExists((By)EmailMessageOnTimeline));
            Thread.Sleep(2000);
            driver.FindElement(EmailMessageOnTimeline).Click();
            Thread.Sleep(3000);
            //Verify message is correct
            wait.Until(ExpectedConditions.ElementExists((By)EmailMessageContentOnTimeline));
            Thread.Sleep(2000);
            Assert.IsTrue(driver.FindElement(EmailMessageContentOnTimeline).Displayed);
            Thread.Sleep(2000);*/
            //Verify current queue is correct
            driver.FindElement(RefreshButtonOnCaseDetails).Click();
            actions.SendKeys(Keys.PageDown).Build().Perform();
            wait.Until(ExpectedConditions.ElementExists((By)CaseDetailsCurrentQueue));
            Assert.IsTrue(driver.FindElement(CaseDetailsCurrentQueue).Displayed);
            //Select reporters name
            wait.Until(ExpectedConditions.ElementExists((By)ReporterBusinessOnCaseSummary));
            driver.FindElement(ReporterBusinessOnCaseSummary).Click();
            Thread.Sleep(2000);
            //Verify case shows in the history tab
            wait.Until(ExpectedConditions.ElementExists((By)HistoryTabOnCustomer));
            driver.FindElement(HistoryTabOnCustomer).Click();
            Thread.Sleep(2000);
            actions.SendKeys(Keys.PageDown).Build().Perform();
            wait.Until(ExpectedConditions.ElementExists((By)BusinessNameOnCustomerHistory));
            Assert.IsTrue(driver.FindElement(BusinessNameOnCustomerHistory).Displayed);
            //click dashboards in LHN
            driver.FindElement(DashboardsLHN).Click();
            Thread.Sleep(2000);
            //Search for customer//
            //Switch to searchbox iframe
            driver.SwitchTo().Frame(driver.FindElement(By.Id("9532b1de-41a1-456c-b21c-805faca15573_WebResource_customeradvisorstart")));
            wait.Until(ExpectedConditions.ElementExists((By)Searchbox));
            Assert.IsTrue(driver.FindElement(Searchbox).Displayed);
            //Enter fullname in search
            driver.FindElement(Searchbox).Click();
            driver.FindElement(Searchbox).SendKeys("Test Business");
            driver.FindElement(Searchbox).SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            //Check result shows on the dropdown
            wait.Until(ExpectedConditions.ElementExists((By)TestBusinessInDropdown));
            driver.FindElement(TestBusinessInDropdown).Click();
            Thread.Sleep(2000);
            //Check result is shown under access channel after selecting from dropdown
            wait.Until(ExpectedConditions.ElementExists((By)TestBusinessInAccessChannel));
            Assert.IsTrue(driver.FindElement(TestBusinessInAccessChannel).Displayed);
            //Verify case status shows as active
            wait.Until(ExpectedConditions.ElementExists((By)CaseHistoryUnderAcessChannel));
            Assert.IsTrue(driver.FindElement(CaseHistoryUnderAcessChannel).Displayed);
            wait.Until(ExpectedConditions.ElementExists((By)CaseHistoryStatus));
            Assert.IsTrue(driver.FindElement(CaseHistoryStatus).Displayed);
            //Verify on behalf of asterisk is shown
            wait.Until(ExpectedConditions.ElementExists((By)CaseHistoryAsterisk));
            Assert.IsTrue(driver.FindElement(CaseHistoryAsterisk).Displayed);
            driver.SwitchTo().DefaultContent();
            //Click cases on LHN
            driver.FindElement(CasesOnLHN).Click();
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)ActiveCasesTitle));
            Assert.IsTrue(driver.FindElement(ActiveCasesTitle).Displayed);
            Thread.Sleep(2000);
            //click customer name
            driver.FindElement(BusinessNameOnCasesList).Click();
            Thread.Sleep(2000);
            //Click history tab
            wait.Until(ExpectedConditions.ElementExists((By)HistoryTabOnCustomer));
            driver.FindElement(HistoryTabOnCustomer).Click();
            Thread.Sleep(2000);
            try
            {
                do
                {
                    //Click select all cases
                    wait.Until(ExpectedConditions.ElementExists((By)SelectAllCasesBtn));
                    Thread.Sleep(3000);
                    driver.FindElement(SelectAllCasesBtn).Click();
                    Thread.Sleep(2000);
                    //Click more options dots
                    wait.Until(ExpectedConditions.ElementExists((By)MoreOptionsDotsOnCustomerCases));
                    Thread.Sleep(2000);
                    driver.FindElement(MoreOptionsDotsOnCustomerCases).Click();
                    Thread.Sleep(2000);
                    //Click delete cases
                    wait.Until(ExpectedConditions.ElementExists((By)DeleteCasesFromMoreOptions));
                    Thread.Sleep(2000);
                    driver.FindElement(DeleteCasesFromMoreOptions).Click();
                    Thread.Sleep(2000);
                    //Click delete on the overlay
                    wait.Until(ExpectedConditions.ElementExists((By)DeleteCasesOverlayBtn));
                    Thread.Sleep(2000);
                    driver.FindElement(DeleteCasesOverlayBtn).Click();
                    Thread.Sleep(10000);
                    wait.Until(ExpectedConditions.ElementExists((By)CustomerCasesTitle));
                }
                while (driver.FindElement(TestBusinessOnCustomerHistory).Displayed);
            }
            catch (Exception)
            {
                Console.WriteLine("All cases removed from history screen");
            }
            //Verify cases deleted
            var Cases = 0;
            try
            {
                WebElement cases = (WebElement)driver.FindElement(TestBusinessOnCustomerHistory);
                if (cases.Displayed)
                {
                    Cases = 1;
                    Assert.Fail();
                }
            }
            catch (Exception)
            {
                if (Cases > 0)
                {
                    Console.WriteLine("Cases not removed");
                }
                else
                {
                    Console.WriteLine("Cases removed");
                }
            }
        }

        public void CustomerRejectCase()
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
            driver.FindElement(Searchbox).SendKeys("Gary Moore");
            driver.FindElement(Searchbox).SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            //Check result shows on the dropdown
            wait.Until(ExpectedConditions.ElementExists((By)ExistingCustomerSearchDropdown));
            Assert.IsTrue(driver.FindElement(ExistingCustomerSearchDropdown).Displayed);
            driver.FindElement(ExistingCustomerSearchDropdown).Click();
            Thread.Sleep(2000);
            //Check result is shown under access channel after selecting from dropdown
            wait.Until(ExpectedConditions.ElementExists((By)ExistingCustomerSearchResult));
            Assert.IsTrue(driver.FindElement(ExistingCustomerSearchResult).Displayed);
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
            wait.Until(ExpectedConditions.ElementExists((By)FAQSearchServiceResult));
            Assert.IsTrue(driver.FindElement(FAQSearchServiceResult).Displayed);
            driver.FindElement(FAQSearchServiceResult).Click();
            Thread.Sleep(2000);
            //Verify customer name and service shown on the create new case overlay
            driver.SwitchTo().DefaultContent();
            wait.Until(ExpectedConditions.ElementExists((By)CustomerNameOnNewCaseOverlay));
            Assert.IsTrue(driver.FindElement(CustomerNameOnNewCaseOverlay).Displayed);
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
            //Select private land
            Actions actions = new Actions(driver);
            actions.SendKeys(Keys.PageDown).Build().Perform();
            Thread.Sleep(2000);
            driver.FindElement(DogFoulingLandType).Click();
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)DogFoulingLandPrivate));
            driver.FindElement(DogFoulingLandPrivate).Click();
            Thread.Sleep(2000);
            driver.FindElement(DogFoulingLandType).Click();
            Thread.Sleep(2000);
            //Click reject
            driver.SwitchTo().Frame("WebResource_allocatingpanel");
            wait.Until(ExpectedConditions.ElementExists((By)RejectBtn));
            Thread.Sleep(2000);
            driver.FindElement(RejectBtn).Click();
            Thread.Sleep(2000);
            //Select customer rejecting on dropdown
            wait.Until(ExpectedConditions.ElementExists((By)RejectReasonDropdown));
            driver.FindElement(RejectReasonDropdown).Click();
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)RejectReasonCustomerRejected));
            driver.FindElement(RejectReasonCustomerRejected).Click();
            Thread.Sleep(2000);
            //Verify default message is shown
            wait.Until(ExpectedConditions.ElementExists((By)RejectCustomerMsg));
            Assert.IsTrue(driver.FindElement(RejectCustomerMsg).Displayed);
            Thread.Sleep(2000);
            //Click submit button
            wait.Until(ExpectedConditions.ElementExists((By)StatusSubmitBtn));
            driver.FindElement(StatusSubmitBtn).Click();
            Thread.Sleep(2000);
            driver.SwitchTo().DefaultContent();
            //Verify case summary page loads
            wait.Until(ExpectedConditions.ElementExists((By)CustomerInfoTitleOnCaseSummary));
            Assert.IsTrue(driver.FindElement(CustomerInfoTitleOnCaseSummary).Displayed);
            //Verify SLA empty
            wait.Until(ExpectedConditions.ElementExists((By)EmptySLAOnCaseSummary));
            Assert.IsTrue(driver.FindElement(EmptySLAOnCaseSummary).Displayed);
            Thread.Sleep(2000);
            //Click refresh button
            var Status = 0;
            try
            {
                if (driver.FindElements(JobStatusOnCaseSummary).Count() != 0)
                {
                    Console.WriteLine("Job status changed from in progress");
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                do
                {
                    driver.FindElement(RefreshButtonOnCaseDetails).Click();
                    Thread.Sleep(5000);
                    Status++;
                    if (driver.FindElements(JobStatusOnCaseSummary).Count() != 0)
                    {
                        break;
                    }
                    else if (Status == 10)
                    {
                        Console.WriteLine("Job status not updated from in progress");
                        Assert.Fail();
                    }
                } while (driver.FindElements(JobStatusOnCaseSummary).Count() == 0);
            }
            //Verify status updated to customer rejected
            wait.Until(ExpectedConditions.ElementExists((By)JobStatusOnCaseSummary));
            Assert.IsTrue(driver.FindElement(JobStatusOnCaseSummary).Displayed);
            Thread.Sleep(2000);
            //Select wakefield case from allocated case dropdown
            wait.Until(ExpectedConditions.ElementExists((By)AllocatedCaseForm));
            driver.FindElement(AllocatedCaseForm).Click();
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)AllocatedCaseDropdownWakefield));
            driver.FindElement(AllocatedCaseDropdownWakefield).Click();
            Thread.Sleep(2000);
            //Verify case details form loads
            wait.Until(ExpectedConditions.ElementExists((By)CaseDetailsForm));
            Assert.IsTrue(driver.FindElement(CaseDetailsForm).Displayed);
            Thread.Sleep(2000);
            //Verify last customer update shows rejected message
            wait.Until(ExpectedConditions.ElementExists((By)CaseDetailsRejectedUpdateMsg));
            Assert.IsTrue(driver.FindElement(CaseDetailsRejectedUpdateMsg).Displayed);
            Thread.Sleep(2000);
            //Verify status message shown on timeline
            wait.Until(ExpectedConditions.ElementExists((By)TimelineStatusClosed));
            Assert.IsTrue(driver.FindElement(TimelineStatusClosed).Displayed);
            Thread.Sleep(2000);
            //Click customer updates/history
            driver.FindElement(HistoryTabOnCustomer).Click();
            Thread.Sleep(2000);
            //Verify status updates shows the rejected status message
            wait.Until(ExpectedConditions.ElementExists((By)CustomerStatusOnHistoryTab));
            Assert.IsTrue(driver.FindElement(CustomerStatusOnHistoryTab).Displayed);
            Thread.Sleep(2000);
            //Click back to summary tab
            driver.FindElement(CaseDetailsSummaryTab).Click();
            Thread.Sleep(2000);
            //Click case form link on service details
            Assert.IsTrue(driver.FindElement(ServiceFormLink).Displayed);
            Thread.Sleep(2000);
            driver.FindElement(ServiceFormLink).Click();
            Thread.Sleep(2000);
            //Verify form loads
            wait.Until(ExpectedConditions.ElementExists((By)DogFoulingFormTitle));
            Assert.IsTrue(driver.FindElement(DogFoulingFormTitle).Displayed);
            Thread.Sleep(2000);
            //Verify message shows record is inactive
            wait.Until(ExpectedConditions.ElementExists((By)DogFoulingFormStatusInactive));
            Assert.IsTrue(driver.FindElement(DogFoulingFormStatusInactive).Displayed);
            Thread.Sleep(2000);
            //Click dashboards in LHN
            driver.FindElement(DashboardsLHN).Click();
            Thread.Sleep(2000);
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
            driver.FindElement(Searchbox).SendKeys("Gary Moore");
            driver.FindElement(Searchbox).SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            //Check result shows on the dropdown
            wait.Until(ExpectedConditions.ElementExists((By)ExistingCustomerSearchDropdown));
            Assert.IsTrue(driver.FindElement(ExistingCustomerSearchDropdown).Displayed);
            driver.FindElement(ExistingCustomerSearchDropdown).Click();
            Thread.Sleep(2000);
            //Check result is shown under access channel after selecting from dropdown
            wait.Until(ExpectedConditions.ElementExists((By)ExistingCustomerSearchResult));
            Assert.IsTrue(driver.FindElement(ExistingCustomerSearchResult).Displayed);
            Thread.Sleep(5000);
            //Verify job status shows as cancelled
            wait.Until(ExpectedConditions.ElementExists((By)CaseHistoryCancelled));
            Assert.IsTrue(driver.FindElement(CaseHistoryCancelled).Displayed);
            Thread.Sleep(2000);
            //Click customer name
            driver.FindElement(ExistingCustomerSearchResult).Click();
            Thread.Sleep(2000);
            driver.SwitchTo().DefaultContent();
            Thread.Sleep(2000);
            //Click history tab
            driver.FindElement(HistoryTabOnCustomer).Click();
            Thread.Sleep(2000);
            Actions action = new Actions(driver);
            action.SendKeys(Keys.PageDown).Build().Perform();
            var Cases = 0;
            try
            {
                if (driver.FindElements(CustomerNameOnCustomerHistory).Count() != 0)
                    Console.WriteLine("Cases present on customer history");
                {
                    do
                    {
                        //Click select all cases
                        wait.Until(ExpectedConditions.ElementExists((By)SelectAllCasesBtn));
                        Thread.Sleep(3000);
                        driver.FindElement(SelectAllCasesBtn).Click();
                        Thread.Sleep(2000);
                        //Click more options dots
                        wait.Until(ExpectedConditions.ElementExists((By)MoreOptionsDotsOnCustomerCases));
                        Thread.Sleep(2000);
                        driver.FindElement(MoreOptionsDotsOnCustomerCases).Click();
                        Thread.Sleep(2000);
                        //Click delete cases
                        wait.Until(ExpectedConditions.ElementExists((By)DeleteCasesFromMoreOptions));
                        Thread.Sleep(2000);
                        driver.FindElement(DeleteCasesFromMoreOptions).Click();
                        Thread.Sleep(2000);
                        //Click delete on the overlay
                        wait.Until(ExpectedConditions.ElementExists((By)DeleteCasesOverlayBtn));
                        Thread.Sleep(2000);
                        driver.FindElement(DeleteCasesOverlayBtn).Click();
                        Thread.Sleep(10000);
                        wait.Until(ExpectedConditions.ElementExists((By)CustomerCasesTitle));
                        Cases++;
                        if (driver.FindElements(CustomerNameOnCustomerHistory).Count() == 0)
                        {
                            Console.WriteLine("All cases removed");
                            break;
                        }
                    }
                    while (driver.FindElements(CustomerNameOnCustomerHistory).Count() != 0);
                }
            }
            catch (Exception)
            {
                if (Cases == 0)
                {
                    Console.WriteLine("No cases were added to customer history");
                    Assert.Fail();
                }
            }
        }

        public void OOACustomerRejectCase()
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
            driver.FindElement(Searchbox).SendKeys("Out Ofarea");
            driver.FindElement(Searchbox).SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            //Check result shows on the dropdown
            wait.Until(ExpectedConditions.ElementExists((By)OutOfareaDetailsOnDropdown));
            Assert.IsTrue(driver.FindElement(OutOfareaDetailsOnDropdown).Displayed);
            driver.FindElement(OutOfareaDetailsOnDropdown).Click();
            Thread.Sleep(2000);
            //Check result is shown under access channel after selecting from dropdown
            wait.Until(ExpectedConditions.ElementExists((By)OutOfareaSearchResult));
            Assert.IsTrue(driver.FindElement(OutOfareaSearchResult).Displayed);
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
            wait.Until(ExpectedConditions.ElementExists((By)FAQSearchServiceResult));
            Assert.IsTrue(driver.FindElement(FAQSearchServiceResult).Displayed);
            driver.FindElement(FAQSearchServiceResult).Click();
            Thread.Sleep(2000);
            //Verify customer name and service shown on the create new case overlay
            driver.SwitchTo().DefaultContent();
            wait.Until(ExpectedConditions.ElementExists((By)OOANameOnNewCaseOverlay));
            Assert.IsTrue(driver.FindElement(OOANameOnNewCaseOverlay).Displayed);
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
            driver.FindElement(AddressSearchBox).SendKeys("pontefract");
            Thread.Sleep(1000);
            driver.FindElement(AddressSearchBox).SendKeys(Keys.Enter);
            wait.Until(ExpectedConditions.ElementExists((By)NewCustomerAddressDropdown));
            driver.FindElement(NewCustomerAddressDropdown).Click();
            driver.SwitchTo().DefaultContent();
            Thread.Sleep(5000);
            //Select private land
            Actions actions = new Actions(driver);
            actions.SendKeys(Keys.PageDown).Build().Perform();
            Thread.Sleep(2000);
            driver.FindElement(DogFoulingLandType).Click();
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)DogFoulingLandPrivate));
            driver.FindElement(DogFoulingLandPrivate).Click();
            Thread.Sleep(2000);
            driver.FindElement(DogFoulingLandType).Click();
            Thread.Sleep(2000);
            //Click reject
            driver.SwitchTo().Frame("WebResource_allocatingpanel");
            wait.Until(ExpectedConditions.ElementExists((By)RejectBtn));
            Thread.Sleep(2000);
            driver.FindElement(RejectBtn).Click();
            Thread.Sleep(2000);
            //Select customer rejecting on dropdown
            wait.Until(ExpectedConditions.ElementExists((By)RejectReasonDropdown));
            driver.FindElement(RejectReasonDropdown).Click();
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)RejectReasonCustomerRejected));
            driver.FindElement(RejectReasonCustomerRejected).Click();
            Thread.Sleep(2000);
            //Verify default message is shown
            wait.Until(ExpectedConditions.ElementExists((By)RejectCustomerMsg));
            Assert.IsTrue(driver.FindElement(RejectCustomerMsg).Displayed);
            Thread.Sleep(2000);
            //Click submit button
            wait.Until(ExpectedConditions.ElementExists((By)StatusSubmitBtn));
            driver.FindElement(StatusSubmitBtn).Click();
            Thread.Sleep(2000);
            driver.SwitchTo().DefaultContent();
            //Verify case summary page loads
            wait.Until(ExpectedConditions.ElementExists((By)CustomerInfoTitleOnCaseSummary));
            Assert.IsTrue(driver.FindElement(CustomerInfoTitleOnCaseSummary).Displayed);
            //Verify SLA empty
            wait.Until(ExpectedConditions.ElementExists((By)EmptySLAOnCaseSummary));
            Assert.IsTrue(driver.FindElement(EmptySLAOnCaseSummary).Displayed);
            Thread.Sleep(2000);
            //Click refresh button
            var Status = 0;
            try
            {
                if (driver.FindElements(JobStatusOnCaseSummary).Count() != 0)
                {
                    Console.WriteLine("Job status changed from in progress");
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                do
                {
                    driver.FindElement(RefreshButtonOnCaseDetails).Click();
                    Thread.Sleep(5000);
                    Status++;
                    if (driver.FindElements(JobStatusOnCaseSummary).Count() != 0)
                    {
                        break;
                    }
                    else if (Status == 10)
                    {
                        Console.WriteLine("Job status not updated from in progress");
                        Assert.Fail();
                    }
                } while (driver.FindElements(JobStatusOnCaseSummary).Count() == 0);
            }
            //Verify status updated to customer rejected
            wait.Until(ExpectedConditions.ElementExists((By)JobStatusOnCaseSummary));
            Assert.IsTrue(driver.FindElement(JobStatusOnCaseSummary).Displayed);
            Thread.Sleep(2000);
            //Select wakefield case from allocated case dropdown
            wait.Until(ExpectedConditions.ElementExists((By)AllocatedCaseForm));
            driver.FindElement(AllocatedCaseForm).Click();
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)AllocatedCaseDropdownWakefield));
            driver.FindElement(AllocatedCaseDropdownWakefield).Click();
            Thread.Sleep(2000);
            //Verify case details form loads
            wait.Until(ExpectedConditions.ElementExists((By)CaseDetailsForm));
            Assert.IsTrue(driver.FindElement(CaseDetailsForm).Displayed);
            Thread.Sleep(2000);
            //Verify last customer update shows rejected message
            wait.Until(ExpectedConditions.ElementExists((By)CaseDetailsRejectedUpdateMsg));
            Assert.IsTrue(driver.FindElement(CaseDetailsRejectedUpdateMsg).Displayed);
            Thread.Sleep(2000);
            //Verify status message shown on timeline
            wait.Until(ExpectedConditions.ElementExists((By)TimelineStatusClosed));
            Assert.IsTrue(driver.FindElement(TimelineStatusClosed).Displayed);
            Thread.Sleep(2000);
            //Click customer updates/history
            driver.FindElement(HistoryTabOnCustomer).Click();
            Thread.Sleep(2000);
            //Verify status updates shows the rejected status message
            wait.Until(ExpectedConditions.ElementExists((By)CustomerStatusOnHistoryTab));
            Assert.IsTrue(driver.FindElement(CustomerStatusOnHistoryTab).Displayed);
            Thread.Sleep(2000);
            //Click back to summary tab
            driver.FindElement(CaseDetailsSummaryTab).Click();
            Thread.Sleep(2000);
            //Click case form link on service details
            Assert.IsTrue(driver.FindElement(ServiceFormLink).Displayed);
            Thread.Sleep(2000);
            driver.FindElement(ServiceFormLink).Click();
            Thread.Sleep(2000);
            //Verify form loads
            wait.Until(ExpectedConditions.ElementExists((By)DogFoulingFormTitle));
            Assert.IsTrue(driver.FindElement(DogFoulingFormTitle).Displayed);
            Thread.Sleep(2000);
            //Verify message shows record is inactive
            wait.Until(ExpectedConditions.ElementExists((By)DogFoulingFormStatusInactive));
            Assert.IsTrue(driver.FindElement(DogFoulingFormStatusInactive).Displayed);
            Thread.Sleep(2000);
            //Click dashboards in LHN
            driver.FindElement(DashboardsLHN).Click();
            Thread.Sleep(2000);
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
            driver.FindElement(Searchbox).SendKeys("Out Ofarea");
            driver.FindElement(Searchbox).SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            //Select customer on dropdown 
            wait.Until(ExpectedConditions.ElementExists((By)OutOfareaDetailsOnDropdown));
            Assert.IsTrue(driver.FindElement(OutOfareaDetailsOnDropdown).Displayed);
            driver.FindElement(OutOfareaDetailsOnDropdown).Click();
            Thread.Sleep(2000);
            //Check result is shown under access channel after selecting from dropdown
            wait.Until(ExpectedConditions.ElementExists((By)OutOfareaSearchResult));
            Assert.IsTrue(driver.FindElement(OutOfareaSearchResult).Displayed);
            Thread.Sleep(5000);
            //Verify job status shows as cancelled
            wait.Until(ExpectedConditions.ElementExists((By)CaseHistoryCancelled));
            Assert.IsTrue(driver.FindElement(CaseHistoryCancelled).Displayed);
            Thread.Sleep(2000);
            //Click customer name
            driver.FindElement(OutOfareaSearchResult).Click();
            Thread.Sleep(2000);
            driver.SwitchTo().DefaultContent();
            Thread.Sleep(2000);
            //Click history tab
            driver.FindElement(HistoryTabOnCustomer).Click();
            Thread.Sleep(2000);
            Actions action = new Actions(driver);
            action.SendKeys(Keys.PageDown).Build().Perform();
            var Cases = 0;
            try
            {
                if (driver.FindElements(OOANameOnCustomerHistory).Count() != 0)
                    Console.WriteLine("Cases present on customer history");
                {
                    do
                    {
                        //Click select all cases
                        wait.Until(ExpectedConditions.ElementExists((By)SelectAllCasesBtn));
                        Thread.Sleep(3000);
                        driver.FindElement(SelectAllCasesBtn).Click();
                        Thread.Sleep(2000);
                        //Click more options dots
                        wait.Until(ExpectedConditions.ElementExists((By)MoreOptionsDotsOnCustomerCases));
                        Thread.Sleep(2000);
                        driver.FindElement(MoreOptionsDotsOnCustomerCases).Click();
                        Thread.Sleep(2000);
                        //Click delete cases
                        wait.Until(ExpectedConditions.ElementExists((By)DeleteCasesFromMoreOptions));
                        Thread.Sleep(2000);
                        driver.FindElement(DeleteCasesFromMoreOptions).Click();
                        Thread.Sleep(2000);
                        //Click delete on the overlay
                        wait.Until(ExpectedConditions.ElementExists((By)DeleteCasesOverlayBtn));
                        Thread.Sleep(2000);
                        driver.FindElement(DeleteCasesOverlayBtn).Click();
                        Thread.Sleep(10000);
                        wait.Until(ExpectedConditions.ElementExists((By)CustomerCasesTitle));
                        Cases++;
                        if (driver.FindElements(OOANameOnCustomerHistory).Count() == 0)
                        {
                            Console.WriteLine("All cases removed");
                            break;
                        }
                    }
                    while (driver.FindElements(OOANameOnCustomerHistory).Count() != 0);
                }
            }
            catch (Exception)
            {
                if (Cases == 0)
                {
                    Console.WriteLine("No cases were added to customer history");
                    Assert.Fail();
                }
            }
        }

        public void ManualAddressCustomerRejectCase()
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
            wait.Until(ExpectedConditions.ElementExists((By)FAQSearchServiceResult));
            Assert.IsTrue(driver.FindElement(FAQSearchServiceResult).Displayed);
            driver.FindElement(FAQSearchServiceResult).Click();
            Thread.Sleep(2000);
            //Verify customer name and service shown on the create new case overlay
            driver.SwitchTo().DefaultContent();
            wait.Until(ExpectedConditions.ElementExists((By)ManualAddressOnNewCaseOverlay));
            Assert.IsTrue(driver.FindElement(ManualAddressOnNewCaseOverlay).Displayed);
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
            Thread.Sleep(2000);
            //Click can't find address link
            wait.Until(ExpectedConditions.ElementExists((By)CantFindAddressLink));
            driver.FindElement(CantFindAddressLink).Click();
            Thread.Sleep(2000);
            driver.SwitchTo().DefaultContent();
            //Click I understand on overlay
            wait.Until(ExpectedConditions.ElementExists((By)UnderstandBtnOnOverlay));
            driver.FindElement(UnderstandBtnOnOverlay).Click();
            Thread.Sleep(2000);
            //Enter address
            driver.SwitchTo().Frame("WebResource_WMDCAddressSearch");
            wait.Until(ExpectedConditions.ElementExists((By)FindAddressSearchBox));
            driver.FindElement(FindAddressSearchBox).Click();
            driver.FindElement(FindAddressSearchBox).SendKeys("80 spring avenue, ashby-de-la-zouch, le65 2rb");
            Thread.Sleep(2000);
            driver.FindElement(AddressConfirmBtn).Click();
            driver.SwitchTo().DefaultContent();
            Thread.Sleep(5000);
            //Select private land
            Actions actions = new Actions(driver);
            actions.SendKeys(Keys.PageDown).Build().Perform();
            Thread.Sleep(2000);
            driver.FindElement(DogFoulingLandType).Click();
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)DogFoulingLandPrivate));
            driver.FindElement(DogFoulingLandPrivate).Click();
            Thread.Sleep(2000);
            driver.FindElement(DogFoulingLandType).Click();
            Thread.Sleep(2000);
            //Click reject
            driver.SwitchTo().Frame("WebResource_allocatingpanel");
            wait.Until(ExpectedConditions.ElementExists((By)RejectBtn));
            Thread.Sleep(2000);
            driver.FindElement(RejectBtn).Click();
            Thread.Sleep(2000);
            //Select customer rejecting on dropdown
            wait.Until(ExpectedConditions.ElementExists((By)RejectReasonDropdown));
            driver.FindElement(RejectReasonDropdown).Click();
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)RejectReasonCustomerRejected));
            driver.FindElement(RejectReasonCustomerRejected).Click();
            Thread.Sleep(2000);
            //Verify default message is shown
            wait.Until(ExpectedConditions.ElementExists((By)RejectCustomerMsg));
            Assert.IsTrue(driver.FindElement(RejectCustomerMsg).Displayed);
            Thread.Sleep(2000);
            //Click submit button
            wait.Until(ExpectedConditions.ElementExists((By)StatusSubmitBtn));
            driver.FindElement(StatusSubmitBtn).Click();
            Thread.Sleep(2000);
            driver.SwitchTo().DefaultContent();
            //Verify case summary page loads
            wait.Until(ExpectedConditions.ElementExists((By)CustomerInfoTitleOnCaseSummary));
            Assert.IsTrue(driver.FindElement(CustomerInfoTitleOnCaseSummary).Displayed);
            //Verify SLA empty
            wait.Until(ExpectedConditions.ElementExists((By)EmptySLAOnCaseSummary));
            Assert.IsTrue(driver.FindElement(EmptySLAOnCaseSummary).Displayed);
            Thread.Sleep(2000);
            //Click refresh button
            var Status = 0;
            try
            {
                if (driver.FindElements(JobStatusOnCaseSummary).Count() != 0)
                {
                    Console.WriteLine("Job status changed from in progress");
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                do
                {
                    driver.FindElement(RefreshButtonOnCaseDetails).Click();
                    Thread.Sleep(5000);
                    Status++;
                    if (driver.FindElements(JobStatusOnCaseSummary).Count() != 0)
                    {
                        break;
                    }
                    else if (Status == 10)
                    {
                        Console.WriteLine("Job status not updated from in progress");
                        Assert.Fail();
                    }
                } while (driver.FindElements(JobStatusOnCaseSummary).Count() == 0);
            }
            //Verify status updated to customer rejected
            wait.Until(ExpectedConditions.ElementExists((By)JobStatusOnCaseSummary));
            Assert.IsTrue(driver.FindElement(JobStatusOnCaseSummary).Displayed);
            Thread.Sleep(2000);
            //Select wakefield case from allocated case dropdown
            wait.Until(ExpectedConditions.ElementExists((By)AllocatedCaseForm));
            driver.FindElement(AllocatedCaseForm).Click();
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)AllocatedCaseDropdownWakefield));
            driver.FindElement(AllocatedCaseDropdownWakefield).Click();
            Thread.Sleep(2000);
            //Verify case details form loads
            wait.Until(ExpectedConditions.ElementExists((By)CaseDetailsForm));
            Assert.IsTrue(driver.FindElement(CaseDetailsForm).Displayed);
            Thread.Sleep(2000);
            //Verify last customer update shows rejected message
            wait.Until(ExpectedConditions.ElementExists((By)CaseDetailsRejectedUpdateMsg));
            Assert.IsTrue(driver.FindElement(CaseDetailsRejectedUpdateMsg).Displayed);
            Thread.Sleep(2000);
            //Verify status message shown on timeline
            wait.Until(ExpectedConditions.ElementExists((By)TimelineStatusClosed));
            Assert.IsTrue(driver.FindElement(TimelineStatusClosed).Displayed);
            Thread.Sleep(2000);
            //Click customer updates/history
            driver.FindElement(HistoryTabOnCustomer).Click();
            Thread.Sleep(2000);
            //Verify status updates shows the rejected status message
            wait.Until(ExpectedConditions.ElementExists((By)CustomerStatusOnHistoryTab));
            Assert.IsTrue(driver.FindElement(CustomerStatusOnHistoryTab).Displayed);
            Thread.Sleep(2000);
            //Click back to summary tab
            driver.FindElement(CaseDetailsSummaryTab).Click();
            Thread.Sleep(2000);
            //Click case form link on service details
            Assert.IsTrue(driver.FindElement(ServiceFormLink).Displayed);
            Thread.Sleep(2000);
            driver.FindElement(ServiceFormLink).Click();
            Thread.Sleep(2000);
            //Verify form loads
            wait.Until(ExpectedConditions.ElementExists((By)DogFoulingFormTitle));
            Assert.IsTrue(driver.FindElement(DogFoulingFormTitle).Displayed);
            Thread.Sleep(2000);
            //Verify message shows record is inactive
            wait.Until(ExpectedConditions.ElementExists((By)DogFoulingFormStatusInactive));
            Assert.IsTrue(driver.FindElement(DogFoulingFormStatusInactive).Displayed);
            Thread.Sleep(2000);
            //Click dashboards in LHN
            driver.FindElement(DashboardsLHN).Click();
            Thread.Sleep(2000);
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
            Thread.Sleep(5000);
            //Verify job status shows as cancelled
            wait.Until(ExpectedConditions.ElementExists((By)CaseHistoryCancelled));
            Assert.IsTrue(driver.FindElement(CaseHistoryCancelled).Displayed);
            Thread.Sleep(2000);
            //Click customer name
            wait.Until(ExpectedConditions.ElementExists((By)ManualAddressSearchResult));
            driver.FindElement(ManualAddressSearchResult).Click();
            Thread.Sleep(2000);
            driver.SwitchTo().DefaultContent();
            Thread.Sleep(2000);
            //Click history tab
            driver.FindElement(HistoryTabOnCustomer).Click();
            Thread.Sleep(2000);
            Actions action = new Actions(driver);
            action.SendKeys(Keys.PageDown).Build().Perform();
            var Cases = 0;
            try
            {
                if (driver.FindElements(ManualAddressOnCustomerHistory).Count() != 0)
                    Console.WriteLine("Cases present on customer history");
                {
                    do
                    {
                        //Click select all cases
                        wait.Until(ExpectedConditions.ElementExists((By)SelectAllCasesBtn));
                        Thread.Sleep(3000);
                        driver.FindElement(SelectAllCasesBtn).Click();
                        Thread.Sleep(2000);
                        //Click more options dots
                        wait.Until(ExpectedConditions.ElementExists((By)MoreOptionsDotsOnCustomerCases));
                        Thread.Sleep(2000);
                        driver.FindElement(MoreOptionsDotsOnCustomerCases).Click();
                        Thread.Sleep(2000);
                        //Click delete cases
                        wait.Until(ExpectedConditions.ElementExists((By)DeleteCasesFromMoreOptions));
                        Thread.Sleep(2000);
                        driver.FindElement(DeleteCasesFromMoreOptions).Click();
                        Thread.Sleep(2000);
                        //Click delete on the overlay
                        wait.Until(ExpectedConditions.ElementExists((By)DeleteCasesOverlayBtn));
                        Thread.Sleep(2000);
                        driver.FindElement(DeleteCasesOverlayBtn).Click();
                        Thread.Sleep(10000);
                        wait.Until(ExpectedConditions.ElementExists((By)CustomerCasesTitle));
                        Cases++;
                        if (driver.FindElements(OOANameOnCustomerHistory).Count() == 0)
                        {
                            Console.WriteLine("All cases removed");
                            break;
                        }
                    }
                    while (driver.FindElements(ManualAddressOnCustomerHistory).Count() != 0);
                }
            }
            catch (Exception)
            {
                if (Cases == 0)
                {
                    Console.WriteLine("No cases were added to customer history");
                    Assert.Fail();
                }
            }
        }

        public void AnonCustomerRejectCase()
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
            wait.Until(ExpectedConditions.ElementExists((By)Searchbox));
            Assert.IsTrue(driver.FindElement(Searchbox).Displayed);
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
            wait.Until(ExpectedConditions.ElementExists((By)FAQSearchServiceResult));
            Assert.IsTrue(driver.FindElement(FAQSearchServiceResult).Displayed);
            driver.FindElement(FAQSearchServiceResult).Click();
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
            //Select private land
            Actions actions = new Actions(driver);
            actions.SendKeys(Keys.PageDown).Build().Perform();
            Thread.Sleep(2000);
            driver.FindElement(DogFoulingLandType).Click();
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)DogFoulingLandPrivate));
            driver.FindElement(DogFoulingLandPrivate).Click();
            Thread.Sleep(2000);
            driver.FindElement(DogFoulingLandType).Click();
            Thread.Sleep(2000);
            //Click reject
            driver.SwitchTo().Frame("WebResource_allocatingpanel");
            wait.Until(ExpectedConditions.ElementExists((By)RejectBtn));
            Thread.Sleep(2000);
            driver.FindElement(RejectBtn).Click();
            Thread.Sleep(2000);
            //Select customer rejecting on dropdown
            wait.Until(ExpectedConditions.ElementExists((By)RejectReasonDropdown));
            driver.FindElement(RejectReasonDropdown).Click();
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)RejectReasonCustomerRejected));
            driver.FindElement(RejectReasonCustomerRejected).Click();
            Thread.Sleep(2000);
            //Verify default message is shown
            wait.Until(ExpectedConditions.ElementExists((By)RejectCustomerMsg));
            Assert.IsTrue(driver.FindElement(RejectCustomerMsg).Displayed);
            Thread.Sleep(2000);
            //Click submit button
            wait.Until(ExpectedConditions.ElementExists((By)StatusSubmitBtn));
            driver.FindElement(StatusSubmitBtn).Click();
            Thread.Sleep(2000);
            driver.SwitchTo().DefaultContent();
            //Verify case summary page loads
            wait.Until(ExpectedConditions.ElementExists((By)CustomerInfoTitleOnCaseSummary));
            Assert.IsTrue(driver.FindElement(CustomerInfoTitleOnCaseSummary).Displayed);
            //Verify SLA empty
            wait.Until(ExpectedConditions.ElementExists((By)EmptySLAOnCaseSummary));
            Assert.IsTrue(driver.FindElement(EmptySLAOnCaseSummary).Displayed);
            Thread.Sleep(2000);
            //Click refresh button
            var Status = 0;
            try
            {
                if (driver.FindElements(JobStatusOnCaseSummary).Count() != 0)
                {
                    Console.WriteLine("Job status changed from in progress");
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                do
                {
                    driver.FindElement(RefreshButtonOnCaseDetails).Click();
                    Thread.Sleep(5000);
                    Status++;
                    if (driver.FindElements(JobStatusOnCaseSummary).Count() != 0)
                    {
                        break;
                    }
                    else if (Status == 10)
                    {
                        Console.WriteLine("Job status not updated from in progress");
                        Assert.Fail();
                    }
                } while (driver.FindElements(JobStatusOnCaseSummary).Count() == 0);
            }
            //Verify status updated to customer rejected
            wait.Until(ExpectedConditions.ElementExists((By)JobStatusOnCaseSummary));
            Assert.IsTrue(driver.FindElement(JobStatusOnCaseSummary).Displayed);
            Thread.Sleep(2000);
            //Select wakefield case from allocated case dropdown
            wait.Until(ExpectedConditions.ElementExists((By)AllocatedCaseForm));
            driver.FindElement(AllocatedCaseForm).Click();
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)AllocatedCaseDropdownWakefield));
            driver.FindElement(AllocatedCaseDropdownWakefield).Click();
            Thread.Sleep(2000);
            //Verify case details form loads
            wait.Until(ExpectedConditions.ElementExists((By)CaseDetailsForm));
            Assert.IsTrue(driver.FindElement(CaseDetailsForm).Displayed);
            Thread.Sleep(2000);
            //Verify record status shows cancelled
            wait.Until(ExpectedConditions.ElementExists((By)RecordStatusCancelled));
            Assert.IsTrue(driver.FindElement(RecordStatusCancelled).Displayed);
            Thread.Sleep(2000);
            //Click customer updates/history
            driver.FindElement(HistoryTabOnCustomer).Click();
            Thread.Sleep(2000);
            //Verify status updates shows the rejected status message
            wait.Until(ExpectedConditions.ElementExists((By)CustomerStatusOnHistoryTab));
            Assert.IsTrue(driver.FindElement(CustomerStatusOnHistoryTab).Displayed);
            Thread.Sleep(2000);
            //Click back to summary tab
            driver.FindElement(CaseDetailsSummaryTab).Click();
            Thread.Sleep(2000);
            //Click case form link on service details
            Assert.IsTrue(driver.FindElement(ServiceFormLink).Displayed);
            Thread.Sleep(2000);
            driver.FindElement(ServiceFormLink).Click();
            Thread.Sleep(2000);
            //Verify form loads
            wait.Until(ExpectedConditions.ElementExists((By)DogFoulingFormTitle));
            Assert.IsTrue(driver.FindElement(DogFoulingFormTitle).Displayed);
            Thread.Sleep(2000);
            //Verify message shows record is inactive
            wait.Until(ExpectedConditions.ElementExists((By)DogFoulingFormStatusInactive));
            Assert.IsTrue(driver.FindElement(DogFoulingFormStatusInactive).Displayed);
        }

        public void UnknownAddressRejectCase()
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
            wait.Until(ExpectedConditions.ElementExists((By)AnonCustomerSearchDropdown));
            Assert.IsTrue(driver.FindElement(AnonCustomerSearchDropdown).Displayed);
            driver.FindElement(AnonCustomerSearchDropdown).Click();
            Thread.Sleep(2000);
            //Check result is shown under access channel after selecting from dropdown
            wait.Until(ExpectedConditions.ElementExists((By)AnonAddressSearchResult));
            Assert.IsTrue(driver.FindElement(AnonAddressSearchResult).Displayed);
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
            wait.Until(ExpectedConditions.ElementExists((By)FAQSearchServiceResult));
            Assert.IsTrue(driver.FindElement(FAQSearchServiceResult).Displayed);
            driver.FindElement(FAQSearchServiceResult).Click();
            Thread.Sleep(2000);
            //Verify customer name and service shown on the create new case overlay
            driver.SwitchTo().DefaultContent();
            wait.Until(ExpectedConditions.ElementExists((By)UnknownAddressOnNewCaseOverlay));
            Assert.IsTrue(driver.FindElement(UnknownAddressOnNewCaseOverlay).Displayed);
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
            //Select private land
            Actions actions = new Actions(driver);
            actions.SendKeys(Keys.PageDown).Build().Perform();
            Thread.Sleep(2000);
            driver.FindElement(DogFoulingLandType).Click();
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)DogFoulingLandPrivate));
            driver.FindElement(DogFoulingLandPrivate).Click();
            Thread.Sleep(2000);
            driver.FindElement(DogFoulingLandType).Click();
            Thread.Sleep(2000);
            //Click reject
            driver.SwitchTo().Frame("WebResource_allocatingpanel");
            wait.Until(ExpectedConditions.ElementExists((By)RejectBtn));
            Thread.Sleep(2000);
            driver.FindElement(RejectBtn).Click();
            Thread.Sleep(2000);
            //Select customer rejecting on dropdown
            wait.Until(ExpectedConditions.ElementExists((By)RejectReasonDropdown));
            driver.FindElement(RejectReasonDropdown).Click();
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)RejectReasonCustomerRejected));
            driver.FindElement(RejectReasonCustomerRejected).Click();
            Thread.Sleep(2000);
            //Verify default message is shown
            wait.Until(ExpectedConditions.ElementExists((By)RejectCustomerMsg));
            Assert.IsTrue(driver.FindElement(RejectCustomerMsg).Displayed);
            Thread.Sleep(2000);
            //Click submit button
            wait.Until(ExpectedConditions.ElementExists((By)StatusSubmitBtn));
            driver.FindElement(StatusSubmitBtn).Click();
            Thread.Sleep(2000);
            driver.SwitchTo().DefaultContent();
            //Verify case summary page loads
            wait.Until(ExpectedConditions.ElementExists((By)CustomerInfoTitleOnCaseSummary));
            Assert.IsTrue(driver.FindElement(CustomerInfoTitleOnCaseSummary).Displayed);
            //Verify SLA empty
            wait.Until(ExpectedConditions.ElementExists((By)EmptySLAOnCaseSummary));
            Assert.IsTrue(driver.FindElement(EmptySLAOnCaseSummary).Displayed);
            Thread.Sleep(2000);
            //Click refresh button
            var Status = 0;
            try
            {
                if (driver.FindElements(JobStatusOnCaseSummary).Count() != 0)
                {
                    Console.WriteLine("Job status changed from in progress");
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                do
                {
                    driver.FindElement(RefreshButtonOnCaseDetails).Click();
                    Thread.Sleep(5000);
                    Status++;
                    if (driver.FindElements(JobStatusOnCaseSummary).Count() != 0)
                    {
                        break;
                    }
                    else if (Status == 10)
                    {
                        Console.WriteLine("Job status not updated from in progress");
                        Assert.Fail();
                    }
                } while (driver.FindElements(JobStatusOnCaseSummary).Count() == 0);
            }
            //Verify status updated to customer rejected
            wait.Until(ExpectedConditions.ElementExists((By)JobStatusOnCaseSummary));
            Assert.IsTrue(driver.FindElement(JobStatusOnCaseSummary).Displayed);
            Thread.Sleep(2000);
            //Select wakefield case from allocated case dropdown
            wait.Until(ExpectedConditions.ElementExists((By)AllocatedCaseForm));
            driver.FindElement(AllocatedCaseForm).Click();
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)AllocatedCaseDropdownWakefield));
            driver.FindElement(AllocatedCaseDropdownWakefield).Click();
            Thread.Sleep(2000);
            //Verify case details form loads
            wait.Until(ExpectedConditions.ElementExists((By)CaseDetailsForm));
            Assert.IsTrue(driver.FindElement(CaseDetailsForm).Displayed);
            Thread.Sleep(2000);
            //Verify last customer update shows rejected message
            wait.Until(ExpectedConditions.ElementExists((By)CaseDetailsRejectedUpdateMsg));
            Assert.IsTrue(driver.FindElement(CaseDetailsRejectedUpdateMsg).Displayed);
            Thread.Sleep(2000);
            //Verify status message shown on timeline
            wait.Until(ExpectedConditions.ElementExists((By)TimelineStatusClosed));
            Assert.IsTrue(driver.FindElement(TimelineStatusClosed).Displayed);
            Thread.Sleep(2000);
            //Click customer updates/history
            driver.FindElement(HistoryTabOnCustomer).Click();
            Thread.Sleep(2000);
            //Verify status updates shows the rejected status message
            wait.Until(ExpectedConditions.ElementExists((By)CustomerStatusOnHistoryTab));
            Assert.IsTrue(driver.FindElement(CustomerStatusOnHistoryTab).Displayed);
            Thread.Sleep(2000);
            //Click back to summary tab
            driver.FindElement(CaseDetailsSummaryTab).Click();
            Thread.Sleep(2000);
            //Click case form link on service details
            Assert.IsTrue(driver.FindElement(ServiceFormLink).Displayed);
            Thread.Sleep(2000);
            driver.FindElement(ServiceFormLink).Click();
            Thread.Sleep(2000);
            //Verify form loads
            wait.Until(ExpectedConditions.ElementExists((By)DogFoulingFormTitle));
            Assert.IsTrue(driver.FindElement(DogFoulingFormTitle).Displayed);
            Thread.Sleep(2000);
            //Verify message shows record is inactive
            wait.Until(ExpectedConditions.ElementExists((By)DogFoulingFormStatusInactive));
            Assert.IsTrue(driver.FindElement(DogFoulingFormStatusInactive).Displayed);
            Thread.Sleep(2000);
            //Click dashboards in LHN
            driver.FindElement(DashboardsLHN).Click();
            Thread.Sleep(2000);
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
            wait.Until(ExpectedConditions.ElementExists((By)AnonCustomerSearchDropdown));
            Assert.IsTrue(driver.FindElement(AnonCustomerSearchDropdown).Displayed);
            driver.FindElement(AnonCustomerSearchDropdown).Click();
            Thread.Sleep(2000);
            //Check result is shown under access channel after selecting from dropdown
            wait.Until(ExpectedConditions.ElementExists((By)AnonAddressSearchResult));
            Assert.IsTrue(driver.FindElement(AnonAddressSearchResult).Displayed);
            Thread.Sleep(5000);
            //Verify job status shows as cancelled
            wait.Until(ExpectedConditions.ElementExists((By)CaseHistoryCancelled));
            Assert.IsTrue(driver.FindElement(CaseHistoryCancelled).Displayed);
            Thread.Sleep(2000);
            //Click customer name
            driver.FindElement(AnonAddressSearchResult).Click();
            Thread.Sleep(2000);
            driver.SwitchTo().DefaultContent();
            Thread.Sleep(2000);
            //Click history tab
            driver.FindElement(HistoryTabOnCustomer).Click();
            Thread.Sleep(2000);
            Actions action = new Actions(driver);
            action.SendKeys(Keys.PageDown).Build().Perform();
            var Cases = 0;
            try
            {
                if (driver.FindElements(AnonOnCustomerHistory).Count() != 0)
                    Console.WriteLine("Cases present on customer history");
                {
                    do
                    {
                        //Click select all cases
                        wait.Until(ExpectedConditions.ElementExists((By)SelectAllCasesBtn));
                        Thread.Sleep(3000);
                        driver.FindElement(SelectAllCasesBtn).Click();
                        Thread.Sleep(2000);
                        //Click more options dots
                        wait.Until(ExpectedConditions.ElementExists((By)MoreOptionsDotsOnCustomerCases));
                        Thread.Sleep(2000);
                        driver.FindElement(MoreOptionsDotsOnCustomerCases).Click();
                        Thread.Sleep(2000);
                        //Click delete cases
                        wait.Until(ExpectedConditions.ElementExists((By)DeleteCasesFromMoreOptions));
                        Thread.Sleep(2000);
                        driver.FindElement(DeleteCasesFromMoreOptions).Click();
                        Thread.Sleep(2000);
                        //Click delete on the overlay
                        wait.Until(ExpectedConditions.ElementExists((By)DeleteCasesOverlayBtn));
                        Thread.Sleep(2000);
                        driver.FindElement(DeleteCasesOverlayBtn).Click();
                        Thread.Sleep(10000);
                        wait.Until(ExpectedConditions.ElementExists((By)CustomerCasesTitle));
                        Cases++;
                        if (driver.FindElements(AnonOnCustomerHistory).Count() == 0)
                        {
                            Console.WriteLine("All cases removed");
                            break;
                        }
                    }
                    while (driver.FindElements(AnonOnCustomerHistory).Count() != 0);
                }
            }
            catch (Exception)
            {
                if (Cases == 0)
                {
                    Console.WriteLine("No cases were added to customer history");
                    Assert.Fail();
                }
            }
        }

        public void CustomerRejectCaseOnBehalfOf()
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
            wait.Until(ExpectedConditions.ElementExists((By)Searchbox));
            Assert.IsTrue(driver.FindElement(Searchbox).Displayed);
            //Enter fullname in search
            driver.FindElement(Searchbox).Click();
            driver.FindElement(Searchbox).SendKeys("Gary Moore");
            driver.FindElement(Searchbox).SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            //Check result shows on the dropdown
            wait.Until(ExpectedConditions.ElementExists((By)ExistingCustomerSearchDropdown));
            driver.FindElement(OnBehalfOfInDropdown).Click();
            driver.FindElement(ExistingCustomerSearchDropdown).Click();
            Thread.Sleep(2000);
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
            wait.Until(ExpectedConditions.ElementExists((By)FAQSearchServiceResult));
            Assert.IsTrue(driver.FindElement(FAQSearchServiceResult).Displayed);
            driver.FindElement(FAQSearchServiceResult).Click();
            Thread.Sleep(2000);
            //Verify customer name and service shown on the create new case overlay
            driver.SwitchTo().DefaultContent();
            wait.Until(ExpectedConditions.ElementExists((By)TestNameOnNewCaseOverlay));
            Assert.IsTrue(driver.FindElement(TestNameOnNewCaseOverlay).Displayed);
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
            //Select private land
            Actions actions = new Actions(driver);
            actions.SendKeys(Keys.PageDown).Build().Perform();
            Thread.Sleep(2000);
            driver.FindElement(DogFoulingLandType).Click();
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)DogFoulingLandPrivate));
            driver.FindElement(DogFoulingLandPrivate).Click();
            Thread.Sleep(2000);
            driver.FindElement(DogFoulingLandType).Click();
            Thread.Sleep(2000);
            //Click reject
            driver.SwitchTo().Frame("WebResource_allocatingpanel");
            wait.Until(ExpectedConditions.ElementExists((By)RejectBtn));
            Thread.Sleep(2000);
            driver.FindElement(RejectBtn).Click();
            Thread.Sleep(2000);
            //Select customer rejecting on dropdown
            wait.Until(ExpectedConditions.ElementExists((By)RejectReasonDropdown));
            driver.FindElement(RejectReasonDropdown).Click();
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)RejectReasonCustomerRejected));
            driver.FindElement(RejectReasonCustomerRejected).Click();
            Thread.Sleep(2000);
            //Verify default message is shown
            wait.Until(ExpectedConditions.ElementExists((By)RejectCustomerMsg));
            Assert.IsTrue(driver.FindElement(RejectCustomerMsg).Displayed);
            Thread.Sleep(2000);
            //Click submit button
            wait.Until(ExpectedConditions.ElementExists((By)StatusSubmitBtn));
            driver.FindElement(StatusSubmitBtn).Click();
            Thread.Sleep(2000);
            driver.SwitchTo().DefaultContent();
            //Verify case summary page loads
            wait.Until(ExpectedConditions.ElementExists((By)CustomerInfoTitleOnCaseSummary));
            Assert.IsTrue(driver.FindElement(CustomerInfoTitleOnCaseSummary).Displayed);
            //Verify SLA empty
            wait.Until(ExpectedConditions.ElementExists((By)EmptySLAOnCaseSummary));
            Assert.IsTrue(driver.FindElement(EmptySLAOnCaseSummary).Displayed);
            Thread.Sleep(2000);
            //Click refresh button
            var Status = 0;
            try
            {
                if (driver.FindElements(JobStatusOnCaseSummary).Count() != 0)
                {
                    Console.WriteLine("Job status changed from in progress");
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                do
                {
                    driver.FindElement(RefreshButtonOnCaseDetails).Click();
                    Thread.Sleep(5000);
                    Status++;
                    if (driver.FindElements(JobStatusOnCaseSummary).Count() != 0)
                    {
                        break;
                    }
                    else if (Status == 10)
                    {
                        Console.WriteLine("Job status not updated from in progress");
                        Assert.Fail();
                    }
                } while (driver.FindElements(JobStatusOnCaseSummary).Count() == 0);
            }
            //Verify status updated to customer rejected
            wait.Until(ExpectedConditions.ElementExists((By)JobStatusOnCaseSummary));
            Assert.IsTrue(driver.FindElement(JobStatusOnCaseSummary).Displayed);
            Thread.Sleep(2000);
            //Select wakefield case from allocated case dropdown
            wait.Until(ExpectedConditions.ElementExists((By)AllocatedCaseForm));
            driver.FindElement(AllocatedCaseForm).Click();
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)AllocatedCaseDropdownWakefield));
            driver.FindElement(AllocatedCaseDropdownWakefield).Click();
            Thread.Sleep(2000);
            //Verify case details form loads
            wait.Until(ExpectedConditions.ElementExists((By)CaseDetailsForm));
            Assert.IsTrue(driver.FindElement(CaseDetailsForm).Displayed);
            Thread.Sleep(2000);
            //Verify last customer update shows rejected message
            wait.Until(ExpectedConditions.ElementExists((By)CaseDetailsRejectedUpdateMsg));
            Assert.IsTrue(driver.FindElement(CaseDetailsRejectedUpdateMsg).Displayed);
            Thread.Sleep(2000);
            //Verify status message shown on timeline
            wait.Until(ExpectedConditions.ElementExists((By)TimelineStatusClosed));
            Assert.IsTrue(driver.FindElement(TimelineStatusClosed).Displayed);
            Thread.Sleep(2000);
            //Click customer updates/history
            driver.FindElement(HistoryTabOnCustomer).Click();
            Thread.Sleep(2000);
            //Verify customer and reporter names are displayed
            wait.Until(ExpectedConditions.ElementExists((By)CustomerNameOnCustomerCases));
            Assert.IsTrue(driver.FindElement(CustomerNameOnCustomerCases).Displayed);
            wait.Until(ExpectedConditions.ElementExists((By)ReporterNameOnCustomerCases));
            Assert.IsTrue(driver.FindElement(ReporterNameOnCustomerCases).Displayed);
            //Verify status updates shows the rejected status message
            wait.Until(ExpectedConditions.ElementExists((By)CustomerStatusOnHistoryTab));
            Assert.IsTrue(driver.FindElement(CustomerStatusOnHistoryTab).Displayed);
            Thread.Sleep(2000);
            //Click back to summary tab
            driver.FindElement(CaseDetailsSummaryTab).Click();
            Thread.Sleep(2000);
            //Click case form link on service details
            Assert.IsTrue(driver.FindElement(ServiceFormLink).Displayed);
            Thread.Sleep(2000);
            driver.FindElement(ServiceFormLink).Click();
            Thread.Sleep(2000);
            //Verify form loads
            wait.Until(ExpectedConditions.ElementExists((By)DogFoulingFormTitle));
            Assert.IsTrue(driver.FindElement(DogFoulingFormTitle).Displayed);
            Thread.Sleep(2000);
            //Verify message shows record is inactive
            wait.Until(ExpectedConditions.ElementExists((By)DogFoulingFormStatusInactive));
            Assert.IsTrue(driver.FindElement(DogFoulingFormStatusInactive).Displayed);
            Thread.Sleep(2000);
            //Click dashboards in LHN
            driver.FindElement(DashboardsLHN).Click();
            Thread.Sleep(2000);
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
            driver.FindElement(Searchbox).SendKeys("Gary Test");
            driver.FindElement(Searchbox).SendKeys(Keys.Enter);
            wait.Until(ExpectedConditions.ElementExists((By)GaryTestInDropdown));
            Assert.IsTrue(driver.FindElement(GaryTestInDropdown).Displayed);
            driver.FindElement(GaryTestInDropdown).Click();
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)GaryTestInAccessChannel));
            Assert.IsTrue(driver.FindElement(GaryTestInAccessChannel).Displayed);
            Thread.Sleep(2000);
            //Check result is shown under access channel after selecting from dropdown
            wait.Until(ExpectedConditions.ElementExists((By)TestUserSearchResult));
            Assert.IsTrue(driver.FindElement(TestUserSearchResult).Displayed);
            Thread.Sleep(5000);
            //Verify job status shows as cancelled
            wait.Until(ExpectedConditions.ElementExists((By)CaseHistoryCancelled));
            Assert.IsTrue(driver.FindElement(CaseHistoryCancelled).Displayed);
            Thread.Sleep(2000);
            //Verify on behalf of asterisk is shown
            wait.Until(ExpectedConditions.ElementExists((By)CaseHistoryAsterisk));
            Assert.IsTrue(driver.FindElement(CaseHistoryAsterisk).Displayed);
            //Click customer name
            driver.FindElement(TestUserSearchResult).Click();
            Thread.Sleep(2000);
            driver.SwitchTo().DefaultContent();
            Thread.Sleep(2000);
            //Click history tab
            wait.Until(ExpectedConditions.ElementExists((By)HistoryTabOnCustomer));
            driver.FindElement(HistoryTabOnCustomer).Click();
            Thread.Sleep(2000);
            try
            {
                do
                {
                    //Click select all cases
                    wait.Until(ExpectedConditions.ElementExists((By)SelectAllCasesBtn));
                    Thread.Sleep(3000);
                    driver.FindElement(SelectAllCasesBtn).Click();
                    Thread.Sleep(2000);
                    //Click more options dots
                    wait.Until(ExpectedConditions.ElementExists((By)MoreOptionsDotsOnCustomerCases));
                    Thread.Sleep(2000);
                    driver.FindElement(MoreOptionsDotsOnCustomerCases).Click();
                    Thread.Sleep(2000);
                    //Click delete cases
                    wait.Until(ExpectedConditions.ElementExists((By)DeleteCasesFromMoreOptions));
                    Thread.Sleep(2000);
                    driver.FindElement(DeleteCasesFromMoreOptions).Click();
                    Thread.Sleep(2000);
                    //Click delete on the overlay
                    wait.Until(ExpectedConditions.ElementExists((By)DeleteCasesOverlayBtn));
                    Thread.Sleep(2000);
                    driver.FindElement(DeleteCasesOverlayBtn).Click();
                    Thread.Sleep(10000);
                    wait.Until(ExpectedConditions.ElementExists((By)CustomerCasesTitle));
                }
                while (driver.FindElement(TestNameOnCustomerHistory).Displayed);
            }
            catch (Exception)
            {
                Console.WriteLine("All cases removed from history screen");
            }
            //Verify cases deleted
            var Cases = 0;
            try
            {
                WebElement cases = (WebElement)driver.FindElement(TestNameOnCustomerHistory);
                if (cases.Displayed)
                {
                    Cases = 1;
                    Assert.Fail();
                }
            }
            catch (Exception)
            {
                if (Cases > 0)
                {
                    Console.WriteLine("Cases not removed");
                }
                else
                {
                    Console.WriteLine("Cases removed");
                }
            }
        }

        public void BusinessRejectCase()
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
            driver.FindElement(Searchbox).SendKeys("Test Cafe");
            driver.FindElement(Searchbox).SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            //Check result shows on the dropdown
            wait.Until(ExpectedConditions.ElementExists((By)ExistingBusinessSearchDropdown));
            Assert.IsTrue(driver.FindElement(ExistingBusinessSearchDropdown).Displayed);
            driver.FindElement(ExistingBusinessSearchDropdown).Click();
            Thread.Sleep(2000);
            //Check result is shown under access channel after selecting from dropdown
            wait.Until(ExpectedConditions.ElementExists((By)ExistingBusinessSearchResult));
            Assert.IsTrue(driver.FindElement(ExistingBusinessSearchResult).Displayed);
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
            wait.Until(ExpectedConditions.ElementExists((By)FAQSearchServiceResult));
            Assert.IsTrue(driver.FindElement(FAQSearchServiceResult).Displayed);
            driver.FindElement(FAQSearchServiceResult).Click();
            Thread.Sleep(2000);
            //Verify customer name and service shown on the create new case overlay
            driver.SwitchTo().DefaultContent();
            wait.Until(ExpectedConditions.ElementExists((By)BusinessNameOnNewCaseOverlay));
            Assert.IsTrue(driver.FindElement(BusinessNameOnNewCaseOverlay).Displayed);
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
            //Select private land
            Actions actions = new Actions(driver);
            actions.SendKeys(Keys.PageDown).Build().Perform();
            Thread.Sleep(2000);
            driver.FindElement(DogFoulingLandType).Click();
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)DogFoulingLandPrivate));
            driver.FindElement(DogFoulingLandPrivate).Click();
            Thread.Sleep(2000);
            driver.FindElement(DogFoulingLandType).Click();
            Thread.Sleep(2000);
            //Click reject
            driver.SwitchTo().Frame("WebResource_allocatingpanel");
            wait.Until(ExpectedConditions.ElementExists((By)RejectBtn));
            Thread.Sleep(2000);
            driver.FindElement(RejectBtn).Click();
            Thread.Sleep(2000);
            //Select customer rejecting on dropdown
            wait.Until(ExpectedConditions.ElementExists((By)RejectReasonDropdown));
            driver.FindElement(RejectReasonDropdown).Click();
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)RejectReasonCustomerRejected));
            driver.FindElement(RejectReasonCustomerRejected).Click();
            Thread.Sleep(2000);
            //Verify default message is shown
            wait.Until(ExpectedConditions.ElementExists((By)RejectCustomerMsg));
            Assert.IsTrue(driver.FindElement(RejectCustomerMsg).Displayed);
            Thread.Sleep(2000);
            //Click submit button
            wait.Until(ExpectedConditions.ElementExists((By)StatusSubmitBtn));
            driver.FindElement(StatusSubmitBtn).Click();
            Thread.Sleep(2000);
            driver.SwitchTo().DefaultContent();
            //Verify case summary page loads
            wait.Until(ExpectedConditions.ElementExists((By)CustomerInfoTitleOnCaseSummary));
            Assert.IsTrue(driver.FindElement(CustomerInfoTitleOnCaseSummary).Displayed);
            //Verify SLA empty
            wait.Until(ExpectedConditions.ElementExists((By)EmptySLAOnCaseSummary));
            Assert.IsTrue(driver.FindElement(EmptySLAOnCaseSummary).Displayed);
            Thread.Sleep(2000);
            //Click refresh button
            var Status = 0;
            try
            {
                if (driver.FindElements(JobStatusOnCaseSummary).Count() != 0)
                {
                    Console.WriteLine("Job status changed from in progress");
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                do
                {
                    driver.FindElement(RefreshButtonOnCaseDetails).Click();
                    Thread.Sleep(5000);
                    Status++;
                    if (driver.FindElements(JobStatusOnCaseSummary).Count() != 0)
                    {
                        break;
                    }
                    else if (Status == 10)
                    {
                        Console.WriteLine("Job status not updated from in progress");
                        Assert.Fail();
                    }
                } while (driver.FindElements(JobStatusOnCaseSummary).Count() == 0);
            }
            //Verify status updated to customer rejected
            wait.Until(ExpectedConditions.ElementExists((By)JobStatusOnCaseSummary));
            Assert.IsTrue(driver.FindElement(JobStatusOnCaseSummary).Displayed);
            Thread.Sleep(2000);
            //Select wakefield case from allocated case dropdown
            wait.Until(ExpectedConditions.ElementExists((By)AllocatedCaseForm));
            driver.FindElement(AllocatedCaseForm).Click();
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)AllocatedCaseDropdownWakefield));
            driver.FindElement(AllocatedCaseDropdownWakefield).Click();
            Thread.Sleep(2000);
            //Verify case details form loads
            wait.Until(ExpectedConditions.ElementExists((By)CaseDetailsForm));
            Assert.IsTrue(driver.FindElement(CaseDetailsForm).Displayed);
            Thread.Sleep(2000);
            //Verify last customer update shows rejected message
            wait.Until(ExpectedConditions.ElementExists((By)CaseDetailsRejectedUpdateMsg));
            Assert.IsTrue(driver.FindElement(CaseDetailsRejectedUpdateMsg).Displayed);
            Thread.Sleep(2000);
            //Verify status message shown on timeline
            wait.Until(ExpectedConditions.ElementExists((By)TimelineStatusClosed));
            Assert.IsTrue(driver.FindElement(TimelineStatusClosed).Displayed);
            Thread.Sleep(2000);
            //Click customer updates/history
            driver.FindElement(HistoryTabOnCustomer).Click();
            Thread.Sleep(2000);
            //Verify status updates shows the rejected status message
            wait.Until(ExpectedConditions.ElementExists((By)CustomerStatusOnHistoryTab));
            Assert.IsTrue(driver.FindElement(CustomerStatusOnHistoryTab).Displayed);
            Thread.Sleep(2000);
            //Click back to summary tab
            driver.FindElement(CaseDetailsSummaryTab).Click();
            Thread.Sleep(2000);
            //Click case form link on service details
            Assert.IsTrue(driver.FindElement(ServiceFormLink).Displayed);
            Thread.Sleep(2000);
            driver.FindElement(ServiceFormLink).Click();
            Thread.Sleep(2000);
            //Verify form loads
            wait.Until(ExpectedConditions.ElementExists((By)DogFoulingFormTitle));
            Assert.IsTrue(driver.FindElement(DogFoulingFormTitle).Displayed);
            Thread.Sleep(2000);
            //Verify message shows record is inactive
            wait.Until(ExpectedConditions.ElementExists((By)DogFoulingFormStatusInactive));
            Assert.IsTrue(driver.FindElement(DogFoulingFormStatusInactive).Displayed);
            Thread.Sleep(2000);
            //Click dashboards in LHN
            driver.FindElement(DashboardsLHN).Click();
            Thread.Sleep(2000);
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
            driver.FindElement(Searchbox).SendKeys("Test Cafe");
            driver.FindElement(Searchbox).SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            //Check result shows on the dropdown
            wait.Until(ExpectedConditions.ElementExists((By)ExistingBusinessSearchDropdown));
            Assert.IsTrue(driver.FindElement(ExistingBusinessSearchDropdown).Displayed);
            driver.FindElement(ExistingBusinessSearchDropdown).Click();
            Thread.Sleep(2000);
            //Check result is shown under access channel after selecting from dropdown
            wait.Until(ExpectedConditions.ElementExists((By)ExistingBusinessSearchResult));
            Assert.IsTrue(driver.FindElement(ExistingBusinessSearchResult).Displayed);
            Thread.Sleep(5000);
            //Verify job status shows as cancelled
            wait.Until(ExpectedConditions.ElementExists((By)CaseHistoryCancelled));
            Assert.IsTrue(driver.FindElement(CaseHistoryCancelled).Displayed);
            Thread.Sleep(2000);
            //Click customer name
            driver.FindElement(ExistingBusinessSearchResult).Click();
            Thread.Sleep(2000);
            driver.SwitchTo().DefaultContent();
            Thread.Sleep(2000);
            //Click history tab
            driver.FindElement(HistoryTabOnCustomer).Click();
            Thread.Sleep(2000);
            Actions action = new Actions(driver);
            action.SendKeys(Keys.PageDown).Build().Perform();
            var Cases = 0;
            try
            {
                if (driver.FindElements(BusinessNameOnCustomerHistory).Count() != 0)
                    Console.WriteLine("Cases present on customer history");
                {
                    do
                    {
                        //Click select all cases
                        wait.Until(ExpectedConditions.ElementExists((By)SelectAllCasesBtn));
                        Thread.Sleep(3000);
                        driver.FindElement(SelectAllCasesBtn).Click();
                        Thread.Sleep(2000);
                        //Click more options dots
                        wait.Until(ExpectedConditions.ElementExists((By)MoreOptionsDotsOnCustomerCases));
                        Thread.Sleep(2000);
                        driver.FindElement(MoreOptionsDotsOnCustomerCases).Click();
                        Thread.Sleep(2000);
                        //Click delete cases
                        wait.Until(ExpectedConditions.ElementExists((By)DeleteCasesFromMoreOptions));
                        Thread.Sleep(2000);
                        driver.FindElement(DeleteCasesFromMoreOptions).Click();
                        Thread.Sleep(2000);
                        //Click delete on the overlay
                        wait.Until(ExpectedConditions.ElementExists((By)DeleteCasesOverlayBtn));
                        Thread.Sleep(2000);
                        driver.FindElement(DeleteCasesOverlayBtn).Click();
                        Thread.Sleep(10000);
                        wait.Until(ExpectedConditions.ElementExists((By)CustomerCasesTitle));
                        Cases++;
                        if (driver.FindElements(BusinessNameOnCustomerHistory).Count() == 0)
                        {
                            Console.WriteLine("All cases removed");
                            break;
                        }
                    }
                    while (driver.FindElements(BusinessNameOnCustomerHistory).Count() != 0);
                }
            }
            catch (Exception)
            {
                if (Cases == 0)
                {
                    Console.WriteLine("No cases were added to customer history");
                    Assert.Fail();
                }
            }
        }

        public void UABusinessRejectCase()
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
            driver.FindElement(Searchbox).SendKeys("Unknown Business");
            driver.FindElement(Searchbox).SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            //Check result shows on the dropdown
            wait.Until(ExpectedConditions.ElementExists((By)UABusinessSearchDropdown));
            Assert.IsTrue(driver.FindElement(UABusinessSearchDropdown).Displayed);
            driver.FindElement(UABusinessSearchDropdown).Click();
            Thread.Sleep(2000);
            //Check result is shown under access channel after selecting from dropdown
            wait.Until(ExpectedConditions.ElementExists((By)UABusinessSearchResult));
            Assert.IsTrue(driver.FindElement(UABusinessSearchResult).Displayed);
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
            wait.Until(ExpectedConditions.ElementExists((By)FAQSearchServiceResult));
            Assert.IsTrue(driver.FindElement(FAQSearchServiceResult).Displayed);
            driver.FindElement(FAQSearchServiceResult).Click();
            Thread.Sleep(2000);
            //Verify customer name and service shown on the create new case overlay
            driver.SwitchTo().DefaultContent();
            wait.Until(ExpectedConditions.ElementExists((By)UABusinessOnNewCaseOverlay));
            Assert.IsTrue(driver.FindElement(UABusinessOnNewCaseOverlay).Displayed);
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
            //Select private land
            Actions actions = new Actions(driver);
            actions.SendKeys(Keys.PageDown).Build().Perform();
            Thread.Sleep(2000);
            driver.FindElement(DogFoulingLandType).Click();
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)DogFoulingLandPrivate));
            driver.FindElement(DogFoulingLandPrivate).Click();
            Thread.Sleep(2000);
            driver.FindElement(DogFoulingLandType).Click();
            Thread.Sleep(2000);
            //Click reject
            driver.SwitchTo().Frame("WebResource_allocatingpanel");
            wait.Until(ExpectedConditions.ElementExists((By)RejectBtn));
            Thread.Sleep(2000);
            driver.FindElement(RejectBtn).Click();
            Thread.Sleep(2000);
            //Select customer rejecting on dropdown
            wait.Until(ExpectedConditions.ElementExists((By)RejectReasonDropdown));
            driver.FindElement(RejectReasonDropdown).Click();
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)RejectReasonCustomerRejected));
            driver.FindElement(RejectReasonCustomerRejected).Click();
            Thread.Sleep(2000);
            //Verify default message is shown
            wait.Until(ExpectedConditions.ElementExists((By)RejectCustomerMsg));
            Assert.IsTrue(driver.FindElement(RejectCustomerMsg).Displayed);
            Thread.Sleep(2000);
            //Click submit button
            wait.Until(ExpectedConditions.ElementExists((By)StatusSubmitBtn));
            driver.FindElement(StatusSubmitBtn).Click();
            Thread.Sleep(2000);
            driver.SwitchTo().DefaultContent();
            //Verify case summary page loads
            wait.Until(ExpectedConditions.ElementExists((By)CustomerInfoTitleOnCaseSummary));
            Assert.IsTrue(driver.FindElement(CustomerInfoTitleOnCaseSummary).Displayed);
            //Verify SLA empty
            wait.Until(ExpectedConditions.ElementExists((By)EmptySLAOnCaseSummary));
            Assert.IsTrue(driver.FindElement(EmptySLAOnCaseSummary).Displayed);
            Thread.Sleep(2000);
            //Click refresh button
            var Status = 0;
            try
            {
                if (driver.FindElements(JobStatusOnCaseSummary).Count() != 0)
                {
                    Console.WriteLine("Job status changed from in progress");
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                do
                {
                    driver.FindElement(RefreshButtonOnCaseDetails).Click();
                    Thread.Sleep(5000);
                    Status++;
                    if (driver.FindElements(JobStatusOnCaseSummary).Count() != 0)
                    {
                        break;
                    }
                    else if (Status == 10)
                    {
                        Console.WriteLine("Job status not updated from in progress");
                        Assert.Fail();
                    }
                } while (driver.FindElements(JobStatusOnCaseSummary).Count() == 0);
            }
            //Verify status updated to customer rejected
            wait.Until(ExpectedConditions.ElementExists((By)JobStatusOnCaseSummary));
            Assert.IsTrue(driver.FindElement(JobStatusOnCaseSummary).Displayed);
            Thread.Sleep(2000);
            //Select wakefield case from allocated case dropdown
            wait.Until(ExpectedConditions.ElementExists((By)AllocatedCaseForm));
            driver.FindElement(AllocatedCaseForm).Click();
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)AllocatedCaseDropdownWakefield));
            driver.FindElement(AllocatedCaseDropdownWakefield).Click();
            Thread.Sleep(2000);
            //Verify case details form loads
            wait.Until(ExpectedConditions.ElementExists((By)CaseDetailsForm));
            Assert.IsTrue(driver.FindElement(CaseDetailsForm).Displayed);
            Thread.Sleep(2000);
            //Verify last customer update shows rejected message
            wait.Until(ExpectedConditions.ElementExists((By)CaseDetailsRejectedUpdateMsg));
            Assert.IsTrue(driver.FindElement(CaseDetailsRejectedUpdateMsg).Displayed);
            Thread.Sleep(2000);
            //Verify status message shown on timeline
            wait.Until(ExpectedConditions.ElementExists((By)TimelineStatusClosed));
            Assert.IsTrue(driver.FindElement(TimelineStatusClosed).Displayed);
            Thread.Sleep(2000);
            //Click customer updates/history
            driver.FindElement(HistoryTabOnCustomer).Click();
            Thread.Sleep(2000);
            //Verify status updates shows the rejected status message
            wait.Until(ExpectedConditions.ElementExists((By)CustomerStatusOnHistoryTab));
            Assert.IsTrue(driver.FindElement(CustomerStatusOnHistoryTab).Displayed);
            Thread.Sleep(2000);
            //Click back to summary tab
            driver.FindElement(CaseDetailsSummaryTab).Click();
            Thread.Sleep(2000);
            //Click case form link on service details
            Assert.IsTrue(driver.FindElement(ServiceFormLink).Displayed);
            Thread.Sleep(2000);
            driver.FindElement(ServiceFormLink).Click();
            Thread.Sleep(2000);
            //Verify form loads
            wait.Until(ExpectedConditions.ElementExists((By)DogFoulingFormTitle));
            Assert.IsTrue(driver.FindElement(DogFoulingFormTitle).Displayed);
            Thread.Sleep(2000);
            //Verify message shows record is inactive
            wait.Until(ExpectedConditions.ElementExists((By)DogFoulingFormStatusInactive));
            Assert.IsTrue(driver.FindElement(DogFoulingFormStatusInactive).Displayed);
            Thread.Sleep(2000);
            //Click dashboards in LHN
            driver.FindElement(DashboardsLHN).Click();
            Thread.Sleep(2000);
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
            driver.FindElement(Searchbox).SendKeys("Unknown Business");
            driver.FindElement(Searchbox).SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            //Check result shows on the dropdown
            wait.Until(ExpectedConditions.ElementExists((By)UABusinessSearchDropdown));
            Assert.IsTrue(driver.FindElement(UABusinessSearchDropdown).Displayed);
            driver.FindElement(UABusinessSearchDropdown).Click();
            Thread.Sleep(2000);
            //Check result is shown under access channel after selecting from dropdown
            wait.Until(ExpectedConditions.ElementExists((By)UABusinessSearchResult));
            Assert.IsTrue(driver.FindElement(UABusinessSearchResult).Displayed);
            Thread.Sleep(5000);
            //Verify job status shows as cancelled
            wait.Until(ExpectedConditions.ElementExists((By)CaseHistoryCancelled));
            Assert.IsTrue(driver.FindElement(CaseHistoryCancelled).Displayed);
            Thread.Sleep(2000);
            //Click customer name
            driver.FindElement(UABusinessSearchResult).Click();
            Thread.Sleep(2000);
            driver.SwitchTo().DefaultContent();
            Thread.Sleep(2000);
            //Click history tab
            driver.FindElement(HistoryTabOnCustomer).Click();
            Thread.Sleep(2000);
            Actions action = new Actions(driver);
            action.SendKeys(Keys.PageDown).Build().Perform();
            var Cases = 0;
            try
            {
                if (driver.FindElements(UABusinessOnCustomerHistory).Count() != 0)
                    Console.WriteLine("Cases present on customer history");
                {
                    do
                    {
                        //Click select all cases
                        wait.Until(ExpectedConditions.ElementExists((By)SelectAllCasesBtn));
                        Thread.Sleep(3000);
                        driver.FindElement(SelectAllCasesBtn).Click();
                        Thread.Sleep(2000);
                        //Click more options dots
                        wait.Until(ExpectedConditions.ElementExists((By)MoreOptionsDotsOnCustomerCases));
                        Thread.Sleep(2000);
                        driver.FindElement(MoreOptionsDotsOnCustomerCases).Click();
                        Thread.Sleep(2000);
                        //Click delete cases
                        wait.Until(ExpectedConditions.ElementExists((By)DeleteCasesFromMoreOptions));
                        Thread.Sleep(2000);
                        driver.FindElement(DeleteCasesFromMoreOptions).Click();
                        Thread.Sleep(2000);
                        //Click delete on the overlay
                        wait.Until(ExpectedConditions.ElementExists((By)DeleteCasesOverlayBtn));
                        Thread.Sleep(2000);
                        driver.FindElement(DeleteCasesOverlayBtn).Click();
                        Thread.Sleep(10000);
                        wait.Until(ExpectedConditions.ElementExists((By)CustomerCasesTitle));
                        Cases++;
                        if (driver.FindElements(UABusinessOnCustomerHistory).Count() == 0)
                        {
                            Console.WriteLine("All cases removed");
                            break;
                        }
                    }
                    while (driver.FindElements(UABusinessOnCustomerHistory).Count() != 0);
                }
            }
            catch (Exception)
            {
                if (Cases == 0)
                {
                    Console.WriteLine("No cases were added to customer history");
                    Assert.Fail();
                }
            }
        }

        public void ImmediatelyResolveCase()
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
            driver.FindElement(Searchbox).SendKeys("Gary Moore");
            driver.FindElement(Searchbox).SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            //Check result shows on the dropdown
            wait.Until(ExpectedConditions.ElementExists((By)ExistingCustomerSearchDropdown));
            Assert.IsTrue(driver.FindElement(ExistingCustomerSearchDropdown).Displayed);
            driver.FindElement(ExistingCustomerSearchDropdown).Click();
            Thread.Sleep(2000);
            //Check result is shown under access channel after selecting from dropdown
            wait.Until(ExpectedConditions.ElementExists((By)ExistingCustomerSearchResult));
            Assert.IsTrue(driver.FindElement(ExistingCustomerSearchResult).Displayed);
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
            wait.Until(ExpectedConditions.ElementExists((By)FAQSearchServiceResult));
            Assert.IsTrue(driver.FindElement(FAQSearchServiceResult).Displayed);
            driver.FindElement(FAQSearchServiceResult).Click();
            Thread.Sleep(2000);
            //Verify customer name and service shown on the create new case overlay
            driver.SwitchTo().DefaultContent();
            wait.Until(ExpectedConditions.ElementExists((By)CustomerNameOnNewCaseOverlay));
            Assert.IsTrue(driver.FindElement(CustomerNameOnNewCaseOverlay).Displayed);
            wait.Until(ExpectedConditions.ElementExists((By)ServiceOnNewCaseOverlay));
            Assert.IsTrue(driver.FindElement(ServiceOnNewCaseOverlay).Displayed);
            //Click yes on overlay
            wait.Until(ExpectedConditions.ElementExists((By)YesBtnOnNewCaseOverlay));
            driver.FindElement(YesBtnOnNewCaseOverlay).Click();
            Thread.Sleep(3000);
            //Verify dog fouling form loads
            wait.Until(ExpectedConditions.ElementExists((By)DogFoulingFormTitle));
            Assert.IsTrue(driver.FindElement(DogFoulingFormTitle).Displayed);
            //Click resolve button
            driver.SwitchTo().Frame("WebResource_allocatingpanel");
            wait.Until(ExpectedConditions.ElementExists((By)ResolveBtn));
            Thread.Sleep(2000);
            driver.FindElement(ResolveBtn).Click();
            Thread.Sleep(2000);
            //Select immediately resolve from dropdown
            wait.Until(ExpectedConditions.ElementExists((By)ResolveDropdown));
            driver.FindElement(ResolveDropdown).Click();
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)ImmediateleyResolveOption));
            driver.FindElement(ImmediateleyResolveOption).Click();
            Thread.Sleep(2000);
            //Click submit
            wait.Until(ExpectedConditions.ElementExists((By)StatusSubmitBtn));
            driver.FindElement(StatusSubmitBtn).Click();
            Thread.Sleep(2000);
            driver.SwitchTo().DefaultContent();
            //Verify case summary page loads
            wait.Until(ExpectedConditions.ElementExists((By)CustomerInfoTitleOnCaseSummary));
            Assert.IsTrue(driver.FindElement(CustomerInfoTitleOnCaseSummary).Displayed);
            //Verify SLA empty
            wait.Until(ExpectedConditions.ElementExists((By)EmptySLAOnCaseSummary));
            Assert.IsTrue(driver.FindElement(EmptySLAOnCaseSummary).Displayed);
            Thread.Sleep(2000);
            //Click refresh button
            var Status = 0;
            try
            {
                if (driver.FindElements(ResolvedJobStatus).Count() != 0)
                {
                    Console.WriteLine("Job status changed from in progress");
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                do
                {
                    driver.FindElement(RefreshButtonOnCaseDetails).Click();
                    Thread.Sleep(5000);
                    Status++;
                    if (driver.FindElements(ResolvedJobStatus).Count() != 0)
                    {
                        break;
                    }
                    else if (Status == 10)
                    {
                        Console.WriteLine("Job status not updated from in progress");
                        Assert.Fail();
                    }
                } while (driver.FindElements(ResolvedJobStatus).Count() == 0);
            }
            //Verify status updated to customer rejected
            wait.Until(ExpectedConditions.ElementExists((By)ResolvedJobStatus));
            Assert.IsTrue(driver.FindElement(ResolvedJobStatus).Displayed);
            Thread.Sleep(2000);
            //Select wakefield case from allocated case dropdown
            wait.Until(ExpectedConditions.ElementExists((By)AllocatedCaseForm));
            driver.FindElement(AllocatedCaseForm).Click();
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)AllocatedCaseDropdownWakefield));
            driver.FindElement(AllocatedCaseDropdownWakefield).Click();
            Thread.Sleep(2000);
            //Verify case details form loads
            wait.Until(ExpectedConditions.ElementExists((By)CaseDetailsForm));
            Assert.IsTrue(driver.FindElement(CaseDetailsForm).Displayed);
            Thread.Sleep(2000);
            //Verify last customer update shows resolved message
            wait.Until(ExpectedConditions.ElementExists((By)CaseDetailsResolvedUpdateMsg));
            Assert.IsTrue(driver.FindElement(CaseDetailsResolvedUpdateMsg).Displayed);
            Thread.Sleep(2000);
            //Verify status message shown on timeline
            wait.Until(ExpectedConditions.ElementExists((By)TimelineStatusClosed));
            Assert.IsTrue(driver.FindElement(TimelineStatusClosed).Displayed);
            Thread.Sleep(2000);
            //Click customer updates/history
            driver.FindElement(HistoryTabOnCustomer).Click();
            Thread.Sleep(2000);
            //Verify status updates shows the rejected status message
            wait.Until(ExpectedConditions.ElementExists((By)CustomerResolvedOnHistoryTab));
            Assert.IsTrue(driver.FindElement(CustomerResolvedOnHistoryTab).Displayed);
            Thread.Sleep(2000);
            //Click back to summary tab
            driver.FindElement(CaseDetailsSummaryTab).Click();
            Thread.Sleep(2000);
            //Click case form link on service details
            Assert.IsTrue(driver.FindElement(ServiceFormLink).Displayed);
            Thread.Sleep(2000);
            driver.FindElement(ServiceFormLink).Click();
            Thread.Sleep(2000);
            //Verify form loads
            wait.Until(ExpectedConditions.ElementExists((By)DogFoulingFormTitle));
            Assert.IsTrue(driver.FindElement(DogFoulingFormTitle).Displayed);
            Thread.Sleep(2000);
            //Verify message shows record is inactive
            wait.Until(ExpectedConditions.ElementExists((By)DogFoulingFormStatusInactive));
            Assert.IsTrue(driver.FindElement(DogFoulingFormStatusInactive).Displayed);
            Thread.Sleep(2000);
            //Click dashboards in LHN
            driver.FindElement(DashboardsLHN).Click();
            Thread.Sleep(2000);
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
            driver.FindElement(Searchbox).SendKeys("Gary Moore");
            driver.FindElement(Searchbox).SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            //Check result shows on the dropdown
            wait.Until(ExpectedConditions.ElementExists((By)ExistingCustomerSearchDropdown));
            Assert.IsTrue(driver.FindElement(ExistingCustomerSearchDropdown).Displayed);
            driver.FindElement(ExistingCustomerSearchDropdown).Click();
            Thread.Sleep(2000);
            //Check result is shown under access channel after selecting from dropdown
            wait.Until(ExpectedConditions.ElementExists((By)ExistingCustomerSearchResult));
            Assert.IsTrue(driver.FindElement(ExistingCustomerSearchResult).Displayed);
            Thread.Sleep(5000);
            //Verify job status shows as resolved
            wait.Until(ExpectedConditions.ElementExists((By)CaseHistoryResolved));
            Assert.IsTrue(driver.FindElement(CaseHistoryResolved).Displayed);
            Thread.Sleep(2000);
            //Click customer name
            driver.FindElement(ExistingCustomerSearchResult).Click();
            Thread.Sleep(2000);
            driver.SwitchTo().DefaultContent();
            Thread.Sleep(2000);
            //Click history tab
            driver.FindElement(HistoryTabOnCustomer).Click();
            Thread.Sleep(2000);
            Actions action = new Actions(driver);
            action.SendKeys(Keys.PageDown).Build().Perform();
            var Cases = 0;
            try
            {
                if (driver.FindElements(CustomerNameOnCustomerHistory).Count() != 0)
                    Console.WriteLine("Cases present on customer history");
                {
                    do
                    {
                        //Click select all cases
                        wait.Until(ExpectedConditions.ElementExists((By)SelectAllCasesBtn));
                        Thread.Sleep(3000);
                        driver.FindElement(SelectAllCasesBtn).Click();
                        Thread.Sleep(2000);
                        //Click more options dots
                        wait.Until(ExpectedConditions.ElementExists((By)MoreOptionsDotsOnCustomerCases));
                        Thread.Sleep(2000);
                        driver.FindElement(MoreOptionsDotsOnCustomerCases).Click();
                        Thread.Sleep(2000);
                        //Click delete cases
                        wait.Until(ExpectedConditions.ElementExists((By)DeleteCasesFromMoreOptions));
                        Thread.Sleep(2000);
                        driver.FindElement(DeleteCasesFromMoreOptions).Click();
                        Thread.Sleep(2000);
                        //Click delete on the overlay
                        wait.Until(ExpectedConditions.ElementExists((By)DeleteCasesOverlayBtn));
                        Thread.Sleep(2000);
                        driver.FindElement(DeleteCasesOverlayBtn).Click();
                        Thread.Sleep(10000);
                        wait.Until(ExpectedConditions.ElementExists((By)CustomerCasesTitle));
                        Cases++;
                        if (driver.FindElements(CustomerNameOnCustomerHistory).Count() == 0)
                        {
                            Console.WriteLine("All cases removed");
                            break;
                        }
                    }
                    while (driver.FindElements(CustomerNameOnCustomerHistory).Count() != 0);
                }
            }
            catch (Exception)
            {
                if (Cases == 0)
                {
                    Console.WriteLine("No cases were added to customer history");
                    Assert.Fail();
                }
            }
        }

        public void BusinessRejectCaseOnBehalfOf()
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
            wait.Until(ExpectedConditions.ElementExists((By)Searchbox));
            Assert.IsTrue(driver.FindElement(Searchbox).Displayed);
            //Enter fullname in search
            driver.FindElement(Searchbox).Click();
            driver.FindElement(Searchbox).SendKeys("Test Business");
            driver.FindElement(Searchbox).SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            //Check result shows on the dropdown
            wait.Until(ExpectedConditions.ElementExists((By)TestBusinessInDropdown));
            driver.FindElement(OnBehalfOfInDropdown).Click();
            driver.FindElement(TestBusinessInDropdown).Click();
            Thread.Sleep(2000);
            //Remove search term from box
            driver.FindElement(Searchbox).Click();
            Actions action = new Actions(driver);
            WebElement ele = (WebElement)driver.FindElement(Searchbox);
            action.Click(ele).Click(ele).Click(ele).Perform();
            driver.FindElement(Searchbox).SendKeys(Keys.Delete);
            //Search for different customer
            Thread.Sleep(2000);
            driver.FindElement(Searchbox).SendKeys("Test cafe");
            driver.FindElement(Searchbox).SendKeys(Keys.Enter);
            wait.Until(ExpectedConditions.ElementExists((By)ExistingBusinessSearchDropdown));
            Assert.IsTrue(driver.FindElement(ExistingBusinessSearchDropdown).Displayed);
            driver.FindElement(ExistingBusinessSearchDropdown).Click();
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)ExistingBusinessSearchResult));
            Assert.IsTrue(driver.FindElement(ExistingBusinessSearchResult).Displayed);
            Thread.Sleep(2000);
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
            wait.Until(ExpectedConditions.ElementExists((By)FAQSearchServiceResult));
            Assert.IsTrue(driver.FindElement(FAQSearchServiceResult).Displayed);
            driver.FindElement(FAQSearchServiceResult).Click();
            Thread.Sleep(2000);
            //Verify customer name and service shown on the create new case overlay
            driver.SwitchTo().DefaultContent();
            wait.Until(ExpectedConditions.ElementExists((By)BusinessNameOnNewCaseOverlay));
            Assert.IsTrue(driver.FindElement(BusinessNameOnNewCaseOverlay).Displayed);
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
            //Select private land
            Actions actions = new Actions(driver);
            actions.SendKeys(Keys.PageDown).Build().Perform();
            Thread.Sleep(2000);
            driver.FindElement(DogFoulingLandType).Click();
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)DogFoulingLandPrivate));
            driver.FindElement(DogFoulingLandPrivate).Click();
            Thread.Sleep(2000);
            driver.FindElement(DogFoulingLandType).Click();
            Thread.Sleep(2000);
            //Click reject
            driver.SwitchTo().Frame("WebResource_allocatingpanel");
            wait.Until(ExpectedConditions.ElementExists((By)RejectBtn));
            Thread.Sleep(2000);
            driver.FindElement(RejectBtn).Click();
            Thread.Sleep(2000);
            //Select customer rejecting on dropdown
            wait.Until(ExpectedConditions.ElementExists((By)RejectReasonDropdown));
            driver.FindElement(RejectReasonDropdown).Click();
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)RejectReasonCustomerRejected));
            driver.FindElement(RejectReasonCustomerRejected).Click();
            Thread.Sleep(2000);
            //Verify default message is shown
            wait.Until(ExpectedConditions.ElementExists((By)RejectCustomerMsg));
            Assert.IsTrue(driver.FindElement(RejectCustomerMsg).Displayed);
            Thread.Sleep(2000);
            //Click submit button
            wait.Until(ExpectedConditions.ElementExists((By)StatusSubmitBtn));
            driver.FindElement(StatusSubmitBtn).Click();
            Thread.Sleep(2000);
            driver.SwitchTo().DefaultContent();
            //Verify case summary page loads
            wait.Until(ExpectedConditions.ElementExists((By)CustomerInfoTitleOnCaseSummary));
            Assert.IsTrue(driver.FindElement(CustomerInfoTitleOnCaseSummary).Displayed);
            //Verify SLA empty
            wait.Until(ExpectedConditions.ElementExists((By)EmptySLAOnCaseSummary));
            Assert.IsTrue(driver.FindElement(EmptySLAOnCaseSummary).Displayed);
            Thread.Sleep(2000);
            //Click refresh button
            var Status = 0;
            try
            {
                if (driver.FindElements(JobStatusOnCaseSummary).Count() != 0)
                {
                    Console.WriteLine("Job status changed from in progress");
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                do
                {
                    driver.FindElement(RefreshButtonOnCaseDetails).Click();
                    Thread.Sleep(5000);
                    Status++;
                    if (driver.FindElements(JobStatusOnCaseSummary).Count() != 0)
                    {
                        break;
                    }
                    else if (Status == 10)
                    {
                        Console.WriteLine("Job status not updated from in progress");
                        Assert.Fail();
                    }
                } while (driver.FindElements(JobStatusOnCaseSummary).Count() == 0);
            }
            //Verify status updated to customer rejected
            wait.Until(ExpectedConditions.ElementExists((By)JobStatusOnCaseSummary));
            Assert.IsTrue(driver.FindElement(JobStatusOnCaseSummary).Displayed);
            Thread.Sleep(2000);
            //Select wakefield case from allocated case dropdown
            wait.Until(ExpectedConditions.ElementExists((By)AllocatedCaseForm));
            driver.FindElement(AllocatedCaseForm).Click();
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)AllocatedCaseDropdownWakefield));
            driver.FindElement(AllocatedCaseDropdownWakefield).Click();
            Thread.Sleep(2000);
            //Verify case details form loads
            wait.Until(ExpectedConditions.ElementExists((By)CaseDetailsForm));
            Assert.IsTrue(driver.FindElement(CaseDetailsForm).Displayed);
            Thread.Sleep(2000);
            //Verify last customer update shows rejected message
            wait.Until(ExpectedConditions.ElementExists((By)CaseDetailsRejectedUpdateMsg));
            Assert.IsTrue(driver.FindElement(CaseDetailsRejectedUpdateMsg).Displayed);
            Thread.Sleep(2000);
            //Verify status message shown on timeline
            wait.Until(ExpectedConditions.ElementExists((By)TimelineStatusClosed));
            Assert.IsTrue(driver.FindElement(TimelineStatusClosed).Displayed);
            Thread.Sleep(2000);
            //Click customer updates/history
            driver.FindElement(HistoryTabOnCustomer).Click();
            Thread.Sleep(2000);
            //Verify customer name is displayed
            wait.Until(ExpectedConditions.ElementExists((By)BusinessNameOnCustomerCases));
            Assert.IsTrue(driver.FindElement(BusinessNameOnCustomerCases).Displayed);
            //Verify status updates shows the rejected status message
            wait.Until(ExpectedConditions.ElementExists((By)CustomerStatusOnHistoryTab));
            Assert.IsTrue(driver.FindElement(CustomerStatusOnHistoryTab).Displayed);
            Thread.Sleep(2000);
            //Click back to summary tab
            driver.FindElement(CaseDetailsSummaryTab).Click();
            Thread.Sleep(2000);
            //Click case form link on service details
            Assert.IsTrue(driver.FindElement(ServiceFormLink).Displayed);
            Thread.Sleep(2000);
            driver.FindElement(ServiceFormLink).Click();
            Thread.Sleep(2000);
            //Verify form loads
            wait.Until(ExpectedConditions.ElementExists((By)DogFoulingFormTitle));
            Assert.IsTrue(driver.FindElement(DogFoulingFormTitle).Displayed);
            Thread.Sleep(2000);
            //Verify message shows record is inactive
            wait.Until(ExpectedConditions.ElementExists((By)DogFoulingFormStatusInactive));
            Assert.IsTrue(driver.FindElement(DogFoulingFormStatusInactive).Displayed);
            Thread.Sleep(2000);
            //Click dashboards in LHN
            driver.FindElement(DashboardsLHN).Click();
            Thread.Sleep(2000);
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
            driver.FindElement(Searchbox).SendKeys("Test Business");
            driver.FindElement(Searchbox).SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            //Check result shows on the dropdown
            wait.Until(ExpectedConditions.ElementExists((By)TestBusinessInDropdown));
            driver.FindElement(TestBusinessInDropdown).Click();
            Thread.Sleep(2000);
            //Check result is shown under access channel after selecting from dropdown
            wait.Until(ExpectedConditions.ElementExists((By)TestBusinessInAccessChannel));
            Assert.IsTrue(driver.FindElement(TestBusinessInAccessChannel).Displayed);
            Thread.Sleep(5000);
            //Verify job status shows as cancelled
            wait.Until(ExpectedConditions.ElementExists((By)CaseHistoryCancelled));
            Assert.IsTrue(driver.FindElement(CaseHistoryCancelled).Displayed);
            Thread.Sleep(2000);
            //Verify on behalf of asterisk is shown
            wait.Until(ExpectedConditions.ElementExists((By)CaseHistoryAsterisk));
            Assert.IsTrue(driver.FindElement(CaseHistoryAsterisk).Displayed);
            //Click customer name
            driver.FindElement(TestBusinessInAccessChannel).Click();
            Thread.Sleep(2000);
            driver.SwitchTo().DefaultContent();
            Thread.Sleep(2000);
            //Click history tab
            wait.Until(ExpectedConditions.ElementExists((By)HistoryTabOnCustomer));
            driver.FindElement(HistoryTabOnCustomer).Click();
            Thread.Sleep(2000);
            try
            {
                do
                {
                    //Click select all cases
                    wait.Until(ExpectedConditions.ElementExists((By)SelectAllCasesBtn));
                    Thread.Sleep(3000);
                    driver.FindElement(SelectAllCasesBtn).Click();
                    Thread.Sleep(2000);
                    //Click more options dots
                    wait.Until(ExpectedConditions.ElementExists((By)MoreOptionsDotsOnCustomerCases));
                    Thread.Sleep(2000);
                    driver.FindElement(MoreOptionsDotsOnCustomerCases).Click();
                    Thread.Sleep(2000);
                    //Click delete cases
                    wait.Until(ExpectedConditions.ElementExists((By)DeleteCasesFromMoreOptions));
                    Thread.Sleep(2000);
                    driver.FindElement(DeleteCasesFromMoreOptions).Click();
                    Thread.Sleep(2000);
                    //Click delete on the overlay
                    wait.Until(ExpectedConditions.ElementExists((By)DeleteCasesOverlayBtn));
                    Thread.Sleep(2000);
                    driver.FindElement(DeleteCasesOverlayBtn).Click();
                    Thread.Sleep(10000);
                    wait.Until(ExpectedConditions.ElementExists((By)CustomerCasesTitle));
                }
                while (driver.FindElement(TestBusinessOnCustomerHistory).Displayed);
            }
            catch (Exception)
            {
                Console.WriteLine("All cases removed from history screen");
            }
            //Verify cases deleted
            var Cases = 0;
            try
            {
                WebElement cases = (WebElement)driver.FindElement(TestBusinessOnCustomerHistory);
                if (cases.Displayed)
                {
                    Cases = 1;
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                if (Cases > 0)
                {
                    Console.WriteLine("Cases not removed");
                }
                else
                {
                    Console.WriteLine("Cases removed");
                }
            }
        }

        public void AnonImmediatelyResolveCase()
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
            wait.Until(ExpectedConditions.ElementExists((By)Searchbox));
            Assert.IsTrue(driver.FindElement(Searchbox).Displayed);
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
            wait.Until(ExpectedConditions.ElementExists((By)FAQSearchServiceResult));
            Assert.IsTrue(driver.FindElement(FAQSearchServiceResult).Displayed);
            driver.FindElement(FAQSearchServiceResult).Click();
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
            //Click resolve button
            driver.SwitchTo().Frame("WebResource_allocatingpanel");
            wait.Until(ExpectedConditions.ElementExists((By)ResolveBtn));
            Thread.Sleep(2000);
            driver.FindElement(ResolveBtn).Click();
            Thread.Sleep(2000);
            //Select immediately resolve from dropdown
            wait.Until(ExpectedConditions.ElementExists((By)ResolveDropdown));
            driver.FindElement(ResolveDropdown).Click();
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)ImmediateleyResolveOption));
            driver.FindElement(ImmediateleyResolveOption).Click();
            Thread.Sleep(2000);
            //Click submit
            wait.Until(ExpectedConditions.ElementExists((By)StatusSubmitBtn));
            driver.FindElement(StatusSubmitBtn).Click();
            Thread.Sleep(2000);
            driver.SwitchTo().DefaultContent();
            //Verify case summary page loads
            wait.Until(ExpectedConditions.ElementExists((By)CustomerInfoTitleOnCaseSummary));
            Assert.IsTrue(driver.FindElement(CustomerInfoTitleOnCaseSummary).Displayed);
            //Verify SLA empty
            wait.Until(ExpectedConditions.ElementExists((By)EmptySLAOnCaseSummary));
            Assert.IsTrue(driver.FindElement(EmptySLAOnCaseSummary).Displayed);
            Thread.Sleep(2000);
            //Click refresh button
            var Status = 0;
            try
            {
                if (driver.FindElements(ResolvedJobStatus).Count() != 0)
                {
                    Console.WriteLine("Job status changed from in progress");
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                do
                {
                    driver.FindElement(RefreshButtonOnCaseDetails).Click();
                    Thread.Sleep(5000);
                    Status++;
                    if (driver.FindElements(ResolvedJobStatus).Count() != 0)
                    {
                        break;
                    }
                    else if (Status == 10)
                    {
                        Console.WriteLine("Job status not updated from in progress");
                        Assert.Fail();
                    }
                } while (driver.FindElements(ResolvedJobStatus).Count() == 0);
            }
            //Verify status updated to customer rejected
            wait.Until(ExpectedConditions.ElementExists((By)ResolvedJobStatus));
            Assert.IsTrue(driver.FindElement(ResolvedJobStatus).Displayed);
            Thread.Sleep(2000);
            //Select wakefield case from allocated case dropdown
            wait.Until(ExpectedConditions.ElementExists((By)AllocatedCaseForm));
            driver.FindElement(AllocatedCaseForm).Click();
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)AllocatedCaseDropdownWakefield));
            driver.FindElement(AllocatedCaseDropdownWakefield).Click();
            Thread.Sleep(2000);
            //Verify case details form loads
            wait.Until(ExpectedConditions.ElementExists((By)CaseDetailsForm));
            Assert.IsTrue(driver.FindElement(CaseDetailsForm).Displayed);
            Thread.Sleep(2000);
            //Verify status message shown on timeline
            wait.Until(ExpectedConditions.ElementExists((By)TimelineStatusClosed));
            Assert.IsTrue(driver.FindElement(TimelineStatusClosed).Displayed);
            Thread.Sleep(2000);
            //Click customer updates/history
            driver.FindElement(HistoryTabOnCustomer).Click();
            Thread.Sleep(2000);
            //Verify status updates shows the rejected status message
            wait.Until(ExpectedConditions.ElementExists((By)CustomerResolvedOnHistoryTab));
            Assert.IsTrue(driver.FindElement(CustomerResolvedOnHistoryTab).Displayed);
            Thread.Sleep(2000);
            //Click back to summary tab
            driver.FindElement(CaseDetailsSummaryTab).Click();
            Thread.Sleep(2000);
            //Click case form link on service details
            Assert.IsTrue(driver.FindElement(ServiceFormLink).Displayed);
            Thread.Sleep(2000);
            driver.FindElement(ServiceFormLink).Click();
            Thread.Sleep(2000);
            //Verify form loads
            wait.Until(ExpectedConditions.ElementExists((By)DogFoulingFormTitle));
            Assert.IsTrue(driver.FindElement(DogFoulingFormTitle).Displayed);
            Thread.Sleep(2000);
            //Verify message shows record is inactive
            wait.Until(ExpectedConditions.ElementExists((By)DogFoulingFormStatusInactive));
            Assert.IsTrue(driver.FindElement(DogFoulingFormStatusInactive).Displayed);
            Thread.Sleep(2000);
        }

        public void OOAImmediatelyResolveCase()
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
            driver.FindElement(Searchbox).SendKeys("Out Ofarea");
            driver.FindElement(Searchbox).SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            //Check result shows on the dropdown
            wait.Until(ExpectedConditions.ElementExists((By)OutOfareaDetailsOnDropdown));
            Assert.IsTrue(driver.FindElement(OutOfareaDetailsOnDropdown).Displayed);
            driver.FindElement(OutOfareaDetailsOnDropdown).Click();
            Thread.Sleep(2000);
            //Check result is shown under access channel after selecting from dropdown
            wait.Until(ExpectedConditions.ElementExists((By)OutOfareaSearchResult));
            Assert.IsTrue(driver.FindElement(OutOfareaSearchResult).Displayed);
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
            wait.Until(ExpectedConditions.ElementExists((By)FAQSearchServiceResult));
            Assert.IsTrue(driver.FindElement(FAQSearchServiceResult).Displayed);
            driver.FindElement(FAQSearchServiceResult).Click();
            Thread.Sleep(2000);
            //Verify customer name and service shown on the create new case overlay
            driver.SwitchTo().DefaultContent();
            wait.Until(ExpectedConditions.ElementExists((By)OOANameOnNewCaseOverlay));
            Assert.IsTrue(driver.FindElement(OOANameOnNewCaseOverlay).Displayed);
            wait.Until(ExpectedConditions.ElementExists((By)ServiceOnNewCaseOverlay));
            Assert.IsTrue(driver.FindElement(ServiceOnNewCaseOverlay).Displayed);
            //Click yes on overlay
            wait.Until(ExpectedConditions.ElementExists((By)YesBtnOnNewCaseOverlay));
            driver.FindElement(YesBtnOnNewCaseOverlay).Click();
            Thread.Sleep(3000);
            //Verify dog fouling form loads
            wait.Until(ExpectedConditions.ElementExists((By)DogFoulingFormTitle));
            Assert.IsTrue(driver.FindElement(DogFoulingFormTitle).Displayed);
            //Click resolve button
            driver.SwitchTo().Frame("WebResource_allocatingpanel");
            wait.Until(ExpectedConditions.ElementExists((By)ResolveBtn));
            Thread.Sleep(2000);
            driver.FindElement(ResolveBtn).Click();
            Thread.Sleep(2000);
            //Select immediately resolve from dropdown
            wait.Until(ExpectedConditions.ElementExists((By)ResolveDropdown));
            driver.FindElement(ResolveDropdown).Click();
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)ImmediateleyResolveOption));
            driver.FindElement(ImmediateleyResolveOption).Click();
            Thread.Sleep(2000);
            //Click submit
            wait.Until(ExpectedConditions.ElementExists((By)StatusSubmitBtn));
            driver.FindElement(StatusSubmitBtn).Click();
            Thread.Sleep(2000);
            driver.SwitchTo().DefaultContent();
            //Verify case summary page loads
            wait.Until(ExpectedConditions.ElementExists((By)CustomerInfoTitleOnCaseSummary));
            Assert.IsTrue(driver.FindElement(CustomerInfoTitleOnCaseSummary).Displayed);
            //Verify SLA empty
            wait.Until(ExpectedConditions.ElementExists((By)EmptySLAOnCaseSummary));
            Assert.IsTrue(driver.FindElement(EmptySLAOnCaseSummary).Displayed);
            Thread.Sleep(2000);
            //Click refresh button
            var Status = 0;
            try
            {
                if (driver.FindElements(ResolvedJobStatus).Count() != 0)
                {
                    Console.WriteLine("Job status changed from in progress");
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                do
                {
                    driver.FindElement(RefreshButtonOnCaseDetails).Click();
                    Thread.Sleep(5000);
                    Status++;
                    if (driver.FindElements(ResolvedJobStatus).Count() != 0)
                    {
                        break;
                    }
                    else if (Status == 10)
                    {
                        Console.WriteLine("Job status not updated from in progress");
                        Assert.Fail();
                    }
                } while (driver.FindElements(ResolvedJobStatus).Count() == 0);
            }
            //Verify status updated to customer rejected
            wait.Until(ExpectedConditions.ElementExists((By)ResolvedJobStatus));
            Assert.IsTrue(driver.FindElement(ResolvedJobStatus).Displayed);
            Thread.Sleep(2000);
            //Select wakefield case from allocated case dropdown
            wait.Until(ExpectedConditions.ElementExists((By)AllocatedCaseForm));
            driver.FindElement(AllocatedCaseForm).Click();
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)AllocatedCaseDropdownWakefield));
            driver.FindElement(AllocatedCaseDropdownWakefield).Click();
            Thread.Sleep(2000);
            //Verify case details form loads
            wait.Until(ExpectedConditions.ElementExists((By)CaseDetailsForm));
            Assert.IsTrue(driver.FindElement(CaseDetailsForm).Displayed);
            Thread.Sleep(2000);
            //Verify last customer update shows resolved message
            wait.Until(ExpectedConditions.ElementExists((By)CaseDetailsResolvedUpdateMsg));
            Assert.IsTrue(driver.FindElement(CaseDetailsResolvedUpdateMsg).Displayed);
            Thread.Sleep(2000);
            //Verify status message shown on timeline
            wait.Until(ExpectedConditions.ElementExists((By)TimelineStatusClosed));
            Assert.IsTrue(driver.FindElement(TimelineStatusClosed).Displayed);
            Thread.Sleep(2000);
            //Click customer updates/history
            driver.FindElement(HistoryTabOnCustomer).Click();
            Thread.Sleep(2000);
            //Verify status updates shows the rejected status message
            wait.Until(ExpectedConditions.ElementExists((By)CustomerResolvedOnHistoryTab));
            Assert.IsTrue(driver.FindElement(CustomerResolvedOnHistoryTab).Displayed);
            Thread.Sleep(2000);
            //Click back to summary tab
            driver.FindElement(CaseDetailsSummaryTab).Click();
            Thread.Sleep(2000);
            //Click case form link on service details
            Assert.IsTrue(driver.FindElement(ServiceFormLink).Displayed);
            Thread.Sleep(2000);
            driver.FindElement(ServiceFormLink).Click();
            Thread.Sleep(2000);
            //Verify form loads
            wait.Until(ExpectedConditions.ElementExists((By)DogFoulingFormTitle));
            Assert.IsTrue(driver.FindElement(DogFoulingFormTitle).Displayed);
            Thread.Sleep(2000);
            //Verify message shows record is inactive
            wait.Until(ExpectedConditions.ElementExists((By)DogFoulingFormStatusInactive));
            Assert.IsTrue(driver.FindElement(DogFoulingFormStatusInactive).Displayed);
            Thread.Sleep(2000);
            //Click dashboards in LHN
            driver.FindElement(DashboardsLHN).Click();
            Thread.Sleep(2000);
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
            driver.FindElement(Searchbox).SendKeys("Out Ofarea");
            driver.FindElement(Searchbox).SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            //Check result shows on the dropdown
            wait.Until(ExpectedConditions.ElementExists((By)OutOfareaDetailsOnDropdown));
            Assert.IsTrue(driver.FindElement(OutOfareaDetailsOnDropdown).Displayed);
            driver.FindElement(OutOfareaDetailsOnDropdown).Click();
            Thread.Sleep(2000);
            //Check result is shown under access channel after selecting from dropdown
            wait.Until(ExpectedConditions.ElementExists((By)OutOfareaSearchResult));
            Assert.IsTrue(driver.FindElement(OutOfareaSearchResult).Displayed);
            Thread.Sleep(5000);
            //Verify job status shows as resolved
            wait.Until(ExpectedConditions.ElementExists((By)CaseHistoryResolved));
            Assert.IsTrue(driver.FindElement(CaseHistoryResolved).Displayed);
            Thread.Sleep(2000);
            //Click customer name
            driver.FindElement(OutOfareaSearchResult).Click();
            Thread.Sleep(2000);
            driver.SwitchTo().DefaultContent();
            Thread.Sleep(2000);
            //Click history tab
            driver.FindElement(HistoryTabOnCustomer).Click();
            Thread.Sleep(2000);
            Actions action = new Actions(driver);
            action.SendKeys(Keys.PageDown).Build().Perform();
            var Cases = 0;
            try
            {
                if (driver.FindElements(OOANameOnCustomerHistory).Count() != 0)
                    Console.WriteLine("Cases present on customer history");
                {
                    do
                    {
                        //Click select all cases
                        wait.Until(ExpectedConditions.ElementExists((By)SelectAllCasesBtn));
                        Thread.Sleep(3000);
                        driver.FindElement(SelectAllCasesBtn).Click();
                        Thread.Sleep(2000);
                        //Click more options dots
                        wait.Until(ExpectedConditions.ElementExists((By)MoreOptionsDotsOnCustomerCases));
                        Thread.Sleep(2000);
                        driver.FindElement(MoreOptionsDotsOnCustomerCases).Click();
                        Thread.Sleep(2000);
                        //Click delete cases
                        wait.Until(ExpectedConditions.ElementExists((By)DeleteCasesFromMoreOptions));
                        Thread.Sleep(2000);
                        driver.FindElement(DeleteCasesFromMoreOptions).Click();
                        Thread.Sleep(2000);
                        //Click delete on the overlay
                        wait.Until(ExpectedConditions.ElementExists((By)DeleteCasesOverlayBtn));
                        Thread.Sleep(2000);
                        driver.FindElement(DeleteCasesOverlayBtn).Click();
                        Thread.Sleep(10000);
                        wait.Until(ExpectedConditions.ElementExists((By)CustomerCasesTitle));
                        Cases++;
                        if (driver.FindElements(OOANameOnCustomerHistory).Count() == 0)
                        {
                            Console.WriteLine("All cases removed");
                            break;
                        }
                    }
                    while (driver.FindElements(OOANameOnCustomerHistory).Count() != 0);
                }
            }
            catch (Exception)
            {
                if (Cases == 0)
                {
                    Console.WriteLine("No cases were added to customer history");
                    Assert.Fail();
                }
            }
        }

        public void ManualAddressResolveCase()
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
            wait.Until(ExpectedConditions.ElementExists((By)FAQSearchServiceResult));
            Assert.IsTrue(driver.FindElement(FAQSearchServiceResult).Displayed);
            driver.FindElement(FAQSearchServiceResult).Click();
            Thread.Sleep(2000);
            //Verify customer name and service shown on the create new case overlay
            driver.SwitchTo().DefaultContent();
            wait.Until(ExpectedConditions.ElementExists((By)ManualAddressOnNewCaseOverlay));
            Assert.IsTrue(driver.FindElement(ManualAddressOnNewCaseOverlay).Displayed);
            wait.Until(ExpectedConditions.ElementExists((By)ServiceOnNewCaseOverlay));
            Assert.IsTrue(driver.FindElement(ServiceOnNewCaseOverlay).Displayed);
            //Click yes on overlay
            wait.Until(ExpectedConditions.ElementExists((By)YesBtnOnNewCaseOverlay));
            driver.FindElement(YesBtnOnNewCaseOverlay).Click();
            Thread.Sleep(3000);
            //Verify dog fouling form loads
            wait.Until(ExpectedConditions.ElementExists((By)DogFoulingFormTitle));
            Assert.IsTrue(driver.FindElement(DogFoulingFormTitle).Displayed);
            //Click resolve button
            driver.SwitchTo().Frame("WebResource_allocatingpanel");
            wait.Until(ExpectedConditions.ElementExists((By)ResolveBtn));
            Thread.Sleep(2000);
            driver.FindElement(ResolveBtn).Click();
            Thread.Sleep(2000);
            //Select immediately resolve from dropdown
            wait.Until(ExpectedConditions.ElementExists((By)ResolveDropdown));
            driver.FindElement(ResolveDropdown).Click();
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)ImmediateleyResolveOption));
            driver.FindElement(ImmediateleyResolveOption).Click();
            Thread.Sleep(2000);
            //Click submit
            wait.Until(ExpectedConditions.ElementExists((By)StatusSubmitBtn));
            driver.FindElement(StatusSubmitBtn).Click();
            Thread.Sleep(2000);
            driver.SwitchTo().DefaultContent();
            //Verify case summary page loads
            wait.Until(ExpectedConditions.ElementExists((By)CustomerInfoTitleOnCaseSummary));
            Assert.IsTrue(driver.FindElement(CustomerInfoTitleOnCaseSummary).Displayed);
            //Verify SLA empty
            wait.Until(ExpectedConditions.ElementExists((By)EmptySLAOnCaseSummary));
            Assert.IsTrue(driver.FindElement(EmptySLAOnCaseSummary).Displayed);
            Thread.Sleep(2000);
            //Click refresh button
            var Status = 0;
            try
            {
                if (driver.FindElements(ResolvedJobStatus).Count() != 0)
                {
                    Console.WriteLine("Job status changed from in progress");
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                do
                {
                    driver.FindElement(RefreshButtonOnCaseDetails).Click();
                    Thread.Sleep(5000);
                    Status++;
                    if (driver.FindElements(ResolvedJobStatus).Count() != 0)
                    {
                        break;
                    }
                    else if (Status == 10)
                    {
                        Console.WriteLine("Job status not updated from in progress");
                        Assert.Fail();
                    }
                } while (driver.FindElements(ResolvedJobStatus).Count() == 0);
            }
            //Verify status updated to customer rejected
            wait.Until(ExpectedConditions.ElementExists((By)ResolvedJobStatus));
            Assert.IsTrue(driver.FindElement(ResolvedJobStatus).Displayed);
            Thread.Sleep(2000);
            //Select wakefield case from allocated case dropdown
            wait.Until(ExpectedConditions.ElementExists((By)AllocatedCaseForm));
            driver.FindElement(AllocatedCaseForm).Click();
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)AllocatedCaseDropdownWakefield));
            driver.FindElement(AllocatedCaseDropdownWakefield).Click();
            Thread.Sleep(2000);
            //Verify case details form loads
            wait.Until(ExpectedConditions.ElementExists((By)CaseDetailsForm));
            Assert.IsTrue(driver.FindElement(CaseDetailsForm).Displayed);
            Thread.Sleep(2000);
            //Verify last customer update shows resolved message
            wait.Until(ExpectedConditions.ElementExists((By)CaseDetailsResolvedUpdateMsg));
            Assert.IsTrue(driver.FindElement(CaseDetailsResolvedUpdateMsg).Displayed);
            Thread.Sleep(2000);
            //Verify status message shown on timeline
            wait.Until(ExpectedConditions.ElementExists((By)TimelineStatusClosed));
            Assert.IsTrue(driver.FindElement(TimelineStatusClosed).Displayed);
            Thread.Sleep(2000);
            //Click customer updates/history
            driver.FindElement(HistoryTabOnCustomer).Click();
            Thread.Sleep(2000);
            //Verify status updates shows the rejected status message
            wait.Until(ExpectedConditions.ElementExists((By)CustomerResolvedOnHistoryTab));
            Assert.IsTrue(driver.FindElement(CustomerResolvedOnHistoryTab).Displayed);
            Thread.Sleep(2000);
            //Click back to summary tab
            driver.FindElement(CaseDetailsSummaryTab).Click();
            Thread.Sleep(2000);
            //Click case form link on service details
            Assert.IsTrue(driver.FindElement(ServiceFormLink).Displayed);
            Thread.Sleep(2000);
            driver.FindElement(ServiceFormLink).Click();
            Thread.Sleep(2000);
            //Verify form loads
            wait.Until(ExpectedConditions.ElementExists((By)DogFoulingFormTitle));
            Assert.IsTrue(driver.FindElement(DogFoulingFormTitle).Displayed);
            Thread.Sleep(2000);
            //Verify message shows record is inactive
            wait.Until(ExpectedConditions.ElementExists((By)DogFoulingFormStatusInactive));
            Assert.IsTrue(driver.FindElement(DogFoulingFormStatusInactive).Displayed);
            Thread.Sleep(2000);
            //Click dashboards in LHN
            driver.FindElement(DashboardsLHN).Click();
            Thread.Sleep(2000);
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
            Thread.Sleep(5000);
            //Verify job status shows as resolved
            wait.Until(ExpectedConditions.ElementExists((By)CaseHistoryResolved));
            Assert.IsTrue(driver.FindElement(CaseHistoryResolved).Displayed);
            Thread.Sleep(2000);
            //Click customer name
            driver.FindElement(ManualAddressSearchResult).Click();
            Thread.Sleep(2000);
            driver.SwitchTo().DefaultContent();
            Thread.Sleep(2000);
            //Click history tab
            driver.FindElement(HistoryTabOnCustomer).Click();
            Thread.Sleep(2000);
            Actions action = new Actions(driver);
            action.SendKeys(Keys.PageDown).Build().Perform();
            var Cases = 0;
            try
            {
                if (driver.FindElements(ManualAddressOnCustomerHistory).Count() != 0)
                    Console.WriteLine("Cases present on customer history");
                {
                    do
                    {
                        //Click select all cases
                        wait.Until(ExpectedConditions.ElementExists((By)SelectAllCasesBtn));
                        Thread.Sleep(3000);
                        driver.FindElement(SelectAllCasesBtn).Click();
                        Thread.Sleep(2000);
                        //Click more options dots
                        wait.Until(ExpectedConditions.ElementExists((By)MoreOptionsDotsOnCustomerCases));
                        Thread.Sleep(2000);
                        driver.FindElement(MoreOptionsDotsOnCustomerCases).Click();
                        Thread.Sleep(2000);
                        //Click delete cases
                        wait.Until(ExpectedConditions.ElementExists((By)DeleteCasesFromMoreOptions));
                        Thread.Sleep(2000);
                        driver.FindElement(DeleteCasesFromMoreOptions).Click();
                        Thread.Sleep(2000);
                        //Click delete on the overlay
                        wait.Until(ExpectedConditions.ElementExists((By)DeleteCasesOverlayBtn));
                        Thread.Sleep(2000);
                        driver.FindElement(DeleteCasesOverlayBtn).Click();
                        Thread.Sleep(10000);
                        wait.Until(ExpectedConditions.ElementExists((By)CustomerCasesTitle));
                        Cases++;
                        if (driver.FindElements(OOANameOnCustomerHistory).Count() == 0)
                        {
                            Console.WriteLine("All cases removed");
                            break;
                        }
                    }
                    while (driver.FindElements(ManualAddressOnCustomerHistory).Count() != 0);
                }
            }
            catch (Exception)
            {
                if (Cases == 0)
                {
                    Console.WriteLine("No cases were added to customer history");
                    Assert.Fail();
                }
            }
        }

        public void UnknownAddressImmediatelyResolveCase()
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
            wait.Until(ExpectedConditions.ElementExists((By)AnonCustomerSearchDropdown));
            Assert.IsTrue(driver.FindElement(AnonCustomerSearchDropdown).Displayed);
            driver.FindElement(AnonCustomerSearchDropdown).Click();
            Thread.Sleep(2000);
            //Check result is shown under access channel after selecting from dropdown
            wait.Until(ExpectedConditions.ElementExists((By)AnonAddressSearchResult));
            Assert.IsTrue(driver.FindElement(AnonAddressSearchResult).Displayed);
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
            wait.Until(ExpectedConditions.ElementExists((By)FAQSearchServiceResult));
            Assert.IsTrue(driver.FindElement(FAQSearchServiceResult).Displayed);
            driver.FindElement(FAQSearchServiceResult).Click();
            Thread.Sleep(2000);
            //Verify customer name and service shown on the create new case overlay
            driver.SwitchTo().DefaultContent();
            wait.Until(ExpectedConditions.ElementExists((By)UnknownAddressOnNewCaseOverlay));
            Assert.IsTrue(driver.FindElement(UnknownAddressOnNewCaseOverlay).Displayed);
            wait.Until(ExpectedConditions.ElementExists((By)ServiceOnNewCaseOverlay));
            Assert.IsTrue(driver.FindElement(ServiceOnNewCaseOverlay).Displayed);
            //Click yes on overlay
            wait.Until(ExpectedConditions.ElementExists((By)YesBtnOnNewCaseOverlay));
            driver.FindElement(YesBtnOnNewCaseOverlay).Click();
            Thread.Sleep(3000);
            //Verify dog fouling form loads
            wait.Until(ExpectedConditions.ElementExists((By)DogFoulingFormTitle));
            Assert.IsTrue(driver.FindElement(DogFoulingFormTitle).Displayed);
            //Click resolve button
            driver.SwitchTo().Frame("WebResource_allocatingpanel");
            wait.Until(ExpectedConditions.ElementExists((By)ResolveBtn));
            Thread.Sleep(2000);
            driver.FindElement(ResolveBtn).Click();
            Thread.Sleep(2000);
            //Select immediately resolve from dropdown
            wait.Until(ExpectedConditions.ElementExists((By)ResolveDropdown));
            driver.FindElement(ResolveDropdown).Click();
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)ImmediateleyResolveOption));
            driver.FindElement(ImmediateleyResolveOption).Click();
            Thread.Sleep(2000);
            //Click submit
            wait.Until(ExpectedConditions.ElementExists((By)StatusSubmitBtn));
            driver.FindElement(StatusSubmitBtn).Click();
            Thread.Sleep(2000);
            driver.SwitchTo().DefaultContent();
            //Verify case summary page loads
            wait.Until(ExpectedConditions.ElementExists((By)CustomerInfoTitleOnCaseSummary));
            Assert.IsTrue(driver.FindElement(CustomerInfoTitleOnCaseSummary).Displayed);
            //Verify SLA empty
            wait.Until(ExpectedConditions.ElementExists((By)EmptySLAOnCaseSummary));
            Assert.IsTrue(driver.FindElement(EmptySLAOnCaseSummary).Displayed);
            Thread.Sleep(2000);
            //Click refresh button
            var Status = 0;
            try
            {
                if (driver.FindElements(ResolvedJobStatus).Count() != 0)
                {
                    Console.WriteLine("Job status changed from in progress");
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                do
                {
                    driver.FindElement(RefreshButtonOnCaseDetails).Click();
                    Thread.Sleep(5000);
                    Status++;
                    if (driver.FindElements(ResolvedJobStatus).Count() != 0)
                    {
                        break;
                    }
                    else if (Status == 10)
                    {
                        Console.WriteLine("Job status not updated from in progress");
                        Assert.Fail();
                    }
                } while (driver.FindElements(ResolvedJobStatus).Count() == 0);
            }
            //Verify status updated to customer rejected
            wait.Until(ExpectedConditions.ElementExists((By)ResolvedJobStatus));
            Assert.IsTrue(driver.FindElement(ResolvedJobStatus).Displayed);
            Thread.Sleep(2000);
            //Select wakefield case from allocated case dropdown
            wait.Until(ExpectedConditions.ElementExists((By)AllocatedCaseForm));
            driver.FindElement(AllocatedCaseForm).Click();
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)AllocatedCaseDropdownWakefield));
            driver.FindElement(AllocatedCaseDropdownWakefield).Click();
            Thread.Sleep(2000);
            //Verify case details form loads
            wait.Until(ExpectedConditions.ElementExists((By)CaseDetailsForm));
            Assert.IsTrue(driver.FindElement(CaseDetailsForm).Displayed);
            Thread.Sleep(2000);
            //Verify last customer update shows resolved message
            wait.Until(ExpectedConditions.ElementExists((By)CaseDetailsResolvedUpdateMsg));
            Assert.IsTrue(driver.FindElement(CaseDetailsResolvedUpdateMsg).Displayed);
            Thread.Sleep(2000);
            //Verify status message shown on timeline
            wait.Until(ExpectedConditions.ElementExists((By)TimelineStatusClosed));
            Assert.IsTrue(driver.FindElement(TimelineStatusClosed).Displayed);
            Thread.Sleep(2000);
            //Click customer updates/history
            driver.FindElement(HistoryTabOnCustomer).Click();
            Thread.Sleep(2000);
            //Verify status updates shows the rejected status message
            wait.Until(ExpectedConditions.ElementExists((By)CustomerResolvedOnHistoryTab));
            Assert.IsTrue(driver.FindElement(CustomerResolvedOnHistoryTab).Displayed);
            Thread.Sleep(2000);
            //Click back to summary tab
            driver.FindElement(CaseDetailsSummaryTab).Click();
            Thread.Sleep(2000);
            //Click case form link on service details
            Assert.IsTrue(driver.FindElement(ServiceFormLink).Displayed);
            Thread.Sleep(2000);
            driver.FindElement(ServiceFormLink).Click();
            Thread.Sleep(2000);
            //Verify form loads
            wait.Until(ExpectedConditions.ElementExists((By)DogFoulingFormTitle));
            Assert.IsTrue(driver.FindElement(DogFoulingFormTitle).Displayed);
            Thread.Sleep(2000);
            //Verify message shows record is inactive
            wait.Until(ExpectedConditions.ElementExists((By)DogFoulingFormStatusInactive));
            Assert.IsTrue(driver.FindElement(DogFoulingFormStatusInactive).Displayed);
            Thread.Sleep(2000);
            //Click dashboards in LHN
            driver.FindElement(DashboardsLHN).Click();
            Thread.Sleep(2000);
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
            wait.Until(ExpectedConditions.ElementExists((By)AnonCustomerSearchDropdown));
            Assert.IsTrue(driver.FindElement(AnonCustomerSearchDropdown).Displayed);
            driver.FindElement(AnonCustomerSearchDropdown).Click();
            Thread.Sleep(2000);
            //Check result is shown under access channel after selecting from dropdown
            wait.Until(ExpectedConditions.ElementExists((By)AnonAddressSearchResult));
            Assert.IsTrue(driver.FindElement(AnonAddressSearchResult).Displayed);
            Thread.Sleep(5000);
            //Verify job status shows as resolved
            wait.Until(ExpectedConditions.ElementExists((By)CaseHistoryResolved));
            Assert.IsTrue(driver.FindElement(CaseHistoryResolved).Displayed);
            Thread.Sleep(2000);
            //Click customer name
            driver.FindElement(AnonAddressSearchResult).Click();
            Thread.Sleep(2000);
            driver.SwitchTo().DefaultContent();
            Thread.Sleep(2000);
            //Click history tab
            driver.FindElement(HistoryTabOnCustomer).Click();
            Thread.Sleep(2000);
            Actions action = new Actions(driver);
            action.SendKeys(Keys.PageDown).Build().Perform();
            var Cases = 0;
            try
            {
                if (driver.FindElements(AnonOnCustomerHistory).Count() != 0)
                    Console.WriteLine("Cases present on customer history");
                {
                    do
                    {
                        //Click select all cases
                        wait.Until(ExpectedConditions.ElementExists((By)SelectAllCasesBtn));
                        Thread.Sleep(3000);
                        driver.FindElement(SelectAllCasesBtn).Click();
                        Thread.Sleep(2000);
                        //Click more options dots
                        wait.Until(ExpectedConditions.ElementExists((By)MoreOptionsDotsOnCustomerCases));
                        Thread.Sleep(2000);
                        driver.FindElement(MoreOptionsDotsOnCustomerCases).Click();
                        Thread.Sleep(2000);
                        //Click delete cases
                        wait.Until(ExpectedConditions.ElementExists((By)DeleteCasesFromMoreOptions));
                        Thread.Sleep(2000);
                        driver.FindElement(DeleteCasesFromMoreOptions).Click();
                        Thread.Sleep(2000);
                        //Click delete on the overlay
                        wait.Until(ExpectedConditions.ElementExists((By)DeleteCasesOverlayBtn));
                        Thread.Sleep(2000);
                        driver.FindElement(DeleteCasesOverlayBtn).Click();
                        Thread.Sleep(10000);
                        wait.Until(ExpectedConditions.ElementExists((By)CustomerCasesTitle));
                        Cases++;
                        if (driver.FindElements(AnonOnCustomerHistory).Count() == 0)
                        {
                            Console.WriteLine("All cases removed");
                            break;
                        }
                    }
                    while (driver.FindElements(AnonOnCustomerHistory).Count() != 0);
                }
            }
            catch (Exception)
            {
                if (Cases == 0)
                {
                    Console.WriteLine("No cases were added to customer history");
                    Assert.Fail();
                }
            }
        }

        public void ImmediatelyResolveCaseOnBehalfOf()
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
            wait.Until(ExpectedConditions.ElementExists((By)Searchbox));
            Assert.IsTrue(driver.FindElement(Searchbox).Displayed);
            //Enter fullname in search
            driver.FindElement(Searchbox).Click();
            driver.FindElement(Searchbox).SendKeys("Gary Moore");
            driver.FindElement(Searchbox).SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            //Check result shows on the dropdown
            wait.Until(ExpectedConditions.ElementExists((By)ExistingCustomerSearchDropdown));
            driver.FindElement(OnBehalfOfInDropdown).Click();
            driver.FindElement(ExistingCustomerSearchDropdown).Click();
            Thread.Sleep(2000);
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
            wait.Until(ExpectedConditions.ElementExists((By)FAQSearchServiceResult));
            Assert.IsTrue(driver.FindElement(FAQSearchServiceResult).Displayed);
            driver.FindElement(FAQSearchServiceResult).Click();
            Thread.Sleep(2000);
            //Verify customer name and service shown on the create new case overlay
            driver.SwitchTo().DefaultContent();
            wait.Until(ExpectedConditions.ElementExists((By)TestNameOnNewCaseOverlay));
            Assert.IsTrue(driver.FindElement(TestNameOnNewCaseOverlay).Displayed);
            wait.Until(ExpectedConditions.ElementExists((By)ServiceOnNewCaseOverlay));
            Assert.IsTrue(driver.FindElement(ServiceOnNewCaseOverlay).Displayed);
            //Click yes on overlay
            wait.Until(ExpectedConditions.ElementExists((By)YesBtnOnNewCaseOverlay));
            driver.FindElement(YesBtnOnNewCaseOverlay).Click();
            Thread.Sleep(3000);
            //Verify dog fouling form loads
            wait.Until(ExpectedConditions.ElementExists((By)DogFoulingFormTitle));
            Assert.IsTrue(driver.FindElement(DogFoulingFormTitle).Displayed);
            //Click resolve button
            driver.SwitchTo().Frame("WebResource_allocatingpanel");
            wait.Until(ExpectedConditions.ElementExists((By)ResolveBtn));
            Thread.Sleep(2000);
            driver.FindElement(ResolveBtn).Click();
            Thread.Sleep(2000);
            //Select immediately resolve from dropdown
            wait.Until(ExpectedConditions.ElementExists((By)ResolveDropdown));
            driver.FindElement(ResolveDropdown).Click();
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)ImmediateleyResolveOption));
            driver.FindElement(ImmediateleyResolveOption).Click();
            Thread.Sleep(2000);
            //Click submit
            wait.Until(ExpectedConditions.ElementExists((By)StatusSubmitBtn));
            driver.FindElement(StatusSubmitBtn).Click();
            Thread.Sleep(2000);
            driver.SwitchTo().DefaultContent();
            //Verify case summary page loads
            wait.Until(ExpectedConditions.ElementExists((By)CustomerInfoTitleOnCaseSummary));
            Assert.IsTrue(driver.FindElement(CustomerInfoTitleOnCaseSummary).Displayed);
            //Verify SLA empty
            wait.Until(ExpectedConditions.ElementExists((By)EmptySLAOnCaseSummary));
            Assert.IsTrue(driver.FindElement(EmptySLAOnCaseSummary).Displayed);
            Thread.Sleep(2000);
            //Click refresh button
            var Status = 0;
            try
            {
                if (driver.FindElements(ResolvedJobStatus).Count() != 0)
                {
                    Console.WriteLine("Job status changed from in progress");
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                do
                {
                    driver.FindElement(RefreshButtonOnCaseDetails).Click();
                    Thread.Sleep(5000);
                    Status++;
                    if (driver.FindElements(ResolvedJobStatus).Count() != 0)
                    {
                        break;
                    }
                    else if (Status == 10)
                    {
                        Console.WriteLine("Job status not updated from in progress");
                        Assert.Fail();
                    }
                } while (driver.FindElements(ResolvedJobStatus).Count() == 0);
            }
            //Verify status updated to customer rejected
            wait.Until(ExpectedConditions.ElementExists((By)ResolvedJobStatus));
            Assert.IsTrue(driver.FindElement(ResolvedJobStatus).Displayed);
            Thread.Sleep(2000);
            //Select wakefield case from allocated case dropdown
            wait.Until(ExpectedConditions.ElementExists((By)AllocatedCaseForm));
            driver.FindElement(AllocatedCaseForm).Click();
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)AllocatedCaseDropdownWakefield));
            driver.FindElement(AllocatedCaseDropdownWakefield).Click();
            Thread.Sleep(2000);
            //Verify case details form loads
            wait.Until(ExpectedConditions.ElementExists((By)CaseDetailsForm));
            Assert.IsTrue(driver.FindElement(CaseDetailsForm).Displayed);
            Thread.Sleep(2000);
            //Verify last customer update shows resolved message
            wait.Until(ExpectedConditions.ElementExists((By)CaseDetailsResolvedUpdateMsg));
            Assert.IsTrue(driver.FindElement(CaseDetailsResolvedUpdateMsg).Displayed);
            Thread.Sleep(2000);
            //Verify status message shown on timeline
            wait.Until(ExpectedConditions.ElementExists((By)TimelineStatusClosed));
            Assert.IsTrue(driver.FindElement(TimelineStatusClosed).Displayed);
            Thread.Sleep(2000);
            //Click customer updates/history
            driver.FindElement(HistoryTabOnCustomer).Click();
            Thread.Sleep(2000);
            //Verify status updates shows the rejected status message
            wait.Until(ExpectedConditions.ElementExists((By)CustomerResolvedOnHistoryTab));
            Assert.IsTrue(driver.FindElement(CustomerResolvedOnHistoryTab).Displayed);
            Thread.Sleep(2000);
            //Click back to summary tab
            driver.FindElement(CaseDetailsSummaryTab).Click();
            Thread.Sleep(2000);
            //Click case form link on service details
            Assert.IsTrue(driver.FindElement(ServiceFormLink).Displayed);
            Thread.Sleep(2000);
            driver.FindElement(ServiceFormLink).Click();
            Thread.Sleep(2000);
            //Verify form loads
            wait.Until(ExpectedConditions.ElementExists((By)DogFoulingFormTitle));
            Assert.IsTrue(driver.FindElement(DogFoulingFormTitle).Displayed);
            Thread.Sleep(2000);
            //Verify message shows record is inactive
            wait.Until(ExpectedConditions.ElementExists((By)DogFoulingFormStatusInactive));
            Assert.IsTrue(driver.FindElement(DogFoulingFormStatusInactive).Displayed);
            Thread.Sleep(2000);
            //Click back button
            wait.Until(ExpectedConditions.ElementExists((By)BackBtn));
            driver.FindElement(BackBtn).Click();
            //Select reporters name
            action.SendKeys(Keys.PageDown).Build().Perform();
            wait.Until(ExpectedConditions.ElementExists((By)ReporterNameOnCaseSummary));
            driver.FindElement(ReporterNameOnCaseSummary).Click();
            Thread.Sleep(2000);
            //Verify case shows in the history tab
            wait.Until(ExpectedConditions.ElementExists((By)HistoryTabOnCustomer));
            driver.FindElement(HistoryTabOnCustomer).Click();
            Thread.Sleep(2000);
            action.SendKeys(Keys.PageDown).Build().Perform();
            wait.Until(ExpectedConditions.ElementExists((By)TestNameOnCustomerHistory));
            Assert.IsTrue(driver.FindElement(TestNameOnCustomerHistory).Displayed);
            //Click dashboards in LHN
            driver.FindElement(DashboardsLHN).Click();
            Thread.Sleep(2000);
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
            driver.FindElement(Searchbox).SendKeys("Gary Test");
            driver.FindElement(Searchbox).SendKeys(Keys.Enter);
            wait.Until(ExpectedConditions.ElementExists((By)GaryTestInDropdown));
            Assert.IsTrue(driver.FindElement(GaryTestInDropdown).Displayed);
            driver.FindElement(GaryTestInDropdown).Click();
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)GaryTestInAccessChannel));
            Assert.IsTrue(driver.FindElement(GaryTestInAccessChannel).Displayed);
            Thread.Sleep(2000);
            //Check result is shown under access channel after selecting from dropdown
            wait.Until(ExpectedConditions.ElementExists((By)TestUserSearchResult));
            Assert.IsTrue(driver.FindElement(TestUserSearchResult).Displayed);
            Thread.Sleep(5000);
            //Verify job status shows as resolved
            wait.Until(ExpectedConditions.ElementExists((By)CaseHistoryResolved));
            Assert.IsTrue(driver.FindElement(CaseHistoryResolved).Displayed);
            Thread.Sleep(2000);
            //Verify on behalf of asterisk is shown
            wait.Until(ExpectedConditions.ElementExists((By)CaseHistoryAsterisk));
            Assert.IsTrue(driver.FindElement(CaseHistoryAsterisk).Displayed);
            //Click customer name
            driver.FindElement(TestUserSearchResult).Click();
            Thread.Sleep(2000);
            driver.SwitchTo().DefaultContent();
            Thread.Sleep(2000);
            //Click history tab
            wait.Until(ExpectedConditions.ElementExists((By)HistoryTabOnCustomer));
            driver.FindElement(HistoryTabOnCustomer).Click();
            Thread.Sleep(2000);
            try
            {
                do
                {
                    //Click select all cases
                    wait.Until(ExpectedConditions.ElementExists((By)SelectAllCasesBtn));
                    Thread.Sleep(3000);
                    driver.FindElement(SelectAllCasesBtn).Click();
                    Thread.Sleep(2000);
                    //Click more options dots
                    wait.Until(ExpectedConditions.ElementExists((By)MoreOptionsDotsOnCustomerCases));
                    Thread.Sleep(2000);
                    driver.FindElement(MoreOptionsDotsOnCustomerCases).Click();
                    Thread.Sleep(2000);
                    //Click delete cases
                    wait.Until(ExpectedConditions.ElementExists((By)DeleteCasesFromMoreOptions));
                    Thread.Sleep(2000);
                    driver.FindElement(DeleteCasesFromMoreOptions).Click();
                    Thread.Sleep(2000);
                    //Click delete on the overlay
                    wait.Until(ExpectedConditions.ElementExists((By)DeleteCasesOverlayBtn));
                    Thread.Sleep(2000);
                    driver.FindElement(DeleteCasesOverlayBtn).Click();
                    Thread.Sleep(10000);
                    wait.Until(ExpectedConditions.ElementExists((By)CustomerCasesTitle));
                }
                while (driver.FindElement(TestNameOnCustomerHistory).Displayed);
            }
            catch (Exception)
            {
                Console.WriteLine("All cases removed from history screen");
            }
            //Verify cases deleted
            var Cases = 0;
            try
            {
                WebElement cases = (WebElement)driver.FindElement(TestNameOnCustomerHistory);
                if (cases.Displayed)
                {
                    Cases = 1;
                    Assert.Fail();
                }
            }
            catch (Exception)
            {
                if (Cases > 0)
                {
                    Console.WriteLine("Cases not removed");
                }
                else
                {
                    Console.WriteLine("Cases removed");
                }
            }
        }

        public void ImmediatelyResolveCaseBusiness()
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
            driver.FindElement(Searchbox).SendKeys("Test Cafe");
            driver.FindElement(Searchbox).SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            //Check result shows on the dropdown
            wait.Until(ExpectedConditions.ElementExists((By)ExistingBusinessSearchDropdown));
            Assert.IsTrue(driver.FindElement(ExistingBusinessSearchDropdown).Displayed);
            driver.FindElement(ExistingBusinessSearchDropdown).Click();
            Thread.Sleep(2000);
            //Check result is shown under access channel after selecting from dropdown
            wait.Until(ExpectedConditions.ElementExists((By)ExistingBusinessSearchResult));
            Assert.IsTrue(driver.FindElement(ExistingBusinessSearchResult).Displayed);
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
            wait.Until(ExpectedConditions.ElementExists((By)FAQSearchServiceResult));
            Assert.IsTrue(driver.FindElement(FAQSearchServiceResult).Displayed);
            driver.FindElement(FAQSearchServiceResult).Click();
            Thread.Sleep(2000);
            //Verify customer name and service shown on the create new case overlay
            driver.SwitchTo().DefaultContent();
            wait.Until(ExpectedConditions.ElementExists((By)BusinessNameOnNewCaseOverlay));
            Assert.IsTrue(driver.FindElement(BusinessNameOnNewCaseOverlay).Displayed);
            wait.Until(ExpectedConditions.ElementExists((By)ServiceOnNewCaseOverlay));
            //Click yes on overlay
            wait.Until(ExpectedConditions.ElementExists((By)YesBtnOnNewCaseOverlay));
            driver.FindElement(YesBtnOnNewCaseOverlay).Click();
            Thread.Sleep(3000);
            //Verify dog fouling form loads
            wait.Until(ExpectedConditions.ElementExists((By)DogFoulingFormTitle));
            Assert.IsTrue(driver.FindElement(DogFoulingFormTitle).Displayed);
            //Click resolve button
            driver.SwitchTo().Frame("WebResource_allocatingpanel");
            wait.Until(ExpectedConditions.ElementExists((By)ResolveBtn));
            Thread.Sleep(2000);
            driver.FindElement(ResolveBtn).Click();
            Thread.Sleep(2000);
            //Select immediately resolve from dropdown
            wait.Until(ExpectedConditions.ElementExists((By)ResolveDropdown));
            driver.FindElement(ResolveDropdown).Click();
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)ImmediateleyResolveOption));
            driver.FindElement(ImmediateleyResolveOption).Click();
            Thread.Sleep(2000);
            //Click submit
            wait.Until(ExpectedConditions.ElementExists((By)StatusSubmitBtn));
            driver.FindElement(StatusSubmitBtn).Click();
            Thread.Sleep(2000);
            driver.SwitchTo().DefaultContent();
            //Verify case summary page loads
            wait.Until(ExpectedConditions.ElementExists((By)CustomerInfoTitleOnCaseSummary));
            Assert.IsTrue(driver.FindElement(CustomerInfoTitleOnCaseSummary).Displayed);
            //Verify SLA empty
            wait.Until(ExpectedConditions.ElementExists((By)EmptySLAOnCaseSummary));
            Assert.IsTrue(driver.FindElement(EmptySLAOnCaseSummary).Displayed);
            Thread.Sleep(2000);
            //Click refresh button
            var Status = 0;
            try
            {
                if (driver.FindElements(ResolvedJobStatus).Count() != 0)
                {
                    Console.WriteLine("Job status changed from in progress");
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                do
                {
                    driver.FindElement(RefreshButtonOnCaseDetails).Click();
                    Thread.Sleep(5000);
                    Status++;
                    if (driver.FindElements(ResolvedJobStatus).Count() != 0)
                    {
                        break;
                    }
                    else if (Status == 10)
                    {
                        Console.WriteLine("Job status not updated from in progress");
                        Assert.Fail();
                    }
                } while (driver.FindElements(ResolvedJobStatus).Count() == 0);
            }
            //Verify status updated to customer rejected
            wait.Until(ExpectedConditions.ElementExists((By)ResolvedJobStatus));
            Assert.IsTrue(driver.FindElement(ResolvedJobStatus).Displayed);
            Thread.Sleep(2000);
            //Select wakefield case from allocated case dropdown
            wait.Until(ExpectedConditions.ElementExists((By)AllocatedCaseForm));
            driver.FindElement(AllocatedCaseForm).Click();
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)AllocatedCaseDropdownWakefield));
            driver.FindElement(AllocatedCaseDropdownWakefield).Click();
            Thread.Sleep(2000);
            //Verify case details form loads
            wait.Until(ExpectedConditions.ElementExists((By)CaseDetailsForm));
            Assert.IsTrue(driver.FindElement(CaseDetailsForm).Displayed);
            Thread.Sleep(2000);
            //Verify last customer update shows resolved message
            wait.Until(ExpectedConditions.ElementExists((By)CaseDetailsResolvedUpdateMsg));
            Assert.IsTrue(driver.FindElement(CaseDetailsResolvedUpdateMsg).Displayed);
            Thread.Sleep(2000);
            //Verify status message shown on timeline
            wait.Until(ExpectedConditions.ElementExists((By)TimelineStatusClosed));
            Assert.IsTrue(driver.FindElement(TimelineStatusClosed).Displayed);
            Thread.Sleep(2000);
            //Click customer updates/history
            driver.FindElement(HistoryTabOnCustomer).Click();
            Thread.Sleep(2000);
            //Verify status updates shows the rejected status message
            wait.Until(ExpectedConditions.ElementExists((By)CustomerResolvedOnHistoryTab));
            Assert.IsTrue(driver.FindElement(CustomerResolvedOnHistoryTab).Displayed);
            Thread.Sleep(2000);
            //Click back to summary tab
            driver.FindElement(CaseDetailsSummaryTab).Click();
            Thread.Sleep(2000);
            //Click case form link on service details
            Assert.IsTrue(driver.FindElement(ServiceFormLink).Displayed);
            Thread.Sleep(2000);
            driver.FindElement(ServiceFormLink).Click();
            Thread.Sleep(2000);
            //Verify form loads
            wait.Until(ExpectedConditions.ElementExists((By)DogFoulingFormTitle));
            Assert.IsTrue(driver.FindElement(DogFoulingFormTitle).Displayed);
            Thread.Sleep(2000);
            //Verify message shows record is inactive
            wait.Until(ExpectedConditions.ElementExists((By)DogFoulingFormStatusInactive));
            Assert.IsTrue(driver.FindElement(DogFoulingFormStatusInactive).Displayed);
            Thread.Sleep(2000);
            //Click dashboards in LHN
            driver.FindElement(DashboardsLHN).Click();
            Thread.Sleep(2000);
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
            driver.FindElement(Searchbox).SendKeys("Test Cafe");
            driver.FindElement(Searchbox).SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            //Check result shows on the dropdown
            wait.Until(ExpectedConditions.ElementExists((By)ExistingBusinessSearchDropdown));
            Assert.IsTrue(driver.FindElement(ExistingBusinessSearchDropdown).Displayed);
            driver.FindElement(ExistingBusinessSearchDropdown).Click();
            Thread.Sleep(2000);
            //Check result is shown under access channel after selecting from dropdown
            wait.Until(ExpectedConditions.ElementExists((By)ExistingBusinessSearchResult));
            Assert.IsTrue(driver.FindElement(ExistingBusinessSearchResult).Displayed);
            Thread.Sleep(5000);
            //Verify job status shows as resolved
            wait.Until(ExpectedConditions.ElementExists((By)CaseHistoryResolved));
            Assert.IsTrue(driver.FindElement(CaseHistoryResolved).Displayed);
            Thread.Sleep(2000);
            //Click customer name
            driver.FindElement(ExistingBusinessSearchResult).Click();
            Thread.Sleep(2000);
            driver.SwitchTo().DefaultContent();
            Thread.Sleep(2000);
            //Click history tab
            driver.FindElement(HistoryTabOnCustomer).Click();
            Thread.Sleep(2000);
            Actions action = new Actions(driver);
            action.SendKeys(Keys.PageDown).Build().Perform();
            var Cases = 0;
            try
            {
                if (driver.FindElements(BusinessNameOnCustomerHistory).Count() != 0)
                    Console.WriteLine("Cases present on customer history");
                {
                    do
                    {
                        //Click select all cases
                        wait.Until(ExpectedConditions.ElementExists((By)SelectAllCasesBtn));
                        Thread.Sleep(3000);
                        driver.FindElement(SelectAllCasesBtn).Click();
                        Thread.Sleep(2000);
                        //Click more options dots
                        wait.Until(ExpectedConditions.ElementExists((By)MoreOptionsDotsOnCustomerCases));
                        Thread.Sleep(2000);
                        driver.FindElement(MoreOptionsDotsOnCustomerCases).Click();
                        Thread.Sleep(2000);
                        //Click delete cases
                        wait.Until(ExpectedConditions.ElementExists((By)DeleteCasesFromMoreOptions));
                        Thread.Sleep(2000);
                        driver.FindElement(DeleteCasesFromMoreOptions).Click();
                        Thread.Sleep(2000);
                        //Click delete on the overlay
                        wait.Until(ExpectedConditions.ElementExists((By)DeleteCasesOverlayBtn));
                        Thread.Sleep(2000);
                        driver.FindElement(DeleteCasesOverlayBtn).Click();
                        Thread.Sleep(10000);
                        wait.Until(ExpectedConditions.ElementExists((By)CustomerCasesTitle));
                        Cases++;
                        if (driver.FindElements(BusinessNameOnCustomerHistory).Count() == 0)
                        {
                            Console.WriteLine("All cases removed");
                            break;
                        }
                    }
                    while (driver.FindElements(BusinessNameOnCustomerHistory).Count() != 0);
                }
            }
            catch (Exception)
            {
                if (Cases == 0)
                {
                    Console.WriteLine("No cases were added to customer history");
                    Assert.Fail();
                }
            }
        }

        public void ImmediatelyResolveCaseBusinessUA()
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
            driver.FindElement(Searchbox).SendKeys("Unknown Business");
            driver.FindElement(Searchbox).SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            //Check result shows on the dropdown
            wait.Until(ExpectedConditions.ElementExists((By)UABusinessSearchDropdown));
            Assert.IsTrue(driver.FindElement(UABusinessSearchDropdown).Displayed);
            driver.FindElement(UABusinessSearchDropdown).Click();
            Thread.Sleep(2000);
            //Check result is shown under access channel after selecting from dropdown
            wait.Until(ExpectedConditions.ElementExists((By)UABusinessSearchResult));
            Assert.IsTrue(driver.FindElement(UABusinessSearchResult).Displayed);
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
            wait.Until(ExpectedConditions.ElementExists((By)FAQSearchServiceResult));
            Assert.IsTrue(driver.FindElement(FAQSearchServiceResult).Displayed);
            driver.FindElement(FAQSearchServiceResult).Click();
            Thread.Sleep(2000);
            //Verify customer name and service shown on the create new case overlay
            driver.SwitchTo().DefaultContent();
            wait.Until(ExpectedConditions.ElementExists((By)UABusinessOnNewCaseOverlay));
            Assert.IsTrue(driver.FindElement(UABusinessOnNewCaseOverlay).Displayed);
            wait.Until(ExpectedConditions.ElementExists((By)ServiceOnNewCaseOverlay));
            Assert.IsTrue(driver.FindElement(ServiceOnNewCaseOverlay).Displayed);
            //Click yes on overlay
            wait.Until(ExpectedConditions.ElementExists((By)YesBtnOnNewCaseOverlay));
            driver.FindElement(YesBtnOnNewCaseOverlay).Click();
            Thread.Sleep(3000);
            //Verify dog fouling form loads
            wait.Until(ExpectedConditions.ElementExists((By)DogFoulingFormTitle));
            Assert.IsTrue(driver.FindElement(DogFoulingFormTitle).Displayed);
            //Click resolve button
            driver.SwitchTo().Frame("WebResource_allocatingpanel");
            wait.Until(ExpectedConditions.ElementExists((By)ResolveBtn));
            Thread.Sleep(2000);
            driver.FindElement(ResolveBtn).Click();
            Thread.Sleep(2000);
            //Select immediately resolve from dropdown
            wait.Until(ExpectedConditions.ElementExists((By)ResolveDropdown));
            driver.FindElement(ResolveDropdown).Click();
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)ImmediateleyResolveOption));
            driver.FindElement(ImmediateleyResolveOption).Click();
            Thread.Sleep(2000);
            //Click submit
            wait.Until(ExpectedConditions.ElementExists((By)StatusSubmitBtn));
            driver.FindElement(StatusSubmitBtn).Click();
            Thread.Sleep(2000);
            driver.SwitchTo().DefaultContent();
            //Verify case summary page loads
            wait.Until(ExpectedConditions.ElementExists((By)CustomerInfoTitleOnCaseSummary));
            Assert.IsTrue(driver.FindElement(CustomerInfoTitleOnCaseSummary).Displayed);
            //Verify SLA empty
            wait.Until(ExpectedConditions.ElementExists((By)EmptySLAOnCaseSummary));
            Assert.IsTrue(driver.FindElement(EmptySLAOnCaseSummary).Displayed);
            Thread.Sleep(2000);
            //Click refresh button
            var Status = 0;
            try
            {
                if (driver.FindElements(ResolvedJobStatus).Count() != 0)
                {
                    Console.WriteLine("Job status changed from in progress");
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                do
                {
                    driver.FindElement(RefreshButtonOnCaseDetails).Click();
                    Thread.Sleep(5000);
                    Status++;
                    if (driver.FindElements(ResolvedJobStatus).Count() != 0)
                    {
                        break;
                    }
                    else if (Status == 10)
                    {
                        Console.WriteLine("Job status not updated from in progress");
                        Assert.Fail();
                    }
                } while (driver.FindElements(ResolvedJobStatus).Count() == 0);
            }
            //Verify status updated to customer rejected
            wait.Until(ExpectedConditions.ElementExists((By)ResolvedJobStatus));
            Assert.IsTrue(driver.FindElement(ResolvedJobStatus).Displayed);
            Thread.Sleep(2000);
            //Select wakefield case from allocated case dropdown
            wait.Until(ExpectedConditions.ElementExists((By)AllocatedCaseForm));
            driver.FindElement(AllocatedCaseForm).Click();
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)AllocatedCaseDropdownWakefield));
            driver.FindElement(AllocatedCaseDropdownWakefield).Click();
            Thread.Sleep(2000);
            //Verify case details form loads
            wait.Until(ExpectedConditions.ElementExists((By)CaseDetailsForm));
            Assert.IsTrue(driver.FindElement(CaseDetailsForm).Displayed);
            Thread.Sleep(2000);
            //Verify last customer update shows resolved message
            wait.Until(ExpectedConditions.ElementExists((By)CaseDetailsResolvedUpdateMsg));
            Assert.IsTrue(driver.FindElement(CaseDetailsResolvedUpdateMsg).Displayed);
            Thread.Sleep(2000);
            //Verify status message shown on timeline
            wait.Until(ExpectedConditions.ElementExists((By)TimelineStatusClosed));
            Assert.IsTrue(driver.FindElement(TimelineStatusClosed).Displayed);
            Thread.Sleep(2000);
            //Click customer updates/history
            driver.FindElement(HistoryTabOnCustomer).Click();
            Thread.Sleep(2000);
            //Verify status updates shows the rejected status message
            wait.Until(ExpectedConditions.ElementExists((By)CustomerResolvedOnHistoryTab));
            Assert.IsTrue(driver.FindElement(CustomerResolvedOnHistoryTab).Displayed);
            Thread.Sleep(2000);
            //Click back to summary tab
            driver.FindElement(CaseDetailsSummaryTab).Click();
            Thread.Sleep(2000);
            //Click case form link on service details
            Assert.IsTrue(driver.FindElement(ServiceFormLink).Displayed);
            Thread.Sleep(2000);
            driver.FindElement(ServiceFormLink).Click();
            Thread.Sleep(2000);
            //Verify form loads
            wait.Until(ExpectedConditions.ElementExists((By)DogFoulingFormTitle));
            Assert.IsTrue(driver.FindElement(DogFoulingFormTitle).Displayed);
            Thread.Sleep(2000);
            //Verify message shows record is inactive
            wait.Until(ExpectedConditions.ElementExists((By)DogFoulingFormStatusInactive));
            Assert.IsTrue(driver.FindElement(DogFoulingFormStatusInactive).Displayed);
            Thread.Sleep(2000);
            //Click dashboards in LHN
            driver.FindElement(DashboardsLHN).Click();
            Thread.Sleep(2000);
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
            driver.FindElement(Searchbox).SendKeys("Unknown Business");
            driver.FindElement(Searchbox).SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            //Check result shows on the dropdown
            wait.Until(ExpectedConditions.ElementExists((By)UABusinessSearchDropdown));
            Assert.IsTrue(driver.FindElement(UABusinessSearchDropdown).Displayed);
            driver.FindElement(UABusinessSearchDropdown).Click();
            Thread.Sleep(2000);
            //Check result is shown under access channel after selecting from dropdown
            wait.Until(ExpectedConditions.ElementExists((By)UABusinessSearchResult));
            Assert.IsTrue(driver.FindElement(UABusinessSearchResult).Displayed);
            Thread.Sleep(5000);
            //Verify job status shows as resolved
            wait.Until(ExpectedConditions.ElementExists((By)CaseHistoryResolved));
            Assert.IsTrue(driver.FindElement(CaseHistoryResolved).Displayed);
            Thread.Sleep(2000);
            //Click customer name
            driver.FindElement(UABusinessSearchResult).Click();
            Thread.Sleep(2000);
            driver.SwitchTo().DefaultContent();
            Thread.Sleep(2000);
            //Click history tab
            driver.FindElement(HistoryTabOnCustomer).Click();
            Thread.Sleep(2000);
            Actions action = new Actions(driver);
            action.SendKeys(Keys.PageDown).Build().Perform();
            var Cases = 0;
            try
            {
                if (driver.FindElements(UABusinessOnCustomerHistory).Count() != 0)
                    Console.WriteLine("Cases present on customer history");
                {
                    do
                    {
                        //Click select all cases
                        wait.Until(ExpectedConditions.ElementExists((By)SelectAllCasesBtn));
                        Thread.Sleep(3000);
                        driver.FindElement(SelectAllCasesBtn).Click();
                        Thread.Sleep(2000);
                        //Click more options dots
                        wait.Until(ExpectedConditions.ElementExists((By)MoreOptionsDotsOnCustomerCases));
                        Thread.Sleep(2000);
                        driver.FindElement(MoreOptionsDotsOnCustomerCases).Click();
                        Thread.Sleep(2000);
                        //Click delete cases
                        wait.Until(ExpectedConditions.ElementExists((By)DeleteCasesFromMoreOptions));
                        Thread.Sleep(2000);
                        driver.FindElement(DeleteCasesFromMoreOptions).Click();
                        Thread.Sleep(2000);
                        //Click delete on the overlay
                        wait.Until(ExpectedConditions.ElementExists((By)DeleteCasesOverlayBtn));
                        Thread.Sleep(2000);
                        driver.FindElement(DeleteCasesOverlayBtn).Click();
                        Thread.Sleep(10000);
                        wait.Until(ExpectedConditions.ElementExists((By)CustomerCasesTitle));
                        Cases++;
                        if (driver.FindElements(UABusinessOnCustomerHistory).Count() == 0)
                        {
                            Console.WriteLine("All cases removed");
                            break;
                        }
                    }
                    while (driver.FindElements(UABusinessOnCustomerHistory).Count() != 0);
                }
            }
            catch (Exception)
            {
                if (Cases == 0)
                {
                    Console.WriteLine("No cases were added to customer history");
                    Assert.Fail();
                }
            }
        }

        public void ImmediatelyResolveCaseOnBehalfOfBusiness()
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
            wait.Until(ExpectedConditions.ElementExists((By)Searchbox));
            Assert.IsTrue(driver.FindElement(Searchbox).Displayed);
            //Enter fullname in search
            driver.FindElement(Searchbox).Click();
            driver.FindElement(Searchbox).SendKeys("Test Business");
            driver.FindElement(Searchbox).SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            //Check result shows on the dropdown
            wait.Until(ExpectedConditions.ElementExists((By)TestBusinessInDropdown));
            driver.FindElement(OnBehalfOfInDropdown).Click();
            driver.FindElement(TestBusinessInDropdown).Click();
            Thread.Sleep(2000);
            //Remove search term from box
            driver.FindElement(Searchbox).Click();
            Actions action = new Actions(driver);
            WebElement ele = (WebElement)driver.FindElement(Searchbox);
            action.Click(ele).Click(ele).Click(ele).Perform();
            driver.FindElement(Searchbox).SendKeys(Keys.Delete);
            //Search for different customer
            Thread.Sleep(2000);
            driver.FindElement(Searchbox).SendKeys("Test cafe");
            driver.FindElement(Searchbox).SendKeys(Keys.Enter);
            wait.Until(ExpectedConditions.ElementExists((By)ExistingBusinessSearchDropdown));
            Assert.IsTrue(driver.FindElement(ExistingBusinessSearchDropdown).Displayed);
            driver.FindElement(ExistingBusinessSearchDropdown).Click();
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)ExistingBusinessSearchResult));
            Assert.IsTrue(driver.FindElement(ExistingBusinessSearchResult).Displayed);
            Thread.Sleep(2000);
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
            wait.Until(ExpectedConditions.ElementExists((By)FAQSearchServiceResult));
            Assert.IsTrue(driver.FindElement(FAQSearchServiceResult).Displayed);
            driver.FindElement(FAQSearchServiceResult).Click();
            Thread.Sleep(2000);
            //Verify customer name and service shown on the create new case overlay
            driver.SwitchTo().DefaultContent();
            wait.Until(ExpectedConditions.ElementExists((By)BusinessNameOnNewCaseOverlay));
            Assert.IsTrue(driver.FindElement(BusinessNameOnNewCaseOverlay).Displayed);
            wait.Until(ExpectedConditions.ElementExists((By)ServiceOnNewCaseOverlay));
            Assert.IsTrue(driver.FindElement(ServiceOnNewCaseOverlay).Displayed);
            //Click yes on overlay
            wait.Until(ExpectedConditions.ElementExists((By)YesBtnOnNewCaseOverlay));
            driver.FindElement(YesBtnOnNewCaseOverlay).Click();
            Thread.Sleep(3000);
            //Verify dog fouling form loads
            wait.Until(ExpectedConditions.ElementExists((By)DogFoulingFormTitle));
            Assert.IsTrue(driver.FindElement(DogFoulingFormTitle).Displayed);
            //Click resolve button
            driver.SwitchTo().Frame("WebResource_allocatingpanel");
            wait.Until(ExpectedConditions.ElementExists((By)ResolveBtn));
            Thread.Sleep(2000);
            driver.FindElement(ResolveBtn).Click();
            Thread.Sleep(2000);
            //Select immediately resolve from dropdown
            wait.Until(ExpectedConditions.ElementExists((By)ResolveDropdown));
            driver.FindElement(ResolveDropdown).Click();
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)ImmediateleyResolveOption));
            driver.FindElement(ImmediateleyResolveOption).Click();
            Thread.Sleep(2000);
            //Click submit
            wait.Until(ExpectedConditions.ElementExists((By)StatusSubmitBtn));
            driver.FindElement(StatusSubmitBtn).Click();
            Thread.Sleep(2000);
            driver.SwitchTo().DefaultContent();
            //Verify case summary page loads
            wait.Until(ExpectedConditions.ElementExists((By)CustomerInfoTitleOnCaseSummary));
            Assert.IsTrue(driver.FindElement(CustomerInfoTitleOnCaseSummary).Displayed);
            //Verify SLA empty
            wait.Until(ExpectedConditions.ElementExists((By)EmptySLAOnCaseSummary));
            Assert.IsTrue(driver.FindElement(EmptySLAOnCaseSummary).Displayed);
            Thread.Sleep(2000);
            //Click refresh button
            var Status = 0;
            try
            {
                if (driver.FindElements(ResolvedJobStatus).Count() != 0)
                {
                    Console.WriteLine("Job status changed from in progress");
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                do
                {
                    driver.FindElement(RefreshButtonOnCaseDetails).Click();
                    Thread.Sleep(5000);
                    Status++;
                    if (driver.FindElements(ResolvedJobStatus).Count() != 0)
                    {
                        break;
                    }
                    else if (Status == 10)
                    {
                        Console.WriteLine("Job status not updated from in progress");
                        Assert.Fail();
                    }
                } while (driver.FindElements(ResolvedJobStatus).Count() == 0);
            }
            //Verify status updated to customer rejected
            wait.Until(ExpectedConditions.ElementExists((By)ResolvedJobStatus));
            Assert.IsTrue(driver.FindElement(ResolvedJobStatus).Displayed);
            Thread.Sleep(2000);
            //Select wakefield case from allocated case dropdown
            wait.Until(ExpectedConditions.ElementExists((By)AllocatedCaseForm));
            driver.FindElement(AllocatedCaseForm).Click();
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)AllocatedCaseDropdownWakefield));
            driver.FindElement(AllocatedCaseDropdownWakefield).Click();
            Thread.Sleep(2000);
            //Verify case details form loads
            wait.Until(ExpectedConditions.ElementExists((By)CaseDetailsForm));
            Assert.IsTrue(driver.FindElement(CaseDetailsForm).Displayed);
            Thread.Sleep(2000);
            //Verify last customer update shows resolved message
            wait.Until(ExpectedConditions.ElementExists((By)CaseDetailsResolvedUpdateMsg));
            Assert.IsTrue(driver.FindElement(CaseDetailsResolvedUpdateMsg).Displayed);
            Thread.Sleep(2000);
            //Verify status message shown on timeline
            wait.Until(ExpectedConditions.ElementExists((By)TimelineStatusClosed));
            Assert.IsTrue(driver.FindElement(TimelineStatusClosed).Displayed);
            Thread.Sleep(2000);
            //Click customer updates/history
            driver.FindElement(HistoryTabOnCustomer).Click();
            Thread.Sleep(2000);
            //Verify status updates shows the rejected status message
            wait.Until(ExpectedConditions.ElementExists((By)CustomerResolvedOnHistoryTab));
            Assert.IsTrue(driver.FindElement(CustomerResolvedOnHistoryTab).Displayed);
            Thread.Sleep(2000);
            //Click back to summary tab
            driver.FindElement(CaseDetailsSummaryTab).Click();
            Thread.Sleep(2000);
            //Click case form link on service details
            Assert.IsTrue(driver.FindElement(ServiceFormLink).Displayed);
            Thread.Sleep(2000);
            driver.FindElement(ServiceFormLink).Click();
            Thread.Sleep(2000);
            //Verify form loads
            wait.Until(ExpectedConditions.ElementExists((By)DogFoulingFormTitle));
            Assert.IsTrue(driver.FindElement(DogFoulingFormTitle).Displayed);
            Thread.Sleep(2000);
            //Verify message shows record is inactive
            wait.Until(ExpectedConditions.ElementExists((By)DogFoulingFormStatusInactive));
            Assert.IsTrue(driver.FindElement(DogFoulingFormStatusInactive).Displayed);
            Thread.Sleep(2000);
            //Click back button
            wait.Until(ExpectedConditions.ElementExists((By)BackBtn));
            driver.FindElement(BackBtn).Click();
            //Select reporters name
            action.SendKeys(Keys.PageDown).Build().Perform();
            wait.Until(ExpectedConditions.ElementExists((By)ReporterBusinessOnCaseSummary));
            driver.FindElement(ReporterBusinessOnCaseSummary).Click();
            Thread.Sleep(2000);
            //Verify case shows in the history tab
            wait.Until(ExpectedConditions.ElementExists((By)HistoryTabOnCustomer));
            driver.FindElement(HistoryTabOnCustomer).Click();
            Thread.Sleep(2000);
            action.SendKeys(Keys.PageDown).Build().Perform();
            wait.Until(ExpectedConditions.ElementExists((By)TestBusinessOnCustomerHistory));
            Assert.IsTrue(driver.FindElement(TestBusinessOnCustomerHistory).Displayed);
            //Click dashboards in LHN
            driver.FindElement(DashboardsLHN).Click();
            Thread.Sleep(2000);
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
            driver.FindElement(Searchbox).SendKeys("Test Business");
            driver.FindElement(Searchbox).SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            //Check result shows on the dropdown
            wait.Until(ExpectedConditions.ElementExists((By)TestBusinessInDropdown));
            driver.FindElement(TestBusinessInDropdown).Click();
            Thread.Sleep(2000);
            //Check result is shown under access channel after selecting from dropdown
            wait.Until(ExpectedConditions.ElementExists((By)TestBusinessInAccessChannel));
            Assert.IsTrue(driver.FindElement(TestBusinessInAccessChannel).Displayed);
            Thread.Sleep(5000);
            //Verify job status shows as resolved
            wait.Until(ExpectedConditions.ElementExists((By)CaseHistoryResolved));
            Assert.IsTrue(driver.FindElement(CaseHistoryResolved).Displayed);
            Thread.Sleep(2000);
            //Verify on behalf of asterisk is shown
            wait.Until(ExpectedConditions.ElementExists((By)CaseHistoryAsterisk));
            Assert.IsTrue(driver.FindElement(CaseHistoryAsterisk).Displayed);
            //Click customer name
            driver.FindElement(TestBusinessInAccessChannel).Click();
            Thread.Sleep(2000);
            driver.SwitchTo().DefaultContent();
            Thread.Sleep(2000);
            //Click history tab
            wait.Until(ExpectedConditions.ElementExists((By)HistoryTabOnCustomer));
            driver.FindElement(HistoryTabOnCustomer).Click();
            Thread.Sleep(2000);
            try
            {
                do
                {
                    //Click select all cases
                    wait.Until(ExpectedConditions.ElementExists((By)SelectAllCasesBtn));
                    Thread.Sleep(3000);
                    driver.FindElement(SelectAllCasesBtn).Click();
                    Thread.Sleep(2000);
                    //Click more options dots
                    wait.Until(ExpectedConditions.ElementExists((By)MoreOptionsDotsOnCustomerCases));
                    Thread.Sleep(2000);
                    driver.FindElement(MoreOptionsDotsOnCustomerCases).Click();
                    Thread.Sleep(2000);
                    //Click delete cases
                    wait.Until(ExpectedConditions.ElementExists((By)DeleteCasesFromMoreOptions));
                    Thread.Sleep(2000);
                    driver.FindElement(DeleteCasesFromMoreOptions).Click();
                    Thread.Sleep(2000);
                    //Click delete on the overlay
                    wait.Until(ExpectedConditions.ElementExists((By)DeleteCasesOverlayBtn));
                    Thread.Sleep(2000);
                    driver.FindElement(DeleteCasesOverlayBtn).Click();
                    Thread.Sleep(10000);
                    wait.Until(ExpectedConditions.ElementExists((By)CustomerCasesTitle));
                }
                while (driver.FindElement(TestBusinessOnCustomerHistory).Displayed);
            }
            catch (Exception)
            {
                Console.WriteLine("All cases removed from history screen");
            }
            //Verify cases deleted
            var Cases = 0;
            try
            {
                WebElement cases = (WebElement)driver.FindElement(TestBusinessOnCustomerHistory);
                if (cases.Displayed)
                {
                    Cases = 1;
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                if (Cases > 0)
                {
                    Console.WriteLine("Cases not removed");
                }
                else
                {
                    Console.WriteLine("Cases removed");
                }
            }
        }

        public void SignPostCase()
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
            driver.FindElement(Searchbox).SendKeys("Gary Test");
            driver.FindElement(Searchbox).SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            //Check result shows on the dropdown
            wait.Until(ExpectedConditions.ElementExists((By)TestUserDetailsOnDropdown));
            Assert.IsTrue(driver.FindElement(TestUserDetailsOnDropdown).Displayed);
            driver.FindElement(TestUserDetailsOnDropdown).Click();
            Thread.Sleep(2000);
            //Check result is shown under access channel after selecting from dropdown
            wait.Until(ExpectedConditions.ElementExists((By)TestUserSearchResult));
            Assert.IsTrue(driver.FindElement(TestUserSearchResult).Displayed);
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
            wait.Until(ExpectedConditions.ElementExists((By)FAQSearchServiceResult));
            Assert.IsTrue(driver.FindElement(FAQSearchServiceResult).Displayed);
            driver.FindElement(FAQSearchServiceResult).Click();
            Thread.Sleep(2000);
            //Verify customer name and service shown on the create new case overlay
            driver.SwitchTo().DefaultContent();
            wait.Until(ExpectedConditions.ElementExists((By)TestNameOnNewCaseOverlay));
            Assert.IsTrue(driver.FindElement(TestNameOnNewCaseOverlay).Displayed);
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
            //Select private land
            Actions actions = new Actions(driver);
            actions.SendKeys(Keys.PageDown).Build().Perform();
            Thread.Sleep(2000);
            driver.FindElement(DogFoulingLandType).Click();
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)DogFoulingLandPrivate));
            driver.FindElement(DogFoulingLandPrivate).Click();
            Thread.Sleep(2000);
            driver.FindElement(DogFoulingLandType).Click();
            Thread.Sleep(2000);
            //Click signpost
            driver.SwitchTo().Frame("WebResource_allocatingpanel");
            wait.Until(ExpectedConditions.ElementExists((By)SignpostBtn));
            Thread.Sleep(2000);
            driver.FindElement(SignpostBtn).Click();
            Thread.Sleep(2000);
            //Select bespoke signposting from dropdown
            wait.Until(ExpectedConditions.ElementExists((By)ResolveDropdown));
            driver.FindElement(ResolveDropdown).Click();
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)BespokeSignposting));
            driver.FindElement(BespokeSignposting).Click();
            Thread.Sleep(2000);
            //Enter text in to text box
            wait.Until(ExpectedConditions.ElementExists((By)BespokeSignpostingTextBox));
            driver.FindElement(BespokeSignpostingTextBox).Click();
            Thread.Sleep(2000);
            driver.FindElement(BespokeSignpostingTextBox).SendKeys("This is a signpost message");
            Thread.Sleep(2000);
            //Click submit
            wait.Until(ExpectedConditions.ElementExists((By)StatusSubmitBtn));
            driver.FindElement(StatusSubmitBtn).Click();
            Thread.Sleep(2000);
            driver.SwitchTo().DefaultContent();
            //Verify case summary page loads
            wait.Until(ExpectedConditions.ElementExists((By)CustomerInfoTitleOnCaseSummary));
            Assert.IsTrue(driver.FindElement(CustomerInfoTitleOnCaseSummary).Displayed);
            //Verify SLA empty
            wait.Until(ExpectedConditions.ElementExists((By)EmptySLAOnCaseSummary));
            Assert.IsTrue(driver.FindElement(EmptySLAOnCaseSummary).Displayed);
            Thread.Sleep(2000);
            //Click refresh button
            var Status = 0;
            try
            {
                if (driver.FindElements(SignpostedJobStatus).Count() != 0)
                {
                    Console.WriteLine("Job status changed from in progress");
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                do
                {
                    driver.FindElement(RefreshButtonOnCaseDetails).Click();
                    Thread.Sleep(5000);
                    Status++;
                    if (driver.FindElements(SignpostedJobStatus).Count() != 0)
                    {
                        break;
                    }
                    else if (Status == 10)
                    {
                        Console.WriteLine("Job status not updated from in progress");
                        Assert.Fail();
                    }
                } while (driver.FindElements(SignpostedJobStatus).Count() == 0);
            }
            //Verify status updated to signposted
            wait.Until(ExpectedConditions.ElementExists((By)SignpostedJobStatus));
            Assert.IsTrue(driver.FindElement(SignpostedJobStatus).Displayed);
            Thread.Sleep(2000);
            //Select wakefield case from allocated case dropdown
            wait.Until(ExpectedConditions.ElementExists((By)AllocatedCaseForm));
            driver.FindElement(AllocatedCaseForm).Click();
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)AllocatedCaseDropdownWakefield));
            driver.FindElement(AllocatedCaseDropdownWakefield).Click();
            Thread.Sleep(2000);
            //Verify case details form loads
            wait.Until(ExpectedConditions.ElementExists((By)CaseDetailsForm));
            Assert.IsTrue(driver.FindElement(CaseDetailsForm).Displayed);
            Thread.Sleep(2000);
            //Verify last customer update shows no message
            wait.Until(ExpectedConditions.ElementExists((By)StatusUpdateAdded));
            Assert.IsFalse(driver.FindElement(StatusUpdateAdded).Text.Equals("This is a signpost message"));
            Thread.Sleep(2000);
            //Verify status message shown on timeline
            wait.Until(ExpectedConditions.ElementExists((By)TimelineStatusClosed));
            Assert.IsTrue(driver.FindElement(TimelineStatusClosed).Displayed);
            Thread.Sleep(2000);
            //Click customer updates/history
            driver.FindElement(HistoryTabOnCustomer).Click();
            Thread.Sleep(2000);
            //Verify bespoke message is shown
            wait.Until(ExpectedConditions.ElementExists((By)BespokeMsgOnHistoryTab));
            Assert.IsTrue(driver.FindElement(BespokeMsgOnHistoryTab).Displayed);
            Thread.Sleep(2000);
            //Click back to summary tab
            driver.FindElement(CaseDetailsSummaryTab).Click();
            Thread.Sleep(2000);
            //Click case form link on service details
            Assert.IsTrue(driver.FindElement(ServiceFormLink).Displayed);
            Thread.Sleep(2000);
            driver.FindElement(ServiceFormLink).Click();
            Thread.Sleep(2000);
            //Verify form loads
            wait.Until(ExpectedConditions.ElementExists((By)DogFoulingFormTitle));
            Assert.IsTrue(driver.FindElement(DogFoulingFormTitle).Displayed);
            Thread.Sleep(2000);
            //Verify message shows record is inactive
            wait.Until(ExpectedConditions.ElementExists((By)DogFoulingFormStatusInactive));
            Assert.IsTrue(driver.FindElement(DogFoulingFormStatusInactive).Displayed);
            Thread.Sleep(2000);
            //Click dashboards in LHN
            driver.FindElement(DashboardsLHN).Click();
            Thread.Sleep(2000);
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
            driver.FindElement(Searchbox).SendKeys("Gary Test");
            driver.FindElement(Searchbox).SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            //Check result shows on the dropdown
            wait.Until(ExpectedConditions.ElementExists((By)TestUserDetailsOnDropdown));
            Assert.IsTrue(driver.FindElement(TestUserDetailsOnDropdown).Displayed);
            driver.FindElement(TestUserDetailsOnDropdown).Click();
            Thread.Sleep(2000);
            //Check result is shown under access channel after selecting from dropdown
            wait.Until(ExpectedConditions.ElementExists((By)TestUserSearchResult));
            Assert.IsTrue(driver.FindElement(TestUserSearchResult).Displayed);
            Thread.Sleep(5000);
            //Verify job status shows as resolved
            wait.Until(ExpectedConditions.ElementExists((By)CaseHistoryResolved));
            Assert.IsTrue(driver.FindElement(CaseHistoryResolved).Displayed);
            Thread.Sleep(2000);
            //Click customer name
            driver.FindElement(TestUserSearchResult).Click();
            Thread.Sleep(2000);
            driver.SwitchTo().DefaultContent();
            Thread.Sleep(2000);
            //Click history tab
            driver.FindElement(HistoryTabOnCustomer).Click();
            Thread.Sleep(2000);
            Actions action = new Actions(driver);
            action.SendKeys(Keys.PageDown).Build().Perform();
            var Cases = 0;
            try
            {
                if (driver.FindElements(TestNameOnCustomerHistory).Count() != 0)
                    Console.WriteLine("Cases present on customer history");
                {
                    do
                    {
                        //Click select all cases
                        wait.Until(ExpectedConditions.ElementExists((By)SelectAllCasesBtn));
                        Thread.Sleep(3000);
                        driver.FindElement(SelectAllCasesBtn).Click();
                        Thread.Sleep(2000);
                        //Click more options dots
                        wait.Until(ExpectedConditions.ElementExists((By)MoreOptionsDotsOnCustomerCases));
                        Thread.Sleep(2000);
                        driver.FindElement(MoreOptionsDotsOnCustomerCases).Click();
                        Thread.Sleep(2000);
                        //Click delete cases
                        wait.Until(ExpectedConditions.ElementExists((By)DeleteCasesFromMoreOptions));
                        Thread.Sleep(2000);
                        driver.FindElement(DeleteCasesFromMoreOptions).Click();
                        Thread.Sleep(2000);
                        //Click delete on the overlay
                        wait.Until(ExpectedConditions.ElementExists((By)DeleteCasesOverlayBtn));
                        Thread.Sleep(2000);
                        driver.FindElement(DeleteCasesOverlayBtn).Click();
                        Thread.Sleep(10000);
                        wait.Until(ExpectedConditions.ElementExists((By)CustomerCasesTitle));
                        Cases++;
                        if (driver.FindElements(TestNameOnCustomerHistory).Count() == 0)
                        {
                            Console.WriteLine("All cases removed");
                            break;
                        }
                    }
                    while (driver.FindElements(TestNameOnCustomerHistory).Count() != 0);
                }
            }
            catch (Exception)
            {
                if (Cases == 0)
                {
                    Console.WriteLine("No cases were added to customer history");
                    Assert.Fail();
                }
            }
        }

        public void OOASignPostCase()
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
            driver.FindElement(Searchbox).SendKeys("Out Ofarea");
            driver.FindElement(Searchbox).SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            //Check result shows on the dropdown
            wait.Until(ExpectedConditions.ElementExists((By)OutOfareaDetailsOnDropdown));
            Assert.IsTrue(driver.FindElement(OutOfareaDetailsOnDropdown).Displayed);
            driver.FindElement(OutOfareaDetailsOnDropdown).Click();
            Thread.Sleep(2000);
            //Check result is shown under access channel after selecting from dropdown
            wait.Until(ExpectedConditions.ElementExists((By)OutOfareaSearchResult));
            Assert.IsTrue(driver.FindElement(OutOfareaSearchResult).Displayed);
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
            wait.Until(ExpectedConditions.ElementExists((By)FAQSearchServiceResult));
            Assert.IsTrue(driver.FindElement(FAQSearchServiceResult).Displayed);
            driver.FindElement(FAQSearchServiceResult).Click();
            Thread.Sleep(2000);
            //Verify customer name and service shown on the create new case overlay
            driver.SwitchTo().DefaultContent();
            wait.Until(ExpectedConditions.ElementExists((By)OOANameOnNewCaseOverlay));
            Assert.IsTrue(driver.FindElement(OOANameOnNewCaseOverlay).Displayed);
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
            driver.FindElement(AddressSearchBox).SendKeys("pontefract");
            Thread.Sleep(1000);
            driver.FindElement(AddressSearchBox).SendKeys(Keys.Enter);
            wait.Until(ExpectedConditions.ElementExists((By)NewCustomerAddressDropdown));
            driver.FindElement(NewCustomerAddressDropdown).Click();
            driver.SwitchTo().DefaultContent();
            Thread.Sleep(5000);
            //Select private land
            Actions actions = new Actions(driver);
            actions.SendKeys(Keys.PageDown).Build().Perform();
            Thread.Sleep(2000);
            driver.FindElement(DogFoulingLandType).Click();
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)DogFoulingLandPrivate));
            driver.FindElement(DogFoulingLandPrivate).Click();
            Thread.Sleep(2000);
            driver.FindElement(DogFoulingLandType).Click();
            Thread.Sleep(2000);
            //Click signpost
            driver.SwitchTo().Frame("WebResource_allocatingpanel");
            wait.Until(ExpectedConditions.ElementExists((By)SignpostBtn));
            Thread.Sleep(2000);
            driver.FindElement(SignpostBtn).Click();
            Thread.Sleep(2000);
            //Select bespoke signposting from dropdown
            wait.Until(ExpectedConditions.ElementExists((By)ResolveDropdown));
            driver.FindElement(ResolveDropdown).Click();
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)BespokeSignposting));
            driver.FindElement(BespokeSignposting).Click();
            Thread.Sleep(2000);
            //Enter text in to text box
            wait.Until(ExpectedConditions.ElementExists((By)BespokeSignpostingTextBox));
            driver.FindElement(BespokeSignpostingTextBox).Click();
            Thread.Sleep(2000);
            driver.FindElement(BespokeSignpostingTextBox).SendKeys("This is a signpost message");
            Thread.Sleep(2000);
            //Click submit
            wait.Until(ExpectedConditions.ElementExists((By)StatusSubmitBtn));
            driver.FindElement(StatusSubmitBtn).Click();
            Thread.Sleep(2000);
            driver.SwitchTo().DefaultContent();
            //Verify case summary page loads
            wait.Until(ExpectedConditions.ElementExists((By)CustomerInfoTitleOnCaseSummary));
            Assert.IsTrue(driver.FindElement(CustomerInfoTitleOnCaseSummary).Displayed);
            //Verify SLA empty
            wait.Until(ExpectedConditions.ElementExists((By)EmptySLAOnCaseSummary));
            Assert.IsTrue(driver.FindElement(EmptySLAOnCaseSummary).Displayed);
            Thread.Sleep(2000);
            //Click refresh button
            var Status = 0;
            try
            {
                if (driver.FindElements(SignpostedJobStatus).Count() != 0)
                {
                    Console.WriteLine("Job status changed from in progress");
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                do
                {
                    driver.FindElement(RefreshButtonOnCaseDetails).Click();
                    Thread.Sleep(5000);
                    Status++;
                    if (driver.FindElements(SignpostedJobStatus).Count() != 0)
                    {
                        break;
                    }
                    else if (Status == 10)
                    {
                        Console.WriteLine("Job status not updated from in progress");
                        Assert.Fail();
                    }
                } while (driver.FindElements(SignpostedJobStatus).Count() == 0);
            }
            //Verify status updated to signposted
            wait.Until(ExpectedConditions.ElementExists((By)SignpostedJobStatus));
            Assert.IsTrue(driver.FindElement(SignpostedJobStatus).Displayed);
            Thread.Sleep(2000);
            //Select wakefield case from allocated case dropdown
            wait.Until(ExpectedConditions.ElementExists((By)AllocatedCaseForm));
            driver.FindElement(AllocatedCaseForm).Click();
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)AllocatedCaseDropdownWakefield));
            driver.FindElement(AllocatedCaseDropdownWakefield).Click();
            Thread.Sleep(2000);
            //Verify case details form loads
            wait.Until(ExpectedConditions.ElementExists((By)CaseDetailsForm));
            Assert.IsTrue(driver.FindElement(CaseDetailsForm).Displayed);
            Thread.Sleep(2000);
            //Verify last customer update shows no message
            wait.Until(ExpectedConditions.ElementExists((By)StatusUpdateAdded));
            Assert.IsFalse(driver.FindElement(StatusUpdateAdded).Text.Equals("This is a signpost message"));
            Thread.Sleep(2000);
            //Verify status message shown on timeline
            wait.Until(ExpectedConditions.ElementExists((By)TimelineStatusClosed));
            Assert.IsTrue(driver.FindElement(TimelineStatusClosed).Displayed);
            Thread.Sleep(2000);
            //Click customer updates/history
            driver.FindElement(HistoryTabOnCustomer).Click();
            Thread.Sleep(2000);
            //Verify bespoke message is shown
            wait.Until(ExpectedConditions.ElementExists((By)BespokeMsgOnHistoryTab));
            Assert.IsTrue(driver.FindElement(BespokeMsgOnHistoryTab).Displayed);
            Thread.Sleep(2000);
            //Click back to summary tab
            driver.FindElement(CaseDetailsSummaryTab).Click();
            Thread.Sleep(2000);
            //Click case form link on service details
            Assert.IsTrue(driver.FindElement(ServiceFormLink).Displayed);
            Thread.Sleep(2000);
            driver.FindElement(ServiceFormLink).Click();
            Thread.Sleep(2000);
            //Verify form loads
            wait.Until(ExpectedConditions.ElementExists((By)DogFoulingFormTitle));
            Assert.IsTrue(driver.FindElement(DogFoulingFormTitle).Displayed);
            Thread.Sleep(2000);
            //Verify message shows record is inactive
            wait.Until(ExpectedConditions.ElementExists((By)DogFoulingFormStatusInactive));
            Assert.IsTrue(driver.FindElement(DogFoulingFormStatusInactive).Displayed);
            Thread.Sleep(2000);
            //Click dashboards in LHN
            driver.FindElement(DashboardsLHN).Click();
            Thread.Sleep(2000);
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
            driver.FindElement(Searchbox).SendKeys("Out Ofarea");
            driver.FindElement(Searchbox).SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            //Check result shows on the dropdown
            wait.Until(ExpectedConditions.ElementExists((By)OutOfareaDetailsOnDropdown));
            Assert.IsTrue(driver.FindElement(OutOfareaDetailsOnDropdown).Displayed);
            driver.FindElement(OutOfareaDetailsOnDropdown).Click();
            Thread.Sleep(2000);
            //Check result is shown under access channel after selecting from dropdown
            wait.Until(ExpectedConditions.ElementExists((By)OutOfareaSearchResult));
            Assert.IsTrue(driver.FindElement(OutOfareaSearchResult).Displayed);
            Thread.Sleep(5000);
            //Verify job status shows as resolved
            wait.Until(ExpectedConditions.ElementExists((By)CaseHistoryResolved));
            Assert.IsTrue(driver.FindElement(CaseHistoryResolved).Displayed);
            Thread.Sleep(2000);
            //Click customer name
            wait.Until(ExpectedConditions.ElementExists((By)OutOfareaSearchResult));
            driver.FindElement(OutOfareaSearchResult).Click();
            Thread.Sleep(2000);
            driver.SwitchTo().DefaultContent();
            Thread.Sleep(2000);
            //Click history tab
            driver.FindElement(HistoryTabOnCustomer).Click();
            Thread.Sleep(2000);
            Actions action = new Actions(driver);
            action.SendKeys(Keys.PageDown).Build().Perform();
            var Cases = 0;
            try
            {
                if (driver.FindElements(OOANameOnCustomerHistory).Count() != 0)
                    Console.WriteLine("Cases present on customer history");
                {
                    do
                    {
                    //Click select all cases
                    wait.Until(ExpectedConditions.ElementExists((By)SelectAllCasesBtn));
                    Thread.Sleep(3000);
                    driver.FindElement(SelectAllCasesBtn).Click();
                    Thread.Sleep(2000);
                    //Click more options dots
                    wait.Until(ExpectedConditions.ElementExists((By)MoreOptionsDotsOnCustomerCases));
                    Thread.Sleep(2000);
                    driver.FindElement(MoreOptionsDotsOnCustomerCases).Click();
                    Thread.Sleep(2000);
                    //Click delete cases
                    wait.Until(ExpectedConditions.ElementExists((By)DeleteCasesFromMoreOptions));
                    Thread.Sleep(2000);
                    driver.FindElement(DeleteCasesFromMoreOptions).Click();
                    Thread.Sleep(2000);
                    //Click delete on the overlay
                    wait.Until(ExpectedConditions.ElementExists((By)DeleteCasesOverlayBtn));
                    Thread.Sleep(2000);
                    driver.FindElement(DeleteCasesOverlayBtn).Click();
                    Thread.Sleep(10000);
                    wait.Until(ExpectedConditions.ElementExists((By)CustomerCasesTitle));
                    Cases++;
                        if(driver.FindElements(OOANameOnCustomerHistory).Count() == 0)
                        {
                            Console.WriteLine("All cases removed");
                            break;
                        }
                    }
                    while (driver.FindElements(OOANameOnCustomerHistory).Count() != 0);
                }
            }
            catch (Exception)
            {
                if (Cases == 0)
                {
                    Console.WriteLine("No cases were added to customer history");
                    Assert.Fail();
                }
            }
        }

        public void ManualAddressSignPostCase()
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
            wait.Until(ExpectedConditions.ElementExists((By)FAQSearchServiceResult));
            Assert.IsTrue(driver.FindElement(FAQSearchServiceResult).Displayed);
            driver.FindElement(FAQSearchServiceResult).Click();
            Thread.Sleep(2000);
            //Verify customer name and service shown on the create new case overlay
            driver.SwitchTo().DefaultContent();
            wait.Until(ExpectedConditions.ElementExists((By)ManualAddressOnNewCaseOverlay));
            Assert.IsTrue(driver.FindElement(ManualAddressOnNewCaseOverlay).Displayed);
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
            Thread.Sleep(2000);
            //Click can't find address link
            wait.Until(ExpectedConditions.ElementExists((By)CantFindAddressLink));
            driver.FindElement(CantFindAddressLink).Click();
            Thread.Sleep(2000);
            driver.SwitchTo().DefaultContent();
            //Click I understand on overlay
            wait.Until(ExpectedConditions.ElementExists((By)UnderstandBtnOnOverlay));
            driver.FindElement(UnderstandBtnOnOverlay).Click();
            Thread.Sleep(2000);
            //Enter address
            driver.SwitchTo().Frame("WebResource_WMDCAddressSearch");
            wait.Until(ExpectedConditions.ElementExists((By)FindAddressSearchBox));
            driver.FindElement(FindAddressSearchBox).Click();
            driver.FindElement(FindAddressSearchBox).SendKeys("80 spring avenue, ashby-de-la-zouch, le65 2rb");
            Thread.Sleep(2000);
            driver.FindElement(AddressConfirmBtn).Click();
            driver.SwitchTo().DefaultContent();
            Thread.Sleep(5000);
            //Select private land
            Actions actions = new Actions(driver);
            actions.SendKeys(Keys.PageDown).Build().Perform();
            Thread.Sleep(2000);
            driver.FindElement(DogFoulingLandType).Click();
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)DogFoulingLandPrivate));
            driver.FindElement(DogFoulingLandPrivate).Click();
            Thread.Sleep(2000);
            driver.FindElement(DogFoulingLandType).Click();
            Thread.Sleep(2000);
            //Click signpost
            driver.SwitchTo().Frame("WebResource_allocatingpanel");
            wait.Until(ExpectedConditions.ElementExists((By)SignpostBtn));
            Thread.Sleep(2000);
            driver.FindElement(SignpostBtn).Click();
            Thread.Sleep(2000);
            //Select bespoke signposting from dropdown
            wait.Until(ExpectedConditions.ElementExists((By)ResolveDropdown));
            driver.FindElement(ResolveDropdown).Click();
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)BespokeSignposting));
            driver.FindElement(BespokeSignposting).Click();
            Thread.Sleep(2000);
            //Enter text in to text box
            wait.Until(ExpectedConditions.ElementExists((By)BespokeSignpostingTextBox));
            driver.FindElement(BespokeSignpostingTextBox).Click();
            Thread.Sleep(2000);
            driver.FindElement(BespokeSignpostingTextBox).SendKeys("This is a signpost message");
            Thread.Sleep(2000);
            //Click submit
            wait.Until(ExpectedConditions.ElementExists((By)StatusSubmitBtn));
            driver.FindElement(StatusSubmitBtn).Click();
            Thread.Sleep(2000);
            driver.SwitchTo().DefaultContent();
            //Verify case summary page loads
            wait.Until(ExpectedConditions.ElementExists((By)CustomerInfoTitleOnCaseSummary));
            Assert.IsTrue(driver.FindElement(CustomerInfoTitleOnCaseSummary).Displayed);
            //Verify SLA empty
            wait.Until(ExpectedConditions.ElementExists((By)EmptySLAOnCaseSummary));
            Assert.IsTrue(driver.FindElement(EmptySLAOnCaseSummary).Displayed);
            Thread.Sleep(2000);
            //Click refresh button
            var Status = 0;
            try
            {
                if (driver.FindElements(SignpostedJobStatus).Count() != 0)
                {
                    Console.WriteLine("Job status changed from in progress");
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                do
                {
                    driver.FindElement(RefreshButtonOnCaseDetails).Click();
                    Thread.Sleep(5000);
                    Status++;
                    if (driver.FindElements(SignpostedJobStatus).Count() != 0)
                    {
                        break;
                    }
                    else if (Status == 10)
                    {
                        Console.WriteLine("Job status not updated from in progress");
                        Assert.Fail();
                    }
                } while (driver.FindElements(SignpostedJobStatus).Count() == 0);
            }
            //Verify status updated to signposted
            wait.Until(ExpectedConditions.ElementExists((By)SignpostedJobStatus));
            Assert.IsTrue(driver.FindElement(SignpostedJobStatus).Displayed);
            Thread.Sleep(2000);
            //Select wakefield case from allocated case dropdown
            wait.Until(ExpectedConditions.ElementExists((By)AllocatedCaseForm));
            driver.FindElement(AllocatedCaseForm).Click();
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)AllocatedCaseDropdownWakefield));
            driver.FindElement(AllocatedCaseDropdownWakefield).Click();
            Thread.Sleep(2000);
            //Verify case details form loads
            wait.Until(ExpectedConditions.ElementExists((By)CaseDetailsForm));
            Assert.IsTrue(driver.FindElement(CaseDetailsForm).Displayed);
            Thread.Sleep(2000);
            //Verify last customer update shows no message
            wait.Until(ExpectedConditions.ElementExists((By)StatusUpdateAdded));
            Assert.IsFalse(driver.FindElement(StatusUpdateAdded).Text.Equals("This is a signpost message"));
            Thread.Sleep(2000);
            //Verify status message shown on timeline
            wait.Until(ExpectedConditions.ElementExists((By)TimelineStatusClosed));
            Assert.IsTrue(driver.FindElement(TimelineStatusClosed).Displayed);
            Thread.Sleep(2000);
            //Click customer updates/history
            driver.FindElement(HistoryTabOnCustomer).Click();
            Thread.Sleep(2000);
            //Verify bespoke message is shown
            wait.Until(ExpectedConditions.ElementExists((By)BespokeMsgOnHistoryTab));
            Assert.IsTrue(driver.FindElement(BespokeMsgOnHistoryTab).Displayed);
            Thread.Sleep(2000);
            //Click back to summary tab
            driver.FindElement(CaseDetailsSummaryTab).Click();
            Thread.Sleep(2000);
            //Click case form link on service details
            Assert.IsTrue(driver.FindElement(ServiceFormLink).Displayed);
            Thread.Sleep(2000);
            driver.FindElement(ServiceFormLink).Click();
            Thread.Sleep(2000);
            //Verify form loads
            wait.Until(ExpectedConditions.ElementExists((By)DogFoulingFormTitle));
            Assert.IsTrue(driver.FindElement(DogFoulingFormTitle).Displayed);
            Thread.Sleep(2000);
            //Verify message shows record is inactive
            wait.Until(ExpectedConditions.ElementExists((By)DogFoulingFormStatusInactive));
            Assert.IsTrue(driver.FindElement(DogFoulingFormStatusInactive).Displayed);
            Thread.Sleep(2000);
            //Click dashboards in LHN
            driver.FindElement(DashboardsLHN).Click();
            Thread.Sleep(2000);
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
            Thread.Sleep(5000);
            //Verify job status shows as resolved
            wait.Until(ExpectedConditions.ElementExists((By)CaseHistoryResolved));
            Assert.IsTrue(driver.FindElement(CaseHistoryResolved).Displayed);
            Thread.Sleep(2000);
            //Click customer name
            driver.FindElement(ManualAddressSearchResult).Click();
            Thread.Sleep(2000);
            driver.SwitchTo().DefaultContent();
            Thread.Sleep(2000);
            //Click history tab
            driver.FindElement(HistoryTabOnCustomer).Click();
            Thread.Sleep(2000);
            Actions action = new Actions(driver);
            action.SendKeys(Keys.PageDown).Build().Perform();
            var Cases = 0;
            try
            {
                if (driver.FindElements(ManualAddressOnCustomerHistory).Count() != 0)
                    Console.WriteLine("Cases present on customer history");
                {
                    do
                    {
                        //Click select all cases
                        wait.Until(ExpectedConditions.ElementExists((By)SelectAllCasesBtn));
                        Thread.Sleep(3000);
                        driver.FindElement(SelectAllCasesBtn).Click();
                        Thread.Sleep(3000);
                        //Click more options dots
                        wait.Until(ExpectedConditions.ElementExists((By)MoreOptionsDotsOnCustomerCases));
                        Thread.Sleep(3000);
                        driver.FindElement(MoreOptionsDotsOnCustomerCases).Click();
                        Thread.Sleep(3000);
                        //Click delete cases
                        wait.Until(ExpectedConditions.ElementExists((By)DeleteCasesFromMoreOptions));
                        Thread.Sleep(3000);
                        driver.FindElement(DeleteCasesFromMoreOptions).Click();
                        Thread.Sleep(3000);
                        //Click delete on the overlay
                        wait.Until(ExpectedConditions.ElementExists((By)DeleteCasesOverlayBtn));
                        Thread.Sleep(3000);
                        driver.FindElement(DeleteCasesOverlayBtn).Click();
                        Thread.Sleep(10000);
                        wait.Until(ExpectedConditions.ElementExists((By)CustomerCasesTitle));
                        Cases++;
                        if (driver.FindElements(OOANameOnCustomerHistory).Count() == 0)
                        {
                            Console.WriteLine("All cases removed");
                            break;
                        }
                    }
                    while (driver.FindElements(ManualAddressOnCustomerHistory).Count() != 0);
                }
            }
            catch (Exception)
            {
                if (Cases == 0)
                {
                    Console.WriteLine("No cases were added to customer history");
                    Assert.Fail();
                }
            }
        }

        public void AnonSignPostCase()
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
            wait.Until(ExpectedConditions.ElementExists((By)Searchbox));
            Assert.IsTrue(driver.FindElement(Searchbox).Displayed);
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
            wait.Until(ExpectedConditions.ElementExists((By)FAQSearchServiceResult));
            Assert.IsTrue(driver.FindElement(FAQSearchServiceResult).Displayed);
            driver.FindElement(FAQSearchServiceResult).Click();
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
            //Select private land
            Actions actions = new Actions(driver);
            actions.SendKeys(Keys.PageDown).Build().Perform();
            Thread.Sleep(2000);
            driver.FindElement(DogFoulingLandType).Click();
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)DogFoulingLandPrivate));
            driver.FindElement(DogFoulingLandPrivate).Click();
            Thread.Sleep(2000);
            driver.FindElement(DogFoulingLandType).Click();
            Thread.Sleep(2000);
            //Click signpost
            driver.SwitchTo().Frame("WebResource_allocatingpanel");
            wait.Until(ExpectedConditions.ElementExists((By)SignpostBtn));
            Thread.Sleep(2000);
            driver.FindElement(SignpostBtn).Click();
            Thread.Sleep(2000);
            //Select bespoke signposting from dropdown
            wait.Until(ExpectedConditions.ElementExists((By)ResolveDropdown));
            driver.FindElement(ResolveDropdown).Click();
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)BespokeSignposting));
            driver.FindElement(BespokeSignposting).Click();
            Thread.Sleep(2000);
            //Enter text in to text box
            wait.Until(ExpectedConditions.ElementExists((By)BespokeSignpostingTextBox));
            driver.FindElement(BespokeSignpostingTextBox).Click();
            Thread.Sleep(2000);
            driver.FindElement(BespokeSignpostingTextBox).SendKeys("This is a signpost message");
            Thread.Sleep(2000);
            //Click submit
            wait.Until(ExpectedConditions.ElementExists((By)StatusSubmitBtn));
            driver.FindElement(StatusSubmitBtn).Click();
            Thread.Sleep(2000);
            driver.SwitchTo().DefaultContent();
            //Verify case summary page loads
            wait.Until(ExpectedConditions.ElementExists((By)CustomerInfoTitleOnCaseSummary));
            Assert.IsTrue(driver.FindElement(CustomerInfoTitleOnCaseSummary).Displayed);
            //Verify SLA empty
            wait.Until(ExpectedConditions.ElementExists((By)EmptySLAOnCaseSummary));
            Assert.IsTrue(driver.FindElement(EmptySLAOnCaseSummary).Displayed);
            Thread.Sleep(2000);
            //Click refresh button
            var Status = 0;
            try
            {
                if (driver.FindElements(SignpostedJobStatus).Count() != 0)
                {
                    Console.WriteLine("Job status changed from in progress");
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                do
                {
                    driver.FindElement(RefreshButtonOnCaseDetails).Click();
                    Thread.Sleep(5000);
                    Status++;
                    if (driver.FindElements(SignpostedJobStatus).Count() != 0)
                    {
                        break;
                    }
                    else if (Status == 10)
                    {
                        Console.WriteLine("Job status not updated from in progress");
                        Assert.Fail();
                    }
                } while (driver.FindElements(SignpostedJobStatus).Count() == 0);
            }
            //Verify status updated to signposted
            wait.Until(ExpectedConditions.ElementExists((By)SignpostedJobStatus));
            Assert.IsTrue(driver.FindElement(SignpostedJobStatus).Displayed);
            Thread.Sleep(2000);
            //Select wakefield case from allocated case dropdown
            wait.Until(ExpectedConditions.ElementExists((By)AllocatedCaseForm));
            driver.FindElement(AllocatedCaseForm).Click();
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)AllocatedCaseDropdownWakefield));
            driver.FindElement(AllocatedCaseDropdownWakefield).Click();
            Thread.Sleep(2000);
            //Verify case details form loads
            wait.Until(ExpectedConditions.ElementExists((By)CaseDetailsForm));
            Assert.IsTrue(driver.FindElement(CaseDetailsForm).Displayed);
            Thread.Sleep(2000);
            //Verify last customer update shows no message
            wait.Until(ExpectedConditions.ElementExists((By)StatusUpdateAdded));
            Assert.IsFalse(driver.FindElement(StatusUpdateAdded).Text.Equals("This is a signpost message"));
            Thread.Sleep(2000);
            //Verify status message shown on timeline
            wait.Until(ExpectedConditions.ElementExists((By)TimelineStatusClosed));
            Assert.IsTrue(driver.FindElement(TimelineStatusClosed).Displayed);
            Thread.Sleep(2000);
            //Click customer updates/history
            driver.FindElement(HistoryTabOnCustomer).Click();
            Thread.Sleep(2000);
            //Verify bespoke message is shown
            wait.Until(ExpectedConditions.ElementExists((By)BespokeMsgOnHistoryTab));
            Assert.IsTrue(driver.FindElement(BespokeMsgOnHistoryTab).Displayed);
            Thread.Sleep(2000);
            //Click back to summary tab
            driver.FindElement(CaseDetailsSummaryTab).Click();
            Thread.Sleep(2000);
            //Click case form link on service details
            Assert.IsTrue(driver.FindElement(ServiceFormLink).Displayed);
            Thread.Sleep(2000);
            driver.FindElement(ServiceFormLink).Click();
            Thread.Sleep(2000);
            //Verify form loads
            wait.Until(ExpectedConditions.ElementExists((By)DogFoulingFormTitle));
            Assert.IsTrue(driver.FindElement(DogFoulingFormTitle).Displayed);
            Thread.Sleep(2000);
            //Verify message shows record is inactive
            wait.Until(ExpectedConditions.ElementExists((By)DogFoulingFormStatusInactive));
            Assert.IsTrue(driver.FindElement(DogFoulingFormStatusInactive).Displayed);
            Thread.Sleep(2000);
        }

        public void SignPostCaseOnBehalfOf()
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
            wait.Until(ExpectedConditions.ElementExists((By)Searchbox));
            Assert.IsTrue(driver.FindElement(Searchbox).Displayed);
            //Enter fullname in search
            driver.FindElement(Searchbox).Click();
            driver.FindElement(Searchbox).SendKeys("Gary Moore");
            driver.FindElement(Searchbox).SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            //Check result shows on the dropdown
            wait.Until(ExpectedConditions.ElementExists((By)ExistingCustomerSearchDropdown));
            driver.FindElement(OnBehalfOfInDropdown).Click();
            driver.FindElement(ExistingCustomerSearchDropdown).Click();
            Thread.Sleep(2000);
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
            wait.Until(ExpectedConditions.ElementExists((By)FAQSearchServiceResult));
            Assert.IsTrue(driver.FindElement(FAQSearchServiceResult).Displayed);
            driver.FindElement(FAQSearchServiceResult).Click();
            Thread.Sleep(2000);
            //Verify customer name and service shown on the create new case overlay
            driver.SwitchTo().DefaultContent();
            wait.Until(ExpectedConditions.ElementExists((By)TestNameOnNewCaseOverlay));
            Assert.IsTrue(driver.FindElement(TestNameOnNewCaseOverlay).Displayed);
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
            //Select private land
            Actions actions = new Actions(driver);
            actions.SendKeys(Keys.PageDown).Build().Perform();
            Thread.Sleep(2000);
            driver.FindElement(DogFoulingLandType).Click();
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)DogFoulingLandPrivate));
            driver.FindElement(DogFoulingLandPrivate).Click();
            Thread.Sleep(2000);
            driver.FindElement(DogFoulingLandType).Click();
            Thread.Sleep(2000);
            //Click signpost
            driver.SwitchTo().Frame("WebResource_allocatingpanel");
            wait.Until(ExpectedConditions.ElementExists((By)SignpostBtn));
            Thread.Sleep(2000);
            driver.FindElement(SignpostBtn).Click();
            Thread.Sleep(2000);
            //Select bespoke signposting from dropdown
            wait.Until(ExpectedConditions.ElementExists((By)ResolveDropdown));
            driver.FindElement(ResolveDropdown).Click();
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)BespokeSignposting));
            driver.FindElement(BespokeSignposting).Click();
            Thread.Sleep(2000);
            //Enter text in to text box
            wait.Until(ExpectedConditions.ElementExists((By)BespokeSignpostingTextBox));
            driver.FindElement(BespokeSignpostingTextBox).Click();
            Thread.Sleep(2000);
            driver.FindElement(BespokeSignpostingTextBox).SendKeys("This is a signpost message");
            Thread.Sleep(2000);
            //Click submit
            wait.Until(ExpectedConditions.ElementExists((By)StatusSubmitBtn));
            driver.FindElement(StatusSubmitBtn).Click();
            Thread.Sleep(2000);
            driver.SwitchTo().DefaultContent();
            //Verify case summary page loads
            wait.Until(ExpectedConditions.ElementExists((By)CustomerInfoTitleOnCaseSummary));
            Assert.IsTrue(driver.FindElement(CustomerInfoTitleOnCaseSummary).Displayed);
            //Verify SLA empty
            wait.Until(ExpectedConditions.ElementExists((By)EmptySLAOnCaseSummary));
            Assert.IsTrue(driver.FindElement(EmptySLAOnCaseSummary).Displayed);
            Thread.Sleep(2000);
            //Click refresh button
            var Status = 0;
            try
            {
                if (driver.FindElements(SignpostedJobStatus).Count() != 0)
                {
                    Console.WriteLine("Job status changed from in progress");
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                do
                {
                    driver.FindElement(RefreshButtonOnCaseDetails).Click();
                    Thread.Sleep(5000);
                    Status++;
                    if (driver.FindElements(SignpostedJobStatus).Count() != 0)
                    {
                        break;
                    }
                    else if (Status == 10)
                    {
                        Console.WriteLine("Job status not updated from in progress");
                        Assert.Fail();
                    }
                } while (driver.FindElements(SignpostedJobStatus).Count() == 0);
            }
            //Verify status updated to signposted
            wait.Until(ExpectedConditions.ElementExists((By)SignpostedJobStatus));
            Assert.IsTrue(driver.FindElement(SignpostedJobStatus).Displayed);
            Thread.Sleep(2000);
            //Select wakefield case from allocated case dropdown
            wait.Until(ExpectedConditions.ElementExists((By)AllocatedCaseForm));
            driver.FindElement(AllocatedCaseForm).Click();
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)AllocatedCaseDropdownWakefield));
            driver.FindElement(AllocatedCaseDropdownWakefield).Click();
            Thread.Sleep(2000);
            //Verify case details form loads
            wait.Until(ExpectedConditions.ElementExists((By)CaseDetailsForm));
            Assert.IsTrue(driver.FindElement(CaseDetailsForm).Displayed);
            Thread.Sleep(2000);
            //Verify last customer update shows no message
            wait.Until(ExpectedConditions.ElementExists((By)StatusUpdateAdded));
            Assert.IsFalse(driver.FindElement(StatusUpdateAdded).Text.Equals("This is a signpost message"));
            Thread.Sleep(2000);
            //Verify status message shown on timeline
            wait.Until(ExpectedConditions.ElementExists((By)TimelineStatusClosed));
            Assert.IsTrue(driver.FindElement(TimelineStatusClosed).Displayed);
            Thread.Sleep(2000);
            //Click customer updates/history
            driver.FindElement(HistoryTabOnCustomer).Click();
            Thread.Sleep(2000);
            //Verify bespoke message is shown
            wait.Until(ExpectedConditions.ElementExists((By)BespokeMsgOnHistoryTab));
            Assert.IsTrue(driver.FindElement(BespokeMsgOnHistoryTab).Displayed);
            Thread.Sleep(2000);
            //Verify customer and reporter names are displayed
            wait.Until(ExpectedConditions.ElementExists((By)CustomerNameOnCustomerCases));
            Assert.IsTrue(driver.FindElement(CustomerNameOnCustomerCases).Displayed);
            wait.Until(ExpectedConditions.ElementExists((By)ReporterNameOnCustomerCases));
            Assert.IsTrue(driver.FindElement(ReporterNameOnCustomerCases).Displayed);
            //Click back to summary tab
            driver.FindElement(CaseDetailsSummaryTab).Click();
            Thread.Sleep(2000);
            //Click case form link on service details
            Assert.IsTrue(driver.FindElement(ServiceFormLink).Displayed);
            Thread.Sleep(2000);
            driver.FindElement(ServiceFormLink).Click();
            Thread.Sleep(2000);
            //Verify form loads
            wait.Until(ExpectedConditions.ElementExists((By)DogFoulingFormTitle));
            Assert.IsTrue(driver.FindElement(DogFoulingFormTitle).Displayed);
            Thread.Sleep(2000);
            //Verify message shows record is inactive
            wait.Until(ExpectedConditions.ElementExists((By)DogFoulingFormStatusInactive));
            Assert.IsTrue(driver.FindElement(DogFoulingFormStatusInactive).Displayed);
            Thread.Sleep(2000);
            //Click dashboards in LHN
            driver.FindElement(DashboardsLHN).Click();
            Thread.Sleep(2000);
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
            driver.FindElement(Searchbox).SendKeys("Gary Test");
            driver.FindElement(Searchbox).SendKeys(Keys.Enter);
            wait.Until(ExpectedConditions.ElementExists((By)GaryTestInDropdown));
            Assert.IsTrue(driver.FindElement(GaryTestInDropdown).Displayed);
            driver.FindElement(GaryTestInDropdown).Click();
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)GaryTestInAccessChannel));
            Assert.IsTrue(driver.FindElement(GaryTestInAccessChannel).Displayed);
            Thread.Sleep(2000);
            //Check result is shown under access channel after selecting from dropdown
            wait.Until(ExpectedConditions.ElementExists((By)TestUserSearchResult));
            Assert.IsTrue(driver.FindElement(TestUserSearchResult).Displayed);
            Thread.Sleep(5000);
            //Verify job status shows as resolved
            wait.Until(ExpectedConditions.ElementExists((By)CaseHistoryResolved));
            Assert.IsTrue(driver.FindElement(CaseHistoryResolved).Displayed);
            Thread.Sleep(2000);
            //Verify on behalf of asterisk is shown
            wait.Until(ExpectedConditions.ElementExists((By)CaseHistoryAsterisk));
            Assert.IsTrue(driver.FindElement(CaseHistoryAsterisk).Displayed);
            //Click customer name
            driver.FindElement(TestUserSearchResult).Click();
            Thread.Sleep(2000);
            driver.SwitchTo().DefaultContent();
            Thread.Sleep(2000);
            //Click history tab
            wait.Until(ExpectedConditions.ElementExists((By)HistoryTabOnCustomer));
            driver.FindElement(HistoryTabOnCustomer).Click();
            Thread.Sleep(2000);
            try
            {
                do
                {
                    //Click select all cases
                    wait.Until(ExpectedConditions.ElementExists((By)SelectAllCasesBtn));
                    Thread.Sleep(3000);
                    driver.FindElement(SelectAllCasesBtn).Click();
                    Thread.Sleep(2000);
                    //Click more options dots
                    wait.Until(ExpectedConditions.ElementExists((By)MoreOptionsDotsOnCustomerCases));
                    Thread.Sleep(2000);
                    driver.FindElement(MoreOptionsDotsOnCustomerCases).Click();
                    Thread.Sleep(2000);
                    //Click delete cases
                    wait.Until(ExpectedConditions.ElementExists((By)DeleteCasesFromMoreOptions));
                    Thread.Sleep(2000);
                    driver.FindElement(DeleteCasesFromMoreOptions).Click();
                    Thread.Sleep(2000);
                    //Click delete on the overlay
                    wait.Until(ExpectedConditions.ElementExists((By)DeleteCasesOverlayBtn));
                    Thread.Sleep(2000);
                    driver.FindElement(DeleteCasesOverlayBtn).Click();
                    Thread.Sleep(10000);
                    wait.Until(ExpectedConditions.ElementExists((By)CustomerCasesTitle));
                }
                while (driver.FindElement(TestNameOnCustomerHistory).Displayed);
            }
            catch (Exception)
            {
                Console.WriteLine("All cases removed from history screen");
            }
            //Verify cases deleted
            var Cases = 0;
            try
            {
                WebElement cases = (WebElement)driver.FindElement(TestNameOnCustomerHistory);
                if (cases.Displayed)
                {
                    Cases = 1;
                    Assert.Fail();
                }
            }
            catch (Exception)
            {
                if (Cases > 0)
                {
                    Console.WriteLine("Cases not removed");
                }
                else
                {
                    Console.WriteLine("Cases removed");
                }
            }
        }

        public void UnknownAddressSignPostCase()
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
            wait.Until(ExpectedConditions.ElementExists((By)AnonCustomerSearchDropdown));
            Assert.IsTrue(driver.FindElement(AnonCustomerSearchDropdown).Displayed);
            driver.FindElement(AnonCustomerSearchDropdown).Click();
            Thread.Sleep(2000);
            //Check result is shown under access channel after selecting from dropdown
            wait.Until(ExpectedConditions.ElementExists((By)AnonAddressSearchResult));
            Assert.IsTrue(driver.FindElement(AnonAddressSearchResult).Displayed);
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
            wait.Until(ExpectedConditions.ElementExists((By)FAQSearchServiceResult));
            Assert.IsTrue(driver.FindElement(FAQSearchServiceResult).Displayed);
            driver.FindElement(FAQSearchServiceResult).Click();
            Thread.Sleep(2000);
            //Verify customer name and service shown on the create new case overlay
            driver.SwitchTo().DefaultContent();
            wait.Until(ExpectedConditions.ElementExists((By)UnknownAddressOnNewCaseOverlay));
            Assert.IsTrue(driver.FindElement(UnknownAddressOnNewCaseOverlay).Displayed);
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
            //Select private land
            Actions actions = new Actions(driver);
            actions.SendKeys(Keys.PageDown).Build().Perform();
            Thread.Sleep(2000);
            driver.FindElement(DogFoulingLandType).Click();
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)DogFoulingLandPrivate));
            driver.FindElement(DogFoulingLandPrivate).Click();
            Thread.Sleep(2000);
            driver.FindElement(DogFoulingLandType).Click();
            Thread.Sleep(2000);
            //Click signpost
            driver.SwitchTo().Frame("WebResource_allocatingpanel");
            wait.Until(ExpectedConditions.ElementExists((By)SignpostBtn));
            Thread.Sleep(2000);
            driver.FindElement(SignpostBtn).Click();
            Thread.Sleep(2000);
            //Select bespoke signposting from dropdown
            wait.Until(ExpectedConditions.ElementExists((By)ResolveDropdown));
            driver.FindElement(ResolveDropdown).Click();
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)BespokeSignposting));
            driver.FindElement(BespokeSignposting).Click();
            Thread.Sleep(2000);
            //Enter text in to text box
            wait.Until(ExpectedConditions.ElementExists((By)BespokeSignpostingTextBox));
            driver.FindElement(BespokeSignpostingTextBox).Click();
            Thread.Sleep(2000);
            driver.FindElement(BespokeSignpostingTextBox).SendKeys("This is a signpost message");
            Thread.Sleep(2000);
            //Click submit
            wait.Until(ExpectedConditions.ElementExists((By)StatusSubmitBtn));
            driver.FindElement(StatusSubmitBtn).Click();
            Thread.Sleep(2000);
            driver.SwitchTo().DefaultContent();
            //Verify case summary page loads
            wait.Until(ExpectedConditions.ElementExists((By)CustomerInfoTitleOnCaseSummary));
            Assert.IsTrue(driver.FindElement(CustomerInfoTitleOnCaseSummary).Displayed);
            //Verify SLA empty
            wait.Until(ExpectedConditions.ElementExists((By)EmptySLAOnCaseSummary));
            Assert.IsTrue(driver.FindElement(EmptySLAOnCaseSummary).Displayed);
            Thread.Sleep(2000);
            //Click refresh button
            var Status = 0;
            try
            {
                if (driver.FindElements(SignpostedJobStatus).Count() != 0)
                {
                    Console.WriteLine("Job status changed from in progress");
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                do
                {
                    driver.FindElement(RefreshButtonOnCaseDetails).Click();
                    Thread.Sleep(5000);
                    Status++;
                    if (driver.FindElements(SignpostedJobStatus).Count() != 0)
                    {
                        break;
                    }
                    else if (Status == 10)
                    {
                        Console.WriteLine("Job status not updated from in progress");
                        Assert.Fail();
                    }
                } while (driver.FindElements(SignpostedJobStatus).Count() == 0);
            }
            //Verify status updated to signposted
            wait.Until(ExpectedConditions.ElementExists((By)SignpostedJobStatus));
            Assert.IsTrue(driver.FindElement(SignpostedJobStatus).Displayed);
            Thread.Sleep(2000);
            //Select wakefield case from allocated case dropdown
            wait.Until(ExpectedConditions.ElementExists((By)AllocatedCaseForm));
            driver.FindElement(AllocatedCaseForm).Click();
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)AllocatedCaseDropdownWakefield));
            driver.FindElement(AllocatedCaseDropdownWakefield).Click();
            Thread.Sleep(2000);
            //Verify case details form loads
            wait.Until(ExpectedConditions.ElementExists((By)CaseDetailsForm));
            Assert.IsTrue(driver.FindElement(CaseDetailsForm).Displayed);
            Thread.Sleep(2000);
            //Verify last customer update shows no message
            wait.Until(ExpectedConditions.ElementExists((By)StatusUpdateAdded));
            Assert.IsFalse(driver.FindElement(StatusUpdateAdded).Text.Equals("This is a signpost message"));
            Thread.Sleep(2000);
            //Verify status message shown on timeline
            wait.Until(ExpectedConditions.ElementExists((By)TimelineStatusClosed));
            Assert.IsTrue(driver.FindElement(TimelineStatusClosed).Displayed);
            Thread.Sleep(2000);
            //Click customer updates/history
            driver.FindElement(HistoryTabOnCustomer).Click();
            Thread.Sleep(2000);
            //Verify bespoke message is shown
            wait.Until(ExpectedConditions.ElementExists((By)BespokeMsgOnHistoryTab));
            Assert.IsTrue(driver.FindElement(BespokeMsgOnHistoryTab).Displayed);
            Thread.Sleep(2000);
            //Click back to summary tab
            driver.FindElement(CaseDetailsSummaryTab).Click();
            Thread.Sleep(2000);
            //Click case form link on service details
            Assert.IsTrue(driver.FindElement(ServiceFormLink).Displayed);
            Thread.Sleep(2000);
            driver.FindElement(ServiceFormLink).Click();
            Thread.Sleep(2000);
            //Verify form loads
            wait.Until(ExpectedConditions.ElementExists((By)DogFoulingFormTitle));
            Assert.IsTrue(driver.FindElement(DogFoulingFormTitle).Displayed);
            Thread.Sleep(2000);
            //Verify message shows record is inactive
            wait.Until(ExpectedConditions.ElementExists((By)DogFoulingFormStatusInactive));
            Assert.IsTrue(driver.FindElement(DogFoulingFormStatusInactive).Displayed);
            Thread.Sleep(2000);
            //Click dashboards in LHN
            driver.FindElement(DashboardsLHN).Click();
            Thread.Sleep(2000);
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
            wait.Until(ExpectedConditions.ElementExists((By)AnonCustomerSearchDropdown));
            Assert.IsTrue(driver.FindElement(AnonCustomerSearchDropdown).Displayed);
            driver.FindElement(AnonCustomerSearchDropdown).Click();
            Thread.Sleep(2000);
            //Check result is shown under access channel after selecting from dropdown
            wait.Until(ExpectedConditions.ElementExists((By)AnonAddressSearchResult));
            Assert.IsTrue(driver.FindElement(AnonAddressSearchResult).Displayed);
            Thread.Sleep(5000);
            //Verify job status shows as resolved
            wait.Until(ExpectedConditions.ElementExists((By)CaseHistoryResolved));
            Assert.IsTrue(driver.FindElement(CaseHistoryResolved).Displayed);
            Thread.Sleep(2000);
            //Click customer name
            driver.FindElement(AnonAddressSearchResult).Click();
            Thread.Sleep(2000);
            driver.SwitchTo().DefaultContent();
            Thread.Sleep(2000);
            //Click history tab
            driver.FindElement(HistoryTabOnCustomer).Click();
            Thread.Sleep(2000);
            Actions action = new Actions(driver);
            action.SendKeys(Keys.PageDown).Build().Perform();
            var Cases = 0;
            try
            {
                if (driver.FindElements(AnonOnCustomerHistory).Count() != 0)
                    Console.WriteLine("Cases present on customer history");
                {
                    do
                    {
                        //Click select all cases
                        wait.Until(ExpectedConditions.ElementExists((By)SelectAllCasesBtn));
                        Thread.Sleep(3000);
                        driver.FindElement(SelectAllCasesBtn).Click();
                        Thread.Sleep(2000);
                        //Click more options dots
                        wait.Until(ExpectedConditions.ElementExists((By)MoreOptionsDotsOnCustomerCases));
                        Thread.Sleep(2000);
                        driver.FindElement(MoreOptionsDotsOnCustomerCases).Click();
                        Thread.Sleep(2000);
                        //Click delete cases
                        wait.Until(ExpectedConditions.ElementExists((By)DeleteCasesFromMoreOptions));
                        Thread.Sleep(2000);
                        driver.FindElement(DeleteCasesFromMoreOptions).Click();
                        Thread.Sleep(2000);
                        //Click delete on the overlay
                        wait.Until(ExpectedConditions.ElementExists((By)DeleteCasesOverlayBtn));
                        Thread.Sleep(2000);
                        driver.FindElement(DeleteCasesOverlayBtn).Click();
                        Thread.Sleep(10000);
                        wait.Until(ExpectedConditions.ElementExists((By)CustomerCasesTitle));
                        Cases++;
                        if (driver.FindElements(AnonOnCustomerHistory).Count() == 0)
                        {
                            Console.WriteLine("All cases removed");
                            break;
                        }
                    }
                    while (driver.FindElements(AnonOnCustomerHistory).Count() != 0);
                }
            }
            catch (Exception)
            {
                if (Cases == 0)
                {
                    Console.WriteLine("No cases were added to customer history");
                    Assert.Fail();
                }
            }
        }

        public void SignPostCaseBusiness()
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
            driver.FindElement(Searchbox).SendKeys("Test Cafe");
            driver.FindElement(Searchbox).SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            //Check result shows on the dropdown
            wait.Until(ExpectedConditions.ElementExists((By)ExistingBusinessSearchDropdown));
            Assert.IsTrue(driver.FindElement(ExistingBusinessSearchDropdown).Displayed);
            driver.FindElement(ExistingBusinessSearchDropdown).Click();
            Thread.Sleep(2000);
            //Check result is shown under access channel after selecting from dropdown
            wait.Until(ExpectedConditions.ElementExists((By)ExistingBusinessSearchResult));
            Assert.IsTrue(driver.FindElement(ExistingBusinessSearchResult).Displayed);
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
            wait.Until(ExpectedConditions.ElementExists((By)FAQSearchServiceResult));
            Assert.IsTrue(driver.FindElement(FAQSearchServiceResult).Displayed);
            driver.FindElement(FAQSearchServiceResult).Click();
            Thread.Sleep(2000);
            //Verify customer name and service shown on the create new case overlay
            driver.SwitchTo().DefaultContent();
            wait.Until(ExpectedConditions.ElementExists((By)BusinessNameOnNewCaseOverlay));
            Assert.IsTrue(driver.FindElement(BusinessNameOnNewCaseOverlay).Displayed);
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
            //Select private land
            Actions actions = new Actions(driver);
            actions.SendKeys(Keys.PageDown).Build().Perform();
            Thread.Sleep(2000);
            driver.FindElement(DogFoulingLandType).Click();
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)DogFoulingLandPrivate));
            driver.FindElement(DogFoulingLandPrivate).Click();
            Thread.Sleep(2000);
            driver.FindElement(DogFoulingLandType).Click();
            Thread.Sleep(2000);
            //Click signpost
            driver.SwitchTo().Frame("WebResource_allocatingpanel");
            wait.Until(ExpectedConditions.ElementExists((By)SignpostBtn));
            Thread.Sleep(2000);
            driver.FindElement(SignpostBtn).Click();
            Thread.Sleep(2000);
            //Select bespoke signposting from dropdown
            wait.Until(ExpectedConditions.ElementExists((By)ResolveDropdown));
            driver.FindElement(ResolveDropdown).Click();
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)BespokeSignposting));
            driver.FindElement(BespokeSignposting).Click();
            Thread.Sleep(2000);
            //Enter text in to text box
            wait.Until(ExpectedConditions.ElementExists((By)BespokeSignpostingTextBox));
            driver.FindElement(BespokeSignpostingTextBox).Click();
            Thread.Sleep(2000);
            driver.FindElement(BespokeSignpostingTextBox).SendKeys("This is a signpost message");
            Thread.Sleep(2000);
            //Click submit
            wait.Until(ExpectedConditions.ElementExists((By)StatusSubmitBtn));
            driver.FindElement(StatusSubmitBtn).Click();
            Thread.Sleep(2000);
            driver.SwitchTo().DefaultContent();
            //Verify case summary page loads
            wait.Until(ExpectedConditions.ElementExists((By)CustomerInfoTitleOnCaseSummary));
            Assert.IsTrue(driver.FindElement(CustomerInfoTitleOnCaseSummary).Displayed);
            //Verify SLA empty
            wait.Until(ExpectedConditions.ElementExists((By)EmptySLAOnCaseSummary));
            Assert.IsTrue(driver.FindElement(EmptySLAOnCaseSummary).Displayed);
            Thread.Sleep(2000);
            //Click refresh button
            var Status = 0;
            try
            {
                if (driver.FindElements(SignpostedJobStatus).Count() != 0)
                {
                    Console.WriteLine("Job status changed from in progress");
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                do
                {
                    driver.FindElement(RefreshButtonOnCaseDetails).Click();
                    Thread.Sleep(5000);
                    Status++;
                    if (driver.FindElements(SignpostedJobStatus).Count() != 0)
                    {
                        break;
                    }
                    else if (Status == 10)
                    {
                        Console.WriteLine("Job status not updated from in progress");
                        Assert.Fail();
                    }
                } while (driver.FindElements(SignpostedJobStatus).Count() == 0);
            }
            //Verify status updated to signposted
            wait.Until(ExpectedConditions.ElementExists((By)SignpostedJobStatus));
            Assert.IsTrue(driver.FindElement(SignpostedJobStatus).Displayed);
            Thread.Sleep(2000);
            //Select wakefield case from allocated case dropdown
            wait.Until(ExpectedConditions.ElementExists((By)AllocatedCaseForm));
            driver.FindElement(AllocatedCaseForm).Click();
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)AllocatedCaseDropdownWakefield));
            driver.FindElement(AllocatedCaseDropdownWakefield).Click();
            Thread.Sleep(2000);
            //Verify case details form loads
            wait.Until(ExpectedConditions.ElementExists((By)CaseDetailsForm));
            Assert.IsTrue(driver.FindElement(CaseDetailsForm).Displayed);
            Thread.Sleep(2000);
            //Verify last customer update shows no message
            wait.Until(ExpectedConditions.ElementExists((By)StatusUpdateAdded));
            Assert.IsFalse(driver.FindElement(StatusUpdateAdded).Text.Equals("This is a signpost message"));
            Thread.Sleep(2000);
            //Verify status message shown on timeline
            wait.Until(ExpectedConditions.ElementExists((By)TimelineStatusClosed));
            Assert.IsTrue(driver.FindElement(TimelineStatusClosed).Displayed);
            Thread.Sleep(2000);
            //Click customer updates/history
            driver.FindElement(HistoryTabOnCustomer).Click();
            Thread.Sleep(2000);
            //Verify bespoke message is shown
            wait.Until(ExpectedConditions.ElementExists((By)BespokeMsgOnHistoryTab));
            Assert.IsTrue(driver.FindElement(BespokeMsgOnHistoryTab).Displayed);
            Thread.Sleep(2000);
            //Click back to summary tab
            driver.FindElement(CaseDetailsSummaryTab).Click();
            Thread.Sleep(2000);
            //Click case form link on service details
            Assert.IsTrue(driver.FindElement(ServiceFormLink).Displayed);
            Thread.Sleep(2000);
            driver.FindElement(ServiceFormLink).Click();
            Thread.Sleep(2000);
            //Verify form loads
            wait.Until(ExpectedConditions.ElementExists((By)DogFoulingFormTitle));
            Assert.IsTrue(driver.FindElement(DogFoulingFormTitle).Displayed);
            Thread.Sleep(2000);
            //Verify message shows record is inactive
            wait.Until(ExpectedConditions.ElementExists((By)DogFoulingFormStatusInactive));
            Assert.IsTrue(driver.FindElement(DogFoulingFormStatusInactive).Displayed);
            Thread.Sleep(2000);
            //Click dashboards in LHN
            driver.FindElement(DashboardsLHN).Click();
            Thread.Sleep(2000);
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
            driver.FindElement(Searchbox).SendKeys("Test Cafe");
            driver.FindElement(Searchbox).SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            //Check result shows on the dropdown
            wait.Until(ExpectedConditions.ElementExists((By)ExistingBusinessSearchDropdown));
            Assert.IsTrue(driver.FindElement(ExistingBusinessSearchDropdown).Displayed);
            driver.FindElement(ExistingBusinessSearchDropdown).Click();
            Thread.Sleep(2000);
            //Check result is shown under access channel after selecting from dropdown
            wait.Until(ExpectedConditions.ElementExists((By)ExistingBusinessSearchResult));
            Assert.IsTrue(driver.FindElement(ExistingBusinessSearchResult).Displayed);
            Thread.Sleep(5000);
            //Verify job status shows as resolved
            wait.Until(ExpectedConditions.ElementExists((By)CaseHistoryResolved));
            Assert.IsTrue(driver.FindElement(CaseHistoryResolved).Displayed);
            Thread.Sleep(2000);
            //Click customer name
            driver.FindElement(ExistingBusinessSearchResult).Click();
            Thread.Sleep(2000);
            driver.SwitchTo().DefaultContent();
            Thread.Sleep(2000);
            //Click history tab
            driver.FindElement(HistoryTabOnCustomer).Click();
            Thread.Sleep(2000);
            Actions action = new Actions(driver);
            action.SendKeys(Keys.PageDown).Build().Perform();
            var Cases = 0;
            try
            {
                if (driver.FindElements(BusinessNameOnCustomerHistory).Count() != 0)
                    Console.WriteLine("Cases present on customer history");
                {
                    do
                    {
                        //Click select all cases
                        wait.Until(ExpectedConditions.ElementExists((By)SelectAllCasesBtn));
                        Thread.Sleep(3000);
                        driver.FindElement(SelectAllCasesBtn).Click();
                        Thread.Sleep(2000);
                        //Click more options dots
                        wait.Until(ExpectedConditions.ElementExists((By)MoreOptionsDotsOnCustomerCases));
                        Thread.Sleep(2000);
                        driver.FindElement(MoreOptionsDotsOnCustomerCases).Click();
                        Thread.Sleep(2000);
                        //Click delete cases
                        wait.Until(ExpectedConditions.ElementExists((By)DeleteCasesFromMoreOptions));
                        Thread.Sleep(2000);
                        driver.FindElement(DeleteCasesFromMoreOptions).Click();
                        Thread.Sleep(2000);
                        //Click delete on the overlay
                        wait.Until(ExpectedConditions.ElementExists((By)DeleteCasesOverlayBtn));
                        Thread.Sleep(2000);
                        driver.FindElement(DeleteCasesOverlayBtn).Click();
                        Thread.Sleep(10000);
                        wait.Until(ExpectedConditions.ElementExists((By)CustomerCasesTitle));
                        Cases++;
                        if (driver.FindElements(BusinessNameOnCustomerHistory).Count() == 0)
                        {
                            Console.WriteLine("All cases removed");
                            break;
                        }
                    }
                    while (driver.FindElements(BusinessNameOnCustomerHistory).Count() != 0);
                }
            }
            catch (Exception)
            {
                if (Cases == 0)
                {
                    Console.WriteLine("No cases were added to customer history");
                    Assert.Fail();
                }
            }
        }

        public void SignPostCaseBusinessUA()
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
            driver.FindElement(Searchbox).SendKeys("Unknown Business");
            driver.FindElement(Searchbox).SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            //Check result shows on the dropdown
            wait.Until(ExpectedConditions.ElementExists((By)UABusinessSearchDropdown));
            Assert.IsTrue(driver.FindElement(UABusinessSearchDropdown).Displayed);
            driver.FindElement(UABusinessSearchDropdown).Click();
            Thread.Sleep(2000);
            //Check result is shown under access channel after selecting from dropdown
            wait.Until(ExpectedConditions.ElementExists((By)UABusinessSearchResult));
            Assert.IsTrue(driver.FindElement(UABusinessSearchResult).Displayed);
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
            wait.Until(ExpectedConditions.ElementExists((By)FAQSearchServiceResult));
            Assert.IsTrue(driver.FindElement(FAQSearchServiceResult).Displayed);
            driver.FindElement(FAQSearchServiceResult).Click();
            Thread.Sleep(2000);
            //Verify customer name and service shown on the create new case overlay
            driver.SwitchTo().DefaultContent();
            wait.Until(ExpectedConditions.ElementExists((By)UABusinessOnNewCaseOverlay));
            Assert.IsTrue(driver.FindElement(UABusinessOnNewCaseOverlay).Displayed);
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
            //Select private land
            Actions actions = new Actions(driver);
            actions.SendKeys(Keys.PageDown).Build().Perform();
            Thread.Sleep(2000);
            driver.FindElement(DogFoulingLandType).Click();
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)DogFoulingLandPrivate));
            driver.FindElement(DogFoulingLandPrivate).Click();
            Thread.Sleep(2000);
            driver.FindElement(DogFoulingLandType).Click();
            Thread.Sleep(2000);
            //Click signpost
            driver.SwitchTo().Frame("WebResource_allocatingpanel");
            wait.Until(ExpectedConditions.ElementExists((By)SignpostBtn));
            Thread.Sleep(2000);
            driver.FindElement(SignpostBtn).Click();
            Thread.Sleep(2000);
            //Select bespoke signposting from dropdown
            wait.Until(ExpectedConditions.ElementExists((By)ResolveDropdown));
            driver.FindElement(ResolveDropdown).Click();
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)BespokeSignposting));
            driver.FindElement(BespokeSignposting).Click();
            Thread.Sleep(2000);
            //Enter text in to text box
            wait.Until(ExpectedConditions.ElementExists((By)BespokeSignpostingTextBox));
            driver.FindElement(BespokeSignpostingTextBox).Click();
            Thread.Sleep(2000);
            driver.FindElement(BespokeSignpostingTextBox).SendKeys("This is a signpost message");
            Thread.Sleep(2000);
            //Click submit
            wait.Until(ExpectedConditions.ElementExists((By)StatusSubmitBtn));
            driver.FindElement(StatusSubmitBtn).Click();
            Thread.Sleep(2000);
            driver.SwitchTo().DefaultContent();
            //Verify case summary page loads
            wait.Until(ExpectedConditions.ElementExists((By)CustomerInfoTitleOnCaseSummary));
            Assert.IsTrue(driver.FindElement(CustomerInfoTitleOnCaseSummary).Displayed);
            //Verify SLA empty
            wait.Until(ExpectedConditions.ElementExists((By)EmptySLAOnCaseSummary));
            Assert.IsTrue(driver.FindElement(EmptySLAOnCaseSummary).Displayed);
            Thread.Sleep(2000);
            //Click refresh button
            var Status = 0;
            try
            {
                if (driver.FindElements(SignpostedJobStatus).Count() != 0)
                {
                    Console.WriteLine("Job status changed from in progress");
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                do
                {
                    driver.FindElement(RefreshButtonOnCaseDetails).Click();
                    Thread.Sleep(5000);
                    Status++;
                    if (driver.FindElements(SignpostedJobStatus).Count() != 0)
                    {
                        break;
                    }
                    else if (Status == 10)
                    {
                        Console.WriteLine("Job status not updated from in progress");
                        Assert.Fail();
                    }
                } while (driver.FindElements(SignpostedJobStatus).Count() == 0);
            }
            //Verify status updated to signposted
            wait.Until(ExpectedConditions.ElementExists((By)SignpostedJobStatus));
            Assert.IsTrue(driver.FindElement(SignpostedJobStatus).Displayed);
            Thread.Sleep(2000);
            //Select wakefield case from allocated case dropdown
            wait.Until(ExpectedConditions.ElementExists((By)AllocatedCaseForm));
            driver.FindElement(AllocatedCaseForm).Click();
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)AllocatedCaseDropdownWakefield));
            driver.FindElement(AllocatedCaseDropdownWakefield).Click();
            Thread.Sleep(2000);
            //Verify case details form loads
            wait.Until(ExpectedConditions.ElementExists((By)CaseDetailsForm));
            Assert.IsTrue(driver.FindElement(CaseDetailsForm).Displayed);
            Thread.Sleep(2000);
            //Verify last customer update shows no message
            wait.Until(ExpectedConditions.ElementExists((By)StatusUpdateAdded));
            Assert.IsFalse(driver.FindElement(StatusUpdateAdded).Text.Equals("This is a signpost message"));
            Thread.Sleep(2000);
            //Verify status message shown on timeline
            wait.Until(ExpectedConditions.ElementExists((By)TimelineStatusClosed));
            Assert.IsTrue(driver.FindElement(TimelineStatusClosed).Displayed);
            Thread.Sleep(2000);
            //Click customer updates/history
            driver.FindElement(HistoryTabOnCustomer).Click();
            Thread.Sleep(2000);
            //Verify bespoke message is shown
            wait.Until(ExpectedConditions.ElementExists((By)BespokeMsgOnHistoryTab));
            Assert.IsTrue(driver.FindElement(BespokeMsgOnHistoryTab).Displayed);
            Thread.Sleep(2000);
            //Click back to summary tab
            driver.FindElement(CaseDetailsSummaryTab).Click();
            Thread.Sleep(2000);
            //Click case form link on service details
            Assert.IsTrue(driver.FindElement(ServiceFormLink).Displayed);
            Thread.Sleep(2000);
            driver.FindElement(ServiceFormLink).Click();
            Thread.Sleep(2000);
            //Verify form loads
            wait.Until(ExpectedConditions.ElementExists((By)DogFoulingFormTitle));
            Assert.IsTrue(driver.FindElement(DogFoulingFormTitle).Displayed);
            Thread.Sleep(2000);
            //Verify message shows record is inactive
            wait.Until(ExpectedConditions.ElementExists((By)DogFoulingFormStatusInactive));
            Assert.IsTrue(driver.FindElement(DogFoulingFormStatusInactive).Displayed);
            Thread.Sleep(2000);
            //Click dashboards in LHN
            driver.FindElement(DashboardsLHN).Click();
            Thread.Sleep(2000);
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
            driver.FindElement(Searchbox).SendKeys("Unknown Business");
            driver.FindElement(Searchbox).SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            //Check result shows on the dropdown
            wait.Until(ExpectedConditions.ElementExists((By)UABusinessSearchDropdown));
            Assert.IsTrue(driver.FindElement(UABusinessSearchDropdown).Displayed);
            driver.FindElement(UABusinessSearchDropdown).Click();
            Thread.Sleep(2000);
            //Check result is shown under access channel after selecting from dropdown
            wait.Until(ExpectedConditions.ElementExists((By)UABusinessSearchResult));
            Assert.IsTrue(driver.FindElement(UABusinessSearchResult).Displayed);
            Thread.Sleep(5000);
            //Verify job status shows as resolved
            wait.Until(ExpectedConditions.ElementExists((By)CaseHistoryResolved));
            Assert.IsTrue(driver.FindElement(CaseHistoryResolved).Displayed);
            Thread.Sleep(2000);
            //Click customer name
            driver.FindElement(UABusinessSearchResult).Click();
            Thread.Sleep(2000);
            driver.SwitchTo().DefaultContent();
            Thread.Sleep(2000);
            //Click history tab
            driver.FindElement(HistoryTabOnCustomer).Click();
            Thread.Sleep(2000);
            Actions action = new Actions(driver);
            action.SendKeys(Keys.PageDown).Build().Perform();
            var Cases = 0;
            try
            {
                if (driver.FindElements(UABusinessOnCustomerHistory).Count() != 0)
                    Console.WriteLine("Cases present on customer history");
                {
                    do
                    {
                        //Click select all cases
                        wait.Until(ExpectedConditions.ElementExists((By)SelectAllCasesBtn));
                        Thread.Sleep(3000);
                        driver.FindElement(SelectAllCasesBtn).Click();
                        Thread.Sleep(2000);
                        //Click more options dots
                        wait.Until(ExpectedConditions.ElementExists((By)MoreOptionsDotsOnCustomerCases));
                        Thread.Sleep(2000);
                        driver.FindElement(MoreOptionsDotsOnCustomerCases).Click();
                        Thread.Sleep(2000);
                        //Click delete cases
                        wait.Until(ExpectedConditions.ElementExists((By)DeleteCasesFromMoreOptions));
                        Thread.Sleep(2000);
                        driver.FindElement(DeleteCasesFromMoreOptions).Click();
                        Thread.Sleep(2000);
                        //Click delete on the overlay
                        wait.Until(ExpectedConditions.ElementExists((By)DeleteCasesOverlayBtn));
                        Thread.Sleep(2000);
                        driver.FindElement(DeleteCasesOverlayBtn).Click();
                        Thread.Sleep(10000);
                        wait.Until(ExpectedConditions.ElementExists((By)CustomerCasesTitle));
                        Cases++;
                        if (driver.FindElements(UABusinessOnCustomerHistory).Count() == 0)
                        {
                            Console.WriteLine("All cases removed");
                            break;
                        }
                    }
                    while (driver.FindElements(UABusinessOnCustomerHistory).Count() != 0);
                }
            }
            catch (Exception)
            {
                if (Cases == 0)
                {
                    Console.WriteLine("No cases were added to customer history");
                    Assert.Fail();
                }
            }
        }

        public void SignPostCaseOnBehalfOfBusiness()
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
            wait.Until(ExpectedConditions.ElementExists((By)Searchbox));
            Assert.IsTrue(driver.FindElement(Searchbox).Displayed);
            //Enter fullname in search
            driver.FindElement(Searchbox).Click();
            driver.FindElement(Searchbox).SendKeys("Test Business");
            driver.FindElement(Searchbox).SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            //Check result shows on the dropdown
            wait.Until(ExpectedConditions.ElementExists((By)TestBusinessInDropdown));
            driver.FindElement(OnBehalfOfInDropdown).Click();
            driver.FindElement(TestBusinessInDropdown).Click();
            Thread.Sleep(2000);
            //Remove search term from box
            driver.FindElement(Searchbox).Click();
            Actions action = new Actions(driver);
            WebElement ele = (WebElement)driver.FindElement(Searchbox);
            action.Click(ele).Click(ele).Click(ele).Perform();
            driver.FindElement(Searchbox).SendKeys(Keys.Delete);
            //Search for different customer
            Thread.Sleep(2000);
            driver.FindElement(Searchbox).SendKeys("Test cafe");
            driver.FindElement(Searchbox).SendKeys(Keys.Enter);
            wait.Until(ExpectedConditions.ElementExists((By)ExistingBusinessSearchDropdown));
            Assert.IsTrue(driver.FindElement(ExistingBusinessSearchDropdown).Displayed);
            driver.FindElement(ExistingBusinessSearchDropdown).Click();
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)ExistingBusinessSearchResult));
            Assert.IsTrue(driver.FindElement(ExistingBusinessSearchResult).Displayed);
            Thread.Sleep(2000);
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
            wait.Until(ExpectedConditions.ElementExists((By)FAQSearchServiceResult));
            Assert.IsTrue(driver.FindElement(FAQSearchServiceResult).Displayed);
            driver.FindElement(FAQSearchServiceResult).Click();
            Thread.Sleep(2000);
            //Verify customer name and service shown on the create new case overlay
            driver.SwitchTo().DefaultContent();
            wait.Until(ExpectedConditions.ElementExists((By)BusinessNameOnNewCaseOverlay));
            Assert.IsTrue(driver.FindElement(BusinessNameOnNewCaseOverlay).Displayed);
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
            //Select private land
            Actions actions = new Actions(driver);
            actions.SendKeys(Keys.PageDown).Build().Perform();
            Thread.Sleep(2000);
            driver.FindElement(DogFoulingLandType).Click();
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)DogFoulingLandPrivate));
            driver.FindElement(DogFoulingLandPrivate).Click();
            Thread.Sleep(2000);
            driver.FindElement(DogFoulingLandType).Click();
            Thread.Sleep(2000);
            //Click signpost
            driver.SwitchTo().Frame("WebResource_allocatingpanel");
            wait.Until(ExpectedConditions.ElementExists((By)SignpostBtn));
            Thread.Sleep(2000);
            driver.FindElement(SignpostBtn).Click();
            Thread.Sleep(2000);
            //Select bespoke signposting from dropdown
            wait.Until(ExpectedConditions.ElementExists((By)ResolveDropdown));
            driver.FindElement(ResolveDropdown).Click();
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)BespokeSignposting));
            driver.FindElement(BespokeSignposting).Click();
            Thread.Sleep(2000);
            //Enter text in to text box
            wait.Until(ExpectedConditions.ElementExists((By)BespokeSignpostingTextBox));
            driver.FindElement(BespokeSignpostingTextBox).Click();
            Thread.Sleep(2000);
            driver.FindElement(BespokeSignpostingTextBox).SendKeys("This is a signpost message");
            Thread.Sleep(2000);
            //Click submit
            wait.Until(ExpectedConditions.ElementExists((By)StatusSubmitBtn));
            driver.FindElement(StatusSubmitBtn).Click();
            Thread.Sleep(2000);
            driver.SwitchTo().DefaultContent();
            //Verify case summary page loads
            wait.Until(ExpectedConditions.ElementExists((By)CustomerInfoTitleOnCaseSummary));
            Assert.IsTrue(driver.FindElement(CustomerInfoTitleOnCaseSummary).Displayed);
            //Verify SLA empty
            wait.Until(ExpectedConditions.ElementExists((By)EmptySLAOnCaseSummary));
            Assert.IsTrue(driver.FindElement(EmptySLAOnCaseSummary).Displayed);
            Thread.Sleep(2000);
            //Click refresh button
            var Status = 0;
            try
            {
                if (driver.FindElements(SignpostedJobStatus).Count() != 0)
                {
                    Console.WriteLine("Job status changed from in progress");
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                do
                {
                    driver.FindElement(RefreshButtonOnCaseDetails).Click();
                    Thread.Sleep(5000);
                    Status++;
                    if (driver.FindElements(SignpostedJobStatus).Count() != 0)
                    {
                        break;
                    }
                    else if (Status == 10)
                    {
                        Console.WriteLine("Job status not updated from in progress");
                        Assert.Fail();
                    }
                } while (driver.FindElements(SignpostedJobStatus).Count() == 0);
            }
            //Verify status updated to signposted
            wait.Until(ExpectedConditions.ElementExists((By)SignpostedJobStatus));
            Assert.IsTrue(driver.FindElement(SignpostedJobStatus).Displayed);
            Thread.Sleep(2000);
            //Select wakefield case from allocated case dropdown
            wait.Until(ExpectedConditions.ElementExists((By)AllocatedCaseForm));
            driver.FindElement(AllocatedCaseForm).Click();
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)AllocatedCaseDropdownWakefield));
            driver.FindElement(AllocatedCaseDropdownWakefield).Click();
            Thread.Sleep(2000);
            //Verify case details form loads
            wait.Until(ExpectedConditions.ElementExists((By)CaseDetailsForm));
            Assert.IsTrue(driver.FindElement(CaseDetailsForm).Displayed);
            Thread.Sleep(2000);
            //Verify last customer update shows no message
            wait.Until(ExpectedConditions.ElementExists((By)StatusUpdateAdded));
            Assert.IsFalse(driver.FindElement(StatusUpdateAdded).Text.Equals("This is a signpost message"));
            Thread.Sleep(2000);
            //Verify status message shown on timeline
            wait.Until(ExpectedConditions.ElementExists((By)TimelineStatusClosed));
            Assert.IsTrue(driver.FindElement(TimelineStatusClosed).Displayed);
            Thread.Sleep(2000);
            //Click customer updates/history
            driver.FindElement(HistoryTabOnCustomer).Click();
            Thread.Sleep(2000);
            //Verify bespoke message is shown
            wait.Until(ExpectedConditions.ElementExists((By)BespokeMsgOnHistoryTab));
            Assert.IsTrue(driver.FindElement(BespokeMsgOnHistoryTab).Displayed);
            Thread.Sleep(2000);
            //Verify customer and reporter names are displayed
            wait.Until(ExpectedConditions.ElementExists((By)BusinessNameOnCustomerCases));
            Assert.IsTrue(driver.FindElement(BusinessNameOnCustomerCases).Displayed);
            //Click back to summary tab
            driver.FindElement(CaseDetailsSummaryTab).Click();
            Thread.Sleep(2000);
            //Click case form link on service details
            Assert.IsTrue(driver.FindElement(ServiceFormLink).Displayed);
            Thread.Sleep(2000);
            driver.FindElement(ServiceFormLink).Click();
            Thread.Sleep(2000);
            //Verify form loads
            wait.Until(ExpectedConditions.ElementExists((By)DogFoulingFormTitle));
            Assert.IsTrue(driver.FindElement(DogFoulingFormTitle).Displayed);
            Thread.Sleep(2000);
            //Verify message shows record is inactive
            wait.Until(ExpectedConditions.ElementExists((By)DogFoulingFormStatusInactive));
            Assert.IsTrue(driver.FindElement(DogFoulingFormStatusInactive).Displayed);
            Thread.Sleep(2000);
            //Click dashboards in LHN
            driver.FindElement(DashboardsLHN).Click();
            Thread.Sleep(2000);
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
            driver.FindElement(Searchbox).SendKeys("Test Business");
            driver.FindElement(Searchbox).SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            //Check result shows on the dropdown
            wait.Until(ExpectedConditions.ElementExists((By)TestBusinessInDropdown));
            driver.FindElement(TestBusinessInDropdown).Click();
            Thread.Sleep(2000);
            //Check result is shown under access channel after selecting from dropdown
            wait.Until(ExpectedConditions.ElementExists((By)TestBusinessInAccessChannel));
            Assert.IsTrue(driver.FindElement(TestBusinessInAccessChannel).Displayed);
            Thread.Sleep(5000);
            //Verify job status shows as cancelled
            wait.Until(ExpectedConditions.ElementExists((By)CaseHistoryResolved));
            Assert.IsTrue(driver.FindElement(CaseHistoryResolved).Displayed);
            Thread.Sleep(2000);
            //Verify on behalf of asterisk is shown
            wait.Until(ExpectedConditions.ElementExists((By)CaseHistoryAsterisk));
            Assert.IsTrue(driver.FindElement(CaseHistoryAsterisk).Displayed);
            //Click customer name
            driver.FindElement(TestBusinessInAccessChannel).Click();
            Thread.Sleep(2000);
            driver.SwitchTo().DefaultContent();
            Thread.Sleep(2000);
            //Click history tab
            wait.Until(ExpectedConditions.ElementExists((By)HistoryTabOnCustomer));
            driver.FindElement(HistoryTabOnCustomer).Click();
            Thread.Sleep(2000);
            try
            {
                do
                {
                    //Click select all cases
                    wait.Until(ExpectedConditions.ElementExists((By)SelectAllCasesBtn));
                    Thread.Sleep(3000);
                    driver.FindElement(SelectAllCasesBtn).Click();
                    Thread.Sleep(2000);
                    //Click more options dots
                    wait.Until(ExpectedConditions.ElementExists((By)MoreOptionsDotsOnCustomerCases));
                    Thread.Sleep(2000);
                    driver.FindElement(MoreOptionsDotsOnCustomerCases).Click();
                    Thread.Sleep(2000);
                    //Click delete cases
                    wait.Until(ExpectedConditions.ElementExists((By)DeleteCasesFromMoreOptions));
                    Thread.Sleep(2000);
                    driver.FindElement(DeleteCasesFromMoreOptions).Click();
                    Thread.Sleep(2000);
                    //Click delete on the overlay
                    wait.Until(ExpectedConditions.ElementExists((By)DeleteCasesOverlayBtn));
                    Thread.Sleep(2000);
                    driver.FindElement(DeleteCasesOverlayBtn).Click();
                    Thread.Sleep(10000);
                    wait.Until(ExpectedConditions.ElementExists((By)CustomerCasesTitle));
                }
                while (driver.FindElement(TestBusinessOnCustomerHistory).Displayed);
            }
            catch (Exception)
            {
                Console.WriteLine("All cases removed from history screen");
            }
            //Verify cases deleted
            var Cases = 0;
            try
            {
                WebElement cases = (WebElement)driver.FindElement(TestBusinessOnCustomerHistory);
                if (cases.Displayed)
                {
                    Cases = 1;
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                if (Cases > 0)
                {
                    Console.WriteLine("Cases not removed");
                }
                else
                {
                    Console.WriteLine("Cases removed");
                }
            }
        }

        public void CaseHistoryInAccessChannel()
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
            driver.FindElement(Searchbox).SendKeys("Gary Casehistory");
            driver.FindElement(Searchbox).SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            //Check result shows on the dropdown
            wait.Until(ExpectedConditions.ElementExists((By)CaseHistoryDetailsOnDropdown));
            Assert.IsTrue(driver.FindElement(CaseHistoryDetailsOnDropdown).Displayed);
            driver.FindElement(CaseHistoryDetailsOnDropdown).Click();
            Thread.Sleep(2000);
            //Check result is shown under access channel after selecting from dropdown
            wait.Until(ExpectedConditions.ElementExists((By)CasehistorySearchResult));
            Assert.IsTrue(driver.FindElement(CasehistorySearchResult).Displayed);
            //Check table headings on case history
            wait.Until(ExpectedConditions.ElementExists((By)CaseHistoryTable));
            Assert.IsTrue(driver.FindElement(CaseHistoryTable).Displayed);
            Thread.Sleep(2000);
            try
            {
                //Check table heading 1 = reference
                Assert.IsTrue(driver.FindElement(CaseHistoryTableHeader1).Text.Contains("Reference"));
                //Check table heading 2 = date logged
                Assert.IsTrue(driver.FindElement(CaseHistoryTableHeader2).Text.Contains("Date Logged"));
                //Check table heading 3 = service type
                Assert.IsTrue(driver.FindElement(CaseHistoryTableHeader3).Text.Contains("Service Type"));
                //Check table heading 4 = status
                Assert.IsTrue(driver.FindElement(CaseHistoryTableHeader4).Text.Contains("Status"));

            }
            catch (Exception)
            {
                Console.WriteLine("Table headings incorrect");
            }

            try
            {
                //Verify most recent case is at the top
             //   Assert.IsTrue(driver.FindElement(CaseHistoryTableData1).Text.Contains("CAS-13738"));
             //   Assert.IsTrue(driver.FindElement(CaseHistoryTableData2).Text.Contains("CAS-13737"));
                Assert.IsTrue(driver.FindElement(CaseHistoryTableData1).Text.Contains("CAS-14252")); //test environment
                Assert.IsTrue(driver.FindElement(CaseHistoryTableData2).Text.Contains("CAS-14251")); //test environment
            }
            catch (Exception)
            {
                Console.WriteLine("Table data order incorrect");
            }
            //Click on case to view information
            //driver.FindElement(TopCaseOnList).Click();
            driver.FindElement(TopCaseOnList2).Click(); //test environment
            Thread.Sleep(2000);
            driver.SwitchTo().DefaultContent();
            Thread.Sleep(4000);
            wait.Until(ExpectedConditions.ElementExists((By)CaseDetailsForm));
            Assert.IsTrue(driver.FindElement(CaseDetailsForm).Displayed);

        }

        public void OOACaseHistoryInAccessChannel()
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
            //Check table headings on case history
            wait.Until(ExpectedConditions.ElementExists((By)CaseHistoryTable));
            Assert.IsTrue(driver.FindElement(CaseHistoryTable).Displayed);
            try
            {
                //Check table heading 1 = reference
                Assert.IsTrue(driver.FindElement(CaseHistoryTableHeader1).Text.Contains("Reference"));
                //Check table heading 2 = date logged
                Assert.IsTrue(driver.FindElement(CaseHistoryTableHeader2).Text.Contains("Date Logged"));
                //Check table heading 3 = service type
                Assert.IsTrue(driver.FindElement(CaseHistoryTableHeader3).Text.Contains("Service Type"));
                //Check table heading 4 = status
                Assert.IsTrue(driver.FindElement(CaseHistoryTableHeader4).Text.Contains("Status"));

            }
            catch (Exception)
            {
                Console.WriteLine("Table headings incorrect");
            }

            try
            {
                //Verify most recent case is at the top
            //    Assert.IsTrue(driver.FindElement(CaseHistoryTableData1).Text.Contains("CAS-13580"));
            //    Assert.IsTrue(driver.FindElement(CaseHistoryTableData2).Text.Contains("CAS-13579"));
                Assert.IsTrue(driver.FindElement(CaseHistoryTableData1).Text.Contains("CAS-14257"));//test environment
                Assert.IsTrue(driver.FindElement(CaseHistoryTableData2).Text.Contains("CAS-14256"));//test environment
            }
            catch (Exception)
            {
                Console.WriteLine("Table data order incorrect");
            }
            //Click on case to view information
        //    driver.FindElement(OOATopCaseOnList).Click();
            driver.FindElement(OOATopCaseOnList2).Click();//test environment
            Thread.Sleep(2000);
            driver.SwitchTo().DefaultContent();
            Thread.Sleep(4000);
            wait.Until(ExpectedConditions.ElementExists((By)CaseDetailsForm));
            Assert.IsTrue(driver.FindElement(CaseDetailsForm).Displayed);

        }

        public void MACaseHistoryInAccessChannel()
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
            driver.FindElement(Searchbox).SendKeys("Manualaddress Casehistory");
            driver.FindElement(Searchbox).SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            //Check result shows on the dropdown
            wait.Until(ExpectedConditions.ElementExists((By)MASearchDropdown));
            Assert.IsTrue(driver.FindElement(MASearchDropdown).Displayed);
            driver.FindElement(MASearchDropdown).Click();
            Thread.Sleep(2000);
            //Check result is shown under access channel after selecting from dropdown
            wait.Until(ExpectedConditions.ElementExists((By)MACasehistorySearchResult));
            Assert.IsTrue(driver.FindElement(MACasehistorySearchResult).Displayed);
            //Check table headings on case history
            wait.Until(ExpectedConditions.ElementExists((By)CaseHistoryTable));
            Assert.IsTrue(driver.FindElement(CaseHistoryTable).Displayed);
            Thread.Sleep(2000);
            try
            {
                //Check table heading 1 = reference
                Assert.IsTrue(driver.FindElement(CaseHistoryTableHeader1).Text.Contains("Reference"));
                //Check table heading 2 = date logged
                Assert.IsTrue(driver.FindElement(CaseHistoryTableHeader2).Text.Contains("Date Logged"));
                //Check table heading 3 = service type
                Assert.IsTrue(driver.FindElement(CaseHistoryTableHeader3).Text.Contains("Service Type"));
                //Check table heading 4 = status
                Assert.IsTrue(driver.FindElement(CaseHistoryTableHeader4).Text.Contains("Status"));

            }
            catch (Exception)
            {
                Console.WriteLine("Table headings incorrect");
            }

            try
            {
                //Verify most recent case is at the top
             //   Assert.IsTrue(driver.FindElement(CaseHistoryTableData1).Text.Contains("CAS-13856"));
             //   Assert.IsTrue(driver.FindElement(CaseHistoryTableData2).Text.Contains("CAS-13855"));
                Assert.IsTrue(driver.FindElement(CaseHistoryTableData1).Text.Contains("CAS-14254"));//test environment
                Assert.IsTrue(driver.FindElement(CaseHistoryTableData2).Text.Contains("CAS-14253"));//test environment
            }
            catch (Exception)
            {
                Console.WriteLine("Table data order incorrect");
            }
            //Click on case to view information
         //   driver.FindElement(MATopCaseOnList).Click();
            driver.FindElement(MATopCaseOnList2).Click();//test environment
            Thread.Sleep(2000);
            driver.SwitchTo().DefaultContent();
            Thread.Sleep(4000);
            wait.Until(ExpectedConditions.ElementExists((By)CaseDetailsForm));
            Assert.IsTrue(driver.FindElement(CaseDetailsForm).Displayed);

        }

        public void UACaseHistoryInAccessChannel()
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
            driver.FindElement(Searchbox).SendKeys("Unknownaddress Casehistory");
            driver.FindElement(Searchbox).SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            //Check result shows on the dropdown
            wait.Until(ExpectedConditions.ElementExists((By)UACaseHistoryDetailsOnDropdown));
            Assert.IsTrue(driver.FindElement(UACaseHistoryDetailsOnDropdown).Displayed);
            driver.FindElement(UACaseHistoryDetailsOnDropdown).Click();
            Thread.Sleep(2000);
            //Check result is shown under access channel after selecting from dropdown
            wait.Until(ExpectedConditions.ElementExists((By)UnknownAddressSearchResult));
            Assert.IsTrue(driver.FindElement(UnknownAddressSearchResult).Displayed);
            //Check table headings on case history
            wait.Until(ExpectedConditions.ElementExists((By)CaseHistoryTable));
            Assert.IsTrue(driver.FindElement(CaseHistoryTable).Displayed);
            Thread.Sleep(2000);
            try
            {
                //Check table heading 1 = reference
                Assert.IsTrue(driver.FindElement(CaseHistoryTableHeader1).Text.Contains("Reference"));
                //Check table heading 2 = date logged
                Assert.IsTrue(driver.FindElement(CaseHistoryTableHeader2).Text.Contains("Date Logged"));
                //Check table heading 3 = service type
                Assert.IsTrue(driver.FindElement(CaseHistoryTableHeader3).Text.Contains("Service Type"));
                //Check table heading 4 = status
                Assert.IsTrue(driver.FindElement(CaseHistoryTableHeader4).Text.Contains("Status"));

            }
            catch (Exception)
            {
                Console.WriteLine("Table headings incorrect");
            }

            try
            {
                //Verify most recent case is at the top
            //    Assert.IsTrue(driver.FindElement(CaseHistoryTableData1).Text.Contains("CAS-14032"));
            //    Assert.IsTrue(driver.FindElement(CaseHistoryTableData2).Text.Contains("CAS-14031"));
                Assert.IsTrue(driver.FindElement(CaseHistoryTableData1).Text.Contains("CAS-14259"));//test environment
                Assert.IsTrue(driver.FindElement(CaseHistoryTableData2).Text.Contains("CAS-14258"));//test environment
            }
            catch (Exception)
            {
                Console.WriteLine("Table data order incorrect");
            }
            //Click on case to view information
        //    driver.FindElement(UATopCaseOnList).Click();
            driver.FindElement(UATopCaseOnList2).Click();//test environment
            Thread.Sleep(2000);
            driver.SwitchTo().DefaultContent();
            Thread.Sleep(4000);
            wait.Until(ExpectedConditions.ElementExists((By)CaseDetailsForm));
            Assert.IsTrue(driver.FindElement(CaseDetailsForm).Displayed);

        }

        public void BusinessCaseHistoryInAccessChannel()
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
            driver.FindElement(Searchbox).SendKeys("Business Casehistory");
            driver.FindElement(Searchbox).SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            //Check result shows on the dropdown
            wait.Until(ExpectedConditions.ElementExists((By)BusinessHistoryDetailsOnDropdown));
            Assert.IsTrue(driver.FindElement(BusinessHistoryDetailsOnDropdown).Displayed);
            driver.FindElement(BusinessHistoryDetailsOnDropdown).Click();
            Thread.Sleep(2000);
            //Check result is shown under access channel after selecting from dropdown
            wait.Until(ExpectedConditions.ElementExists((By)BusinessHistorySearchResult));
            Assert.IsTrue(driver.FindElement(BusinessHistorySearchResult).Displayed);
            //Check table headings on case history
            wait.Until(ExpectedConditions.ElementExists((By)CaseHistoryTable));
            Assert.IsTrue(driver.FindElement(CaseHistoryTable).Displayed);
            Thread.Sleep(2000);
            try
            {
                //Check table heading 1 = reference
                Assert.IsTrue(driver.FindElement(CaseHistoryTableHeader1).Text.Contains("Reference"));
                //Check table heading 2 = date logged
                Assert.IsTrue(driver.FindElement(CaseHistoryTableHeader2).Text.Contains("Date Logged"));
                //Check table heading 3 = service type
                Assert.IsTrue(driver.FindElement(CaseHistoryTableHeader3).Text.Contains("Service Type"));
                //Check table heading 4 = status
                Assert.IsTrue(driver.FindElement(CaseHistoryTableHeader4).Text.Contains("Status"));

            }
            catch (Exception)
            {
                Console.WriteLine("Table headings incorrect");
            }

            try
            {
                //Verify most recent case is at the top
            //    Assert.IsTrue(driver.FindElement(CaseHistoryTableData1).Text.Contains("CAS-14830"));
             //   Assert.IsTrue(driver.FindElement(CaseHistoryTableData2).Text.Contains("CAS-14829"));
                Assert.IsTrue(driver.FindElement(CaseHistoryTableData1).Text.Contains("CAS-14389")); //Test environment
                Assert.IsTrue(driver.FindElement(CaseHistoryTableData2).Text.Contains("CAS-14388")); //Test environment
            }
            catch (Exception)
            {
                Console.WriteLine("Table data order incorrect");
            }
            //Click on case to view information
         //   driver.FindElement(BusinessTopCaseOnList).Click();
            driver.FindElement(BusinessTopCaseOnList2).Click(); //Test environment
            Thread.Sleep(2000);
            driver.SwitchTo().DefaultContent();
            Thread.Sleep(4000);
            wait.Until(ExpectedConditions.ElementExists((By)CaseDetailsForm));
            Assert.IsTrue(driver.FindElement(CaseDetailsForm).Displayed);

        }

        public void UABusinessCaseHistoryInAccessChannel()
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
            driver.FindElement(Searchbox).SendKeys("Unknown Addresscases");
            driver.FindElement(Searchbox).SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            //Check result shows on the dropdown
            wait.Until(ExpectedConditions.ElementExists((By)UACasesSearchDropdown));
            Assert.IsTrue(driver.FindElement(UACasesSearchDropdown).Displayed);
            driver.FindElement(UACasesSearchDropdown).Click();
            Thread.Sleep(2000);
            //Check result is shown under access channel after selecting from dropdown
            wait.Until(ExpectedConditions.ElementExists((By)UACasesSearchResult));
            Assert.IsTrue(driver.FindElement(UACasesSearchResult).Displayed);
            //Check table headings on case history
            wait.Until(ExpectedConditions.ElementExists((By)CaseHistoryTable));
            Assert.IsTrue(driver.FindElement(CaseHistoryTable).Displayed);
            Thread.Sleep(2000);
            try
            {
                //Check table heading 1 = reference
                Assert.IsTrue(driver.FindElement(CaseHistoryTableHeader1).Text.Contains("Reference"));
                //Check table heading 2 = date logged
                Assert.IsTrue(driver.FindElement(CaseHistoryTableHeader2).Text.Contains("Date Logged"));
                //Check table heading 3 = service type
                Assert.IsTrue(driver.FindElement(CaseHistoryTableHeader3).Text.Contains("Service Type"));
                //Check table heading 4 = status
                Assert.IsTrue(driver.FindElement(CaseHistoryTableHeader4).Text.Contains("Status"));

            }
            catch (Exception)
            {
                Console.WriteLine("Table headings incorrect");
            }

            try
            {
                //Verify most recent case is at the top
             //   Assert.IsTrue(driver.FindElement(CaseHistoryTableData1).Text.Contains("CAS-14980"));
            //    Assert.IsTrue(driver.FindElement(CaseHistoryTableData2).Text.Contains("CAS-14979"));
                Assert.IsTrue(driver.FindElement(CaseHistoryTableData1).Text.Contains("CAS-14416"));//test environment
                Assert.IsTrue(driver.FindElement(CaseHistoryTableData2).Text.Contains("CAS-14415"));//test environment
            }
            catch (Exception)
            {
                Console.WriteLine("Table data order incorrect");
            }
            //Click on case to view information
        //    driver.FindElement(UABusinessTopCaseOnList).Click();
            driver.FindElement(UABusinessTopCaseOnList2).Click();//test environment
            Thread.Sleep(2000);
            driver.SwitchTo().DefaultContent();
            Thread.Sleep(4000);
            wait.Until(ExpectedConditions.ElementExists((By)CaseDetailsForm));
            Assert.IsTrue(driver.FindElement(CaseDetailsForm).Displayed);

        }

        public void DiscardACase() 
        {
            //Verify Home dashboard is displayed
            Thread.Sleep(4000);
            wait.Until(ExpectedConditions.ElementExists((By)DashboardsLHN));
            driver.FindElement(DashboardsLHN).Click();
            Thread.Sleep(2000);
            driver.FindElement(DashboardsLHN).Click();
            wait.Until(ExpectedConditions.ElementExists((By)DashboardTitle));
            Assert.IsTrue(driver.FindElement(DashboardTitle).Displayed);
            Thread.Sleep(3000);
            //Switch to searchbox iframe
            driver.SwitchTo().Frame(driver.FindElement(By.Id("9532b1de-41a1-456c-b21c-805faca15573_WebResource_customeradvisorstart")));
            wait.Until(ExpectedConditions.ElementExists((By)Searchbox));
            Assert.IsTrue(driver.FindElement(Searchbox).Displayed);
            //Enter fullname in search
            driver.FindElement(Searchbox).Click();
            driver.FindElement(Searchbox).SendKeys("Gary Moore");
            driver.FindElement(Searchbox).SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            //Check result shows on the dropdown
            wait.Until(ExpectedConditions.ElementExists((By)ExistingCustomerSearchDropdown));
            Assert.IsTrue(driver.FindElement(ExistingCustomerSearchDropdown).Displayed);
            driver.FindElement(ExistingCustomerSearchDropdown).Click();
            Thread.Sleep(2000);
            //Check result is shown under access channel after selecting from dropdown
            wait.Until(ExpectedConditions.ElementExists((By)ExistingCustomerSearchResult));
            Assert.IsTrue(driver.FindElement(ExistingCustomerSearchResult).Displayed);
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
            wait.Until(ExpectedConditions.ElementExists((By)LitterDogBinService));
            Assert.IsTrue(driver.FindElement(LitterDogBinService).Displayed);
            driver.FindElement(LitterDogBinService).Click();
            Thread.Sleep(2000);
            driver.SwitchTo().DefaultContent();
            //Click yes on overlay
            wait.Until(ExpectedConditions.ElementExists((By)YesBtnOnNewCaseOverlay));
            driver.FindElement(YesBtnOnNewCaseOverlay).Click();
            Thread.Sleep(3000);
            //Verify form loads
            wait.Until(ExpectedConditions.ElementExists((By)DogLitterBinFormTitle));
            Assert.IsTrue(driver.FindElement(DogLitterBinFormTitle).Displayed);
            //Enter address for location
            driver.SwitchTo().Frame("WebResource_WMDCAddressSearch");
            driver.FindElement(AddressSearchBox).Click();
            driver.FindElement(AddressSearchBox).SendKeys("Pontefract");
            Thread.Sleep(2000);
            driver.FindElement(AddressSearchBtn).Click();
            wait.Until(ExpectedConditions.ElementExists((By)DiscardedAddressSearchBoxResult));
            driver.FindElement(DiscardedAddressSearchBoxResult).Click();
            driver.SwitchTo().DefaultContent();
            Thread.Sleep(5000);
            //Click back button
            wait.Until(ExpectedConditions.ElementExists((By)BackBtn));
            driver.FindElement(BackBtn).Click();
            //Click discard changes on overlay
            wait.Until(ExpectedConditions.ElementExists((By)DiscardBtnOnOverlay));
            driver.FindElement(DiscardBtnOnOverlay).Click();
            Thread.Sleep(2000);
            //Verify dashboard is shown
            wait.Until(ExpectedConditions.ElementExists((By)DashboardTitle));
            Assert.IsTrue(driver.FindElement(DashboardTitle).Displayed);
            Thread.Sleep(3000);
            //Switch to searchbox iframe
            driver.SwitchTo().Frame(driver.FindElement(By.Id("9532b1de-41a1-456c-b21c-805faca15573_WebResource_customeradvisorstart")));
            wait.Until(ExpectedConditions.ElementExists((By)Searchbox));
            Assert.IsTrue(driver.FindElement(Searchbox).Displayed);
            //Enter fullname in search
            driver.FindElement(Searchbox).Click();
            driver.FindElement(Searchbox).SendKeys("Gary Moore");
            driver.FindElement(Searchbox).SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            //Check result shows on the dropdown
            wait.Until(ExpectedConditions.ElementExists((By)ExistingCustomerSearchDropdown));
            Assert.IsTrue(driver.FindElement(ExistingCustomerSearchDropdown).Displayed);
            driver.FindElement(ExistingCustomerSearchDropdown).Click();
            Thread.Sleep(2000);
            //Check result is shown under access channel after selecting from dropdown
            wait.Until(ExpectedConditions.ElementExists((By)ExistingCustomerSearchResult));
            Assert.IsTrue(driver.FindElement(ExistingCustomerSearchResult).Displayed);
            //Verify disgarded case is not displayed in case history
            wait.Until(ExpectedConditions.ElementExists((By)CaseHistoryTitle)); 
            wait.Until(ExpectedConditions.ElementExists((By)DiscardedCaseUnderAcessChannel));
            Assert.IsTrue(driver.FindElement(DiscardedCaseUnderAcessChannel).Displayed);
        }

        public void PauseCaseStatus()
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
            wait.Until(ExpectedConditions.ElementExists((By)Searchbox));
            Assert.IsTrue(driver.FindElement(Searchbox).Displayed);
            //Enter fullname in search
            driver.FindElement(Searchbox).Click();
            driver.FindElement(Searchbox).SendKeys("Gary Moore");
            driver.FindElement(Searchbox).SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            //Check result shows on the dropdown
            wait.Until(ExpectedConditions.ElementExists((By)ExistingCustomerSearchDropdown));
            Assert.IsTrue(driver.FindElement(ExistingCustomerSearchDropdown).Displayed);
            driver.FindElement(ExistingCustomerSearchDropdown).Click();
            Thread.Sleep(2000);
            //Check result is shown under access channel after selecting from dropdown
            wait.Until(ExpectedConditions.ElementExists((By)ExistingCustomerSearchResult));
            Assert.IsTrue(driver.FindElement(ExistingCustomerSearchResult).Displayed);
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
            wait.Until(ExpectedConditions.ElementExists((By)FAQSearchServiceResult));
            Assert.IsTrue(driver.FindElement(FAQSearchServiceResult).Displayed);
            driver.FindElement(FAQSearchServiceResult).Click();
            Thread.Sleep(2000);
            //Verify customer name and service shown on the create new case overlay
            driver.SwitchTo().DefaultContent();
            wait.Until(ExpectedConditions.ElementExists((By)CustomerNameOnNewCaseOverlay));
            Assert.IsTrue(driver.FindElement(CustomerNameOnNewCaseOverlay).Displayed);
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
            Thread.Sleep(2000);
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
            //Select wakefield case on dropdown
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)AllocatedCaseForm));
            driver.FindElement(AllocatedCaseForm).Click();
            wait.Until(ExpectedConditions.ElementExists((By)AllocatedCaseDropdownWakefield));
            driver.FindElement(AllocatedCaseDropdownWakefield).Click();
            Thread.Sleep(10000);
            //Verify case details page is displayed
            wait.Until(ExpectedConditions.ElementExists((By)CaseDetailsForm));
            Assert.IsTrue(driver.FindElement(CaseDetailsForm).Displayed);
            //Click plus button on timeline
            wait.Until(ExpectedConditions.ElementExists((By)AddTimelineRecord));
            driver.FindElement(AddTimelineRecord).Click();
            //Click add status update
            wait.Until(ExpectedConditions.ElementExists((By)AddStatusUpdate));
            driver.FindElement(AddStatusUpdate).Click();
            //Enter bespoke pausing
            wait.Until(ExpectedConditions.ElementExists((By)AddBespokePausing));
            driver.FindElement(AddBespokePausing).Click();
            driver.FindElement(AddBespokePausing).SendKeys("Bespoke Pausing");
            Thread.Sleep(2000);
            //Click bespoke pausing from dropdown
            wait.Until(ExpectedConditions.ElementExists((By)AddBespokePausingOnDropdown));
            driver.FindElement(AddBespokePausingOnDropdown).Click();
            //Add free text to message box
            wait.Until(ExpectedConditions.ElementExists((By)BespokePausingMsgBox));
            driver.FindElement(BespokePausingMsgBox).Click();
            driver.FindElement(BespokePausingMsgBox).SendKeys("Bespoke Pausing");
            Thread.Sleep(2000);
            //Click save and close
            wait.Until(ExpectedConditions.ElementExists((By)BespokePausingSave));
            driver.FindElement(BespokePausingSave).Click();
            Thread.Sleep(2000);
            //Verify latest customer update field is blank
            driver.FindElement(RefreshButtonOnCaseDetails).Click();
            Thread.Sleep(3000);
            wait.Until(ExpectedConditions.ElementExists((By)SLATimer));
            var Pause = 0;
            IWebElement element = driver.FindElement(SLATimer);
            string time = element.Text;

            try
            {
                if (time.Contains("7d"))
                {
                    Console.WriteLine("SLA timer not paused");
                    throw new Exception();
                }
                else
                {
                    if (driver.FindElement(ResolvedInPause).Displayed == true)
                    {
                        Console.WriteLine("SLA timer has been paused");

                    }
                }
            }
            catch (Exception)
            {
                do
                {
                    wait.Until(ExpectedConditions.ElementExists((By)RefreshButtonOnCaseDetails));
                    driver.FindElement(RefreshButtonOnCaseDetails).Click();
                    Thread.Sleep(5000);
                    Pause++;
                    if (driver.FindElement(LatestCustomerUpdate).Text.ToString().Contains("---"))
                    {
                        break;
                    }
                    else if (Pause == 10)
                    {
                        Console.WriteLine("SLA timer not paused");
                        Assert.Fail();
                    }
                } while (time.Contains("7d"));
            }
            wait.Until(ExpectedConditions.ElementExists((By)LatestCustomerUpdate));
            Thread.Sleep(2000);
            Assert.IsTrue(driver.FindElement(LatestCustomerUpdate).Text.ToString().Contains("---"));
            //Click customer updates/history tab
            wait.Until(ExpectedConditions.ElementExists((By)CaseDetailsCustomerUpdate));
            driver.FindElement(CaseDetailsCustomerUpdate).Click();
            Thread.Sleep(2000);
            //Verify status message is shown
            wait.Until(ExpectedConditions.ElementExists((By)CaseDetailsBespokePausing));
            Assert.IsTrue(driver.FindElement(CaseDetailsBespokePausing).Displayed);
            //Click summary tab
            driver.FindElement(CaseDetailsSummaryTab).Click();
            Thread.Sleep(2000);
            //Verify default customer update is displayed
            wait.Until(ExpectedConditions.ElementExists((By)BespokePausingCustomerUpdate));
            Assert.IsTrue(driver.FindElement(BespokePausingCustomerUpdate).Displayed);
            /*    //click email message on timeline
                var Email = 0;
                try
                {
                    if (driver.FindElements(EmailMessageOnTimeline).Count() != 0)
                    {
                        Console.WriteLine("Email message displayed on timeline");
                    }
                    else
                    {
                        throw new Exception();
                    }
                }
                catch (Exception)
                {
                    do
                    {
                        driver.FindElement(RefreshButtonOnCaseDetails).Click();
                        Thread.Sleep(5000);
                        Email++;
                        if (driver.FindElements(EmailMessageOnTimeline).Count() != 0)
                        {
                            break;
                        }
                        else if (Email == 10)
                        {
                            Console.WriteLine("Email message not displayed on timeline");
                            Assert.Fail();
                        }
                    } while (driver.FindElements(EmailMessageOnTimeline).Count() == 0);
                }
                wait.Until(ExpectedConditions.ElementExists((By)EmailMessageOnTimeline));
                Thread.Sleep(2000);
                driver.FindElement(EmailMessageOnTimeline).Click();
                Thread.Sleep(3000);
                //Verify message is correct
                wait.Until(ExpectedConditions.ElementExists((By)EmailMessageContentOnTimeline));
                Thread.Sleep(2000);
                Assert.IsTrue(driver.FindElement(EmailMessageContentOnTimeline).Displayed);
                Thread.Sleep(2000);*/
            //click dashboards in LHN
            driver.FindElement(DashboardsLHN).Click();
            Thread.Sleep(2000);
            //Search for customer//
            //Switch to searchbox iframe
            driver.SwitchTo().Frame(driver.FindElement(By.Id("9532b1de-41a1-456c-b21c-805faca15573_WebResource_customeradvisorstart")));
            wait.Until(ExpectedConditions.ElementExists((By)Searchbox));
            Assert.IsTrue(driver.FindElement(Searchbox).Displayed);
            //Enter fullname in search
            driver.FindElement(Searchbox).Click();
            driver.FindElement(Searchbox).SendKeys("Gary Moore");
            driver.FindElement(Searchbox).SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            //Select customer on dropdown 
            wait.Until(ExpectedConditions.ElementExists((By)ExistingCustomerSearchDropdown));
            Assert.IsTrue(driver.FindElement(ExistingCustomerSearchDropdown).Displayed);
            driver.FindElement(ExistingCustomerSearchDropdown).Click();
            Thread.Sleep(2000);
            //Check result is shown under access channel after selecting from dropdown
            wait.Until(ExpectedConditions.ElementExists((By)ExistingCustomerSearchResult));
            Assert.IsTrue(driver.FindElement(ExistingCustomerSearchResult).Displayed);
            //Verify case status shows as active
            wait.Until(ExpectedConditions.ElementExists((By)CaseHistoryUnderAcessChannel));
            Assert.IsTrue(driver.FindElement(CaseHistoryUnderAcessChannel).Displayed);
            wait.Until(ExpectedConditions.ElementExists((By)CaseHistoryStatus));
            Assert.IsTrue(driver.FindElement(CaseHistoryStatus).Displayed);
            driver.SwitchTo().DefaultContent();
            //Click cases on LHN
            driver.FindElement(CasesOnLHN).Click();
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)ActiveCasesTitle));
            Assert.IsTrue(driver.FindElement(ActiveCasesTitle).Displayed);
            Thread.Sleep(2000);
            //click customer name
            driver.FindElement(CustomerNameOnCasesList).Click();
            Thread.Sleep(2000);
            //Click history tab
            wait.Until(ExpectedConditions.ElementExists((By)HistoryTabOnCustomer));
            driver.FindElement(HistoryTabOnCustomer).Click();
            Thread.Sleep(2000);
            try
            {
                do
                {
                    //Click select all cases
                    wait.Until(ExpectedConditions.ElementExists((By)SelectAllCasesBtn));
                    Thread.Sleep(3000);
                    driver.FindElement(SelectAllCasesBtn).Click();
                    Thread.Sleep(2000);
                    //Click more options dots
                    wait.Until(ExpectedConditions.ElementExists((By)MoreOptionsDotsOnCustomerCases));
                    Thread.Sleep(2000);
                    driver.FindElement(MoreOptionsDotsOnCustomerCases).Click();
                    Thread.Sleep(2000);
                    //Click delete cases
                    wait.Until(ExpectedConditions.ElementExists((By)DeleteCasesFromMoreOptions));
                    Thread.Sleep(2000);
                    driver.FindElement(DeleteCasesFromMoreOptions).Click();
                    Thread.Sleep(2000);
                    //Click delete on the overlay
                    wait.Until(ExpectedConditions.ElementExists((By)DeleteCasesOverlayBtn));
                    Thread.Sleep(2000);
                    driver.FindElement(DeleteCasesOverlayBtn).Click();
                    Thread.Sleep(10000);
                    wait.Until(ExpectedConditions.ElementExists((By)CustomerCasesTitle));
                }
                while (driver.FindElement(CustomerNameOnCustomerHistory).Displayed);
            }
            catch (Exception)
            {
                Console.WriteLine("All cases removed from history screen");
            }
            //Verify cases deleted
            var Cases = 0;
            try
            {
                WebElement cases = (WebElement)driver.FindElement(CustomerNameOnCustomerHistory);
                if (cases.Displayed)
                {
                    Cases = 1;
                    Assert.Fail();
                }
            }
            catch (Exception)
            {
                if (Cases > 0)
                {
                    Console.WriteLine("Cases not removed");
                }
                else
                {
                    Console.WriteLine("Cases removed");
                }
            }
        }

        public void UnpauseCaseStatus()
        {
            //Verify Home dashboard is displayed
            Thread.Sleep(4000);
            wait.Until(ExpectedConditions.ElementExists((By)DashboardsLHN));
            driver.FindElement(DashboardsLHN).Click();
            Thread.Sleep(2000);
            driver.FindElement(DashboardsLHN).Click();
            wait.Until(ExpectedConditions.ElementExists((By)DashboardTitle));
            Assert.IsTrue(driver.FindElement(DashboardTitle).Displayed);
            Thread.Sleep(3000);
            //Switch to searchbox iframe
            driver.SwitchTo().Frame(driver.FindElement(By.Id("9532b1de-41a1-456c-b21c-805faca15573_WebResource_customeradvisorstart")));
            wait.Until(ExpectedConditions.ElementExists((By)Searchbox));
            Assert.IsTrue(driver.FindElement(Searchbox).Displayed);
            //Enter fullname in search
            driver.FindElement(Searchbox).Click();
            driver.FindElement(Searchbox).SendKeys("Case Status");
            driver.FindElement(Searchbox).SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            //Check result shows on the dropdown
            wait.Until(ExpectedConditions.ElementExists((By)CaseStatusOnDropdown));
            Assert.IsTrue(driver.FindElement(CaseStatusOnDropdown).Displayed);
            driver.FindElement(CaseStatusOnDropdown).Click();
            Thread.Sleep(2000);
            //Click result under access channel after selecting from dropdown
            wait.Until(ExpectedConditions.ElementExists((By)CaseStatusSearchResult));
            Assert.IsTrue(driver.FindElement(CaseStatusSearchResult).Displayed);
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
            wait.Until(ExpectedConditions.ElementExists((By)FAQSearchServiceResult));
            Assert.IsTrue(driver.FindElement(FAQSearchServiceResult).Displayed);
            driver.FindElement(FAQSearchServiceResult).Click();
            driver.SwitchTo().DefaultContent();
            Thread.Sleep(2000);
            //Click yes on overlay
            wait.Until(ExpectedConditions.ElementExists((By)YesBtnOnNewCaseOverlay));
            driver.FindElement(YesBtnOnNewCaseOverlay).Click();
            Thread.Sleep(3000);
            //Verify dog fouling form loads
            wait.Until(ExpectedConditions.ElementExists((By)DogFoulingFormTitle));
            Assert.IsTrue(driver.FindElement(DogFoulingFormTitle).Displayed);
            //Enter address for location
            Thread.Sleep(2000);
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
            //Select wakefield case on dropdown
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)AllocatedCaseForm));
            driver.FindElement(AllocatedCaseForm).Click();
            wait.Until(ExpectedConditions.ElementExists((By)AllocatedCaseDropdownWakefield));
            driver.FindElement(AllocatedCaseDropdownWakefield).Click();
            Thread.Sleep(10000);
            //Verify case details page is displayed
            wait.Until(ExpectedConditions.ElementExists((By)CaseDetailsForm));
            Assert.IsTrue(driver.FindElement(CaseDetailsForm).Displayed);
            //Click plus button on timeline
            wait.Until(ExpectedConditions.ElementExists((By)AddTimelineRecord));
            driver.FindElement(AddTimelineRecord).Click();
            //Click add status update
            wait.Until(ExpectedConditions.ElementExists((By)AddStatusUpdate));
            driver.FindElement(AddStatusUpdate).Click();
            //Enter bespoke pausing
            wait.Until(ExpectedConditions.ElementExists((By)AddBespokePausing));
            driver.FindElement(AddBespokePausing).Click();
            driver.FindElement(AddBespokePausing).SendKeys("Bespoke Pausing");
            Thread.Sleep(2000);
            //Click bespoke pausing from dropdown
            wait.Until(ExpectedConditions.ElementExists((By)AddBespokePausingOnDropdown));
            driver.FindElement(AddBespokePausingOnDropdown).Click();
            //Add free text to message box
            wait.Until(ExpectedConditions.ElementExists((By)BespokePausingMsgBox));
            driver.FindElement(BespokePausingMsgBox).Click();
            driver.FindElement(BespokePausingMsgBox).SendKeys("Bespoke Pausing");
            Thread.Sleep(2000);
            //Click save and close
            wait.Until(ExpectedConditions.ElementExists((By)BespokePausingSave));
            driver.FindElement(BespokePausingSave).Click();
            Thread.Sleep(2000);
            //Click plus button on timeline
            wait.Until(ExpectedConditions.ElementExists((By)AddTimelineRecord));
            driver.FindElement(AddTimelineRecord).Click();
            Thread.Sleep(2000);
            //Click add status update
            wait.Until(ExpectedConditions.ElementExists((By)AddStatusUpdate));
            driver.FindElement(AddStatusUpdate).Click();
            //Enter restarting
            wait.Until(ExpectedConditions.ElementExists((By)AddBespokePausing));
            driver.FindElement(AddBespokePausing).Click();
            driver.FindElement(AddBespokePausing).SendKeys("Restarting");
            Thread.Sleep(2000);
            //Click restarting from dropdown
            wait.Until(ExpectedConditions.ElementExists((By)AddRestartingOnDropdown));
            driver.FindElement(AddRestartingOnDropdown).Click();
            //Click save and close
            wait.Until(ExpectedConditions.ElementExists((By)BespokePausingSave));
            driver.FindElement(BespokePausingSave).Click();
            Thread.Sleep(3000);
            //Verify latest customer update field is blank
            wait.Until(ExpectedConditions.ElementExists((By)RefreshButtonOnCaseDetails));
            driver.FindElement(RefreshButtonOnCaseDetails).Click();
            Thread.Sleep(5000);
            var Pause = 0;
            try
            {
                if (driver.FindElement(LatestCustomerUpdate).Text.ToString().Contains("---"))
                {
                    Console.WriteLine("SLA timer is paused");
                    throw new Exception();
                }
                else
                {
                    if (driver.FindElement(LatestCustomerUpdate).Text.ToString().Contains("This case SLA has now been restarted"))
                    {
                        Console.WriteLine("SLA timer is not paused");
                    }
                }
            }
            catch (Exception)
            {
                do
                {
                    wait.Until(ExpectedConditions.ElementExists((By)RefreshButtonOnCaseDetails));
                    driver.FindElement(RefreshButtonOnCaseDetails).Click();
                    Thread.Sleep(5000);
                    Pause++;
                    if (driver.FindElement(LatestCustomerUpdate).Text.ToString().Contains("This case SLA has now been restarted"))
                    {
                        break;
                    }
                    else if (Pause == 10)
                    {
                        Console.WriteLine("SLA timer is paused");
                        Assert.Fail();
                    }
                } while (driver.FindElement(LatestCustomerUpdate).Text.ToString().Contains("---"));
            }

            wait.Until(ExpectedConditions.ElementExists((By)LatestCustomerUpdate));
            Thread.Sleep(2000);
            Assert.IsTrue(driver.FindElement(LatestCustomerUpdate).Text.ToString().Contains("This case SLA has now been restarted"));
            //Click customer updates/history tab
            wait.Until(ExpectedConditions.ElementExists((By)CaseDetailsCustomerUpdate));
            driver.FindElement(CaseDetailsCustomerUpdate).Click();
            Thread.Sleep(2000);
            //Verify status message is shown
            wait.Until(ExpectedConditions.ElementExists((By)CaseDetailsRestarting));
            Assert.IsTrue(driver.FindElement(CaseDetailsRestarting).Displayed);
            //Click summary tab
            driver.FindElement(CaseDetailsSummaryTab).Click();
            Thread.Sleep(2000);
            //Verify default customer update is displayed
            wait.Until(ExpectedConditions.ElementExists((By)BespokePausingCustomerUpdate));
            Assert.IsTrue(driver.FindElement(BespokePausingCustomerUpdate).Displayed);
            /*    //click email message on timeline
                var Email = 0;
                try
                {
                    if (driver.FindElements(EmailMessageOnTimeline).Count() != 0)
                    {
                        Console.WriteLine("Email message displayed on timeline");
                    }
                    else
                    {
                        throw new Exception();
                    }
                }
                catch (Exception)
                {
                    do
                    {
                        driver.FindElement(RefreshButtonOnCaseDetails).Click();
                        Thread.Sleep(5000);
                        Email++;
                        if (driver.FindElements(EmailMessageOnTimeline).Count() != 0)
                        {
                            break;
                        }
                        else if (Email == 10)
                        {
                            Console.WriteLine("Email message not displayed on timeline");
                            Assert.Fail();
                        }
                    } while (driver.FindElements(EmailMessageOnTimeline).Count() == 0);
                }
                wait.Until(ExpectedConditions.ElementExists((By)EmailMessageOnTimeline));
                Thread.Sleep(2000);
                driver.FindElement(EmailMessageOnTimeline).Click();
                Thread.Sleep(3000);
                //Verify message is correct
                wait.Until(ExpectedConditions.ElementExists((By)EmailMessageContentOnTimeline));
                Thread.Sleep(2000);
                Assert.IsTrue(driver.FindElement(EmailMessageContentOnTimeline).Displayed);
                Thread.Sleep(2000);*/
            //Click customer updates/history tab
            wait.Until(ExpectedConditions.ElementExists((By)CaseDetailsCustomerUpdate));
            driver.FindElement(CaseDetailsCustomerUpdate).Click();
            Thread.Sleep(2000);
            //Remove cases
            Thread.Sleep(2000);
            Actions action1 = new Actions(driver);
            action1.SendKeys(Keys.ArrowDown).Build().Perform();
            var Cases = 0;
            try
            {
                if (driver.FindElements(CaseStatusOnCustomerHistory).Count() != 0)
                    Console.WriteLine("Cases present on customer history");
                {
                    do
                    {
                        //Click select all cases
                        wait.Until(ExpectedConditions.ElementExists((By)SelectAllCasesBtn));
                        Thread.Sleep(3000);
                        driver.FindElement(SelectAllCasesBtn).Click();
                        Thread.Sleep(2000);
                        //Click more options dots
                        wait.Until(ExpectedConditions.ElementExists((By)MoreOptionsDotsOnCustomerCases));
                        Thread.Sleep(2000);
                        driver.FindElement(MoreOptionsDotsOnCustomerCases).Click();
                        Thread.Sleep(2000);
                        //Click delete cases
                        wait.Until(ExpectedConditions.ElementExists((By)DeleteCasesFromMoreOptions));
                        Thread.Sleep(2000);
                        driver.FindElement(DeleteCasesFromMoreOptions).Click();
                        Thread.Sleep(2000);
                        //Click delete on the overlay
                        wait.Until(ExpectedConditions.ElementExists((By)DeleteCasesOverlayBtn));
                        Thread.Sleep(2000);
                        driver.FindElement(DeleteCasesOverlayBtn).Click();
                        Thread.Sleep(10000);
                        wait.Until(ExpectedConditions.ElementExists((By)CustomerCasesTitle));
                        Cases++;
                        if (driver.FindElements(CaseStatusOnCustomerHistory).Count() == 0)
                        {
                            Console.WriteLine("All cases removed");
                            break;
                        }
                    }
                    while (driver.FindElements(CaseStatusOnCustomerHistory).Count() != 0);
                }
            }
            catch (Exception)
            {
                if (Cases == 0)
                {
                    Console.WriteLine("No cases were added to customer history");
                    Assert.Fail();
                }
            }

        } 

        public void ClosingCaseStatus()
        {
            //Verify Home dashboard is displayed
            Thread.Sleep(4000);
            wait.Until(ExpectedConditions.ElementExists((By)DashboardsLHN));
            driver.FindElement(DashboardsLHN).Click();
            Thread.Sleep(2000);
            driver.FindElement(DashboardsLHN).Click();
            wait.Until(ExpectedConditions.ElementExists((By)DashboardTitle));
            Assert.IsTrue(driver.FindElement(DashboardTitle).Displayed);
            Thread.Sleep(3000);
            //Switch to searchbox iframe
            driver.SwitchTo().Frame(driver.FindElement(By.Id("9532b1de-41a1-456c-b21c-805faca15573_WebResource_customeradvisorstart")));
            wait.Until(ExpectedConditions.ElementExists((By)Searchbox));
            Assert.IsTrue(driver.FindElement(Searchbox).Displayed);
            //Enter fullname in search
            driver.FindElement(Searchbox).Click();
            driver.FindElement(Searchbox).SendKeys("Case Status");
            driver.FindElement(Searchbox).SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            //Check result shows on the dropdown
            wait.Until(ExpectedConditions.ElementExists((By)CaseStatusOnDropdown));
            Assert.IsTrue(driver.FindElement(CaseStatusOnDropdown).Displayed);
            driver.FindElement(CaseStatusOnDropdown).Click();
            Thread.Sleep(2000);
            //Click result under access channel after selecting from dropdown
            wait.Until(ExpectedConditions.ElementExists((By)CaseStatusSearchResult));
            Assert.IsTrue(driver.FindElement(CaseStatusSearchResult).Displayed);
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
            wait.Until(ExpectedConditions.ElementExists((By)FAQSearchServiceResult));
            Assert.IsTrue(driver.FindElement(FAQSearchServiceResult).Displayed);
            driver.FindElement(FAQSearchServiceResult).Click();
            driver.SwitchTo().DefaultContent();
            Thread.Sleep(2000);
            //Click yes on overlay
            wait.Until(ExpectedConditions.ElementExists((By)YesBtnOnNewCaseOverlay));
            driver.FindElement(YesBtnOnNewCaseOverlay).Click();
            Thread.Sleep(3000);
            //Verify dog fouling form loads
            wait.Until(ExpectedConditions.ElementExists((By)DogFoulingFormTitle));
            Assert.IsTrue(driver.FindElement(DogFoulingFormTitle).Displayed);
            //Enter address for location
            Thread.Sleep(2000);
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
            //Select wakefield case on dropdown
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)AllocatedCaseForm));
            driver.FindElement(AllocatedCaseForm).Click();
            wait.Until(ExpectedConditions.ElementExists((By)AllocatedCaseDropdownWakefield));
            driver.FindElement(AllocatedCaseDropdownWakefield).Click();
            Thread.Sleep(10000);
            //Verify case details page is displayed
            wait.Until(ExpectedConditions.ElementExists((By)CaseDetailsForm));
            Assert.IsTrue(driver.FindElement(CaseDetailsForm).Displayed);
            //Click plus button on timeline
            wait.Until(ExpectedConditions.ElementExists((By)AddTimelineRecord));
            driver.FindElement(AddTimelineRecord).Click();
            //Click add status update
            wait.Until(ExpectedConditions.ElementExists((By)AddStatusUpdate));
            driver.FindElement(AddStatusUpdate).Click();
            //Enter bespoke pausing
            wait.Until(ExpectedConditions.ElementExists((By)AddBespokePausing));
            driver.FindElement(AddBespokePausing).Click();
            driver.FindElement(AddBespokePausing).SendKeys("Bespoke Pausing");
            Thread.Sleep(2000);
            //Click bespoke pausing from dropdown
            wait.Until(ExpectedConditions.ElementExists((By)AddBespokePausingOnDropdown));
            driver.FindElement(AddBespokePausingOnDropdown).Click();
            //Add free text to message box
            wait.Until(ExpectedConditions.ElementExists((By)BespokePausingMsgBox));
            driver.FindElement(BespokePausingMsgBox).Click();
            driver.FindElement(BespokePausingMsgBox).SendKeys("Bespoke Pausing");
            Thread.Sleep(2000);
            //Click save and close
            wait.Until(ExpectedConditions.ElementExists((By)BespokePausingSave));
            driver.FindElement(BespokePausingSave).Click();
            Thread.Sleep(2000);
            //Verify latest customer update field is blank
            driver.FindElement(RefreshButtonOnCaseDetails).Click();
            Thread.Sleep(3000);
            wait.Until(ExpectedConditions.ElementExists((By)SLATimer));
            var Pause = 0;
            IWebElement element = driver.FindElement(SLATimer);
            string time = element.Text;

            try
            {
                if (time.Contains("6d"))
                {
                    Console.WriteLine("SLA timer not paused");
                    throw new Exception();
                }
                else
                {
                    if (driver.FindElement(ResolvedInPause).Displayed == true)
                    {
                        Console.WriteLine("SLA timer has been paused");

                    }
                }
            }
            catch (Exception)
            {
                do
                {
                    wait.Until(ExpectedConditions.ElementExists((By)RefreshButtonOnCaseDetails));
                    driver.FindElement(RefreshButtonOnCaseDetails).Click();
                    Thread.Sleep(5000);
                    Pause++;
                    if (driver.FindElement(LatestCustomerUpdate).Text.ToString().Contains("---"))
                    {
                        break;
                    }
                    else if (Pause == 10)
                    {
                        Console.WriteLine("SLA timer not paused");
                        Assert.Fail();
                    }
                } while (time.Contains("6d"));
            }
            wait.Until(ExpectedConditions.ElementExists((By)LatestCustomerUpdate));
            Thread.Sleep(2000);
            Assert.IsTrue(driver.FindElement(LatestCustomerUpdate).Text.ToString().Contains("---"));
            Thread.Sleep(2000);
            //Click plus button on timeline
            wait.Until(ExpectedConditions.ElementExists((By)AddTimelineRecord));
            driver.FindElement(AddTimelineRecord).Click();
            //Click add status update
            wait.Until(ExpectedConditions.ElementExists((By)AddStatusUpdate));
            driver.FindElement(AddStatusUpdate).Click();
            //Enter closing
            wait.Until(ExpectedConditions.ElementExists((By)AddBespokePausing));
            driver.FindElement(AddBespokePausing).Click();
            driver.FindElement(AddBespokePausing).SendKeys("Closing");
            Thread.Sleep(2000);
            //Click closing - fouling cleared from dropdown
            wait.Until(ExpectedConditions.ElementExists((By)AddClosingOnDropdown));
            driver.FindElement(AddClosingOnDropdown).Click();
            //Click save and close
            wait.Until(ExpectedConditions.ElementExists((By)BespokePausingSave));
            driver.FindElement(BespokePausingSave).Click();
            Thread.Sleep(2000);
            //Verify latest customer update field is updated
            driver.FindElement(RefreshButtonOnCaseDetails).Click();
            Thread.Sleep(3000);
            Pause = 0;
            IWebElement elementP = driver.FindElement(SLATimerPaused);

            try
            {
                if (elementP.Displayed)
                {
                    Console.WriteLine("SLA timer paused");
                    throw new Exception();
                }
                else
                {
                    if (driver.FindElement(LatestCustomerUpdateClosed).Displayed)
                    {
                        Console.WriteLine("SLA timer has been succeeded");

                    }
                }
            }
            catch (Exception)
            {
                do
                {
                    wait.Until(ExpectedConditions.ElementExists((By)RefreshButtonOnCaseDetails));
                    driver.FindElement(RefreshButtonOnCaseDetails).Click();
                    Thread.Sleep(6000);
                    Pause++;
                    if (driver.FindElement(LatestCustomerUpdateClosed).Text.ToString().Contains("Further to your enquiry"))
                    {
                        break;
                    }
                    else if (Pause == 10)
                    {
                        Console.WriteLine("SLA timer still paused");
                        Assert.Fail();
                    }
                } while (element.Displayed);
            }
            Thread.Sleep(2000);
            //Click customer updates/history tab
            wait.Until(ExpectedConditions.ElementExists((By)CaseDetailsCustomerUpdate));
            driver.FindElement(CaseDetailsCustomerUpdate).Click();
            Thread.Sleep(2000);
            //Verify status message is shown
            wait.Until(ExpectedConditions.ElementExists((By)CaseDetailsClosed));
            Assert.IsTrue(driver.FindElement(CaseDetailsClosed).Displayed);
            //Click summary tab
            driver.FindElement(CaseDetailsSummaryTab).Click();
            Thread.Sleep(2000);
            //Verify default customer update is displayed
            wait.Until(ExpectedConditions.ElementExists((By)BespokePausingCustomerUpdate));
            Assert.IsTrue(driver.FindElement(BespokePausingCustomerUpdate).Displayed);
            /*    //click email message on timeline
                var Email = 0;
                try
                {
                    if (driver.FindElements(EmailMessageOnTimeline).Count() != 0)
                    {
                        Console.WriteLine("Email message displayed on timeline");
                    }
                    else
                    {
                        throw new Exception();
                    }
                }
                catch (Exception)
                {
                    do
                    {
                        driver.FindElement(RefreshButtonOnCaseDetails).Click();
                        Thread.Sleep(5000);
                        Email++;
                        if (driver.FindElements(EmailMessageOnTimeline).Count() != 0)
                        {
                            break;
                        }
                        else if (Email == 10)
                        {
                            Console.WriteLine("Email message not displayed on timeline");
                            Assert.Fail();
                        }
                    } while (driver.FindElements(EmailMessageOnTimeline).Count() == 0);
                }
                wait.Until(ExpectedConditions.ElementExists((By)EmailMessageOnTimeline));
                Thread.Sleep(2000);
                driver.FindElement(EmailMessageOnTimeline).Click();
                Thread.Sleep(3000);
                //Verify message is correct
                wait.Until(ExpectedConditions.ElementExists((By)EmailMessageContentOnTimeline));
                Thread.Sleep(2000);
                Assert.IsTrue(driver.FindElement(EmailMessageContentOnTimeline).Displayed);
                Thread.Sleep(2000);*/
            //Verify ribbon shows case as resolved
            wait.Until(ExpectedConditions.ElementExists((By)ClosedCaseRibbonMsg));
            Assert.IsTrue(driver.FindElement(ClosedCaseRibbonMsg).Displayed);
            //Click customer updates/history tab
            wait.Until(ExpectedConditions.ElementExists((By)CaseDetailsCustomerUpdate));
            driver.FindElement(CaseDetailsCustomerUpdate).Click();
            Thread.Sleep(2000);
            //Remove cases
            Thread.Sleep(2000);
            Actions actionPD = new Actions(driver);
            actionPD.SendKeys(Keys.PageDown).Build().Perform();
            var Cases = 0;
            try
            {
                if (driver.FindElements(CaseStatusOnCustomerHistory).Count() != 0)
                    Console.WriteLine("Cases present on customer history");
                {
                    do
                    {
                        //Click select all cases
                        wait.Until(ExpectedConditions.ElementExists((By)SelectAllCasesBtn));
                        Thread.Sleep(3000);
                        driver.FindElement(SelectAllCasesBtn).Click();
                        Thread.Sleep(2000);
                        //Click more options dots
                        wait.Until(ExpectedConditions.ElementExists((By)MoreOptionsDotsOnCustomerCases));
                        Thread.Sleep(2000);
                        driver.FindElement(MoreOptionsDotsOnCustomerCases).Click();
                        Thread.Sleep(2000);
                        //Click delete cases
                        wait.Until(ExpectedConditions.ElementExists((By)DeleteCasesFromMoreOptions));
                        Thread.Sleep(2000);
                        driver.FindElement(DeleteCasesFromMoreOptions).Click();
                        Thread.Sleep(2000);
                        //Click delete on the overlay
                        wait.Until(ExpectedConditions.ElementExists((By)DeleteCasesOverlayBtn));
                        Thread.Sleep(2000);
                        driver.FindElement(DeleteCasesOverlayBtn).Click();
                        Thread.Sleep(10000);
                        wait.Until(ExpectedConditions.ElementExists((By)CustomerCasesTitle));
                        Cases++;
                        if (driver.FindElements(CaseStatusOnCustomerHistory).Count() == 0)
                        {
                            Console.WriteLine("All cases removed");
                            break;
                        }
                    }
                    while (driver.FindElements(CaseStatusOnCustomerHistory).Count() != 0);
                }
            }
            catch (Exception)
            {
                if (Cases == 0)
                {
                    Console.WriteLine("No cases were added to customer history");
                    Assert.Fail();
                }
            }

            }

        public void CaseHistoryAtAddress()
        {
            //Verify Home dashboard is displayed
            Thread.Sleep(4000);
            wait.Until(ExpectedConditions.ElementExists((By)DashboardsLHN));
            driver.FindElement(DashboardsLHN).Click();
            Thread.Sleep(2000);
            driver.FindElement(DashboardsLHN).Click();
            wait.Until(ExpectedConditions.ElementExists((By)DashboardTitle));
            Assert.IsTrue(driver.FindElement(DashboardTitle).Displayed);
            Thread.Sleep(3000);
            //Switch to searchbox iframe
            driver.SwitchTo().Frame(driver.FindElement(By.Id("9532b1de-41a1-456c-b21c-805faca15573_WebResource_customeradvisorstart")));
            wait.Until(ExpectedConditions.ElementExists((By)Searchbox));
            Assert.IsTrue(driver.FindElement(Searchbox).Displayed);
            //Enter fullname in search
            driver.FindElement(Searchbox).Click();
            driver.FindElement(Searchbox).SendKeys("Case Status");
            driver.FindElement(Searchbox).SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            //Check result shows on the dropdown
            wait.Until(ExpectedConditions.ElementExists((By)CaseStatusOnDropdown));
            Assert.IsTrue(driver.FindElement(CaseStatusOnDropdown).Displayed);
            driver.FindElement(CaseStatusOnDropdown).Click();
            Thread.Sleep(2000);
            //Click result under access channel after selecting from dropdown
            wait.Until(ExpectedConditions.ElementExists((By)CaseStatusSearchResult));
            Assert.IsTrue(driver.FindElement(CaseStatusSearchResult).Displayed);
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
            wait.Until(ExpectedConditions.ElementExists((By)FAQSearchServiceResult));
            Assert.IsTrue(driver.FindElement(FAQSearchServiceResult).Displayed);
            driver.FindElement(FAQSearchServiceResult).Click();
            driver.SwitchTo().DefaultContent();
            Thread.Sleep(2000);
            //Click yes on overlay
            wait.Until(ExpectedConditions.ElementExists((By)YesBtnOnNewCaseOverlay));
            driver.FindElement(YesBtnOnNewCaseOverlay).Click();
            Thread.Sleep(3000);
            //Verify dog fouling form loads
            wait.Until(ExpectedConditions.ElementExists((By)DogFoulingFormTitle));
            Assert.IsTrue(driver.FindElement(DogFoulingFormTitle).Displayed);
            //Enter address for location
            Thread.Sleep(2000);
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
            //Select wakefield case on dropdown
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)AllocatedCaseForm));
            driver.FindElement(AllocatedCaseForm).Click();
            wait.Until(ExpectedConditions.ElementExists((By)AllocatedCaseDropdownWakefield));
            driver.FindElement(AllocatedCaseDropdownWakefield).Click();
            Thread.Sleep(10000);
            //Verify case details page is displayed
            wait.Until(ExpectedConditions.ElementExists((By)CaseDetailsForm));
            Assert.IsTrue(driver.FindElement(CaseDetailsForm).Displayed);
            //Click Location Tab
            wait.Until(ExpectedConditions.ElementExists((By)LocationTab));
            driver.FindElement(LocationTab).Click();
            //Click reported location
            wait.Until(ExpectedConditions.ElementExists((By)ReportedLocation));
            driver.FindElement(ReportedLocation).Click();
            //Click linked records tab
            wait.Until(ExpectedConditions.ElementExists((By)LinkedRecordsTab));
            driver.FindElement(LinkedRecordsTab).Click();
            //Click linked case from the table
            wait.Until(ExpectedConditions.ElementExists((By)LinkedCaseOnTable));
            driver.FindElement(LinkedCaseOnTable).Click();
            //Verify case form loads
            wait.Until(ExpectedConditions.ElementExists((By)CaseDetailsForm));
            Assert.IsTrue(driver.FindElement(CaseDetailsForm).Displayed);
        }

        public void CaseEscalation()
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
            wait.Until(ExpectedConditions.ElementExists((By)Searchbox));
            Assert.IsTrue(driver.FindElement(Searchbox).Displayed);
            //Enter fullname in search
            driver.FindElement(Searchbox).Click();
            driver.FindElement(Searchbox).SendKeys("Gary Moore");
            driver.FindElement(Searchbox).SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            //Check result shows on the dropdown
            wait.Until(ExpectedConditions.ElementExists((By)ExistingCustomerSearchDropdown));
            Assert.IsTrue(driver.FindElement(ExistingCustomerSearchDropdown).Displayed);
            driver.FindElement(ExistingCustomerSearchDropdown).Click();
            Thread.Sleep(2000);
            //Check result is shown under access channel after selecting from dropdown
            wait.Until(ExpectedConditions.ElementExists((By)ExistingCustomerSearchResult));
            Assert.IsTrue(driver.FindElement(ExistingCustomerSearchResult).Displayed);
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
            wait.Until(ExpectedConditions.ElementExists((By)FAQSearchServiceResult));
            Assert.IsTrue(driver.FindElement(FAQSearchServiceResult).Displayed);
            driver.FindElement(FAQSearchServiceResult).Click();
            Thread.Sleep(2000);
            //Verify customer name and service shown on the create new case overlay
            driver.SwitchTo().DefaultContent();
            wait.Until(ExpectedConditions.ElementExists((By)CustomerNameOnNewCaseOverlay));
            Assert.IsTrue(driver.FindElement(CustomerNameOnNewCaseOverlay).Displayed);
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
            Thread.Sleep(2000);
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
            //Select wakefield case on dropdown
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)AllocatedCaseForm));
            driver.FindElement(AllocatedCaseForm).Click();
            wait.Until(ExpectedConditions.ElementExists((By)AllocatedCaseDropdownWakefield));
            driver.FindElement(AllocatedCaseDropdownWakefield).Click();
            Thread.Sleep(10000);
            //Verify case details page is displayed
            wait.Until(ExpectedConditions.ElementExists((By)CaseDetailsForm));
            Assert.IsTrue(driver.FindElement(CaseDetailsForm).Displayed);
            //Click plus button on timeline
            wait.Until(ExpectedConditions.ElementExists((By)AddTimelineRecord));
            driver.FindElement(AddTimelineRecord).Click();
            //Click Escalate
            wait.Until(ExpectedConditions.ElementExists((By)AddEscalate));
            driver.FindElement(AddEscalate).Click();
            Thread.Sleep(2000);
            //Enter complaints type
            wait.Until(ExpectedConditions.ElementExists((By)AddComplaintsType));
            driver.FindElement(AddComplaintsType).Click();
            driver.FindElement(AddComplaintsType).SendKeys("Social Care Complaint");
            Thread.Sleep(2000);
            //Click social care complaint from dropdown
            wait.Until(ExpectedConditions.ElementExists((By)SocialCareComplaintOnDropdown));
            driver.FindElement(SocialCareComplaintOnDropdown).Click();
            //Click escalation stage
            wait.Until(ExpectedConditions.ElementExists((By)AddEscalationStage));
            driver.FindElement(AddEscalationStage).Click();
            driver.FindElement(AddEscalationStage).SendKeys("Adult Local Resolution");
            Thread.Sleep(2000);
            //Click adult local resolution from dropdown
            wait.Until(ExpectedConditions.ElementExists((By)AdultLocalResolutionOnDropdown));
            driver.FindElement(AdultLocalResolutionOnDropdown).Click();
            //Click access channel from dropdown
            wait.Until(ExpectedConditions.ElementExists((By)AccessChannelPhoneOnDropdown));
            driver.FindElement(AccessChannelPhoneOnDropdown).Click();
            //Click save and close
            wait.Until(ExpectedConditions.ElementExists((By)BespokePausingSave));
            driver.FindElement(BespokePausingSave).Click();
            Thread.Sleep(5000);
            //Verify linked case is shown
            wait.Until(ExpectedConditions.ElementExists((By)LinkedCaseOnComplaintsForm));
            Assert.IsTrue(driver.FindElement(LinkedCaseOnComplaintsForm).Displayed);
            //Click complaint overview
            wait.Until(ExpectedConditions.ElementExists((By)AddComplaintOverview));
            driver.FindElement(AddComplaintOverview).Click();
            driver.FindElement(AddComplaintOverview).SendKeys("Dissatisfied with previous complaint response");
            Thread.Sleep(2000);
            //Click Dissatisfied with previous complaint response from dropdown
            wait.Until(ExpectedConditions.ElementExists((By)ComplaintOverviewDropdown));
            driver.FindElement(ComplaintOverviewDropdown).Click();
            //Enter details of complaint
            wait.Until(ExpectedConditions.ElementExists((By)AddDetailsOfComplaint));
            driver.FindElement(AddDetailsOfComplaint).Click();
            driver.FindElement(AddDetailsOfComplaint).SendKeys("Dissatisfied with previous complaint response");
            Thread.Sleep(2000);
            //Enter desired outcome
            wait.Until(ExpectedConditions.ElementExists((By)AddDesiredOutcome));
            driver.FindElement(AddDesiredOutcome).Click();
            driver.FindElement(AddDesiredOutcome).SendKeys("Mass sackings");
            Thread.Sleep(2000);
            //Click source from dropdown
            driver.FindElement(SourceOnDropdown).Click();
            Thread.Sleep(2000);
            //Click complaint type
            driver.FindElement(ComplaintTypeOnDropdown).Click();
            Thread.Sleep(2000);
            //Click allocate box
            driver.SwitchTo().Frame("WebResource_allocatingpanel");
            wait.Until(ExpectedConditions.ElementExists((By)AllocateBtn));
            driver.FindElement(AllocateBtn).Click();
            Thread.Sleep(2000);
            driver.SwitchTo().DefaultContent();
            //Verify complaint title
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)ComplaintTitle));
            Assert.IsTrue(driver.FindElement(ComplaintTitle).Displayed);
            //Click customer name
            wait.Until(ExpectedConditions.ElementExists((By)CustomerNameOnComplaintForm));
            driver.FindElement(CustomerNameOnComplaintForm).Click();
            Thread.Sleep(4000);
            //Click history tab
            wait.Until(ExpectedConditions.ElementExists((By)HistoryTabOnCustomer));
            driver.FindElement(HistoryTabOnCustomer).Click();
            Thread.Sleep(2000);
            try
            {
                do
                {
                    //Click select all cases
                    wait.Until(ExpectedConditions.ElementExists((By)SelectAllCasesBtn));
                    Thread.Sleep(3000);
                    driver.FindElement(SelectAllCasesBtn).Click();
                    Thread.Sleep(2000);
                    //Click more options dots
                    wait.Until(ExpectedConditions.ElementExists((By)MoreOptionsDotsOnCustomerCases));
                    Thread.Sleep(2000);
                    driver.FindElement(MoreOptionsDotsOnCustomerCases).Click();
                    Thread.Sleep(2000);
                    //Click delete cases
                    wait.Until(ExpectedConditions.ElementExists((By)DeleteCasesFromMoreOptions));
                    Thread.Sleep(2000);
                    driver.FindElement(DeleteCasesFromMoreOptions).Click();
                    Thread.Sleep(2000);
                    //Click delete on the overlay
                    wait.Until(ExpectedConditions.ElementExists((By)DeleteCasesOverlayBtn));
                    Thread.Sleep(2000);
                    driver.FindElement(DeleteCasesOverlayBtn).Click();
                    Thread.Sleep(10000);
                    wait.Until(ExpectedConditions.ElementExists((By)CustomerCasesTitle));
                }
                while (driver.FindElement(CustomerNameOnCustomerHistory).Displayed);
            }
            catch (Exception)
            {
                Console.WriteLine("All cases removed from history screen");
            }
            //Verify cases deleted
            var Cases = 0;
            try
            {
                WebElement cases = (WebElement)driver.FindElement(CustomerNameOnCustomerHistory);
                if (cases.Displayed)
                {
                    Cases = 1;
                    Assert.Fail();
                }
            }
            catch (Exception)
            {
                if (Cases > 0)
                {
                    Console.WriteLine("Cases not removed");
                }
                else
                {
                    Console.WriteLine("Cases removed");
                }
            }
        }

        public void CaseEscalationStage1()
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
            wait.Until(ExpectedConditions.ElementExists((By)Searchbox));
            Assert.IsTrue(driver.FindElement(Searchbox).Displayed);
            //Enter fullname in search
            driver.FindElement(Searchbox).Click();
            driver.FindElement(Searchbox).SendKeys("Gary Moore");
            driver.FindElement(Searchbox).SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            //Check result shows on the dropdown
            wait.Until(ExpectedConditions.ElementExists((By)ExistingCustomerSearchDropdown));
            Assert.IsTrue(driver.FindElement(ExistingCustomerSearchDropdown).Displayed);
            driver.FindElement(ExistingCustomerSearchDropdown).Click();
            Thread.Sleep(2000);
            //Check result is shown under access channel after selecting from dropdown
            wait.Until(ExpectedConditions.ElementExists((By)ExistingCustomerSearchResult));
            Assert.IsTrue(driver.FindElement(ExistingCustomerSearchResult).Displayed);
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
            wait.Until(ExpectedConditions.ElementExists((By)FAQSearchServiceResult));
            Assert.IsTrue(driver.FindElement(FAQSearchServiceResult).Displayed);
            driver.FindElement(FAQSearchServiceResult).Click();
            Thread.Sleep(2000);
            //Verify customer name and service shown on the create new case overlay
            driver.SwitchTo().DefaultContent();
            wait.Until(ExpectedConditions.ElementExists((By)CustomerNameOnNewCaseOverlay));
            Assert.IsTrue(driver.FindElement(CustomerNameOnNewCaseOverlay).Displayed);
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
            Thread.Sleep(2000);
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
            //Select wakefield case on dropdown
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)AllocatedCaseForm));
            driver.FindElement(AllocatedCaseForm).Click();
            wait.Until(ExpectedConditions.ElementExists((By)AllocatedCaseDropdownWakefield));
            driver.FindElement(AllocatedCaseDropdownWakefield).Click();
            Thread.Sleep(10000);
            //Verify case details page is displayed
            wait.Until(ExpectedConditions.ElementExists((By)CaseDetailsForm));
            Assert.IsTrue(driver.FindElement(CaseDetailsForm).Displayed);
            //Click plus button on timeline
            wait.Until(ExpectedConditions.ElementExists((By)AddTimelineRecord));
            driver.FindElement(AddTimelineRecord).Click();
            //Click Escalate
            wait.Until(ExpectedConditions.ElementExists((By)AddEscalate));
            driver.FindElement(AddEscalate).Click();
            Thread.Sleep(2000);
            //Enter complaints type
            wait.Until(ExpectedConditions.ElementExists((By)AddComplaintsType));
            driver.FindElement(AddComplaintsType).Click();
            driver.FindElement(AddComplaintsType).SendKeys("Social Care Complaint");
            Thread.Sleep(2000);
            //Click social care complaint from dropdown
            wait.Until(ExpectedConditions.ElementExists((By)SocialCareComplaintOnDropdown));
            driver.FindElement(SocialCareComplaintOnDropdown).Click();
            //Click escalation stage
            wait.Until(ExpectedConditions.ElementExists((By)AddEscalationStage));
            driver.FindElement(AddEscalationStage).Click();
            driver.FindElement(AddEscalationStage).SendKeys("Adult Stage 1");
            Thread.Sleep(2000);
            //Click adult local resolution from dropdown
            wait.Until(ExpectedConditions.ElementExists((By)AdultStage1OnDropdown));
            driver.FindElement(AdultStage1OnDropdown).Click();
            //Click access channel from dropdown
            wait.Until(ExpectedConditions.ElementExists((By)AccessChannelPhoneOnDropdown));
            driver.FindElement(AccessChannelPhoneOnDropdown).Click();
            //Click save and close
            wait.Until(ExpectedConditions.ElementExists((By)BespokePausingSave));
            driver.FindElement(BespokePausingSave).Click();
            Thread.Sleep(5000);
            //Verify linked case is shown
            wait.Until(ExpectedConditions.ElementExists((By)LinkedCaseOnComplaintsForm));
            Assert.IsTrue(driver.FindElement(LinkedCaseOnComplaintsForm).Displayed);
            //Click complaint overview
            wait.Until(ExpectedConditions.ElementExists((By)AddComplaintOverview));
            driver.FindElement(AddComplaintOverview).Click();
            driver.FindElement(AddComplaintOverview).SendKeys("Dissatisfied with previous complaint response");
            Thread.Sleep(2000);
            //Click Dissatisfied with previous complaint response from dropdown
            wait.Until(ExpectedConditions.ElementExists((By)ComplaintOverviewDropdown));
            driver.FindElement(ComplaintOverviewDropdown).Click();
            //Enter details of complaint
            wait.Until(ExpectedConditions.ElementExists((By)AddDetailsOfComplaint));
            driver.FindElement(AddDetailsOfComplaint).Click();
            driver.FindElement(AddDetailsOfComplaint).SendKeys("Dissatisfied with previous complaint response");
            Thread.Sleep(2000);
            //Enter desired outcome
            wait.Until(ExpectedConditions.ElementExists((By)AddDesiredOutcome));
            driver.FindElement(AddDesiredOutcome).Click();
            driver.FindElement(AddDesiredOutcome).SendKeys("Mass sackings");
            Thread.Sleep(2000);
            //Click source from dropdown
            driver.FindElement(SourceOnDropdown).Click();
            Thread.Sleep(2000);
            //Verify complaint stage 1 is shown
            wait.Until(ExpectedConditions.ElementExists((By)ComplaintStage1OnForm));
            Assert.IsTrue(driver.FindElement(ComplaintStage1OnForm).Displayed);
            //Click complaint type
            driver.FindElement(ComplaintTypeOnDropdown).Click();
            Thread.Sleep(2000);
            //Click allocate box
            driver.SwitchTo().Frame("WebResource_allocatingpanel");
            wait.Until(ExpectedConditions.ElementExists((By)AllocateBtn));
            driver.FindElement(AllocateBtn).Click();
            Thread.Sleep(2000);
            driver.SwitchTo().DefaultContent();
            //Verify complaint title
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)ComplaintTitle));
            Assert.IsTrue(driver.FindElement(ComplaintTitle).Displayed);
            //Click customer name
            wait.Until(ExpectedConditions.ElementExists((By)CustomerNameOnComplaintForm));
            driver.FindElement(CustomerNameOnComplaintForm).Click();
            Thread.Sleep(4000);
            //Click history tab
            wait.Until(ExpectedConditions.ElementExists((By)HistoryTabOnCustomer));
            driver.FindElement(HistoryTabOnCustomer).Click();
            Thread.Sleep(2000);
            try
            {
                do
                {
                    //Click select all cases
                    wait.Until(ExpectedConditions.ElementExists((By)SelectAllCasesBtn));
                    Thread.Sleep(3000);
                    driver.FindElement(SelectAllCasesBtn).Click();
                    Thread.Sleep(2000);
                    //Click more options dots
                    wait.Until(ExpectedConditions.ElementExists((By)MoreOptionsDotsOnCustomerCases));
                    Thread.Sleep(2000);
                    driver.FindElement(MoreOptionsDotsOnCustomerCases).Click();
                    Thread.Sleep(2000);
                    //Click delete cases
                    wait.Until(ExpectedConditions.ElementExists((By)DeleteCasesFromMoreOptions));
                    Thread.Sleep(2000);
                    driver.FindElement(DeleteCasesFromMoreOptions).Click();
                    Thread.Sleep(2000);
                    //Click delete on the overlay
                    wait.Until(ExpectedConditions.ElementExists((By)DeleteCasesOverlayBtn));
                    Thread.Sleep(2000);
                    driver.FindElement(DeleteCasesOverlayBtn).Click();
                    Thread.Sleep(10000);
                    wait.Until(ExpectedConditions.ElementExists((By)CustomerCasesTitle));
                }
                while (driver.FindElement(CustomerNameOnCustomerHistory).Displayed);
            }
            catch (Exception)
            {
                Console.WriteLine("All cases removed from history screen");
            }
            //Verify cases deleted
            var Cases = 0;
            try
            {
                WebElement cases = (WebElement)driver.FindElement(CustomerNameOnCustomerHistory);
                if (cases.Displayed)
                {
                    Cases = 1;
                    Assert.Fail();
                }
            }
            catch (Exception)
            {
                if (Cases > 0)
                {
                    Console.WriteLine("Cases not removed");
                }
                else
                {
                    Console.WriteLine("Cases removed");
                }
            }
        }

        public void CaseEscalationStage2()
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
            wait.Until(ExpectedConditions.ElementExists((By)Searchbox));
            Assert.IsTrue(driver.FindElement(Searchbox).Displayed);
            //Enter fullname in search
            driver.FindElement(Searchbox).Click();
            driver.FindElement(Searchbox).SendKeys("Gary Moore");
            driver.FindElement(Searchbox).SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            //Check result shows on the dropdown
            wait.Until(ExpectedConditions.ElementExists((By)ExistingCustomerSearchDropdown));
            Assert.IsTrue(driver.FindElement(ExistingCustomerSearchDropdown).Displayed);
            driver.FindElement(ExistingCustomerSearchDropdown).Click();
            Thread.Sleep(2000);
            //Check result is shown under access channel after selecting from dropdown
            wait.Until(ExpectedConditions.ElementExists((By)ExistingCustomerSearchResult));
            Assert.IsTrue(driver.FindElement(ExistingCustomerSearchResult).Displayed);
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
            wait.Until(ExpectedConditions.ElementExists((By)FAQSearchServiceResult));
            Assert.IsTrue(driver.FindElement(FAQSearchServiceResult).Displayed);
            driver.FindElement(FAQSearchServiceResult).Click();
            Thread.Sleep(2000);
            //Verify customer name and service shown on the create new case overlay
            driver.SwitchTo().DefaultContent();
            wait.Until(ExpectedConditions.ElementExists((By)CustomerNameOnNewCaseOverlay));
            Assert.IsTrue(driver.FindElement(CustomerNameOnNewCaseOverlay).Displayed);
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
            Thread.Sleep(2000);
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
            //Select wakefield case on dropdown
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)AllocatedCaseForm));
            driver.FindElement(AllocatedCaseForm).Click();
            wait.Until(ExpectedConditions.ElementExists((By)AllocatedCaseDropdownWakefield));
            driver.FindElement(AllocatedCaseDropdownWakefield).Click();
            Thread.Sleep(10000);
            //Verify case details page is displayed
            wait.Until(ExpectedConditions.ElementExists((By)CaseDetailsForm));
            Assert.IsTrue(driver.FindElement(CaseDetailsForm).Displayed);
            //Click plus button on timeline
            wait.Until(ExpectedConditions.ElementExists((By)AddTimelineRecord));
            driver.FindElement(AddTimelineRecord).Click();
            //Click Escalate
            wait.Until(ExpectedConditions.ElementExists((By)AddEscalate));
            driver.FindElement(AddEscalate).Click();
            Thread.Sleep(2000);
            //Enter complaints type
            wait.Until(ExpectedConditions.ElementExists((By)AddComplaintsType));
            driver.FindElement(AddComplaintsType).Click();
            driver.FindElement(AddComplaintsType).SendKeys("Social Care Complaint");
            Thread.Sleep(2000);
            //Click social care complaint from dropdown
            wait.Until(ExpectedConditions.ElementExists((By)SocialCareComplaintOnDropdown));
            driver.FindElement(SocialCareComplaintOnDropdown).Click();
            //Click escalation stage
            wait.Until(ExpectedConditions.ElementExists((By)AddEscalationStage));
            driver.FindElement(AddEscalationStage).Click();
            driver.FindElement(AddEscalationStage).SendKeys("Adult Stage 2");
            Thread.Sleep(2000);
            //Click adult local resolution from dropdown
            wait.Until(ExpectedConditions.ElementExists((By)AdultStage2OnDropdown));
            driver.FindElement(AdultStage2OnDropdown).Click();
            //Click access channel from dropdown
            wait.Until(ExpectedConditions.ElementExists((By)AccessChannelPhoneOnDropdown));
            driver.FindElement(AccessChannelPhoneOnDropdown).Click();
            //Click save and close
            wait.Until(ExpectedConditions.ElementExists((By)BespokePausingSave));
            driver.FindElement(BespokePausingSave).Click();
            Thread.Sleep(5000);
            //Verify linked case is shown
            wait.Until(ExpectedConditions.ElementExists((By)LinkedCaseOnComplaintsForm));
            Assert.IsTrue(driver.FindElement(LinkedCaseOnComplaintsForm).Displayed);
            //Click complaint overview
            wait.Until(ExpectedConditions.ElementExists((By)AddComplaintOverview));
            driver.FindElement(AddComplaintOverview).Click();
            driver.FindElement(AddComplaintOverview).SendKeys("Dissatisfied with previous complaint response");
            Thread.Sleep(2000);
            //Click Dissatisfied with previous complaint response from dropdown
            wait.Until(ExpectedConditions.ElementExists((By)ComplaintOverviewDropdown));
            driver.FindElement(ComplaintOverviewDropdown).Click();
            //Enter details of complaint
            wait.Until(ExpectedConditions.ElementExists((By)AddDetailsOfComplaint));
            driver.FindElement(AddDetailsOfComplaint).Click();
            driver.FindElement(AddDetailsOfComplaint).SendKeys("Dissatisfied with previous complaint response");
            Thread.Sleep(2000);
            //Enter desired outcome
            wait.Until(ExpectedConditions.ElementExists((By)AddDesiredOutcome));
            driver.FindElement(AddDesiredOutcome).Click();
            driver.FindElement(AddDesiredOutcome).SendKeys("Mass sackings");
            Thread.Sleep(2000);
            //Click source from dropdown
            driver.FindElement(SourceOnDropdown).Click();
            Thread.Sleep(2000);
            //Verify complaint stage 2 is shown
            wait.Until(ExpectedConditions.ElementExists((By)ComplaintStage2OnForm));
            Assert.IsTrue(driver.FindElement(ComplaintStage2OnForm).Displayed);
            //Click complaint type
            driver.FindElement(ComplaintTypeOnDropdown).Click();
            Thread.Sleep(2000);
            //Click allocate box
            driver.SwitchTo().Frame("WebResource_allocatingpanel");
            wait.Until(ExpectedConditions.ElementExists((By)AllocateBtn));
            driver.FindElement(AllocateBtn).Click();
            Thread.Sleep(2000);
            driver.SwitchTo().DefaultContent();
            //Verify complaint title
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)ComplaintTitle));
            Assert.IsTrue(driver.FindElement(ComplaintTitle).Displayed);
            //Click customer name
            wait.Until(ExpectedConditions.ElementExists((By)CustomerNameOnComplaintForm));
            driver.FindElement(CustomerNameOnComplaintForm).Click();
            Thread.Sleep(4000);
            //Click history tab
            wait.Until(ExpectedConditions.ElementExists((By)HistoryTabOnCustomer));
            driver.FindElement(HistoryTabOnCustomer).Click();
            Thread.Sleep(2000);
            try
            {
                do
                {
                    //Click select all cases
                    wait.Until(ExpectedConditions.ElementExists((By)SelectAllCasesBtn));
                    Thread.Sleep(3000);
                    driver.FindElement(SelectAllCasesBtn).Click();
                    Thread.Sleep(2000);
                    //Click more options dots
                    wait.Until(ExpectedConditions.ElementExists((By)MoreOptionsDotsOnCustomerCases));
                    Thread.Sleep(2000);
                    driver.FindElement(MoreOptionsDotsOnCustomerCases).Click();
                    Thread.Sleep(2000);
                    //Click delete cases
                    wait.Until(ExpectedConditions.ElementExists((By)DeleteCasesFromMoreOptions));
                    Thread.Sleep(2000);
                    driver.FindElement(DeleteCasesFromMoreOptions).Click();
                    Thread.Sleep(2000);
                    //Click delete on the overlay
                    wait.Until(ExpectedConditions.ElementExists((By)DeleteCasesOverlayBtn));
                    Thread.Sleep(2000);
                    driver.FindElement(DeleteCasesOverlayBtn).Click();
                    Thread.Sleep(10000);
                    wait.Until(ExpectedConditions.ElementExists((By)CustomerCasesTitle));
                }
                while (driver.FindElement(CustomerNameOnCustomerHistory).Displayed);
            }
            catch (Exception)
            {
                Console.WriteLine("All cases removed from history screen");
            }
            //Verify cases deleted
            var Cases = 0;
            try
            {
                WebElement cases = (WebElement)driver.FindElement(CustomerNameOnCustomerHistory);
                if (cases.Displayed)
                {
                    Cases = 1;
                    Assert.Fail();
                }
            }
            catch (Exception)
            {
                if (Cases > 0)
                {
                    Console.WriteLine("Cases not removed");
                }
                else
                {
                    Console.WriteLine("Cases removed");
                }
            }
        }

        public void CaseEscalationProDisagreement()
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
            wait.Until(ExpectedConditions.ElementExists((By)Searchbox));
            Assert.IsTrue(driver.FindElement(Searchbox).Displayed);
            //Enter fullname in search
            driver.FindElement(Searchbox).Click();
            driver.FindElement(Searchbox).SendKeys("Gary Moore");
            driver.FindElement(Searchbox).SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            //Check result shows on the dropdown
            wait.Until(ExpectedConditions.ElementExists((By)ExistingCustomerSearchDropdown));
            Assert.IsTrue(driver.FindElement(ExistingCustomerSearchDropdown).Displayed);
            driver.FindElement(ExistingCustomerSearchDropdown).Click();
            Thread.Sleep(2000);
            //Check result is shown under access channel after selecting from dropdown
            wait.Until(ExpectedConditions.ElementExists((By)ExistingCustomerSearchResult));
            Assert.IsTrue(driver.FindElement(ExistingCustomerSearchResult).Displayed);
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
            wait.Until(ExpectedConditions.ElementExists((By)FAQSearchServiceResult));
            Assert.IsTrue(driver.FindElement(FAQSearchServiceResult).Displayed);
            driver.FindElement(FAQSearchServiceResult).Click();
            Thread.Sleep(2000);
            //Verify customer name and service shown on the create new case overlay
            driver.SwitchTo().DefaultContent();
            wait.Until(ExpectedConditions.ElementExists((By)CustomerNameOnNewCaseOverlay));
            Assert.IsTrue(driver.FindElement(CustomerNameOnNewCaseOverlay).Displayed);
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
            Thread.Sleep(2000);
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
            //Select wakefield case on dropdown
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)AllocatedCaseForm));
            driver.FindElement(AllocatedCaseForm).Click();
            wait.Until(ExpectedConditions.ElementExists((By)AllocatedCaseDropdownWakefield));
            driver.FindElement(AllocatedCaseDropdownWakefield).Click();
            Thread.Sleep(10000);
            //Verify case details page is displayed
            wait.Until(ExpectedConditions.ElementExists((By)CaseDetailsForm));
            Assert.IsTrue(driver.FindElement(CaseDetailsForm).Displayed);
            //Click plus button on timeline
            wait.Until(ExpectedConditions.ElementExists((By)AddTimelineRecord));
            driver.FindElement(AddTimelineRecord).Click();
            //Click Escalate
            wait.Until(ExpectedConditions.ElementExists((By)AddEscalate));
            driver.FindElement(AddEscalate).Click();
            Thread.Sleep(2000);
            //Enter complaints type
            wait.Until(ExpectedConditions.ElementExists((By)AddComplaintsType));
            driver.FindElement(AddComplaintsType).Click();
            driver.FindElement(AddComplaintsType).SendKeys("Social Care Complaint");
            Thread.Sleep(2000);
            //Click social care complaint from dropdown
            wait.Until(ExpectedConditions.ElementExists((By)SocialCareComplaintOnDropdown));
            driver.FindElement(SocialCareComplaintOnDropdown).Click();
            //Click escalation stage
            wait.Until(ExpectedConditions.ElementExists((By)AddEscalationStage));
            driver.FindElement(AddEscalationStage).Click();
            driver.FindElement(AddEscalationStage).SendKeys("Professional Disagreement");
            Thread.Sleep(2000);
            //Click adult local resolution from dropdown
            wait.Until(ExpectedConditions.ElementExists((By)AdultProDisagreementOnDropdown));
            driver.FindElement(AdultProDisagreementOnDropdown).Click();
            //Click access channel from dropdown
            wait.Until(ExpectedConditions.ElementExists((By)AccessChannelPhoneOnDropdown));
            driver.FindElement(AccessChannelPhoneOnDropdown).Click();
            //Click save and close
            wait.Until(ExpectedConditions.ElementExists((By)BespokePausingSave));
            driver.FindElement(BespokePausingSave).Click();
            Thread.Sleep(5000);
            //Verify linked case is shown
            wait.Until(ExpectedConditions.ElementExists((By)LinkedCaseOnComplaintsForm));
            Assert.IsTrue(driver.FindElement(LinkedCaseOnComplaintsForm).Displayed);
            //Click complaint overview
            wait.Until(ExpectedConditions.ElementExists((By)AddComplaintOverview));
            driver.FindElement(AddComplaintOverview).Click();
            driver.FindElement(AddComplaintOverview).SendKeys("Dissatisfied with previous complaint response");
            Thread.Sleep(2000);
            //Click Dissatisfied with previous complaint response from dropdown
            wait.Until(ExpectedConditions.ElementExists((By)ComplaintOverviewDropdown));
            driver.FindElement(ComplaintOverviewDropdown).Click();
            //Enter details of complaint
            wait.Until(ExpectedConditions.ElementExists((By)AddDetailsOfComplaint));
            driver.FindElement(AddDetailsOfComplaint).Click();
            driver.FindElement(AddDetailsOfComplaint).SendKeys("Dissatisfied with previous complaint response");
            Thread.Sleep(2000);
            //Enter desired outcome
            wait.Until(ExpectedConditions.ElementExists((By)AddDesiredOutcome));
            driver.FindElement(AddDesiredOutcome).Click();
            driver.FindElement(AddDesiredOutcome).SendKeys("Mass sackings");
            Thread.Sleep(2000);
            //Click source from dropdown
            driver.FindElement(SourceOnDropdown).Click();
            Thread.Sleep(2000);
            //Verify complaint professional disagreement is shown
            wait.Until(ExpectedConditions.ElementExists((By)ProDisagreementOnForm));
            Assert.IsTrue(driver.FindElement(ProDisagreementOnForm).Displayed);
            //Click complaint type
            driver.FindElement(ComplaintTypeOnDropdown).Click();
            Thread.Sleep(2000);
            //Click allocate box
            driver.SwitchTo().Frame("WebResource_allocatingpanel");
            wait.Until(ExpectedConditions.ElementExists((By)AllocateBtn));
            driver.FindElement(AllocateBtn).Click();
            Thread.Sleep(2000);
            driver.SwitchTo().DefaultContent();
            //Verify complaint title
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)ComplaintTitle));
            Assert.IsTrue(driver.FindElement(ComplaintTitle).Displayed);
            //Click customer name
            wait.Until(ExpectedConditions.ElementExists((By)CustomerNameOnComplaintForm));
            driver.FindElement(CustomerNameOnComplaintForm).Click();
            Thread.Sleep(4000);
            //Click history tab
            wait.Until(ExpectedConditions.ElementExists((By)HistoryTabOnCustomer));
            driver.FindElement(HistoryTabOnCustomer).Click();
            Thread.Sleep(2000);
            try
            {
                do
                {
                    //Click select all cases
                    wait.Until(ExpectedConditions.ElementExists((By)SelectAllCasesBtn));
                    Thread.Sleep(3000);
                    driver.FindElement(SelectAllCasesBtn).Click();
                    Thread.Sleep(2000);
                    //Click more options dots
                    wait.Until(ExpectedConditions.ElementExists((By)MoreOptionsDotsOnCustomerCases));
                    Thread.Sleep(2000);
                    driver.FindElement(MoreOptionsDotsOnCustomerCases).Click();
                    Thread.Sleep(2000);
                    //Click delete cases
                    wait.Until(ExpectedConditions.ElementExists((By)DeleteCasesFromMoreOptions));
                    Thread.Sleep(2000);
                    driver.FindElement(DeleteCasesFromMoreOptions).Click();
                    Thread.Sleep(2000);
                    //Click delete on the overlay
                    wait.Until(ExpectedConditions.ElementExists((By)DeleteCasesOverlayBtn));
                    Thread.Sleep(2000);
                    driver.FindElement(DeleteCasesOverlayBtn).Click();
                    Thread.Sleep(10000);
                    wait.Until(ExpectedConditions.ElementExists((By)CustomerCasesTitle));
                }
                while (driver.FindElement(CustomerNameOnCustomerHistory).Displayed);
            }
            catch (Exception)
            {
                Console.WriteLine("All cases removed from history screen");
            }
            //Verify cases deleted
            var Cases = 0;
            try
            {
                WebElement cases = (WebElement)driver.FindElement(CustomerNameOnCustomerHistory);
                if (cases.Displayed)
                {
                    Cases = 1;
                    Assert.Fail();
                }
            }
            catch (Exception)
            {
                if (Cases > 0)
                {
                    Console.WriteLine("Cases not removed");
                }
                else
                {
                    Console.WriteLine("Cases removed");
                }
            }
        }

        public void CaseEscalationChildren()
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
            wait.Until(ExpectedConditions.ElementExists((By)Searchbox));
            Assert.IsTrue(driver.FindElement(Searchbox).Displayed);
            //Enter fullname in search
            driver.FindElement(Searchbox).Click();
            driver.FindElement(Searchbox).SendKeys("Gary Moore");
            driver.FindElement(Searchbox).SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            //Check result shows on the dropdown
            wait.Until(ExpectedConditions.ElementExists((By)ExistingCustomerSearchDropdown));
            Assert.IsTrue(driver.FindElement(ExistingCustomerSearchDropdown).Displayed);
            driver.FindElement(ExistingCustomerSearchDropdown).Click();
            Thread.Sleep(2000);
            //Check result is shown under access channel after selecting from dropdown
            wait.Until(ExpectedConditions.ElementExists((By)ExistingCustomerSearchResult));
            Assert.IsTrue(driver.FindElement(ExistingCustomerSearchResult).Displayed);
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
            wait.Until(ExpectedConditions.ElementExists((By)FAQSearchServiceResult));
            Assert.IsTrue(driver.FindElement(FAQSearchServiceResult).Displayed);
            driver.FindElement(FAQSearchServiceResult).Click();
            Thread.Sleep(2000);
            //Verify customer name and service shown on the create new case overlay
            driver.SwitchTo().DefaultContent();
            wait.Until(ExpectedConditions.ElementExists((By)CustomerNameOnNewCaseOverlay));
            Assert.IsTrue(driver.FindElement(CustomerNameOnNewCaseOverlay).Displayed);
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
            Thread.Sleep(2000);
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
            //Select wakefield case on dropdown
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)AllocatedCaseForm));
            driver.FindElement(AllocatedCaseForm).Click();
            wait.Until(ExpectedConditions.ElementExists((By)AllocatedCaseDropdownWakefield));
            driver.FindElement(AllocatedCaseDropdownWakefield).Click();
            Thread.Sleep(10000);
            //Verify case details page is displayed
            wait.Until(ExpectedConditions.ElementExists((By)CaseDetailsForm));
            Assert.IsTrue(driver.FindElement(CaseDetailsForm).Displayed);
            //Click plus button on timeline
            wait.Until(ExpectedConditions.ElementExists((By)AddTimelineRecord));
            driver.FindElement(AddTimelineRecord).Click();
            //Click Escalate
            wait.Until(ExpectedConditions.ElementExists((By)AddEscalate));
            driver.FindElement(AddEscalate).Click();
            Thread.Sleep(2000);
            //Enter complaints type
            wait.Until(ExpectedConditions.ElementExists((By)AddComplaintsType));
            driver.FindElement(AddComplaintsType).Click();
            driver.FindElement(AddComplaintsType).SendKeys("Social Care Complaint");
            Thread.Sleep(2000);
            //Click social care complaint from dropdown
            wait.Until(ExpectedConditions.ElementExists((By)SocialCareComplaintOnDropdown));
            driver.FindElement(SocialCareComplaintOnDropdown).Click();
            //Click escalation stage
            wait.Until(ExpectedConditions.ElementExists((By)AddEscalationStage));
            driver.FindElement(AddEscalationStage).Click();
            driver.FindElement(AddEscalationStage).SendKeys("Children Local Resolution");
            Thread.Sleep(2000);
            //Click adult local resolution from dropdown
            wait.Until(ExpectedConditions.ElementExists((By)ChildrensLocalResolutionOnDropdown));
            driver.FindElement(ChildrensLocalResolutionOnDropdown).Click();
            //Click access channel from dropdown
            wait.Until(ExpectedConditions.ElementExists((By)AccessChannelPhoneOnDropdown));
            driver.FindElement(AccessChannelPhoneOnDropdown).Click();
            //Click save and close
            wait.Until(ExpectedConditions.ElementExists((By)BespokePausingSave));
            driver.FindElement(BespokePausingSave).Click();
            Thread.Sleep(5000);
            //Verify linked case is shown
            wait.Until(ExpectedConditions.ElementExists((By)LinkedCaseOnComplaintsForm));
            Assert.IsTrue(driver.FindElement(LinkedCaseOnComplaintsForm).Displayed);
            //Click complaint overview
            wait.Until(ExpectedConditions.ElementExists((By)AddComplaintOverview));
            driver.FindElement(AddComplaintOverview).Click();
            driver.FindElement(AddComplaintOverview).SendKeys("Dissatisfied with previous complaint response");
            Thread.Sleep(2000);
            //Click Dissatisfied with previous complaint response from dropdown
            wait.Until(ExpectedConditions.ElementExists((By)ComplaintOverviewDropdown));
            driver.FindElement(ComplaintOverviewDropdown).Click();
            //Enter details of complaint
            wait.Until(ExpectedConditions.ElementExists((By)AddDetailsOfComplaint));
            driver.FindElement(AddDetailsOfComplaint).Click();
            driver.FindElement(AddDetailsOfComplaint).SendKeys("Dissatisfied with previous complaint response");
            Thread.Sleep(2000);
            //Enter desired outcome
            wait.Until(ExpectedConditions.ElementExists((By)AddDesiredOutcome));
            driver.FindElement(AddDesiredOutcome).Click();
            driver.FindElement(AddDesiredOutcome).SendKeys("Mass sackings");
            Thread.Sleep(2000);
            //Click source from dropdown
            driver.FindElement(SourceOnDropdown).Click();
            Thread.Sleep(2000);
            //Verify complaint children local resolution is shown
            wait.Until(ExpectedConditions.ElementExists((By)ChildrenLocalComplaintOnForm));
            Assert.IsTrue(driver.FindElement(ChildrenLocalComplaintOnForm).Displayed);
            //Click complaint type
            driver.FindElement(ComplaintTypeOnDropdown).Click();
            Thread.Sleep(2000);
            //Click allocate box
            driver.SwitchTo().Frame("WebResource_allocatingpanel");
            wait.Until(ExpectedConditions.ElementExists((By)AllocateBtn));
            driver.FindElement(AllocateBtn).Click();
            Thread.Sleep(2000);
            driver.SwitchTo().DefaultContent();
            //Verify complaint title
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)ComplaintTitle));
            Assert.IsTrue(driver.FindElement(ComplaintTitle).Displayed);
            //Click customer name
            wait.Until(ExpectedConditions.ElementExists((By)CustomerNameOnComplaintForm));
            driver.FindElement(CustomerNameOnComplaintForm).Click();
            Thread.Sleep(4000);
            //Click history tab
            wait.Until(ExpectedConditions.ElementExists((By)HistoryTabOnCustomer));
            driver.FindElement(HistoryTabOnCustomer).Click();
            Thread.Sleep(2000);
            try
            {
                do
                {
                    //Click select all cases
                    wait.Until(ExpectedConditions.ElementExists((By)SelectAllCasesBtn));
                    Thread.Sleep(3000);
                    driver.FindElement(SelectAllCasesBtn).Click();
                    Thread.Sleep(2000);
                    //Click more options dots
                    wait.Until(ExpectedConditions.ElementExists((By)MoreOptionsDotsOnCustomerCases));
                    Thread.Sleep(2000);
                    driver.FindElement(MoreOptionsDotsOnCustomerCases).Click();
                    Thread.Sleep(2000);
                    //Click delete cases
                    wait.Until(ExpectedConditions.ElementExists((By)DeleteCasesFromMoreOptions));
                    Thread.Sleep(2000);
                    driver.FindElement(DeleteCasesFromMoreOptions).Click();
                    Thread.Sleep(2000);
                    //Click delete on the overlay
                    wait.Until(ExpectedConditions.ElementExists((By)DeleteCasesOverlayBtn));
                    Thread.Sleep(2000);
                    driver.FindElement(DeleteCasesOverlayBtn).Click();
                    Thread.Sleep(10000);
                    wait.Until(ExpectedConditions.ElementExists((By)CustomerCasesTitle));
                }
                while (driver.FindElement(CustomerNameOnCustomerHistory).Displayed);
            }
            catch (Exception)
            {
                Console.WriteLine("All cases removed from history screen");
            }
            //Verify cases deleted
            var Cases = 0;
            try
            {
                WebElement cases = (WebElement)driver.FindElement(CustomerNameOnCustomerHistory);
                if (cases.Displayed)
                {
                    Cases = 1;
                    Assert.Fail();
                }
            }
            catch (Exception)
            {
                if (Cases > 0)
                {
                    Console.WriteLine("Cases not removed");
                }
                else
                {
                    Console.WriteLine("Cases removed");
                }
            }
        }

        public void CaseEscalationStage2Children()
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
            wait.Until(ExpectedConditions.ElementExists((By)Searchbox));
            Assert.IsTrue(driver.FindElement(Searchbox).Displayed);
            //Enter fullname in search
            driver.FindElement(Searchbox).Click();
            driver.FindElement(Searchbox).SendKeys("Gary Moore");
            driver.FindElement(Searchbox).SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            //Check result shows on the dropdown
            wait.Until(ExpectedConditions.ElementExists((By)ExistingCustomerSearchDropdown));
            Assert.IsTrue(driver.FindElement(ExistingCustomerSearchDropdown).Displayed);
            driver.FindElement(ExistingCustomerSearchDropdown).Click();
            Thread.Sleep(2000);
            //Check result is shown under access channel after selecting from dropdown
            wait.Until(ExpectedConditions.ElementExists((By)ExistingCustomerSearchResult));
            Assert.IsTrue(driver.FindElement(ExistingCustomerSearchResult).Displayed);
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
            wait.Until(ExpectedConditions.ElementExists((By)FAQSearchServiceResult));
            Assert.IsTrue(driver.FindElement(FAQSearchServiceResult).Displayed);
            driver.FindElement(FAQSearchServiceResult).Click();
            Thread.Sleep(2000);
            //Verify customer name and service shown on the create new case overlay
            driver.SwitchTo().DefaultContent();
            wait.Until(ExpectedConditions.ElementExists((By)CustomerNameOnNewCaseOverlay));
            Assert.IsTrue(driver.FindElement(CustomerNameOnNewCaseOverlay).Displayed);
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
            Thread.Sleep(2000);
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
            //Select wakefield case on dropdown
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)AllocatedCaseForm));
            driver.FindElement(AllocatedCaseForm).Click();
            wait.Until(ExpectedConditions.ElementExists((By)AllocatedCaseDropdownWakefield));
            driver.FindElement(AllocatedCaseDropdownWakefield).Click();
            Thread.Sleep(10000);
            //Verify case details page is displayed
            wait.Until(ExpectedConditions.ElementExists((By)CaseDetailsForm));
            Assert.IsTrue(driver.FindElement(CaseDetailsForm).Displayed);
            //Click plus button on timeline
            wait.Until(ExpectedConditions.ElementExists((By)AddTimelineRecord));
            driver.FindElement(AddTimelineRecord).Click();
            //Click Escalate
            wait.Until(ExpectedConditions.ElementExists((By)AddEscalate));
            driver.FindElement(AddEscalate).Click();
            Thread.Sleep(2000);
            //Enter complaints type
            wait.Until(ExpectedConditions.ElementExists((By)AddComplaintsType));
            driver.FindElement(AddComplaintsType).Click();
            driver.FindElement(AddComplaintsType).SendKeys("Social Care Complaint");
            Thread.Sleep(2000);
            //Click social care complaint from dropdown
            wait.Until(ExpectedConditions.ElementExists((By)SocialCareComplaintOnDropdown));
            driver.FindElement(SocialCareComplaintOnDropdown).Click();
            //Click escalation stage
            wait.Until(ExpectedConditions.ElementExists((By)AddEscalationStage));
            driver.FindElement(AddEscalationStage).Click();
            driver.FindElement(AddEscalationStage).SendKeys("Children Stage 2");
            Thread.Sleep(2000);
            //Click adult local resolution from dropdown
            wait.Until(ExpectedConditions.ElementExists((By)ChildrenStage2OnDropdown));
            driver.FindElement(ChildrenStage2OnDropdown).Click();
            //Click access channel from dropdown
            wait.Until(ExpectedConditions.ElementExists((By)AccessChannelPhoneOnDropdown));
            driver.FindElement(AccessChannelPhoneOnDropdown).Click();
            //Click save and close
            wait.Until(ExpectedConditions.ElementExists((By)BespokePausingSave));
            driver.FindElement(BespokePausingSave).Click();
            Thread.Sleep(5000);
            //Verify linked case is shown
            wait.Until(ExpectedConditions.ElementExists((By)LinkedCaseOnComplaintsForm));
            Assert.IsTrue(driver.FindElement(LinkedCaseOnComplaintsForm).Displayed);
            //Click complaint overview
            wait.Until(ExpectedConditions.ElementExists((By)AddComplaintOverview));
            driver.FindElement(AddComplaintOverview).Click();
            driver.FindElement(AddComplaintOverview).SendKeys("Dissatisfied with previous complaint response");
            Thread.Sleep(2000);
            //Click Dissatisfied with previous complaint response from dropdown
            wait.Until(ExpectedConditions.ElementExists((By)ComplaintOverviewDropdown));
            driver.FindElement(ComplaintOverviewDropdown).Click();
            //Enter details of complaint
            wait.Until(ExpectedConditions.ElementExists((By)AddDetailsOfComplaint));
            driver.FindElement(AddDetailsOfComplaint).Click();
            driver.FindElement(AddDetailsOfComplaint).SendKeys("Dissatisfied with previous complaint response");
            Thread.Sleep(2000);
            //Enter desired outcome
            wait.Until(ExpectedConditions.ElementExists((By)AddDesiredOutcome));
            driver.FindElement(AddDesiredOutcome).Click();
            driver.FindElement(AddDesiredOutcome).SendKeys("Mass sackings");
            Thread.Sleep(2000);
            //Click source from dropdown
            driver.FindElement(SourceOnDropdown).Click();
            Thread.Sleep(2000);
            //Verify complaint stage 2 is shown
            wait.Until(ExpectedConditions.ElementExists((By)ComplaintStage2ChildrenOnForm));
            Assert.IsTrue(driver.FindElement(ComplaintStage2ChildrenOnForm).Displayed);
            //Click complaint type
            driver.FindElement(ComplaintTypeOnDropdown).Click();
            Thread.Sleep(2000);
            //Click allocate box
            driver.SwitchTo().Frame("WebResource_allocatingpanel");
            wait.Until(ExpectedConditions.ElementExists((By)AllocateBtn));
            driver.FindElement(AllocateBtn).Click();
            Thread.Sleep(2000);
            driver.SwitchTo().DefaultContent();
            //Verify complaint title
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)ComplaintTitle));
            Assert.IsTrue(driver.FindElement(ComplaintTitle).Displayed);
            //Click customer name
            wait.Until(ExpectedConditions.ElementExists((By)CustomerNameOnComplaintForm));
            driver.FindElement(CustomerNameOnComplaintForm).Click();
            Thread.Sleep(4000);
            //Click history tab
            wait.Until(ExpectedConditions.ElementExists((By)HistoryTabOnCustomer));
            driver.FindElement(HistoryTabOnCustomer).Click();
            Thread.Sleep(2000);
            try
            {
                do
                {
                    //Click select all cases
                    wait.Until(ExpectedConditions.ElementExists((By)SelectAllCasesBtn));
                    Thread.Sleep(3000);
                    driver.FindElement(SelectAllCasesBtn).Click();
                    Thread.Sleep(2000);
                    //Click more options dots
                    wait.Until(ExpectedConditions.ElementExists((By)MoreOptionsDotsOnCustomerCases));
                    Thread.Sleep(2000);
                    driver.FindElement(MoreOptionsDotsOnCustomerCases).Click();
                    Thread.Sleep(2000);
                    //Click delete cases
                    wait.Until(ExpectedConditions.ElementExists((By)DeleteCasesFromMoreOptions));
                    Thread.Sleep(2000);
                    driver.FindElement(DeleteCasesFromMoreOptions).Click();
                    Thread.Sleep(2000);
                    //Click delete on the overlay
                    wait.Until(ExpectedConditions.ElementExists((By)DeleteCasesOverlayBtn));
                    Thread.Sleep(2000);
                    driver.FindElement(DeleteCasesOverlayBtn).Click();
                    Thread.Sleep(10000);
                    wait.Until(ExpectedConditions.ElementExists((By)CustomerCasesTitle));
                }
                while (driver.FindElement(CustomerNameOnCustomerHistory).Displayed);
            }
            catch (Exception)
            {
                Console.WriteLine("All cases removed from history screen");
            }
            //Verify cases deleted
            var Cases = 0;
            try
            {
                WebElement cases = (WebElement)driver.FindElement(CustomerNameOnCustomerHistory);
                if (cases.Displayed)
                {
                    Cases = 1;
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                if (Cases > 0)
                {
                    Console.WriteLine("Cases not removed");
                }
                else
                {
                    Console.WriteLine("Cases removed");
                }
            }
        }

        public void CaseEscalationProDisChildren()
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
            wait.Until(ExpectedConditions.ElementExists((By)Searchbox));
            Assert.IsTrue(driver.FindElement(Searchbox).Displayed);
            //Enter fullname in search
            driver.FindElement(Searchbox).Click();
            driver.FindElement(Searchbox).SendKeys("Gary Moore");
            driver.FindElement(Searchbox).SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            //Check result shows on the dropdown
            wait.Until(ExpectedConditions.ElementExists((By)ExistingCustomerSearchDropdown));
            Assert.IsTrue(driver.FindElement(ExistingCustomerSearchDropdown).Displayed);
            driver.FindElement(ExistingCustomerSearchDropdown).Click();
            Thread.Sleep(2000);
            //Check result is shown under access channel after selecting from dropdown
            wait.Until(ExpectedConditions.ElementExists((By)ExistingCustomerSearchResult));
            Assert.IsTrue(driver.FindElement(ExistingCustomerSearchResult).Displayed);
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
            wait.Until(ExpectedConditions.ElementExists((By)FAQSearchServiceResult));
            Assert.IsTrue(driver.FindElement(FAQSearchServiceResult).Displayed);
            driver.FindElement(FAQSearchServiceResult).Click();
            Thread.Sleep(2000);
            //Verify customer name and service shown on the create new case overlay
            driver.SwitchTo().DefaultContent();
            wait.Until(ExpectedConditions.ElementExists((By)CustomerNameOnNewCaseOverlay));
            Assert.IsTrue(driver.FindElement(CustomerNameOnNewCaseOverlay).Displayed);
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
            Thread.Sleep(2000);
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
            //Select wakefield case on dropdown
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)AllocatedCaseForm));
            driver.FindElement(AllocatedCaseForm).Click();
            wait.Until(ExpectedConditions.ElementExists((By)AllocatedCaseDropdownWakefield));
            driver.FindElement(AllocatedCaseDropdownWakefield).Click();
            Thread.Sleep(10000);
            //Verify case details page is displayed
            wait.Until(ExpectedConditions.ElementExists((By)CaseDetailsForm));
            Assert.IsTrue(driver.FindElement(CaseDetailsForm).Displayed);
            //Click plus button on timeline
            wait.Until(ExpectedConditions.ElementExists((By)AddTimelineRecord));
            driver.FindElement(AddTimelineRecord).Click();
            //Click Escalate
            wait.Until(ExpectedConditions.ElementExists((By)AddEscalate));
            driver.FindElement(AddEscalate).Click();
            Thread.Sleep(2000);
            //Enter complaints type
            wait.Until(ExpectedConditions.ElementExists((By)AddComplaintsType));
            driver.FindElement(AddComplaintsType).Click();
            driver.FindElement(AddComplaintsType).SendKeys("Social Care Complaint");
            Thread.Sleep(2000);
            //Click social care complaint from dropdown
            wait.Until(ExpectedConditions.ElementExists((By)SocialCareComplaintOnDropdown));
            driver.FindElement(SocialCareComplaintOnDropdown).Click();
            //Click escalation stage
            wait.Until(ExpectedConditions.ElementExists((By)AddEscalationStage));
            driver.FindElement(AddEscalationStage).Click();
            driver.FindElement(AddEscalationStage).SendKeys("Professional Disagreement");
            Thread.Sleep(2000);
            //Click adult local resolution from dropdown
            wait.Until(ExpectedConditions.ElementExists((By)ChildProDisagreementOnDropdown));
            driver.FindElement(ChildProDisagreementOnDropdown).Click();
            //Click access channel from dropdown
            wait.Until(ExpectedConditions.ElementExists((By)AccessChannelPhoneOnDropdown));
            driver.FindElement(AccessChannelPhoneOnDropdown).Click();
            //Click save and close
            wait.Until(ExpectedConditions.ElementExists((By)BespokePausingSave));
            driver.FindElement(BespokePausingSave).Click();
            Thread.Sleep(5000);
            //Verify linked case is shown
            wait.Until(ExpectedConditions.ElementExists((By)LinkedCaseOnComplaintsForm));
            Assert.IsTrue(driver.FindElement(LinkedCaseOnComplaintsForm).Displayed);
            //Click complaint overview
            wait.Until(ExpectedConditions.ElementExists((By)AddComplaintOverview));
            driver.FindElement(AddComplaintOverview).Click();
            driver.FindElement(AddComplaintOverview).SendKeys("Dissatisfied with previous complaint response");
            Thread.Sleep(2000);
            //Click Dissatisfied with previous complaint response from dropdown
            wait.Until(ExpectedConditions.ElementExists((By)ComplaintOverviewDropdown));
            driver.FindElement(ComplaintOverviewDropdown).Click();
            //Enter details of complaint
            wait.Until(ExpectedConditions.ElementExists((By)AddDetailsOfComplaint));
            driver.FindElement(AddDetailsOfComplaint).Click();
            driver.FindElement(AddDetailsOfComplaint).SendKeys("Dissatisfied with previous complaint response");
            Thread.Sleep(2000);
            //Enter desired outcome
            wait.Until(ExpectedConditions.ElementExists((By)AddDesiredOutcome));
            driver.FindElement(AddDesiredOutcome).Click();
            driver.FindElement(AddDesiredOutcome).SendKeys("Mass sackings");
            Thread.Sleep(2000);
            //Click source from dropdown
            driver.FindElement(SourceOnDropdown).Click();
            Thread.Sleep(2000);
            //Verify professional disagreement is shown
            wait.Until(ExpectedConditions.ElementExists((By)ProDisagreementChildOnForm));
            Assert.IsTrue(driver.FindElement(ProDisagreementChildOnForm).Displayed);
            //Click complaint type
            driver.FindElement(ComplaintTypeOnDropdown).Click();
            Thread.Sleep(2000);
            //Click allocate box
            driver.SwitchTo().Frame("WebResource_allocatingpanel");
            wait.Until(ExpectedConditions.ElementExists((By)AllocateBtn));
            driver.FindElement(AllocateBtn).Click();
            Thread.Sleep(2000);
            driver.SwitchTo().DefaultContent();
            //Verify complaint title
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)ComplaintTitle));
            Assert.IsTrue(driver.FindElement(ComplaintTitle).Displayed);
            //Click customer name
            wait.Until(ExpectedConditions.ElementExists((By)CustomerNameOnComplaintForm));
            driver.FindElement(CustomerNameOnComplaintForm).Click();
            Thread.Sleep(4000);
            //Click history tab
            wait.Until(ExpectedConditions.ElementExists((By)HistoryTabOnCustomer));
            driver.FindElement(HistoryTabOnCustomer).Click();
            Thread.Sleep(2000);
            try
            {
                do
                {
                    //Click select all cases
                    wait.Until(ExpectedConditions.ElementExists((By)SelectAllCasesBtn));
                    Thread.Sleep(3000);
                    driver.FindElement(SelectAllCasesBtn).Click();
                    Thread.Sleep(2000);
                    //Click more options dots
                    wait.Until(ExpectedConditions.ElementExists((By)MoreOptionsDotsOnCustomerCases));
                    Thread.Sleep(2000);
                    driver.FindElement(MoreOptionsDotsOnCustomerCases).Click();
                    Thread.Sleep(2000);
                    //Click delete cases
                    wait.Until(ExpectedConditions.ElementExists((By)DeleteCasesFromMoreOptions));
                    Thread.Sleep(2000);
                    driver.FindElement(DeleteCasesFromMoreOptions).Click();
                    Thread.Sleep(2000);
                    //Click delete on the overlay
                    wait.Until(ExpectedConditions.ElementExists((By)DeleteCasesOverlayBtn));
                    Thread.Sleep(2000);
                    driver.FindElement(DeleteCasesOverlayBtn).Click();
                    Thread.Sleep(10000);
                    wait.Until(ExpectedConditions.ElementExists((By)CustomerCasesTitle));
                }
                while (driver.FindElement(CustomerNameOnCustomerHistory).Displayed);
            }
            catch (Exception)
            {
                Console.WriteLine("All cases removed from history screen");
            }
            //Verify cases deleted
            var Cases = 0;
            try
            {
                WebElement cases = (WebElement)driver.FindElement(CustomerNameOnCustomerHistory);
                if (cases.Displayed)
                {
                    Cases = 1;
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                if (Cases > 0)
                {
                    Console.WriteLine("Cases not removed");
                }
                else
                {
                    Console.WriteLine("Cases removed");
                }
            }
        }

        public void CorporateCaseEscalation()
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
            wait.Until(ExpectedConditions.ElementExists((By)Searchbox));
            Assert.IsTrue(driver.FindElement(Searchbox).Displayed);
            //Enter fullname in search
            driver.FindElement(Searchbox).Click();
            driver.FindElement(Searchbox).SendKeys("Gary Moore");
            driver.FindElement(Searchbox).SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            //Check result shows on the dropdown
            wait.Until(ExpectedConditions.ElementExists((By)ExistingCustomerSearchDropdown));
            Assert.IsTrue(driver.FindElement(ExistingCustomerSearchDropdown).Displayed);
            driver.FindElement(ExistingCustomerSearchDropdown).Click();
            Thread.Sleep(2000);
            //Check result is shown under access channel after selecting from dropdown
            wait.Until(ExpectedConditions.ElementExists((By)ExistingCustomerSearchResult));
            Assert.IsTrue(driver.FindElement(ExistingCustomerSearchResult).Displayed);
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
            wait.Until(ExpectedConditions.ElementExists((By)FAQSearchServiceResult));
            Assert.IsTrue(driver.FindElement(FAQSearchServiceResult).Displayed);
            driver.FindElement(FAQSearchServiceResult).Click();
            Thread.Sleep(2000);
            //Verify customer name and service shown on the create new case overlay
            driver.SwitchTo().DefaultContent();
            wait.Until(ExpectedConditions.ElementExists((By)CustomerNameOnNewCaseOverlay));
            Assert.IsTrue(driver.FindElement(CustomerNameOnNewCaseOverlay).Displayed);
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
            Thread.Sleep(2000);
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
            //Select wakefield case on dropdown
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)AllocatedCaseForm));
            driver.FindElement(AllocatedCaseForm).Click();
            wait.Until(ExpectedConditions.ElementExists((By)AllocatedCaseDropdownWakefield));
            driver.FindElement(AllocatedCaseDropdownWakefield).Click();
            Thread.Sleep(10000);
            //Verify case details page is displayed
            wait.Until(ExpectedConditions.ElementExists((By)CaseDetailsForm));
            Assert.IsTrue(driver.FindElement(CaseDetailsForm).Displayed);
            //Click plus button on timeline
            wait.Until(ExpectedConditions.ElementExists((By)AddTimelineRecord));
            driver.FindElement(AddTimelineRecord).Click();
            //Click Escalate
            wait.Until(ExpectedConditions.ElementExists((By)AddEscalate));
            driver.FindElement(AddEscalate).Click();
            Thread.Sleep(2000);
            //Enter complaints type
            wait.Until(ExpectedConditions.ElementExists((By)AddComplaintsType));
            driver.FindElement(AddComplaintsType).Click();
            driver.FindElement(AddComplaintsType).SendKeys("Corporate Complaint");
            Thread.Sleep(2000);
            //Click social care complaint from dropdown
            wait.Until(ExpectedConditions.ElementExists((By)SocialCareComplaintOnDropdown));
            driver.FindElement(SocialCareComplaintOnDropdown).Click();
            //Click escalation stage
            wait.Until(ExpectedConditions.ElementExists((By)AddEscalationStage));
            driver.FindElement(AddEscalationStage).Click();
            driver.FindElement(AddEscalationStage).SendKeys("Adult Local Resolution");
            Thread.Sleep(2000);
            //Click adult local resolution from dropdown
            wait.Until(ExpectedConditions.ElementExists((By)AdultLocalResolutionOnDropdown));
            driver.FindElement(AdultLocalResolutionOnDropdown).Click();
            //Click access channel from dropdown
            wait.Until(ExpectedConditions.ElementExists((By)AccessChannelPhoneOnDropdown));
            driver.FindElement(AccessChannelPhoneOnDropdown).Click();
            //Click save and close
            wait.Until(ExpectedConditions.ElementExists((By)BespokePausingSave));
            driver.FindElement(BespokePausingSave).Click();
            Thread.Sleep(5000);
            //Verify linked case is shown
            wait.Until(ExpectedConditions.ElementExists((By)LinkedCaseOnComplaintsForm));
            Assert.IsTrue(driver.FindElement(LinkedCaseOnComplaintsForm).Displayed);
            //Click complaint overview
            wait.Until(ExpectedConditions.ElementExists((By)AddComplaintOverview));
            driver.FindElement(AddComplaintOverview).Click();
            driver.FindElement(AddComplaintOverview).SendKeys("Dissatisfied with previous complaint response");
            Thread.Sleep(2000);
            //Click Dissatisfied with previous complaint response from dropdown
            wait.Until(ExpectedConditions.ElementExists((By)ComplaintOverviewDropdown));
            driver.FindElement(ComplaintOverviewDropdown).Click();
            //Enter details of complaint
            wait.Until(ExpectedConditions.ElementExists((By)AddDetailsOfComplaint));
            driver.FindElement(AddDetailsOfComplaint).Click();
            driver.FindElement(AddDetailsOfComplaint).SendKeys("Dissatisfied with previous complaint response");
            Thread.Sleep(2000);
            //Enter desired outcome
            wait.Until(ExpectedConditions.ElementExists((By)AddDesiredOutcome));
            driver.FindElement(AddDesiredOutcome).Click();
            driver.FindElement(AddDesiredOutcome).SendKeys("Mass sackings");
            Thread.Sleep(2000);
            //Click source from dropdown
            driver.FindElement(SourceOnDropdown).Click();
            Thread.Sleep(2000);
            //Click complaint type
            driver.FindElement(ComplaintTypeOnDropdown).Click();
            Thread.Sleep(2000);
            //Click allocate box
            driver.SwitchTo().Frame("WebResource_allocatingpanel");
            wait.Until(ExpectedConditions.ElementExists((By)AllocateBtn));
            driver.FindElement(AllocateBtn).Click();
            Thread.Sleep(2000);
            driver.SwitchTo().DefaultContent();
            //Verify complaint title
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)ComplaintTitle));
            Assert.IsTrue(driver.FindElement(ComplaintTitle).Displayed);
            //Click customer name
            wait.Until(ExpectedConditions.ElementExists((By)CustomerNameOnComplaintForm));
            driver.FindElement(CustomerNameOnComplaintForm).Click();
            Thread.Sleep(4000);
            //Click history tab
            wait.Until(ExpectedConditions.ElementExists((By)HistoryTabOnCustomer));
            driver.FindElement(HistoryTabOnCustomer).Click();
            Thread.Sleep(2000);
            try
            {
                do
                {
                    //Click select all cases
                    wait.Until(ExpectedConditions.ElementExists((By)SelectAllCasesBtn));
                    Thread.Sleep(3000);
                    driver.FindElement(SelectAllCasesBtn).Click();
                    Thread.Sleep(2000);
                    //Click more options dots
                    wait.Until(ExpectedConditions.ElementExists((By)MoreOptionsDotsOnCustomerCases));
                    Thread.Sleep(2000);
                    driver.FindElement(MoreOptionsDotsOnCustomerCases).Click();
                    Thread.Sleep(2000);
                    //Click delete cases
                    wait.Until(ExpectedConditions.ElementExists((By)DeleteCasesFromMoreOptions));
                    Thread.Sleep(2000);
                    driver.FindElement(DeleteCasesFromMoreOptions).Click();
                    Thread.Sleep(2000);
                    //Click delete on the overlay
                    wait.Until(ExpectedConditions.ElementExists((By)DeleteCasesOverlayBtn));
                    Thread.Sleep(2000);
                    driver.FindElement(DeleteCasesOverlayBtn).Click();
                    Thread.Sleep(10000);
                    wait.Until(ExpectedConditions.ElementExists((By)CustomerCasesTitle));
                }
                while (driver.FindElement(CustomerNameOnCustomerHistory).Displayed);
            }
            catch (Exception)
            {
                Console.WriteLine("All cases removed from history screen");
            }
            //Verify cases deleted
            var Cases = 0;
            try
            {
                WebElement cases = (WebElement)driver.FindElement(CustomerNameOnCustomerHistory);
                if (cases.Displayed)
                {
                    Cases = 1;
                    Assert.Fail();
                }
            }
            catch (Exception)
            {
                if (Cases > 0)
                {
                    Console.WriteLine("Cases not removed");
                }
                else
                {
                    Console.WriteLine("Cases removed");
                }
            }
        }

        public void AutoCloseCaseStatus()
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
            wait.Until(ExpectedConditions.ElementExists((By)Searchbox));
            Assert.IsTrue(driver.FindElement(Searchbox).Displayed);
            //Enter fullname in search
            driver.FindElement(Searchbox).Click();
            driver.FindElement(Searchbox).SendKeys("Gary Moore");
            driver.FindElement(Searchbox).SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            //Check result shows on the dropdown
            wait.Until(ExpectedConditions.ElementExists((By)ExistingCustomerSearchDropdown));
            Assert.IsTrue(driver.FindElement(ExistingCustomerSearchDropdown).Displayed);
            driver.FindElement(ExistingCustomerSearchDropdown).Click();
            Thread.Sleep(2000);
            //Check result is shown under access channel after selecting from dropdown
            wait.Until(ExpectedConditions.ElementExists((By)ExistingCustomerSearchResult));
            Assert.IsTrue(driver.FindElement(ExistingCustomerSearchResult).Displayed);
            //Select access channel
            Thread.Sleep(1000);
            driver.FindElement(AccessChannelDropdown).Click();
            Thread.Sleep(1000);
            driver.FindElement(AccessChannelOptionPhone).Click();
            //Enter search term
            Thread.Sleep(1000);
            driver.FindElement(FAQSearchBox).Click();
            Thread.Sleep(1000);
            driver.FindElement(FAQSearchBox).SendKeys("Noise");
            Thread.Sleep(2000);
            //Verify service result is shown and click on it
            wait.Until(ExpectedConditions.ElementExists((By)FAQSearchNoiseResult));
            Assert.IsTrue(driver.FindElement(FAQSearchNoiseResult).Displayed);
            driver.FindElement(FAQSearchNoiseResult).Click();
            Thread.Sleep(2000);
            //Click yes on overlay
            driver.SwitchTo().DefaultContent();
            wait.Until(ExpectedConditions.ElementExists((By)YesBtnOnNewCaseOverlay));
            driver.FindElement(YesBtnOnNewCaseOverlay).Click();
            Thread.Sleep(3000);
            //Verify noise form loads
            wait.Until(ExpectedConditions.ElementExists((By)NoiseFormTitle));
            Assert.IsTrue(driver.FindElement(NoiseFormTitle).Displayed);
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
            // Select domestic property type
            Actions actions = new Actions(driver);
            actions.SendKeys(Keys.PageDown).Build().Perform();
            Thread.Sleep(2000);
            driver.FindElement(DomesticNoiseType).Click();
            Thread.Sleep(2000);
            //Select dogs and other animals
            driver.FindElement(AnimalNoiseType).Click();
            Thread.Sleep(2000);
            //Enter free text in where is noise coming from
            wait.Until(ExpectedConditions.ElementExists((By)AnimalNoiseTypeFreeTextBox));
            driver.FindElement(AnimalNoiseTypeFreeTextBox).Click();
            Thread.Sleep(2000);
            driver.FindElement(AnimalNoiseTypeFreeTextBox).SendKeys("No");
            Thread.Sleep(2000);
            //Enter free text in how often does noise occur
            wait.Until(ExpectedConditions.ElementExists((By)NoiseFrequencyFreeTextBox));
            driver.FindElement(NoiseFrequencyFreeTextBox).Click();
            Thread.Sleep(2000);
            driver.FindElement(NoiseFrequencyFreeTextBox).SendKeys("No");
            Thread.Sleep(2000);
            //Enter free text in to when does noise occur
            wait.Until(ExpectedConditions.ElementExists((By)NoiseTimeFreeTextBox));
            driver.FindElement(NoiseTimeFreeTextBox).Click();
            Thread.Sleep(2000);
            driver.FindElement(NoiseTimeFreeTextBox).SendKeys("No");
            Thread.Sleep(2000);
            //Select no on have you spoken to them dropdown
            wait.Until(ExpectedConditions.ElementExists((By)NoiseSpokenToThemDropdown));
            driver.FindElement(NoiseSpokenToThemDropdown).Click();
            Thread.Sleep(2000);
            //Select no on willing to speak to them dropdown
            wait.Until(ExpectedConditions.ElementExists((By)NoiseWillingToSpeakDropdown));
            driver.FindElement(NoiseWillingToSpeakDropdown).Click();
            Thread.Sleep(2000);
            //Enter free text in to reason for not talking
            wait.Until(ExpectedConditions.ElementExists((By)ReasonFreeTextBox));
            driver.FindElement(ReasonFreeTextBox).Click();
            Thread.Sleep(2000);
            driver.FindElement(ReasonFreeTextBox).SendKeys("No");
            Thread.Sleep(2000);
            //Click allocate box
            driver.SwitchTo().Frame("WebResource_allocatingpanel");
            wait.Until(ExpectedConditions.ElementExists((By)AllocateBtn));
            driver.FindElement(AllocateBtn).Click();
            Thread.Sleep(4000);
            driver.SwitchTo().DefaultContent();
            //Click allocated case form
            wait.Until(ExpectedConditions.ElementExists((By)AllocatedCaseForm));
            driver.FindElement(AllocatedCaseForm).Click();
            Thread.Sleep(2000);
            //Select wakefield case on dropdown
            wait.Until(ExpectedConditions.ElementExists((By)AllocatedCaseDropdownWakefield));
            driver.FindElement(AllocatedCaseDropdownWakefield).Click();
            Thread.Sleep(10000);
            //Verify case details page is displayed
            wait.Until(ExpectedConditions.ElementExists((By)CaseDetailsForm));
            Assert.IsTrue(driver.FindElement(CaseDetailsForm).Displayed);
            //Verify SLA timer updated to succceded
            Thread.Sleep(2000);
            var SLA = 0;
            try
            {
                if (driver.FindElement(SLATimerSucceeded).Text.ToString().Contains("Succeeded"))
                {
                    Console.WriteLine("SLA Correct");
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                do
                {
                    driver.FindElement(RefreshButtonOnCaseDetails).Click();
                    Thread.Sleep(5000);
                    SLA++;
                    if (driver.FindElement(SLATimerSucceeded).Text.ToString().Contains("Succeeded"))
                    {
                        break;
                    }
                    else if (SLA == 10)
                    {
                        Console.WriteLine("SLA not updated correctly");
                        Assert.Fail();
                    }
                } while (driver.FindElement(SLATimerSucceeded).Text.ToString().Contains("13d"));
            }
            //Verify ribbon shows case as resolved
            wait.Until(ExpectedConditions.ElementExists((By)ClosedCaseRibbonMsg));
            Assert.IsTrue(driver.FindElement(ClosedCaseRibbonMsg).Displayed);
            //Verify status updates to completed
            wait.Until(ExpectedConditions.ElementExists((By)StatusCompleted));
            Assert.IsTrue(driver.FindElement(StatusCompleted).Displayed);
            //Click customer updates/history tab
            wait.Until(ExpectedConditions.ElementExists((By)CaseDetailsCustomerUpdate));
            driver.FindElement(CaseDetailsCustomerUpdate).Click();
            Thread.Sleep(2000);
            try
            {
                do
                {
                    //Click select all cases
                    wait.Until(ExpectedConditions.ElementExists((By)SelectAllCasesBtn));
                    Thread.Sleep(3000);
                    driver.FindElement(SelectAllCasesBtn).Click();
                    Thread.Sleep(2000);
                    //Click more options dots
                    wait.Until(ExpectedConditions.ElementExists((By)MoreOptionsDotsOnCustomerCases));
                    Thread.Sleep(2000);
                    driver.FindElement(MoreOptionsDotsOnCustomerCases).Click();
                    Thread.Sleep(2000);
                    //Click delete cases
                    wait.Until(ExpectedConditions.ElementExists((By)DeleteCasesFromMoreOptions));
                    Thread.Sleep(2000);
                    driver.FindElement(DeleteCasesFromMoreOptions).Click();
                    Thread.Sleep(2000);
                    //Click delete on the overlay
                    wait.Until(ExpectedConditions.ElementExists((By)DeleteCasesOverlayBtn));
                    Thread.Sleep(2000);
                    driver.FindElement(DeleteCasesOverlayBtn).Click();
                    Thread.Sleep(10000);
                    wait.Until(ExpectedConditions.ElementExists((By)CustomerCasesTitle));
                }
                while (driver.FindElement(CustomerNameOnCustomerHistory).Displayed);
            }
            catch (Exception)
            {
                Console.WriteLine("All cases removed from history screen");
            }
            //Verify cases deleted
            var Cases = 0;
            try
            {
                WebElement cases = (WebElement)driver.FindElement(CustomerNameOnCustomerHistory);
                if (cases.Displayed)
                {
                    Cases = 1;
                    Assert.Fail();
                }
            }
            catch (Exception)
            {
                if (Cases > 0)
                {
                    Console.WriteLine("Cases not removed");
                }
                else
                {
                    Console.WriteLine("Cases removed");
                }
            }
        }
    }

}
