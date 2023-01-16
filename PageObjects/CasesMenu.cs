using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace CRMRegressionPack.PageObjects
{
    public class CasesMenu
    {
        By CasesOnLHN = By.XPath("//span[.='Cases']");
        By ActiveCasesList = By.XPath("//span[contains(text(),'Active Cases')]");
        By ActiveCaseSearchBox = By.XPath("//input[@placeholder='Filter by keyword']");
        By CaseNumberOnActiveCaseLst = By.XPath("//div[contains(text(),'CAS-13758-H7N9X0')]");
        By BusinessCaseNumberOnCaseLst = By.XPath("//div[contains(text(),'CAS-14979-T1F9Z8')]");
        By BusinessCaseNumberOnCaseLst2 = By.XPath("//div[contains(text(),'CAS-14251')]"); //Test environment case number

        By CaseTitleOnListAfterSearch = By.XPath("//span[.='Dog Fouling']");
        By DogSearchResultOnList2 = By.XPath("(//span[text()='Dog Fouling'])[1]");
        By DogSearchResultOnList3 = By.XPath("(//span[text()='Dangerous Dog'])[1]");
        By CaseDetailsHeading = By.XPath("//h2[.='CASE DETAILS']");
        By PlusOnTimeline = By.XPath("//button[@title='Create a timeline record.']");
        By FurtherContactOption = By.XPath("//div[text()='Further contact']");
        By FurtherContactDescriptionBox = By.XPath("//label[text()='Description']/following::textarea");
        By AccessChannelDropdown = By.CssSelector(("[aria-label='Access channel']"));
        By AccessChannelDropdownOption = By.CssSelector(("select[aria-label='Access channel'] option[value='1']"));
        By AvoidableContactLabel = By.XPath("(//label[text()='Avoidable Contact'])[2]");
        By AvoidableContactDropdown = By.XPath("//select[@data-id='wmdc_contactavoidable.fieldControl-option-set-select']");
        By AvoidableContactDropdownOption = By.XPath("(//option[@value='762210000'][normalize-space()='Yes'])[4]");
        By AvoidableContactReasonDropdown = By.CssSelector(("[aria-label='Reason for avoidable contact']"));
        By AvoidableContactReasonDropdownOption = By.XPath("//option[normalize-space()='Enquiry past target date']");
        By NotifyServiceDropdown = By.CssSelector(("[aria-label='Notify Service']"));
        By NotifyServiceDropdownOption = By.CssSelector("select[aria-label='Notify Service'] option[value='762210001']");
        By NotifyServiceDropdownOptionNo = By.XPath("//select[@aria-label='Notify Service']//option[@value='762210001'][normalize-space()='No']");
        By SaveAndCloseBtn = By.XPath("//span[text()='Save and Close']");

        By FurtherContactOnTimeline = By.XPath("//label[.='Further contact']");
        By CurrentQueueLink = By.XPath("(//div[@title='SS Pontefract and Knottingley'])[1]");
        By CurrentQueueLinkBusiness = By.XPath("(//div[@title='Street Scene - Default'])[1]");
        By DogFoulingOnQueueItems = By.XPath("(//span[text()='Dog Fouling'])[1]");

        By CustomerUpdates = By.XPath("//li[.='Customer Updates / HistoryCustomer Updates / History']");
        By StatusUpdatesTitle = By.XPath("//h2[.='STATUS UPDATES']");
        By CustomerCasesTitle = By.XPath("//h2[.='CUSTOMERS CASES']");
        By CaseTitle = By.XPath("//label[@title='Case Title']");
        By ReportedAddressLocation = By.XPath("//label[text()='Reported Address Location']");
        By CaseNumber = By.XPath("//label[text()='Case Number']");
        By Customer = By.XPath("//label[text()='Customer']");
        By Origin = By.XPath("//label[text()='Origin']");
        By StatusReason = By.XPath("//label[text()='Status Reason']");
        By CreatedOn = By.XPath("//label[text()='Created On']");
        By SLATarget = By.XPath("(//label[text()='SLA Target Date'])[2]");
        By ReportedBy = By.XPath("//label[text()='Reported By']");
        By ReportedByBusiness = By.XPath("//label[text()='Reported By (Business)']");

        [ThreadStatic]
        IWebDriver driver;
        WebDriverWait wait;

        public CasesMenu(IWebDriver driver)
        {
            this.driver = driver;
            this.wait = new WebDriverWait(driver, TimeSpan.FromSeconds(120));
        }

        public void SearchForCase()
        {
            //Select cases on LHN
            Thread.Sleep(4000);
            wait.Until(ExpectedConditions.ElementExists((By)CasesOnLHN));
            Thread.Sleep(4000);
            driver.FindElement(CasesOnLHN).Click();
            Thread.Sleep(4000);
            wait.Until(ExpectedConditions.ElementExists((By)ActiveCasesList));
            Thread.Sleep(4000);
            Assert.IsTrue(driver.FindElement(ActiveCasesList).Displayed);
            Thread.Sleep(4000);
            //Enter case number in to search field
            wait.Until(ExpectedConditions.ElementExists((By)ActiveCaseSearchBox));
            driver.FindElement(ActiveCaseSearchBox).Click();
            Thread.Sleep(2000);
            driver.FindElement(ActiveCaseSearchBox).SendKeys("CAS-14251"); //Test environment
         //   driver.FindElement(ActiveCaseSearchBox).SendKeys("CAS-13758"); //Wave environment
            Thread.Sleep(2000);
            driver.FindElement(ActiveCaseSearchBox).SendKeys(Keys.Enter);
            Thread.Sleep(4000);
            //Validate result is shown
          //  wait.Until(ExpectedConditions.ElementExists((By)CaseNumberOnActiveCaseLst)); //wave environment
            wait.Until(ExpectedConditions.ElementExists((By)BusinessCaseNumberOnCaseLst2)); //test environment
            Thread.Sleep(1000);
            //  Assert.IsTrue(driver.FindElement(CaseNumberOnActiveCaseLst).Displayed); //wave environment
            Assert.IsTrue(driver.FindElement(BusinessCaseNumberOnCaseLst2).Displayed); //test environment
        }

        public void SearchForCaseType()
        {
            //Verify form loads
            Thread.Sleep(4000);
            wait.Until(ExpectedConditions.ElementExists((By)CasesOnLHN));
            Thread.Sleep(4000);
            driver.FindElement(CasesOnLHN).Click();
            Thread.Sleep(4000);
            wait.Until(ExpectedConditions.ElementExists((By)ActiveCasesList));
            Thread.Sleep(4000);
            Assert.IsTrue(driver.FindElement(ActiveCasesList).Displayed);
            Thread.Sleep(4000);
            //Enter search term
            driver.FindElement(ActiveCaseSearchBox).Click();
            Thread.Sleep(2000);
            driver.FindElement(ActiveCaseSearchBox).SendKeys("Dog");
            Thread.Sleep(2000);
            driver.FindElement(ActiveCaseSearchBox).SendKeys(Keys.Enter);
            Thread.Sleep(4000);
            //Check search results
            try
            {
                if (driver.FindElement(DogSearchResultOnList3).Displayed)
                {
                    Console.WriteLine("Search results correct");
                }
            }
            catch (Exception)
            {
                if (driver.FindElement(DogSearchResultOnList2).Displayed)
                {
                    Console.WriteLine("Search results correct");
                }
                else
                {
                    Console.WriteLine("Search results not correct");
                    Assert.Fail();
                }
            }
        }

        public void AddFurtherContact()
        {
            //Select cases on LHN
            Thread.Sleep(4000);
            wait.Until(ExpectedConditions.ElementExists((By)CasesOnLHN));
            Thread.Sleep(4000);
            driver.FindElement(CasesOnLHN).Click();
            Thread.Sleep(4000);
            wait.Until(ExpectedConditions.ElementExists((By)ActiveCasesList));
            Thread.Sleep(4000);
            Assert.IsTrue(driver.FindElement(ActiveCasesList).Displayed);
            Thread.Sleep(4000);
            //Enter case number in to search field
            wait.Until(ExpectedConditions.ElementExists((By)ActiveCaseSearchBox));
            driver.FindElement(ActiveCaseSearchBox).Click();
            Thread.Sleep(2000);
         //   driver.FindElement(ActiveCaseSearchBox).SendKeys("CAS-13758");
            driver.FindElement(ActiveCaseSearchBox).SendKeys("CAS-14251");  //Test Environment

            Thread.Sleep(2000);
            driver.FindElement(ActiveCaseSearchBox).SendKeys(Keys.Enter);
            Thread.Sleep(4000);
            //Validate result is shown
          //  wait.Until(ExpectedConditions.ElementExists((By)CaseNumberOnActiveCaseLst));
            wait.Until(ExpectedConditions.ElementExists((By)BusinessCaseNumberOnCaseLst2)); //Test environment

            Thread.Sleep(1000);
         //   Assert.IsTrue(driver.FindElement(CaseNumberOnActiveCaseLst).Displayed);
            Assert.IsTrue(driver.FindElement(BusinessCaseNumberOnCaseLst2).Displayed); //Test environment

            //Click result on the list
            driver.FindElement(DogSearchResultOnList2).Click();
            Thread.Sleep(2000);
            //Verify form loads
            wait.Until(ExpectedConditions.ElementExists((By)CaseDetailsHeading));
            Assert.IsTrue(driver.FindElement(CaseDetailsHeading).Displayed);
            //Click plus on timeline
            wait.Until(ExpectedConditions.ElementExists((By)PlusOnTimeline));
            driver.FindElement(PlusOnTimeline).Click();
            Thread.Sleep(2000);
            //Select further contact option
            wait.Until(ExpectedConditions.ElementExists((By)FurtherContactOption));
            driver.FindElement(FurtherContactOption).Click();
            Thread.Sleep(2000);
            //Add text to description
            wait.Until(ExpectedConditions.ElementExists((By)FurtherContactDescriptionBox));
            driver.FindElement(FurtherContactDescriptionBox).Click();
            Thread.Sleep(2000);
            driver.FindElement(FurtherContactDescriptionBox).SendKeys("Test");
            Thread.Sleep(2000);
            //Select option from access channel dropdown
            driver.FindElement(AccessChannelDropdown).Click();
            Thread.Sleep(2000);
            driver.FindElement(AccessChannelDropdownOption).Click();
            Thread.Sleep(2000);
            //Select option from avoidable contact dropdown
            driver.FindElement(AvoidableContactLabel).Click();
            Thread.Sleep(2000);
            driver.FindElement(AvoidableContactDropdown).Click();
            Thread.Sleep(2000);
            driver.FindElement(AvoidableContactDropdownOption).Click();
            Thread.Sleep(2000);
            //Select option from reason for avoidable contact dropdown
            driver.FindElement(AvoidableContactReasonDropdown).Click();
            Thread.Sleep(2000);
            driver.FindElement(AvoidableContactReasonDropdownOption).Click();
            Thread.Sleep(2000);
            //Select option from notify service dropdown
            driver.FindElement(NotifyServiceDropdown).Click();
            Thread.Sleep(2000);
            driver.FindElement(NotifyServiceDropdownOption).Click();
            Thread.Sleep(2000);
            //Click save and close
            driver.FindElement(SaveAndCloseBtn).Click();
            Thread.Sleep(4000);
            //Verify further contact is shown on the timeline
            wait.Until(ExpectedConditions.ElementExists((By)FurtherContactOnTimeline));
            Assert.IsTrue(driver.FindElement(FurtherContactOnTimeline).Displayed);
            //Click current queue
            Actions actions = new Actions(driver);
            actions.SendKeys(Keys.PageDown).Build().Perform();
            Thread.Sleep(2000);
            driver.FindElement(CurrentQueueLink).Click();
            Thread.Sleep(4000);
            //Verify further contact is shown at top of queue items
            wait.Until(ExpectedConditions.ElementExists((By)DogFoulingOnQueueItems));
            Assert.IsTrue(driver.FindElement(DogFoulingOnQueueItems).Displayed);
        }

        public void AddFurtherContactBusiness()
        {
            //Select cases on LHN
            Thread.Sleep(4000);
            wait.Until(ExpectedConditions.ElementExists((By)CasesOnLHN));
            Thread.Sleep(4000);
            driver.FindElement(CasesOnLHN).Click();
            Thread.Sleep(4000);
            wait.Until(ExpectedConditions.ElementExists((By)ActiveCasesList));
            Thread.Sleep(4000);
            Assert.IsTrue(driver.FindElement(ActiveCasesList).Displayed);
            Thread.Sleep(4000);
            //Enter case number in to search field
            wait.Until(ExpectedConditions.ElementExists((By)ActiveCaseSearchBox));
            driver.FindElement(ActiveCaseSearchBox).Click();
            Thread.Sleep(2000);
            driver.FindElement(ActiveCaseSearchBox).SendKeys("CAS-14251");  //Test Environment
           // driver.FindElement(ActiveCaseSearchBox).SendKeys("CAS-14979"); //Wave Environment
            Thread.Sleep(2000);
            driver.FindElement(ActiveCaseSearchBox).SendKeys(Keys.Enter);
            Thread.Sleep(4000);
            //Validate result is shown
           // wait.Until(ExpectedConditions.ElementExists((By)BusinessCaseNumberOnCaseLst));
            wait.Until(ExpectedConditions.ElementExists((By)BusinessCaseNumberOnCaseLst2)); //Test environment
            Thread.Sleep(1000);
         //   Assert.IsTrue(driver.FindElement(BusinessCaseNumberOnCaseLst).Displayed);
            Assert.IsTrue(driver.FindElement(BusinessCaseNumberOnCaseLst2).Displayed); //Test environment
            //Click result on the list
            driver.FindElement(DogSearchResultOnList2).Click();
            Thread.Sleep(2000);
            //Verify form loads
            wait.Until(ExpectedConditions.ElementExists((By)CaseDetailsHeading));
            Assert.IsTrue(driver.FindElement(CaseDetailsHeading).Displayed);
            //Click plus on timeline
            wait.Until(ExpectedConditions.ElementExists((By)PlusOnTimeline));
            driver.FindElement(PlusOnTimeline).Click();
            Thread.Sleep(2000);
            //Select further contact option
            wait.Until(ExpectedConditions.ElementExists((By)FurtherContactOption));
            driver.FindElement(FurtherContactOption).Click();
            Thread.Sleep(2000);
            //Add text to description
            wait.Until(ExpectedConditions.ElementExists((By)FurtherContactDescriptionBox));
            driver.FindElement(FurtherContactDescriptionBox).Click();
            Thread.Sleep(2000);
            driver.FindElement(FurtherContactDescriptionBox).SendKeys("Test");
            Thread.Sleep(2000);
            //Select option from access channel dropdown
            driver.FindElement(AccessChannelDropdown).Click();
            Thread.Sleep(2000);
            driver.FindElement(AccessChannelDropdownOption).Click();
            Thread.Sleep(2000);
            //Select option from avoidable contact dropdown
            driver.FindElement(AvoidableContactLabel).Click();
            Thread.Sleep(2000);
            driver.FindElement(AvoidableContactDropdown).Click();
            Thread.Sleep(2000);
            driver.FindElement(AvoidableContactDropdownOption).Click();
            Thread.Sleep(2000);
            //Select option from reason for avoidable contact dropdown
            driver.FindElement(AvoidableContactReasonDropdown).Click();
            Thread.Sleep(2000);
            driver.FindElement(AvoidableContactReasonDropdownOption).Click();
            Thread.Sleep(2000);
            //Select option from notify service dropdown
            driver.FindElement(NotifyServiceDropdown).Click();
            Thread.Sleep(2000);
            driver.FindElement(NotifyServiceDropdownOption).Click();
            Thread.Sleep(2000);
            //Click save and close
            driver.FindElement(SaveAndCloseBtn).Click();
            Thread.Sleep(4000);
            //Verify further contact is shown on the timeline
            wait.Until(ExpectedConditions.ElementExists((By)FurtherContactOnTimeline));
            Assert.IsTrue(driver.FindElement(FurtherContactOnTimeline).Displayed);
            //Click current queue
            Actions actions = new Actions(driver);
            actions.SendKeys(Keys.PageDown).Build().Perform();
            Thread.Sleep(2000);
          //  driver.FindElement(CurrentQueueLinkBusiness).Click();
            driver.FindElement(CurrentQueueLink).Click(); //Test environment
            Thread.Sleep(4000);
            //Verify further contact is shown at top of queue items
            wait.Until(ExpectedConditions.ElementExists((By)DogFoulingOnQueueItems));
            Assert.IsTrue(driver.FindElement(DogFoulingOnQueueItems).Displayed);
        }

        public void FurtherContactBusinessNoNotify()
        {
            //Select cases on LHN
            Thread.Sleep(4000);
            wait.Until(ExpectedConditions.ElementExists((By)CasesOnLHN));
            Thread.Sleep(4000);
            driver.FindElement(CasesOnLHN).Click();
            Thread.Sleep(4000);
            wait.Until(ExpectedConditions.ElementExists((By)ActiveCasesList));
            Thread.Sleep(4000);
            Assert.IsTrue(driver.FindElement(ActiveCasesList).Displayed);
            Thread.Sleep(4000);
            //Enter case number in to search field
            wait.Until(ExpectedConditions.ElementExists((By)ActiveCaseSearchBox));
            driver.FindElement(ActiveCaseSearchBox).Click();
            Thread.Sleep(2000);
            driver.FindElement(ActiveCaseSearchBox).SendKeys("CAS-14251");  //Test Environment
           // driver.FindElement(ActiveCaseSearchBox).SendKeys("CAS-14979"); //Wave Environment
            Thread.Sleep(2000);
            driver.FindElement(ActiveCaseSearchBox).SendKeys(Keys.Enter);
            Thread.Sleep(4000);
            //Validate result is shown
            //   wait.Until(ExpectedConditions.ElementExists((By)BusinessCaseNumberOnCaseLst));
            wait.Until(ExpectedConditions.ElementExists((By)BusinessCaseNumberOnCaseLst2)); //Test environment
            Thread.Sleep(1000);
            //   Assert.IsTrue(driver.FindElement(BusinessCaseNumberOnCaseLst).Displayed);
            Assert.IsTrue(driver.FindElement(BusinessCaseNumberOnCaseLst2).Displayed); //Test environment
            //Click result on the list
            driver.FindElement(DogSearchResultOnList2).Click();
            Thread.Sleep(2000);
            //Verify form loads
            wait.Until(ExpectedConditions.ElementExists((By)CaseDetailsHeading));
            Assert.IsTrue(driver.FindElement(CaseDetailsHeading).Displayed);
            //Click plus on timeline
            wait.Until(ExpectedConditions.ElementExists((By)PlusOnTimeline));
            driver.FindElement(PlusOnTimeline).Click();
            Thread.Sleep(2000);
            //Select further contact option
            wait.Until(ExpectedConditions.ElementExists((By)FurtherContactOption));
            driver.FindElement(FurtherContactOption).Click();
            Thread.Sleep(2000);
            //Add text to description
            wait.Until(ExpectedConditions.ElementExists((By)FurtherContactDescriptionBox));
            driver.FindElement(FurtherContactDescriptionBox).Click();
            Thread.Sleep(2000);
            driver.FindElement(FurtherContactDescriptionBox).SendKeys("Test");
            Thread.Sleep(2000);
            //Select option from access channel dropdown
            driver.FindElement(AccessChannelDropdown).Click();
            Thread.Sleep(2000);
            driver.FindElement(AccessChannelDropdownOption).Click();
            Thread.Sleep(2000);
            //Select option from avoidable contact dropdown
            driver.FindElement(AvoidableContactLabel).Click();
            Thread.Sleep(2000);
            driver.FindElement(AvoidableContactDropdown).Click();
            Thread.Sleep(2000);
            driver.FindElement(AvoidableContactDropdownOption).Click();
            Thread.Sleep(2000);
            //Select option from reason for avoidable contact dropdown
            driver.FindElement(AvoidableContactReasonDropdown).Click();
            Thread.Sleep(2000);
            driver.FindElement(AvoidableContactReasonDropdownOption).Click();
            Thread.Sleep(2000);
            //Select option from notify service dropdown
            driver.FindElement(NotifyServiceDropdown).Click();
            Thread.Sleep(2000);
            driver.FindElement(NotifyServiceDropdownOptionNo).Click();
            Thread.Sleep(2000);
            //Click save and close
            driver.FindElement(SaveAndCloseBtn).Click();
            Thread.Sleep(4000);
            //Verify further contact is shown on the timeline
            wait.Until(ExpectedConditions.ElementExists((By)FurtherContactOnTimeline));
            Assert.IsTrue(driver.FindElement(FurtherContactOnTimeline).Displayed);
            //Click current queue
            Actions actions = new Actions(driver);
            actions.SendKeys(Keys.PageDown).Build().Perform();
            Thread.Sleep(2000);
          //  driver.FindElement(CurrentQueueLinkBusiness).Click();
            driver.FindElement(CurrentQueueLink).Click(); // Test environment
            Thread.Sleep(4000);
            //Verify further contact is shown at top of queue items
            wait.Until(ExpectedConditions.ElementExists((By)DogFoulingOnQueueItems));
            Assert.IsTrue(driver.FindElement(DogFoulingOnQueueItems).Displayed);
        }

        public void RecentCasesOnCaseForm()
        {
            //Select cases on LHN
            Thread.Sleep(4000);
            wait.Until(ExpectedConditions.ElementExists((By)CasesOnLHN));
            Thread.Sleep(4000);
            driver.FindElement(CasesOnLHN).Click();
            Thread.Sleep(4000);
            wait.Until(ExpectedConditions.ElementExists((By)ActiveCasesList));
            Thread.Sleep(4000);
            Assert.IsTrue(driver.FindElement(ActiveCasesList).Displayed);
            Thread.Sleep(4000);
            //Enter case number in to search field
            wait.Until(ExpectedConditions.ElementExists((By)ActiveCaseSearchBox));
            driver.FindElement(ActiveCaseSearchBox).Click();
            Thread.Sleep(2000);
            driver.FindElement(ActiveCaseSearchBox).SendKeys("CAS-14251"); //Test environment
           // driver.FindElement(ActiveCaseSearchBox).SendKeys("CAS-13758"); //Wave environment
            Thread.Sleep(2000);
            driver.FindElement(ActiveCaseSearchBox).SendKeys(Keys.Enter);
            Thread.Sleep(4000);
            //Validate result is shown
         //   wait.Until(ExpectedConditions.ElementExists((By)CaseNumberOnActiveCaseLst));
            wait.Until(ExpectedConditions.ElementExists((By)BusinessCaseNumberOnCaseLst2)); //Test environment
            Thread.Sleep(1000);
            //   Assert.IsTrue(driver.FindElement(CaseNumberOnActiveCaseLst).Displayed);
            Assert.IsTrue(driver.FindElement(BusinessCaseNumberOnCaseLst2).Displayed); //Test environment
            driver.FindElement(CaseTitleOnListAfterSearch).Click();
            //Verify summary page is shown
            wait.Until(ExpectedConditions.ElementExists((By)CaseDetailsHeading));
            Assert.IsTrue(driver.FindElement(CaseDetailsHeading).Displayed);
            //Click customer updates/history tab
            wait.Until(ExpectedConditions.ElementExists((By)CustomerUpdates));
            driver.FindElement(CustomerUpdates).Click();
            Thread.Sleep(4000);
            //Verify status updates and customer cases blocks show
            wait.Until(ExpectedConditions.ElementExists((By)StatusUpdatesTitle));
            Assert.IsTrue(driver.FindElement(StatusUpdatesTitle).Displayed);
            Console.WriteLine("Status updates heading correct");
            wait.Until(ExpectedConditions.ElementExists((By)CustomerCasesTitle));
            Assert.IsTrue(driver.FindElement(CustomerCasesTitle).Displayed);
            Console.WriteLine("Customer cases heading correct");
            //Verify case headings are correct
            Assert.IsTrue(driver.FindElement(CaseTitle).Displayed);
            Console.WriteLine("Title heading correct");
            Assert.IsTrue(driver.FindElement(ReportedAddressLocation).Displayed);
            Console.WriteLine("Address heading correct");
            Assert.IsTrue(driver.FindElement(CaseNumber).Displayed);
            Console.WriteLine("Case number heading correct");
            Assert.IsTrue(driver.FindElement(Customer).Displayed);
            Console.WriteLine("Customer heading correct");
            Assert.IsTrue(driver.FindElement(Origin).Displayed);
            Console.WriteLine("Origin heading correct");
            Assert.IsTrue(driver.FindElement(StatusReason).Displayed);
            Console.WriteLine("Status heading correct");
            Assert.IsTrue(driver.FindElement(CreatedOn).Displayed);
            Console.WriteLine("Create on heading correct");
            Assert.IsTrue(driver.FindElement(SLATarget).Displayed);
            Console.WriteLine("SLA heading correct");
            Assert.IsTrue(driver.FindElement(ReportedBy).Displayed);
            Console.WriteLine("Reporte by heading correct");
            Assert.IsTrue(driver.FindElement(ReportedByBusiness).Displayed);
            Console.WriteLine("Reported by business heading correct");
        }
    }
}
