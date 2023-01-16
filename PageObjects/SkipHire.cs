using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace CRMRegressionPack.PageObjects
{
    public class SkipHire
    {
        By DashboardsLHN = By.XPath("//span[contains(text(),'Dashboards')]");
        By QueuesLHN = By.XPath("//span[normalize-space()='Queues']");
        By CasesLHN = By.XPath("//span[normalize-space()='Cases']");

        By DashboardTitle = By.XPath("//span[contains(text(),'Wakefield Home')]");
        By WakefieldUserApp = By.XPath("//span[.='Wakefield User App']");
        By ResourceSchedulingApp = By.XPath("//div[@title='Provides access to the Resource Scheduling solution']");

        By ResourcesLHN = By.XPath("//span[normalize-space()='Resources']");
        By BookingsLHN = By.XPath("//span[normalize-space()='Bookings']");
        By ScheduleBoardLHN = By.XPath("//span[normalize-space()='Schedule Board']");

        By ResourceOnLst = By.XPath("(//span[@aria-label='Select or deselect the row'])[10]");
        By ShowWorkHours = By.XPath("//span[contains(text(),'Show Work Hours')]");
        By CurrentMonthOnCalendar = By.CssSelector(".UbYRs");
        By NewWorkingHoursBtn = By.XPath("//span[contains(text(),'New')]");
        By NewWorkingHoursDropdown = By.XPath("//span[normalize-space()='Working hours']");
        By Day10OnCalendar = By.XPath("//div[contains(text(),'10')]");
        By RepeatDropdownNever = By.XPath("//input[@value='Never']");
        By RepeatDropdownEveryWeek = By.XPath("//input[@value='Every week']");

        By RepeatDropdownCustom = By.XPath("//span[contains(text(),'Custom')]");
        By SundayOnWorkingHours = By.XPath("//span[contains(text(),'Su')]");
        By SaturdayOnWorkingHours = By.XPath("//span[contains(text(),'Sa')]");
        By ChooseEndDate = By.XPath("//span[contains(text(),'choose an end date')]");
        By ChooseEndDateOnCalendar = By.XPath("//body[1]/div[2]/div[1]/div[1]/div[1]/div[1]/div[1]/div[2]/div[2]/div[2]/table[1]/tbody[1]/tr[5]/td[4]");
        By RemoveEndDate = By.XPath("//span[contains(text(),'remove end date')]");

        By HoursOnMonday = By.XPath("//span[@data-automationid='splitbuttonprimary']//span//span[contains(text(),'08:00')]");
        By MondayStartTime = By.XPath("//input[@value='08:00']");
        By MondayFinishTime = By.XPath("//input[@value='12:00']");
        By NewStartTime = By.Id("ComboBox11-input");
        By NewFinishTime = By.Id("ComboBox15-input");

        By WorkHoursApplyBtn = By.XPath("//span[normalize-space()='Apply']");
        By WorkHoursTimezoneDropdown = By.XPath("//div[@data-automation-id='timezonePicker']//span[@data-automationid='splitbuttonprimary']");
        By WorkingHoursTimezoneGMT = By.XPath("//span[contains(text(),'(GMT+00:00) Dublin, Edinburgh, Lisbon, London')]");
        By WorkingTimeAddedToCalendar = By.XPath("(//span[contains(text(),'Working')])");
        By SaveWorkHoursBtn = By.XPath("//button[@aria-label='Save']//span[contains(text(),'Save')]");
        By EditWorkingTimeOnCalendar = By.XPath("//span[contains(text(),'Edit')]");
        By EditWorkingTimeSeries = By.XPath("//span[normalize-space()='All events in the series']");
        By MondayHoursModified = By.XPath("(//span[text()='08:00 - 17:00'])[1]");

        By MoreOptionsDots = By.XPath("//i[@data-icon-name='MoreVertical']");
        By AddABreakOption = By.XPath("//span[normalize-space()='Add break']");
        By BreakIcon = By.XPath("//i[@title='Break']");
        By BreakOnCalendar = By.XPath("//span[normalize-space()='Break']");

        By ResourceTitleFilter = By.XPath("//label[normalize-space()='Resource']");
        By QueueTitleFilter = By.XPath("//label[normalize-space()='Service Sub Type (Object)']");
        By ResourceStartFilter = By.XPath("//label[normalize-space()='Start Time']");

        By ResourceTitleFilterBy = By.XPath("//span[normalize-space()='Filter by']");
        By QueueFilterBy = By.XPath("//input[@aria-label='Filter by value']");
        By ResourceTitleFilterSkip1 = By.XPath("//button[@aria-label='Skip1']");
        By StartTimeFilterCalendar = By.XPath("(//i[@data-icon-name='Calendar'])[2]");
        By StartTimeCalendarDate = By.XPath("//span[normalize-space()='16']");

        By ResourceTitleFilterApply = By.XPath("//button[@type='submit']");
        By QueueTitleFilterApply = By.XPath("//span[contains(text(),'Apply')]");
        By EqualsFilterParameter = By.XPath("//span[text()='Equals']");
        By ContainsFilterParameter = By.XPath("(//span[contains(text(),'Contains')])[1]");

        By Skip1OnTable = By.XPath("//span[normalize-space()='Skip1']");
        By SkipHireDeliveryOnTable = By.XPath("//div[contains(text(),'Skip Hire Booking - Delivery')]");
        By SkipHireCallBackOnTable = By.XPath("(//div[text()='Skip Hire Booking - Call Back'])");
        By CallBackTCOnTable = By.XPath("//span[normalize-space()='Call Back - Terms and Conditions']");
        By CaseDetailsTitle = By.XPath("//h2[normalize-space()='CASE DETAILS']");
        By BackButtonOnSkipHireForm = By.XPath("//button[@title='Go back']//span");

        By QueuesDropdown = By.XPath("//span[@data-automationid='splitbuttonprimary']//span//span[contains(text(),'Items I am working on')]");
        By SelectedQueuesOnDropdown = By.XPath("//span[contains(text(),'All Cases in Selected Queues')]");
        By SkipRecordTitle = By.XPath("//h1[@title='Skip Hire Booking']");

        By PickOnRibbon = By.XPath("//span[@aria-hidden='true']//span[contains(text(),'Pick')]");
        By PickWindowDropdown = By.XPath("//select[@aria-label='Also remove the item(s) from the Queue']");
        By PickWindowDropdownNo = By.XPath("//option[.='No']");
        By PickWindowPickBtn = By.XPath("//div[@data-id='dialogFooter']//span[contains(text(),'Pick')]");
        By NameInWorkedByColumn = By.XPath("(//span[@role='presentation'][normalize-space()='Gary Moore'])[1]");

        By PlusOnTimeline = By.XPath("//button[@title='Create a timeline record.']//span[@aria-hidden='true']");
        By StatusUpdateOption = By.XPath("//div[text()='Status Update']");
        By StatusUpdateSearchbox = By.XPath("//input[@aria-label='Status Update Message, Lookup']");
        By StatusUpdateDropdownOption = By.XPath("//li[@aria-label='Closing - Not Booked, Closing']");
        By StatusUpdateDropdownOptionBooked = By.XPath("//li[@aria-label='Closing - Booked, Closing']");

        By StatusUpdateSaveAndClose = By.XPath("//span[contains(text(),'Save and Close')]");
        By CaseStatus = By.XPath("//div[text()='Completed']");
        By RefreshButtonOnCaseDetails = By.XPath("//span[contains(text(),'Refresh')]");
        By MarkComplete = By.XPath("//span[contains(text(),'Mark Complete')]");

        By ActiveCasesSearchBox = By.XPath("//input[@placeholder='Filter by keyword']");
        By ActiveCasesOnList = By.XPath("//div[contains(text(),'CAS-15235-G3D8G1')]");
        By SkipHireBookingFormLink = By.XPath("//div[@title='Skip Hire Booking Form']");
        By SkipHireBookingLink = By.XPath("//div[@title='Skip Hire Booking']");

        By SkipLicenceNumber = By.XPath("//label[text()='Skip License Number']/following::input");
        By SaveAndClose = By.XPath("//span[contains(text(),'Save & Close')]");
        By AdditionalCaseInfoTab = By.XPath("//li[@title='Additional Case Info']");
        By ServiceDetailsTitle = By.XPath("//h2[normalize-space()='Service Details']");
        By ResourcesSearchBox = By.XPath("(//input[@placeholder='Search resources'])[2]");
        By Skip1OnScheduleSearchResult = By.XPath("//div[@title='Skip1']");

        By ScheduleBoardPopUpDismiss = By.XPath("//span[contains(text(),'Dismiss')]");
        By RefreshCollectionDate = By.XPath("//button[normalize-space()='Refresh Collection Date']");
        By CollectionDate = By.XPath("//input[@id='datepickerPickup']");
        By AmendCollectionDateBtn = By.XPath("//button[@id='btnAmendCollection']");

        //\\ My Account //\\
        By SiteHomepage = By.XPath("//img[@alt='Site Home Page']");
        By RequestSkipPrivate = By.XPath("//a[.='Request to hire a skip sited on private land']");
        By RequestSkipPublic = By.XPath("//a[.='Request to hire a skip sited on a public road']");
        By RequestSkipPrivateFormTitle = By.XPath("//b[normalize-space()='Please note:']");
        By RequestSkipPrivateFormHeading = By.XPath("//h4[normalize-space()='Delivery address']");
        By RequestSkipPublicFormTitle = By.XPath("//h1[normalize-space()='Request to hire a skip sited on a public road']");
        By HomepageAllServicesTitle = By.XPath("//h2[normalize-space()='All Services']");
        By LoginToMyAccount = By.XPath("//input[@value='2']");
        By LoginMyAccountContinueBtn = By.XPath("//button[@type='submit']");
        By LoginMyAccountUsername = By.XPath("//input[@placeholder='Email / Username']");
        By LoginMyAccountPassword = By.XPath("//input[@placeholder='Password']");
        By LoginMyAccountLoginBtn = By.XPath("(//button[normalize-space()='Login'])[1]");
        By EditAddressBtn = By.XPath("//a[normalize-space()='Edit']");
        By SearchForAddress = By.XPath("//input[@placeholder='Search for an address']");
        By SearchForAddressBtn = By.XPath("//button[normalize-space()='Search']");
        By WakefieldOneAddressOnLst = By.XPath("//option[.='Wakefield One Burton Street Wakefield WF1 2EB']");
        By DeliveryInstructionsTxtBox = By.TagName("textarea");
        By SkipSizeDropdown = By.XPath("//option[.='Choose...']");
        By SkipSizeDropdownMidi = By.XPath("//option[contains(.,'Midi')]");
        By SkipSizeDropdownMaxi = By.XPath("//option[contains(.,'Maxi')]");
        By SkipDeliveryDate = By.XPath("//input[@id='deliveryDate']");
        By SkipDeliveryDateYear = By.XPath("//select[@class='ui-datepicker-year']");
        By SkipDeliveryDateYear2023 = By.XPath("//option[@value='2023']");
        By SkipDeliveryAvailableDate = By.XPath("(//td[@class=' availableDate'])[1]");
        By SkipCollectionDate = By.XPath("//input[@id='collectionDate']");
        By SkipCollectionAvailableDate = By.XPath("(//td[@class=' availableDate'])[1]");
        By TermsYesBtn = By.XPath("//input[@value='Yes']");
        By GoToPaymentsBtn = By.XPath("//input[@name='__next']");
        By SkipHireBookingOnPaymentPage = By.XPath("//td[normalize-space()='Skip Hire Booking']");
        By SkipPrice = By.XPath("//td[normalize-space()='£126.00']");
        By SkipPriceMaxi = By.XPath("//td[normalize-space()='£200.00']");
        By SkipPayBtn = By.XPath("//a[normalize-space()='Pay']");
        By TestPaymentSiteWarning = By.XPath("//div[contains(text(),'WARNING - This website is for internal testing')]");
        By CardNumber = By.XPath("//input[@name='cardNumber']");
        By ExpiryDate1 = By.XPath("//input[@name='expiryDate']");
        By ExpiryDate2 = By.XPath("//input[@name='expiryDate2']");
        By SecurityCode = By.XPath("//input[@name='csc']");
        By ContinuePaymentBtn = By.XPath("//input[@name='_eventId_continue']");
        By CardholderName = By.XPath("//input[@name='cardholderName']");
        By PaymentConfirmationTitle = By.XPath("//h3[normalize-space()='Payment Confirmation Page']");
        By MakePaymentBtn = By.XPath("//input[@name='_eventId_payment']");
        By PaymentPasswordBox = By.XPath("//input[@name='password']");
        By ContinuePaymentBtn3DSPage = By.XPath("//input[@id='Continue']");
        By PaymentSuccessMsg = By.XPath("//h5[normalize-space()='Successful payment']");
        By CaseReferenceNumber = By.XPath("//p[contains(text(),'Your case reference is:')]");
        By SkipHireBookingOnCaseLst = By.XPath("//span[normalize-space()='Skip Hire Booking']");
        By PaymentStatusComplete = By.XPath("//select[@title='Complete']");
        By SkipBookingsQueue = By.XPath("(//div[@aria-label='Skip Bookings'])[1]");
        By SkipBookingsQueueEmpty = By.XPath("(//input[@value='---'])[2]");
        By SkipBookingsQueueBDDefault = By.XPath("(//div[@title='Business Development - Default'])[1]");
        By ActiveCasesTitle = By.XPath("//span[@data-automationid='splitbuttonprimary']//span//span[contains(text(),'Active Cases')]");
        By CasesOpenedLast7Days = By.XPath("//span[normalize-space()='Cases Opened in the Last 7 days']");
        By PaymentStatusIncomplete = By.XPath("//select[@title='Incomplete']");
        By PaymentStatusCancelled = By.XPath("//select[@title='Cancelled']");
        By PublicSkipSubmitBtn = By.XPath("//input[@name='__next']");
        By ServiceSubTypeCallBack = By.XPath("//input[@title='Skip Hire Booking - Call Back']");
        By SLATimer = By.CssSelector("[title='Time remaining to complete the action']");
        By CookieBanner = By.XPath("//button[@id='consent']");
        By CancelPaymentsBtn = By.XPath("//a[normalize-space()='Cancel']");
        By ConfirmCancelPaymentsBtn = By.XPath("//button[normalize-space()='Yes']");


        [ThreadStatic]
        IWebDriver driver;
        WebDriverWait wait;

        public SkipHire(IWebDriver driver)
        {
            this.driver = driver;
            this.wait = new WebDriverWait(driver, TimeSpan.FromSeconds(120));
        }

        public void AddWorkHoursExistingResourceDateRange()
        {
            //Verify Home dashboard is displayed
            Thread.Sleep(4000);
            wait.Until(ExpectedConditions.ElementExists((By)DashboardsLHN));
            driver.FindElement(DashboardsLHN).Click();
            wait.Until(ExpectedConditions.ElementExists((By)DashboardTitle));
            Assert.IsTrue(driver.FindElement(DashboardTitle).Displayed);
            Thread.Sleep(3000);
            //Click wakefield user app
            wait.Until(ExpectedConditions.ElementExists((By)WakefieldUserApp));
            driver.FindElement(WakefieldUserApp).Click();
            //Click resource scheduling
            Thread.Sleep(6000);
            driver.SwitchTo().Frame(driver.FindElement(By.Id("AppLandingPage")));
            wait.Until(ExpectedConditions.ElementExists((By)ResourceSchedulingApp));
            driver.FindElement(ResourceSchedulingApp).Click();
            Thread.Sleep(3000);
            driver.SwitchTo().DefaultContent();
            //Click resources on LHN
            wait.Until(ExpectedConditions.ElementExists((By)ResourcesLHN));
            driver.FindElement(ResourcesLHN).Click();
            Thread.Sleep(2000);
            //Select top resource on list
            wait.Until(ExpectedConditions.ElementExists((By)ResourceOnLst));
            driver.FindElement(ResourceOnLst).Click();
            Thread.Sleep(2000);
            //Click show work hours in top ribbon
            wait.Until(ExpectedConditions.ElementExists((By)ShowWorkHours));
            driver.FindElement(ShowWorkHours).Click();
            //Verify month is set to current month
            Thread.Sleep(6000);
            driver.SwitchTo().Frame(driver.FindElement(By.Id("CalendarSection")));
            var calendarMonth = driver.FindElement((By)CurrentMonthOnCalendar);
            Thread.Sleep(2000);
            string month = calendarMonth.Text;
            string monthTrim = month.Remove(month.Length - 1);
            DateTime dt = DateTime.Now;
            var dateTime = dt.ToString("MMMM yyyy");
            try
            {
                if (monthTrim == dateTime)
                {
                    Console.WriteLine("Current month is set correctly");
                    Console.WriteLine(dateTime);
                    Console.WriteLine(monthTrim);
                }
                else
                {
                    throw new Exception();
                }
            }
            catch
            {
                Console.WriteLine("Current month on calendar is not set to current month");
                Console.WriteLine(dateTime);
                Console.WriteLine(monthTrim);
                Assert.Fail();

            }
            //Select day on the calendar
            wait.Until(ExpectedConditions.ElementExists((By)Day10OnCalendar));
            driver.FindElement(Day10OnCalendar).Click();
            //Select New btn on calendar
            wait.Until(ExpectedConditions.ElementExists((By)NewWorkingHoursBtn));
            driver.FindElement(NewWorkingHoursBtn).Click();
            //Select working hours on dropdown
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)NewWorkingHoursDropdown));
            driver.FindElement(NewWorkingHoursDropdown).Click();
            //Change repeat to custom
            driver.SwitchTo().Window(driver.WindowHandles.Last()); 
            Thread.Sleep(5000);
            driver.SwitchTo().Frame(driver.FindElement(By.Id("WorkHourFormSection")));
            wait.Until(ExpectedConditions.ElementExists((By)RepeatDropdownNever));
            driver.FindElement(RepeatDropdownNever).Click();
            wait.Until(ExpectedConditions.ElementExists((By)RepeatDropdownCustom));
            driver.FindElement(RepeatDropdownCustom).Click();
            //Disable sat&sun
            wait.Until(ExpectedConditions.ElementExists((By)SundayOnWorkingHours));
            driver.FindElement(SundayOnWorkingHours).Click();
            Thread.Sleep(2000);
            driver.FindElement(SaturdayOnWorkingHours).Click();
            //Verify 2 days have been removed
            int iRowsCount = driver.FindElements(By.XPath("//html//body//div//div//div//div//table//tbody//tr")).Count;
            try
            {
                if(iRowsCount == 5)
                {
                    Console.WriteLine("5 days shown on working hours calendar");
                    Console.WriteLine(iRowsCount);
                }
                else
                {
                    throw new Exception();
                }
            }
            catch
            {
                if(iRowsCount > 5)
                {
                    Console.WriteLine("More than 5 days shown on working hours calendar");
                    Console.WriteLine(iRowsCount);
                    Assert.Fail();
                }
                else if(iRowsCount < 5)
                {
                    Console.WriteLine("Less than 5 days shown on working hours calendar");
                    Console.WriteLine(iRowsCount);
                    Assert.Fail();
                }
            }

            //Click choose an end date
            wait.Until(ExpectedConditions.ElementExists((By)ChooseEndDate));
            driver.FindElement(ChooseEndDate).Click();
            Thread.Sleep(2000);
            //Select end date from calendar
            wait.Until(ExpectedConditions.ElementExists((By)ChooseEndDateOnCalendar));
            driver.FindElement(ChooseEndDateOnCalendar).Click();
            //Verify remove end date is shown
            wait.Until(ExpectedConditions.ElementExists((By)RemoveEndDate));
            driver.FindElement(RemoveEndDate).Click();
            //Click working hours for monday
            wait.Until(ExpectedConditions.ElementExists((By)HoursOnMonday));
            driver.FindElement(HoursOnMonday).Click();
            Thread.Sleep(2000);
            //Change working hours
            wait.Until(ExpectedConditions.ElementExists((By)MondayStartTime));
            driver.FindElement(MondayStartTime).Click();
            driver.FindElement(MondayStartTime).SendKeys("07:00");
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)MondayFinishTime));
            driver.FindElement(MondayFinishTime).Click();
            driver.FindElement(MondayFinishTime).SendKeys("18:00");
            //Click apply
            driver.SwitchTo().DefaultContent();
            wait.Until(ExpectedConditions.ElementExists((By)WorkHoursApplyBtn));
            driver.FindElement(WorkHoursApplyBtn).Click();
            //Set timezone to GMT
            driver.SwitchTo().Frame(driver.FindElement(By.Id("WorkHourFormSection")));
            wait.Until(ExpectedConditions.ElementExists((By)WorkHoursTimezoneDropdown));
            driver.FindElement(WorkHoursTimezoneDropdown).Click();
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)WorkingHoursTimezoneGMT));
            driver.FindElement(WorkingHoursTimezoneGMT).Click(); 
            //Click save
            driver.SwitchTo().DefaultContent();
            wait.Until(ExpectedConditions.ElementExists((By)SaveWorkHoursBtn));
            driver.FindElement(SaveWorkHoursBtn).Click();
            //Verify working schedule is added to calendar
            Thread.Sleep(5000);
            driver.SwitchTo().Frame(driver.FindElement(By.Id("CalendarSection")));
            wait.Until(ExpectedConditions.ElementExists((By)WorkingTimeAddedToCalendar));
            Assert.IsTrue(driver.FindElement(WorkingTimeAddedToCalendar).Displayed);

        }

        public void EditWorkHoursExistingResourceThisEvent()
        {
            //Verify Home dashboard is displayed
            Thread.Sleep(5000);
            wait.Until(ExpectedConditions.ElementExists((By)DashboardsLHN));
            driver.FindElement(DashboardsLHN).Click();
            wait.Until(ExpectedConditions.ElementExists((By)DashboardTitle));
            Assert.IsTrue(driver.FindElement(DashboardTitle).Displayed);
            Thread.Sleep(5000);
            //Click wakefield user app
            wait.Until(ExpectedConditions.ElementExists((By)WakefieldUserApp));
            driver.FindElement(WakefieldUserApp).Click();
            //Click resource scheduling
            Thread.Sleep(5000);
            driver.SwitchTo().Frame(driver.FindElement(By.Id("AppLandingPage")));
            Thread.Sleep(5000);
            wait.Until(ExpectedConditions.ElementExists((By)ResourceSchedulingApp));
            driver.FindElement(ResourceSchedulingApp).Click();
            Thread.Sleep(3000);
            driver.SwitchTo().DefaultContent();
            //Click resources on LHN
            wait.Until(ExpectedConditions.ElementExists((By)ResourcesLHN));
            driver.FindElement(ResourcesLHN).Click();
            Thread.Sleep(2000);
            //Select top resource on list
            wait.Until(ExpectedConditions.ElementExists((By)ResourceOnLst));
            driver.FindElement(ResourceOnLst).Click();
            Thread.Sleep(2000);
            //Click show work hours in top ribbon
            wait.Until(ExpectedConditions.ElementExists((By)ShowWorkHours));
            driver.FindElement(ShowWorkHours).Click();
            //Verify month is set to current month
            Thread.Sleep(5000);
            driver.SwitchTo().Frame(driver.FindElement(By.Id("CalendarSection")));
            var calendarMonth = driver.FindElement((By)CurrentMonthOnCalendar);
            Thread.Sleep(2000);
            string month = calendarMonth.Text;
            string monthTrim = month.Remove(month.Length - 1);
            DateTime dt = DateTime.Now;
            var dateTime = dt.ToString("MMMM yyyy");
            try
            {
                if (monthTrim == dateTime)
                {
                    Console.WriteLine("Current month is set correctly");
                    Console.WriteLine(dateTime);
                    Console.WriteLine(monthTrim);
                }
                else
                {
                    throw new Exception();
                }
            }
            catch
            {
                Console.WriteLine("Current month on calendar is not set to current month");
                Console.WriteLine(dateTime);
                Console.WriteLine(monthTrim);
                Assert.Fail();

            }
            //Click working hours on calendar
            Thread.Sleep(5000);
            wait.Until(ExpectedConditions.ElementExists((By)WorkingTimeAddedToCalendar));
            driver.FindElement(WorkingTimeAddedToCalendar).Click();
            Thread.Sleep(2000);
            driver.FindElement(WorkingTimeAddedToCalendar).Click();
            //Edit working hours
            wait.Until(ExpectedConditions.ElementExists((By)EditWorkingTimeOnCalendar));
            driver.FindElement(EditWorkingTimeOnCalendar).Click();
            //Change repeat to custom
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            Thread.Sleep(5000);
            driver.SwitchTo().Frame(driver.FindElement(By.Id("WorkHourFormSection")));
            wait.Until(ExpectedConditions.ElementExists((By)RepeatDropdownNever));
            driver.FindElement(RepeatDropdownNever).Click();
            wait.Until(ExpectedConditions.ElementExists((By)RepeatDropdownCustom));
            driver.FindElement(RepeatDropdownCustom).Click();
            //Disable sun
            wait.Until(ExpectedConditions.ElementExists((By)SundayOnWorkingHours));
            driver.FindElement(SundayOnWorkingHours).Click();
            Thread.Sleep(2000);
            //Click working hours for monday
            wait.Until(ExpectedConditions.ElementExists((By)HoursOnMonday));
            driver.FindElement(HoursOnMonday).Click();
            Thread.Sleep(2000);
            //Change working hours
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)MondayStartTime));
            driver.FindElement(MondayStartTime).Click();
            driver.FindElement(MondayStartTime).SendKeys("08:00");
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)MondayFinishTime));
            driver.FindElement(MondayFinishTime).Click();
            driver.FindElement(MondayFinishTime).SendKeys("17:00");
            //Click apply
            driver.SwitchTo().DefaultContent();
            wait.Until(ExpectedConditions.ElementExists((By)WorkHoursApplyBtn));
            driver.FindElement(WorkHoursApplyBtn).Click();
            //Verify monday hours changed to 08:00-17:00
            driver.SwitchTo().Frame(driver.FindElement(By.Id("WorkHourFormSection")));
            wait.Until(ExpectedConditions.ElementExists((By)MondayHoursModified));
            Assert.IsTrue(driver.FindElement(MondayHoursModified).Displayed);
            //Click save
            driver.SwitchTo().DefaultContent();
            wait.Until(ExpectedConditions.ElementExists((By)SaveWorkHoursBtn));
            driver.FindElement(SaveWorkHoursBtn).Click();
        }

        public void AddWorkHoursWithBreak()
        {
            //Verify Home dashboard is displayed
            Thread.Sleep(4000);
            wait.Until(ExpectedConditions.ElementExists((By)DashboardsLHN));
            driver.FindElement(DashboardsLHN).Click();
            wait.Until(ExpectedConditions.ElementExists((By)DashboardTitle));
            Assert.IsTrue(driver.FindElement(DashboardTitle).Displayed);
            Thread.Sleep(3000);
            //Click wakefield user app
            wait.Until(ExpectedConditions.ElementExists((By)WakefieldUserApp));
            driver.FindElement(WakefieldUserApp).Click();
            //Click resource scheduling
            Thread.Sleep(6000);
            driver.SwitchTo().Frame(driver.FindElement(By.Id("AppLandingPage")));
            wait.Until(ExpectedConditions.ElementExists((By)ResourceSchedulingApp));
            driver.FindElement(ResourceSchedulingApp).Click();
            Thread.Sleep(3000);
            driver.SwitchTo().DefaultContent();
            //Click resources on LHN
            wait.Until(ExpectedConditions.ElementExists((By)ResourcesLHN));
            driver.FindElement(ResourcesLHN).Click();
            Thread.Sleep(2000);
            //Select top resource on list
            wait.Until(ExpectedConditions.ElementExists((By)ResourceOnLst));
            driver.FindElement(ResourceOnLst).Click();
            Thread.Sleep(2000);
            //Click show work hours in top ribbon
            wait.Until(ExpectedConditions.ElementExists((By)ShowWorkHours));
            driver.FindElement(ShowWorkHours).Click();
            //Verify month is set to current month
            Thread.Sleep(6000);
            driver.SwitchTo().Frame(driver.FindElement(By.Id("CalendarSection")));
            var calendarMonth = driver.FindElement((By)CurrentMonthOnCalendar);
            Thread.Sleep(2000);
            string month = calendarMonth.Text;
            string monthTrim = month.Remove(month.Length - 1);
            DateTime dt = DateTime.Now;
            var dateTime = dt.ToString("MMMM yyyy");
            try
            {
                if (monthTrim == dateTime)
                {
                    Console.WriteLine("Current month is set correctly");
                    Console.WriteLine(dateTime);
                    Console.WriteLine(monthTrim);
                }
                else
                {
                    throw new Exception();
                }
            }
            catch
            {
                Console.WriteLine("Current month on calendar is not set to current month");
                Console.WriteLine(dateTime);
                Console.WriteLine(monthTrim);
                Assert.Fail();

            }
            //Select day on the calendar
            wait.Until(ExpectedConditions.ElementExists((By)Day10OnCalendar));
            driver.FindElement(Day10OnCalendar).Click();
            //Select New btn on calendar
            wait.Until(ExpectedConditions.ElementExists((By)NewWorkingHoursBtn));
            driver.FindElement(NewWorkingHoursBtn).Click();
            //Select working hours on dropdown
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)NewWorkingHoursDropdown));
            driver.FindElement(NewWorkingHoursDropdown).Click();
            //Change working hours
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            Thread.Sleep(5000);
            driver.SwitchTo().Frame(driver.FindElement(By.Id("WorkHourFormSection")));
            wait.Until(ExpectedConditions.ElementExists((By)NewStartTime));
            driver.FindElement(NewStartTime).Click();
            driver.FindElement(NewStartTime).SendKeys("07:00");
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)NewFinishTime));
            driver.FindElement(NewFinishTime).Click();
            driver.FindElement(NewFinishTime).SendKeys("18:00");
            //Add a break
            wait.Until(ExpectedConditions.ElementExists((By)MoreOptionsDots));
            driver.FindElement(MoreOptionsDots).Click();
            wait.Until(ExpectedConditions.ElementExists((By)AddABreakOption));
            driver.FindElement(AddABreakOption).Click();
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)BreakIcon));
            Assert.IsTrue(driver.FindElement(BreakIcon).Displayed);
            //Click save
            driver.SwitchTo().DefaultContent();
            wait.Until(ExpectedConditions.ElementExists((By)SaveWorkHoursBtn));
            driver.FindElement(SaveWorkHoursBtn).Click();
            Thread.Sleep(2000);
            //Verify Break is added
            driver.SwitchTo().Frame(driver.FindElement(By.Id("CalendarSection")));
            wait.Until(ExpectedConditions.ElementExists((By)BreakOnCalendar));
            Assert.IsTrue(driver.FindElement(BreakOnCalendar).Displayed);


        }

        public void ViewBookingsForResourceAndDate()
        {
            //Verify Home dashboard is displayed
            Thread.Sleep(4000);
            wait.Until(ExpectedConditions.ElementExists((By)DashboardsLHN));
            driver.FindElement(DashboardsLHN).Click();
            wait.Until(ExpectedConditions.ElementExists((By)DashboardTitle));
            Assert.IsTrue(driver.FindElement(DashboardTitle).Displayed);
            Thread.Sleep(3000);
            //Click wakefield user app
            wait.Until(ExpectedConditions.ElementExists((By)WakefieldUserApp));
            driver.FindElement(WakefieldUserApp).Click();
            //Click resource scheduling
            Thread.Sleep(6000);
            driver.SwitchTo().Frame(driver.FindElement(By.Id("AppLandingPage")));
            wait.Until(ExpectedConditions.ElementExists((By)ResourceSchedulingApp));
            driver.FindElement(ResourceSchedulingApp).Click();
            Thread.Sleep(3000);
            driver.SwitchTo().DefaultContent();
            //Click Bookins on LHN
            wait.Until(ExpectedConditions.ElementExists((By)BookingsLHN));
            driver.FindElement(BookingsLHN).Click();
            Thread.Sleep(2000);
            //Filter resource title
            wait.Until(ExpectedConditions.ElementExists((By)ResourceTitleFilter));
            driver.FindElement(ResourceTitleFilter).Click();
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)ResourceTitleFilterBy));
            driver.FindElement(ResourceTitleFilterBy).Click();
            Thread.Sleep(2000);
            //Click skip1
            wait.Until(ExpectedConditions.ElementExists((By)ResourceTitleFilterSkip1));
            driver.FindElement(ResourceTitleFilterSkip1).Click();
            //Click apply
            wait.Until(ExpectedConditions.ElementExists((By)ResourceTitleFilterApply));
            driver.FindElement(ResourceTitleFilterApply).Click();
            Thread.Sleep(2000);
            //Verify skip1 is displayed
            wait.Until(ExpectedConditions.ElementExists((By)Skip1OnTable));
            Assert.IsTrue(driver.FindElement(Skip1OnTable).Displayed);
            //Filter start time
            wait.Until(ExpectedConditions.ElementExists((By)ResourceStartFilter));
            driver.FindElement(ResourceStartFilter).Click();
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)ResourceTitleFilterBy));
            driver.FindElement(ResourceTitleFilterBy).Click();
            //Select calendar
            wait.Until(ExpectedConditions.ElementExists((By)StartTimeFilterCalendar));
            driver.FindElement(StartTimeFilterCalendar).Click();
            Thread.Sleep(2000);
            //Select start date
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)StartTimeCalendarDate));
            driver.FindElement(StartTimeCalendarDate).Click();
            Thread.Sleep(2000);
            //Click apply
            wait.Until(ExpectedConditions.ElementExists((By)ResourceTitleFilterApply));
            driver.FindElement(ResourceTitleFilterApply).Click();
            //Verify skip1 is displayed
            wait.Until(ExpectedConditions.ElementExists((By)Skip1OnTable));
            Assert.IsTrue(driver.FindElement(Skip1OnTable).Displayed);


        }

        public void PrivateBookingsQueue()
        {
            //Verify Home dashboard is displayed
            Thread.Sleep(4000);
            wait.Until(ExpectedConditions.ElementExists((By)DashboardsLHN));
            driver.FindElement(DashboardsLHN).Click();
            wait.Until(ExpectedConditions.ElementExists((By)DashboardTitle));
            Assert.IsTrue(driver.FindElement(DashboardTitle).Displayed);
            Thread.Sleep(3000);
            //Click queues on LHN
            wait.Until(ExpectedConditions.ElementExists((By)QueuesLHN));
            driver.FindElement(QueuesLHN).Click();
            //Click queues dropdown
            Thread.Sleep(6000);
            wait.Until(ExpectedConditions.ElementExists((By)QueuesDropdown));
            driver.FindElement(QueuesDropdown).Click();
            Thread.Sleep(2000);
            //Select all cases in selected queues
            wait.Until(ExpectedConditions.ElementExists((By)SelectedQueuesOnDropdown));
            driver.FindElement(SelectedQueuesOnDropdown).Click();
            Thread.Sleep(2000);
            //Filter resource title
            wait.Until(ExpectedConditions.ElementExists((By)QueueTitleFilter));
            driver.FindElement(QueueTitleFilter).Click();
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)ResourceTitleFilterBy));
            driver.FindElement(ResourceTitleFilterBy).Click();
            Thread.Sleep(2000);
            //Enter service subtype in box
            wait.Until(ExpectedConditions.ElementExists((By)QueueFilterBy));
            driver.FindElement(QueueFilterBy).Click();
            driver.FindElement(QueueFilterBy).SendKeys("Skip Hire Booking - Delivery");
            Thread.Sleep(5000);
            //Click apply
            wait.Until(ExpectedConditions.ElementExists((By)QueueTitleFilterApply));
            driver.FindElement(QueueTitleFilterApply).Click();
            Thread.Sleep(2000);
            //Verify correct sub service is displayed and click it
            wait.Until(ExpectedConditions.ElementExists((By)SkipHireDeliveryOnTable));
            Assert.IsTrue(driver.FindElement(SkipHireDeliveryOnTable).Displayed);
            Actions act = new Actions(driver);
            WebElement ele = (WebElement)driver.FindElement(SkipHireDeliveryOnTable);
            act.DoubleClick(ele).Perform();
            Thread.Sleep(3000);
            //Verify record opens
            wait.Until(ExpectedConditions.ElementExists((By)SkipRecordTitle));
            Assert.IsTrue(driver.FindElement(SkipRecordTitle).Displayed);

        }

        public void LicenceCallBackQueue()
        {
            //Verify Home dashboard is displayed
            Thread.Sleep(4000);
            wait.Until(ExpectedConditions.ElementExists((By)DashboardsLHN));
            driver.FindElement(DashboardsLHN).Click();
            wait.Until(ExpectedConditions.ElementExists((By)DashboardTitle));
            Assert.IsTrue(driver.FindElement(DashboardTitle).Displayed);
            Thread.Sleep(3000);
            //Click queues on LHN
            wait.Until(ExpectedConditions.ElementExists((By)QueuesLHN));
            driver.FindElement(QueuesLHN).Click();
            //Click queues dropdown
            Thread.Sleep(6000);
            wait.Until(ExpectedConditions.ElementExists((By)QueuesDropdown));
            driver.FindElement(QueuesDropdown).Click();
            Thread.Sleep(2000);
            //Select all cases in selected queues
            wait.Until(ExpectedConditions.ElementExists((By)SelectedQueuesOnDropdown));
            driver.FindElement(SelectedQueuesOnDropdown).Click();
            Thread.Sleep(2000);
            //Filter resource title
            wait.Until(ExpectedConditions.ElementExists((By)QueueTitleFilter));
            driver.FindElement(QueueTitleFilter).Click();
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)ResourceTitleFilterBy));
            driver.FindElement(ResourceTitleFilterBy).Click();
            Thread.Sleep(2000);
            //Change search parameter to contains
            wait.Until(ExpectedConditions.ElementExists((By)EqualsFilterParameter));
            driver.FindElement(EqualsFilterParameter).Click();
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)ContainsFilterParameter));
            driver.FindElement(ContainsFilterParameter).Click();
            Thread.Sleep(2000);
            //Enter service subtype in box
            wait.Until(ExpectedConditions.ElementExists((By)QueueFilterBy));
            driver.FindElement(QueueFilterBy).Click();
            driver.FindElement(QueueFilterBy).SendKeys("Skip Hire Booking - Call Back");
            Thread.Sleep(5000);
            //Click apply
            wait.Until(ExpectedConditions.ElementExists((By)QueueTitleFilterApply));
            driver.FindElement(QueueTitleFilterApply).Click();
            Thread.Sleep(2000);
            //Verify correct sub service is displayed and click it
            wait.Until(ExpectedConditions.ElementExists((By)SkipHireCallBackOnTable));
            Assert.IsTrue(driver.FindElement(SkipHireCallBackOnTable).Displayed);
            //Click top record
            Thread.Sleep(3000);
            driver.FindElement(SkipHireCallBackOnTable).Click();
            //Click pick in the ribbon
            wait.Until(ExpectedConditions.ElementExists((By)PickOnRibbon));
            driver.FindElement(PickOnRibbon).Click();
            Thread.Sleep(2000);
            //select no on remove items from queue
            wait.Until(ExpectedConditions.ElementExists((By)PickWindowDropdown));
            driver.FindElement(PickWindowDropdown).Click();
            Thread.Sleep(2000);
            driver.FindElement(PickWindowDropdownNo).Click();
            //Click pick
            wait.Until(ExpectedConditions.ElementExists((By)PickWindowPickBtn));
            driver.FindElement(PickWindowPickBtn).Click();
            Thread.Sleep(3000);
            //Verify name is now shown in worked by column
            wait.Until(ExpectedConditions.ElementExists((By)NameInWorkedByColumn));
            Assert.IsTrue(driver.FindElement(NameInWorkedByColumn).Displayed);




        }

        public void LicenceCallBackReject()
        {
            //Verify Home dashboard is displayed
            Thread.Sleep(4000);
            wait.Until(ExpectedConditions.ElementExists((By)DashboardsLHN));
            driver.FindElement(DashboardsLHN).Click();
            wait.Until(ExpectedConditions.ElementExists((By)DashboardTitle));
            Assert.IsTrue(driver.FindElement(DashboardTitle).Displayed);
            Thread.Sleep(3000);
            //Click queues on LHN
            wait.Until(ExpectedConditions.ElementExists((By)QueuesLHN));
            driver.FindElement(QueuesLHN).Click();
            //Click queues dropdown
            Thread.Sleep(6000);
            wait.Until(ExpectedConditions.ElementExists((By)QueuesDropdown));
            driver.FindElement(QueuesDropdown).Click();
            Thread.Sleep(2000);
            //Select all cases in selected queues
            wait.Until(ExpectedConditions.ElementExists((By)SelectedQueuesOnDropdown));
            driver.FindElement(SelectedQueuesOnDropdown).Click();
            Thread.Sleep(2000);
            //Filter resource title
            wait.Until(ExpectedConditions.ElementExists((By)QueueTitleFilter));
            driver.FindElement(QueueTitleFilter).Click();
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)ResourceTitleFilterBy));
            driver.FindElement(ResourceTitleFilterBy).Click();
            Thread.Sleep(2000);
            //Change search parameter to contains
            wait.Until(ExpectedConditions.ElementExists((By)EqualsFilterParameter));
            driver.FindElement(EqualsFilterParameter).Click();
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)ContainsFilterParameter));
            driver.FindElement(ContainsFilterParameter).Click();
            Thread.Sleep(2000);
            //Enter service subtype in box
            wait.Until(ExpectedConditions.ElementExists((By)QueueFilterBy));
            driver.FindElement(QueueFilterBy).Click();
            driver.FindElement(QueueFilterBy).SendKeys("Skip Hire Booking - Call Back");
            Thread.Sleep(5000);
            //Click apply
            wait.Until(ExpectedConditions.ElementExists((By)QueueTitleFilterApply));
            driver.FindElement(QueueTitleFilterApply).Click();
            Thread.Sleep(2000);
            //Verify correct sub service is displayed and click it
            wait.Until(ExpectedConditions.ElementExists((By)SkipHireCallBackOnTable));
            Assert.IsTrue(driver.FindElement(SkipHireCallBackOnTable).Displayed);
            //Click top record
            wait.Until(ExpectedConditions.ElementExists((By)SkipHireCallBackOnTable));
            Actions act = new Actions(driver);
            WebElement ele = (WebElement)driver.FindElement(SkipHireCallBackOnTable);
            act.DoubleClick(ele).Perform();
            Thread.Sleep(3000);
            //Verify record opens
            wait.Until(ExpectedConditions.ElementExists((By)SkipRecordTitle));
            Assert.IsTrue(driver.FindElement(SkipRecordTitle).Displayed);
            //Click plus on timeline
            wait.Until(ExpectedConditions.ElementExists((By)PlusOnTimeline));
            driver.FindElement(PlusOnTimeline).Click();
            Thread.Sleep(2000);
            //click status update
            wait.Until(ExpectedConditions.ElementExists((By)StatusUpdateOption));
            driver.FindElement(StatusUpdateOption).Click();
            Thread.Sleep(2000);
            //click status update searchbox
            wait.Until(ExpectedConditions.ElementExists((By)StatusUpdateSearchbox));
            driver.FindElement(StatusUpdateSearchbox).Click();
            Thread.Sleep(2000);
            //enter closing - not booked
            driver.FindElement(StatusUpdateSearchbox).SendKeys("Closing - Not Booked");
            Thread.Sleep(2000);
            //select option
            wait.Until(ExpectedConditions.ElementExists((By)StatusUpdateDropdownOption));
            driver.FindElement(StatusUpdateDropdownOption).Click();
            Thread.Sleep(2000);
            //select save and close
            wait.Until(ExpectedConditions.ElementExists((By)StatusUpdateSaveAndClose));
            driver.FindElement(StatusUpdateSaveAndClose).Click();
            Thread.Sleep(2000);
            //verify case is closed
            var Status = 0;
            try
            {
                if (driver.FindElements(CaseStatus).Count() != 0)
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
                    if (driver.FindElements(CaseStatus).Count() != 0)
                    {
                        break;
                    }
                    else if (Status == 10)
                    {
                        Console.WriteLine("Job status not updated from in progress");
                        Assert.Fail();
                    }
                } while (driver.FindElements(CaseStatus).Count() == 0);
            }
        }

        public void LicenceCallBackAccept()
        {
            //Verify Home dashboard is displayed
            Thread.Sleep(4000);
            wait.Until(ExpectedConditions.ElementExists((By)DashboardsLHN));
            driver.FindElement(DashboardsLHN).Click();
            wait.Until(ExpectedConditions.ElementExists((By)DashboardTitle));
            Assert.IsTrue(driver.FindElement(DashboardTitle).Displayed);
            Thread.Sleep(3000);
            //Click queues on LHN
            wait.Until(ExpectedConditions.ElementExists((By)QueuesLHN));
            driver.FindElement(QueuesLHN).Click();
            //Click queues dropdown
            Thread.Sleep(6000);
            wait.Until(ExpectedConditions.ElementExists((By)QueuesDropdown));
            driver.FindElement(QueuesDropdown).Click();
            Thread.Sleep(2000);
            //Select all cases in selected queues
            wait.Until(ExpectedConditions.ElementExists((By)SelectedQueuesOnDropdown));
            driver.FindElement(SelectedQueuesOnDropdown).Click();
            Thread.Sleep(2000);
            //Filter resource title
            wait.Until(ExpectedConditions.ElementExists((By)QueueTitleFilter));
            driver.FindElement(QueueTitleFilter).Click();
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)ResourceTitleFilterBy));
            driver.FindElement(ResourceTitleFilterBy).Click();
            Thread.Sleep(2000);
            //Change search parameter to contains
            wait.Until(ExpectedConditions.ElementExists((By)EqualsFilterParameter));
            driver.FindElement(EqualsFilterParameter).Click();
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)ContainsFilterParameter));
            driver.FindElement(ContainsFilterParameter).Click();
            Thread.Sleep(2000);
            //Enter service subtype in box
            wait.Until(ExpectedConditions.ElementExists((By)QueueFilterBy));
            driver.FindElement(QueueFilterBy).Click();
            driver.FindElement(QueueFilterBy).SendKeys("Skip Hire Booking - Call Back");
            Thread.Sleep(5000);
            //Click apply
            wait.Until(ExpectedConditions.ElementExists((By)QueueTitleFilterApply));
            driver.FindElement(QueueTitleFilterApply).Click();
            Thread.Sleep(2000);
            //Verify correct sub service is displayed and click it
            wait.Until(ExpectedConditions.ElementExists((By)SkipHireCallBackOnTable));
            Assert.IsTrue(driver.FindElement(SkipHireCallBackOnTable).Displayed);
            //Click top record
            wait.Until(ExpectedConditions.ElementExists((By)SkipHireCallBackOnTable));
            Actions act = new Actions(driver);
            WebElement ele = (WebElement)driver.FindElement(SkipHireCallBackOnTable);
            act.DoubleClick(ele).Perform();
            Thread.Sleep(3000);
            //Verify record opens
            wait.Until(ExpectedConditions.ElementExists((By)SkipRecordTitle));
            Assert.IsTrue(driver.FindElement(SkipRecordTitle).Displayed);
            //Click plus on timeline
            wait.Until(ExpectedConditions.ElementExists((By)PlusOnTimeline));
            driver.FindElement(PlusOnTimeline).Click();
            Thread.Sleep(2000);
            //click status update
            wait.Until(ExpectedConditions.ElementExists((By)StatusUpdateOption));
            driver.FindElement(StatusUpdateOption).Click();
            Thread.Sleep(2000);
            //click status update searchbox
            wait.Until(ExpectedConditions.ElementExists((By)StatusUpdateSearchbox));
            driver.FindElement(StatusUpdateSearchbox).Click();
            Thread.Sleep(2000);
            //enter closing - booked
            driver.FindElement(StatusUpdateSearchbox).SendKeys("Closing - Booked");
            Thread.Sleep(2000);
            //select option
            wait.Until(ExpectedConditions.ElementExists((By)StatusUpdateDropdownOptionBooked));
            driver.FindElement(StatusUpdateDropdownOptionBooked).Click();
            Thread.Sleep(2000);
            //select save and close
            wait.Until(ExpectedConditions.ElementExists((By)StatusUpdateSaveAndClose));
            driver.FindElement(StatusUpdateSaveAndClose).Click();
            Thread.Sleep(2000);
            //verify case is closed
            var Status = 0;
            try
            {
                if (driver.FindElements(CaseStatus).Count() != 0)
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
                    if (driver.FindElements(CaseStatus).Count() != 0)
                    {
                        break;
                    }
                    else if (Status == 10)
                    {
                        Console.WriteLine("Job status not updated from in progress");
                        Assert.Fail();
                    }
                } while (driver.FindElements(CaseStatus).Count() == 0);
            }
        }

        public void AddLicenceToBooking()
        {
            //Verify Home dashboard is displayed
            Thread.Sleep(4000);
            wait.Until(ExpectedConditions.ElementExists((By)DashboardsLHN));
            driver.FindElement(DashboardsLHN).Click();
            wait.Until(ExpectedConditions.ElementExists((By)DashboardTitle));
            Assert.IsTrue(driver.FindElement(DashboardTitle).Displayed);
            Thread.Sleep(3000);
            //Click cases on LHN
            wait.Until(ExpectedConditions.ElementExists((By)CasesLHN));
            driver.FindElement(CasesLHN).Click();
            //Enter case number in searchbox
            Thread.Sleep(6000);
            wait.Until(ExpectedConditions.ElementExists((By)ActiveCasesSearchBox));
            driver.FindElement(ActiveCasesSearchBox).Click();
            Thread.Sleep(2000);
            driver.FindElement(ActiveCasesSearchBox).SendKeys("CAS-15235");
            driver.FindElement(ActiveCasesSearchBox).SendKeys(Keys.Enter);
            Thread.Sleep(5000);
            //Click case on the list
            wait.Until(ExpectedConditions.ElementExists((By)ActiveCasesOnList));
            driver.FindElement(ActiveCasesOnList).Click();
            Actions act = new Actions(driver);
            WebElement ele = (WebElement)driver.FindElement(ActiveCasesOnList);
            act.DoubleClick(ele).Perform();
            Thread.Sleep(5000);
            //Select skip hire booking form link
            wait.Until(ExpectedConditions.ElementExists((By)SkipHireBookingFormLink));
            driver.FindElement(SkipHireBookingFormLink).Click();
            Thread.Sleep(3000);
            //Enter licence number 
            Thread.Sleep(2000);
            driver.FindElement(ServiceDetailsTitle).Click();
            Actions actions = new Actions(driver);
            actions.SendKeys(Keys.PageDown).Build().Perform();
            Thread.Sleep(1000);
            actions.SendKeys(Keys.PageDown).Build().Perform();
            Thread.Sleep(1000);
            actions.SendKeys(Keys.PageDown).Build().Perform();
            wait.Until(ExpectedConditions.ElementExists((By)SkipLicenceNumber));
            driver.FindElement(SkipLicenceNumber).Click();
            driver.FindElement(SkipLicenceNumber).SendKeys("12345");
            //Select save and close
            wait.Until(ExpectedConditions.ElementExists((By)SaveAndClose));
            driver.FindElement(SaveAndClose).Click();
            //Click additional case info
            wait.Until(ExpectedConditions.ElementExists((By)AdditionalCaseInfoTab));
            driver.FindElement(AdditionalCaseInfoTab).Click();
            //// Need to add bartec integration //////

        }

        public void ViewBookingsScheduleBoard()
        {
            //Verify Home dashboard is displayed
            Thread.Sleep(4000);
            wait.Until(ExpectedConditions.ElementExists((By)DashboardsLHN));
            driver.FindElement(DashboardsLHN).Click();
            wait.Until(ExpectedConditions.ElementExists((By)DashboardTitle));
            Assert.IsTrue(driver.FindElement(DashboardTitle).Displayed);
            Thread.Sleep(3000);
            //Click wakefield user app
            wait.Until(ExpectedConditions.ElementExists((By)WakefieldUserApp));
            driver.FindElement(WakefieldUserApp).Click();
            //Click resource scheduling
            Thread.Sleep(6000);
            driver.SwitchTo().Frame(driver.FindElement(By.Id("AppLandingPage")));
            wait.Until(ExpectedConditions.ElementExists((By)ResourceSchedulingApp));
            driver.FindElement(ResourceSchedulingApp).Click();
            Thread.Sleep(3000);
            driver.SwitchTo().DefaultContent();
            //Click schedule board on LHN
            wait.Until(ExpectedConditions.ElementExists((By)ScheduleBoardLHN));
            driver.FindElement(ScheduleBoardLHN).Click();
            Thread.Sleep(6000);
            //Dismiss pop up if displayed
            try
            {
                driver.SwitchTo().Window(driver.WindowHandles.Last());

                if (driver.FindElement(ScheduleBoardPopUpDismiss).Displayed)
                {
                    driver.FindElement(ScheduleBoardPopUpDismiss).Click();
                    Thread.Sleep(2000);
                }
            }
            catch
            {
                Console.WriteLine("No pop up displayed");
            }

            //Click search resources box
            driver.SwitchTo().Frame(driver.FindElement(By.Id("ScheduleBoardFrame")));
            wait.Until(ExpectedConditions.ElementExists((By)ResourcesSearchBox));
            driver.FindElement(ResourcesSearchBox).Click();
            Thread.Sleep(1000);
            driver.FindElement(ResourcesSearchBox).SendKeys("Skip");
            driver.FindElement(ResourcesSearchBox).SendKeys(Keys.Enter);
            //Verify skip 1 resource is displayed
            wait.Until(ExpectedConditions.ElementExists((By)Skip1OnScheduleSearchResult));
            Assert.IsTrue(driver.FindElement(Skip1OnScheduleSearchResult).Displayed);

        } //Need clarification on test steps//

        public void CollectionDateChange()
        {
            //Verify Home dashboard is displayed
            Thread.Sleep(4000);
            wait.Until(ExpectedConditions.ElementExists((By)DashboardsLHN));
            driver.FindElement(DashboardsLHN).Click();
            wait.Until(ExpectedConditions.ElementExists((By)DashboardTitle));
            Assert.IsTrue(driver.FindElement(DashboardTitle).Displayed);
            Thread.Sleep(3000);
            //Click cases on LHN
            wait.Until(ExpectedConditions.ElementExists((By)CasesLHN));
            driver.FindElement(CasesLHN).Click();
            //Enter case number in searchbox
            Thread.Sleep(6000);
            wait.Until(ExpectedConditions.ElementExists((By)ActiveCasesSearchBox));
            driver.FindElement(ActiveCasesSearchBox).Click();
            Thread.Sleep(2000);
            driver.FindElement(ActiveCasesSearchBox).SendKeys("CAS-15235");
            driver.FindElement(ActiveCasesSearchBox).SendKeys(Keys.Enter);
            Thread.Sleep(5000);
            //Click case on the list
            wait.Until(ExpectedConditions.ElementExists((By)ActiveCasesOnList));
            driver.FindElement(ActiveCasesOnList).Click();
            Actions act = new Actions(driver);
            WebElement ele = (WebElement)driver.FindElement(ActiveCasesOnList);
            act.DoubleClick(ele).Perform();
            Thread.Sleep(5000);
            //Select skip hire booking form link
            wait.Until(ExpectedConditions.ElementExists((By)SkipHireBookingFormLink));
            driver.FindElement(SkipHireBookingFormLink).Click();
            Thread.Sleep(3000);
            //Refresh collection dates 
            Thread.Sleep(2000);
            driver.FindElement(ServiceDetailsTitle).Click();
            Actions actions = new Actions(driver);
            actions.SendKeys(Keys.PageDown).Build().Perform();
            Thread.Sleep(1000);
            actions.SendKeys(Keys.PageDown).Build().Perform();
            wait.Until(ExpectedConditions.ElementExists((By)RefreshCollectionDate));
            driver.FindElement(RefreshCollectionDate).Click();
            //Enter new pickup date
            driver.SwitchTo().Frame(driver.FindElement(By.Id("WebResource_skipbookingappointments")));
            wait.Until(ExpectedConditions.ElementExists((By)CollectionDate));
            driver.FindElement(CollectionDate).Click();
            driver.FindElement(CollectionDate).SendKeys("20/01/2025");
            driver.FindElement(CollectionDate).SendKeys(Keys.Enter);
            //Click amend collection date
            wait.Until(ExpectedConditions.ElementExists((By)AmendCollectionDateBtn));
            driver.FindElement(AmendCollectionDateBtn).Click();
            driver.SwitchTo().DefaultContent();
            //Select save and close
            wait.Until(ExpectedConditions.ElementExists((By)SaveAndClose));
            driver.FindElement(SaveAndClose).Click();
            //Verify user is navigated back to skip hire booking form
            wait.Until(ExpectedConditions.ElementExists((By)ServiceDetailsTitle));
            driver.FindElement(ServiceDetailsTitle).Click();
        } //Need to find case that has skip delivered and collection date in future

        public void MyAccountBookMidiPrivateEast()
        {
            //Verify Home dashboard is displayed
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)SiteHomepage));
              try
              {
                  if (driver.FindElement(CookieBanner).Displayed)
                  {
                      driver.FindElement(CookieBanner).Click();
                  }
              }
              catch
              {
                  Console.WriteLine("Cookie banner not shown");
              }
            //Select request skip hire on private land
            driver.FindElement(HomepageAllServicesTitle).Click();
            Actions actions = new Actions(driver);
            actions.SendKeys(Keys.PageDown).Build().Perform();
            Thread.Sleep(1000);
            actions.SendKeys(Keys.PageDown).Build().Perform();
            wait.Until(ExpectedConditions.ElementExists((By)RequestSkipPrivate));
            driver.FindElement(RequestSkipPrivate).Click();
            Thread.Sleep(3000);
            //Verify request skip form loads
            driver.WindowHandles.Last();
            wait.Until(ExpectedConditions.ElementExists((By)RequestSkipPrivateFormTitle));
            driver.FindElement(RequestSkipPrivateFormTitle).Click();
            actions = new Actions(driver);
            actions.SendKeys(Keys.PageDown).Build().Perform();
            Thread.Sleep(1000);
            actions.SendKeys(Keys.PageDown).Build().Perform();
            //Click login to my account
            wait.Until(ExpectedConditions.ElementExists((By)LoginToMyAccount));
            driver.FindElement(LoginToMyAccount).Click();
            //Click continue
            wait.Until(ExpectedConditions.ElementExists((By)LoginMyAccountContinueBtn));
            driver.FindElement(LoginMyAccountContinueBtn).Click();
            //Enter Username
            wait.Until(ExpectedConditions.ElementExists((By)LoginMyAccountUsername));
            Actions action = new Actions(driver);
            WebElement ele = (WebElement)driver.FindElement(LoginMyAccountUsername);
            action.Click(ele).Click(ele).Click(ele).Perform();
            driver.FindElement(LoginMyAccountUsername).SendKeys(Keys.Delete);
            driver.FindElement(LoginMyAccountUsername).SendKeys("ittesting@wakefield.gov.uk");
            //Enter password
            wait.Until(ExpectedConditions.ElementExists((By)LoginMyAccountPassword));
            ele = (WebElement)driver.FindElement(LoginMyAccountPassword);
            action.Click(ele).Click(ele).Click(ele).Perform();
            driver.FindElement(LoginMyAccountPassword).SendKeys(Keys.Delete); 
            StreamReader streamReader = new StreamReader(@"C:\Users\garymoore\OneDrive - Wakefield Council\Desktop\MyAccountPassword.txt");
            string password = streamReader.ReadToEnd();
            driver.FindElement(LoginMyAccountPassword).SendKeys(password);
            //Click Login
            wait.Until(ExpectedConditions.ElementExists((By)LoginMyAccountLoginBtn));
            driver.FindElement(LoginMyAccountLoginBtn).Click();
            Thread.Sleep(3000);
            //Enter text into deliver instructions
            wait.Until(ExpectedConditions.ElementExists((By)DeliveryInstructionsTxtBox));
            driver.FindElement(DeliveryInstructionsTxtBox).Click();
            driver.FindElement(DeliveryInstructionsTxtBox).SendKeys("Please Deliver");
            //Select skip size
            wait.Until(ExpectedConditions.ElementExists((By)SkipSizeDropdown));
            driver.FindElement(SkipSizeDropdown).Click();
            wait.Until(ExpectedConditions.ElementExists((By)SkipSizeDropdownMidi));
            driver.FindElement(SkipSizeDropdownMidi).Click();
            driver.FindElement(DeliveryInstructionsTxtBox).Click();
            actions = new Actions(driver);
            actions.SendKeys(Keys.PageDown).Build().Perform();
            Thread.Sleep(10000);
            //Select delivery date
            wait.Until(ExpectedConditions.ElementExists((By)SkipDeliveryDate));
            driver.FindElement(SkipDeliveryDate).Click();
            wait.Until(ExpectedConditions.ElementExists((By)SkipDeliveryDateYear));
            driver.FindElement(SkipDeliveryDateYear).Click();
            wait.Until(ExpectedConditions.ElementExists((By)SkipDeliveryDateYear2023));
            driver.FindElement(SkipDeliveryDateYear2023).Click();
            wait.Until(ExpectedConditions.ElementExists((By)SkipDeliveryAvailableDate));
            driver.FindElement(SkipDeliveryAvailableDate).Click();
            Thread.Sleep(6000);
            //Select collection date
            wait.Until(ExpectedConditions.ElementExists((By)SkipCollectionDate));
            driver.FindElement(SkipCollectionDate).Click();
            wait.Until(ExpectedConditions.ElementExists((By)SkipCollectionAvailableDate));
            driver.FindElement(SkipCollectionAvailableDate).Click();
            //Click yes to t&c's
            wait.Until(ExpectedConditions.ElementExists((By)TermsYesBtn));
            driver.FindElement(TermsYesBtn).Click();
            //Click go to payments
            wait.Until(ExpectedConditions.ElementExists((By)GoToPaymentsBtn));
            driver.FindElement(GoToPaymentsBtn).Click();
            Thread.Sleep(3000);
            //Verify skip price is correct
            wait.Until(ExpectedConditions.ElementExists((By)SkipHireBookingOnPaymentPage));
            Assert.IsTrue(driver.FindElement(SkipPrice).Displayed);
            //Select pay button
            wait.Until(ExpectedConditions.ElementExists((By)SkipPayBtn));
            driver.FindElement(SkipPayBtn).Click();
            Thread.Sleep(3000);
            //Verify payment page loads
            wait.Until(ExpectedConditions.ElementExists((By)TestPaymentSiteWarning));
            Assert.IsTrue(driver.FindElement(TestPaymentSiteWarning).Displayed);
            Thread.Sleep(2000);
            //Enter card number
            wait.Until(ExpectedConditions.ElementExists((By)CardNumber));
            driver.FindElement(CardNumber).Click();
            driver.FindElement(CardNumber).SendKeys("4543059790016721");
            //Enter expiry date
            wait.Until(ExpectedConditions.ElementExists((By)ExpiryDate1));
            driver.FindElement(ExpiryDate1).Click();
            driver.FindElement(ExpiryDate1).SendKeys("12");
            wait.Until(ExpectedConditions.ElementExists((By)ExpiryDate2));
            driver.FindElement(ExpiryDate2).Click();
            driver.FindElement(ExpiryDate2).SendKeys("23");
            //Enter security code
            wait.Until(ExpectedConditions.ElementExists((By)SecurityCode));
            driver.FindElement(SecurityCode).Click();
            driver.FindElement(SecurityCode).SendKeys("587");
            //Click continue
            wait.Until(ExpectedConditions.ElementExists((By)ContinuePaymentBtn));
            driver.FindElement(ContinuePaymentBtn).Click();
            Thread.Sleep(2000);
            //Enter cardholder name
            wait.Until(ExpectedConditions.ElementExists((By)CardholderName));
            driver.FindElement(CardholderName).Click();
            driver.FindElement(CardholderName).SendKeys("Test");
            //Click continue
            wait.Until(ExpectedConditions.ElementExists((By)ContinuePaymentBtn));
            driver.FindElement(ContinuePaymentBtn).Click();
            Thread.Sleep(2000);
            //Verify payment confirmation page loads
            wait.Until(ExpectedConditions.ElementExists((By)PaymentConfirmationTitle));
            Assert.IsTrue(driver.FindElement(PaymentConfirmationTitle).Displayed);
            //Click make payment
            wait.Until(ExpectedConditions.ElementExists((By)MakePaymentBtn));
            driver.FindElement(MakePaymentBtn).Click();
            Thread.Sleep(2000);
            //Enter password
            driver.SwitchTo().Frame(driver.FindElement(By.Id("scp_threeDSecure_iframe")));
            wait.Until(ExpectedConditions.ElementExists((By)PaymentPasswordBox));
            driver.FindElement(PaymentPasswordBox).Click();
            driver.FindElement(PaymentPasswordBox).SendKeys("Test_6721");
            //Click continue
            wait.Until(ExpectedConditions.ElementExists((By)ContinuePaymentBtn3DSPage));
            driver.FindElement(ContinuePaymentBtn3DSPage).Click();
            Thread.Sleep(5000);
            driver.SwitchTo().DefaultContent();
            //Verify payment successful box is shown
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            wait.Until(ExpectedConditions.ElementExists((By)PaymentSuccessMsg));
            Assert.IsTrue(driver.FindElement(PaymentSuccessMsg).Displayed);
            //Copy case reference
            wait.Until(ExpectedConditions.ElementExists((By)CaseReferenceNumber));
            var caseReferenceNumber = driver.FindElement(CaseReferenceNumber).Text;
            int pos = caseReferenceNumber.IndexOf("CAS");
            string beforeCAS = caseReferenceNumber.Remove(0, pos);
            Console.WriteLine(beforeCAS);
            //Login to CRM test
            driver.Navigate().GoToUrl("https://wmdctest.crm11.dynamics.com/main.aspx?appid=9ad87dee-5622-ea11-a814-00224801cd38&forceUCI=1&pagetype=dashboard&id=323a6277-86e6-e911-a812-000d3a7ed30d&type=system&_canOverride=true");
            //Verify wakefield user app is displayed
            wait.Until(ExpectedConditions.ElementExists((By)WakefieldUserApp));
            Assert.IsTrue(driver.FindElement(WakefieldUserApp).Displayed);
            //Click cases on LHN
            wait.Until(ExpectedConditions.ElementExists((By)CasesLHN));
            Thread.Sleep(3000);
            driver.FindElement(CasesLHN).Click();
            //Enter case number in searchbox
            Thread.Sleep(6000);
            wait.Until(ExpectedConditions.ElementExists((By)ActiveCasesSearchBox));
            Thread.Sleep(2000);
            driver.FindElement(ActiveCasesSearchBox).Click();
            Thread.Sleep(2000);
            driver.FindElement(ActiveCasesSearchBox).SendKeys(beforeCAS);
            driver.FindElement(ActiveCasesSearchBox).SendKeys(Keys.Enter);
            Thread.Sleep(5000);
            //Click case on the list
            wait.Until(ExpectedConditions.ElementExists((By)SkipHireBookingOnCaseLst));
            driver.FindElement(SkipHireBookingOnCaseLst).Click();
            Thread.Sleep(5000);
            //Verify payment shows as complete
            wait.Until(ExpectedConditions.ElementExists((By)PaymentStatusComplete));
            Assert.IsTrue(driver.FindElement(PaymentStatusComplete).Displayed);
            //Verify current queue is skip bookings
            var Status = 0;
            try
            {
                if (driver.FindElements(SkipBookingsQueue).Count() != 0)
                {
                    Console.WriteLine("Skip Bookings queue is assigned");
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
                    if (driver.FindElements(SkipBookingsQueue).Count() != 0)
                    {
                        break;
                    }
                    else if (Status == 10)
                    {
                        Console.WriteLine("Current queue not updated");
                        Assert.Fail();
                    }
                } while (driver.FindElements(SkipBookingsQueue).Count() == 0);
            }
        }

        public void MyAccountBookMidiPrivateWest()
        {
            //Verify Home dashboard is displayed
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)SiteHomepage));
            try
            {
                if (driver.FindElement(CookieBanner).Displayed)
                {
                    driver.FindElement(CookieBanner).Click();
                }
            }
            catch
            {
                Console.WriteLine("Cookie banner not shown");
            }
            //Select request skip hire on private land
            driver.FindElement(HomepageAllServicesTitle).Click();
            Actions actions = new Actions(driver);
            actions.SendKeys(Keys.PageDown).Build().Perform();
            Thread.Sleep(1000);
            actions.SendKeys(Keys.PageDown).Build().Perform();
            wait.Until(ExpectedConditions.ElementExists((By)RequestSkipPrivate));
            driver.FindElement(RequestSkipPrivate).Click();
            //Verify request skip form loads
            driver.WindowHandles.Last();
            wait.Until(ExpectedConditions.ElementExists((By)RequestSkipPrivateFormTitle));
            Assert.IsTrue(driver.FindElement(RequestSkipPrivateFormTitle).Displayed);
            //Click login to my account
            wait.Until(ExpectedConditions.ElementExists((By)LoginToMyAccount));
            driver.FindElement(LoginToMyAccount).Click();
            //Click continue
            wait.Until(ExpectedConditions.ElementExists((By)LoginMyAccountContinueBtn));
            driver.FindElement(LoginMyAccountContinueBtn).Click();
            //Enter Username
            wait.Until(ExpectedConditions.ElementExists((By)LoginMyAccountUsername));
            Actions action = new Actions(driver);
            WebElement ele = (WebElement)driver.FindElement(LoginMyAccountUsername);
            action.Click(ele).Click(ele).Click(ele).Perform();
            driver.FindElement(LoginMyAccountUsername).SendKeys(Keys.Delete);
            driver.FindElement(LoginMyAccountUsername).SendKeys("ittesting@wakefield.gov.uk");
            //Enter password
            wait.Until(ExpectedConditions.ElementExists((By)LoginMyAccountPassword));
            ele = (WebElement)driver.FindElement(LoginMyAccountPassword);
            action.Click(ele).Click(ele).Click(ele).Perform();
            driver.FindElement(LoginMyAccountPassword).SendKeys(Keys.Delete);
            StreamReader streamReader = new StreamReader(@"C:\Users\garymoore\OneDrive - Wakefield Council\Desktop\MyAccountPassword.txt");
            string password = streamReader.ReadToEnd();
            driver.FindElement(LoginMyAccountPassword).SendKeys(password);
            //Click Login
            wait.Until(ExpectedConditions.ElementExists((By)LoginMyAccountLoginBtn));
            driver.FindElement(LoginMyAccountLoginBtn).Click();
            //Click edit address
            wait.Until(ExpectedConditions.ElementExists((By)EditAddressBtn));
            driver.FindElement(EditAddressBtn).Click();
            //Enter new address
            wait.Until(ExpectedConditions.ElementExists((By)SearchForAddress));
            driver.FindElement(SearchForAddress).Click();
            driver.FindElement(SearchForAddress).SendKeys("Wakefield One Burton Street Wakefield WF1 2EB");
            driver.FindElement(SearchForAddressBtn).Click();
            //Select address from list
            wait.Until(ExpectedConditions.ElementExists((By)WakefieldOneAddressOnLst));
            driver.FindElement(WakefieldOneAddressOnLst).Click();
            //Enter text into deliver instructions
            wait.Until(ExpectedConditions.ElementExists((By)DeliveryInstructionsTxtBox));
            driver.FindElement(DeliveryInstructionsTxtBox).Click();
            driver.FindElement(DeliveryInstructionsTxtBox).SendKeys("Please Deliver");
            //Select skip size
            wait.Until(ExpectedConditions.ElementExists((By)SkipSizeDropdown));
            driver.FindElement(SkipSizeDropdown).Click();
            wait.Until(ExpectedConditions.ElementExists((By)SkipSizeDropdownMidi));
            driver.FindElement(SkipSizeDropdownMidi).Click();
            driver.FindElement(DeliveryInstructionsTxtBox).Click();
            actions = new Actions(driver);
            actions.SendKeys(Keys.PageDown).Build().Perform();
            Thread.Sleep(10000);
            //Select delivery date
            wait.Until(ExpectedConditions.ElementExists((By)SkipDeliveryDate));
            driver.FindElement(SkipDeliveryDate).Click();
            wait.Until(ExpectedConditions.ElementExists((By)SkipDeliveryDateYear));
            driver.FindElement(SkipDeliveryDateYear).Click();
            wait.Until(ExpectedConditions.ElementExists((By)SkipDeliveryDateYear2023));
            driver.FindElement(SkipDeliveryDateYear2023).Click();
            wait.Until(ExpectedConditions.ElementExists((By)SkipDeliveryAvailableDate));
            driver.FindElement(SkipDeliveryAvailableDate).Click();
            Thread.Sleep(6000);
            //Select collection date
            wait.Until(ExpectedConditions.ElementExists((By)SkipCollectionDate));
            driver.FindElement(SkipCollectionDate).Click();
            wait.Until(ExpectedConditions.ElementExists((By)SkipCollectionAvailableDate));
            driver.FindElement(SkipCollectionAvailableDate).Click();
            //Click yes to t&c's
            wait.Until(ExpectedConditions.ElementExists((By)TermsYesBtn));
            driver.FindElement(TermsYesBtn).Click();
            //Click go to payments
            wait.Until(ExpectedConditions.ElementExists((By)GoToPaymentsBtn));
            driver.FindElement(GoToPaymentsBtn).Click();
            //Verify skip price is correct
            wait.Until(ExpectedConditions.ElementExists((By)SkipHireBookingOnPaymentPage));
            Assert.IsTrue(driver.FindElement(SkipPrice).Displayed);
            //Select pay button
            wait.Until(ExpectedConditions.ElementExists((By)SkipPayBtn));
            driver.FindElement(SkipPayBtn).Click();
            Thread.Sleep(3000);
            //Verify payment page loads
            wait.Until(ExpectedConditions.ElementExists((By)TestPaymentSiteWarning));
            Assert.IsTrue(driver.FindElement(TestPaymentSiteWarning).Displayed);
            Thread.Sleep(2000);
            //Enter card number
            wait.Until(ExpectedConditions.ElementExists((By)CardNumber));
            driver.FindElement(CardNumber).Click();
            driver.FindElement(CardNumber).SendKeys("4543059790016721");
            //Enter expiry date
            wait.Until(ExpectedConditions.ElementExists((By)ExpiryDate1));
            driver.FindElement(ExpiryDate1).Click();
            driver.FindElement(ExpiryDate1).SendKeys("12");
            wait.Until(ExpectedConditions.ElementExists((By)ExpiryDate2));
            driver.FindElement(ExpiryDate2).Click();
            driver.FindElement(ExpiryDate2).SendKeys("23");
            //Enter security code
            wait.Until(ExpectedConditions.ElementExists((By)SecurityCode));
            driver.FindElement(SecurityCode).Click();
            driver.FindElement(SecurityCode).SendKeys("587");
            //Click continue
            wait.Until(ExpectedConditions.ElementExists((By)ContinuePaymentBtn));
            driver.FindElement(ContinuePaymentBtn).Click();
            Thread.Sleep(2000);
            //Enter cardholder name
            wait.Until(ExpectedConditions.ElementExists((By)CardholderName));
            driver.FindElement(CardholderName).Click();
            driver.FindElement(CardholderName).SendKeys("Test");
            //Click continue
            wait.Until(ExpectedConditions.ElementExists((By)ContinuePaymentBtn));
            driver.FindElement(ContinuePaymentBtn).Click();
            Thread.Sleep(2000);
            //Verify payment confirmation page loads
            wait.Until(ExpectedConditions.ElementExists((By)PaymentConfirmationTitle));
            Assert.IsTrue(driver.FindElement(PaymentConfirmationTitle).Displayed);
            //Click make payment
            wait.Until(ExpectedConditions.ElementExists((By)MakePaymentBtn));
            driver.FindElement(MakePaymentBtn).Click();
            Thread.Sleep(2000);
            //Enter password
            driver.SwitchTo().Frame(driver.FindElement(By.Id("scp_threeDSecure_iframe")));
            wait.Until(ExpectedConditions.ElementExists((By)PaymentPasswordBox));
            driver.FindElement(PaymentPasswordBox).Click();
            driver.FindElement(PaymentPasswordBox).SendKeys("Test_6721");
            //Click continue
            wait.Until(ExpectedConditions.ElementExists((By)ContinuePaymentBtn3DSPage));
            driver.FindElement(ContinuePaymentBtn3DSPage).Click();
            Thread.Sleep(5000);
            driver.SwitchTo().DefaultContent();
            //Verify payment successful box is shown
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            wait.Until(ExpectedConditions.ElementExists((By)PaymentSuccessMsg));
            Assert.IsTrue(driver.FindElement(PaymentSuccessMsg).Displayed);
            //Copy case reference
            wait.Until(ExpectedConditions.ElementExists((By)CaseReferenceNumber));
            var caseReferenceNumber = driver.FindElement(CaseReferenceNumber).Text;
            int pos = caseReferenceNumber.IndexOf("CAS");
            string beforeCAS = caseReferenceNumber.Remove(0, pos);
            Console.WriteLine(beforeCAS);
            //Login to CRM test
            driver.Navigate().GoToUrl("https://wmdctest.crm11.dynamics.com/main.aspx?appid=9ad87dee-5622-ea11-a814-00224801cd38&forceUCI=1&pagetype=dashboard&id=323a6277-86e6-e911-a812-000d3a7ed30d&type=system&_canOverride=true");
            //Verify wakefield user app is displayed
            wait.Until(ExpectedConditions.ElementExists((By)WakefieldUserApp));
            Assert.IsTrue(driver.FindElement(WakefieldUserApp).Displayed);
            //Click cases on LHN
            wait.Until(ExpectedConditions.ElementExists((By)CasesLHN));
            Thread.Sleep(3000);
            driver.FindElement(CasesLHN).Click();
            //Enter case number in searchbox
            Thread.Sleep(6000);
            wait.Until(ExpectedConditions.ElementExists((By)ActiveCasesSearchBox));
            driver.FindElement(ActiveCasesSearchBox).Click();
            Thread.Sleep(2000);
            driver.FindElement(ActiveCasesSearchBox).SendKeys(beforeCAS);
            driver.FindElement(ActiveCasesSearchBox).SendKeys(Keys.Enter);
            Thread.Sleep(5000);
            //Click case on the list
            wait.Until(ExpectedConditions.ElementExists((By)SkipHireBookingOnCaseLst));
            driver.FindElement(SkipHireBookingOnCaseLst).Click();
            Thread.Sleep(5000);
            //Verify payment shows as complete
            wait.Until(ExpectedConditions.ElementExists((By)PaymentStatusComplete));
            Assert.IsTrue(driver.FindElement(PaymentStatusComplete).Displayed);
            //Verify current queue is skip bookings
            var Status = 0;
            try
            {
                if (driver.FindElements(SkipBookingsQueue).Count() != 0)
                {
                    Console.WriteLine("Skip Bookings queue is assigned");
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
                    if (driver.FindElements(SkipBookingsQueue).Count() != 0)
                    {
                        break;
                    }
                    else if (Status == 10)
                    {
                        Console.WriteLine("Current queue not updated");
                        Assert.Fail();
                    }
                } while (driver.FindElements(SkipBookingsQueue).Count() == 0);
            }
        }

        public void MyAccountBookMaxiPrivateEast()
        {
            //Verify Home dashboard is displayed
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)SiteHomepage));
            try
            {
                if (driver.FindElement(CookieBanner).Displayed)
                {
                    driver.FindElement(CookieBanner).Click();
                }
            }
            catch
            {
                Console.WriteLine("Cookie banner not shown");
            }
            //Select request skip hire on private land
            driver.FindElement(HomepageAllServicesTitle).Click();
            Actions actions = new Actions(driver);
            actions.SendKeys(Keys.PageDown).Build().Perform();
            Thread.Sleep(1000);
            actions.SendKeys(Keys.PageDown).Build().Perform();
            wait.Until(ExpectedConditions.ElementExists((By)RequestSkipPrivate));
            driver.FindElement(RequestSkipPrivate).Click();
            //Verify request skip form loads
            driver.WindowHandles.Last();
            wait.Until(ExpectedConditions.ElementExists((By)RequestSkipPrivateFormTitle));
            Assert.IsTrue(driver.FindElement(RequestSkipPrivateFormTitle).Displayed);
            //Click login to my account
            wait.Until(ExpectedConditions.ElementExists((By)LoginToMyAccount));
            driver.FindElement(LoginToMyAccount).Click();
            //Click continue
            wait.Until(ExpectedConditions.ElementExists((By)LoginMyAccountContinueBtn));
            driver.FindElement(LoginMyAccountContinueBtn).Click();
            //Enter Username
            wait.Until(ExpectedConditions.ElementExists((By)LoginMyAccountUsername));
            Actions action = new Actions(driver);
            WebElement ele = (WebElement)driver.FindElement(LoginMyAccountUsername);
            action.Click(ele).Click(ele).Click(ele).Perform();
            driver.FindElement(LoginMyAccountUsername).SendKeys(Keys.Delete);
            driver.FindElement(LoginMyAccountUsername).SendKeys("ittesting@wakefield.gov.uk");
            //Enter password
            wait.Until(ExpectedConditions.ElementExists((By)LoginMyAccountPassword));
            ele = (WebElement)driver.FindElement(LoginMyAccountPassword);
            action.Click(ele).Click(ele).Click(ele).Perform();
            driver.FindElement(LoginMyAccountPassword).SendKeys(Keys.Delete);
            StreamReader streamReader = new StreamReader(@"C:\Users\garymoore\OneDrive - Wakefield Council\Desktop\MyAccountPassword.txt");
            string password = streamReader.ReadToEnd();
            driver.FindElement(LoginMyAccountPassword).SendKeys(password);
            //Click Login
            wait.Until(ExpectedConditions.ElementExists((By)LoginMyAccountLoginBtn));
            driver.FindElement(LoginMyAccountLoginBtn).Click();
            Thread.Sleep(3000);
            //Enter text into deliver instructions
            wait.Until(ExpectedConditions.ElementExists((By)DeliveryInstructionsTxtBox));
            driver.FindElement(DeliveryInstructionsTxtBox).Click();
            driver.FindElement(DeliveryInstructionsTxtBox).SendKeys("Please Deliver");
            //Select skip size
            wait.Until(ExpectedConditions.ElementExists((By)SkipSizeDropdown));
            driver.FindElement(SkipSizeDropdown).Click();
            wait.Until(ExpectedConditions.ElementExists((By)SkipSizeDropdownMaxi));
            driver.FindElement(SkipSizeDropdownMaxi).Click();
            driver.FindElement(DeliveryInstructionsTxtBox).Click();
            actions = new Actions(driver);
            actions.SendKeys(Keys.PageDown).Build().Perform();
            Thread.Sleep(10000);
            //Select delivery date
            wait.Until(ExpectedConditions.ElementExists((By)SkipDeliveryDate));
            driver.FindElement(SkipDeliveryDate).Click();
            wait.Until(ExpectedConditions.ElementExists((By)SkipDeliveryDateYear));
            driver.FindElement(SkipDeliveryDateYear).Click();
            wait.Until(ExpectedConditions.ElementExists((By)SkipDeliveryDateYear2023));
            driver.FindElement(SkipDeliveryDateYear2023).Click();
            wait.Until(ExpectedConditions.ElementExists((By)SkipDeliveryAvailableDate));
            driver.FindElement(SkipDeliveryAvailableDate).Click();
            Thread.Sleep(3000);
            //Select collection date
            wait.Until(ExpectedConditions.ElementExists((By)SkipCollectionDate));
            driver.FindElement(SkipCollectionDate).Click();
            wait.Until(ExpectedConditions.ElementExists((By)SkipCollectionAvailableDate));
            driver.FindElement(SkipCollectionAvailableDate).Click();
            //Click yes to t&c's
            wait.Until(ExpectedConditions.ElementExists((By)TermsYesBtn));
            driver.FindElement(TermsYesBtn).Click();
            //Click go to payments
            wait.Until(ExpectedConditions.ElementExists((By)GoToPaymentsBtn));
            driver.FindElement(GoToPaymentsBtn).Click();
            //Verify skip price is correct
            wait.Until(ExpectedConditions.ElementExists((By)SkipHireBookingOnPaymentPage));
            Assert.IsTrue(driver.FindElement(SkipPriceMaxi).Displayed);
            //Select pay button
            wait.Until(ExpectedConditions.ElementExists((By)SkipPayBtn));
            driver.FindElement(SkipPayBtn).Click();
            Thread.Sleep(3000);
            //Verify payment page loads
            wait.Until(ExpectedConditions.ElementExists((By)TestPaymentSiteWarning));
            Assert.IsTrue(driver.FindElement(TestPaymentSiteWarning).Displayed);
            Thread.Sleep(2000);
            //Enter card number
            wait.Until(ExpectedConditions.ElementExists((By)CardNumber));
            driver.FindElement(CardNumber).Click();
            driver.FindElement(CardNumber).SendKeys("4543059790016721");
            //Enter expiry date
            wait.Until(ExpectedConditions.ElementExists((By)ExpiryDate1));
            driver.FindElement(ExpiryDate1).Click();
            driver.FindElement(ExpiryDate1).SendKeys("12");
            wait.Until(ExpectedConditions.ElementExists((By)ExpiryDate2));
            driver.FindElement(ExpiryDate2).Click();
            driver.FindElement(ExpiryDate2).SendKeys("23");
            //Enter security code
            wait.Until(ExpectedConditions.ElementExists((By)SecurityCode));
            driver.FindElement(SecurityCode).Click();
            driver.FindElement(SecurityCode).SendKeys("587");
            //Click continue
            wait.Until(ExpectedConditions.ElementExists((By)ContinuePaymentBtn));
            driver.FindElement(ContinuePaymentBtn).Click();
            Thread.Sleep(2000);
            //Enter cardholder name
            wait.Until(ExpectedConditions.ElementExists((By)CardholderName));
            driver.FindElement(CardholderName).Click();
            driver.FindElement(CardholderName).SendKeys("Test");
            //Click continue
            wait.Until(ExpectedConditions.ElementExists((By)ContinuePaymentBtn));
            driver.FindElement(ContinuePaymentBtn).Click();
            Thread.Sleep(2000);
            //Verify payment confirmation page loads
            wait.Until(ExpectedConditions.ElementExists((By)PaymentConfirmationTitle));
            Assert.IsTrue(driver.FindElement(PaymentConfirmationTitle).Displayed);
            //Click make payment
            wait.Until(ExpectedConditions.ElementExists((By)MakePaymentBtn));
            driver.FindElement(MakePaymentBtn).Click();
            Thread.Sleep(2000);
            //Enter password
            driver.SwitchTo().Frame(driver.FindElement(By.Id("scp_threeDSecure_iframe")));
            wait.Until(ExpectedConditions.ElementExists((By)PaymentPasswordBox));
            driver.FindElement(PaymentPasswordBox).Click();
            driver.FindElement(PaymentPasswordBox).SendKeys("Test_6721");
            //Click continue
            wait.Until(ExpectedConditions.ElementExists((By)ContinuePaymentBtn3DSPage));
            driver.FindElement(ContinuePaymentBtn3DSPage).Click();
            Thread.Sleep(5000);
            driver.SwitchTo().DefaultContent();
            //Verify payment successful box is shown
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            wait.Until(ExpectedConditions.ElementExists((By)PaymentSuccessMsg));
            Assert.IsTrue(driver.FindElement(PaymentSuccessMsg).Displayed);
            //Copy case reference
            wait.Until(ExpectedConditions.ElementExists((By)CaseReferenceNumber));
            var caseReferenceNumber = driver.FindElement(CaseReferenceNumber).Text;
            int pos = caseReferenceNumber.IndexOf("CAS");
            string beforeCAS = caseReferenceNumber.Remove(0, pos);
            Console.WriteLine(beforeCAS);
            //Login to CRM test
            driver.Navigate().GoToUrl("https://wmdctest.crm11.dynamics.com/main.aspx?appid=9ad87dee-5622-ea11-a814-00224801cd38&forceUCI=1&pagetype=dashboard&id=323a6277-86e6-e911-a812-000d3a7ed30d&type=system&_canOverride=true");
            //Verify wakefield user app is displayed
            wait.Until(ExpectedConditions.ElementExists((By)WakefieldUserApp));
            Assert.IsTrue(driver.FindElement(WakefieldUserApp).Displayed);
            //Click cases on LHN
            wait.Until(ExpectedConditions.ElementExists((By)CasesLHN));
            Thread.Sleep(3000);
            driver.FindElement(CasesLHN).Click();
            //Enter case number in searchbox
            Thread.Sleep(10000);
            wait.Until(ExpectedConditions.ElementExists((By)ActiveCasesSearchBox));
            driver.FindElement(ActiveCasesSearchBox).Click();
            Thread.Sleep(2000);
            driver.FindElement(ActiveCasesSearchBox).SendKeys(beforeCAS);
            driver.FindElement(ActiveCasesSearchBox).SendKeys(Keys.Enter);
            Thread.Sleep(5000);
            //Click case on the list
            wait.Until(ExpectedConditions.ElementExists((By)SkipHireBookingOnCaseLst));
            driver.FindElement(SkipHireBookingOnCaseLst).Click();
            Thread.Sleep(5000);
            //Verify payment shows as complete
            wait.Until(ExpectedConditions.ElementExists((By)PaymentStatusComplete));
            Assert.IsTrue(driver.FindElement(PaymentStatusComplete).Displayed);
            //Verify current queue is skip bookings
            var Status = 0;
            try
            {
                if (driver.FindElements(SkipBookingsQueue).Count() != 0)
                {
                    Console.WriteLine("Skip Bookings queue is assigned");
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
                    if (driver.FindElements(SkipBookingsQueue).Count() != 0)
                    {
                        break;
                    }
                    else if (Status == 10)
                    {
                        Console.WriteLine("Current queue not updated");
                        Assert.Fail();
                    }
                } while (driver.FindElements(SkipBookingsQueue).Count() == 0);
            }
        }

        public void MyAccountBookMaxiPrivateWest()
        {
            //Verify Home dashboard is displayed
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)SiteHomepage));
            try
            {
                if (driver.FindElement(CookieBanner).Displayed)
                {
                    driver.FindElement(CookieBanner).Click();
                }
            }
            catch
            {
                Console.WriteLine("Cookie banner not shown");
            }
            //Select request skip hire on private land
            driver.FindElement(HomepageAllServicesTitle).Click();
            Actions actions = new Actions(driver);
            actions.SendKeys(Keys.PageDown).Build().Perform();
            Thread.Sleep(1000);
            actions.SendKeys(Keys.PageDown).Build().Perform();
            wait.Until(ExpectedConditions.ElementExists((By)RequestSkipPrivate));
            driver.FindElement(RequestSkipPrivate).Click();
            //Verify request skip form loads
            driver.WindowHandles.Last();
            wait.Until(ExpectedConditions.ElementExists((By)RequestSkipPrivateFormTitle));
            Assert.IsTrue(driver.FindElement(RequestSkipPrivateFormTitle).Displayed);
            //Click login to my account
            wait.Until(ExpectedConditions.ElementExists((By)LoginToMyAccount));
            driver.FindElement(LoginToMyAccount).Click();
            //Click continue
            wait.Until(ExpectedConditions.ElementExists((By)LoginMyAccountContinueBtn));
            driver.FindElement(LoginMyAccountContinueBtn).Click();
            //Enter Username
            wait.Until(ExpectedConditions.ElementExists((By)LoginMyAccountUsername));
            Actions action = new Actions(driver);
            WebElement ele = (WebElement)driver.FindElement(LoginMyAccountUsername);
            action.Click(ele).Click(ele).Click(ele).Perform();
            driver.FindElement(LoginMyAccountUsername).SendKeys(Keys.Delete);
            driver.FindElement(LoginMyAccountUsername).SendKeys("ittesting@wakefield.gov.uk");
            //Enter password
            wait.Until(ExpectedConditions.ElementExists((By)LoginMyAccountPassword));
            ele = (WebElement)driver.FindElement(LoginMyAccountPassword);
            action.Click(ele).Click(ele).Click(ele).Perform();
            driver.FindElement(LoginMyAccountPassword).SendKeys(Keys.Delete);
            StreamReader streamReader = new StreamReader(@"C:\Users\garymoore\OneDrive - Wakefield Council\Desktop\MyAccountPassword.txt");
            string password = streamReader.ReadToEnd();
            driver.FindElement(LoginMyAccountPassword).SendKeys(password);
            //Click Login
            wait.Until(ExpectedConditions.ElementExists((By)LoginMyAccountLoginBtn));
            driver.FindElement(LoginMyAccountLoginBtn).Click();
            //Click edit address
            wait.Until(ExpectedConditions.ElementExists((By)EditAddressBtn));
            driver.FindElement(EditAddressBtn).Click();
            //Enter new address
            wait.Until(ExpectedConditions.ElementExists((By)SearchForAddress));
            driver.FindElement(SearchForAddress).Click();
            driver.FindElement(SearchForAddress).SendKeys("Wakefield One Burton Street Wakefield WF1 2EB");
            driver.FindElement(SearchForAddressBtn).Click();
            //Select address from list
            wait.Until(ExpectedConditions.ElementExists((By)WakefieldOneAddressOnLst));
            driver.FindElement(WakefieldOneAddressOnLst).Click();
            //Enter text into deliver instructions
            wait.Until(ExpectedConditions.ElementExists((By)DeliveryInstructionsTxtBox));
            driver.FindElement(DeliveryInstructionsTxtBox).Click();
            driver.FindElement(DeliveryInstructionsTxtBox).SendKeys("Please Deliver");
            //Select skip size
            wait.Until(ExpectedConditions.ElementExists((By)SkipSizeDropdown));
            driver.FindElement(SkipSizeDropdown).Click();
            wait.Until(ExpectedConditions.ElementExists((By)SkipSizeDropdownMaxi));
            driver.FindElement(SkipSizeDropdownMaxi).Click();
            driver.FindElement(DeliveryInstructionsTxtBox).Click();
            actions = new Actions(driver);
            actions.SendKeys(Keys.PageDown).Build().Perform();
            Thread.Sleep(10000);
            //Select delivery date
            wait.Until(ExpectedConditions.ElementExists((By)SkipDeliveryDate));
            driver.FindElement(SkipDeliveryDate).Click();
            wait.Until(ExpectedConditions.ElementExists((By)SkipDeliveryDateYear));
            driver.FindElement(SkipDeliveryDateYear).Click();
            wait.Until(ExpectedConditions.ElementExists((By)SkipDeliveryDateYear2023));
            driver.FindElement(SkipDeliveryDateYear2023).Click();
            wait.Until(ExpectedConditions.ElementExists((By)SkipDeliveryAvailableDate));
            driver.FindElement(SkipDeliveryAvailableDate).Click();
            Thread.Sleep(5000);
            //Select collection date
            wait.Until(ExpectedConditions.ElementExists((By)SkipCollectionDate));
            driver.FindElement(SkipCollectionDate).Click();
            wait.Until(ExpectedConditions.ElementExists((By)SkipCollectionAvailableDate));
            driver.FindElement(SkipCollectionAvailableDate).Click();
            //Click yes to t&c's
            wait.Until(ExpectedConditions.ElementExists((By)TermsYesBtn));
            driver.FindElement(TermsYesBtn).Click();
            //Click go to payments
            wait.Until(ExpectedConditions.ElementExists((By)GoToPaymentsBtn));
            driver.FindElement(GoToPaymentsBtn).Click();
            //Verify skip price is correct
            wait.Until(ExpectedConditions.ElementExists((By)SkipHireBookingOnPaymentPage));
            Assert.IsTrue(driver.FindElement(SkipPriceMaxi).Displayed);
            //Select pay button
            wait.Until(ExpectedConditions.ElementExists((By)SkipPayBtn));
            driver.FindElement(SkipPayBtn).Click();
            Thread.Sleep(3000);
            //Verify payment page loads
            wait.Until(ExpectedConditions.ElementExists((By)TestPaymentSiteWarning));
            Assert.IsTrue(driver.FindElement(TestPaymentSiteWarning).Displayed);
            Thread.Sleep(2000);
            //Enter card number
            wait.Until(ExpectedConditions.ElementExists((By)CardNumber));
            driver.FindElement(CardNumber).Click();
            driver.FindElement(CardNumber).SendKeys("4543059790016721");
            //Enter expiry date
            wait.Until(ExpectedConditions.ElementExists((By)ExpiryDate1));
            driver.FindElement(ExpiryDate1).Click();
            driver.FindElement(ExpiryDate1).SendKeys("12");
            wait.Until(ExpectedConditions.ElementExists((By)ExpiryDate2));
            driver.FindElement(ExpiryDate2).Click();
            driver.FindElement(ExpiryDate2).SendKeys("23");
            //Enter security code
            wait.Until(ExpectedConditions.ElementExists((By)SecurityCode));
            driver.FindElement(SecurityCode).Click();
            driver.FindElement(SecurityCode).SendKeys("587");
            //Click continue
            wait.Until(ExpectedConditions.ElementExists((By)ContinuePaymentBtn));
            driver.FindElement(ContinuePaymentBtn).Click();
            Thread.Sleep(2000);
            //Enter cardholder name
            wait.Until(ExpectedConditions.ElementExists((By)CardholderName));
            driver.FindElement(CardholderName).Click();
            driver.FindElement(CardholderName).SendKeys("Test");
            //Click continue
            wait.Until(ExpectedConditions.ElementExists((By)ContinuePaymentBtn));
            driver.FindElement(ContinuePaymentBtn).Click();
            Thread.Sleep(2000);
            //Verify payment confirmation page loads
            wait.Until(ExpectedConditions.ElementExists((By)PaymentConfirmationTitle));
            Assert.IsTrue(driver.FindElement(PaymentConfirmationTitle).Displayed);
            //Click make payment
            wait.Until(ExpectedConditions.ElementExists((By)MakePaymentBtn));
            driver.FindElement(MakePaymentBtn).Click();
            Thread.Sleep(2000);
            //Enter password
            driver.SwitchTo().Frame(driver.FindElement(By.Id("scp_threeDSecure_iframe")));
            wait.Until(ExpectedConditions.ElementExists((By)PaymentPasswordBox));
            driver.FindElement(PaymentPasswordBox).Click();
            driver.FindElement(PaymentPasswordBox).SendKeys("Test_6721");
            //Click continue
            wait.Until(ExpectedConditions.ElementExists((By)ContinuePaymentBtn3DSPage));
            driver.FindElement(ContinuePaymentBtn3DSPage).Click();
            Thread.Sleep(5000);
            driver.SwitchTo().DefaultContent();
            //Verify payment successful box is shown
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            wait.Until(ExpectedConditions.ElementExists((By)PaymentSuccessMsg));
            Assert.IsTrue(driver.FindElement(PaymentSuccessMsg).Displayed);
            //Copy case reference
            wait.Until(ExpectedConditions.ElementExists((By)CaseReferenceNumber));
            var caseReferenceNumber = driver.FindElement(CaseReferenceNumber).Text;
            int pos = caseReferenceNumber.IndexOf("CAS");
            string beforeCAS = caseReferenceNumber.Remove(0, pos);
            Console.WriteLine(beforeCAS);
            //Login to CRM test
            driver.Navigate().GoToUrl("https://wmdctest.crm11.dynamics.com/main.aspx?appid=9ad87dee-5622-ea11-a814-00224801cd38&forceUCI=1&pagetype=dashboard&id=323a6277-86e6-e911-a812-000d3a7ed30d&type=system&_canOverride=true");
            //Verify wakefield user app is displayed
            wait.Until(ExpectedConditions.ElementExists((By)WakefieldUserApp));
            Assert.IsTrue(driver.FindElement(WakefieldUserApp).Displayed);
            //Click cases on LHN
            wait.Until(ExpectedConditions.ElementExists((By)CasesLHN));
            Thread.Sleep(3000);
            driver.FindElement(CasesLHN).Click();
            //Enter case number in searchbox
            Thread.Sleep(10000);
            wait.Until(ExpectedConditions.ElementExists((By)ActiveCasesSearchBox));
            driver.FindElement(ActiveCasesSearchBox).Click();
            Thread.Sleep(2000);
            driver.FindElement(ActiveCasesSearchBox).SendKeys(beforeCAS);
            driver.FindElement(ActiveCasesSearchBox).SendKeys(Keys.Enter);
            Thread.Sleep(5000);
            //Click case on the list
            wait.Until(ExpectedConditions.ElementExists((By)SkipHireBookingOnCaseLst));
            driver.FindElement(SkipHireBookingOnCaseLst).Click();
            Thread.Sleep(5000);
            //Verify payment shows as complete
            wait.Until(ExpectedConditions.ElementExists((By)PaymentStatusComplete));
            Assert.IsTrue(driver.FindElement(PaymentStatusComplete).Displayed);
            //Verify current queue is skip bookings
            var Status = 0;
            try
            {
                if (driver.FindElements(SkipBookingsQueue).Count() != 0)
                {
                    Console.WriteLine("Skip Bookings queue is assigned");
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
                    if (driver.FindElements(SkipBookingsQueue).Count() != 0)
                    {
                        break;
                    }
                    else if (Status == 10)
                    {
                        Console.WriteLine("Current queue not updated");
                        Assert.Fail();
                    }
                } while (driver.FindElements(SkipBookingsQueue).Count() == 0);
            }
        }

        public void MyAccountBookAbandonPayment()
        {
            //Verify Home dashboard is displayed
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)SiteHomepage));
            try
            {
                if (driver.FindElement(CookieBanner).Displayed)
                {
                    driver.FindElement(CookieBanner).Click();
                }
            }
            catch
            {
                Console.WriteLine("Cookie banner not shown");
            }
            //Select request skip hire on private land
            driver.FindElement(HomepageAllServicesTitle).Click();
            Actions actions = new Actions(driver);
            actions.SendKeys(Keys.PageDown).Build().Perform();
            Thread.Sleep(1000);
            actions.SendKeys(Keys.PageDown).Build().Perform();
            wait.Until(ExpectedConditions.ElementExists((By)RequestSkipPrivate));
            driver.FindElement(RequestSkipPrivate).Click();
            Thread.Sleep(3000);
            //Verify request skip form loads
            driver.WindowHandles.Last();
            wait.Until(ExpectedConditions.ElementExists((By)RequestSkipPrivateFormTitle));
            Assert.IsTrue(driver.FindElement(RequestSkipPrivateFormTitle).Displayed);
            //Click login to my account
            wait.Until(ExpectedConditions.ElementExists((By)LoginToMyAccount));
            driver.FindElement(LoginToMyAccount).Click();
            //Click continue
            wait.Until(ExpectedConditions.ElementExists((By)LoginMyAccountContinueBtn));
            driver.FindElement(LoginMyAccountContinueBtn).Click();
            //Enter Username
            wait.Until(ExpectedConditions.ElementExists((By)LoginMyAccountUsername));
            Actions action = new Actions(driver);
            WebElement ele = (WebElement)driver.FindElement(LoginMyAccountUsername);
            action.Click(ele).Click(ele).Click(ele).Perform();
            driver.FindElement(LoginMyAccountUsername).SendKeys(Keys.Delete);
            driver.FindElement(LoginMyAccountUsername).SendKeys("ittesting@wakefield.gov.uk");
            //Enter password
            wait.Until(ExpectedConditions.ElementExists((By)LoginMyAccountPassword));
            ele = (WebElement)driver.FindElement(LoginMyAccountPassword);
            action.Click(ele).Click(ele).Click(ele).Perform();
            driver.FindElement(LoginMyAccountPassword).SendKeys(Keys.Delete);
            StreamReader streamReader = new StreamReader(@"C:\Users\garymoore\OneDrive - Wakefield Council\Desktop\MyAccountPassword.txt");
            string password = streamReader.ReadToEnd();
            driver.FindElement(LoginMyAccountPassword).SendKeys(password);
            //Click Login
            wait.Until(ExpectedConditions.ElementExists((By)LoginMyAccountLoginBtn));
            driver.FindElement(LoginMyAccountLoginBtn).Click();
            Thread.Sleep(3000);
            //verify skip form loads
            wait.Until(ExpectedConditions.ElementExists((By)RequestSkipPrivateFormTitle));
            Assert.IsTrue(driver.FindElement(RequestSkipPrivateFormTitle).Displayed);
            //Enter text into deliver instructions
            wait.Until(ExpectedConditions.ElementExists((By)DeliveryInstructionsTxtBox));
            driver.FindElement(DeliveryInstructionsTxtBox).Click();
            driver.FindElement(DeliveryInstructionsTxtBox).SendKeys("Please Deliver");
            //Select skip size
            wait.Until(ExpectedConditions.ElementExists((By)SkipSizeDropdown));
            driver.FindElement(SkipSizeDropdown).Click();
            wait.Until(ExpectedConditions.ElementExists((By)SkipSizeDropdownMidi));
            driver.FindElement(SkipSizeDropdownMidi).Click();
            driver.FindElement(DeliveryInstructionsTxtBox).Click();
            actions = new Actions(driver);
            actions.SendKeys(Keys.PageDown).Build().Perform();
            Thread.Sleep(10000);
            //Select delivery date
            wait.Until(ExpectedConditions.ElementExists((By)SkipDeliveryDate));
            driver.FindElement(SkipDeliveryDate).Click();
            wait.Until(ExpectedConditions.ElementExists((By)SkipDeliveryDateYear));
            driver.FindElement(SkipDeliveryDateYear).Click();
            wait.Until(ExpectedConditions.ElementExists((By)SkipDeliveryDateYear2023));
            driver.FindElement(SkipDeliveryDateYear2023).Click();
            wait.Until(ExpectedConditions.ElementExists((By)SkipDeliveryAvailableDate));
            driver.FindElement(SkipDeliveryAvailableDate).Click();
            Thread.Sleep(5000);
            //Select collection date
            wait.Until(ExpectedConditions.ElementExists((By)SkipCollectionDate));
            driver.FindElement(SkipCollectionDate).Click();
            wait.Until(ExpectedConditions.ElementExists((By)SkipCollectionAvailableDate));
            driver.FindElement(SkipCollectionAvailableDate).Click();
            //Click yes to t&c's
            wait.Until(ExpectedConditions.ElementExists((By)TermsYesBtn));
            driver.FindElement(TermsYesBtn).Click();
            //Click go to payments
            wait.Until(ExpectedConditions.ElementExists((By)GoToPaymentsBtn));
            driver.FindElement(GoToPaymentsBtn).Click();
            //Verify skip price is correct
            wait.Until(ExpectedConditions.ElementExists((By)SkipHireBookingOnPaymentPage));
            Assert.IsTrue(driver.FindElement(SkipPrice).Displayed);
            //Login to CRM test
            driver.Navigate().GoToUrl("https://wmdctest.crm11.dynamics.com/main.aspx?appid=9ad87dee-5622-ea11-a814-00224801cd38&forceUCI=1&pagetype=dashboard&id=323a6277-86e6-e911-a812-000d3a7ed30d&type=system&_canOverride=true");
            //Verify wakefield user app is displayed
            wait.Until(ExpectedConditions.ElementExists((By)WakefieldUserApp));
            Assert.IsTrue(driver.FindElement(WakefieldUserApp).Displayed);
            //Click cases on LHN
            wait.Until(ExpectedConditions.ElementExists((By)CasesLHN));
            Thread.Sleep(3000);
            driver.FindElement(CasesLHN).Click();
            //Click active cases
            Thread.Sleep(10000);
            wait.Until(ExpectedConditions.ElementExists((By)ActiveCasesTitle));
            Thread.Sleep(3000);
            driver.FindElement(ActiveCasesTitle).Click();
            Thread.Sleep(2000);
            //Select cases opened in last 7 days
            wait.Until(ExpectedConditions.ElementExists((By)CasesOpenedLast7Days));
            driver.FindElement(CasesOpenedLast7Days).Click();
            Thread.Sleep(3000);
            //Click case on the list
            wait.Until(ExpectedConditions.ElementExists((By)SkipHireBookingOnCaseLst));
            driver.FindElement(SkipHireBookingOnCaseLst).Click();
            Thread.Sleep(5000);
            //Verify payment shows as Incomplete
            wait.Until(ExpectedConditions.ElementExists((By)PaymentStatusIncomplete));
            Assert.IsTrue(driver.FindElement(PaymentStatusIncomplete).Displayed);
            //Verify current queue is empty
            wait.Until(ExpectedConditions.ElementExists((By)SkipBookingsQueueEmpty));
            Assert.IsTrue(driver.FindElement(SkipBookingsQueueEmpty).Displayed);
            //Click skip hire booking form
            wait.Until(ExpectedConditions.ElementExists((By)SkipHireBookingFormLink));
            driver.FindElement(SkipHireBookingFormLink).Click();
            Thread.Sleep(3000);
            //Verify payment shows as Incomplete
            wait.Until(ExpectedConditions.ElementExists((By)ServiceDetailsTitle));
            driver.FindElement(ServiceDetailsTitle).Click();
            actions = new Actions(driver);
            actions.SendKeys(Keys.PageDown).Build().Perform();
            Thread.Sleep(1000);
            actions = new Actions(driver);
            actions.SendKeys(Keys.PageDown).Build().Perform();
            Thread.Sleep(1000);
            actions = new Actions(driver);
            actions.SendKeys(Keys.PageDown).Build().Perform();
            wait.Until(ExpectedConditions.ElementExists((By)PaymentStatusIncomplete));
            Assert.IsTrue(driver.FindElement(PaymentStatusIncomplete).Displayed);

        } //Need to verify what booking should look like on skip booking form

        public void MyAccountBookRoadRequestCallBackEast()
        {
            //Verify Home dashboard is displayed
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)SiteHomepage));
            try
            {
                if (driver.FindElement(CookieBanner).Displayed)
                {
                    driver.FindElement(CookieBanner).Click();
                }
            }
            catch
            {
                Console.WriteLine("Cookie banner not shown");
            }
            //Select request skip hire on public land
            driver.FindElement(HomepageAllServicesTitle).Click();
            Actions actions = new Actions(driver);
            actions.SendKeys(Keys.PageDown).Build().Perform();
            Thread.Sleep(1000);
            actions.SendKeys(Keys.PageDown).Build().Perform();
            wait.Until(ExpectedConditions.ElementExists((By)RequestSkipPublic));
            driver.FindElement(RequestSkipPublic).Click();
            Thread.Sleep(3000);
            //Verify request skip form loads
            wait.Until(ExpectedConditions.ElementExists((By)RequestSkipPublicFormTitle));
            Assert.IsTrue(driver.FindElement(RequestSkipPublicFormTitle).Displayed);
            //Click login to my account
            wait.Until(ExpectedConditions.ElementExists((By)LoginToMyAccount));
            driver.FindElement(LoginToMyAccount).Click();
            //Click continue
            wait.Until(ExpectedConditions.ElementExists((By)LoginMyAccountContinueBtn));
            driver.FindElement(LoginMyAccountContinueBtn).Click();
            //Enter Username
            wait.Until(ExpectedConditions.ElementExists((By)LoginMyAccountUsername));
            Actions action = new Actions(driver);
            WebElement ele = (WebElement)driver.FindElement(LoginMyAccountUsername);
            action.Click(ele).Click(ele).Click(ele).Perform();
            driver.FindElement(LoginMyAccountUsername).SendKeys(Keys.Delete);
            driver.FindElement(LoginMyAccountUsername).SendKeys("ittesting@wakefield.gov.uk");
            //Enter password
            wait.Until(ExpectedConditions.ElementExists((By)LoginMyAccountPassword));
            ele = (WebElement)driver.FindElement(LoginMyAccountPassword);
            action.Click(ele).Click(ele).Click(ele).Perform();
            driver.FindElement(LoginMyAccountPassword).SendKeys(Keys.Delete);
            StreamReader streamReader = new StreamReader(@"C:\Users\garymoore\OneDrive - Wakefield Council\Desktop\MyAccountPassword.txt");
            string password = streamReader.ReadToEnd();
            driver.FindElement(LoginMyAccountPassword).SendKeys(password);
            //Click Login
            wait.Until(ExpectedConditions.ElementExists((By)LoginMyAccountLoginBtn));
            driver.FindElement(LoginMyAccountLoginBtn).Click();
            Thread.Sleep(3000);
            //verify skip form loads
            wait.Until(ExpectedConditions.ElementExists((By)RequestSkipPublicFormTitle));
            Assert.IsTrue(driver.FindElement(RequestSkipPublicFormTitle).Displayed);
            //Enter text into deliver instructions
            wait.Until(ExpectedConditions.ElementExists((By)DeliveryInstructionsTxtBox));
            driver.FindElement(DeliveryInstructionsTxtBox).Click();
            driver.FindElement(DeliveryInstructionsTxtBox).SendKeys("Please Deliver");
            //Select skip size
            wait.Until(ExpectedConditions.ElementExists((By)SkipSizeDropdown));
            driver.FindElement(SkipSizeDropdown).Click();
            wait.Until(ExpectedConditions.ElementExists((By)SkipSizeDropdownMidi));
            driver.FindElement(SkipSizeDropdownMidi).Click();
            //Click submit
            wait.Until(ExpectedConditions.ElementExists((By)PublicSkipSubmitBtn));
            driver.FindElement(PublicSkipSubmitBtn).Click();
            //Login to CRM test
            driver.Navigate().GoToUrl("https://wmdctest.crm11.dynamics.com/main.aspx?appid=9ad87dee-5622-ea11-a814-00224801cd38&forceUCI=1&pagetype=dashboard&id=323a6277-86e6-e911-a812-000d3a7ed30d&type=system&_canOverride=true");
            //Verify wakefield user app is displayed
            wait.Until(ExpectedConditions.ElementExists((By)WakefieldUserApp));
            Assert.IsTrue(driver.FindElement(WakefieldUserApp).Displayed);
            Thread.Sleep(3000);
            //Click cases on LHN
            wait.Until(ExpectedConditions.ElementExists((By)CasesLHN));
            Thread.Sleep(3000);
            driver.FindElement(CasesLHN).Click();
            //Click active cases
            Thread.Sleep(6000);
            wait.Until(ExpectedConditions.ElementExists((By)ActiveCasesTitle));
            Thread.Sleep(5000);
            driver.FindElement(ActiveCasesTitle).Click();
            Thread.Sleep(2000);
            //Select cases opened in last 7 days
            wait.Until(ExpectedConditions.ElementExists((By)CasesOpenedLast7Days));
            driver.FindElement(CasesOpenedLast7Days).Click();
            Thread.Sleep(10000);
            //Click case on the list
            wait.Until(ExpectedConditions.ElementExists((By)SkipHireBookingOnCaseLst));
            driver.FindElement(SkipHireBookingOnCaseLst).Click();
            Thread.Sleep(5000);
            //Verify current queue is business development default
            wait.Until(ExpectedConditions.ElementExists((By)SkipBookingsQueueBDDefault));
            Assert.IsTrue(driver.FindElement(SkipBookingsQueueBDDefault).Displayed);
            //Verify service subtype is skip hire - call back
            wait.Until(ExpectedConditions.ElementExists((By)ServiceSubTypeCallBack));
            Assert.IsTrue(driver.FindElement(ServiceSubTypeCallBack).Displayed);
            Thread.Sleep(3000);
            //Verify SLA timer starts from 1 days
            Thread.Sleep(2000);
            IWebElement element = driver.FindElement(SLATimer);
            string time = element.Text;
            Thread.Sleep(2000);
            Console.WriteLine(time);
            try
            {
                if (time.Contains("23h"))
                {
                    Console.WriteLine("SLA Correct");
                }
            }
            catch
            {
                Console.WriteLine("SLA incorrect");
                Assert.Fail();
            }

        }

        public void MyAccountBookRoadRequestCallBackWest()
        {
            //Verify Home dashboard is displayed
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)SiteHomepage));
            try
            {
                if (driver.FindElement(CookieBanner).Displayed)
                {
                    driver.FindElement(CookieBanner).Click();
                }
            }
            catch
            {
                Console.WriteLine("Cookie banner not shown");
            }
            //Select request skip hire on public land
            driver.FindElement(HomepageAllServicesTitle).Click();
            Actions actions = new Actions(driver);
            actions.SendKeys(Keys.PageDown).Build().Perform();
            Thread.Sleep(1000);
            actions.SendKeys(Keys.PageDown).Build().Perform();
            wait.Until(ExpectedConditions.ElementExists((By)RequestSkipPublic));
            driver.FindElement(RequestSkipPublic).Click();
            Thread.Sleep(3000);
            //Verify request skip form loads
            wait.Until(ExpectedConditions.ElementExists((By)RequestSkipPublicFormTitle));
            Assert.IsTrue(driver.FindElement(RequestSkipPublicFormTitle).Displayed);
            //Click login to my account
            wait.Until(ExpectedConditions.ElementExists((By)LoginToMyAccount));
            driver.FindElement(LoginToMyAccount).Click();
            //Click continue
            wait.Until(ExpectedConditions.ElementExists((By)LoginMyAccountContinueBtn));
            driver.FindElement(LoginMyAccountContinueBtn).Click();
            //Enter Username
            wait.Until(ExpectedConditions.ElementExists((By)LoginMyAccountUsername));
            Actions action = new Actions(driver);
            WebElement ele = (WebElement)driver.FindElement(LoginMyAccountUsername);
            action.Click(ele).Click(ele).Click(ele).Perform();
            driver.FindElement(LoginMyAccountUsername).SendKeys(Keys.Delete);
            driver.FindElement(LoginMyAccountUsername).SendKeys("ittesting@wakefield.gov.uk");
            //Enter password
            wait.Until(ExpectedConditions.ElementExists((By)LoginMyAccountPassword));
            ele = (WebElement)driver.FindElement(LoginMyAccountPassword);
            action.Click(ele).Click(ele).Click(ele).Perform();
            driver.FindElement(LoginMyAccountPassword).SendKeys(Keys.Delete);
            StreamReader streamReader = new StreamReader(@"C:\Users\garymoore\OneDrive - Wakefield Council\Desktop\MyAccountPassword.txt");
            string password = streamReader.ReadToEnd();
            driver.FindElement(LoginMyAccountPassword).SendKeys(password);
            //Click Login
            wait.Until(ExpectedConditions.ElementExists((By)LoginMyAccountLoginBtn));
            driver.FindElement(LoginMyAccountLoginBtn).Click();
            Thread.Sleep(3000);
            //verify skip form loads
            wait.Until(ExpectedConditions.ElementExists((By)RequestSkipPublicFormTitle));
            Assert.IsTrue(driver.FindElement(RequestSkipPublicFormTitle).Displayed);
            //Click edit address
            wait.Until(ExpectedConditions.ElementExists((By)EditAddressBtn));
            driver.FindElement(EditAddressBtn).Click();
            //Enter new address
            wait.Until(ExpectedConditions.ElementExists((By)SearchForAddress));
            driver.FindElement(SearchForAddress).Click();
            driver.FindElement(SearchForAddress).SendKeys("Wakefield One Burton Street Wakefield WF1 2EB");
            driver.FindElement(SearchForAddressBtn).Click();
            //Select address from list
            wait.Until(ExpectedConditions.ElementExists((By)WakefieldOneAddressOnLst));
            driver.FindElement(WakefieldOneAddressOnLst).Click();
            //Enter text into deliver instructions
            wait.Until(ExpectedConditions.ElementExists((By)DeliveryInstructionsTxtBox));
            driver.FindElement(DeliveryInstructionsTxtBox).Click();
            driver.FindElement(DeliveryInstructionsTxtBox).SendKeys("Please Deliver");
            //Select skip size
            wait.Until(ExpectedConditions.ElementExists((By)SkipSizeDropdown));
            driver.FindElement(SkipSizeDropdown).Click();
            wait.Until(ExpectedConditions.ElementExists((By)SkipSizeDropdownMidi));
            driver.FindElement(SkipSizeDropdownMidi).Click();
            //Click submit
            wait.Until(ExpectedConditions.ElementExists((By)PublicSkipSubmitBtn));
            driver.FindElement(PublicSkipSubmitBtn).Click();
            //Login to CRM test
            driver.Navigate().GoToUrl("https://wmdctest.crm11.dynamics.com/main.aspx?appid=9ad87dee-5622-ea11-a814-00224801cd38&forceUCI=1&pagetype=dashboard&id=323a6277-86e6-e911-a812-000d3a7ed30d&type=system&_canOverride=true");
            //Verify wakefield user app is displayed
            wait.Until(ExpectedConditions.ElementExists((By)WakefieldUserApp));
            Assert.IsTrue(driver.FindElement(WakefieldUserApp).Displayed);
            Thread.Sleep(3000);
            //Click cases on LHN
            wait.Until(ExpectedConditions.ElementExists((By)CasesLHN));
            Thread.Sleep(3000);
            driver.FindElement(CasesLHN).Click();
            //Click active cases
            Thread.Sleep(6000);
            wait.Until(ExpectedConditions.ElementExists((By)ActiveCasesTitle));
            Thread.Sleep(5000);
            driver.FindElement(ActiveCasesTitle).Click();
            Thread.Sleep(2000);
            //Select cases opened in last 7 days
            wait.Until(ExpectedConditions.ElementExists((By)CasesOpenedLast7Days));
            driver.FindElement(CasesOpenedLast7Days).Click();
            Thread.Sleep(10000);
            //Click case on the list
            wait.Until(ExpectedConditions.ElementExists((By)SkipHireBookingOnCaseLst));
            driver.FindElement(SkipHireBookingOnCaseLst).Click();
            Thread.Sleep(5000);
            //Verify current queue is business development default
            wait.Until(ExpectedConditions.ElementExists((By)SkipBookingsQueueBDDefault));
            Assert.IsTrue(driver.FindElement(SkipBookingsQueueBDDefault).Displayed);
            //Verify service subtype is skip hire - call back
            wait.Until(ExpectedConditions.ElementExists((By)ServiceSubTypeCallBack));
            Assert.IsTrue(driver.FindElement(ServiceSubTypeCallBack).Displayed);
            Thread.Sleep(3000);
            //Verify SLA timer starts from 1 days
            Thread.Sleep(2000);
            IWebElement element = driver.FindElement(SLATimer);
            string time = element.Text;
            Thread.Sleep(2000);
            Console.WriteLine(time);
            try
            {
                if (time.Contains("23h"))
                {
                    Console.WriteLine("SLA Correct");
                }
            }
            catch
            {
                Console.WriteLine("SLA incorrect");
                Assert.Fail();
            }

        }

        public void MyAccountBookCancelPayment()
        {
            //Verify Home dashboard is displayed
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)SiteHomepage));
            try
            {
                if (driver.FindElement(CookieBanner).Displayed)
                {
                    driver.FindElement(CookieBanner).Click();
                }
            }
            catch
            {
                Console.WriteLine("Cookie banner not shown");
            }
            //Select request skip hire on private land
            driver.FindElement(HomepageAllServicesTitle).Click();
            Actions actions = new Actions(driver);
            actions.SendKeys(Keys.PageDown).Build().Perform();
            Thread.Sleep(1000);
            actions.SendKeys(Keys.PageDown).Build().Perform();
            wait.Until(ExpectedConditions.ElementExists((By)RequestSkipPrivate));
            driver.FindElement(RequestSkipPrivate).Click();
            Thread.Sleep(3000);
            //Verify request skip form loads
            driver.WindowHandles.Last();
            wait.Until(ExpectedConditions.ElementExists((By)RequestSkipPrivateFormTitle));
            Assert.IsTrue(driver.FindElement(RequestSkipPrivateFormTitle).Displayed);
            //Click login to my account
            wait.Until(ExpectedConditions.ElementExists((By)LoginToMyAccount));
            driver.FindElement(LoginToMyAccount).Click();
            //Click continue
            wait.Until(ExpectedConditions.ElementExists((By)LoginMyAccountContinueBtn));
            driver.FindElement(LoginMyAccountContinueBtn).Click();
            //Enter Username
            wait.Until(ExpectedConditions.ElementExists((By)LoginMyAccountUsername));
            Actions action = new Actions(driver);
            WebElement ele = (WebElement)driver.FindElement(LoginMyAccountUsername);
            action.Click(ele).Click(ele).Click(ele).Perform();
            driver.FindElement(LoginMyAccountUsername).SendKeys(Keys.Delete);
            driver.FindElement(LoginMyAccountUsername).SendKeys("ittesting@wakefield.gov.uk");
            //Enter password
            wait.Until(ExpectedConditions.ElementExists((By)LoginMyAccountPassword));
            ele = (WebElement)driver.FindElement(LoginMyAccountPassword);
            action.Click(ele).Click(ele).Click(ele).Perform();
            driver.FindElement(LoginMyAccountPassword).SendKeys(Keys.Delete);
            StreamReader streamReader = new StreamReader(@"C:\Users\garymoore\OneDrive - Wakefield Council\Desktop\MyAccountPassword.txt");
            string password = streamReader.ReadToEnd();
            driver.FindElement(LoginMyAccountPassword).SendKeys(password);
            //Click Login
            wait.Until(ExpectedConditions.ElementExists((By)LoginMyAccountLoginBtn));
            driver.FindElement(LoginMyAccountLoginBtn).Click();
            Thread.Sleep(3000);
            //Enter text into deliver instructions
            wait.Until(ExpectedConditions.ElementExists((By)DeliveryInstructionsTxtBox));
            driver.FindElement(DeliveryInstructionsTxtBox).Click();
            driver.FindElement(DeliveryInstructionsTxtBox).SendKeys("Please Deliver");
            //Select skip size
            wait.Until(ExpectedConditions.ElementExists((By)SkipSizeDropdown));
            driver.FindElement(SkipSizeDropdown).Click();
            wait.Until(ExpectedConditions.ElementExists((By)SkipSizeDropdownMidi));
            driver.FindElement(SkipSizeDropdownMidi).Click();
            driver.FindElement(DeliveryInstructionsTxtBox).Click();
            actions = new Actions(driver);
            actions.SendKeys(Keys.PageDown).Build().Perform();
            Thread.Sleep(10000);
            //Select delivery date
            wait.Until(ExpectedConditions.ElementExists((By)SkipDeliveryDate));
            driver.FindElement(SkipDeliveryDate).Click();
            wait.Until(ExpectedConditions.ElementExists((By)SkipDeliveryDateYear));
            driver.FindElement(SkipDeliveryDateYear).Click();
            wait.Until(ExpectedConditions.ElementExists((By)SkipDeliveryDateYear2023));
            driver.FindElement(SkipDeliveryDateYear2023).Click();
            wait.Until(ExpectedConditions.ElementExists((By)SkipDeliveryAvailableDate));
            driver.FindElement(SkipDeliveryAvailableDate).Click();
            Thread.Sleep(5000);
            //Select collection date
            wait.Until(ExpectedConditions.ElementExists((By)SkipCollectionDate));
            driver.FindElement(SkipCollectionDate).Click();
            wait.Until(ExpectedConditions.ElementExists((By)SkipCollectionAvailableDate));
            driver.FindElement(SkipCollectionAvailableDate).Click();
            //Click yes to t&c's
            wait.Until(ExpectedConditions.ElementExists((By)TermsYesBtn));
            driver.FindElement(TermsYesBtn).Click();
            //Click go to payments
            wait.Until(ExpectedConditions.ElementExists((By)GoToPaymentsBtn));
            driver.FindElement(GoToPaymentsBtn).Click();
            //Verify skip price is correct
            wait.Until(ExpectedConditions.ElementExists((By)SkipHireBookingOnPaymentPage));
            Assert.IsTrue(driver.FindElement(SkipPrice).Displayed);
            //Click cancel
            wait.Until(ExpectedConditions.ElementExists((By)CancelPaymentsBtn));
            driver.FindElement(CancelPaymentsBtn).Click();
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)ConfirmCancelPaymentsBtn));
            driver.FindElement(ConfirmCancelPaymentsBtn).Click();
            Thread.Sleep(10000);
            //Login to CRM test
            driver.Navigate().GoToUrl("https://wmdctest.crm11.dynamics.com/main.aspx?appid=9ad87dee-5622-ea11-a814-00224801cd38&forceUCI=1&pagetype=dashboard&id=323a6277-86e6-e911-a812-000d3a7ed30d&type=system&_canOverride=true");
            //Verify wakefield user app is displayed
            wait.Until(ExpectedConditions.ElementExists((By)WakefieldUserApp));
            Assert.IsTrue(driver.FindElement(WakefieldUserApp).Displayed);
            //Click cases on LHN
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)CasesLHN));
            Thread.Sleep(3000);
            driver.FindElement(CasesLHN).Click();
            //Click active cases
            Thread.Sleep(10000);
            wait.Until(ExpectedConditions.ElementExists((By)ActiveCasesTitle));
            Thread.Sleep(3000);
            driver.FindElement(ActiveCasesTitle).Click();
            Thread.Sleep(2000);
            //Select cases opened in last 7 days
            wait.Until(ExpectedConditions.ElementExists((By)CasesOpenedLast7Days));
            driver.FindElement(CasesOpenedLast7Days).Click();
            Thread.Sleep(3000);
            //Click case on the list
            wait.Until(ExpectedConditions.ElementExists((By)SkipHireBookingOnCaseLst));
            driver.FindElement(SkipHireBookingOnCaseLst).Click();
            Thread.Sleep(5000);
            //Verify payment shows as cancelled
            wait.Until(ExpectedConditions.ElementExists((By)PaymentStatusCancelled));
            Assert.IsTrue(driver.FindElement(PaymentStatusCancelled).Displayed);
            //Verify current queue is empty
            wait.Until(ExpectedConditions.ElementExists((By)SkipBookingsQueueEmpty));
            Assert.IsTrue(driver.FindElement(SkipBookingsQueueEmpty).Displayed);
            //Click skip hire booking form
            wait.Until(ExpectedConditions.ElementExists((By)SkipHireBookingFormLink));
            driver.FindElement(SkipHireBookingFormLink).Click();
            Thread.Sleep(3000);
            //Verify payment shows as Incomplete
            wait.Until(ExpectedConditions.ElementExists((By)ServiceDetailsTitle));
            driver.FindElement(ServiceDetailsTitle).Click();
            actions = new Actions(driver);
            actions.SendKeys(Keys.PageDown).Build().Perform();
            Thread.Sleep(1000);
            actions = new Actions(driver);
            actions.SendKeys(Keys.PageDown).Build().Perform();
            Thread.Sleep(1000);
            actions = new Actions(driver);
            actions.SendKeys(Keys.PageDown).Build().Perform();
            wait.Until(ExpectedConditions.ElementExists((By)PaymentStatusCancelled));
            Assert.IsTrue(driver.FindElement(PaymentStatusCancelled).Displayed);

        }

        public void AdminTCCallBack()
        {
            //Verify Home dashboard is displayed
            Thread.Sleep(4000);
            wait.Until(ExpectedConditions.ElementExists((By)DashboardsLHN));
            driver.FindElement(DashboardsLHN).Click();
            wait.Until(ExpectedConditions.ElementExists((By)DashboardTitle));
            Assert.IsTrue(driver.FindElement(DashboardTitle).Displayed);
            Thread.Sleep(3000);
            //Click queues on LHN
            wait.Until(ExpectedConditions.ElementExists((By)QueuesLHN));
            driver.FindElement(QueuesLHN).Click();
            //Click queues dropdown
            Thread.Sleep(6000);
            wait.Until(ExpectedConditions.ElementExists((By)QueuesDropdown));
            driver.FindElement(QueuesDropdown).Click();
            Thread.Sleep(2000);
            //Select all cases in selected queues
            wait.Until(ExpectedConditions.ElementExists((By)SelectedQueuesOnDropdown));
            driver.FindElement(SelectedQueuesOnDropdown).Click();
            Thread.Sleep(2000);
            //Filter resource title
            wait.Until(ExpectedConditions.ElementExists((By)QueueTitleFilter));
            driver.FindElement(QueueTitleFilter).Click();
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)ResourceTitleFilterBy));
            driver.FindElement(ResourceTitleFilterBy).Click();
            Thread.Sleep(2000);
            //Change search parameter to contains
            wait.Until(ExpectedConditions.ElementExists((By)EqualsFilterParameter));
            driver.FindElement(EqualsFilterParameter).Click();
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementExists((By)ContainsFilterParameter));
            driver.FindElement(ContainsFilterParameter).Click();
            Thread.Sleep(2000);
            //Enter service subtype in box
            wait.Until(ExpectedConditions.ElementExists((By)QueueFilterBy));
            driver.FindElement(QueueFilterBy).Click();
            driver.FindElement(QueueFilterBy).SendKeys("Call Back");
            Thread.Sleep(5000);
            //Click apply
            wait.Until(ExpectedConditions.ElementExists((By)QueueTitleFilterApply));
            driver.FindElement(QueueTitleFilterApply).Click();
            Thread.Sleep(2000);
            //Verify correct sub service is displayed and click it
            wait.Until(ExpectedConditions.ElementExists((By)CallBackTCOnTable));
            Assert.IsTrue(driver.FindElement(CallBackTCOnTable).Displayed);
            //Click top record
            Thread.Sleep(3000);
            driver.FindElement(CallBackTCOnTable).Click();
            //Click pick in the ribbon
            wait.Until(ExpectedConditions.ElementExists((By)PickOnRibbon));
            driver.FindElement(PickOnRibbon).Click();
            Thread.Sleep(2000);
            //select no on remove items from queue
            wait.Until(ExpectedConditions.ElementExists((By)PickWindowDropdown));
            driver.FindElement(PickWindowDropdown).Click();
            Thread.Sleep(2000);
            driver.FindElement(PickWindowDropdownNo).Click();
            //Click pick
            wait.Until(ExpectedConditions.ElementExists((By)PickWindowPickBtn));
            driver.FindElement(PickWindowPickBtn).Click();
            Thread.Sleep(3000);
            //Verify name is now shown in worked by column
            wait.Until(ExpectedConditions.ElementExists((By)NameInWorkedByColumn));
            Assert.IsTrue(driver.FindElement(NameInWorkedByColumn).Displayed);
            //Open record
            Thread.Sleep(3000);
            Actions action = new Actions(driver);
            WebElement ele = (WebElement)driver.FindElement(CallBackTCOnTable);
            action.Click(ele).Click(ele).Perform();
            //Click skip hire booking
            wait.Until(ExpectedConditions.ElementExists((By)SkipHireBookingLink));
            Thread.Sleep(2000);
            driver.FindElement(SkipHireBookingLink).Click();
            //Verify form loads
            wait.Until(ExpectedConditions.ElementExists((By)CaseDetailsTitle));
            Assert.IsTrue(driver.FindElement(CaseDetailsTitle).Displayed);
            //Click back button
            wait.Until(ExpectedConditions.ElementExists((By)BackButtonOnSkipHireForm));
            Thread.Sleep(2000);
            driver.FindElement(BackButtonOnSkipHireForm).Click();
            //Click mark complete
            wait.Until(ExpectedConditions.ElementExists((By)MarkComplete));
            Thread.Sleep(2000);
            driver.FindElement(MarkComplete).Click();

        }
    }
}
