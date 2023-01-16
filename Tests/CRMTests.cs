using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using CRMRegressionPack.PageObjects;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using System.Net;

namespace CRMRegressionPack.Tests
{
   // [Parallelizable(ParallelScope.All)]
    public class CRMTests : BaseTest
    {
        ExtentReports extent = null;

        [OneTimeSetUp]
        public void ExtentStart()
        {
            extent = new ExtentReports();
        //    var htmlReporter = new ExtentHtmlReporter(@"C:\Users\garymoore\OneDrive - Wakefield Council\Desktop\CRMRegressionPack\CRMRegressionPack\Reports\"); extent.AttachReporter(htmlReporter);
            string hostname = Dns.GetHostName();

            OperatingSystem os = Environment.OSVersion;
            string Browser = targetBrowser.ToString();

            extent.AddSystemInfo("Operating System:", os.ToString());
            extent.AddSystemInfo("HostName:", hostname);
            extent.AddSystemInfo("Browser:", Browser);
            extent.AddSystemInfo("Test Category:", "Selenium");
            extent.AddSystemInfo("Project:", "CRM");
            extent.AddSystemInfo("Test Type", "Regression");

        }

        [OneTimeTearDown]
        public void ExtentClose()
        {
            extent.Flush();
            DateTime dateTime = DateTime.Now;
            var FileDate = dateTime.ToString("dd_MM_yy-HH_mm_ss");
         //   System.IO.File.Move(@"C:\Users\garymoore\OneDrive - Wakefield Council\Desktop\CRMRegressionPack\CRMRegressionPack\Reports\index.html", @"C:\Users\garymoore\OneDrive - Wakefield Council\Desktop\CRMRegressionPack\CRMRegressionPack\Reports\" + "ExtentReport-" + FileDate + ".html");
        }
        public CRMTests(string browser)
            : base(browser)
        {

        }
        
        [Test, Retry(3)]
        [Category("Selenium")]
        public void Test_Dashboards_VerifyTitle()
        {
            using (var driver = InitialiseDriver())
            {
                ExtentTest test = null;
                try
                {
                    test = extent.CreateTest("Test_Dashboards_VerifyTitle").Info("<div style= 'color:blue; font-weight:bold'>Test Started");
                    DynamicsLogin dynamicsLogin = new DynamicsLogin(driver);
                    dynamicsLogin.LoginWindow();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Dynamics account selected");

                    Dashboards dashboards = new Dashboards(driver);
                    dashboards.VerifyPageTitle();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'> Homepage Title verified");
                }
                catch (Exception e)
                {
                    Assert.Fail(e.StackTrace);
                }
                finally
                {
                    commonUtils.PrintLogs("browser", driver);

                    if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
                    {
                        string fileName = @"C:\Users\garymoore\OneDrive - Wakefield Council\Desktop\CRMRegressionPack\CRMRegressionPack\Screenshots\" + DateTime.Now.ToString("dd_MM_yy -HH_mm_ss") + ".Png";
                        Screenshot cp = ((ITakesScreenshot)driver).GetScreenshot();
                        cp.SaveAsFile(fileName, ScreenshotImageFormat.Png);
                        test.AddScreenCaptureFromPath(fileName);
                        test.Info(driver.Url);
                        test.Info(Environment.StackTrace.Replace(Environment.NewLine, "<br>"));
                        test.Log(Status.Fail, "<div style= 'color:red; font-weight:bold'>Test_Dashboards_VerifyPageTitle FAILED");
                    }
                    else if (TestContext.CurrentContext.Result.Outcome.Status != TestStatus.Failed)
                    {
                        test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Test_Dashboards_VerifyPageTitle PASSED");
                    }
                }
            }
        }

        [Test, Retry(3)]
        [Category("Selenium")]
        public void Test_Dashboards_EditCustomerFromSearch()
        {
            using (var driver = InitialiseDriver())
            {
                ExtentTest test = null;
                try
                {
                    test = extent.CreateTest("Test_Dashboards_EditCustomerFromSearch").Info("<div style= 'color:blue; font-weight:bold'>Test Started");
                    DynamicsLogin dynamicsLogin = new DynamicsLogin(driver);
                    dynamicsLogin.LoginWindow();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Dynamics account selected");

                    DataClearup dataClearup = new DataClearup(driver);
                    dataClearup.ClearDataCustomer();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Leftover customer data cleared successfully");

                    Dashboards dashboards = new Dashboards(driver);
                    dashboards.EditCustomerFromSearch();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'> Customer successfully edited from search");


                }
                catch (Exception e)
                {
                    Assert.Fail(e.StackTrace);
                }
                finally
                {
                    commonUtils.PrintLogs("browser", driver);

                    if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
                    {
                        string fileName = @"C:\Users\garymoore\OneDrive - Wakefield Council\Desktop\CRMRegressionPack\CRMRegressionPack\Screenshots\" + DateTime.Now.ToString("dd_MM_yy -HH_mm_ss") + ".Png";
                        Screenshot cp = ((ITakesScreenshot)driver).GetScreenshot();
                        cp.SaveAsFile(fileName, ScreenshotImageFormat.Png);
                        test.AddScreenCaptureFromPath(fileName);
                        test.Info(driver.Url);
                        test.Info(Environment.StackTrace.Replace(Environment.NewLine, "<br>"));
                        test.Log(Status.Fail, "<div style= 'color:red; font-weight:bold'>Test_Dashboards_EditCustomerFromSearch FAILED");
                    }
                    else if (TestContext.CurrentContext.Result.Outcome.Status != TestStatus.Failed)
                    {
                        test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Test_Dashboards_EditCustomerFromSearch PASSED");
                    }
                }
            }
        }

        [Test, Retry(3)]
        [Category("Selenium")]
        public void Test_Dashboards_SearchFAQ()
        {
            using (var driver = InitialiseDriver())
            {
                ExtentTest test = null;
                try
                {
                    test = extent.CreateTest("Test_Dashboards_SearchFAQ").Info("<div style= 'color:blue; font-weight:bold'>Test Started");
                    DynamicsLogin dynamicsLogin = new DynamicsLogin(driver);
                    dynamicsLogin.LoginWindow();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Dynamics account selected");

                    Dashboards dashboards = new Dashboards(driver);
                    dashboards.SearchFAQ();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'> Customer successfully searched FAQ's");
                }
                catch (Exception e)
                {
                    Assert.Fail(e.StackTrace);
                }
                finally
                {
                    commonUtils.PrintLogs("browser", driver);

                    if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
                    {
                        string fileName = @"C:\Users\garymoore\OneDrive - Wakefield Council\Desktop\CRMRegressionPack\CRMRegressionPack\Screenshots\" + DateTime.Now.ToString("dd_MM_yy -HH_mm_ss") + ".Png";
                        Screenshot cp = ((ITakesScreenshot)driver).GetScreenshot();
                        cp.SaveAsFile(fileName, ScreenshotImageFormat.Png);
                        test.AddScreenCaptureFromPath(fileName);
                        test.Info(driver.Url);
                        test.Info(Environment.StackTrace.Replace(Environment.NewLine, "<br>"));
                        test.Log(Status.Fail, "<div style= 'color:red; font-weight:bold'>Test_Dashboards_SearchFAQ FAILED");
                    }
                    else if (TestContext.CurrentContext.Result.Outcome.Status != TestStatus.Failed)
                    {
                        test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Test_Dashboards_SearchFAQ PASSED");
                    }
                }
            }
        }
        
        [Test, Retry(3)]
        [Category("Selenium")]
        public void Test_Dashboards_SearchServices()
        {
            using (var driver = InitialiseDriver())
            {
                ExtentTest test = null;
                try
                {
                    test = extent.CreateTest("Test_Dashboards_SearchService").Info("<div style= 'color:blue; font-weight:bold'>Test Started");
                    DynamicsLogin dynamicsLogin = new DynamicsLogin(driver);
                    dynamicsLogin.LoginWindow();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Dynamics account selected");

                    Dashboards dashboards = new Dashboards(driver);
                    dashboards.SearchServices();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'> Customer successfully searched Services");
                }
                catch (Exception e)
                {
                    Assert.Fail(e.StackTrace);
                }
                finally
                {
                    commonUtils.PrintLogs("browser", driver);

                    if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
                    {
                        string fileName = @"C:\Users\garymoore\OneDrive - Wakefield Council\Desktop\CRMRegressionPack\CRMRegressionPack\Screenshots\" + DateTime.Now.ToString("dd_MM_yy -HH_mm_ss") + ".Png";
                        Screenshot cp = ((ITakesScreenshot)driver).GetScreenshot();
                        cp.SaveAsFile(fileName, ScreenshotImageFormat.Png);
                        test.AddScreenCaptureFromPath(fileName);
                        test.Info(driver.Url);
                        test.Info(Environment.StackTrace.Replace(Environment.NewLine, "<br>"));
                        test.Log(Status.Fail, "<div style= 'color:red; font-weight:bold'>Test_Dashboards_SearchServices FAILED");
                    }
                    else if (TestContext.CurrentContext.Result.Outcome.Status != TestStatus.Failed)
                    {
                        test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Test_Dashboards_SearchServices PASSED");
                    }
                }
            }
        }

        [Test, Retry(3)]
        [Category("Selenium")]
        public void Test_Dashboards_SearchUsers()
        {
            using (var driver = InitialiseDriver())
            {
                ExtentTest test = null;
                try
                {
                    test = extent.CreateTest("Test_Dashboards_SearchUsers").Info("<div style= 'color:blue; font-weight:bold'>Test Started");
                    DynamicsLogin dynamicsLogin = new DynamicsLogin(driver);
                    dynamicsLogin.LoginWindow();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Dynamics account selected");

                    Dashboards dashboards = new Dashboards(driver);
                    dashboards.SearchUsers();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>User successfully searched for customer and business");
                }
                catch (Exception e)
                {
                    Assert.Fail(e.StackTrace);
                }
                finally
                {
                    commonUtils.PrintLogs("browser", driver);

                    if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
                    {
                        string fileName = @"C:\Users\garymoore\OneDrive - Wakefield Council\Desktop\CRMRegressionPack\CRMRegressionPack\Screenshots\" + DateTime.Now.ToString("dd_MM_yy -HH_mm_ss") + ".Png";
                        Screenshot cp = ((ITakesScreenshot)driver).GetScreenshot();
                        cp.SaveAsFile(fileName, ScreenshotImageFormat.Png);
                        test.AddScreenCaptureFromPath(fileName);
                        test.Info(driver.Url);
                        test.Info(Environment.StackTrace.Replace(Environment.NewLine, "<br>"));
                        test.Log(Status.Fail, "<div style= 'color:red; font-weight:bold'>Test_Dashboards_SearchUsers FAILED");
                    }
                    else if (TestContext.CurrentContext.Result.Outcome.Status != TestStatus.Failed)
                    {
                        test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Test_Dashboards_SearchUsers PASSED");
                    }
                }
            }
        }
        
        [Test, Retry(3)]
        [Category("Selenium")]
        public void Test_Dashboards_SearchAnonUsers()
        {
            using (var driver = InitialiseDriver())
            {
                ExtentTest test = null;
                try
                {
                    test = extent.CreateTest("Test_Dashboards_SearchAnonUsers").Info("<div style= 'color:blue; font-weight:bold'>Test Started");
                    DynamicsLogin dynamicsLogin = new DynamicsLogin(driver);
                    dynamicsLogin.LoginWindow();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Dynamics account selected");

                    Dashboards dashboards = new Dashboards(driver);
                    dashboards.SearchUsersUnknownAddress();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'> User successfully searched for customer with unknown address");
                }
                catch (Exception e)
                {
                    Assert.Fail(e.StackTrace);
                }
                finally
                {
                    commonUtils.PrintLogs("browser", driver);

                    if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
                    {
                        string fileName = @"C:\Users\garymoore\OneDrive - Wakefield Council\Desktop\CRMRegressionPack\CRMRegressionPack\Screenshots\" + DateTime.Now.ToString("dd_MM_yy -HH_mm_ss") + ".Png";
                        Screenshot cp = ((ITakesScreenshot)driver).GetScreenshot();
                        cp.SaveAsFile(fileName, ScreenshotImageFormat.Png);
                        test.AddScreenCaptureFromPath(fileName);
                        test.Info(driver.Url);
                        test.Info(Environment.StackTrace.Replace(Environment.NewLine, "<br>"));
                        test.Log(Status.Fail, "<div style= 'color:red; font-weight:bold'>Test_Dashboards_SearchAnonUsers FAILED");
                    }
                    else if (TestContext.CurrentContext.Result.Outcome.Status != TestStatus.Failed)
                    {
                        test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Test_Dashboards_SearchAnonUsers PASSED");
                    }
                }
            }
        }

        [Test, Retry(3)]
        [Category("Selenium")]
        public void Test_Dashboards_SearchUsersManualAddress()
        {
            using (var driver = InitialiseDriver())
            {
                ExtentTest test = null;
                try
                {
                    test = extent.CreateTest("Test_Dashboards_SearchUsersManualAddress").Info("<div style= 'color:blue; font-weight:bold'>Test Started");
                    DynamicsLogin dynamicsLogin = new DynamicsLogin(driver);
                    dynamicsLogin.LoginWindow();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Dynamics account selected");

                    Dashboards dashboards = new Dashboards(driver);
                    dashboards.SearchUsersManualAddress();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'> User successfully searched for customer with manual address");
                }
                catch (Exception e)
                {
                    Assert.Fail(e.StackTrace);
                }
                finally
                {
                    commonUtils.PrintLogs("browser", driver);

                    if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
                    {
                        string fileName = @"C:\Users\garymoore\OneDrive - Wakefield Council\Desktop\CRMRegressionPack\CRMRegressionPack\Screenshots\" + DateTime.Now.ToString("dd_MM_yy -HH_mm_ss") + ".Png";
                        Screenshot cp = ((ITakesScreenshot)driver).GetScreenshot();
                        cp.SaveAsFile(fileName, ScreenshotImageFormat.Png);
                        test.AddScreenCaptureFromPath(fileName);
                        test.Info(driver.Url);
                        test.Info(Environment.StackTrace.Replace(Environment.NewLine, "<br>"));
                        test.Log(Status.Fail, "<div style= 'color:red; font-weight:bold'>Test_Dashboards_SearchUsersManualAddress FAILED");
                    }
                    else if (TestContext.CurrentContext.Result.Outcome.Status != TestStatus.Failed)
                    {
                        test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Test_Dashboards_SearchUsersManualAddress PASSED");
                    }
                }
            }
        }

        [Test, Retry(3)]
        [Category("Selenium")]
        public void Test_Dashboards_CreateCustomerFromSearch()
        {
            using (var driver = InitialiseDriver())
            {
                ExtentTest test = null;
                try
                {
                    test = extent.CreateTest("Test_Dashboards_CreateCustomerFromSearch").Info("<div style= 'color:blue; font-weight:bold'>Test Started");
                    DynamicsLogin dynamicsLogin = new DynamicsLogin(driver);
                    dynamicsLogin.LoginWindow();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Dynamics account selected");

                    DataClearup dataClearup = new DataClearup(driver);
                    dataClearup.ClearDataCustomer();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Leftover customer data cleared successfully");

                    Dashboards dashboards = new Dashboards(driver);
                    dashboards.CreateCustomerFromSearch();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'> User successfully created from search");
                }
                catch (Exception e)
                {
                    Assert.Fail(e.StackTrace);
                }
                finally
                {
                    commonUtils.PrintLogs("browser", driver);

                    if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
                    {
                        string fileName = @"C:\Users\garymoore\OneDrive - Wakefield Council\Desktop\CRMRegressionPack\CRMRegressionPack\Screenshots\" + DateTime.Now.ToString("dd_MM_yy -HH_mm_ss") + ".Png";
                        Screenshot cp = ((ITakesScreenshot)driver).GetScreenshot();
                        cp.SaveAsFile(fileName, ScreenshotImageFormat.Png);
                        test.AddScreenCaptureFromPath(fileName);
                        test.Info(driver.Url);
                        test.Info(Environment.StackTrace.Replace(Environment.NewLine, "<br>"));
                        test.Log(Status.Fail, "<div style= 'color:red; font-weight:bold'>Test_Dashboards_CreateCustomerFromSearch FAILED");
                    }
                    else if (TestContext.CurrentContext.Result.Outcome.Status != TestStatus.Failed)
                    {
                        test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Test_Dashboards_CreateCustomerFromSearch PASSED");
                    }
                }
            }
        }

        [Test, Retry(3)]
        [Category("Selenium")]
        public void Test_Dashboards_CreateCaseAnonCustomer()
        {
            using (var driver = InitialiseDriver())
            {
                ExtentTest test = null;
                try
                {
                    test = extent.CreateTest("Test_Dashboards_CreateCaseAnonCustomer").Info("<div style= 'color:blue; font-weight:bold'>Test Started");
                    DynamicsLogin dynamicsLogin = new DynamicsLogin(driver);
                    dynamicsLogin.LoginWindow();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Dynamics account selected");

                    DataClearup dataClearup = new DataClearup(driver);
                    dataClearup.ClearDataCustomer();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Leftover customer data cleared successfully");

                    Dashboards dashboards = new Dashboards(driver);
                    dashboards.CreateCaseAnonCustomer();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'> Case successfully created for anonymous customer");
                }
                catch (Exception e)
                {
                    Assert.Fail(e.StackTrace);
                }
                finally
                {
                    commonUtils.PrintLogs("browser", driver);

                    if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
                    {
                        string fileName = @"C:\Users\garymoore\OneDrive - Wakefield Council\Desktop\CRMRegressionPack\CRMRegressionPack\Screenshots\" + DateTime.Now.ToString("dd_MM_yy -HH_mm_ss") + ".Png";
                        Screenshot cp = ((ITakesScreenshot)driver).GetScreenshot();
                        cp.SaveAsFile(fileName, ScreenshotImageFormat.Png);
                        test.AddScreenCaptureFromPath(fileName);
                        test.Info(driver.Url);
                        test.Info(Environment.StackTrace.Replace(Environment.NewLine, "<br>"));
                        test.Log(Status.Fail, "<div style= 'color:red; font-weight:bold'>Test_Dashboards_CreateCaseAnonCustomer FAILED");
                    }
                    else if (TestContext.CurrentContext.Result.Outcome.Status != TestStatus.Failed)
                    {
                        test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Test_Dashboards_CreateCaseAnonCustomer PASSED");
                    }
                }
            }
        }

        [Test, Retry(3)]
        [Category("Selenium")]
        public void Test_Dashboards_BinCollection()
        {
            using (var driver = InitialiseDriver())
            {
                ExtentTest test = null;
                try
                {
                    test = extent.CreateTest("Test_Dashboards_BinCollection").Info("<div style= 'color:blue; font-weight:bold'>Test Started");
                    DynamicsLogin dynamicsLogin = new DynamicsLogin(driver);
                    dynamicsLogin.LoginWindow();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Dynamics account selected");

                    Dashboards dashboards = new Dashboards(driver);
                    dashboards.BinCollection();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Bin collection information displayed correctly");
                }
                catch (Exception e)
                {
                    Assert.Fail(e.StackTrace);
                }
                finally
                {
                    commonUtils.PrintLogs("browser", driver);

                    if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
                    {
                        string fileName = @"C:\Users\garymoore\OneDrive - Wakefield Council\Desktop\CRMRegressionPack\CRMRegressionPack\Screenshots\" + DateTime.Now.ToString("dd_MM_yy -HH_mm_ss") + ".Png";
                        Screenshot cp = ((ITakesScreenshot)driver).GetScreenshot();
                        cp.SaveAsFile(fileName, ScreenshotImageFormat.Png);
                        test.AddScreenCaptureFromPath(fileName);
                        test.Info(driver.Url);
                        test.Info(Environment.StackTrace.Replace(Environment.NewLine, "<br>"));
                        test.Log(Status.Fail, "<div style= 'color:red; font-weight:bold'>Test_Dashboards_BinCollection FAILED");
                    }
                    else if (TestContext.CurrentContext.Result.Outcome.Status != TestStatus.Failed)
                    {
                        test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Test_Dashboards_BinCollection PASSED");
                    }
                }
            }
        }

        [Test, Retry(3)]
        [Category("Selenium")]
        public void Test_Dashboards_OnBehalfOf()
        {
            using (var driver = InitialiseDriver())
            {
                ExtentTest test = null;
                try
                {
                    test = extent.CreateTest("Test_Dashboards_OnBehalfOf").Info("<div style= 'color:blue; font-weight:bold'>Test Started");
                    DynamicsLogin dynamicsLogin = new DynamicsLogin(driver);
                    dynamicsLogin.LoginWindow();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Dynamics account selected");

                    Dashboards dashboards = new Dashboards(driver);
                    dashboards.OnBehalfOf();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Case reporting on behalf of another customer working correctly");
                }
                catch (Exception e)
                {
                    Assert.Fail(e.StackTrace);
                }
                finally
                {
                    commonUtils.PrintLogs("browser", driver);

                    if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
                    {
                        string fileName = @"C:\Users\garymoore\OneDrive - Wakefield Council\Desktop\CRMRegressionPack\CRMRegressionPack\Screenshots\" + DateTime.Now.ToString("dd_MM_yy -HH_mm_ss") + ".Png";
                        Screenshot cp = ((ITakesScreenshot)driver).GetScreenshot();
                        cp.SaveAsFile(fileName, ScreenshotImageFormat.Png);
                        test.AddScreenCaptureFromPath(fileName);
                        test.Info(driver.Url);
                        test.Info(Environment.StackTrace.Replace(Environment.NewLine, "<br>"));
                        test.Log(Status.Fail, "<div style= 'color:red; font-weight:bold'>Test_Dashboards_OnBehalfOf FAILED");
                    }
                    else if (TestContext.CurrentContext.Result.Outcome.Status != TestStatus.Failed)
                    {
                        test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Test_Dashboards_OnBehalfOf PASSED");
                    }
                }
            }
        }

        [Test, Retry(3)]
        [Category("Selenium")]
        public void Test_Dashboards_OnBehalfOfBusiness()
        {
            using (var driver = InitialiseDriver())
            {
                ExtentTest test = null;
                try
                {
                    test = extent.CreateTest("Test_Dashboards_OnBehalfOfBusiness").Info("<div style= 'color:blue; font-weight:bold'>Test Started");
                    DynamicsLogin dynamicsLogin = new DynamicsLogin(driver);
                    dynamicsLogin.LoginWindow();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Dynamics account selected");

                    Dashboards dashboards = new Dashboards(driver);
                    dashboards.OnBehalfOfBusiness();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Case reporting on behalf of another business working correctly");
                }
                catch (Exception e)
                {
                    Assert.Fail(e.StackTrace);
                }
                finally
                {
                    commonUtils.PrintLogs("browser", driver);

                    if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
                    {
                        string fileName = @"C:\Users\garymoore\OneDrive - Wakefield Council\Desktop\CRMRegressionPack\CRMRegressionPack\Screenshots\" + DateTime.Now.ToString("dd_MM_yy -HH_mm_ss") + ".Png";
                        Screenshot cp = ((ITakesScreenshot)driver).GetScreenshot();
                        cp.SaveAsFile(fileName, ScreenshotImageFormat.Png);
                        test.AddScreenCaptureFromPath(fileName);
                        test.Info(driver.Url);
                        test.Info(Environment.StackTrace.Replace(Environment.NewLine, "<br>"));
                        test.Log(Status.Fail, "<div style= 'color:red; font-weight:bold'>Test_Dashboards_OnBehalfOfBusiness FAILED");
                    }
                    else if (TestContext.CurrentContext.Result.Outcome.Status != TestStatus.Failed)
                    {
                        test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Test_Dashboards_OnBehalfOfBusiness PASSED");
                    }
                }
            }
        }

        [Test, Retry(3)]
        [Category("Selenium")]
        public void Test_Dashboards_SearchFAQOnBehalfOf()
        {
            using (var driver = InitialiseDriver())
            {
                ExtentTest test = null;
                try
                {
                    test = extent.CreateTest("Test_Dashboards_SearchFAQOnBehalfOf").Info("<div style= 'color:blue; font-weight:bold'>Test Started");
                    DynamicsLogin dynamicsLogin = new DynamicsLogin(driver);
                    dynamicsLogin.LoginWindow();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Dynamics account selected");

                    Dashboards dashboards = new Dashboards(driver);
                    dashboards.SearchFAQOnBehalfOf();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>FAQ search on behalf of another customer working correctly");
                }
                catch (Exception e)
                {
                    Assert.Fail(e.StackTrace);
                }
                finally
                {
                    commonUtils.PrintLogs("browser", driver);

                    if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
                    {
                        string fileName = @"C:\Users\garymoore\OneDrive - Wakefield Council\Desktop\CRMRegressionPack\CRMRegressionPack\Screenshots\" + DateTime.Now.ToString("dd_MM_yy -HH_mm_ss") + ".Png";
                        Screenshot cp = ((ITakesScreenshot)driver).GetScreenshot();
                        cp.SaveAsFile(fileName, ScreenshotImageFormat.Png);
                        test.AddScreenCaptureFromPath(fileName);
                        test.Info(driver.Url);
                        test.Info(Environment.StackTrace.Replace(Environment.NewLine, "<br>"));
                        test.Log(Status.Fail, "<div style= 'color:red; font-weight:bold'>Test_Dashboards_SearchFAQOnBehalfOf FAILED");
                    }
                    else if (TestContext.CurrentContext.Result.Outcome.Status != TestStatus.Failed)
                    {
                        test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Test_Dashboards_SearchFAQOnBehalfOf PASSED");
                    }
                }
            }
        }

        [Test, Retry(3)]
        [Category("Selenium")]
        public void Test_Dashboards_BusinessSearchFAQOnBehalfOf()
        {
            using (var driver = InitialiseDriver())
            {
                ExtentTest test = null;
                try
                {
                    test = extent.CreateTest("Test_Dashboards_BusinessSearchFAQOnBehalfOf").Info("<div style= 'color:blue; font-weight:bold'>Test Started");
                    DynamicsLogin dynamicsLogin = new DynamicsLogin(driver);
                    dynamicsLogin.LoginWindow();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Dynamics account selected");

                    Dashboards dashboards = new Dashboards(driver);
                    dashboards.BusinessSearchFAQOnBehalfOf();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>FAQ search on behalf of another business working correctly");
                }
                catch (Exception e)
                {
                    Assert.Fail(e.StackTrace);
                }
                finally
                {
                    commonUtils.PrintLogs("browser", driver);

                    if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
                    {
                        string fileName = @"C:\Users\garymoore\OneDrive - Wakefield Council\Desktop\CRMRegressionPack\CRMRegressionPack\Screenshots\" + DateTime.Now.ToString("dd_MM_yy -HH_mm_ss") + ".Png";
                        Screenshot cp = ((ITakesScreenshot)driver).GetScreenshot();
                        cp.SaveAsFile(fileName, ScreenshotImageFormat.Png);
                        test.AddScreenCaptureFromPath(fileName);
                        test.Info(driver.Url);
                        test.Info(Environment.StackTrace.Replace(Environment.NewLine, "<br>"));
                        test.Log(Status.Fail, "<div style= 'color:red; font-weight:bold'>Test_Dashboards_BusinessSearchFAQOnBehalfOf FAILED");
                    }
                    else if (TestContext.CurrentContext.Result.Outcome.Status != TestStatus.Failed)
                    {
                        test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Test_Dashboards_BusinessSearchFAQOnBehalfOf PASSED");
                    }
                }
            }
        }

        [Test, Retry(3)]
        [Category("Selenium")]
        public void Test_Dashboards_PreviousBusinessHistory()
        {
            using (var driver = InitialiseDriver())
            {
                ExtentTest test = null;
                try
                {
                    test = extent.CreateTest("Test_Dashboards_PreviousBusinessHistory").Info("<div style= 'color:blue; font-weight:bold'>Test Started");
                    DynamicsLogin dynamicsLogin = new DynamicsLogin(driver);
                    dynamicsLogin.LoginWindow();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Dynamics account selected");

                    Dashboards dashboards = new Dashboards(driver);
                    dashboards.PreviousBusinessHistory();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Previous address functionality correct for business account");
                }
                catch (Exception e)
                {
                    Assert.Fail(e.StackTrace);
                }
                finally
                {
                    commonUtils.PrintLogs("browser", driver);

                    if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
                    {
                        string fileName = @"C:\Users\garymoore\OneDrive - Wakefield Council\Desktop\CRMRegressionPack\CRMRegressionPack\Screenshots\" + DateTime.Now.ToString("dd_MM_yy -HH_mm_ss") + ".Png";
                        Screenshot cp = ((ITakesScreenshot)driver).GetScreenshot();
                        cp.SaveAsFile(fileName, ScreenshotImageFormat.Png);
                        test.AddScreenCaptureFromPath(fileName);
                        test.Info(driver.Url);
                        test.Info(Environment.StackTrace.Replace(Environment.NewLine, "<br>"));
                        test.Log(Status.Fail, "<div style= 'color:red; font-weight:bold'>Test_Dashboards_PreviousBusinessHistory FAILED");
                    }
                    else if (TestContext.CurrentContext.Result.Outcome.Status != TestStatus.Failed)
                    {
                        test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Test_Dashboards_PreviousBusinessHistory PASSED");
                    }
                }
            }
        }

        [Test, Retry(3)]
        [Category("Selenium")]
        public void Test_NewCustomer_VerifyEmail()
        {
            using (var driver = InitialiseDriver())
            {
                ExtentTest test = null;
                try
                {
                    test = extent.CreateTest("Test_NewCustomer_VerifyEmail").Info("<div style= 'color:blue; font-weight:bold'>Test Started");
                    DynamicsLogin dynamicsLogin = new DynamicsLogin(driver);
                    dynamicsLogin.LoginWindow();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Dynamics account selected");

                    Dashboards dashboards = new Dashboards(driver);
                    dashboards.VerifyPageTitle();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'> Homepage Title verified");

                    NewCustomer newCustomer = new NewCustomer(driver);
                    newCustomer.VerifyEmailInput();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'> Email verification successfull");
                }
                catch (Exception e)
                {
                    Assert.Fail(e.StackTrace);
                }
                finally
                {
                    commonUtils.PrintLogs("browser", driver);

                    if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
                    {
                        string fileName = @"C:\Users\garymoore\OneDrive - Wakefield Council\Desktop\CRMRegressionPack\CRMRegressionPack\Screenshots\" + DateTime.Now.ToString("dd_MM_yy -HH_mm_ss") + ".Png";
                        Screenshot cp = ((ITakesScreenshot)driver).GetScreenshot();
                        cp.SaveAsFile(fileName, ScreenshotImageFormat.Png);
                        test.AddScreenCaptureFromPath(fileName);
                        test.Info(driver.Url);
                        test.Info(Environment.StackTrace.Replace(Environment.NewLine, "<br>"));
                        test.Log(Status.Fail, "<div style= 'color:red; font-weight:bold'>Test_NewCustomer_VerifyEmail FAILED");
                    }
                    else if (TestContext.CurrentContext.Result.Outcome.Status != TestStatus.Failed)
                    {
                        test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Test_NewCustomer_VerifyEmail PASSED");
                    }
                }
            }
        }
        
        [Test, Retry(3)]
        [Category("Selenium")]
        public void Test_NewCustomer_AddNewCustomer()
        {
            using (var driver = InitialiseDriver())
            {
                ExtentTest test = null;
                try
                {
                    test = extent.CreateTest("Test_NewCustomer_AddNewCustomer").Info("<div style= 'color:blue; font-weight:bold'>Test Started");
                    DynamicsLogin dynamicsLogin = new DynamicsLogin(driver);
                    dynamicsLogin.LoginWindow();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Dynamics account selected");

                    Dashboards dashboards = new Dashboards(driver);
                    dashboards.VerifyPageTitle();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'> Homepage Title verified");

                    DataClearup dataClearup = new DataClearup(driver);
                    dataClearup.ClearDataCustomer();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Leftover customer data cleared successfully");

                    NewCustomer newCustomer = new NewCustomer(driver);
                    newCustomer.AddNewCustomer();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'> New customer created successfully");
                }
                catch (Exception e)
                {
                    Assert.Fail(e.StackTrace);
                }
                finally
                {
                    commonUtils.PrintLogs("browser", driver);

                    if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
                    {
                        string fileName = @"C:\Users\garymoore\OneDrive - Wakefield Council\Desktop\CRMRegressionPack\CRMRegressionPack\Screenshots\" + DateTime.Now.ToString("dd_MM_yy -HH_mm_ss") + ".Png";
                        Screenshot cp = ((ITakesScreenshot)driver).GetScreenshot();
                        cp.SaveAsFile(fileName, ScreenshotImageFormat.Png);
                        test.AddScreenCaptureFromPath(fileName);
                        test.Info(driver.Url);
                        test.Info(Environment.StackTrace.Replace(Environment.NewLine, "<br>"));
                        test.Log(Status.Fail, "<div style= 'color:red; font-weight:bold'>Test_NewCustomer_AddNewCustomer FAILED");
                    }
                    else if (TestContext.CurrentContext.Result.Outcome.Status != TestStatus.Failed)
                    {
                        test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Test_NewCustomer_AddNewCustomer PASSED");
                    }
                }
            }
        }

        [Test, Retry(3)]
        [Category("Selenium")]
        public void Test_NewCustomer_AddNewCustomerUnknownAddress()
        {
            using (var driver = InitialiseDriver())
            {
                ExtentTest test = null;
                try
                {
                    test = extent.CreateTest("Test_NewCustomer_AddNewCustomerUnknownAddress").Info("<div style= 'color:blue; font-weight:bold'>Test Started");
                    DynamicsLogin dynamicsLogin = new DynamicsLogin(driver);
                    dynamicsLogin.LoginWindow();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Dynamics account selected");

                    Dashboards dashboards = new Dashboards(driver);
                    dashboards.VerifyPageTitle();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'> Homepage Title verified");

                    DataClearup dataClearup = new DataClearup(driver);
                    dataClearup.ClearDataCustomer();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Leftover customer data cleared successfully");

                    NewCustomer newCustomer = new NewCustomer(driver);
                    newCustomer.AddNewCustomerUnknownAddress();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'> New customer with unknown address created successfully");
                }
                catch (Exception e)
                {
                    Assert.Fail(e.StackTrace);
                }
                finally
                {
                    commonUtils.PrintLogs("browser", driver);

                    if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
                    {
                        string fileName = @"C:\Users\garymoore\OneDrive - Wakefield Council\Desktop\CRMRegressionPack\CRMRegressionPack\Screenshots\" + DateTime.Now.ToString("dd_MM_yy -HH_mm_ss") + ".Png";
                        Screenshot cp = ((ITakesScreenshot)driver).GetScreenshot();
                        cp.SaveAsFile(fileName, ScreenshotImageFormat.Png);
                        test.AddScreenCaptureFromPath(fileName);
                        test.Info(driver.Url);
                        test.Info(Environment.StackTrace.Replace(Environment.NewLine, "<br>"));
                        test.Log(Status.Fail, "<div style= 'color:red; font-weight:bold'>Test_NewCustomer_AddNewCustomerUnknownAddress FAILED");
                    }
                    else if (TestContext.CurrentContext.Result.Outcome.Status != TestStatus.Failed)
                    {
                        test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Test_NewCustomer_AddNewCustomerUnknownAddress PASSED");
                    }
                }
            }
        }

        [Test, Retry(3)]
        [Category("Selenium")]
        public void Test_NewCustomer_NonMandatoryFields()
        { 
            using (var driver = InitialiseDriver())
            {
                ExtentTest test = null;
                try
                {
                    test = extent.CreateTest("Test_NewCustomer_NonMandatoryFields").Info("<div style= 'color:blue; font-weight:bold'>Test Started");
                    DynamicsLogin dynamicsLogin = new DynamicsLogin(driver);
                    dynamicsLogin.LoginWindow();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Dynamics account selected");

                    Dashboards dashboards = new Dashboards(driver);
                    dashboards.VerifyPageTitle();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'> Homepage Title verified");

                    NewCustomer newCustomer = new NewCustomer(driver);
                    newCustomer.AddNewCustomerWithoutMandatoryFields();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'> New customer not created. Mandatory fields missing");
                }
                catch (Exception e)
                {
                    Assert.Fail(e.StackTrace);
                }
                finally
                {
                    commonUtils.PrintLogs("browser", driver);

                    if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
                    {
                        string fileName = @"C:\Users\garymoore\OneDrive - Wakefield Council\Desktop\CRMRegressionPack\CRMRegressionPack\Screenshots\" + DateTime.Now.ToString("dd_MM_yy -HH_mm_ss") + ".Png";
                        Screenshot cp = ((ITakesScreenshot)driver).GetScreenshot();
                        cp.SaveAsFile(fileName, ScreenshotImageFormat.Png);
                        test.AddScreenCaptureFromPath(fileName);
                        test.Info(driver.Url);
                        test.Info(Environment.StackTrace.Replace(Environment.NewLine, "<br>"));
                        test.Log(Status.Fail, "<div style= 'color:red; font-weight:bold'>Test_NewCustomer_NonMandatoryFields FAILED");
                    }
                    else if (TestContext.CurrentContext.Result.Outcome.Status != TestStatus.Failed)
                    {
                        test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Test_NewCustomer_NonMandatoryFields PASSED");
                    }
                }
            }
        }

        [Test, Retry(3)]
        [Category("Selenium")]
        public void Test_NewCustomer_SearchCustomerOnActiveContacts()
        {
            using (var driver = InitialiseDriver())
            {
                ExtentTest test = null;
                try
                {
                    test = extent.CreateTest("Test_NewCustomer_SearchCustomerOnActiveContacts").Info("<div style= 'color:blue; font-weight:bold'>Test Started");
                    DynamicsLogin dynamicsLogin = new DynamicsLogin(driver);
                    dynamicsLogin.LoginWindow();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Dynamics account selected");

                    Dashboards dashboards = new Dashboards(driver);
                    dashboards.VerifyPageTitle();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'> Homepage Title verified");

                    DataClearup dataClearup = new DataClearup(driver);
                    dataClearup.ClearDataCustomer();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Leftover customer data cleared successfully");

                    NewCustomer newCustomer = new NewCustomer(driver);
                    newCustomer.SearchCustomerOnActiveContacts();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Correct customer search results displayed");
                }
                catch (Exception e)
                {
                    Assert.Fail(e.StackTrace);
                }
                finally
                {
                    commonUtils.PrintLogs("browser", driver);

                    if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
                    {
                        string fileName = @"C:\Users\garymoore\OneDrive - Wakefield Council\Desktop\CRMRegressionPack\CRMRegressionPack\Screenshots\" + DateTime.Now.ToString("dd_MM_yy -HH_mm_ss") + ".Png";
                        Screenshot cp = ((ITakesScreenshot)driver).GetScreenshot();
                        cp.SaveAsFile(fileName, ScreenshotImageFormat.Png);
                        test.AddScreenCaptureFromPath(fileName);
                        test.Info(driver.Url);
                        test.Info(Environment.StackTrace.Replace(Environment.NewLine, "<br>"));
                        test.Log(Status.Fail, "<div style= 'color:red; font-weight:bold'>Test_NewCustomer_SearchCustomerOnActiveContacts FAILED");
                    }
                    else if (TestContext.CurrentContext.Result.Outcome.Status != TestStatus.Failed)
                    {
                        test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Test_NewCustomer_SearchCustomerOnActiveContacts PASSED");
                    }
                }
            }
        }

        [Test, Retry(3)]
        [Category("Selenium")]
        public void Test_NewCustomer_ContinueWithCustomer()
        {
            using (var driver = InitialiseDriver())
            {
                ExtentTest test = null;
                try
                {
                    test = extent.CreateTest("Test_NewCustomer_ContinueWithCustomer").Info("<div style= 'color:blue; font-weight:bold'>Test Started");
                    DynamicsLogin dynamicsLogin = new DynamicsLogin(driver);
                    dynamicsLogin.LoginWindow();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Dynamics account selected");

                    Dashboards dashboards = new Dashboards(driver);
                    dashboards.VerifyPageTitle();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'> Homepage Title verified");

                    DataClearup dataClearup = new DataClearup(driver);
                    dataClearup.ClearDataCustomer();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Leftover customer data cleared successfully");

                    NewCustomer newCustomer = new NewCustomer(driver);
                    newCustomer.ContinueWithCustomer();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Correct customer details displayed in access channel");
                }
                catch (Exception e)
                {
                    Assert.Fail(e.StackTrace);
                }
                finally
                {
                    commonUtils.PrintLogs("browser", driver);

                    if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
                    {
                        string fileName = @"C:\Users\garymoore\OneDrive - Wakefield Council\Desktop\CRMRegressionPack\CRMRegressionPack\Screenshots\" + DateTime.Now.ToString("dd_MM_yy -HH_mm_ss") + ".Png";
                        Screenshot cp = ((ITakesScreenshot)driver).GetScreenshot();
                        cp.SaveAsFile(fileName, ScreenshotImageFormat.Png);
                        test.AddScreenCaptureFromPath(fileName);
                        test.Info(driver.Url);
                        test.Info(Environment.StackTrace.Replace(Environment.NewLine, "<br>"));
                        test.Log(Status.Fail, "<div style= 'color:red; font-weight:bold'>Test_NewCustomer_ContinueWithCustomer FAILED");
                    }
                    else if (TestContext.CurrentContext.Result.Outcome.Status != TestStatus.Failed)
                    {
                        test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Test_NewCustomer_ContinueWithCustomer PASSED");
                    }
                }
            }
        }

        [Test, Retry(3)]
        [Category("Selenium")]
        public void Test_NewCustomer_ContinueWithCustomerUnknownAddress()
        {
            using (var driver = InitialiseDriver())
            {
                ExtentTest test = null;
                try
                {
                    test = extent.CreateTest("Test_NewCustomer_ContinueWithCustomerUnknownAddress").Info("<div style= 'color:blue; font-weight:bold'>Test Started");
                    DynamicsLogin dynamicsLogin = new DynamicsLogin(driver);
                    dynamicsLogin.LoginWindow();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Dynamics account selected");

                    Dashboards dashboards = new Dashboards(driver);
                    dashboards.VerifyPageTitle();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'> Homepage Title verified");

                    DataClearup dataClearup = new DataClearup(driver);
                    dataClearup.ClearDataCustomer();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Leftover customer data cleared successfully");

                    NewCustomer newCustomer = new NewCustomer(driver);
                    newCustomer.ContinueWithCustomerUnknownAddress();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Correct customer details displayed in access channel for customer with unknown address");
                }
                catch (Exception e)
                {
                    Assert.Fail(e.StackTrace);
                }
                finally
                {
                    commonUtils.PrintLogs("browser", driver);

                    if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
                    {
                        string fileName = @"C:\Users\garymoore\OneDrive - Wakefield Council\Desktop\CRMRegressionPack\CRMRegressionPack\Screenshots\" + DateTime.Now.ToString("dd_MM_yy -HH_mm_ss") + ".Png";
                        Screenshot cp = ((ITakesScreenshot)driver).GetScreenshot();
                        cp.SaveAsFile(fileName, ScreenshotImageFormat.Png);
                        test.AddScreenCaptureFromPath(fileName);
                        test.Info(driver.Url);
                        test.Info(Environment.StackTrace.Replace(Environment.NewLine, "<br>"));
                        test.Log(Status.Fail, "<div style= 'color:red; font-weight:bold'>Test_NewCustomer_ContinueWithCustomerUnknownAddress FAILED");
                    }
                    else if (TestContext.CurrentContext.Result.Outcome.Status != TestStatus.Failed)
                    {
                        test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Test_NewCustomer_ContinueWithCustomerUnknownAddress PASSED");
                    }
                }
            }
        }

        [Test, Retry(3)]
        [Category("Selenium")]
        public void Test_NewCustomer_ContinueWithManualCustomer()
        {
            using (var driver = InitialiseDriver())
            {
                ExtentTest test = null;
                try
                {
                    test = extent.CreateTest("Test_NewCustomer_ContinueWithManualCustomer").Info("<div style= 'color:blue; font-weight:bold'>Test Started");
                    DynamicsLogin dynamicsLogin = new DynamicsLogin(driver);
                    dynamicsLogin.LoginWindow();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Dynamics account selected");

                    Dashboards dashboards = new Dashboards(driver);
                    dashboards.VerifyPageTitle();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'> Homepage Title verified");

                    DataClearup dataClearup = new DataClearup(driver);
                    dataClearup.ClearDataCustomer();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Leftover customer data cleared successfully");

                    NewCustomer newCustomer = new NewCustomer(driver);
                    newCustomer.ContinueWithManualCustomer();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Continue customer journey correct for customer with manual address");
                }
                catch (Exception)
                {
                    Assert.Fail();
                }
                finally
                {
                    commonUtils.PrintLogs("browser", driver);

                    if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
                    {
                        string fileName = @"C:\Users\garymoore\OneDrive - Wakefield Council\Desktop\CRMRegressionPack\CRMRegressionPack\Screenshots\" + DateTime.Now.ToString("dd_MM_yy -HH_mm_ss") + ".Png";
                        Screenshot cp = ((ITakesScreenshot)driver).GetScreenshot();
                        cp.SaveAsFile(fileName, ScreenshotImageFormat.Png);
                        test.AddScreenCaptureFromPath(fileName);
                        test.Info(driver.Url);
                        test.Log(Status.Fail, "<div style= 'color:red; font-weight:bold'>Test_NewCustomer_ContinueWithManualCustomer FAILED");
                    }
                    else if (TestContext.CurrentContext.Result.Outcome.Status != TestStatus.Failed)
                    {
                        test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Test_NewCustomer_ContinueWithManualCustomer PASSED");
                    }
                }
            }
        }

        [Test, Retry(3)]
        [Category("Selenium")]
        public void Test_NewCustomer_OutOfAreaAddress()
        {
            using (var driver = InitialiseDriver())
            {
                ExtentTest test = null;
                try
                {
                    test = extent.CreateTest("Test_NewCustomer_OutOfAreaAddress").Info("<div style= 'color:blue; font-weight:bold'>Test Started");
                    DynamicsLogin dynamicsLogin = new DynamicsLogin(driver);
                    dynamicsLogin.LoginWindow();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Dynamics account selected");

                    Dashboards dashboards = new Dashboards(driver);
                    dashboards.VerifyPageTitle();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'> Homepage Title verified");

                    DataClearup dataClearup = new DataClearup(driver);
                    dataClearup.ClearDataCustomer();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Leftover customer data cleared successfully");

                    NewCustomer newCustomer = new NewCustomer(driver);
                    newCustomer.OutOfAreaAddress();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Out of area address added successfully");
                }
                catch (Exception e)
                {
                    Assert.Fail(e.StackTrace);
                }
                finally
                {
                    commonUtils.PrintLogs("browser", driver);

                    if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
                    {
                        string fileName = @"C:\Users\garymoore\OneDrive - Wakefield Council\Desktop\CRMRegressionPack\CRMRegressionPack\Screenshots\" + DateTime.Now.ToString("dd_MM_yy -HH_mm_ss") + ".Png";
                        Screenshot cp = ((ITakesScreenshot)driver).GetScreenshot();
                        cp.SaveAsFile(fileName, ScreenshotImageFormat.Png);
                        test.AddScreenCaptureFromPath(fileName);
                        test.Info(driver.Url);
                        test.Info(Environment.StackTrace.Replace(Environment.NewLine, "<br>"));
                        test.Log(Status.Fail, "<div style= 'color:red; font-weight:bold'>Test_CaseSummary_OutOfAreaAddress FAILED");
                    }
                    else if (TestContext.CurrentContext.Result.Outcome.Status != TestStatus.Failed)
                    {
                        test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Test_CaseSummary_OutOfAreaAddress PASSED");
                    }
                }
            }
        }

        [Test, Retry(3)]
        [Category("Selenium")]
        public void Test_NewCustomer_AddAddressManualCustomer()
         {
             using (var driver = InitialiseDriver())
             {
                 ExtentTest test = null;
                 try
                 {
                     test = extent.CreateTest("Test_NewCustomer_AddAddressManualCustomer").Info("<div style= 'color:blue; font-weight:bold'>Test Started");
                     DynamicsLogin dynamicsLogin = new DynamicsLogin(driver);
                     dynamicsLogin.LoginWindow();
                     test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Dynamics account selected");

                     Dashboards dashboards = new Dashboards(driver);
                     dashboards.VerifyPageTitle();
                     test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'> Homepage Title verified");

                    DataClearup dataClearup = new DataClearup(driver);
                    dataClearup.ClearDataCustomer();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Leftover customer data cleared successfully");

                    NewCustomer newCustomer = new NewCustomer(driver);
                     newCustomer.AddAddressManualCustomer();
                     test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Manual address added successfully");
                 }
                 catch (Exception)
                 {
                     Assert.Fail();

                 }
                 finally
                 {
                     commonUtils.PrintLogs("browser", driver);

                     if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
                     {
                         string fileName = @"C:\Users\garymoore\OneDrive - Wakefield Council\Desktop\CRMRegressionPack\CRMRegressionPack\Screenshots\" + DateTime.Now.ToString("dd_MM_yy -HH_mm_ss") + ".Png";
                         Screenshot cp = ((ITakesScreenshot)driver).GetScreenshot();
                         cp.SaveAsFile(fileName, ScreenshotImageFormat.Png);
                         test.AddScreenCaptureFromPath(fileName);
                         test.Info(driver.Url);
                         test.Log(Status.Fail, "<div style= 'color:red; font-weight:bold'>Test_CaseSummary_AddAddressManualCustomer FAILED");
                     }
                     else if (TestContext.CurrentContext.Result.Outcome.Status != TestStatus.Failed)
                     {
                         test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Test_CaseSummary_AddAddressManualCustomer PASSED");
                     }
                 }
             }
         }

        [Test, Retry(3)]
        [Category("Selenium")]
        public void Test_NewCustomer_StartNewCustomer()
        {
            using (var driver = InitialiseDriver())
            {
                ExtentTest test = null;
                try
                {
                    test = extent.CreateTest("Test_NewCustomer_StartNewCustomer").Info("<div style= 'color:blue; font-weight:bold'>Test Started");
                    DynamicsLogin dynamicsLogin = new DynamicsLogin(driver);
                    dynamicsLogin.LoginWindow();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Dynamics account selected");

                    Dashboards dashboards = new Dashboards(driver);
                    dashboards.VerifyPageTitle();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'> Homepage Title verified");

                    DataClearup dataClearup = new DataClearup(driver);
                    dataClearup.ClearDataCustomer();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Leftover customer data cleared successfully");

                    NewCustomer newCustomer = new NewCustomer(driver);
                    newCustomer.StartNewCustomer();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Start new customer journey completed successfully");
                }
                catch (Exception e)
                {
                    Assert.Fail(e.StackTrace);
                }
                finally
                {
                    commonUtils.PrintLogs("browser", driver);

                    if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
                    {
                        string fileName = @"C:\Users\garymoore\OneDrive - Wakefield Council\Desktop\CRMRegressionPack\CRMRegressionPack\Screenshots\" + DateTime.Now.ToString("dd_MM_yy -HH_mm_ss") + ".Png";
                        Screenshot cp = ((ITakesScreenshot)driver).GetScreenshot();
                        cp.SaveAsFile(fileName, ScreenshotImageFormat.Png);
                        test.AddScreenCaptureFromPath(fileName);
                        test.Info(driver.Url);
                        test.Info(Environment.StackTrace.Replace(Environment.NewLine, "<br>"));
                        test.Log(Status.Fail, "<div style= 'color:red; font-weight:bold'>Test_CaseSummary_StartNewCustomer FAILED");
                    }
                    else if (TestContext.CurrentContext.Result.Outcome.Status != TestStatus.Failed)
                    {
                        test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Test_CaseSummary_StartNewCustomer PASSED");
                    }
                }
            }
        }

        [Test, Retry(3)]
        [Category("Selenium")]
        public void Test_NewBusiness_VerifyEmail()
        {
            using (var driver = InitialiseDriver())
            {
                ExtentTest test = null;
                try
                {
                    test = extent.CreateTest("Test_NewBusiness_VerifyEmail").Info("<div style= 'color:blue; font-weight:bold'>Test Started");
                    DynamicsLogin dynamicsLogin = new DynamicsLogin(driver);
                    dynamicsLogin.LoginWindow();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Dynamics account selected");

                    Dashboards dashboards = new Dashboards(driver);
                    dashboards.VerifyPageTitle();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'> Homepage Title verified");

                    NewBusiness newBusiness = new NewBusiness(driver);
                    newBusiness.VerifyEmailInput();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'> Email verification successfull");
                }
                catch (Exception e)
                {
                    Assert.Fail(e.StackTrace);
                }
                finally
                {
                    commonUtils.PrintLogs("browser", driver);

                    if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
                    {
                        string fileName = @"C:\Users\garymoore\OneDrive - Wakefield Council\Desktop\CRMRegressionPack\CRMRegressionPack\Screenshots\" + DateTime.Now.ToString("dd_MM_yy -HH_mm_ss") + ".Png";
                        Screenshot cp = ((ITakesScreenshot)driver).GetScreenshot();
                        cp.SaveAsFile(fileName, ScreenshotImageFormat.Png);
                        test.AddScreenCaptureFromPath(fileName);
                        test.Info(driver.Url);
                        test.Info(Environment.StackTrace.Replace(Environment.NewLine, "<br>"));
                        test.Log(Status.Fail, "<div style= 'color:red; font-weight:bold'>Test_NewBusiness_VerifyEmail FAILED");
                    }
                    else if (TestContext.CurrentContext.Result.Outcome.Status != TestStatus.Failed)
                    {
                        test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Test_NewBusiness_VerifyEmail PASSED");
                    }
                }
            }
        }
       
        [Test, Retry(3)]
        [Category("Selenium")]
        public void Test_NewBusiness_AddBusiness()
        {
            using (var driver = InitialiseDriver())
            {
                ExtentTest test = null;
                try
                {
                    test = extent.CreateTest("Test_NewBusiness_AddBusiness").Info("<div style= 'color:blue; font-weight:bold'>Test Started");
                    DynamicsLogin dynamicsLogin = new DynamicsLogin(driver);
                    dynamicsLogin.LoginWindow();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Dynamics account selected");

                    Dashboards dashboards = new Dashboards(driver);
                    dashboards.VerifyPageTitle();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'> Homepage Title verified");

                    DataClearup dataClearup = new DataClearup(driver);
                    dataClearup.DataClearBusiness();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Leftover business data cleared successfully");

                    NewBusiness newBusiness = new NewBusiness(driver);
                    newBusiness.AddNewBusiness();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'> New Business created successfully");
                }
                catch (Exception e)
                {
                    Assert.Fail(e.StackTrace);
                }
                finally
                {
                    commonUtils.PrintLogs("browser", driver);

                    if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
                    {
                        string fileName = @"C:\Users\garymoore\OneDrive - Wakefield Council\Desktop\CRMRegressionPack\CRMRegressionPack\Screenshots\" + DateTime.Now.ToString("dd_MM_yy -HH_mm_ss") + ".Png";
                        Screenshot cp = ((ITakesScreenshot)driver).GetScreenshot();
                        cp.SaveAsFile(fileName, ScreenshotImageFormat.Png);
                        test.AddScreenCaptureFromPath(fileName);
                        test.Info(driver.Url);
                        test.Info(Environment.StackTrace.Replace(Environment.NewLine, "<br>"));
                        test.Log(Status.Fail, "<div style= 'color:red; font-weight:bold'>Test_NewBusiness_AddBusiness FAILED");
                    }
                    else if (TestContext.CurrentContext.Result.Outcome.Status != TestStatus.Failed)
                    {
                        test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Test_NewBusiness_AddBusiness PASSED");
                    }
                }
            }
        }
       
        [Test, Retry(3)]
        [Category("Selenium")]
        public void Test_NewBusiness_NonMandatoryFields()
        {
            using (var driver = InitialiseDriver())
            {
                ExtentTest test = null;
                try
                {
                    test = extent.CreateTest("Test_NewBusiness_NonMandatoryFields").Info("<div style= 'color:blue; font-weight:bold'>Test Started");
                    DynamicsLogin dynamicsLogin = new DynamicsLogin(driver);
                    dynamicsLogin.LoginWindow();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Dynamics account selected");

                    Dashboards dashboards = new Dashboards(driver);
                    dashboards.VerifyPageTitle();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'> Homepage Title verified");

                    NewBusiness newBusiness = new NewBusiness(driver);
                    newBusiness.AddNewBusinessWithoutMandatoryFields();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'> New Business not created. Mandatory fields missing");
                }
                catch (Exception e)
                {
                    Assert.Fail(e.StackTrace);
                }
                finally
                {
                    commonUtils.PrintLogs("browser", driver);

                    if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
                    {
                        string fileName = @"C:\Users\garymoore\OneDrive - Wakefield Council\Desktop\CRMRegressionPack\CRMRegressionPack\Screenshots\" + DateTime.Now.ToString("dd_MM_yy -HH_mm_ss") + ".Png";
                        Screenshot cp = ((ITakesScreenshot)driver).GetScreenshot();
                        cp.SaveAsFile(fileName, ScreenshotImageFormat.Png);
                        test.AddScreenCaptureFromPath(fileName);
                        test.Info(driver.Url);
                        test.Info(Environment.StackTrace.Replace(Environment.NewLine, "<br>"));
                        test.Log(Status.Fail, "<div style= 'color:red; font-weight:bold'>Test_NewBusiness_NonMandatoryFields FAILED");
                    }
                    else if (TestContext.CurrentContext.Result.Outcome.Status != TestStatus.Failed)
                    {
                        test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Test_NewBusiness_NonMandatoryFields PASSED");
                    }
                }
            }
        }

        [Test, Retry(3)]
        [Category("Selenium")]
        public void Test_NewBusiness_SearchBusinessOnActiveAccounts()
        {
            using (var driver = InitialiseDriver())
            {
                ExtentTest test = null;
                try
                {
                    test = extent.CreateTest("Test_NewBusiness_SearchBusinessOnActiveAccounts").Info("<div style= 'color:blue; font-weight:bold'>Test Started");
                    DynamicsLogin dynamicsLogin = new DynamicsLogin(driver);
                    dynamicsLogin.LoginWindow();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Dynamics account selected");

                    Dashboards dashboards = new Dashboards(driver);
                    dashboards.VerifyPageTitle();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'> Homepage Title verified");

                    DataClearup dataClearup = new DataClearup(driver);
                    dataClearup.DataClearBusiness();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Leftover business data cleared successfully");

                    NewBusiness newBusiness = new NewBusiness(driver);
                    newBusiness.SearchBusinessOnActiveAccounts();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Business search result is correct");
                }
                catch (Exception e)
                {
                    Assert.Fail(e.StackTrace);
                }
                finally
                {
                    commonUtils.PrintLogs("browser", driver);

                    if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
                    {
                        string fileName = @"C:\Users\garymoore\OneDrive - Wakefield Council\Desktop\CRMRegressionPack\CRMRegressionPack\Screenshots\" + DateTime.Now.ToString("dd_MM_yy -HH_mm_ss") + ".Png";
                        Screenshot cp = ((ITakesScreenshot)driver).GetScreenshot();
                        cp.SaveAsFile(fileName, ScreenshotImageFormat.Png);
                        test.AddScreenCaptureFromPath(fileName);
                        test.Info(driver.Url);
                        test.Info(Environment.StackTrace.Replace(Environment.NewLine, "<br>"));
                        test.Log(Status.Fail, "<div style= 'color:red; font-weight:bold'>Test_NewBusiness_SearchBusinessOnActiveAccounts FAILED");
                    }
                    else if (TestContext.CurrentContext.Result.Outcome.Status != TestStatus.Failed)
                    {
                        test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Test_NewBusiness_SearchBusinessOnActiveAccounts PASSED");
                    }
                }
            }
        }

        [Test, Retry(3)]
        [Category("Selenium")]
        public void Test_NewBusiness_OutOfAreaBusiness()
        {
            using (var driver = InitialiseDriver())
            {
                ExtentTest test = null;
                try
                {
                    test = extent.CreateTest("Test_NewBusiness_OutOfAreaBusiness").Info("<div style= 'color:blue; font-weight:bold'>Test Started");
                    DynamicsLogin dynamicsLogin = new DynamicsLogin(driver);
                    dynamicsLogin.LoginWindow();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Dynamics account selected");

                    Dashboards dashboards = new Dashboards(driver);
                    dashboards.VerifyPageTitle();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'> Homepage Title verified");

                    DataClearup dataClearup = new DataClearup(driver);
                    dataClearup.DataClearBusiness();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Leftover business data cleared successfully");

                    NewBusiness newBusiness = new NewBusiness(driver);
                    newBusiness.OutOfAreaBusiness();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Business with out of area address added correctly");
                }
                catch (Exception e)
                {
                    Assert.Fail(e.StackTrace);
                }
                finally
                {
                    commonUtils.PrintLogs("browser", driver);

                    if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
                    {
                        string fileName = @"C:\Users\garymoore\OneDrive - Wakefield Council\Desktop\CRMRegressionPack\CRMRegressionPack\Screenshots\" + DateTime.Now.ToString("dd_MM_yy -HH_mm_ss") + ".Png";
                        Screenshot cp = ((ITakesScreenshot)driver).GetScreenshot();
                        cp.SaveAsFile(fileName, ScreenshotImageFormat.Png);
                        test.AddScreenCaptureFromPath(fileName);
                        test.Info(driver.Url);
                        test.Info(Environment.StackTrace.Replace(Environment.NewLine, "<br>"));
                        test.Log(Status.Fail, "<div style= 'color:red; font-weight:bold'>Test_NewBusiness_OutOfAreaBusiness FAILED");
                    }
                    else if (TestContext.CurrentContext.Result.Outcome.Status != TestStatus.Failed)
                    {
                        test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Test_NewBusiness_OutOfAreaBusiness PASSED");
                    }
                }
            }
        }

        [Test, Retry(3)]
        [Category("Selenium")]
        public void Test_NewBusiness_ContinueWithCustomerBusiness()
        {
            using (var driver = InitialiseDriver())
            {
                ExtentTest test = null;
                try
                {
                    test = extent.CreateTest("Test_NewBusiness_ContinueWithCustomerBusiness").Info("<div style= 'color:blue; font-weight:bold'>Test Started");
                    DynamicsLogin dynamicsLogin = new DynamicsLogin(driver);
                    dynamicsLogin.LoginWindow();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Dynamics account selected");

                    Dashboards dashboards = new Dashboards(driver);
                    dashboards.VerifyPageTitle();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'> Homepage Title verified");

                    DataClearup dataClearup = new DataClearup(driver);
                    dataClearup.DataClearBusiness();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Leftover business data cleared successfully");

                    NewBusiness newBusiness = new NewBusiness(driver);
                    newBusiness.ContinueWithCustomerBusiness();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Continue with customer on business account working correctly");
                }
                catch (Exception e)
                {
                    Assert.Fail(e.StackTrace);
                }
                finally
                {
                    commonUtils.PrintLogs("browser", driver);

                    if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
                    {
                        string fileName = @"C:\Users\garymoore\OneDrive - Wakefield Council\Desktop\CRMRegressionPack\CRMRegressionPack\Screenshots\" + DateTime.Now.ToString("dd_MM_yy -HH_mm_ss") + ".Png";
                        Screenshot cp = ((ITakesScreenshot)driver).GetScreenshot();
                        cp.SaveAsFile(fileName, ScreenshotImageFormat.Png);
                        test.AddScreenCaptureFromPath(fileName);
                        test.Info(driver.Url);
                        test.Info(Environment.StackTrace.Replace(Environment.NewLine, "<br>"));
                        test.Log(Status.Fail, "<div style= 'color:red; font-weight:bold'>Test_NewBusiness_ContinueWithCustomerBusiness FAILED");
                    }
                    else if (TestContext.CurrentContext.Result.Outcome.Status != TestStatus.Failed)
                    {
                        test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Test_NewBusiness_ContinueWithCustomerBusiness PASSED");
                    }
                }
            }
        }

        [Test, Retry(3)]
        [Category("Selenium")]
        public void Test_NewBusiness_AddBusinessManualAddress()
        {
            using (var driver = InitialiseDriver())
            {
                ExtentTest test = null;
                try
                {
                    test = extent.CreateTest("Test_NewBusiness_AddBusinessManualAddress").Info("<div style= 'color:blue; font-weight:bold'>Test Started");
                    DynamicsLogin dynamicsLogin = new DynamicsLogin(driver);
                    dynamicsLogin.LoginWindow();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Dynamics account selected");

                    Dashboards dashboards = new Dashboards(driver);
                    dashboards.VerifyPageTitle();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'> Homepage Title verified");

                    DataClearup dataClearup = new DataClearup(driver);
                    dataClearup.DataClearBusiness();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Leftover business data cleared successfully");

                    NewBusiness newBusiness = new NewBusiness(driver);
                    newBusiness.AddBusinessManualAddress();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'> New Business created successfully");
                }
                catch (Exception e)
                {
                    Assert.Fail(e.StackTrace);
                }
                finally
                {
                    commonUtils.PrintLogs("browser", driver);

                    if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
                    {
                        string fileName = @"C:\Users\garymoore\OneDrive - Wakefield Council\Desktop\CRMRegressionPack\CRMRegressionPack\Screenshots\" + DateTime.Now.ToString("dd_MM_yy -HH_mm_ss") + ".Png";
                        Screenshot cp = ((ITakesScreenshot)driver).GetScreenshot();
                        cp.SaveAsFile(fileName, ScreenshotImageFormat.Png);
                        test.AddScreenCaptureFromPath(fileName);
                        test.Info(driver.Url);
                        test.Info(Environment.StackTrace.Replace(Environment.NewLine, "<br>"));
                        test.Log(Status.Fail, "<div style= 'color:red; font-weight:bold'>Test_NewBusiness_AddBusinessManualAddress FAILED");
                    }
                    else if (TestContext.CurrentContext.Result.Outcome.Status != TestStatus.Failed)
                    {
                        test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Test_NewBusiness_AddBusinessManualAddress PASSED");
                    }
                }
            }
        }

        [Test, Retry(3)]
        [Category("Selenium")]
        public void Test_NewBusiness_ContinueWithBusinessManualAddress()
        {
            using (var driver = InitialiseDriver())
            {
                ExtentTest test = null;
                try
                {
                    test = extent.CreateTest("Test_NewBusiness_ContinueWithBusinessManualAddress").Info("<div style= 'color:blue; font-weight:bold'>Test Started");
                    DynamicsLogin dynamicsLogin = new DynamicsLogin(driver);
                    dynamicsLogin.LoginWindow();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Dynamics account selected");

                    Dashboards dashboards = new Dashboards(driver);
                    dashboards.VerifyPageTitle();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'> Homepage Title verified");

                    DataClearup dataClearup = new DataClearup(driver);
                    dataClearup.DataClearBusiness();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Leftover business data cleared successfully");

                    NewBusiness newBusiness = new NewBusiness(driver);
                    newBusiness.ContinueWithBusinessManualAddress();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Continue with business functionality correct for business with manually added address");
                }
                catch (Exception e)
                {
                    Assert.Fail(e.StackTrace);
                }
                finally
                {
                    commonUtils.PrintLogs("browser", driver);

                    if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
                    {
                        string fileName = @"C:\Users\garymoore\OneDrive - Wakefield Council\Desktop\CRMRegressionPack\CRMRegressionPack\Screenshots\" + DateTime.Now.ToString("dd_MM_yy -HH_mm_ss") + ".Png";
                        Screenshot cp = ((ITakesScreenshot)driver).GetScreenshot();
                        cp.SaveAsFile(fileName, ScreenshotImageFormat.Png);
                        test.AddScreenCaptureFromPath(fileName);
                        test.Info(driver.Url);
                        test.Info(Environment.StackTrace.Replace(Environment.NewLine, "<br>"));
                        test.Log(Status.Fail, "<div style= 'color:red; font-weight:bold'>Test_NewBusiness_ContinueWithBusinessManualAddress FAILED");
                    }
                    else if (TestContext.CurrentContext.Result.Outcome.Status != TestStatus.Failed)
                    {
                        test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Test_NewBusiness_ContinueWithBusinessManualAddress PASSED");
                    }
                }
            }
        }

        [Test, Retry(3)]
        [Category("Selenium")]
        public void Test_NewBusiness_AddNewBusinessUnknownAddress()
        {
            using (var driver = InitialiseDriver())
            {
                ExtentTest test = null;
                try
                {
                    test = extent.CreateTest("Test_NewBusiness_AddNewBusinessUnknownAddress").Info("<div style= 'color:blue; font-weight:bold'>Test Started");
                    DynamicsLogin dynamicsLogin = new DynamicsLogin(driver);
                    dynamicsLogin.LoginWindow();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Dynamics account selected");

                    Dashboards dashboards = new Dashboards(driver);
                    dashboards.VerifyPageTitle();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'> Homepage Title verified");

                    DataClearup dataClearup = new DataClearup(driver);
                    dataClearup.DataClearBusiness();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Leftover business data cleared successfully");

                    NewBusiness newBusiness = new NewBusiness(driver);
                    newBusiness.AddNewBusinessUnknownAddress();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'> New Business created successfully");
                }
                catch (Exception e)
                {
                    Assert.Fail(e.StackTrace);
                }
                finally
                {
                    commonUtils.PrintLogs("browser", driver);

                    if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
                    {
                        string fileName = @"C:\Users\garymoore\OneDrive - Wakefield Council\Desktop\CRMRegressionPack\CRMRegressionPack\Screenshots\" + DateTime.Now.ToString("dd_MM_yy -HH_mm_ss") + ".Png";
                        Screenshot cp = ((ITakesScreenshot)driver).GetScreenshot();
                        cp.SaveAsFile(fileName, ScreenshotImageFormat.Png);
                        test.AddScreenCaptureFromPath(fileName);
                        test.Info(driver.Url);
                        test.Info(Environment.StackTrace.Replace(Environment.NewLine, "<br>"));
                        test.Log(Status.Fail, "<div style= 'color:red; font-weight:bold'>Test_NewBusiness_AddNewBusinessUnknownAddress FAILED");
                    }
                    else if (TestContext.CurrentContext.Result.Outcome.Status != TestStatus.Failed)
                    {
                        test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Test_NewBusiness_AddNewBusinessUnknownAddress PASSED");
                    }
                }
            }
        }

        [Test, Retry(3)]
        [Category("Selenium")]
        public void Test_NewBusiness_ContinueWithBusinessUnknownAddress()
        {
            using (var driver = InitialiseDriver())
            {
                ExtentTest test = null;
                try
                {
                    test = extent.CreateTest("Test_NewBusiness_ContinueWithBusinessUnknownAddress").Info("<div style= 'color:blue; font-weight:bold'>Test Started");
                    DynamicsLogin dynamicsLogin = new DynamicsLogin(driver);
                    dynamicsLogin.LoginWindow();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Dynamics account selected");

                    Dashboards dashboards = new Dashboards(driver);
                    dashboards.VerifyPageTitle();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'> Homepage Title verified");

                    DataClearup dataClearup = new DataClearup(driver);
                    dataClearup.DataClearBusiness();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Leftover business data cleared successfully");

                    NewBusiness newBusiness = new NewBusiness(driver);
                    newBusiness.ContinueWithBusinessUnknownAddress();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Continue with business functionality correct for business with unknown address");
                }
                catch (Exception e)
                {
                    Assert.Fail(e.StackTrace);
                }
                finally
                {
                    commonUtils.PrintLogs("browser", driver);

                    if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
                    {
                        string fileName = @"C:\Users\garymoore\OneDrive - Wakefield Council\Desktop\CRMRegressionPack\CRMRegressionPack\Screenshots\" + DateTime.Now.ToString("dd_MM_yy -HH_mm_ss") + ".Png";
                        Screenshot cp = ((ITakesScreenshot)driver).GetScreenshot();
                        cp.SaveAsFile(fileName, ScreenshotImageFormat.Png);
                        test.AddScreenCaptureFromPath(fileName);
                        test.Info(driver.Url);
                        test.Info(Environment.StackTrace.Replace(Environment.NewLine, "<br>"));
                        test.Log(Status.Fail, "<div style= 'color:red; font-weight:bold'>Test_NewBusiness_ContinueWithBusinessUnknownAddress FAILED");
                    }
                    else if (TestContext.CurrentContext.Result.Outcome.Status != TestStatus.Failed)
                    {
                        test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Test_NewBusiness_ContinueWithBusinessUnknownAddress PASSED");
                    }
                }
            }
        }

        [Test, Retry(3)]
        [Category("Selenium")]
        public void Test_NewBusiness_DuplicateBusiness()
        {
            using (var driver = InitialiseDriver())
            {
                ExtentTest test = null;
                try
                {
                    test = extent.CreateTest("Test_NewBusiness_DuplicateBusiness").Info("<div style= 'color:blue; font-weight:bold'>Test Started");
                    DynamicsLogin dynamicsLogin = new DynamicsLogin(driver);
                    dynamicsLogin.LoginWindow();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Dynamics account selected");

                    Dashboards dashboards = new Dashboards(driver);
                    dashboards.VerifyPageTitle();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'> Homepage Title verified");

                    DataClearup dataClearup = new DataClearup(driver);
                    dataClearup.DataClearBusiness();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Leftover business data cleared successfully");

                    NewBusiness newBusiness = new NewBusiness(driver);
                    newBusiness.DuplicateBusiness();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Duplicate business rules are correct");
                }
                catch (Exception e)
                {
                    Assert.Fail(e.StackTrace);
                }
                finally
                {
                    commonUtils.PrintLogs("browser", driver);

                    if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
                    {
                        string fileName = @"C:\Users\garymoore\OneDrive - Wakefield Council\Desktop\CRMRegressionPack\CRMRegressionPack\Screenshots\" + DateTime.Now.ToString("dd_MM_yy -HH_mm_ss") + ".Png";
                        Screenshot cp = ((ITakesScreenshot)driver).GetScreenshot();
                        cp.SaveAsFile(fileName, ScreenshotImageFormat.Png);
                        test.AddScreenCaptureFromPath(fileName);
                        test.Info(driver.Url);
                        test.Info(Environment.StackTrace.Replace(Environment.NewLine, "<br>"));
                        test.Log(Status.Fail, "<div style= 'color:red; font-weight:bold'>Test_NewBusiness_DuplicateBusiness FAILED");
                    }
                    else if (TestContext.CurrentContext.Result.Outcome.Status != TestStatus.Failed)
                    {
                        test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Test_NewBusiness_DuplicateBusiness PASSED");
                    }
                }
            }
        }

        [Test, Retry(3)]
        [Category("Selenium")]
        public void Test_NewBusiness_SortOrderBusinessTimeline()
        {
            using (var driver = InitialiseDriver())
            {
                ExtentTest test = null;
                try
                {
                    test = extent.CreateTest("Test_NewBusiness_SortOrderBusinessTimeline").Info("<div style= 'color:blue; font-weight:bold'>Test Started");
                    DynamicsLogin dynamicsLogin = new DynamicsLogin(driver);
                    dynamicsLogin.LoginWindow();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Dynamics account selected");

                    Dashboards dashboards = new Dashboards(driver);
                    dashboards.VerifyPageTitle();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'> Homepage Title verified");

                    DataClearup dataClearup = new DataClearup(driver);
                    dataClearup.DataClearBusiness();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Leftover business data cleared successfully");

                    NewBusiness newBusiness = new NewBusiness(driver);
                    newBusiness.SortOrderBusinessTimeline();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Customer timeline sort order changed successfully");
                }
                catch (Exception e)
                {
                    Assert.Fail(e.StackTrace);
                }
                finally
                {
                    commonUtils.PrintLogs("browser", driver);

                    if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
                    {
                        string fileName = @"C:\Users\garymoore\OneDrive - Wakefield Council\Desktop\CRMRegressionPack\CRMRegressionPack\Screenshots\" + DateTime.Now.ToString("dd_MM_yy -HH_mm_ss") + ".Png";
                        Screenshot cp = ((ITakesScreenshot)driver).GetScreenshot();
                        cp.SaveAsFile(fileName, ScreenshotImageFormat.Png);
                        test.AddScreenCaptureFromPath(fileName);
                        test.Info(driver.Url);
                        test.Info(Environment.StackTrace.Replace(Environment.NewLine, "<br>"));
                        test.Log(Status.Fail, "<div style= 'color:red; font-weight:bold'>Test_NewBusiness_SortOrderBusinessTimeline FAILED");
                    }
                    else if (TestContext.CurrentContext.Result.Outcome.Status != TestStatus.Failed)
                    {
                        test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Test_NewBusiness_SortOrderBusinessTimeline PASSED");
                    }
                }
            }
        }

        [Test, Retry(3)]
        [Category("Selenium")]
        public void Test_ClientMenu_EditCustomer()
        {
            using (var driver = InitialiseDriver())
            {
                ExtentTest test = null;
                try
                {
                    test = extent.CreateTest("Test_ClientMenu_EditCustomer").Info("<div style= 'color:blue; font-weight:bold'>Test Started");
                    DynamicsLogin dynamicsLogin = new DynamicsLogin(driver);
                    dynamicsLogin.LoginWindow();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Dynamics account selected");

                    Dashboards dashboards = new Dashboards(driver);
                    dashboards.VerifyPageTitle();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'> Homepage Title verified");

                    DataClearup dataClearup = new DataClearup(driver);
                    dataClearup.ClearDataCustomer();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Leftover customer data cleared successfully");

                    ClientMenu clientMenu = new ClientMenu(driver);
                    clientMenu.EditCustomerDetails();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'> Customer details successfully changed from client menu");
                }
                catch (Exception e)
                {
                    Assert.Fail(e.StackTrace);
                }
                finally
                {
                    commonUtils.PrintLogs("browser", driver);

                    if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
                    {
                        string fileName = @"C:\Users\garymoore\OneDrive - Wakefield Council\Desktop\CRMRegressionPack\CRMRegressionPack\Screenshots\" + DateTime.Now.ToString("dd_MM_yy -HH_mm_ss") + ".Png";
                        Screenshot cp = ((ITakesScreenshot)driver).GetScreenshot();
                        cp.SaveAsFile(fileName, ScreenshotImageFormat.Png);
                        test.AddScreenCaptureFromPath(fileName);
                        test.Info(driver.Url);
                        test.Info(Environment.StackTrace.Replace(Environment.NewLine, "<br>"));
                        test.Log(Status.Fail, "<div style= 'color:red; font-weight:bold'>Test_ClientMenu_EditCustomer FAILED");
                    }
                    else if (TestContext.CurrentContext.Result.Outcome.Status != TestStatus.Failed)
                    {
                        test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Test_ClientMenu_EditCustomer PASSED");
                    }
                }
            }
        }

        [Test, Retry(3)]
        [Category("Selenium")]
        public void Test_ClientMenu_EditAnonCustomer()
        {
            using (var driver = InitialiseDriver())
            {
                ExtentTest test = null;
                try
                {
                    test = extent.CreateTest("Test_ClientMenu_EditAnonCustomer").Info("<div style= 'color:blue; font-weight:bold'>Test Started");
                    DynamicsLogin dynamicsLogin = new DynamicsLogin(driver);
                    dynamicsLogin.LoginWindow();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Dynamics account selected");

                    Dashboards dashboards = new Dashboards(driver);
                    dashboards.VerifyPageTitle();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'> Homepage Title verified");

                    ClientMenu clientMenu = new ClientMenu(driver);
                    clientMenu.EditAnonCustomer();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'> Anonymous customer details have not been edited");
                }
                catch (Exception e)
                {
                    Assert.Fail(e.StackTrace);
                }
                finally
                {
                    commonUtils.PrintLogs("browser", driver);

                    if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
                    {
                        string fileName = @"C:\Users\garymoore\OneDrive - Wakefield Council\Desktop\CRMRegressionPack\CRMRegressionPack\Screenshots\" + DateTime.Now.ToString("dd_MM_yy -HH_mm_ss") + ".Png";
                        Screenshot cp = ((ITakesScreenshot)driver).GetScreenshot();
                        cp.SaveAsFile(fileName, ScreenshotImageFormat.Png);
                        test.AddScreenCaptureFromPath(fileName);
                        test.Info(driver.Url);
                        test.Info(Environment.StackTrace.Replace(Environment.NewLine, "<br>"));
                        test.Log(Status.Fail, "<div style= 'color:red; font-weight:bold'>Test_ClientMenu_EditAnonCustomer FAILED");
                    }
                    else if (TestContext.CurrentContext.Result.Outcome.Status != TestStatus.Failed)
                    {
                        test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Test_ClientMenu_EditAnonCustomer PASSED");
                    }
                }
            }
        }

        [Test, Retry(3)]
        [Category("Selenium")]
        public void Test_ClientMenu_EditBusiness()
        {
            using (var driver = InitialiseDriver())
            {
                ExtentTest test = null;
                try
                {
                    test = extent.CreateTest("Test_ClientMenu_EditBusiness").Info("<div style= 'color:blue; font-weight:bold'>Test Started");
                    DynamicsLogin dynamicsLogin = new DynamicsLogin(driver);
                    dynamicsLogin.LoginWindow();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Dynamics account selected");

                    Dashboards dashboards = new Dashboards(driver);
                    dashboards.VerifyPageTitle();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'> Homepage Title verified");

                    DataClearup dataClearup = new DataClearup(driver);
                    dataClearup.DataClearBusiness();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Leftover business data cleared successfully");

                    ClientMenu clientMenu = new ClientMenu(driver);
                    clientMenu.EditBusinessDetails();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'> Customer details successfully changed from client menu");
                }
                catch (Exception e)
                {
                    Assert.Fail(e.StackTrace);
                }
                finally
                {
                    commonUtils.PrintLogs("browser", driver);

                    if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
                    {
                        string fileName = @"C:\Users\garymoore\OneDrive - Wakefield Council\Desktop\CRMRegressionPack\CRMRegressionPack\Screenshots\" + DateTime.Now.ToString("dd_MM_yy -HH_mm_ss") + ".Png";
                        Screenshot cp = ((ITakesScreenshot)driver).GetScreenshot();
                        cp.SaveAsFile(fileName, ScreenshotImageFormat.Png);
                        test.AddScreenCaptureFromPath(fileName);
                        test.Info(driver.Url);
                        test.Info(Environment.StackTrace.Replace(Environment.NewLine, "<br>"));
                        test.Log(Status.Fail, "<div style= 'color:red; font-weight:bold'>Test_ClientMenu_EditBusiness FAILED");
                    }
                    else if (TestContext.CurrentContext.Result.Outcome.Status != TestStatus.Failed)
                    {
                        test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Test_ClientMenu_EditBusiness PASSED");
                    }
                }
            }
        }
       
        [Test, Retry(3)]
        [Category("Selenium")]
        public void Test_ClientMenu_SearchCustomerOnList()
        {
            using (var driver = InitialiseDriver())
            {
                ExtentTest test = null;
                try
                {
                    test = extent.CreateTest("Test_ClientMenu_SearchCustomerOnList").Info("<div style= 'color:blue; font-weight:bold'>Test Started");
                    DynamicsLogin dynamicsLogin = new DynamicsLogin(driver);
                    dynamicsLogin.LoginWindow();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Dynamics account selected");

                    Dashboards dashboards = new Dashboards(driver);
                    dashboards.VerifyPageTitle();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'> Homepage Title verified");

                    DataClearup dataClearup = new DataClearup(driver);
                    dataClearup.ClearDataCustomer();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Leftover customer data cleared successfully");

                    ClientMenu clientMenu = new ClientMenu(driver);
                    clientMenu.SearchCustomerOnActiveContactsList();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'> Customer details successfully changed from client menu");
                }
                catch (Exception e)
                {
                    Assert.Fail(e.StackTrace);
                }
                finally
                {
                    commonUtils.PrintLogs("browser", driver);

                    if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
                    {
                        string fileName = @"C:\Users\garymoore\OneDrive - Wakefield Council\Desktop\CRMRegressionPack\CRMRegressionPack\Screenshots\" + DateTime.Now.ToString("dd_MM_yy -HH_mm_ss") + ".Png";
                        Screenshot cp = ((ITakesScreenshot)driver).GetScreenshot();
                        cp.SaveAsFile(fileName, ScreenshotImageFormat.Png);
                        test.AddScreenCaptureFromPath(fileName);
                        test.Info(driver.Url);
                        test.Info(Environment.StackTrace.Replace(Environment.NewLine, "<br>"));
                        test.Log(Status.Fail, "<div style= 'color:red; font-weight:bold'>Test_ClientMenu_SearchCustomerOnList FAILED");
                    }
                    else if (TestContext.CurrentContext.Result.Outcome.Status != TestStatus.Failed)
                    {
                        test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Test_ClientMenu_SearchCustomerOnList PASSED");
                    }
                }
            }
        }
       
        [Test, Retry(3)]
        [Category("Selenium")]
        public void Test_ClientMenu_SearchBusinessOnList()
        {
            using (var driver = InitialiseDriver())
            {
                ExtentTest test = null;
                try
                {
                    test = extent.CreateTest("Test_ClientMenu_SearchBusinessOnList").Info("<div style= 'color:blue; font-weight:bold'>Test Started");
                    DynamicsLogin dynamicsLogin = new DynamicsLogin(driver);
                    dynamicsLogin.LoginWindow();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Dynamics account selected");

                    Dashboards dashboards = new Dashboards(driver);
                    dashboards.VerifyPageTitle();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'> Homepage Title verified");

                    DataClearup dataClearup = new DataClearup(driver);
                    dataClearup.DataClearBusiness();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Leftover business data cleared successfully");

                    ClientMenu clientMenu = new ClientMenu(driver);
                    clientMenu.SearchBusinessOnActiveContactsList();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'> Customer details successfully changed from client menu");
                }
                catch (Exception e)
                {
                    Assert.Fail(e.StackTrace);
                }
                finally
                {
                    commonUtils.PrintLogs("browser", driver);

                    if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
                    {
                        string fileName = @"C:\Users\garymoore\OneDrive - Wakefield Council\Desktop\CRMRegressionPack\CRMRegressionPack\Screenshots\" + DateTime.Now.ToString("dd_MM_yy -HH_mm_ss") + ".Png";
                        Screenshot cp = ((ITakesScreenshot)driver).GetScreenshot();
                        cp.SaveAsFile(fileName, ScreenshotImageFormat.Png);
                        test.AddScreenCaptureFromPath(fileName);
                        test.Info(driver.Url);
                        test.Info(Environment.StackTrace.Replace(Environment.NewLine, "<br>"));
                        test.Log(Status.Fail, "<div style= 'color:red; font-weight:bold'>Test_ClientMenu_SearchBusinessOnList FAILED");
                    }
                    else if (TestContext.CurrentContext.Result.Outcome.Status != TestStatus.Failed)
                    {
                        test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Test_ClientMenu_SearchBusinessOnList PASSED");
                    }
                }
            }
        }
        
        [Test, Retry(3)]
        [Category("Selenium")]
        public void Test_ClientMenu_SortOrderClientTimeline()
        {
            using (var driver = InitialiseDriver())
            {
                ExtentTest test = null;
                try
                {
                    test = extent.CreateTest("Test_ClientMenu_SortOrderClientTimeline").Info("<div style= 'color:blue; font-weight:bold'>Test Started");
                    DynamicsLogin dynamicsLogin = new DynamicsLogin(driver);
                    dynamicsLogin.LoginWindow();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Dynamics account selected");

                    Dashboards dashboards = new Dashboards(driver);
                    dashboards.VerifyPageTitle();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'> Homepage Title verified");

                    DataClearup dataClearup = new DataClearup(driver);
                    dataClearup.ClearDataCustomer();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Leftover customer data cleared successfully");

                    ClientMenu clientMenu = new ClientMenu(driver);
                    clientMenu.SortOrderClientTimeline();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'> Customer timeline sort order changed successfully");
                }
                catch (Exception e)
                {
                    Assert.Fail(e.StackTrace);
                }
                finally
                {
                    commonUtils.PrintLogs("browser", driver);

                    if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
                    {
                        string fileName = @"C:\Users\garymoore\OneDrive - Wakefield Council\Desktop\CRMRegressionPack\CRMRegressionPack\Screenshots\" + DateTime.Now.ToString("dd_MM_yy -HH_mm_ss") + ".Png";
                        Screenshot cp = ((ITakesScreenshot)driver).GetScreenshot();
                        cp.SaveAsFile(fileName, ScreenshotImageFormat.Png);
                        test.AddScreenCaptureFromPath(fileName);
                        test.Info(driver.Url);
                        test.Info(Environment.StackTrace.Replace(Environment.NewLine, "<br>"));
                        test.Log(Status.Fail, "<div style= 'color:red; font-weight:bold'>Test_ClientMenu_SortOrderClientTimeline FAILED");
                    }
                    else if (TestContext.CurrentContext.Result.Outcome.Status != TestStatus.Failed)
                    {
                        test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Test_ClientMenu_SortOrderClientTimeline PASSED");
                    }
                }
            }
        }

        [Test, Retry(3)]
        [Category("Selenium")]
        public void Test_ClientMenu_AddNoteToClientTimeline()
        {
            using (var driver = InitialiseDriver())
            {
                ExtentTest test = null;
                try
                {
                    test = extent.CreateTest("Test_ClientMenu_AddNoteToClientTimeline").Info("<div style= 'color:blue; font-weight:bold'>Test Started");
                    DynamicsLogin dynamicsLogin = new DynamicsLogin(driver);
                    dynamicsLogin.LoginWindow();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Dynamics account selected");

                    Dashboards dashboards = new Dashboards(driver);
                    dashboards.VerifyPageTitle();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'> Homepage Title verified");

                    DataClearup dataClearup = new DataClearup(driver);
                    dataClearup.ClearDataCustomer();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Leftover customer data cleared successfully");

                    ClientMenu clientMenu = new ClientMenu(driver);
                    clientMenu.AddNoteToClientTimeline();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Note added to customer timeline successfully");
                }
                catch (Exception e)
                {
                    Assert.Fail(e.StackTrace);
                }
                finally
                {
                    commonUtils.PrintLogs("browser", driver);

                    if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
                    {
                        string fileName = @"C:\Users\garymoore\OneDrive - Wakefield Council\Desktop\CRMRegressionPack\CRMRegressionPack\Screenshots\" + DateTime.Now.ToString("dd_MM_yy -HH_mm_ss") + ".Png";
                        Screenshot cp = ((ITakesScreenshot)driver).GetScreenshot();
                        cp.SaveAsFile(fileName, ScreenshotImageFormat.Png);
                        test.AddScreenCaptureFromPath(fileName);
                        test.Info(driver.Url);
                        test.Info(Environment.StackTrace.Replace(Environment.NewLine, "<br>"));
                        test.Log(Status.Fail, "<div style= 'color:red; font-weight:bold'>Test_ClientMenu_AddNoteToClientTimeline FAILED");
                    }
                    else if (TestContext.CurrentContext.Result.Outcome.Status != TestStatus.Failed)
                    {
                        test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Test_ClientMenu_AddNoteToClientTimeline PASSED");
                    }
                }
            }
        }

        [Test, Retry(3)]
        [Category("Selenium")]
        public void Test_ClientMenu_SearchClientTimeline()
        {
            using (var driver = InitialiseDriver())
            {
                ExtentTest test = null;
                try
                {
                    test = extent.CreateTest("Test_ClientMenu_SearchClientTimeline").Info("<div style= 'color:blue; font-weight:bold'>Test Started");
                    DynamicsLogin dynamicsLogin = new DynamicsLogin(driver);
                    dynamicsLogin.LoginWindow();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Dynamics account selected");

                    Dashboards dashboards = new Dashboards(driver);
                    dashboards.VerifyPageTitle();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'> Homepage Title verified");

                    DataClearup dataClearup = new DataClearup(driver);
                    dataClearup.ClearDataCustomer();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Leftover customer data cleared successfully");

                    ClientMenu clientMenu = new ClientMenu(driver);
                    clientMenu.SearchClientTimeline();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'> Customer timeline searched successfully");
                }
                catch (Exception e)
                {
                    Assert.Fail(e.StackTrace);
                }
                finally
                {
                    commonUtils.PrintLogs("browser", driver);

                    if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
                    {
                        string fileName = @"C:\Users\garymoore\OneDrive - Wakefield Council\Desktop\CRMRegressionPack\CRMRegressionPack\Screenshots\" + DateTime.Now.ToString("dd_MM_yy -HH_mm_ss") + ".Png";
                        Screenshot cp = ((ITakesScreenshot)driver).GetScreenshot();
                        cp.SaveAsFile(fileName, ScreenshotImageFormat.Png);
                        test.AddScreenCaptureFromPath(fileName);
                        test.Info(driver.Url);
                        test.Info(Environment.StackTrace.Replace(Environment.NewLine, "<br>"));
                        test.Log(Status.Fail, "<div style= 'color:red; font-weight:bold'>Test_ClientMenu_SearchClientTimeline FAILED");
                    }
                    else if (TestContext.CurrentContext.Result.Outcome.Status != TestStatus.Failed)
                    {
                        test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Test_ClientMenu_SearchClientTimeline PASSED");
                    }
                }
            }
        }

        [Test, Retry(3)]
        [Category("Selenium")]
        public void Test_ClientMenu_FilterClientTimeline()
        {
            using (var driver = InitialiseDriver())
            {
                ExtentTest test = null;
                try
                {
                    test = extent.CreateTest("Test_ClientMenu_FilterClientTimeline").Info("<div style= 'color:blue; font-weight:bold'>Test Started");
                    DynamicsLogin dynamicsLogin = new DynamicsLogin(driver);
                    dynamicsLogin.LoginWindow();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Dynamics account selected");

                    Dashboards dashboards = new Dashboards(driver);
                    dashboards.VerifyPageTitle();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'> Homepage Title verified");

                    DataClearup dataClearup = new DataClearup(driver);
                    dataClearup.ClearDataCustomer();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Leftover customer data cleared successfully");

                    ClientMenu clientMenu = new ClientMenu(driver);
                    clientMenu.FilterClientTimeline();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'> Customer timeline filtered successfully");
                }
                catch (Exception e)
                {
                    Assert.Fail(e.StackTrace);
                }
                finally
                {
                    commonUtils.PrintLogs("browser", driver);

                    if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
                    {
                        string fileName = @"C:\Users\garymoore\OneDrive - Wakefield Council\Desktop\CRMRegressionPack\CRMRegressionPack\Screenshots\" + DateTime.Now.ToString("dd_MM_yy -HH_mm_ss") + ".Png";
                        Screenshot cp = ((ITakesScreenshot)driver).GetScreenshot();
                        cp.SaveAsFile(fileName, ScreenshotImageFormat.Png);
                        test.AddScreenCaptureFromPath(fileName);
                        test.Info(driver.Url);
                        test.Info(Environment.StackTrace.Replace(Environment.NewLine, "<br>"));
                        test.Log(Status.Fail, "<div style= 'color:red; font-weight:bold'>Test_ClientMenu_FilterClientTimeline FAILED");
                    }
                    else if (TestContext.CurrentContext.Result.Outcome.Status != TestStatus.Failed)
                    {
                        test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Test_ClientMenu_FilterClientTimeline PASSED");
                    }
                }
            }
        }

        [Test, Retry(3)]
        [Category("Selenium")]
        public void Test_ClientMenu_CustomerProfileRecentCases()
        {
            using (var driver = InitialiseDriver())
            {
                ExtentTest test = null;
                try
                {
                    test = extent.CreateTest("Test_ClientMenu_CustomerProfileRecentCases").Info("<div style= 'color:blue; font-weight:bold'>Test Started");
                    DynamicsLogin dynamicsLogin = new DynamicsLogin(driver);
                    dynamicsLogin.LoginWindow();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Dynamics account selected");

                    Dashboards dashboards = new Dashboards(driver);
                    dashboards.VerifyPageTitle();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'> Homepage Title verified");

                    ClientMenu clientMenu = new ClientMenu(driver);
                    clientMenu.CustomerProfileRecentCases();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Customer recent cases displayed correctly on profile");
                }
                catch (Exception e)
                {
                    Assert.Fail(e.StackTrace);
                }
                finally
                {
                    commonUtils.PrintLogs("browser", driver);

                    if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
                    {
                        string fileName = @"C:\Users\garymoore\OneDrive - Wakefield Council\Desktop\CRMRegressionPack\CRMRegressionPack\Screenshots\" + DateTime.Now.ToString("dd_MM_yy -HH_mm_ss") + ".Png";
                        Screenshot cp = ((ITakesScreenshot)driver).GetScreenshot();
                        cp.SaveAsFile(fileName, ScreenshotImageFormat.Png);
                        test.AddScreenCaptureFromPath(fileName);
                        test.Info(driver.Url);
                        test.Info(Environment.StackTrace.Replace(Environment.NewLine, "<br>"));
                        test.Log(Status.Fail, "<div style= 'color:red; font-weight:bold'>Test_ClientMenu_CustomerProfileRecentCases FAILED");
                    }
                    else if (TestContext.CurrentContext.Result.Outcome.Status != TestStatus.Failed)
                    {
                        test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Test_ClientMenu_CustomerProfileRecentCases PASSED");
                    }
                }
            }
        }

        [Test, Retry(3)]
        [Category("Selenium")]
        public void Test_ClientMenu_CustomerProfileAlerts()
        {
            using (var driver = InitialiseDriver())
            {
                ExtentTest test = null;
                try
                {
                    test = extent.CreateTest("Test_ClientMenu_CustomerProfileAlerts").Info("<div style= 'color:blue; font-weight:bold'>Test Started");
                    DynamicsLogin dynamicsLogin = new DynamicsLogin(driver);
                    dynamicsLogin.LoginWindow();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Dynamics account selected");

                    Dashboards dashboards = new Dashboards(driver);
                    dashboards.VerifyPageTitle();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'> Homepage Title verified");

                    ClientMenu clientMenu = new ClientMenu(driver);
                    clientMenu.CustomerProfileAlerts();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Customer alerts displayed correctly on profile");
                }
                catch (Exception e)
                {
                    Assert.Fail(e.StackTrace);
                }
                finally
                {
                    commonUtils.PrintLogs("browser", driver);

                    if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
                    {
                        string fileName = @"C:\Users\garymoore\OneDrive - Wakefield Council\Desktop\CRMRegressionPack\CRMRegressionPack\Screenshots\" + DateTime.Now.ToString("dd_MM_yy -HH_mm_ss") + ".Png";
                        Screenshot cp = ((ITakesScreenshot)driver).GetScreenshot();
                        cp.SaveAsFile(fileName, ScreenshotImageFormat.Png);
                        test.AddScreenCaptureFromPath(fileName);
                        test.Info(driver.Url);
                        test.Info(Environment.StackTrace.Replace(Environment.NewLine, "<br>"));
                        test.Log(Status.Fail, "<div style= 'color:red; font-weight:bold'>Test_ClientMenu_CustomerProfileAlerts FAILED");
                    }
                    else if (TestContext.CurrentContext.Result.Outcome.Status != TestStatus.Failed)
                    {
                        test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Test_ClientMenu_CustomerProfileAlerts PASSED");
                    }
                }
            }
        }

        [Test, Retry(3)]
        [Category("Selenium")]
        public void Test_ClientMenu_DuplicateUser()
        {
            using (var driver = InitialiseDriver())
            {
                ExtentTest test = null;
                try
                {
                    test = extent.CreateTest("Test_ClientMenu_DuplicateUser").Info("<div style= 'color:blue; font-weight:bold'>Test Started");
                    DynamicsLogin dynamicsLogin = new DynamicsLogin(driver);
                    dynamicsLogin.LoginWindow();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Dynamics account selected");

                    Dashboards dashboards = new Dashboards(driver);
                    dashboards.VerifyPageTitle();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'> Homepage Title verified");

                    DataClearup dataClearup = new DataClearup(driver);
                    dataClearup.ClearDataCustomer();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Leftover customer data cleared successfully");

                    ClientMenu clientMenu = new ClientMenu(driver);
                    clientMenu.DuplicateUser();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Customer duplicate rule working correctly");
                }
                catch (Exception e)
                {
                    Assert.Fail(e.StackTrace);
                }
                finally
                {
                    commonUtils.PrintLogs("browser", driver);

                    if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
                    {
                        string fileName = @"C:\Users\garymoore\OneDrive - Wakefield Council\Desktop\CRMRegressionPack\CRMRegressionPack\Screenshots\" + DateTime.Now.ToString("dd_MM_yy -HH_mm_ss") + ".Png";
                        Screenshot cp = ((ITakesScreenshot)driver).GetScreenshot();
                        cp.SaveAsFile(fileName, ScreenshotImageFormat.Png);
                        test.AddScreenCaptureFromPath(fileName);
                        test.Info(driver.Url);
                        test.Info(Environment.StackTrace.Replace(Environment.NewLine, "<br>"));
                        test.Log(Status.Fail, "<div style= 'color:red; font-weight:bold'>Test_ClientMenu_DuplicateUser FAILED");
                    }
                    else if (TestContext.CurrentContext.Result.Outcome.Status != TestStatus.Failed)
                    {
                        test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Test_ClientMenu_DuplicateUser PASSED");
                    }
                }
            }
        }

        [Test,Retry(3)]
        [Category("Selenium")]
        public void Test_CasesMenu_SearchForCaseType()
        {
            using (var driver = InitialiseDriver())
            {
                ExtentTest test = null;
                try
                {
                    test = extent.CreateTest("Test_CasesMenu_SearchForCaseType").Info("<div style= 'color:blue; font-weight:bold'>Test Started");
                    DynamicsLogin dynamicsLogin = new DynamicsLogin(driver);
                    dynamicsLogin.LoginWindow();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Dynamics account selected");

                    Dashboards dashboards = new Dashboards(driver);
                    dashboards.VerifyPageTitle();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'> Homepage Title verified");

                    CasesMenu casesMenu = new CasesMenu(driver);
                    casesMenu.SearchForCaseType();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Case type search completed successfully");
                }
                catch (Exception e)
                {
                    Assert.Fail(e.StackTrace);
                }
                finally
                {
                    commonUtils.PrintLogs("browser", driver);

                    if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
                    {
                        string fileName = @"C:\Users\garymoore\OneDrive - Wakefield Council\Desktop\CRMRegressionPack\CRMRegressionPack\Screenshots\" + DateTime.Now.ToString("dd_MM_yy -HH_mm_ss") + ".Png";
                        Screenshot cp = ((ITakesScreenshot)driver).GetScreenshot();
                        cp.SaveAsFile(fileName, ScreenshotImageFormat.Png);
                        test.AddScreenCaptureFromPath(fileName);
                        test.Info(driver.Url);
                        test.Info(Environment.StackTrace.Replace(Environment.NewLine, "<br>"));
                        test.Log(Status.Fail, "<div style= 'color:red; font-weight:bold'>Test_CasesMenu_SearchForCaseType FAILED");
                    }
                    else if (TestContext.CurrentContext.Result.Outcome.Status != TestStatus.Failed)
                    {
                        test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Test_CasesMenu_SearchForCaseType PASSED");
                    }
                }
            }
        }

        [Test,  Retry(3)]
        [Category("Selenium")]
        public void Test_CasesMenu_SearchForCase()
        {
            using (var driver = InitialiseDriver())
            {
                ExtentTest test = null;
                try
                {
                    test = extent.CreateTest("Test_CasesMenu_SearchForCase").Info("<div style= 'color:blue; font-weight:bold'>Test Started");
                    DynamicsLogin dynamicsLogin = new DynamicsLogin(driver);
                    dynamicsLogin.LoginWindow();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Dynamics account selected");

                    Dashboards dashboards = new Dashboards(driver);
                    dashboards.VerifyPageTitle();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'> Homepage Title verified");

                    CasesMenu casesMenu = new CasesMenu(driver);
                    casesMenu.SearchForCase();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Case search completed successfully");
                }
                catch (Exception e)
                {
                    Assert.Fail(e.StackTrace);
                }
                finally
                {
                    commonUtils.PrintLogs("browser", driver);

                    if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
                    {
                        string fileName = @"C:\Users\garymoore\OneDrive - Wakefield Council\Desktop\CRMRegressionPack\CRMRegressionPack\Screenshots\" + DateTime.Now.ToString("dd_MM_yy -HH_mm_ss") + ".Png";
                        Screenshot cp = ((ITakesScreenshot)driver).GetScreenshot();
                        cp.SaveAsFile(fileName, ScreenshotImageFormat.Png);
                        test.AddScreenCaptureFromPath(fileName);
                        test.Info(driver.Url);
                        test.Info(Environment.StackTrace.Replace(Environment.NewLine, "<br>"));
                        test.Log(Status.Fail, "<div style= 'color:red; font-weight:bold'>Test_CasesMenu_SearchForCase FAILED");
                    }
                    else if (TestContext.CurrentContext.Result.Outcome.Status != TestStatus.Failed)
                    {
                        test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Test_CasesMenu_SearchForCase PASSED");
                    }
                }
            }
        }

        [Test, Retry(3)]
        [Category("Selenium")]
        public void Test_CasesMenu_AddFurtherContact()
        {
            using (var driver = InitialiseDriver())
            {
                ExtentTest test = null;
                try
                {
                    test = extent.CreateTest("Test_CasesMenu_AddFurtherContact").Info("<div style= 'color:blue; font-weight:bold'>Test Started");
                    DynamicsLogin dynamicsLogin = new DynamicsLogin(driver);
                    dynamicsLogin.LoginWindow();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Dynamics account selected");

                    Dashboards dashboards = new Dashboards(driver);
                    dashboards.VerifyPageTitle();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'> Homepage Title verified");

                    CasesMenu casesMenu = new CasesMenu(driver);
                    casesMenu.AddFurtherContact();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Further contact added successfully");
                }
                catch (Exception e)
                {
                    Assert.Fail(e.StackTrace);
                }
                finally
                {
                    commonUtils.PrintLogs("browser", driver);

                    if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
                    {
                        string fileName = @"C:\Users\garymoore\OneDrive - Wakefield Council\Desktop\CRMRegressionPack\CRMRegressionPack\Screenshots\" + DateTime.Now.ToString("dd_MM_yy -HH_mm_ss") + ".Png";
                        Screenshot cp = ((ITakesScreenshot)driver).GetScreenshot();
                        cp.SaveAsFile(fileName, ScreenshotImageFormat.Png);
                        test.AddScreenCaptureFromPath(fileName);
                        test.Info(driver.Url);
                        test.Info(Environment.StackTrace.Replace(Environment.NewLine, "<br>"));
                        test.Log(Status.Fail, "<div style= 'color:red; font-weight:bold'>Test_CasesMenu_AddFurtherContact FAILED");
                    }
                    else if (TestContext.CurrentContext.Result.Outcome.Status != TestStatus.Failed)
                    {
                        test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Test_CasesMenu_AddFurtherContact PASSED");
                    }
                }
            }
        }

        [Test, Retry(3)]
        [Category("Selenium")]
        public void Test_CasesMenu_RecentCasesOnCaseForm()
        {
            using (var driver = InitialiseDriver())
            {
                ExtentTest test = null;
                try
                {
                    test = extent.CreateTest("Test_CasesMenu_RecentCasesOnCaseForm").Info("<div style= 'color:blue; font-weight:bold'>Test Started");
                    DynamicsLogin dynamicsLogin = new DynamicsLogin(driver);
                    dynamicsLogin.LoginWindow();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Dynamics account selected");

                    Dashboards dashboards = new Dashboards(driver);
                    dashboards.VerifyPageTitle();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'> Homepage Title verified");

                    CasesMenu casesMenu = new CasesMenu(driver);
                    casesMenu.RecentCasesOnCaseForm();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Recent cases displayed correctly on case form");
                }
                catch (Exception e)
                {
                    Assert.Fail(e.StackTrace);
                }
                finally
                {
                    commonUtils.PrintLogs("browser", driver);

                    if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
                    {
                        string fileName = @"C:\Users\garymoore\OneDrive - Wakefield Council\Desktop\CRMRegressionPack\CRMRegressionPack\Screenshots\" + DateTime.Now.ToString("dd_MM_yy -HH_mm_ss") + ".Png";
                        Screenshot cp = ((ITakesScreenshot)driver).GetScreenshot();
                        cp.SaveAsFile(fileName, ScreenshotImageFormat.Png);
                        test.AddScreenCaptureFromPath(fileName);
                        test.Info(driver.Url);
                        test.Info(Environment.StackTrace.Replace(Environment.NewLine, "<br>"));
                        test.Log(Status.Fail, "<div style= 'color:red; font-weight:bold'>Test_CasesMenu_RecentCasesOnCaseForm FAILED");
                    }
                    else if (TestContext.CurrentContext.Result.Outcome.Status != TestStatus.Failed)
                    {
                        test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Test_CasesMenu_RecentCasesOnCaseForm PASSED");
                    }
                }
            }
        }

        [Test, Retry(3)]
        [Category("Selenium")]
        public void Test_CasesMenu_AddFurtherContactBusiness()
        {
            using (var driver = InitialiseDriver())
            {
                ExtentTest test = null;
                try
                {
                    test = extent.CreateTest("Test_CasesMenu_AddFurtherContactBusiness").Info("<div style= 'color:blue; font-weight:bold'>Test Started");
                    DynamicsLogin dynamicsLogin = new DynamicsLogin(driver);
                    dynamicsLogin.LoginWindow();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Dynamics account selected");

                    Dashboards dashboards = new Dashboards(driver);
                    dashboards.VerifyPageTitle();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'> Homepage Title verified");

                    CasesMenu casesMenu = new CasesMenu(driver);
                    casesMenu.AddFurtherContactBusiness();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Further contact added successfully");
                }
                catch (Exception e)
                {
                    Assert.Fail(e.StackTrace);
                }
                finally
                {
                    commonUtils.PrintLogs("browser", driver);

                    if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
                    {
                        string fileName = @"C:\Users\garymoore\OneDrive - Wakefield Council\Desktop\CRMRegressionPack\CRMRegressionPack\Screenshots\" + DateTime.Now.ToString("dd_MM_yy -HH_mm_ss") + ".Png";
                        Screenshot cp = ((ITakesScreenshot)driver).GetScreenshot();
                        cp.SaveAsFile(fileName, ScreenshotImageFormat.Png);
                        test.AddScreenCaptureFromPath(fileName);
                        test.Info(driver.Url);
                        test.Info(Environment.StackTrace.Replace(Environment.NewLine, "<br>"));
                        test.Log(Status.Fail, "<div style= 'color:red; font-weight:bold'>Test_CasesMenu_AddFurtherContactBusiness FAILED");
                    }
                    else if (TestContext.CurrentContext.Result.Outcome.Status != TestStatus.Failed)
                    {
                        test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Test_CasesMenu_AddFurtherContactBusiness PASSED");
                    }
                }
            }
        }

        [Test, Retry(3)]
        [Category("Selenium")]
        public void Test_CasesMenu_FurtherContactBusinessNoNotify()
        {
            using (var driver = InitialiseDriver())
            {
                ExtentTest test = null;
                try
                {
                    test = extent.CreateTest("Test_CasesMenu_FurtherContactBusinessNoNotify").Info("<div style= 'color:blue; font-weight:bold'>Test Started");
                    DynamicsLogin dynamicsLogin = new DynamicsLogin(driver);
                    dynamicsLogin.LoginWindow();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Dynamics account selected");

                    Dashboards dashboards = new Dashboards(driver);
                    dashboards.VerifyPageTitle();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'> Homepage Title verified");

                    CasesMenu casesMenu = new CasesMenu(driver);
                    casesMenu.FurtherContactBusinessNoNotify();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Further contact added successfully");
                }
                catch (Exception e)
                {
                    Assert.Fail(e.StackTrace);
                }
                finally
                {
                    commonUtils.PrintLogs("browser", driver);

                    if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
                    {
                        string fileName = @"C:\Users\garymoore\OneDrive - Wakefield Council\Desktop\CRMRegressionPack\CRMRegressionPack\Screenshots\" + DateTime.Now.ToString("dd_MM_yy -HH_mm_ss") + ".Png";
                        Screenshot cp = ((ITakesScreenshot)driver).GetScreenshot();
                        cp.SaveAsFile(fileName, ScreenshotImageFormat.Png);
                        test.AddScreenCaptureFromPath(fileName);
                        test.Info(driver.Url);
                        test.Info(Environment.StackTrace.Replace(Environment.NewLine, "<br>"));
                        test.Log(Status.Fail, "<div style= 'color:red; font-weight:bold'>Test_CasesMenu_FurtherContactBusinessNoNotify FAILED");
                    }
                    else if (TestContext.CurrentContext.Result.Outcome.Status != TestStatus.Failed)
                    {
                        test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Test_CasesMenu_FurtherContactBusinessNoNotify PASSED");
                    }
                }
            }
        }

        [Test, Retry(3)]
        [Category("Selenium")]
        public void Test_CaseSummary_AllocatingCaseStatus()
        {
            using (var driver = InitialiseDriver())
            {
                ExtentTest test = null;
                try
                {
                    test = extent.CreateTest("Test_CaseSummary_AllocatingCaseStatus").Info("<div style= 'color:blue; font-weight:bold'>Test Started");
                    DynamicsLogin dynamicsLogin = new DynamicsLogin(driver);
                    dynamicsLogin.LoginWindow();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Dynamics account selected");

                    Dashboards dashboards = new Dashboards(driver);
                    dashboards.VerifyPageTitle();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'> Homepage Title verified");

                    DataClearup dataClearup = new DataClearup(driver);
                    dataClearup.ClearDataCustomer();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Leftover customer data cleared successfully");

                    CaseSummary caseSummary = new CaseSummary(driver);
                    caseSummary.AllocatingCaseStatus();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Case status allocated correctly");
                }
                catch (Exception e)
                {
                    Assert.Fail(e.StackTrace);
                }
                finally
                {
                    commonUtils.PrintLogs("browser", driver);

                    if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
                    {
                        string fileName = @"C:\Users\garymoore\OneDrive - Wakefield Council\Desktop\CRMRegressionPack\CRMRegressionPack\Screenshots\" + DateTime.Now.ToString("dd_MM_yy -HH_mm_ss") + ".Png";
                        Screenshot cp = ((ITakesScreenshot)driver).GetScreenshot();
                        cp.SaveAsFile(fileName, ScreenshotImageFormat.Png);
                        test.AddScreenCaptureFromPath(fileName);
                        test.Info(driver.Url);
                        test.Info(Environment.StackTrace.Replace(Environment.NewLine, "<br>"));
                        test.Log(Status.Fail, "<div style= 'color:red; font-weight:bold'>Test_CaseSummary_AllocatingCaseStatus FAILED");
                    }
                    else if (TestContext.CurrentContext.Result.Outcome.Status != TestStatus.Failed)
                    {
                        test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Test_CaseSummary_AllocatingCaseStatus PASSED");
                    }
                }
            }
        }

        [Test, Retry(3)]
        [Category("Selenium")]
        public void Test_CaseSummary_AllocateCaseStatusOOACustomer()
        {
            using (var driver = InitialiseDriver())
            {
                ExtentTest test = null;
                try
                {
                    test = extent.CreateTest("Test_CaseSummary_AllocateCaseStatusOOACustomer").Info("<div style= 'color:blue; font-weight:bold'>Test Started");
                    DynamicsLogin dynamicsLogin = new DynamicsLogin(driver);
                    dynamicsLogin.LoginWindow();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Dynamics account selected");

                    Dashboards dashboards = new Dashboards(driver);
                    dashboards.VerifyPageTitle();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'> Homepage Title verified");

                    DataClearup dataClearup = new DataClearup(driver);
                    dataClearup.ClearDataCustomer();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Leftover customer data cleared successfully");

                    CaseSummary caseSummary = new CaseSummary(driver);
                    caseSummary.AllocateCaseStatusOOACustomer();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Case status allocated correctly for out of area customer");
                }
                catch (Exception e)
                {
                    Assert.Fail(e.StackTrace);
                }
                finally
                {
                    commonUtils.PrintLogs("browser", driver);

                    if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
                    {
                        string fileName = @"C:\Users\garymoore\OneDrive - Wakefield Council\Desktop\CRMRegressionPack\CRMRegressionPack\Screenshots\" + DateTime.Now.ToString("dd_MM_yy -HH_mm_ss") + ".Png";
                        Screenshot cp = ((ITakesScreenshot)driver).GetScreenshot();
                        cp.SaveAsFile(fileName, ScreenshotImageFormat.Png);
                        test.AddScreenCaptureFromPath(fileName);
                        test.Info(driver.Url);
                        test.Info(Environment.StackTrace.Replace(Environment.NewLine, "<br>"));
                        test.Log(Status.Fail, "<div style= 'color:red; font-weight:bold'>Test_CaseSummary_AllocateCaseStatusOOACustomer FAILED");
                    }
                    else if (TestContext.CurrentContext.Result.Outcome.Status != TestStatus.Failed)
                    {
                        test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Test_CaseSummary_AllocateCaseStatusOOACustomer PASSED");
                    }
                }
            }
        }

        [Test, Retry(3)]
        [Category("Selenium")]
        public void Test_CaseSummary_AllocatingCaseStatusManualAddress()
        {
            using (var driver = InitialiseDriver())
            {
                ExtentTest test = null;
                try
                {
                    test = extent.CreateTest("Test_CaseSummary_AllocatingCaseStatusManualAddress").Info("<div style= 'color:blue; font-weight:bold'>Test Started");
                    DynamicsLogin dynamicsLogin = new DynamicsLogin(driver);
                    dynamicsLogin.LoginWindow();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Dynamics account selected");

                    Dashboards dashboards = new Dashboards(driver);
                    dashboards.VerifyPageTitle();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'> Homepage Title verified");

                    DataClearup dataClearup = new DataClearup(driver);
                    dataClearup.ClearDataCustomer();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Leftover customer data cleared successfully");

                    CaseSummary caseSummary = new CaseSummary(driver);
                    caseSummary.AllocatingCaseStatusManualAddress();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Case status allocated correctly for customer with manual address");
                }
                catch (Exception e)
                {
                    Assert.Fail(e.StackTrace);
                }
                finally
                {
                    commonUtils.PrintLogs("browser", driver);

                    if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
                    {
                        string fileName = @"C:\Users\garymoore\OneDrive - Wakefield Council\Desktop\CRMRegressionPack\CRMRegressionPack\Screenshots\" + DateTime.Now.ToString("dd_MM_yy -HH_mm_ss") + ".Png";
                        Screenshot cp = ((ITakesScreenshot)driver).GetScreenshot();
                        cp.SaveAsFile(fileName, ScreenshotImageFormat.Png);
                        test.AddScreenCaptureFromPath(fileName);
                        test.Info(driver.Url);
                        test.Info(Environment.StackTrace.Replace(Environment.NewLine, "<br>"));
                        test.Log(Status.Fail, "<div style= 'color:red; font-weight:bold'>Test_CaseSummary_AllocatingCaseStatusManualAddress FAILED");
                    }
                    else if (TestContext.CurrentContext.Result.Outcome.Status != TestStatus.Failed)
                    {
                        test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Test_CaseSummary_AllocatingCaseStatusManualAddress PASSED");
                    }
                }
            }
        }

        [Test, Retry(3)]
        [Category("Selenium")]
        public void Test_CaseSummary_AllocatingCaseStatusAnonCustomer()
        {
            using (var driver = InitialiseDriver())
            {
                ExtentTest test = null;
                try
                {
                    test = extent.CreateTest("Test_CaseSummary_AllocatingCaseStatusAnonCustomer").Info("<div style= 'color:blue; font-weight:bold'>Test Started");
                    DynamicsLogin dynamicsLogin = new DynamicsLogin(driver);
                    dynamicsLogin.LoginWindow();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Dynamics account selected");

                    Dashboards dashboards = new Dashboards(driver);
                    dashboards.VerifyPageTitle();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'> Homepage Title verified");

                    DataClearup dataClearup = new DataClearup(driver);
                    dataClearup.ClearDataCustomer();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Leftover customer data cleared successfully");

                    CaseSummary caseSummary = new CaseSummary(driver);
                    caseSummary.AllocatingCaseStatusAnonCustomer();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Case status allocated correctly for anonymous customer");
                }
                catch (Exception e)
                {
                    Assert.Fail(e.StackTrace);
                }
                finally
                {
                    commonUtils.PrintLogs("browser", driver);

                    if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
                    {
                        string fileName = @"C:\Users\garymoore\OneDrive - Wakefield Council\Desktop\CRMRegressionPack\CRMRegressionPack\Screenshots\" + DateTime.Now.ToString("dd_MM_yy -HH_mm_ss") + ".Png";
                        Screenshot cp = ((ITakesScreenshot)driver).GetScreenshot();
                        cp.SaveAsFile(fileName, ScreenshotImageFormat.Png);
                        test.AddScreenCaptureFromPath(fileName);
                        test.Info(driver.Url);
                        test.Info(Environment.StackTrace.Replace(Environment.NewLine, "<br>"));
                        test.Log(Status.Fail, "<div style= 'color:red; font-weight:bold'>Test_CaseSummary_AllocatingCaseStatusAnonCustomer FAILED");
                    }
                    else if (TestContext.CurrentContext.Result.Outcome.Status != TestStatus.Failed)
                    {
                        test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Test_CaseSummary_AllocatingCaseStatusAnonCustomer PASSED");
                    }
                }
            }
        }

        [Test, Retry(3)]
        [Category("Selenium")]
        public void Test_CaseSummary_AllocatingCaseStatusUnknownAddress()
        {
            using (var driver = InitialiseDriver())
            {
                ExtentTest test = null;
                try
                {
                    test = extent.CreateTest("Test_CaseSummary_AllocatingCaseStatusUnknownAddress").Info("<div style= 'color:blue; font-weight:bold'>Test Started");
                    DynamicsLogin dynamicsLogin = new DynamicsLogin(driver);
                    dynamicsLogin.LoginWindow();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Dynamics account selected");

                    Dashboards dashboards = new Dashboards(driver);
                    dashboards.VerifyPageTitle();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'> Homepage Title verified");

                    DataClearup dataClearup = new DataClearup(driver);
                    dataClearup.ClearDataCustomer();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Leftover customer data cleared successfully");

                    CaseSummary caseSummary = new CaseSummary(driver);
                    caseSummary.AllocatingCaseStatusUnknownAddress();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Case status allocated correctly");
                }
                catch (Exception e)
                {
                    Assert.Fail(e.StackTrace);
                }
                finally
                {
                    commonUtils.PrintLogs("browser", driver);

                    if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
                    {
                        string fileName = @"C:\Users\garymoore\OneDrive - Wakefield Council\Desktop\CRMRegressionPack\CRMRegressionPack\Screenshots\" + DateTime.Now.ToString("dd_MM_yy -HH_mm_ss") + ".Png";
                        Screenshot cp = ((ITakesScreenshot)driver).GetScreenshot();
                        cp.SaveAsFile(fileName, ScreenshotImageFormat.Png);
                        test.AddScreenCaptureFromPath(fileName);
                        test.Info(driver.Url);
                        test.Info(Environment.StackTrace.Replace(Environment.NewLine, "<br>"));
                        test.Log(Status.Fail, "<div style= 'color:red; font-weight:bold'>Test_CaseSummary_AllocatingCaseStatusUnknownAddress FAILED");
                    }
                    else if (TestContext.CurrentContext.Result.Outcome.Status != TestStatus.Failed)
                    {
                        test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Test_CaseSummary_AllocatingCaseStatusUnknownAddress PASSED");
                    }
                }
            }
        }

        [Test, Retry(3)]
        [Category("Selenium")]
        public void Test_CaseSummary_AllocatingCaseStatusOnBehalfOf()
        {
            using (var driver = InitialiseDriver())
            {
                ExtentTest test = null;
                try
                {
                    test = extent.CreateTest("Test_CaseSummary_AllocatingCaseStatusOnBehalfOf").Info("<div style= 'color:blue; font-weight:bold'>Test Started");
                    DynamicsLogin dynamicsLogin = new DynamicsLogin(driver);
                    dynamicsLogin.LoginWindow();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Dynamics account selected");

                    Dashboards dashboards = new Dashboards(driver);
                    dashboards.VerifyPageTitle();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'> Homepage Title verified");

                    CaseSummary caseSummary = new CaseSummary(driver);
                    caseSummary.AllocatingCaseStatusOnBehalfOf();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Case status allocated correctly");
                }
                catch (Exception e)
                {
                    Assert.Fail(e.StackTrace);
                }
                finally
                {
                    commonUtils.PrintLogs("browser", driver);

                    if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
                    {
                        string fileName = @"C:\Users\garymoore\OneDrive - Wakefield Council\Desktop\CRMRegressionPack\CRMRegressionPack\Screenshots\" + DateTime.Now.ToString("dd_MM_yy -HH_mm_ss") + ".Png";
                        Screenshot cp = ((ITakesScreenshot)driver).GetScreenshot();
                        cp.SaveAsFile(fileName, ScreenshotImageFormat.Png);
                        test.AddScreenCaptureFromPath(fileName);
                        test.Info(driver.Url);
                        test.Info(Environment.StackTrace.Replace(Environment.NewLine, "<br>"));
                        test.Log(Status.Fail, "<div style= 'color:red; font-weight:bold'>Test_CaseSummary_AllocatingCaseStatusOnBehalfOf FAILED");
                    }
                    else if (TestContext.CurrentContext.Result.Outcome.Status != TestStatus.Failed)
                    {
                        test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Test_CaseSummary_AllocatingCaseStatusOnBehalfOf PASSED");
                    }
                }
            }
        }

        [Test, Retry(3)]
        [Category("Selenium")]
        public void Test_CaseSummary_AllocatingCaseStatusBusiness()
        {
            using (var driver = InitialiseDriver())
            {
                ExtentTest test = null;
                try
                {
                    test = extent.CreateTest("Test_CaseSummary_AllocatingCaseStatusBusiness").Info("<div style= 'color:blue; font-weight:bold'>Test Started");
                    DynamicsLogin dynamicsLogin = new DynamicsLogin(driver);
                    dynamicsLogin.LoginWindow();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Dynamics account selected");

                    Dashboards dashboards = new Dashboards(driver);
                    dashboards.VerifyPageTitle();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'> Homepage Title verified");

                    DataClearup dataClearup = new DataClearup(driver);
                    dataClearup.ClearDataCustomer();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Leftover customer data cleared successfully");

                    CaseSummary caseSummary = new CaseSummary(driver);
                    caseSummary.AllocatingCaseStatusBusiness();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Case status allocated correctly");
                }
                catch (Exception e)
                {
                    Assert.Fail(e.StackTrace);
                }
                finally
                {
                    commonUtils.PrintLogs("browser", driver);

                    if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
                    {
                        string fileName = @"C:\Users\garymoore\OneDrive - Wakefield Council\Desktop\CRMRegressionPack\CRMRegressionPack\Screenshots\" + DateTime.Now.ToString("dd_MM_yy -HH_mm_ss") + ".Png";
                        Screenshot cp = ((ITakesScreenshot)driver).GetScreenshot();
                        cp.SaveAsFile(fileName, ScreenshotImageFormat.Png);
                        test.AddScreenCaptureFromPath(fileName);
                        test.Info(driver.Url);
                        test.Info(Environment.StackTrace.Replace(Environment.NewLine, "<br>"));
                        test.Log(Status.Fail, "<div style= 'color:red; font-weight:bold'>Test_CaseSummary_AllocatingCaseStatusBusiness FAILED");
                    }
                    else if (TestContext.CurrentContext.Result.Outcome.Status != TestStatus.Failed)
                    {
                        test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Test_CaseSummary_AllocatingCaseStatusBusiness PASSED");
                    }
                }
            }
        }

        [Test, Retry(3)]
        [Category("Selenium")]
        public void Test_CaseSummary_AllocatingCaseStatusBusinessUA()
        {
            using (var driver = InitialiseDriver())
            {
                ExtentTest test = null;
                try
                {
                    test = extent.CreateTest("Test_CaseSummary_AllocatingCaseStatusBusinessUA").Info("<div style= 'color:blue; font-weight:bold'>Test Started");
                    DynamicsLogin dynamicsLogin = new DynamicsLogin(driver);
                    dynamicsLogin.LoginWindow();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Dynamics account selected");

                    Dashboards dashboards = new Dashboards(driver);
                    dashboards.VerifyPageTitle();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'> Homepage Title verified");

                    DataClearup dataClearup = new DataClearup(driver);
                    dataClearup.ClearDataCustomer();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Leftover customer data cleared successfully");

                    CaseSummary caseSummary = new CaseSummary(driver);
                    caseSummary.AllocatingCaseStatusBusinessUA();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Case status allocated correctly");
                }
                catch (Exception e)
                {
                    Assert.Fail(e.StackTrace);
                }
                finally
                {
                    commonUtils.PrintLogs("browser", driver);

                    if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
                    {
                        string fileName = @"C:\Users\garymoore\OneDrive - Wakefield Council\Desktop\CRMRegressionPack\CRMRegressionPack\Screenshots\" + DateTime.Now.ToString("dd_MM_yy -HH_mm_ss") + ".Png";
                        Screenshot cp = ((ITakesScreenshot)driver).GetScreenshot();
                        cp.SaveAsFile(fileName, ScreenshotImageFormat.Png);
                        test.AddScreenCaptureFromPath(fileName);
                        test.Info(driver.Url);
                        test.Info(Environment.StackTrace.Replace(Environment.NewLine, "<br>"));
                        test.Log(Status.Fail, "<div style= 'color:red; font-weight:bold'>Test_CaseSummary_AllocatingCaseStatusBusinessUA FAILED");
                    }
                    else if (TestContext.CurrentContext.Result.Outcome.Status != TestStatus.Failed)
                    {
                        test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Test_CaseSummary_AllocatingCaseStatusBusinessUA PASSED");
                    }
                }
            }
        }

        [Test, Retry(3)]
        [Category("Selenium")]
        public void Test_CaseSummary_AllocatingCaseStatusOnBehalfOfBusiness()
        {
            using (var driver = InitialiseDriver())
            {
                ExtentTest test = null;
                try
                {
                    test = extent.CreateTest("Test_CaseSummary_AllocatingCaseStatusOnBehalfOfBusiness").Info("<div style= 'color:blue; font-weight:bold'>Test Started");
                    DynamicsLogin dynamicsLogin = new DynamicsLogin(driver);
                    dynamicsLogin.LoginWindow();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Dynamics account selected");

                    Dashboards dashboards = new Dashboards(driver);
                    dashboards.VerifyPageTitle();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'> Homepage Title verified");

                    CaseSummary caseSummary = new CaseSummary(driver);
                    caseSummary.AllocatingCaseStatusOnBehalfOfBusiness();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Case status allocated correctly");
                }
                catch (Exception e)
                {
                    Assert.Fail(e.StackTrace);
                }
                finally
                {
                    commonUtils.PrintLogs("browser", driver);

                    if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
                    {
                        string fileName = @"C:\Users\garymoore\OneDrive - Wakefield Council\Desktop\CRMRegressionPack\CRMRegressionPack\Screenshots\" + DateTime.Now.ToString("dd_MM_yy -HH_mm_ss") + ".Png";
                        Screenshot cp = ((ITakesScreenshot)driver).GetScreenshot();
                        cp.SaveAsFile(fileName, ScreenshotImageFormat.Png);
                        test.AddScreenCaptureFromPath(fileName);
                        test.Info(driver.Url);
                        test.Info(Environment.StackTrace.Replace(Environment.NewLine, "<br>"));
                        test.Log(Status.Fail, "<div style= 'color:red; font-weight:bold'>Test_CaseSummary_AllocatingCaseStatusOnBehalfOfBusiness FAILED");
                    }
                    else if (TestContext.CurrentContext.Result.Outcome.Status != TestStatus.Failed)
                    {
                        test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Test_CaseSummary_AllocatingCaseStatusOnBehalfOfBusiness PASSED");
                    }
                }
            }
        }

        [Test, Retry(3)]
        [Category("Selenium")]
        public void Test_CaseSummary_CustomerRejectCase()
        {
            using (var driver = InitialiseDriver())
            {
                ExtentTest test = null;
                try
                {
                    test = extent.CreateTest("Test_CaseSummary_CustomerRejectCase").Info("<div style= 'color:blue; font-weight:bold'>Test Started");
                    DynamicsLogin dynamicsLogin = new DynamicsLogin(driver);
                    dynamicsLogin.LoginWindow();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Dynamics account selected");

                    Dashboards dashboards = new Dashboards(driver);
                    dashboards.VerifyPageTitle();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'> Homepage Title verified");

                    CaseSummary caseSummary = new CaseSummary(driver);
                    caseSummary.CustomerRejectCase();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Case status correctly set to rejected");
                }
                catch (Exception e)
                {
                    Assert.Fail(e.StackTrace);
                }
                finally
                {
                    commonUtils.PrintLogs("browser", driver);

                    if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
                    {
                        string fileName = @"C:\Users\garymoore\OneDrive - Wakefield Council\Desktop\CRMRegressionPack\CRMRegressionPack\Screenshots\" + DateTime.Now.ToString("dd_MM_yy -HH_mm_ss") + ".Png";
                        Screenshot cp = ((ITakesScreenshot)driver).GetScreenshot();
                        cp.SaveAsFile(fileName, ScreenshotImageFormat.Png);
                        test.AddScreenCaptureFromPath(fileName);
                        test.Info(driver.Url);
                        test.Info(Environment.StackTrace.Replace(Environment.NewLine, "<br>"));
                        test.Log(Status.Fail, "<div style= 'color:red; font-weight:bold'>Test_CaseSummary_CustomerRejectCase FAILED");
                    }
                    else if (TestContext.CurrentContext.Result.Outcome.Status != TestStatus.Failed)
                    {
                        test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Test_CaseSummary_CustomerRejectCase PASSED");
                    }
                }
            }
        }

        [Test, Retry(3)]
        [Category("Selenium")]
        public void Test_CaseSummary_AnonCustomerRejectCase()
        {
            using (var driver = InitialiseDriver())
            {
                ExtentTest test = null;
                try
                {
                    test = extent.CreateTest("Test_CaseSummary_AnonCustomerRejectCase").Info("<div style= 'color:blue; font-weight:bold'>Test Started");
                    DynamicsLogin dynamicsLogin = new DynamicsLogin(driver);
                    dynamicsLogin.LoginWindow();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Dynamics account selected");

                    Dashboards dashboards = new Dashboards(driver);
                    dashboards.VerifyPageTitle();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'> Homepage Title verified");

                    CaseSummary caseSummary = new CaseSummary(driver);
                    caseSummary.AnonCustomerRejectCase();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Case status correctly set to rejected");
                }
                catch (Exception e)
                {
                    Assert.Fail(e.StackTrace);
                }
                finally
                {
                    commonUtils.PrintLogs("browser", driver);

                    if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
                    {
                        string fileName = @"C:\Users\garymoore\OneDrive - Wakefield Council\Desktop\CRMRegressionPack\CRMRegressionPack\Screenshots\" + DateTime.Now.ToString("dd_MM_yy -HH_mm_ss") + ".Png";
                        Screenshot cp = ((ITakesScreenshot)driver).GetScreenshot();
                        cp.SaveAsFile(fileName, ScreenshotImageFormat.Png);
                        test.AddScreenCaptureFromPath(fileName);
                        test.Info(driver.Url);
                        test.Info(Environment.StackTrace.Replace(Environment.NewLine, "<br>"));
                        test.Log(Status.Fail, "<div style= 'color:red; font-weight:bold'>Test_CaseSummary_AnonCustomerRejectCase FAILED");
                    }
                    else if (TestContext.CurrentContext.Result.Outcome.Status != TestStatus.Failed)
                    {
                        test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Test_CaseSummary_AnonCustomerRejectCase PASSED");
                    }
                }
            }
        }

        [Test, Retry(3)]
        [Category("Selenium")]
        public void Test_CaseSummary_OOACustomerRejectCase()
        {
            using (var driver = InitialiseDriver())
            {
                ExtentTest test = null;
                try
                {
                    test = extent.CreateTest("Test_CaseSummary_OOACustomerRejectCase").Info("<div style= 'color:blue; font-weight:bold'>Test Started");
                    DynamicsLogin dynamicsLogin = new DynamicsLogin(driver);
                    dynamicsLogin.LoginWindow();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Dynamics account selected");

                    Dashboards dashboards = new Dashboards(driver);
                    dashboards.VerifyPageTitle();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'> Homepage Title verified");

                    CaseSummary caseSummary = new CaseSummary(driver);
                    caseSummary.OOACustomerRejectCase();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Case status correctly set to rejected for out of area customer");
                }
                catch (Exception e)
                {
                    Assert.Fail(e.StackTrace);
                }
                finally
                {
                    commonUtils.PrintLogs("browser", driver);

                    if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
                    {
                        string fileName = @"C:\Users\garymoore\OneDrive - Wakefield Council\Desktop\CRMRegressionPack\CRMRegressionPack\Screenshots\" + DateTime.Now.ToString("dd_MM_yy -HH_mm_ss") + ".Png";
                        Screenshot cp = ((ITakesScreenshot)driver).GetScreenshot();
                        cp.SaveAsFile(fileName, ScreenshotImageFormat.Png);
                        test.AddScreenCaptureFromPath(fileName);
                        test.Info(driver.Url);
                        test.Info(Environment.StackTrace.Replace(Environment.NewLine, "<br>"));
                        test.Log(Status.Fail, "<div style= 'color:red; font-weight:bold'>Test_CaseSummary_OOACustomerRejectCase FAILED");
                    }
                    else if (TestContext.CurrentContext.Result.Outcome.Status != TestStatus.Failed)
                    {
                        test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Test_CaseSummary_OOACustomerRejectCase PASSED");
                    }
                }
            }
        }

        [Test, Retry(3)]
        [Category("Selenium")]
        public void Test_CaseSummary_ManualAddressCustomerRejectCase()
        {
            using (var driver = InitialiseDriver())
            {
                ExtentTest test = null;
                try
                {
                    test = extent.CreateTest("Test_CaseSummary_ManualAddressCustomerRejectCase").Info("<div style= 'color:blue; font-weight:bold'>Test Started");
                    DynamicsLogin dynamicsLogin = new DynamicsLogin(driver);
                    dynamicsLogin.LoginWindow();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Dynamics account selected");

                    Dashboards dashboards = new Dashboards(driver);
                    dashboards.VerifyPageTitle();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'> Homepage Title verified");

                    CaseSummary caseSummary = new CaseSummary(driver);
                    caseSummary.ManualAddressCustomerRejectCase();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Case status correctly set to rejected for customer with manually added address");
                }
                catch (Exception e)
                {
                    Assert.Fail(e.StackTrace);
                }
                finally
                {
                    commonUtils.PrintLogs("browser", driver);

                    if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
                    {
                        string fileName = @"C:\Users\garymoore\OneDrive - Wakefield Council\Desktop\CRMRegressionPack\CRMRegressionPack\Screenshots\" + DateTime.Now.ToString("dd_MM_yy -HH_mm_ss") + ".Png";
                        Screenshot cp = ((ITakesScreenshot)driver).GetScreenshot();
                        cp.SaveAsFile(fileName, ScreenshotImageFormat.Png);
                        test.AddScreenCaptureFromPath(fileName);
                        test.Info(driver.Url);
                        test.Info(Environment.StackTrace.Replace(Environment.NewLine, "<br>"));
                        test.Log(Status.Fail, "<div style= 'color:red; font-weight:bold'>Test_CaseSummary_ManualAddressCustomerRejectCase FAILED");
                    }
                    else if (TestContext.CurrentContext.Result.Outcome.Status != TestStatus.Failed)
                    {
                        test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Test_CaseSummary_ManualAddressCustomerRejectCase PASSED");
                    }
                }
            }
        }

        [Test, Retry(3)]
        [Category("Selenium")]
        public void Test_CaseSummary_UnknownAddressRejectCase()
        {
            using (var driver = InitialiseDriver())
            {
                ExtentTest test = null;
                try
                {
                    test = extent.CreateTest("Test_CaseSummary_UnknownAddressRejectCase").Info("<div style= 'color:blue; font-weight:bold'>Test Started");
                    DynamicsLogin dynamicsLogin = new DynamicsLogin(driver);
                    dynamicsLogin.LoginWindow();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Dynamics account selected");

                    Dashboards dashboards = new Dashboards(driver);
                    dashboards.VerifyPageTitle();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'> Homepage Title verified");

                    CaseSummary caseSummary = new CaseSummary(driver);
                    caseSummary.UnknownAddressRejectCase();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Case status correctly set to rejected");
                }
                catch (Exception e)
                {
                    Assert.Fail(e.StackTrace);
                }
                finally
                {
                    commonUtils.PrintLogs("browser", driver);

                    if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
                    {
                        string fileName = @"C:\Users\garymoore\OneDrive - Wakefield Council\Desktop\CRMRegressionPack\CRMRegressionPack\Screenshots\" + DateTime.Now.ToString("dd_MM_yy -HH_mm_ss") + ".Png";
                        Screenshot cp = ((ITakesScreenshot)driver).GetScreenshot();
                        cp.SaveAsFile(fileName, ScreenshotImageFormat.Png);
                        test.AddScreenCaptureFromPath(fileName);
                        test.Info(driver.Url);
                        test.Info(Environment.StackTrace.Replace(Environment.NewLine, "<br>"));
                        test.Log(Status.Fail, "<div style= 'color:red; font-weight:bold'>Test_CaseSummary_UnknownAddressRejectCase FAILED");
                    }
                    else if (TestContext.CurrentContext.Result.Outcome.Status != TestStatus.Failed)
                    {
                        test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Test_CaseSummary_UnknownAddressRejectCase PASSED");
                    }
                }
            }
        }

        [Test, Retry(3)]
        [Category("Selenium")]
        public void Test_CaseSummary_CustomerRejectCaseOnBehalfOf()
        {
            using (var driver = InitialiseDriver())
            {
                ExtentTest test = null;
                try
                {
                    test = extent.CreateTest("Test_CaseSummary_CustomerRejectCaseOnBehalfOf").Info("<div style= 'color:blue; font-weight:bold'>Test Started");
                    DynamicsLogin dynamicsLogin = new DynamicsLogin(driver);
                    dynamicsLogin.LoginWindow();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Dynamics account selected");

                    Dashboards dashboards = new Dashboards(driver);
                    dashboards.VerifyPageTitle();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'> Homepage Title verified");

                    CaseSummary caseSummary = new CaseSummary(driver);
                    caseSummary.CustomerRejectCaseOnBehalfOf();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Case status correctly set to rejected");
                }
                catch (Exception e)
                {
                    Assert.Fail(e.StackTrace);
                }
                finally
                {
                    commonUtils.PrintLogs("browser", driver);

                    if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
                    {
                        string fileName = @"C:\Users\garymoore\OneDrive - Wakefield Council\Desktop\CRMRegressionPack\CRMRegressionPack\Screenshots\" + DateTime.Now.ToString("dd_MM_yy -HH_mm_ss") + ".Png";
                        Screenshot cp = ((ITakesScreenshot)driver).GetScreenshot();
                        cp.SaveAsFile(fileName, ScreenshotImageFormat.Png);
                        test.AddScreenCaptureFromPath(fileName);
                        test.Info(driver.Url);
                        test.Info(Environment.StackTrace.Replace(Environment.NewLine, "<br>"));
                        test.Log(Status.Fail, "<div style= 'color:red; font-weight:bold'>Test_CaseSummary_CustomerRejectCaseOnBehalfOf FAILED");
                    }
                    else if (TestContext.CurrentContext.Result.Outcome.Status != TestStatus.Failed)
                    {
                        test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Test_CaseSummary_CustomerRejectCaseOnBehalfOf PASSED");
                    }
                }
            }
        }

        [Test, Retry(3)]
        [Category("Selenium")]
        public void Test_CaseSummary_BusinessRejectCase()
        {
            using (var driver = InitialiseDriver())
            {
                ExtentTest test = null;
                try
                {
                    test = extent.CreateTest("Test_CaseSummary_BusinessRejectCase").Info("<div style= 'color:blue; font-weight:bold'>Test Started");
                    DynamicsLogin dynamicsLogin = new DynamicsLogin(driver);
                    dynamicsLogin.LoginWindow();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Dynamics account selected");

                    Dashboards dashboards = new Dashboards(driver);
                    dashboards.VerifyPageTitle();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'> Homepage Title verified");

                    CaseSummary caseSummary = new CaseSummary(driver);
                    caseSummary.BusinessRejectCase();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Case status correctly set to rejected");
                }
                catch (Exception e)
                {
                    Assert.Fail(e.StackTrace);
                }
                finally
                {
                    commonUtils.PrintLogs("browser", driver);

                    if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
                    {
                        string fileName = @"C:\Users\garymoore\OneDrive - Wakefield Council\Desktop\CRMRegressionPack\CRMRegressionPack\Screenshots\" + DateTime.Now.ToString("dd_MM_yy -HH_mm_ss") + ".Png";
                        Screenshot cp = ((ITakesScreenshot)driver).GetScreenshot();
                        cp.SaveAsFile(fileName, ScreenshotImageFormat.Png);
                        test.AddScreenCaptureFromPath(fileName);
                        test.Info(driver.Url);
                        test.Info(Environment.StackTrace.Replace(Environment.NewLine, "<br>"));
                        test.Log(Status.Fail, "<div style= 'color:red; font-weight:bold'>Test_CaseSummary_BusinessRejectCase FAILED");
                    }
                    else if (TestContext.CurrentContext.Result.Outcome.Status != TestStatus.Failed)
                    {
                        test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Test_CaseSummary_BusinessRejectCase PASSED");
                    }
                }
            }
        }

        [Test, Retry(3)]
        [Category("Selenium")]
        public void Test_CaseSummary_UABusinessRejectCase()
        {
            using (var driver = InitialiseDriver())
            {
                ExtentTest test = null;
                try
                {
                    test = extent.CreateTest("Test_CaseSummary_UABusinessRejectCase").Info("<div style= 'color:blue; font-weight:bold'>Test Started");
                    DynamicsLogin dynamicsLogin = new DynamicsLogin(driver);
                    dynamicsLogin.LoginWindow();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Dynamics account selected");

                    Dashboards dashboards = new Dashboards(driver);
                    dashboards.VerifyPageTitle();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'> Homepage Title verified");

                    CaseSummary caseSummary = new CaseSummary(driver);
                    caseSummary.UABusinessRejectCase();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Case status correctly set to rejected");
                }
                catch (Exception e)
                {
                    Assert.Fail(e.StackTrace);
                }
                finally
                {
                    commonUtils.PrintLogs("browser", driver);

                    if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
                    {
                        string fileName = @"C:\Users\garymoore\OneDrive - Wakefield Council\Desktop\CRMRegressionPack\CRMRegressionPack\Screenshots\" + DateTime.Now.ToString("dd_MM_yy -HH_mm_ss") + ".Png";
                        Screenshot cp = ((ITakesScreenshot)driver).GetScreenshot();
                        cp.SaveAsFile(fileName, ScreenshotImageFormat.Png);
                        test.AddScreenCaptureFromPath(fileName);
                        test.Info(driver.Url);
                        test.Info(Environment.StackTrace.Replace(Environment.NewLine, "<br>"));
                        test.Log(Status.Fail, "<div style= 'color:red; font-weight:bold'>Test_CaseSummary_UABusinessRejectCase FAILED");
                    }
                    else if (TestContext.CurrentContext.Result.Outcome.Status != TestStatus.Failed)
                    {
                        test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Test_CaseSummary_UABusinessRejectCase PASSED");
                    }
                }
            }
        }

        [Test, Retry(3)]
        [Category("Selenium")]
        public void Test_CaseSummary_BusinessRejectCaseOnBehalfOf()
        {
            using (var driver = InitialiseDriver())
            {
                ExtentTest test = null;
                try
                {
                    test = extent.CreateTest("Test_CaseSummary_BusinessRejectCaseOnBehalfOf").Info("<div style= 'color:blue; font-weight:bold'>Test Started");
                    DynamicsLogin dynamicsLogin = new DynamicsLogin(driver);
                    dynamicsLogin.LoginWindow();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Dynamics account selected");

                    Dashboards dashboards = new Dashboards(driver);
                    dashboards.VerifyPageTitle();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'> Homepage Title verified");

                    CaseSummary caseSummary = new CaseSummary(driver);
                    caseSummary.BusinessRejectCaseOnBehalfOf();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Case status correctly set to rejected");
                }
                catch (Exception e)
                {
                    Assert.Fail(e.StackTrace);
                }
                finally
                {
                    commonUtils.PrintLogs("browser", driver);

                    if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
                    {
                        string fileName = @"C:\Users\garymoore\OneDrive - Wakefield Council\Desktop\CRMRegressionPack\CRMRegressionPack\Screenshots\" + DateTime.Now.ToString("dd_MM_yy -HH_mm_ss") + ".Png";
                        Screenshot cp = ((ITakesScreenshot)driver).GetScreenshot();
                        cp.SaveAsFile(fileName, ScreenshotImageFormat.Png);
                        test.AddScreenCaptureFromPath(fileName);
                        test.Info(driver.Url);
                        test.Info(Environment.StackTrace.Replace(Environment.NewLine, "<br>"));
                        test.Log(Status.Fail, "<div style= 'color:red; font-weight:bold'>Test_CaseSummary_BusinessRejectCaseOnBehalfOf FAILED");
                    }
                    else if (TestContext.CurrentContext.Result.Outcome.Status != TestStatus.Failed)
                    {
                        test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Test_CaseSummary_BusinessRejectCaseOnBehalfOf PASSED");
                    }
                }
            }
        }

        [Test, Retry(3)]
        [Category("Selenium")]
        public void Test_CaseSummary_ImmediatelyResolveCase()
        {
            using (var driver = InitialiseDriver())
            {
                ExtentTest test = null;
                try
                {
                    test = extent.CreateTest("Test_CaseSummary_ImmediatelyResolveCase").Info("<div style= 'color:blue; font-weight:bold'>Test Started");
                    DynamicsLogin dynamicsLogin = new DynamicsLogin(driver);
                    dynamicsLogin.LoginWindow();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Dynamics account selected");

                    Dashboards dashboards = new Dashboards(driver);
                    dashboards.VerifyPageTitle();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'> Homepage Title verified");

                    CaseSummary caseSummary = new CaseSummary(driver);
                    caseSummary.ImmediatelyResolveCase();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Case resolved correctly");
                }
                catch (Exception e)
                {
                    Assert.Fail(e.StackTrace);
                }
                finally
                {
                    commonUtils.PrintLogs("browser", driver);

                    if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
                    {
                        string fileName = @"C:\Users\garymoore\OneDrive - Wakefield Council\Desktop\CRMRegressionPack\CRMRegressionPack\Screenshots\" + DateTime.Now.ToString("dd_MM_yy -HH_mm_ss") + ".Png";
                        Screenshot cp = ((ITakesScreenshot)driver).GetScreenshot();
                        cp.SaveAsFile(fileName, ScreenshotImageFormat.Png);
                        test.AddScreenCaptureFromPath(fileName);
                        test.Info(driver.Url);
                        test.Info(Environment.StackTrace.Replace(Environment.NewLine, "<br>"));
                        test.Log(Status.Fail, "<div style= 'color:red; font-weight:bold'>Test_CaseSummary_ImmediatelyResolveCase FAILED");
                    }
                    else if (TestContext.CurrentContext.Result.Outcome.Status != TestStatus.Failed)
                    {
                        test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Test_CaseSummary_ImmediatelyResolveCase PASSED");
                    }
                }
            }
        }

        [Test, Retry(3)]
        [Category("Selenium")]
        public void Test_CaseSummary_AnonImmediatelyResolveCase()
        {
            using (var driver = InitialiseDriver())
            {
                ExtentTest test = null;
                try
                {
                    test = extent.CreateTest("Test_CaseSummary_AnonImmediatelyResolveCase").Info("<div style= 'color:blue; font-weight:bold'>Test Started");
                    DynamicsLogin dynamicsLogin = new DynamicsLogin(driver);
                    dynamicsLogin.LoginWindow();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Dynamics account selected");

                    Dashboards dashboards = new Dashboards(driver);
                    dashboards.VerifyPageTitle();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'> Homepage Title verified");

                    CaseSummary caseSummary = new CaseSummary(driver);
                    caseSummary.AnonImmediatelyResolveCase();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Case resolved correctly");
                }
                catch (Exception e)
                {
                    Assert.Fail(e.StackTrace);
                }
                finally
                {
                    commonUtils.PrintLogs("browser", driver);

                    if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
                    {
                        string fileName = @"C:\Users\garymoore\OneDrive - Wakefield Council\Desktop\CRMRegressionPack\CRMRegressionPack\Screenshots\" + DateTime.Now.ToString("dd_MM_yy -HH_mm_ss") + ".Png";
                        Screenshot cp = ((ITakesScreenshot)driver).GetScreenshot();
                        cp.SaveAsFile(fileName, ScreenshotImageFormat.Png);
                        test.AddScreenCaptureFromPath(fileName);
                        test.Info(driver.Url);
                        test.Info(Environment.StackTrace.Replace(Environment.NewLine, "<br>"));
                        test.Log(Status.Fail, "<div style= 'color:red; font-weight:bold'>Test_CaseSummary_AnonImmediatelyResolveCase FAILED");
                    }
                    else if (TestContext.CurrentContext.Result.Outcome.Status != TestStatus.Failed)
                    {
                        test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Test_CaseSummary_AnonImmediatelyResolveCase PASSED");
                    }
                }
            }
        }

        [Test, Retry(3)]
        [Category("Selenium")]
        public void Test_CaseSummary_OOAImmediatelyResolveCase()
        {
            using (var driver = InitialiseDriver())
            {
                ExtentTest test = null;
                try
                {
                    test = extent.CreateTest("Test_CaseSummary_OOAImmediatelyResolveCase").Info("<div style= 'color:blue; font-weight:bold'>Test Started");
                    DynamicsLogin dynamicsLogin = new DynamicsLogin(driver);
                    dynamicsLogin.LoginWindow();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Dynamics account selected");

                    Dashboards dashboards = new Dashboards(driver);
                    dashboards.VerifyPageTitle();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'> Homepage Title verified");

                    CaseSummary caseSummary = new CaseSummary(driver);
                    caseSummary.OOAImmediatelyResolveCase();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Case resolved correctly for out of area customer");
                }
                catch (Exception e)
                {
                    Assert.Fail(e.StackTrace);
                }
                finally
                {
                    commonUtils.PrintLogs("browser", driver);

                    if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
                    {
                        string fileName = @"C:\Users\garymoore\OneDrive - Wakefield Council\Desktop\CRMRegressionPack\CRMRegressionPack\Screenshots\" + DateTime.Now.ToString("dd_MM_yy -HH_mm_ss") + ".Png";
                        Screenshot cp = ((ITakesScreenshot)driver).GetScreenshot();
                        cp.SaveAsFile(fileName, ScreenshotImageFormat.Png);
                        test.AddScreenCaptureFromPath(fileName);
                        test.Info(driver.Url);
                        test.Info(Environment.StackTrace.Replace(Environment.NewLine, "<br>"));
                        test.Log(Status.Fail, "<div style= 'color:red; font-weight:bold'>Test_CaseSummary_OOAImmediatelyResolveCase FAILED");
                    }
                    else if (TestContext.CurrentContext.Result.Outcome.Status != TestStatus.Failed)
                    {
                        test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Test_CaseSummary_OOAImmediatelyResolveCase PASSED");
                    }
                }
            }
        }

        [Test, Retry(3)]
        [Category("Selenium")]
        public void Test_CaseSummary_ManualAddressResolveCase()
        {
            using (var driver = InitialiseDriver())
            {
                ExtentTest test = null;
                try
                {
                    test = extent.CreateTest("Test_CaseSummary_ManualAddressResolveCase").Info("<div style= 'color:blue; font-weight:bold'>Test Started");
                    DynamicsLogin dynamicsLogin = new DynamicsLogin(driver);
                    dynamicsLogin.LoginWindow();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Dynamics account selected");

                    Dashboards dashboards = new Dashboards(driver);
                    dashboards.VerifyPageTitle();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'> Homepage Title verified");

                    CaseSummary caseSummary = new CaseSummary(driver);
                    caseSummary.ManualAddressResolveCase();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Case resolved correctly for customer with manual address");
                }
                catch (Exception e)
                {
                    Assert.Fail(e.StackTrace);
                }
                finally
                {
                    commonUtils.PrintLogs("browser", driver);

                    if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
                    {
                        string fileName = @"C:\Users\garymoore\OneDrive - Wakefield Council\Desktop\CRMRegressionPack\CRMRegressionPack\Screenshots\" + DateTime.Now.ToString("dd_MM_yy -HH_mm_ss") + ".Png";
                        Screenshot cp = ((ITakesScreenshot)driver).GetScreenshot();
                        cp.SaveAsFile(fileName, ScreenshotImageFormat.Png);
                        test.AddScreenCaptureFromPath(fileName);
                        test.Info(driver.Url);
                        test.Info(Environment.StackTrace.Replace(Environment.NewLine, "<br>"));
                        test.Log(Status.Fail, "<div style= 'color:red; font-weight:bold'>Test_CaseSummary_ManualAddressResolveCase FAILED");
                    }
                    else if (TestContext.CurrentContext.Result.Outcome.Status != TestStatus.Failed)
                    {
                        test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Test_CaseSummary_ManualAddressResolveCase PASSED");
                    }
                }
            }
        }

        [Test, Retry(3)]
        [Category("Selenium")]
        public void Test_CaseSummary_UnknownAddressImmediatelyResolveCase()
        {
            using (var driver = InitialiseDriver())
            {
                ExtentTest test = null;
                try
                {
                    test = extent.CreateTest("Test_CaseSummary_UnknownAddressImmediatelyResolveCase").Info("<div style= 'color:blue; font-weight:bold'>Test Started");
                    DynamicsLogin dynamicsLogin = new DynamicsLogin(driver);
                    dynamicsLogin.LoginWindow();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Dynamics account selected");

                    Dashboards dashboards = new Dashboards(driver);
                    dashboards.VerifyPageTitle();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'> Homepage Title verified");

                    CaseSummary caseSummary = new CaseSummary(driver);
                    caseSummary.UnknownAddressImmediatelyResolveCase();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Case resolved correctly");
                }
                catch (Exception e)
                {
                    Assert.Fail(e.StackTrace);
                }
                finally
                {
                    commonUtils.PrintLogs("browser", driver);

                    if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
                    {
                        string fileName = @"C:\Users\garymoore\OneDrive - Wakefield Council\Desktop\CRMRegressionPack\CRMRegressionPack\Screenshots\" + DateTime.Now.ToString("dd_MM_yy -HH_mm_ss") + ".Png";
                        Screenshot cp = ((ITakesScreenshot)driver).GetScreenshot();
                        cp.SaveAsFile(fileName, ScreenshotImageFormat.Png);
                        test.AddScreenCaptureFromPath(fileName);
                        test.Info(driver.Url);
                        test.Info(Environment.StackTrace.Replace(Environment.NewLine, "<br>"));
                        test.Log(Status.Fail, "<div style= 'color:red; font-weight:bold'>Test_CaseSummary_UnknownAddressImmediatelyResolveCase FAILED");
                    }
                    else if (TestContext.CurrentContext.Result.Outcome.Status != TestStatus.Failed)
                    {
                        test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Test_CaseSummary_UnknownAddressImmediatelyResolveCase PASSED");
                    }
                }
            }
        }

        [Test, Retry(3)]
        [Category("Selenium")]
        public void Test_CaseSummary_ImmediatelyResolveCaseOnBehalfOf()
        {
            using (var driver = InitialiseDriver())
            {
                ExtentTest test = null;
                try
                {
                    test = extent.CreateTest("Test_CaseSummary_ImmediatelyResolveCaseOnBehalfOf").Info("<div style= 'color:blue; font-weight:bold'>Test Started");
                    DynamicsLogin dynamicsLogin = new DynamicsLogin(driver);
                    dynamicsLogin.LoginWindow();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Dynamics account selected");

                    Dashboards dashboards = new Dashboards(driver);
                    dashboards.VerifyPageTitle();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'> Homepage Title verified");

                    CaseSummary caseSummary = new CaseSummary(driver);
                    caseSummary.ImmediatelyResolveCaseOnBehalfOf();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Case resolved correctly");
                }
                catch (Exception e)
                {
                    Assert.Fail(e.StackTrace);
                }
                finally
                {
                    commonUtils.PrintLogs("browser", driver);

                    if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
                    {
                        string fileName = @"C:\Users\garymoore\OneDrive - Wakefield Council\Desktop\CRMRegressionPack\CRMRegressionPack\Screenshots\" + DateTime.Now.ToString("dd_MM_yy -HH_mm_ss") + ".Png";
                        Screenshot cp = ((ITakesScreenshot)driver).GetScreenshot();
                        cp.SaveAsFile(fileName, ScreenshotImageFormat.Png);
                        test.AddScreenCaptureFromPath(fileName);
                        test.Info(driver.Url);
                        test.Info(Environment.StackTrace.Replace(Environment.NewLine, "<br>"));
                        test.Log(Status.Fail, "<div style= 'color:red; font-weight:bold'>Test_CaseSummary_ImmediatelyResolveCaseOnBehalfOf FAILED");
                    }
                    else if (TestContext.CurrentContext.Result.Outcome.Status != TestStatus.Failed)
                    {
                        test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Test_CaseSummary_ImmediatelyResolveCaseOnBehalfOf PASSED");
                    }
                }
            }
        }

        [Test, Retry(3)]
        [Category("Selenium")]
        public void Test_CaseSummary_ImmediatelyResolveCaseBusiness()
        {
            using (var driver = InitialiseDriver())
            {
                ExtentTest test = null;
                try
                {
                    test = extent.CreateTest("Test_CaseSummary_ImmediatelyResolveCaseBusiness").Info("<div style= 'color:blue; font-weight:bold'>Test Started");
                    DynamicsLogin dynamicsLogin = new DynamicsLogin(driver);
                    dynamicsLogin.LoginWindow();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Dynamics account selected");

                    Dashboards dashboards = new Dashboards(driver);
                    dashboards.VerifyPageTitle();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'> Homepage Title verified");

                    CaseSummary caseSummary = new CaseSummary(driver);
                    caseSummary.ImmediatelyResolveCaseBusiness();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Case resolved correctly");
                }
                catch (Exception e)
                {
                    Assert.Fail(e.StackTrace);
                }
                finally
                {
                    commonUtils.PrintLogs("browser", driver);

                    if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
                    {
                        string fileName = @"C:\Users\garymoore\OneDrive - Wakefield Council\Desktop\CRMRegressionPack\CRMRegressionPack\Screenshots\" + DateTime.Now.ToString("dd_MM_yy -HH_mm_ss") + ".Png";
                        Screenshot cp = ((ITakesScreenshot)driver).GetScreenshot();
                        cp.SaveAsFile(fileName, ScreenshotImageFormat.Png);
                        test.AddScreenCaptureFromPath(fileName);
                        test.Info(driver.Url);
                        test.Info(Environment.StackTrace.Replace(Environment.NewLine, "<br>"));
                        test.Log(Status.Fail, "<div style= 'color:red; font-weight:bold'>Test_CaseSummary_ImmediatelyResolveCaseBusiness FAILED");
                    }
                    else if (TestContext.CurrentContext.Result.Outcome.Status != TestStatus.Failed)
                    {
                        test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Test_CaseSummary_ImmediatelyResolveCaseBusiness PASSED");
                    }
                }
            }
        }

        [Test, Retry(3)]
        [Category("Selenium")]
        public void Test_CaseSummary_ImmediatelyResolveCaseBusinessUA()
        {
            using (var driver = InitialiseDriver())
            {
                ExtentTest test = null;
                try
                {
                    test = extent.CreateTest("Test_CaseSummary_ImmediatelyResolveCaseBusinessUA").Info("<div style= 'color:blue; font-weight:bold'>Test Started");
                    DynamicsLogin dynamicsLogin = new DynamicsLogin(driver);
                    dynamicsLogin.LoginWindow();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Dynamics account selected");

                    Dashboards dashboards = new Dashboards(driver);
                    dashboards.VerifyPageTitle();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'> Homepage Title verified");

                    CaseSummary caseSummary = new CaseSummary(driver);
                    caseSummary.ImmediatelyResolveCaseBusinessUA();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Case resolved correctly");
                }
                catch (Exception e)
                {
                    Assert.Fail(e.StackTrace);
                }
                finally
                {
                    commonUtils.PrintLogs("browser", driver);

                    if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
                    {
                        string fileName = @"C:\Users\garymoore\OneDrive - Wakefield Council\Desktop\CRMRegressionPack\CRMRegressionPack\Screenshots\" + DateTime.Now.ToString("dd_MM_yy -HH_mm_ss") + ".Png";
                        Screenshot cp = ((ITakesScreenshot)driver).GetScreenshot();
                        cp.SaveAsFile(fileName, ScreenshotImageFormat.Png);
                        test.AddScreenCaptureFromPath(fileName);
                        test.Info(driver.Url);
                        test.Info(Environment.StackTrace.Replace(Environment.NewLine, "<br>"));
                        test.Log(Status.Fail, "<div style= 'color:red; font-weight:bold'>Test_CaseSummary_ImmediatelyResolveCaseBusinessUA FAILED");
                    }
                    else if (TestContext.CurrentContext.Result.Outcome.Status != TestStatus.Failed)
                    {
                        test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Test_CaseSummary_ImmediatelyResolveCaseBusinessUA PASSED");
                    }
                }
            }
        }

        [Test, Retry(3)]
        [Category("Selenium")]
        public void Test_CaseSummary_ImmediatelyResolveCaseOnBehalfOfBusiness()
        {
            using (var driver = InitialiseDriver())
            {
                ExtentTest test = null;
                try
                {
                    test = extent.CreateTest("Test_CaseSummary_ImmediatelyResolveCaseOnBehalfOfBusiness").Info("<div style= 'color:blue; font-weight:bold'>Test Started");
                    DynamicsLogin dynamicsLogin = new DynamicsLogin(driver);
                    dynamicsLogin.LoginWindow();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Dynamics account selected");

                    Dashboards dashboards = new Dashboards(driver);
                    dashboards.VerifyPageTitle();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'> Homepage Title verified");

                    CaseSummary caseSummary = new CaseSummary(driver);
                    caseSummary.ImmediatelyResolveCaseOnBehalfOfBusiness();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Case resolved correctly");
                }
                catch (Exception e)
                {
                    Assert.Fail(e.StackTrace);
                }
                finally
                {
                    commonUtils.PrintLogs("browser", driver);

                    if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
                    {
                        string fileName = @"C:\Users\garymoore\OneDrive - Wakefield Council\Desktop\CRMRegressionPack\CRMRegressionPack\Screenshots\" + DateTime.Now.ToString("dd_MM_yy -HH_mm_ss") + ".Png";
                        Screenshot cp = ((ITakesScreenshot)driver).GetScreenshot();
                        cp.SaveAsFile(fileName, ScreenshotImageFormat.Png);
                        test.AddScreenCaptureFromPath(fileName);
                        test.Info(driver.Url);
                        test.Info(Environment.StackTrace.Replace(Environment.NewLine, "<br>"));
                        test.Log(Status.Fail, "<div style= 'color:red; font-weight:bold'>Test_CaseSummary_ImmediatelyResolveCaseOnBehalfOfBusiness FAILED");
                    }
                    else if (TestContext.CurrentContext.Result.Outcome.Status != TestStatus.Failed)
                    {
                        test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Test_CaseSummary_ImmediatelyResolveCaseOnBehalfOfBusiness PASSED");
                    }
                }
            }
        }

        [Test, Retry(3)]
        [Category("Selenium")]
        public void Test_CaseSummary_SignPostCase()
        {
            using (var driver = InitialiseDriver())
            {
                ExtentTest test = null;
                try
                {
                    test = extent.CreateTest("Test_CaseSummary_SignPostCase").Info("<div style= 'color:blue; font-weight:bold'>Test Started");
                    DynamicsLogin dynamicsLogin = new DynamicsLogin(driver);
                    dynamicsLogin.LoginWindow();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Dynamics account selected");

                    Dashboards dashboards = new Dashboards(driver);
                    dashboards.VerifyPageTitle();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'> Homepage Title verified");

                    CaseSummary caseSummary = new CaseSummary(driver);
                    caseSummary.SignPostCase();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Case signposted correctly");
                }
                catch (Exception e)
                {
                    Assert.Fail(e.StackTrace);
                }
                finally
                {
                    commonUtils.PrintLogs("browser", driver);

                    if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
                    {
                        string fileName = @"C:\Users\garymoore\OneDrive - Wakefield Council\Desktop\CRMRegressionPack\CRMRegressionPack\Screenshots\" + DateTime.Now.ToString("dd_MM_yy -HH_mm_ss") + ".Png";
                        Screenshot cp = ((ITakesScreenshot)driver).GetScreenshot();
                        cp.SaveAsFile(fileName, ScreenshotImageFormat.Png);
                        test.AddScreenCaptureFromPath(fileName);
                        test.Info(driver.Url);
                        test.Info(Environment.StackTrace.Replace(Environment.NewLine, "<br>"));
                        test.Log(Status.Fail, "<div style= 'color:red; font-weight:bold'>Test_CaseSummary_SignPostCase FAILED");
                    }
                    else if (TestContext.CurrentContext.Result.Outcome.Status != TestStatus.Failed)
                    {
                        test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Test_CaseSummary_SignPostCase PASSED");
                    }
                }
            }
        }

        [Test, Retry(3)]
        [Category("Selenium")]
        public void Test_CaseSummary_ManualAddressSignPostCase()
        {
            using (var driver = InitialiseDriver())
            {
                ExtentTest test = null;
                try
                {
                    test = extent.CreateTest("Test_CaseSummary_ManualAddressSignPostCase").Info("<div style= 'color:blue; font-weight:bold'>Test Started");
                    DynamicsLogin dynamicsLogin = new DynamicsLogin(driver);
                    dynamicsLogin.LoginWindow();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Dynamics account selected");

                    Dashboards dashboards = new Dashboards(driver);
                    dashboards.VerifyPageTitle();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'> Homepage Title verified");

                    CaseSummary caseSummary = new CaseSummary(driver);
                    caseSummary.ManualAddressSignPostCase();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Case signposted correctly for customer with manual address");
                }
                catch (Exception e)
                {
                    Assert.Fail(e.StackTrace);
                }
                finally
                {
                    commonUtils.PrintLogs("browser", driver);

                    if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
                    {
                        string fileName = @"C:\Users\garymoore\OneDrive - Wakefield Council\Desktop\CRMRegressionPack\CRMRegressionPack\Screenshots\" + DateTime.Now.ToString("dd_MM_yy -HH_mm_ss") + ".Png";
                        Screenshot cp = ((ITakesScreenshot)driver).GetScreenshot();
                        cp.SaveAsFile(fileName, ScreenshotImageFormat.Png);
                        test.AddScreenCaptureFromPath(fileName);
                        test.Info(driver.Url);
                        test.Info(Environment.StackTrace.Replace(Environment.NewLine, "<br>"));
                        test.Log(Status.Fail, "<div style= 'color:red; font-weight:bold'>Test_CaseSummary_ManualAddressSignPostCase FAILED");
                    }
                    else if (TestContext.CurrentContext.Result.Outcome.Status != TestStatus.Failed)
                    {
                        test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Test_CaseSummary_ManualAddressSignPostCase PASSED");
                    }
                }
            }
        }

        [Test, Retry(3)]
        [Category("Selenium")]
        public void Test_CaseSummary_OOASignPostCase()
        {
            using (var driver = InitialiseDriver())
            {
                ExtentTest test = null;
                try
                {
                    test = extent.CreateTest("Test_CaseSummary_OOASignPostCase").Info("<div style= 'color:blue; font-weight:bold'>Test Started");
                    DynamicsLogin dynamicsLogin = new DynamicsLogin(driver);
                    dynamicsLogin.LoginWindow();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Dynamics account selected");

                    Dashboards dashboards = new Dashboards(driver);
                    dashboards.VerifyPageTitle();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'> Homepage Title verified");

                    CaseSummary caseSummary = new CaseSummary(driver);
                    caseSummary.OOASignPostCase();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Case signposted correctly for out of area customer");
                }
                catch (Exception e)
                {
                    Assert.Fail(e.StackTrace);
                }
                finally
                {
                    commonUtils.PrintLogs("browser", driver);

                    if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
                    {
                        string fileName = @"C:\Users\garymoore\OneDrive - Wakefield Council\Desktop\CRMRegressionPack\CRMRegressionPack\Screenshots\" + DateTime.Now.ToString("dd_MM_yy -HH_mm_ss") + ".Png";
                        Screenshot cp = ((ITakesScreenshot)driver).GetScreenshot();
                        cp.SaveAsFile(fileName, ScreenshotImageFormat.Png);
                        test.AddScreenCaptureFromPath(fileName);
                        test.Info(driver.Url);
                        test.Info(Environment.StackTrace.Replace(Environment.NewLine, "<br>"));
                        test.Log(Status.Fail, "<div style= 'color:red; font-weight:bold'>Test_CaseSummary_OOASignPostCase FAILED");
                    }
                    else if (TestContext.CurrentContext.Result.Outcome.Status != TestStatus.Failed)
                    {
                        test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Test_CaseSummary_OOASignPostCase PASSED");
                    }
                }
            }
        }

        [Test, Retry(3)]
        [Category("Selenium")]
        public void Test_CaseSummary_AnonSignPostCase()
        {
            using (var driver = InitialiseDriver())
            {
                ExtentTest test = null;
                try
                {
                    test = extent.CreateTest("Test_CaseSummary_AnonSignPostCase").Info("<div style= 'color:blue; font-weight:bold'>Test Started");
                    DynamicsLogin dynamicsLogin = new DynamicsLogin(driver);
                    dynamicsLogin.LoginWindow();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Dynamics account selected");

                    Dashboards dashboards = new Dashboards(driver);
                    dashboards.VerifyPageTitle();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'> Homepage Title verified");

                    CaseSummary caseSummary = new CaseSummary(driver);
                    caseSummary.AnonSignPostCase();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Case signposted correctly");
                }
                catch (Exception e)
                {
                    Assert.Fail(e.StackTrace);
                }
                finally
                {
                    commonUtils.PrintLogs("browser", driver);

                    if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
                    {
                        string fileName = @"C:\Users\garymoore\OneDrive - Wakefield Council\Desktop\CRMRegressionPack\CRMRegressionPack\Screenshots\" + DateTime.Now.ToString("dd_MM_yy -HH_mm_ss") + ".Png";
                        Screenshot cp = ((ITakesScreenshot)driver).GetScreenshot();
                        cp.SaveAsFile(fileName, ScreenshotImageFormat.Png);
                        test.AddScreenCaptureFromPath(fileName);
                        test.Info(driver.Url);
                        test.Info(Environment.StackTrace.Replace(Environment.NewLine, "<br>"));
                        test.Log(Status.Fail, "<div style= 'color:red; font-weight:bold'>Test_CaseSummary_AnonSignPostCase FAILED");
                    }
                    else if (TestContext.CurrentContext.Result.Outcome.Status != TestStatus.Failed)
                    {
                        test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Test_CaseSummary_AnonSignPostCase PASSED");
                    }
                }
            }
        }

        [Test, Retry(3)]
        [Category("Selenium")]
        public void Test_CaseSummary_UnknownAddressSignPostCase()
        {
            using (var driver = InitialiseDriver())
            {
                ExtentTest test = null;
                try
                {
                    test = extent.CreateTest("Test_CaseSummary_UnknownAddressSignPostCase").Info("<div style= 'color:blue; font-weight:bold'>Test Started");
                    DynamicsLogin dynamicsLogin = new DynamicsLogin(driver);
                    dynamicsLogin.LoginWindow();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Dynamics account selected");

                    Dashboards dashboards = new Dashboards(driver);
                    dashboards.VerifyPageTitle();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'> Homepage Title verified");

                    CaseSummary caseSummary = new CaseSummary(driver);
                    caseSummary.UnknownAddressSignPostCase();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Case signposted correctly");
                }
                catch (Exception e)
                {
                    Assert.Fail(e.StackTrace);
                }
                finally
                {
                    commonUtils.PrintLogs("browser", driver);

                    if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
                    {
                        string fileName = @"C:\Users\garymoore\OneDrive - Wakefield Council\Desktop\CRMRegressionPack\CRMRegressionPack\Screenshots\" + DateTime.Now.ToString("dd_MM_yy -HH_mm_ss") + ".Png";
                        Screenshot cp = ((ITakesScreenshot)driver).GetScreenshot();
                        cp.SaveAsFile(fileName, ScreenshotImageFormat.Png);
                        test.AddScreenCaptureFromPath(fileName);
                        test.Info(driver.Url);
                        test.Info(Environment.StackTrace.Replace(Environment.NewLine, "<br>"));
                        test.Log(Status.Fail, "<div style= 'color:red; font-weight:bold'>Test_CaseSummary_UnknownAddressSignPostCase FAILED");
                    }
                    else if (TestContext.CurrentContext.Result.Outcome.Status != TestStatus.Failed)
                    {
                        test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Test_CaseSummary_UnknownAddressSignPostCase PASSED");
                    }
                }
            }
        }

        [Test, Retry(3)]
        [Category("Selenium")]
        public void Test_CaseSummary_SignPostCaseOnBehalfOf()
        {
            using (var driver = InitialiseDriver())
            {
                ExtentTest test = null;
                try
                {
                    test = extent.CreateTest("Test_CaseSummary_SignPostCaseOnBehalfOf").Info("<div style= 'color:blue; font-weight:bold'>Test Started");
                    DynamicsLogin dynamicsLogin = new DynamicsLogin(driver);
                    dynamicsLogin.LoginWindow();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Dynamics account selected");

                    Dashboards dashboards = new Dashboards(driver);
                    dashboards.VerifyPageTitle();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'> Homepage Title verified");

                    CaseSummary caseSummary = new CaseSummary(driver);
                    caseSummary.SignPostCaseOnBehalfOf();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Case signposted correctly");
                }
                catch (Exception e)
                {
                    Assert.Fail(e.StackTrace);
                }
                finally
                {
                    commonUtils.PrintLogs("browser", driver);

                    if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
                    {
                        string fileName = @"C:\Users\garymoore\OneDrive - Wakefield Council\Desktop\CRMRegressionPack\CRMRegressionPack\Screenshots\" + DateTime.Now.ToString("dd_MM_yy -HH_mm_ss") + ".Png";
                        Screenshot cp = ((ITakesScreenshot)driver).GetScreenshot();
                        cp.SaveAsFile(fileName, ScreenshotImageFormat.Png);
                        test.AddScreenCaptureFromPath(fileName);
                        test.Info(driver.Url);
                        test.Info(Environment.StackTrace.Replace(Environment.NewLine, "<br>"));
                        test.Log(Status.Fail, "<div style= 'color:red; font-weight:bold'>Test_CaseSummary_SignPostCaseOnBehalfOf FAILED");
                    }
                    else if (TestContext.CurrentContext.Result.Outcome.Status != TestStatus.Failed)
                    {
                        test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Test_CaseSummary_SignPostCaseOnBehalfOf PASSED");
                    }
                }
            }
        }

        [Test, Retry(3)]
        [Category("Selenium")]
        public void Test_CaseSummary_SignPostCaseBusiness()
        {
            using (var driver = InitialiseDriver())
            {
                ExtentTest test = null;
                try
                {
                    test = extent.CreateTest("Test_CaseSummary_SignPostCaseBusiness").Info("<div style= 'color:blue; font-weight:bold'>Test Started");
                    DynamicsLogin dynamicsLogin = new DynamicsLogin(driver);
                    dynamicsLogin.LoginWindow();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Dynamics account selected");

                    Dashboards dashboards = new Dashboards(driver);
                    dashboards.VerifyPageTitle();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'> Homepage Title verified");

                    CaseSummary caseSummary = new CaseSummary(driver);
                    caseSummary.SignPostCaseBusiness();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Case signposted correctly");
                }
                catch (Exception e)
                {
                    Assert.Fail(e.StackTrace);
                }
                finally
                {
                    commonUtils.PrintLogs("browser", driver);

                    if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
                    {
                        string fileName = @"C:\Users\garymoore\OneDrive - Wakefield Council\Desktop\CRMRegressionPack\CRMRegressionPack\Screenshots\" + DateTime.Now.ToString("dd_MM_yy -HH_mm_ss") + ".Png";
                        Screenshot cp = ((ITakesScreenshot)driver).GetScreenshot();
                        cp.SaveAsFile(fileName, ScreenshotImageFormat.Png);
                        test.AddScreenCaptureFromPath(fileName);
                        test.Info(driver.Url);
                        test.Info(Environment.StackTrace.Replace(Environment.NewLine, "<br>"));
                        test.Log(Status.Fail, "<div style= 'color:red; font-weight:bold'>Test_CaseSummary_SignPostCaseBusiness FAILED");
                    }
                    else if (TestContext.CurrentContext.Result.Outcome.Status != TestStatus.Failed)
                    {
                        test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Test_CaseSummary_SignPostCaseBusiness PASSED");
                    }
                }
            }
        }

        [Test, Retry(3)]
        [Category("Selenium")]
        public void Test_CaseSummary_SignPostCaseBusinessUA()
        {
            using (var driver = InitialiseDriver())
            {
                ExtentTest test = null;
                try
                {
                    test = extent.CreateTest("Test_CaseSummary_SignPostCaseBusinessUA").Info("<div style= 'color:blue; font-weight:bold'>Test Started");
                    DynamicsLogin dynamicsLogin = new DynamicsLogin(driver);
                    dynamicsLogin.LoginWindow();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Dynamics account selected");

                    Dashboards dashboards = new Dashboards(driver);
                    dashboards.VerifyPageTitle();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'> Homepage Title verified");

                    CaseSummary caseSummary = new CaseSummary(driver);
                    caseSummary.SignPostCaseBusinessUA();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Case signposted correctly");
                }
                catch (Exception e)
                {
                    Assert.Fail(e.StackTrace);
                }
                finally
                {
                    commonUtils.PrintLogs("browser", driver);

                    if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
                    {
                        string fileName = @"C:\Users\garymoore\OneDrive - Wakefield Council\Desktop\CRMRegressionPack\CRMRegressionPack\Screenshots\" + DateTime.Now.ToString("dd_MM_yy -HH_mm_ss") + ".Png";
                        Screenshot cp = ((ITakesScreenshot)driver).GetScreenshot();
                        cp.SaveAsFile(fileName, ScreenshotImageFormat.Png);
                        test.AddScreenCaptureFromPath(fileName);
                        test.Info(driver.Url);
                        test.Info(Environment.StackTrace.Replace(Environment.NewLine, "<br>"));
                        test.Log(Status.Fail, "<div style= 'color:red; font-weight:bold'>Test_CaseSummary_SignPostCaseBusinessUA FAILED");
                    }
                    else if (TestContext.CurrentContext.Result.Outcome.Status != TestStatus.Failed)
                    {
                        test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Test_CaseSummary_SignPostCaseBusinessUA PASSED");
                    }
                }
            }
        }

        [Test, Retry(3)]
        [Category("Selenium")]
        public void Test_CaseSummary_SignPostCaseOnBehalfOfBusiness()
        {
            using (var driver = InitialiseDriver())
            {
                ExtentTest test = null;
                try
                {
                    test = extent.CreateTest("Test_CaseSummary_SignPostCaseOnBehalfOfBusiness").Info("<div style= 'color:blue; font-weight:bold'>Test Started");
                    DynamicsLogin dynamicsLogin = new DynamicsLogin(driver);
                    dynamicsLogin.LoginWindow();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Dynamics account selected");

                    Dashboards dashboards = new Dashboards(driver);
                    dashboards.VerifyPageTitle();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'> Homepage Title verified");

                    CaseSummary caseSummary = new CaseSummary(driver);
                    caseSummary.SignPostCaseOnBehalfOfBusiness();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Case signposted correctly");
                }
                catch (Exception e)
                {
                    Assert.Fail(e.StackTrace);
                }
                finally
                {
                    commonUtils.PrintLogs("browser", driver);

                    if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
                    {
                        string fileName = @"C:\Users\garymoore\OneDrive - Wakefield Council\Desktop\CRMRegressionPack\CRMRegressionPack\Screenshots\" + DateTime.Now.ToString("dd_MM_yy -HH_mm_ss") + ".Png";
                        Screenshot cp = ((ITakesScreenshot)driver).GetScreenshot();
                        cp.SaveAsFile(fileName, ScreenshotImageFormat.Png);
                        test.AddScreenCaptureFromPath(fileName);
                        test.Info(driver.Url);
                        test.Info(Environment.StackTrace.Replace(Environment.NewLine, "<br>"));
                        test.Log(Status.Fail, "<div style= 'color:red; font-weight:bold'>Test_CaseSummary_SignPostCaseOnBehalfOfBusiness FAILED");
                    }
                    else if (TestContext.CurrentContext.Result.Outcome.Status != TestStatus.Failed)
                    {
                        test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Test_CaseSummary_SignPostCaseOnBehalfOfBusiness PASSED");
                    }
                }
            }
        }

        [Test, Retry(3)]
        [Category("Selenium")]
        public void Test_CaseSummary_CaseHistoryInAccessChannel()
        {
            using (var driver = InitialiseDriver())
            {
                ExtentTest test = null;
                try
                {
                    test = extent.CreateTest("Test_CaseSummary_CaseHistoryInAccessChannel").Info("<div style= 'color:blue; font-weight:bold'>Test Started");
                    DynamicsLogin dynamicsLogin = new DynamicsLogin(driver);
                    dynamicsLogin.LoginWindow();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Dynamics account selected");

                    Dashboards dashboards = new Dashboards(driver);
                    dashboards.VerifyPageTitle();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'> Homepage Title verified");

                    CaseSummary caseSummary = new CaseSummary(driver);
                    caseSummary.CaseHistoryInAccessChannel();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Case history displayed correctly");
                }
                catch (Exception e)
                {
                    Assert.Fail(e.StackTrace);
                }
                finally
                {
                    commonUtils.PrintLogs("browser", driver);

                    if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
                    {
                        string fileName = @"C:\Users\garymoore\OneDrive - Wakefield Council\Desktop\CRMRegressionPack\CRMRegressionPack\Screenshots\" + DateTime.Now.ToString("dd_MM_yy -HH_mm_ss") + ".Png";
                        Screenshot cp = ((ITakesScreenshot)driver).GetScreenshot();
                        cp.SaveAsFile(fileName, ScreenshotImageFormat.Png);
                        test.AddScreenCaptureFromPath(fileName);
                        test.Info(driver.Url);
                        test.Info(Environment.StackTrace.Replace(Environment.NewLine, "<br>"));
                        test.Log(Status.Fail, "<div style= 'color:red; font-weight:bold'>Test_CaseSummary_CaseHistoryInAccessChannel FAILED");
                    }
                    else if (TestContext.CurrentContext.Result.Outcome.Status != TestStatus.Failed)
                    {
                        test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Test_CaseSummary_CaseHistoryInAccessChannel PASSED");
                    }
                }
            }
        }

        [Test, Retry(3)]
        [Category("Selenium")]
        public void Test_CaseSummary_OOACaseHistoryInAccessChannel()
        {
            using (var driver = InitialiseDriver())
            {
                ExtentTest test = null;
                try
                {
                    test = extent.CreateTest("Test_CaseSummary_OOACaseHistoryInAccessChannel").Info("<div style= 'color:blue; font-weight:bold'>Test Started");
                    DynamicsLogin dynamicsLogin = new DynamicsLogin(driver);
                    dynamicsLogin.LoginWindow();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Dynamics account selected");

                    Dashboards dashboards = new Dashboards(driver);
                    dashboards.VerifyPageTitle();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'> Homepage Title verified");

                    CaseSummary caseSummary = new CaseSummary(driver);
                    caseSummary.OOACaseHistoryInAccessChannel();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Case history displayed correctly for out of area customer");
                }
                catch (Exception e)
                {
                    Assert.Fail(e.StackTrace);
                }
                finally
                {
                    commonUtils.PrintLogs("browser", driver);

                    if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
                    {
                        string fileName = @"C:\Users\garymoore\OneDrive - Wakefield Council\Desktop\CRMRegressionPack\CRMRegressionPack\Screenshots\" + DateTime.Now.ToString("dd_MM_yy -HH_mm_ss") + ".Png";
                        Screenshot cp = ((ITakesScreenshot)driver).GetScreenshot();
                        cp.SaveAsFile(fileName, ScreenshotImageFormat.Png);
                        test.AddScreenCaptureFromPath(fileName);
                        test.Info(driver.Url);
                        test.Info(Environment.StackTrace.Replace(Environment.NewLine, "<br>"));
                        test.Log(Status.Fail, "<div style= 'color:red; font-weight:bold'>Test_CaseSummary_OOACaseHistoryInAccessChannel FAILED");
                    }
                    else if (TestContext.CurrentContext.Result.Outcome.Status != TestStatus.Failed)
                    {
                        test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Test_CaseSummary_OOACaseHistoryInAccessChannel PASSED");
                    }
                }
            }
        }

        [Test, Retry(3)]
        [Category("Selenium")]
        public void Test_CaseSummary_MACaseHistoryInAccessChannel()
        {
            using (var driver = InitialiseDriver())
            {
                ExtentTest test = null;
                try
                {
                    test = extent.CreateTest("Test_CaseSummary_MACaseHistoryInAccessChannel").Info("<div style= 'color:blue; font-weight:bold'>Test Started");
                    DynamicsLogin dynamicsLogin = new DynamicsLogin(driver);
                    dynamicsLogin.LoginWindow();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Dynamics account selected");

                    Dashboards dashboards = new Dashboards(driver);
                    dashboards.VerifyPageTitle();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'> Homepage Title verified");

                    CaseSummary caseSummary = new CaseSummary(driver);
                    caseSummary.MACaseHistoryInAccessChannel();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Case history displayed correctly for customer with manually added address");
                }
                catch (Exception e)
                {
                    Assert.Fail(e.StackTrace);
                }
                finally
                {
                    commonUtils.PrintLogs("browser", driver);

                    if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
                    {
                        string fileName = @"C:\Users\garymoore\OneDrive - Wakefield Council\Desktop\CRMRegressionPack\CRMRegressionPack\Screenshots\" + DateTime.Now.ToString("dd_MM_yy -HH_mm_ss") + ".Png";
                        Screenshot cp = ((ITakesScreenshot)driver).GetScreenshot();
                        cp.SaveAsFile(fileName, ScreenshotImageFormat.Png);
                        test.AddScreenCaptureFromPath(fileName);
                        test.Info(driver.Url);
                        test.Info(Environment.StackTrace.Replace(Environment.NewLine, "<br>"));
                        test.Log(Status.Fail, "<div style= 'color:red; font-weight:bold'>Test_CaseSummary_MACaseHistoryInAccessChannel FAILED");
                    }
                    else if (TestContext.CurrentContext.Result.Outcome.Status != TestStatus.Failed)
                    {
                        test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Test_CaseSummary_MACaseHistoryInAccessChannel PASSED");
                    }
                }
            }
        }

        [Test, Retry(3)]
        [Category("Selenium")]
        public void Test_CaseSummary_UACaseHistoryInAccessChannel()
        {
            using (var driver = InitialiseDriver())
            {
                ExtentTest test = null;
                try
                {
                    test = extent.CreateTest("Test_CaseSummary_UACaseHistoryInAccessChannel").Info("<div style= 'color:blue; font-weight:bold'>Test Started");
                    DynamicsLogin dynamicsLogin = new DynamicsLogin(driver);
                    dynamicsLogin.LoginWindow();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Dynamics account selected");

                    Dashboards dashboards = new Dashboards(driver);
                    dashboards.VerifyPageTitle();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'> Homepage Title verified");

                    CaseSummary caseSummary = new CaseSummary(driver);
                    caseSummary.UACaseHistoryInAccessChannel();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Case history displayed correctly for customer with unknown address");
                }
                catch (Exception e)
                {
                    Assert.Fail(e.StackTrace);
                }
                finally
                {
                    commonUtils.PrintLogs("browser", driver);

                    if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
                    {
                        string fileName = @"C:\Users\garymoore\OneDrive - Wakefield Council\Desktop\CRMRegressionPack\CRMRegressionPack\Screenshots\" + DateTime.Now.ToString("dd_MM_yy -HH_mm_ss") + ".Png";
                        Screenshot cp = ((ITakesScreenshot)driver).GetScreenshot();
                        cp.SaveAsFile(fileName, ScreenshotImageFormat.Png);
                        test.AddScreenCaptureFromPath(fileName);
                        test.Info(driver.Url);
                        test.Info(Environment.StackTrace.Replace(Environment.NewLine, "<br>"));
                        test.Log(Status.Fail, "<div style= 'color:red; font-weight:bold'>Test_CaseSummary_UACaseHistoryInAccessChannel FAILED");
                    }
                    else if (TestContext.CurrentContext.Result.Outcome.Status != TestStatus.Failed)
                    {
                        test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Test_CaseSummary_UACaseHistoryInAccessChannel PASSED");
                    }
                }
            }
        }

        [Test, Retry(3)]
        [Category("Selenium")]
        public void Test_CaseSummary_BusinessCaseHistoryInAccessChannel()
        {
            using (var driver = InitialiseDriver())
            {
                ExtentTest test = null;
                try
                {
                    test = extent.CreateTest("Test_CaseSummary_BusinessCaseHistoryInAccessChannel").Info("<div style= 'color:blue; font-weight:bold'>Test Started");
                    DynamicsLogin dynamicsLogin = new DynamicsLogin(driver);
                    dynamicsLogin.LoginWindow();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Dynamics account selected");

                    Dashboards dashboards = new Dashboards(driver);
                    dashboards.VerifyPageTitle();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'> Homepage Title verified");

                    CaseSummary caseSummary = new CaseSummary(driver);
                    caseSummary.BusinessCaseHistoryInAccessChannel();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Case history displayed correctly");
                }
                catch (Exception e)
                {
                    Assert.Fail(e.StackTrace);
                }
                finally
                {
                    commonUtils.PrintLogs("browser", driver);

                    if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
                    {
                        string fileName = @"C:\Users\garymoore\OneDrive - Wakefield Council\Desktop\CRMRegressionPack\CRMRegressionPack\Screenshots\" + DateTime.Now.ToString("dd_MM_yy -HH_mm_ss") + ".Png";
                        Screenshot cp = ((ITakesScreenshot)driver).GetScreenshot();
                        cp.SaveAsFile(fileName, ScreenshotImageFormat.Png);
                        test.AddScreenCaptureFromPath(fileName);
                        test.Info(driver.Url);
                        test.Info(Environment.StackTrace.Replace(Environment.NewLine, "<br>"));
                        test.Log(Status.Fail, "<div style= 'color:red; font-weight:bold'>Test_CaseSummary_BusinessCaseHistoryInAccessChannel FAILED");
                    }
                    else if (TestContext.CurrentContext.Result.Outcome.Status != TestStatus.Failed)
                    {
                        test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Test_CaseSummary_BusinessCaseHistoryInAccessChannel PASSED");
                    }
                }
            }
        }

        [Test, Retry(3)]
        [Category("Selenium")]
        public void Test_CaseSummary_UABusinessCaseHistoryInAccessChannel()
        {
            using (var driver = InitialiseDriver())
            {
                ExtentTest test = null;
                try
                {
                    test = extent.CreateTest("Test_CaseSummary_UABusinessCaseHistoryInAccessChannel").Info("<div style= 'color:blue; font-weight:bold'>Test Started");
                    DynamicsLogin dynamicsLogin = new DynamicsLogin(driver);
                    dynamicsLogin.LoginWindow();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Dynamics account selected");

                    Dashboards dashboards = new Dashboards(driver);
                    dashboards.VerifyPageTitle();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'> Homepage Title verified");

                    CaseSummary caseSummary = new CaseSummary(driver);
                    caseSummary.UABusinessCaseHistoryInAccessChannel();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Case history displayed correctly");
                }
                catch (Exception e)
                {
                    Assert.Fail(e.StackTrace);
                }
                finally
                {
                    commonUtils.PrintLogs("browser", driver);

                    if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
                    {
                        string fileName = @"C:\Users\garymoore\OneDrive - Wakefield Council\Desktop\CRMRegressionPack\CRMRegressionPack\Screenshots\" + DateTime.Now.ToString("dd_MM_yy -HH_mm_ss") + ".Png";
                        Screenshot cp = ((ITakesScreenshot)driver).GetScreenshot();
                        cp.SaveAsFile(fileName, ScreenshotImageFormat.Png);
                        test.AddScreenCaptureFromPath(fileName);
                        test.Info(driver.Url);
                        test.Info(Environment.StackTrace.Replace(Environment.NewLine, "<br>"));
                        test.Log(Status.Fail, "<div style= 'color:red; font-weight:bold'>Test_CaseSummary_UABusinessCaseHistoryInAccessChannel FAILED");
                    }
                    else if (TestContext.CurrentContext.Result.Outcome.Status != TestStatus.Failed)
                    {
                        test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Test_CaseSummary_UABusinessCaseHistoryInAccessChannel PASSED");
                    }
                }
            }
        }

        [Test, Retry(3)]
        [Category("Selenium")]
        public void Test_CaseSummary_PauseCaseStatus()
        {
            using (var driver = InitialiseDriver())
            {
                ExtentTest test = null;
                try
                {
                    test = extent.CreateTest("Test_CaseSummary_PauseCaseStatus").Info("<div style= 'color:blue; font-weight:bold'>Test Started");
                    DynamicsLogin dynamicsLogin = new DynamicsLogin(driver);
                    dynamicsLogin.LoginWindow();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Dynamics account selected");

                    Dashboards dashboards = new Dashboards(driver);
                    dashboards.VerifyPageTitle();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'> Homepage Title verified");

                    CaseSummary caseSummary = new CaseSummary(driver);
                    caseSummary.PauseCaseStatus();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Case paused correctly");
                }
                catch (Exception e)
                {
                    Assert.Fail(e.StackTrace);
                }
                finally
                {
                    commonUtils.PrintLogs("browser", driver);

                    if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
                    {
                        string fileName = @"C:\Users\garymoore\OneDrive - Wakefield Council\Desktop\CRMRegressionPack\CRMRegressionPack\Screenshots\" + DateTime.Now.ToString("dd_MM_yy -HH_mm_ss") + ".Png";
                        Screenshot cp = ((ITakesScreenshot)driver).GetScreenshot();
                        cp.SaveAsFile(fileName, ScreenshotImageFormat.Png);
                        test.AddScreenCaptureFromPath(fileName);
                        test.Info(driver.Url);
                        test.Info(Environment.StackTrace.Replace(Environment.NewLine, "<br>"));
                        test.Log(Status.Fail, "<div style= 'color:red; font-weight:bold'>Test_CaseSummary_PauseCaseStatus FAILED");
                    }
                    else if (TestContext.CurrentContext.Result.Outcome.Status != TestStatus.Failed)
                    {
                        test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Test_CaseSummary_PauseCaseStatus PASSED");
                    }
                }
            }
        }

        [Test, Retry(3)]
        [Category("Selenium")]
        public void Test_CaseSummary_UnpauseCaseStatus()
        {
            using (var driver = InitialiseDriver())
            {
                ExtentTest test = null;
                try
                {
                    test = extent.CreateTest("Test_CaseSummary_UnpauseCaseStatus").Info("<div style= 'color:blue; font-weight:bold'>Test Started");
                    DynamicsLogin dynamicsLogin = new DynamicsLogin(driver);
                    dynamicsLogin.LoginWindow();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Dynamics account selected");

                    Dashboards dashboards = new Dashboards(driver);
                    dashboards.VerifyPageTitle();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'> Homepage Title verified");

                    CaseSummary caseSummary = new CaseSummary(driver);
                    caseSummary.UnpauseCaseStatus();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Case restarted correctly");
                }
                catch (Exception e)
                {
                    Assert.Fail(e.StackTrace);
                }
                finally
                {
                    commonUtils.PrintLogs("browser", driver);

                    if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
                    {
                        string fileName = @"C:\Users\garymoore\OneDrive - Wakefield Council\Desktop\CRMRegressionPack\CRMRegressionPack\Screenshots\" + DateTime.Now.ToString("dd_MM_yy -HH_mm_ss") + ".Png";
                        Screenshot cp = ((ITakesScreenshot)driver).GetScreenshot();
                        cp.SaveAsFile(fileName, ScreenshotImageFormat.Png);
                        test.AddScreenCaptureFromPath(fileName);
                        test.Info(driver.Url);
                        test.Info(Environment.StackTrace.Replace(Environment.NewLine, "<br>"));
                        test.Log(Status.Fail, "<div style= 'color:red; font-weight:bold'>Test_CaseSummary_UnpauseCaseStatus FAILED");
                    }
                    else if (TestContext.CurrentContext.Result.Outcome.Status != TestStatus.Failed)
                    {
                        test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Test_CaseSummary_UnpauseCaseStatus PASSED");
                    }
                }
            }
        }

        [Test, Retry(3)]
        [Category("Selenium")]
        public void Test_CaseSummary_ClosingCaseStatus()
        {
            using (var driver = InitialiseDriver())
            {
                ExtentTest test = null;
                try
                {
                    test = extent.CreateTest("Test_CaseSummary_ClosingCaseStatus").Info("<div style= 'color:blue; font-weight:bold'>Test Started");
                    DynamicsLogin dynamicsLogin = new DynamicsLogin(driver);
                    dynamicsLogin.LoginWindow();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Dynamics account selected");

                    Dashboards dashboards = new Dashboards(driver);
                    dashboards.VerifyPageTitle();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'> Homepage Title verified");

                    CaseSummary caseSummary = new CaseSummary(driver);
                    caseSummary.ClosingCaseStatus();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Case closed correctly");
                }
                catch (Exception e)
                {
                    Assert.Fail(e.StackTrace);
                }
                finally
                {
                    commonUtils.PrintLogs("browser", driver);

                    if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
                    {
                        string fileName = @"C:\Users\garymoore\OneDrive - Wakefield Council\Desktop\CRMRegressionPack\CRMRegressionPack\Screenshots\" + DateTime.Now.ToString("dd_MM_yy -HH_mm_ss") + ".Png";
                        Screenshot cp = ((ITakesScreenshot)driver).GetScreenshot();
                        cp.SaveAsFile(fileName, ScreenshotImageFormat.Png);
                        test.AddScreenCaptureFromPath(fileName);
                        test.Info(driver.Url);
                        test.Info(Environment.StackTrace.Replace(Environment.NewLine, "<br>"));
                        test.Log(Status.Fail, "<div style= 'color:red; font-weight:bold'>Test_CaseSummary_ClosingCaseStatus FAILED");
                    }
                    else if (TestContext.CurrentContext.Result.Outcome.Status != TestStatus.Failed)
                    {
                        test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Test_CaseSummary_ClosingCaseStatus PASSED");
                    }
                }
            }
        }

        [Test, Retry(3)]
        [Category("Selenium")]
        public void Test_CaseSummary_CaseHistoryAtAddress()
        {
            using (var driver = InitialiseDriver())
            {
                ExtentTest test = null;
                try
                {
                    test = extent.CreateTest("Test_CaseSummary_CaseHistoryAtAddress").Info("<div style= 'color:blue; font-weight:bold'>Test Started");
                    DynamicsLogin dynamicsLogin = new DynamicsLogin(driver);
                    dynamicsLogin.LoginWindow();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Dynamics account selected");

                    Dashboards dashboards = new Dashboards(driver);
                    dashboards.VerifyPageTitle();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'> Homepage Title verified");

                    CaseSummary caseSummary = new CaseSummary(driver);
                    caseSummary.CaseHistoryAtAddress();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Case history at address shown correctly");
                }
                catch (Exception e)
                {
                    Assert.Fail(e.StackTrace);
                }
                finally
                {
                    commonUtils.PrintLogs("browser", driver);

                    if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
                    {
                        string fileName = @"C:\Users\garymoore\OneDrive - Wakefield Council\Desktop\CRMRegressionPack\CRMRegressionPack\Screenshots\" + DateTime.Now.ToString("dd_MM_yy -HH_mm_ss") + ".Png";
                        Screenshot cp = ((ITakesScreenshot)driver).GetScreenshot();
                        cp.SaveAsFile(fileName, ScreenshotImageFormat.Png);
                        test.AddScreenCaptureFromPath(fileName);
                        test.Info(driver.Url);
                        test.Info(Environment.StackTrace.Replace(Environment.NewLine, "<br>"));
                        test.Log(Status.Fail, "<div style= 'color:red; font-weight:bold'>Test_CaseSummary_CaseHistoryAtAddress FAILED");
                    }
                    else if (TestContext.CurrentContext.Result.Outcome.Status != TestStatus.Failed)
                    {
                        test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Test_CaseSummary_CaseHistoryAtAddress PASSED");
                    }
                }
            }
        }

        [Test, Retry(3)]
        [Category("Selenium")]
        public void Test_CaseSummary_CaseEscalation()
        {
            using (var driver = InitialiseDriver())
            {
                ExtentTest test = null;
                try
                {
                    test = extent.CreateTest("Test_CaseSummary_CaseEscalation").Info("<div style= 'color:blue; font-weight:bold'>Test Started");
                    DynamicsLogin dynamicsLogin = new DynamicsLogin(driver);
                    dynamicsLogin.LoginWindow();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Dynamics account selected");

                    Dashboards dashboards = new Dashboards(driver);
                    dashboards.VerifyPageTitle();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'> Homepage Title verified");

                    CaseSummary caseSummary = new CaseSummary(driver);
                    caseSummary.CaseEscalation();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Case escalated correctly");
                }
                catch (Exception e)
                {
                    Assert.Fail(e.StackTrace);
                }
                finally
                {
                    commonUtils.PrintLogs("browser", driver);

                    if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
                    {
                        string fileName = @"C:\Users\garymoore\OneDrive - Wakefield Council\Desktop\CRMRegressionPack\CRMRegressionPack\Screenshots\" + DateTime.Now.ToString("dd_MM_yy -HH_mm_ss") + ".Png";
                        Screenshot cp = ((ITakesScreenshot)driver).GetScreenshot();
                        cp.SaveAsFile(fileName, ScreenshotImageFormat.Png);
                        test.AddScreenCaptureFromPath(fileName);
                        test.Info(driver.Url);
                        test.Info(Environment.StackTrace.Replace(Environment.NewLine, "<br>"));
                        test.Log(Status.Fail, "<div style= 'color:red; font-weight:bold'>Test_CaseSummary_CaseEscalation FAILED");
                    }
                    else if (TestContext.CurrentContext.Result.Outcome.Status != TestStatus.Failed)
                    {
                        test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Test_CaseSummary_CaseEscalation PASSED");
                    }
                }
            }
        }

        [Test, Retry(3)]
        [Category("Selenium")]
        public void Test_CaseSummary_CaseEscalationStage1()
        {
            using (var driver = InitialiseDriver())
            {
                ExtentTest test = null;
                try
                {
                    test = extent.CreateTest("Test_CaseSummary_CaseEscalationStage1").Info("<div style= 'color:blue; font-weight:bold'>Test Started");
                    DynamicsLogin dynamicsLogin = new DynamicsLogin(driver);
                    dynamicsLogin.LoginWindow();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Dynamics account selected");

                    Dashboards dashboards = new Dashboards(driver);
                    dashboards.VerifyPageTitle();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'> Homepage Title verified");

                    CaseSummary caseSummary = new CaseSummary(driver);
                    caseSummary.CaseEscalationStage1();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Case escalated to stage 1 correctly");
                }
                catch (Exception e)
                {
                    Assert.Fail(e.StackTrace);
                }
                finally
                {
                    commonUtils.PrintLogs("browser", driver);

                    if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
                    {
                        string fileName = @"C:\Users\garymoore\OneDrive - Wakefield Council\Desktop\CRMRegressionPack\CRMRegressionPack\Screenshots\" + DateTime.Now.ToString("dd_MM_yy -HH_mm_ss") + ".Png";
                        Screenshot cp = ((ITakesScreenshot)driver).GetScreenshot();
                        cp.SaveAsFile(fileName, ScreenshotImageFormat.Png);
                        test.AddScreenCaptureFromPath(fileName);
                        test.Info(driver.Url);
                        test.Info(Environment.StackTrace.Replace(Environment.NewLine, "<br>"));
                        test.Log(Status.Fail, "<div style= 'color:red; font-weight:bold'>Test_CaseSummary_CaseEscalationStage1 FAILED");
                    }
                    else if (TestContext.CurrentContext.Result.Outcome.Status != TestStatus.Failed)
                    {
                        test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Test_CaseSummary_CaseEscalationStage1 PASSED");
                    }
                }
            }
        }

        [Test, Retry(3)]
        [Category("Selenium")]
        public void Test_CaseSummary_CaseEscalationStage2()
        {
            using (var driver = InitialiseDriver())
            {
                ExtentTest test = null;
                try
                {
                    test = extent.CreateTest("Test_CaseSummary_CaseEscalationStage2").Info("<div style= 'color:blue; font-weight:bold'>Test Started");
                    DynamicsLogin dynamicsLogin = new DynamicsLogin(driver);
                    dynamicsLogin.LoginWindow();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Dynamics account selected");

                    Dashboards dashboards = new Dashboards(driver);
                    dashboards.VerifyPageTitle();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'> Homepage Title verified");

                    CaseSummary caseSummary = new CaseSummary(driver);
                    caseSummary.CaseEscalationStage2();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Case escalated to stage 2 correctly");
                }
                catch (Exception e)
                {
                    Assert.Fail(e.StackTrace);
                }
                finally
                {
                    commonUtils.PrintLogs("browser", driver);

                    if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
                    {
                        string fileName = @"C:\Users\garymoore\OneDrive - Wakefield Council\Desktop\CRMRegressionPack\CRMRegressionPack\Screenshots\" + DateTime.Now.ToString("dd_MM_yy -HH_mm_ss") + ".Png";
                        Screenshot cp = ((ITakesScreenshot)driver).GetScreenshot();
                        cp.SaveAsFile(fileName, ScreenshotImageFormat.Png);
                        test.AddScreenCaptureFromPath(fileName);
                        test.Info(driver.Url);
                        test.Info(Environment.StackTrace.Replace(Environment.NewLine, "<br>"));
                        test.Log(Status.Fail, "<div style= 'color:red; font-weight:bold'>Test_CaseSummary_CaseEscalationStage2 FAILED");
                    }
                    else if (TestContext.CurrentContext.Result.Outcome.Status != TestStatus.Failed)
                    {
                        test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Test_CaseSummary_CaseEscalationStage2 PASSED");
                    }
                }
            }
        }

        [Test, Retry(3)]
        [Category("Selenium")]
        public void Test_CaseSummary_CaseEscalationProDisagreement()
        {
            using (var driver = InitialiseDriver())
            {
                ExtentTest test = null;
                try
                {
                    test = extent.CreateTest("Test_CaseSummary_CaseEscalationProDisagreement").Info("<div style= 'color:blue; font-weight:bold'>Test Started");
                    DynamicsLogin dynamicsLogin = new DynamicsLogin(driver);
                    dynamicsLogin.LoginWindow();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Dynamics account selected");

                    Dashboards dashboards = new Dashboards(driver);
                    dashboards.VerifyPageTitle();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'> Homepage Title verified");

                    CaseSummary caseSummary = new CaseSummary(driver);
                    caseSummary.CaseEscalationProDisagreement();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Case escalated to professional disagreement correctly");
                }
                catch (Exception e)
                {
                    Assert.Fail(e.StackTrace);
                }
                finally
                {
                    commonUtils.PrintLogs("browser", driver);

                    if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
                    {
                        string fileName = @"C:\Users\garymoore\OneDrive - Wakefield Council\Desktop\CRMRegressionPack\CRMRegressionPack\Screenshots\" + DateTime.Now.ToString("dd_MM_yy -HH_mm_ss") + ".Png";
                        Screenshot cp = ((ITakesScreenshot)driver).GetScreenshot();
                        cp.SaveAsFile(fileName, ScreenshotImageFormat.Png);
                        test.AddScreenCaptureFromPath(fileName);
                        test.Info(driver.Url);
                        test.Info(Environment.StackTrace.Replace(Environment.NewLine, "<br>"));
                        test.Log(Status.Fail, "<div style= 'color:red; font-weight:bold'>Test_CaseSummary_CaseEscalationProDisagreement FAILED");
                    }
                    else if (TestContext.CurrentContext.Result.Outcome.Status != TestStatus.Failed)
                    {
                        test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Test_CaseSummary_CaseEscalationProDisagreement PASSED");
                    }
                }
            }
        }

        [Test, Retry(3)]
        [Category("Selenium")]
        public void Test_CaseSummary_CaseEscalationChildren()
        {
            using (var driver = InitialiseDriver())
            {
                ExtentTest test = null;
                try
                {
                    test = extent.CreateTest("Test_CaseSummary_CaseEscalationChildren").Info("<div style= 'color:blue; font-weight:bold'>Test Started");
                    DynamicsLogin dynamicsLogin = new DynamicsLogin(driver);
                    dynamicsLogin.LoginWindow();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Dynamics account selected");

                    Dashboards dashboards = new Dashboards(driver);
                    dashboards.VerifyPageTitle();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'> Homepage Title verified");

                    CaseSummary caseSummary = new CaseSummary(driver);
                    caseSummary.CaseEscalationChildren();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Child Case escalated correctly");
                }
                catch (Exception e)
                {
                    Assert.Fail(e.StackTrace);
                }
                finally
                {
                    commonUtils.PrintLogs("browser", driver);

                    if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
                    {
                        string fileName = @"C:\Users\garymoore\OneDrive - Wakefield Council\Desktop\CRMRegressionPack\CRMRegressionPack\Screenshots\" + DateTime.Now.ToString("dd_MM_yy -HH_mm_ss") + ".Png";
                        Screenshot cp = ((ITakesScreenshot)driver).GetScreenshot();
                        cp.SaveAsFile(fileName, ScreenshotImageFormat.Png);
                        test.AddScreenCaptureFromPath(fileName);
                        test.Info(driver.Url);
                        test.Info(Environment.StackTrace.Replace(Environment.NewLine, "<br>"));
                        test.Log(Status.Fail, "<div style= 'color:red; font-weight:bold'>Test_CaseSummary_CaseEscalationChildren FAILED");
                    }
                    else if (TestContext.CurrentContext.Result.Outcome.Status != TestStatus.Failed)
                    {
                        test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Test_CaseSummary_CaseEscalationChildren PASSED");
                    }
                }
            }
        }

        [Test, Retry(3)]
        [Category("Selenium")]
        public void Test_CaseSummary_CaseEscalationStage2Children()
        {
            using (var driver = InitialiseDriver())
            {
                ExtentTest test = null;
                try
                {
                    test = extent.CreateTest("Test_CaseSummary_CaseEscalationStage2Children").Info("<div style= 'color:blue; font-weight:bold'>Test Started");
                    DynamicsLogin dynamicsLogin = new DynamicsLogin(driver);
                    dynamicsLogin.LoginWindow();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Dynamics account selected");

                    Dashboards dashboards = new Dashboards(driver);
                    dashboards.VerifyPageTitle();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'> Homepage Title verified");

                    CaseSummary caseSummary = new CaseSummary(driver);
                    caseSummary.CaseEscalationStage2Children();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Child Case escalated to stage 2 correctly");
                }
                catch (Exception e)
                {
                    Assert.Fail(e.StackTrace);
                }
                finally
                {
                    commonUtils.PrintLogs("browser", driver);

                    if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
                    {
                        string fileName = @"C:\Users\garymoore\OneDrive - Wakefield Council\Desktop\CRMRegressionPack\CRMRegressionPack\Screenshots\" + DateTime.Now.ToString("dd_MM_yy -HH_mm_ss") + ".Png";
                        Screenshot cp = ((ITakesScreenshot)driver).GetScreenshot();
                        cp.SaveAsFile(fileName, ScreenshotImageFormat.Png);
                        test.AddScreenCaptureFromPath(fileName);
                        test.Info(driver.Url);
                        test.Info(Environment.StackTrace.Replace(Environment.NewLine, "<br>"));
                        test.Log(Status.Fail, "<div style= 'color:red; font-weight:bold'>Test_CaseSummary_CaseEscalationStage2Children FAILED");
                    }
                    else if (TestContext.CurrentContext.Result.Outcome.Status != TestStatus.Failed)
                    {
                        test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Test_CaseSummary_CaseEscalationStage2Children PASSED");
                    }
                }
            }
        }

        [Test, Retry(3)]
        [Category("Selenium")]
        public void Test_CaseSummary_CaseEscalationProDisChildren()
        {
            using (var driver = InitialiseDriver())
            {
                ExtentTest test = null;
                try
                {
                    test = extent.CreateTest("Test_CaseSummary_CaseEscalationProDisChildren").Info("<div style= 'color:blue; font-weight:bold'>Test Started");
                    DynamicsLogin dynamicsLogin = new DynamicsLogin(driver);
                    dynamicsLogin.LoginWindow();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Dynamics account selected");

                    Dashboards dashboards = new Dashboards(driver);
                    dashboards.VerifyPageTitle();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'> Homepage Title verified");

                    CaseSummary caseSummary = new CaseSummary(driver);
                    caseSummary.CaseEscalationProDisChildren();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Case escalated to professional disagreement correctly");
                }
                catch (Exception e)
                {
                    Assert.Fail(e.StackTrace);
                }
                finally
                {
                    commonUtils.PrintLogs("browser", driver);

                    if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
                    {
                        string fileName = @"C:\Users\garymoore\OneDrive - Wakefield Council\Desktop\CRMRegressionPack\CRMRegressionPack\Screenshots\" + DateTime.Now.ToString("dd_MM_yy -HH_mm_ss") + ".Png";
                        Screenshot cp = ((ITakesScreenshot)driver).GetScreenshot();
                        cp.SaveAsFile(fileName, ScreenshotImageFormat.Png);
                        test.AddScreenCaptureFromPath(fileName);
                        test.Info(driver.Url);
                        test.Info(Environment.StackTrace.Replace(Environment.NewLine, "<br>"));
                        test.Log(Status.Fail, "<div style= 'color:red; font-weight:bold'>Test_CaseSummary_CaseEscalationProDisChildren FAILED");
                    }
                    else if (TestContext.CurrentContext.Result.Outcome.Status != TestStatus.Failed)
                    {
                        test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Test_CaseSummary_CaseEscalationProDisChildren PASSED");
                    }
                }
            }
        }

        [Test, Retry(3)]
        [Category("Selenium")]
        public void Test_CaseSummary_DiscardACase()
        {
            using (var driver = InitialiseDriver())
            {
                ExtentTest test = null;
                try
                {
                    test = extent.CreateTest("Test_CaseSummary_DiscardACase").Info("<div style= 'color:blue; font-weight:bold'>Test Started");
                    DynamicsLogin dynamicsLogin = new DynamicsLogin(driver);
                    dynamicsLogin.LoginWindow();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Dynamics account selected");

                    Dashboards dashboards = new Dashboards(driver);
                    dashboards.VerifyPageTitle();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'> Homepage Title verified");

                    CaseSummary caseSummary = new CaseSummary(driver);
                    caseSummary.DiscardACase();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Discarded case displays correctly");
                }
                catch (Exception e)
                {
                    Assert.Fail(e.StackTrace);
                }
                finally
                {
                    commonUtils.PrintLogs("browser", driver);

                    if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
                    {
                        string fileName = @"C:\Users\garymoore\OneDrive - Wakefield Council\Desktop\CRMRegressionPack\CRMRegressionPack\Screenshots\" + DateTime.Now.ToString("dd_MM_yy -HH_mm_ss") + ".Png";
                        Screenshot cp = ((ITakesScreenshot)driver).GetScreenshot();
                        cp.SaveAsFile(fileName, ScreenshotImageFormat.Png);
                        test.AddScreenCaptureFromPath(fileName);
                        test.Info(driver.Url);
                        test.Info(Environment.StackTrace.Replace(Environment.NewLine, "<br>"));
                        test.Log(Status.Fail, "<div style= 'color:red; font-weight:bold'>Test_CaseSummary_DiscardACase FAILED");
                    }
                    else if (TestContext.CurrentContext.Result.Outcome.Status != TestStatus.Failed)
                    {
                        test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Test_CaseSummary_DiscardACase PASSED");
                    }
                }
            }
        }

        [Test, Retry(3)]
        [Category("Selenium")]
        public void Test_CaseSummary_AutoCloseCaseStatus()
        {
            using (var driver = InitialiseDriver())
            {
                ExtentTest test = null;
                try
                {
                    test = extent.CreateTest("Test_CaseSummary_AutoCloseCaseStatus").Info("<div style= 'color:blue; font-weight:bold'>Test Started");
                    DynamicsLogin dynamicsLogin = new DynamicsLogin(driver);
                    dynamicsLogin.LoginWindow();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Dynamics account selected");

                    Dashboards dashboards = new Dashboards(driver);
                    dashboards.VerifyPageTitle();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'> Homepage Title verified");

                    CaseSummary caseSummary = new CaseSummary(driver);
                    caseSummary.AutoCloseCaseStatus();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Case autoclosure working correctly");
                }
                catch (Exception e)
                {
                    Assert.Fail(e.StackTrace);
                }
                finally
                {
                    commonUtils.PrintLogs("browser", driver);

                    if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
                    {
                        string fileName = @"C:\Users\garymoore\OneDrive - Wakefield Council\Desktop\CRMRegressionPack\CRMRegressionPack\Screenshots\" + DateTime.Now.ToString("dd_MM_yy -HH_mm_ss") + ".Png";
                        Screenshot cp = ((ITakesScreenshot)driver).GetScreenshot();
                        cp.SaveAsFile(fileName, ScreenshotImageFormat.Png);
                        test.AddScreenCaptureFromPath(fileName);
                        test.Info(driver.Url);
                        test.Info(Environment.StackTrace.Replace(Environment.NewLine, "<br>"));
                        test.Log(Status.Fail, "<div style= 'color:red; font-weight:bold'>Test_CaseSummary_AutoCloseCaseStatus FAILED");
                    }
                    else if (TestContext.CurrentContext.Result.Outcome.Status != TestStatus.Failed)
                    {
                        test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Test_CaseSummary_AutoCloseCaseStatus PASSED");
                    }
                }
            }
        }

        [Test, Retry(3)]
        [Category("Selenium")]
        public void Test_Dashboards_CustomerAlerts()
        {
            using (var driver = InitialiseDriver())
            {
                ExtentTest test = null;
                try
                {
                    test = extent.CreateTest("Test_CaseSummary_CustomerAlerts").Info("<div style= 'color:blue; font-weight:bold'>Test Started");
                    DynamicsLogin dynamicsLogin = new DynamicsLogin(driver);
                    dynamicsLogin.LoginWindow();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Dynamics account selected");

                    Dashboards dashboards = new Dashboards(driver);
                    dashboards.VerifyPageTitle();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'> Homepage Title verified");

                    dashboards.CustomerAlerts();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Customer alerts displayed correctly");
                }
                catch (Exception e)
                {
                    Assert.Fail(e.StackTrace);
                }
                finally
                {
                    commonUtils.PrintLogs("browser", driver);

                    if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
                    {
                        string fileName = @"C:\Users\garymoore\OneDrive - Wakefield Council\Desktop\CRMRegressionPack\CRMRegressionPack\Screenshots\" + DateTime.Now.ToString("dd_MM_yy -HH_mm_ss") + ".Png";
                        Screenshot cp = ((ITakesScreenshot)driver).GetScreenshot();
                        cp.SaveAsFile(fileName, ScreenshotImageFormat.Png);
                        test.AddScreenCaptureFromPath(fileName);
                        test.Info(driver.Url);
                        test.Info(Environment.StackTrace.Replace(Environment.NewLine, "<br>"));
                        test.Log(Status.Fail, "<div style= 'color:red; font-weight:bold'>Test_Dashboards_CustomerAlerts FAILED");
                    }
                    else if (TestContext.CurrentContext.Result.Outcome.Status != TestStatus.Failed)
                    {
                        test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Test_Dashboards_CustomerAlerts PASSED");
                    }
                }
            }
        }

        [Test, Retry(3)]
        [Category("Selenium")]
        public void Test_Dashboards_OOACustomerAlerts()
        {
            using (var driver = InitialiseDriver())
            {
                ExtentTest test = null;
                try
                {
                    test = extent.CreateTest("Test_CaseSummary_OOACustomerAlerts").Info("<div style= 'color:blue; font-weight:bold'>Test Started");
                    DynamicsLogin dynamicsLogin = new DynamicsLogin(driver);
                    dynamicsLogin.LoginWindow();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Dynamics account selected");

                    Dashboards dashboards = new Dashboards(driver);
                    dashboards.VerifyPageTitle();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'> Homepage Title verified");

                    dashboards.OOACustomerAlerts();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Customer alerts displayed correctly for out of area customer");
                }
                catch (Exception e)
                {
                    Assert.Fail(e.StackTrace);
                }
                finally
                {
                    commonUtils.PrintLogs("browser", driver);

                    if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
                    {
                        string fileName = @"C:\Users\garymoore\OneDrive - Wakefield Council\Desktop\CRMRegressionPack\CRMRegressionPack\Screenshots\" + DateTime.Now.ToString("dd_MM_yy -HH_mm_ss") + ".Png";
                        Screenshot cp = ((ITakesScreenshot)driver).GetScreenshot();
                        cp.SaveAsFile(fileName, ScreenshotImageFormat.Png);
                        test.AddScreenCaptureFromPath(fileName);
                        test.Info(driver.Url);
                        test.Info(Environment.StackTrace.Replace(Environment.NewLine, "<br>"));
                        test.Log(Status.Fail, "<div style= 'color:red; font-weight:bold'>Test_Dashboards_OOACustomerAlerts FAILED");
                    }
                    else if (TestContext.CurrentContext.Result.Outcome.Status != TestStatus.Failed)
                    {
                        test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Test_Dashboards_OOACustomerAlerts PASSED");
                    }
                }
            }
        }

        [Test, Retry(3)]
        [Category("Selenium")]
        public void Test_Dashboards_ManualAddressCustomerAlerts()
        {
            using (var driver = InitialiseDriver())
            {
                ExtentTest test = null;
                try
                {
                    test = extent.CreateTest("Test_Dashboards_ManualAddressCustomerAlerts").Info("<div style= 'color:blue; font-weight:bold'>Test Started");
                    DynamicsLogin dynamicsLogin = new DynamicsLogin(driver);
                    dynamicsLogin.LoginWindow();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Dynamics account selected");

                    Dashboards dashboards = new Dashboards(driver);
                    dashboards.VerifyPageTitle();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'> Homepage Title verified");

                    dashboards.ManualAddressCustomerAlerts();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Customer alerts displayed correctly for customer with manual address");
                }
                catch (Exception e)
                {
                    Assert.Fail(e.StackTrace);
                }
                finally
                {
                    commonUtils.PrintLogs("browser", driver);

                    if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
                    {
                        string fileName = @"C:\Users\garymoore\OneDrive - Wakefield Council\Desktop\CRMRegressionPack\CRMRegressionPack\Screenshots\" + DateTime.Now.ToString("dd_MM_yy -HH_mm_ss") + ".Png";
                        Screenshot cp = ((ITakesScreenshot)driver).GetScreenshot();
                        cp.SaveAsFile(fileName, ScreenshotImageFormat.Png);
                        test.AddScreenCaptureFromPath(fileName);
                        test.Info(driver.Url);
                        test.Info(Environment.StackTrace.Replace(Environment.NewLine, "<br>"));
                        test.Log(Status.Fail, "<div style= 'color:red; font-weight:bold'>Test_Dashboards_ManualAddressCustomerAlerts FAILED");
                    }
                    else if (TestContext.CurrentContext.Result.Outcome.Status != TestStatus.Failed)
                    {
                        test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Test_Dashboards_ManualAddressCustomerAlerts PASSED");
                    }
                }
            }
        }

        [Test, Retry(3)]
        [Category("Selenium")]
        public void Test_Dashboards_UnknownAddressCustomerAlerts()
        {
            using (var driver = InitialiseDriver())
            {
                ExtentTest test = null;
                try
                {
                    test = extent.CreateTest("Test_CaseSummary_UnknownAddressCustomerAlerts").Info("<div style= 'color:blue; font-weight:bold'>Test Started");
                    DynamicsLogin dynamicsLogin = new DynamicsLogin(driver);
                    dynamicsLogin.LoginWindow();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Dynamics account selected");

                    Dashboards dashboards = new Dashboards(driver);
                    dashboards.VerifyPageTitle();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'> Homepage Title verified");

                    dashboards.UnknownAddressCustomerAlerts();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Customer alerts displayed correctly");
                }
                catch (Exception e)
                {
                    Assert.Fail(e.StackTrace);
                }
                finally
                {
                    commonUtils.PrintLogs("browser", driver);

                    if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
                    {
                        string fileName = @"C:\Users\garymoore\OneDrive - Wakefield Council\Desktop\CRMRegressionPack\CRMRegressionPack\Screenshots\" + DateTime.Now.ToString("dd_MM_yy -HH_mm_ss") + ".Png";
                        Screenshot cp = ((ITakesScreenshot)driver).GetScreenshot();
                        cp.SaveAsFile(fileName, ScreenshotImageFormat.Png);
                        test.AddScreenCaptureFromPath(fileName);
                        test.Info(driver.Url);
                        test.Info(Environment.StackTrace.Replace(Environment.NewLine, "<br>"));
                        test.Log(Status.Fail, "<div style= 'color:red; font-weight:bold'>Test_Dashboards_UnknownAddressCustomerAlerts FAILED");
                    }
                    else if (TestContext.CurrentContext.Result.Outcome.Status != TestStatus.Failed)
                    {
                        test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Test_Dashboards_UnknownAddressCustomerAlerts PASSED");
                    }
                }
            }
        }

        [Test, Retry(3)]
        [Category("Selenium")]
        public void Test_SkipHire_AddWorkHoursExistingResourceDateRange()
        {
            using (var driver = InitialiseDriver())
            {
                ExtentTest test = null;
                try
                {
                    test = extent.CreateTest("Test_SkipHire_AddWorkHoursExistingResourceDateRange").Info("<div style= 'color:blue; font-weight:bold'>Test Started");
                    DynamicsLogin dynamicsLogin = new DynamicsLogin(driver);
                    dynamicsLogin.LoginWindow();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Dynamics account selected");

                    SkipHire skipHire = new SkipHire(driver);
                    skipHire.AddWorkHoursExistingResourceDateRange();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Work hours added to existing resource correctly");
                }
                catch (Exception e)
                {
                    Assert.Fail(e.StackTrace);
                }
                finally
                {
                    commonUtils.PrintLogs("browser", driver);

                    if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
                    {
                        string fileName = @"C:\Users\garymoore\OneDrive - Wakefield Council\Desktop\CRMRegressionPack\CRMRegressionPack\Screenshots\" + DateTime.Now.ToString("dd_MM_yy -HH_mm_ss") + ".Png";
                        Screenshot cp = ((ITakesScreenshot)driver).GetScreenshot();
                        cp.SaveAsFile(fileName, ScreenshotImageFormat.Png);
                        test.AddScreenCaptureFromPath(fileName);
                        test.Info(driver.Url);
                        test.Info(Environment.StackTrace.Replace(Environment.NewLine, "<br>"));
                        test.Log(Status.Fail, "<div style= 'color:red; font-weight:bold'>Test_SkipHire_AddWorkHoursExistingResourceDateRange FAILED");
                    }
                    else if (TestContext.CurrentContext.Result.Outcome.Status != TestStatus.Failed)
                    {
                        test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Test_SkipHire_AddWorkHoursExistingResourceDateRange PASSED");
                    }
                }
            }
        }

        [Test, Retry(3)]
        [Category("Selenium")]
        public void Test_SkipHire_EditWorkHoursExistingResourceThisEvent()
        {
            using (var driver = InitialiseDriver())
            {
                ExtentTest test = null;
                try
                {
                    test = extent.CreateTest("Test_SkipHire_EditWorkHoursExistingResourceThisEvent").Info("<div style= 'color:blue; font-weight:bold'>Test Started");
                    DynamicsLogin dynamicsLogin = new DynamicsLogin(driver);
                    dynamicsLogin.LoginWindow();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Dynamics account selected");

                    SkipHire skipHire = new SkipHire(driver);
                    skipHire.EditWorkHoursExistingResourceThisEvent();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Work hours editted for existing resource correctly");
                }
                catch (Exception e)
                {
                    Assert.Fail(e.StackTrace);
                }
                finally
                {
                    commonUtils.PrintLogs("browser", driver);

                    if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
                    {
                        string fileName = @"C:\Users\garymoore\OneDrive - Wakefield Council\Desktop\CRMRegressionPack\CRMRegressionPack\Screenshots\" + DateTime.Now.ToString("dd_MM_yy -HH_mm_ss") + ".Png";
                        Screenshot cp = ((ITakesScreenshot)driver).GetScreenshot();
                        cp.SaveAsFile(fileName, ScreenshotImageFormat.Png);
                        test.AddScreenCaptureFromPath(fileName);
                        test.Info(driver.Url);
                        test.Info(Environment.StackTrace.Replace(Environment.NewLine, "<br>"));
                        test.Log(Status.Fail, "<div style= 'color:red; font-weight:bold'>Test_SkipHire_EditWorkHoursExistingResourceThisEvent FAILED");
                    }
                    else if (TestContext.CurrentContext.Result.Outcome.Status != TestStatus.Failed)
                    {
                        test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Test_SkipHire_EditWorkHoursExistingResourceThisEvent PASSED");
                    }
                }
            }
        }

        [Test, Retry(3)]
        [Category("Selenium")]
        public void Test_SkipHire_AddWorkHoursWithBreak()
        {
            using (var driver = InitialiseDriver())
            {
                ExtentTest test = null;
                try
                {
                    test = extent.CreateTest("Test_SkipHire_AddWorkHoursWithBreak").Info("<div style= 'color:blue; font-weight:bold'>Test Started");
                    DynamicsLogin dynamicsLogin = new DynamicsLogin(driver);
                    dynamicsLogin.LoginWindow();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Dynamics account selected");

                    SkipHire skipHire = new SkipHire(driver);
                    skipHire.AddWorkHoursWithBreak();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Work hours added with break to existing resource correctly");
                }
                catch (Exception e)
                {
                    Assert.Fail(e.StackTrace);
                }
                finally
                {
                    commonUtils.PrintLogs("browser", driver);

                    if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
                    {
                        string fileName = @"C:\Users\garymoore\OneDrive - Wakefield Council\Desktop\CRMRegressionPack\CRMRegressionPack\Screenshots\" + DateTime.Now.ToString("dd_MM_yy -HH_mm_ss") + ".Png";
                        Screenshot cp = ((ITakesScreenshot)driver).GetScreenshot();
                        cp.SaveAsFile(fileName, ScreenshotImageFormat.Png);
                        test.AddScreenCaptureFromPath(fileName);
                        test.Info(driver.Url);
                        test.Info(Environment.StackTrace.Replace(Environment.NewLine, "<br>"));
                        test.Log(Status.Fail, "<div style= 'color:red; font-weight:bold'>Test_SkipHire_AddWorkHoursWithBreak FAILED");
                    }
                    else if (TestContext.CurrentContext.Result.Outcome.Status != TestStatus.Failed)
                    {
                        test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Test_SkipHire_AddWorkHoursWithBreak PASSED");
                    }
                }
            }
        }

        [Test, Retry(3)]
        [Category("Selenium")]
        public void Test_SkipHire_ViewBookingsForResourceAndDate()
        {
            using (var driver = InitialiseDriver())
            {
                ExtentTest test = null;
                try
                {
                    test = extent.CreateTest("Test_SkipHire_ViewBookingsForResourceAndDate").Info("<div style= 'color:blue; font-weight:bold'>Test Started");
                    DynamicsLogin dynamicsLogin = new DynamicsLogin(driver);
                    dynamicsLogin.LoginWindow();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Dynamics account selected");

                    SkipHire skipHire = new SkipHire(driver);
                    skipHire.ViewBookingsForResourceAndDate();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>User can view bookings correctly");
                }
                catch (Exception e)
                {
                    Assert.Fail(e.StackTrace);
                }
                finally
                {
                    commonUtils.PrintLogs("browser", driver);

                    if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
                    {
                        string fileName = @"C:\Users\garymoore\OneDrive - Wakefield Council\Desktop\CRMRegressionPack\CRMRegressionPack\Screenshots\" + DateTime.Now.ToString("dd_MM_yy -HH_mm_ss") + ".Png";
                        Screenshot cp = ((ITakesScreenshot)driver).GetScreenshot();
                        cp.SaveAsFile(fileName, ScreenshotImageFormat.Png);
                        test.AddScreenCaptureFromPath(fileName);
                        test.Info(driver.Url);
                        test.Info(Environment.StackTrace.Replace(Environment.NewLine, "<br>"));
                        test.Log(Status.Fail, "<div style= 'color:red; font-weight:bold'>Test_SkipHire_ViewBookingsForResourceAndDate FAILED");
                    }
                    else if (TestContext.CurrentContext.Result.Outcome.Status != TestStatus.Failed)
                    {
                        test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Test_SkipHire_ViewBookingsForResourceAndDate PASSED");
                    }
                }
            }
        }

        [Test, Retry(3)]
        [Category("Selenium")]
        public void Test_SkipHire_PrivateBookingsQueue()
        {
            using (var driver = InitialiseDriver())
            {
                ExtentTest test = null;
                try
                {
                    test = extent.CreateTest("Test_SkipHire_PrivateBookingsQueue").Info("<div style= 'color:blue; font-weight:bold'>Test Started");
                    DynamicsLogin dynamicsLogin = new DynamicsLogin(driver);
                    dynamicsLogin.LoginWindow();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Dynamics account selected");

                    SkipHire skipHire = new SkipHire(driver);
                    skipHire.PrivateBookingsQueue();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>User can filter services on queue correctly");
                }
                catch (Exception e)
                {
                    Assert.Fail(e.StackTrace);
                }
                finally
                {
                    commonUtils.PrintLogs("browser", driver);

                    if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
                    {
                        string fileName = @"C:\Users\garymoore\OneDrive - Wakefield Council\Desktop\CRMRegressionPack\CRMRegressionPack\Screenshots\" + DateTime.Now.ToString("dd_MM_yy -HH_mm_ss") + ".Png";
                        Screenshot cp = ((ITakesScreenshot)driver).GetScreenshot();
                        cp.SaveAsFile(fileName, ScreenshotImageFormat.Png);
                        test.AddScreenCaptureFromPath(fileName);
                        test.Info(driver.Url);
                        test.Info(Environment.StackTrace.Replace(Environment.NewLine, "<br>"));
                        test.Log(Status.Fail, "<div style= 'color:red; font-weight:bold'>Test_SkipHire_PrivateBookingsQueue FAILED");
                    }
                    else if (TestContext.CurrentContext.Result.Outcome.Status != TestStatus.Failed)
                    {
                        test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Test_SkipHire_PrivateBookingsQueue PASSED");
                    }
                }
            }
        }

        [Test, Retry(3)]
        [Category("Selenium")]
        public void Test_SkipHire_LicenceCallBackQueue()
        {
            using (var driver = InitialiseDriver())
            {
                ExtentTest test = null;
                try
                {
                    test = extent.CreateTest("Test_SkipHire_LicenceCallBackQueue").Info("<div style= 'color:blue; font-weight:bold'>Test Started");
                    DynamicsLogin dynamicsLogin = new DynamicsLogin(driver);
                    dynamicsLogin.LoginWindow();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Dynamics account selected");

                    SkipHire skipHire = new SkipHire(driver);
                    skipHire.LicenceCallBackQueue();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>User can pick case from the list corrctly");
                }
                catch (Exception e)
                {
                    Assert.Fail(e.StackTrace);
                }
                finally
                {
                    commonUtils.PrintLogs("browser", driver);

                    if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
                    {
                        string fileName = @"C:\Users\garymoore\OneDrive - Wakefield Council\Desktop\CRMRegressionPack\CRMRegressionPack\Screenshots\" + DateTime.Now.ToString("dd_MM_yy -HH_mm_ss") + ".Png";
                        Screenshot cp = ((ITakesScreenshot)driver).GetScreenshot();
                        cp.SaveAsFile(fileName, ScreenshotImageFormat.Png);
                        test.AddScreenCaptureFromPath(fileName);
                        test.Info(driver.Url);
                        test.Info(Environment.StackTrace.Replace(Environment.NewLine, "<br>"));
                        test.Log(Status.Fail, "<div style= 'color:red; font-weight:bold'>Test_SkipHire_LicenceCallBackQueue FAILED");
                    }
                    else if (TestContext.CurrentContext.Result.Outcome.Status != TestStatus.Failed)
                    {
                        test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Test_SkipHire_LicenceCallBackQueue PASSED");
                    }
                }
            }
        }

        [Test, Retry(3)]
        [Category("Selenium")]
        public void Test_SkipHire_LicenceCallBackReject()
        {
            using (var driver = InitialiseDriver())
            {
                ExtentTest test = null;
                try
                {
                    test = extent.CreateTest("Test_SkipHire_LicenceCallBackReject").Info("<div style= 'color:blue; font-weight:bold'>Test Started");
                    DynamicsLogin dynamicsLogin = new DynamicsLogin(driver);
                    dynamicsLogin.LoginWindow();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Dynamics account selected");

                    SkipHire skipHire = new SkipHire(driver);
                    skipHire.LicenceCallBackReject();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Case status updated corrctly");
                }
                catch (Exception e)
                {
                    Assert.Fail(e.StackTrace);
                }
                finally
                {
                    commonUtils.PrintLogs("browser", driver);

                    if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
                    {
                        string fileName = @"C:\Users\garymoore\OneDrive - Wakefield Council\Desktop\CRMRegressionPack\CRMRegressionPack\Screenshots\" + DateTime.Now.ToString("dd_MM_yy -HH_mm_ss") + ".Png";
                        Screenshot cp = ((ITakesScreenshot)driver).GetScreenshot();
                        cp.SaveAsFile(fileName, ScreenshotImageFormat.Png);
                        test.AddScreenCaptureFromPath(fileName);
                        test.Info(driver.Url);
                        test.Info(Environment.StackTrace.Replace(Environment.NewLine, "<br>"));
                        test.Log(Status.Fail, "<div style= 'color:red; font-weight:bold'>Test_SkipHire_LicenceCallBackReject FAILED");
                    }
                    else if (TestContext.CurrentContext.Result.Outcome.Status != TestStatus.Failed)
                    {
                        test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Test_SkipHire_LicenceCallBackReject PASSED");
                    }
                }
            }
        }

        [Test, Retry(3)]
        [Category("Selenium")]
        public void Test_SkipHire_LicenceCallBackAccept()
        {
            using (var driver = InitialiseDriver())
            {
                ExtentTest test = null;
                try
                {
                    test = extent.CreateTest("Test_SkipHire_LicenceCallBackAccept").Info("<div style= 'color:blue; font-weight:bold'>Test Started");
                    DynamicsLogin dynamicsLogin = new DynamicsLogin(driver);
                    dynamicsLogin.LoginWindow();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Dynamics account selected");

                    SkipHire skipHire = new SkipHire(driver);
                    skipHire.LicenceCallBackAccept();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Case status updated corrctly");
                }
                catch (Exception e)
                {
                    Assert.Fail(e.StackTrace);
                }
                finally
                {
                    commonUtils.PrintLogs("browser", driver);

                    if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
                    {
                        string fileName = @"C:\Users\garymoore\OneDrive - Wakefield Council\Desktop\CRMRegressionPack\CRMRegressionPack\Screenshots\" + DateTime.Now.ToString("dd_MM_yy -HH_mm_ss") + ".Png";
                        Screenshot cp = ((ITakesScreenshot)driver).GetScreenshot();
                        cp.SaveAsFile(fileName, ScreenshotImageFormat.Png);
                        test.AddScreenCaptureFromPath(fileName);
                        test.Info(driver.Url);
                        test.Info(Environment.StackTrace.Replace(Environment.NewLine, "<br>"));
                        test.Log(Status.Fail, "<div style= 'color:red; font-weight:bold'>Test_SkipHire_LicenceCallBackAccept FAILED");
                    }
                    else if (TestContext.CurrentContext.Result.Outcome.Status != TestStatus.Failed)
                    {
                        test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Test_SkipHire_LicenceCallBackAccept PASSED");
                    }
                }
            }
        }

        [Test, Retry(3)]
        [Category("Selenium")]
        public void Test_SkipHire_AddLicenceToBooking()
        {
            using (var driver = InitialiseDriver())
            {
                ExtentTest test = null;
                try
                {
                    test = extent.CreateTest("Test_SkipHire_AddLicenceToBooking").Info("<div style= 'color:blue; font-weight:bold'>Test Started");
                    DynamicsLogin dynamicsLogin = new DynamicsLogin(driver);
                    dynamicsLogin.LoginWindow();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Dynamics account selected");

                    SkipHire skipHire = new SkipHire(driver);
                    skipHire.AddLicenceToBooking();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'Skip licence added to case corrctly");
                }
                catch (Exception e)
                {
                    Assert.Fail(e.StackTrace);
                }
                finally
                {
                    commonUtils.PrintLogs("browser", driver);

                    if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
                    {
                        string fileName = @"C:\Users\garymoore\OneDrive - Wakefield Council\Desktop\CRMRegressionPack\CRMRegressionPack\Screenshots\" + DateTime.Now.ToString("dd_MM_yy -HH_mm_ss") + ".Png";
                        Screenshot cp = ((ITakesScreenshot)driver).GetScreenshot();
                        cp.SaveAsFile(fileName, ScreenshotImageFormat.Png);
                        test.AddScreenCaptureFromPath(fileName);
                        test.Info(driver.Url);
                        test.Info(Environment.StackTrace.Replace(Environment.NewLine, "<br>"));
                        test.Log(Status.Fail, "<div style= 'color:red; font-weight:bold'>Test_SkipHire_AddLicenceToBooking FAILED");
                    }
                    else if (TestContext.CurrentContext.Result.Outcome.Status != TestStatus.Failed)
                    {
                        test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Test_SkipHire_AddLicenceToBooking PASSED");
                    }
                }
            }
        }

        [Test, Retry(3)]
        [Category("Selenium")]
        public void Test_SkipHire_ViewBookingsScheduleBoard()
        {
            using (var driver = InitialiseDriver())
            {
                ExtentTest test = null;
                try
                {
                    test = extent.CreateTest("Test_SkipHire_ViewBookingsScheduleBoard").Info("<div style= 'color:blue; font-weight:bold'>Test Started");
                    DynamicsLogin dynamicsLogin = new DynamicsLogin(driver);
                    dynamicsLogin.LoginWindow();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Dynamics account selected");

                    SkipHire skipHire = new SkipHire(driver);
                    skipHire.ViewBookingsScheduleBoard();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'Skip hire schedule board works correctly");
                }
                catch (Exception e)
                {
                    Assert.Fail(e.StackTrace);
                }
                finally
                {
                    commonUtils.PrintLogs("browser", driver);

                    if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
                    {
                        string fileName = @"C:\Users\garymoore\OneDrive - Wakefield Council\Desktop\CRMRegressionPack\CRMRegressionPack\Screenshots\" + DateTime.Now.ToString("dd_MM_yy -HH_mm_ss") + ".Png";
                        Screenshot cp = ((ITakesScreenshot)driver).GetScreenshot();
                        cp.SaveAsFile(fileName, ScreenshotImageFormat.Png);
                        test.AddScreenCaptureFromPath(fileName);
                        test.Info(driver.Url);
                        test.Info(Environment.StackTrace.Replace(Environment.NewLine, "<br>"));
                        test.Log(Status.Fail, "<div style= 'color:red; font-weight:bold'>Test_SkipHire_ViewBookingsScheduleBoard FAILED");
                    }
                    else if (TestContext.CurrentContext.Result.Outcome.Status != TestStatus.Failed)
                    {
                        test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Test_SkipHire_ViewBookingsScheduleBoard PASSED");
                    }
                }
            }
        }

        [Test, Retry(3)]
        [Category("Selenium")]
        public void Test_SkipHire_CollectionDateChange()
        {
            using (var driver = InitialiseDriver())
            {
                ExtentTest test = null;
                try
                {
                    test = extent.CreateTest("Test_SkipHire_CollectionDateChange").Info("<div style= 'color:blue; font-weight:bold'>Test Started");
                    DynamicsLogin dynamicsLogin = new DynamicsLogin(driver);
                    dynamicsLogin.LoginWindow();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Dynamics account selected");

                    SkipHire skipHire = new SkipHire(driver);
                    skipHire.CollectionDateChange();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'Skip hire collection date changed correctly");
                }
                catch (Exception e)
                {
                    Assert.Fail(e.StackTrace);
                }
                finally
                {
                    commonUtils.PrintLogs("browser", driver);

                    if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
                    {
                        string fileName = @"C:\Users\garymoore\OneDrive - Wakefield Council\Desktop\CRMRegressionPack\CRMRegressionPack\Screenshots\" + DateTime.Now.ToString("dd_MM_yy -HH_mm_ss") + ".Png";
                        Screenshot cp = ((ITakesScreenshot)driver).GetScreenshot();
                        cp.SaveAsFile(fileName, ScreenshotImageFormat.Png);
                        test.AddScreenCaptureFromPath(fileName);
                        test.Info(driver.Url);
                        test.Info(Environment.StackTrace.Replace(Environment.NewLine, "<br>"));
                        test.Log(Status.Fail, "<div style= 'color:red; font-weight:bold'>Test_SkipHire_CollectionDateChange FAILED");
                    }
                    else if (TestContext.CurrentContext.Result.Outcome.Status != TestStatus.Failed)
                    {
                        test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Test_SkipHire_CollectionDateChange PASSED");
                    }
                }
            }
        }

        [Test, Retry(3)]
        [Category("Selenium")]
        public void Test_SkipHire_MyAccountBookMidiPrivateEast()
        {
            using (var driver = InitialiseMyAccountDriver())
            {
                ExtentTest test = null;
                try
                {
                    test = extent.CreateTest("Test_SkipHire_MyAccountBookMidiPrivateEast").Info("<div style= 'color:blue; font-weight:bold'>Test Started");
                    DynamicsLogin dynamicsLogin = new DynamicsLogin(driver);
                    dynamicsLogin.LoginWindow();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Dynamics account selected");

                    SkipHire skipHire = new SkipHire(driver);
                    skipHire.MyAccountBookMidiPrivateEast();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'Skip hire for east district completed successfully");
                }
                catch (Exception e)
                {
                    Assert.Fail(e.StackTrace);
                }
                finally
                {
                    commonUtils.PrintLogs("browser", driver);

                    if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
                    {
                        string fileName = @"C:\Users\garymoore\OneDrive - Wakefield Council\Desktop\CRMRegressionPack\CRMRegressionPack\Screenshots\" + DateTime.Now.ToString("dd_MM_yy -HH_mm_ss") + ".Png";
                        Screenshot cp = ((ITakesScreenshot)driver).GetScreenshot();
                        cp.SaveAsFile(fileName, ScreenshotImageFormat.Png);
                        test.AddScreenCaptureFromPath(fileName);
                        test.Info(driver.Url);
                        test.Info(Environment.StackTrace.Replace(Environment.NewLine, "<br>"));
                        test.Log(Status.Fail, "<div style= 'color:red; font-weight:bold'>Test_SkipHire_MyAccountBookMidiPrivateEast FAILED");
                    }
                    else if (TestContext.CurrentContext.Result.Outcome.Status != TestStatus.Failed)
                    {
                        test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Test_SkipHire_MyAccountBookMidiPrivateEast PASSED");
                    }
                }
            }
        }

        [Test, Retry(3)]
        [Category("Selenium")]
        public void Test_SkipHire_MyAccountBookMidiPrivateWest()
        {
            using (var driver = InitialiseMyAccountDriver())
            {
                ExtentTest test = null;
                try
                {
                    test = extent.CreateTest("Test_SkipHire_MyAccountBookMidiPrivateWest").Info("<div style= 'color:blue; font-weight:bold'>Test Started");
                    DynamicsLogin dynamicsLogin = new DynamicsLogin(driver);
                    dynamicsLogin.LoginWindow();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Dynamics account selected");

                    SkipHire skipHire = new SkipHire(driver);
                    skipHire.MyAccountBookMidiPrivateWest();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'Skip hire for west district completed successfully");
                }
                catch (Exception e)
                {
                    Assert.Fail(e.StackTrace);
                }
                finally
                {
                    commonUtils.PrintLogs("browser", driver);

                    if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
                    {
                        string fileName = @"C:\Users\garymoore\OneDrive - Wakefield Council\Desktop\CRMRegressionPack\CRMRegressionPack\Screenshots\" + DateTime.Now.ToString("dd_MM_yy -HH_mm_ss") + ".Png";
                        Screenshot cp = ((ITakesScreenshot)driver).GetScreenshot();
                        cp.SaveAsFile(fileName, ScreenshotImageFormat.Png);
                        test.AddScreenCaptureFromPath(fileName);
                        test.Info(driver.Url);
                        test.Info(Environment.StackTrace.Replace(Environment.NewLine, "<br>"));
                        test.Log(Status.Fail, "<div style= 'color:red; font-weight:bold'>Test_SkipHire_MyAccountBookMidiPrivateWest FAILED");
                    }
                    else if (TestContext.CurrentContext.Result.Outcome.Status != TestStatus.Failed)
                    {
                        test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Test_SkipHire_MyAccountBookMidiPrivateWest PASSED");
                    }
                }
            }
        }

        [Test, Retry(3)]
        [Category("Selenium")]
        public void Test_SkipHire_MyAccountBookMaxiPrivateEast()
        {
            using (var driver = InitialiseMyAccountDriver())
            {
                ExtentTest test = null;
                try
                {
                    test = extent.CreateTest("Test_SkipHire_MyAccountBookMaxiPrivateEast").Info("<div style= 'color:blue; font-weight:bold'>Test Started");
                    DynamicsLogin dynamicsLogin = new DynamicsLogin(driver);
                    dynamicsLogin.LoginWindow();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Dynamics account selected");

                    SkipHire skipHire = new SkipHire(driver);
                    skipHire.MyAccountBookMaxiPrivateEast();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'Skip hire for east district completed successfully");
                }
                catch (Exception e)
                {
                    Assert.Fail(e.StackTrace);
                }
                finally
                {
                    commonUtils.PrintLogs("browser", driver);

                    if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
                    {
                        string fileName = @"C:\Users\garymoore\OneDrive - Wakefield Council\Desktop\CRMRegressionPack\CRMRegressionPack\Screenshots\" + DateTime.Now.ToString("dd_MM_yy -HH_mm_ss") + ".Png";
                        Screenshot cp = ((ITakesScreenshot)driver).GetScreenshot();
                        cp.SaveAsFile(fileName, ScreenshotImageFormat.Png);
                        test.AddScreenCaptureFromPath(fileName);
                        test.Info(driver.Url);
                        test.Info(Environment.StackTrace.Replace(Environment.NewLine, "<br>"));
                        test.Log(Status.Fail, "<div style= 'color:red; font-weight:bold'>Test_SkipHire_MyAccountBookMaxiPrivateEast FAILED");
                    }
                    else if (TestContext.CurrentContext.Result.Outcome.Status != TestStatus.Failed)
                    {
                        test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Test_SkipHire_MyAccountBookMaxiPrivateEast PASSED");
                    }
                }
            }
        }

        [Test, Retry(3)]
        [Category("Selenium")]
        public void Test_SkipHire_MyAccountBookMaxiPrivateWest()
        {
            using (var driver = InitialiseMyAccountDriver())
            {
                ExtentTest test = null;
                try
                {
                    test = extent.CreateTest("Test_SkipHire_MyAccountBookMaxiPrivateWest").Info("<div style= 'color:blue; font-weight:bold'>Test Started");
                    DynamicsLogin dynamicsLogin = new DynamicsLogin(driver);
                    dynamicsLogin.LoginWindow();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Dynamics account selected");

                    SkipHire skipHire = new SkipHire(driver);
                    skipHire.MyAccountBookMaxiPrivateWest();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'Skip hire for west district completed successfully");
                }
                catch (Exception e)
                {
                    Assert.Fail(e.StackTrace);
                }
                finally
                {
                    commonUtils.PrintLogs("browser", driver);

                    if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
                    {
                        string fileName = @"C:\Users\garymoore\OneDrive - Wakefield Council\Desktop\CRMRegressionPack\CRMRegressionPack\Screenshots\" + DateTime.Now.ToString("dd_MM_yy -HH_mm_ss") + ".Png";
                        Screenshot cp = ((ITakesScreenshot)driver).GetScreenshot();
                        cp.SaveAsFile(fileName, ScreenshotImageFormat.Png);
                        test.AddScreenCaptureFromPath(fileName);
                        test.Info(driver.Url);
                        test.Info(Environment.StackTrace.Replace(Environment.NewLine, "<br>"));
                        test.Log(Status.Fail, "<div style= 'color:red; font-weight:bold'>Test_SkipHire_MyAccountBookMaxiPrivateWest FAILED");
                    }
                    else if (TestContext.CurrentContext.Result.Outcome.Status != TestStatus.Failed)
                    {
                        test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Test_SkipHire_MyAccountBookMaxiPrivateWest PASSED");
                    }
                }
            }
        }

        [Test, Retry(3)]
        [Category("Selenium")]
        public void Test_SkipHire_MyAccountBookAbandonPayment()
        {
            using (var driver = InitialiseMyAccountDriver())
            {
                ExtentTest test = null;
                try
                {
                    test = extent.CreateTest("Test_SkipHire_MyAccountBookAbandonPayment").Info("<div style= 'color:blue; font-weight:bold'>Test Started");
                    DynamicsLogin dynamicsLogin = new DynamicsLogin(driver);
                    dynamicsLogin.LoginWindow();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Dynamics account selected");

                    SkipHire skipHire = new SkipHire(driver);
                    skipHire.MyAccountBookAbandonPayment();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'Skip hire abandon payment completed successfully");
                }
                catch (Exception e)
                {
                    Assert.Fail(e.StackTrace);
                }
                finally
                {
                    commonUtils.PrintLogs("browser", driver);

                    if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
                    {
                        string fileName = @"C:\Users\garymoore\OneDrive - Wakefield Council\Desktop\CRMRegressionPack\CRMRegressionPack\Screenshots\" + DateTime.Now.ToString("dd_MM_yy -HH_mm_ss") + ".Png";
                        Screenshot cp = ((ITakesScreenshot)driver).GetScreenshot();
                        cp.SaveAsFile(fileName, ScreenshotImageFormat.Png);
                        test.AddScreenCaptureFromPath(fileName);
                        test.Info(driver.Url);
                        test.Info(Environment.StackTrace.Replace(Environment.NewLine, "<br>"));
                        test.Log(Status.Fail, "<div style= 'color:red; font-weight:bold'>Test_SkipHire_MyAccountBookAbandonPayment FAILED");
                    }
                    else if (TestContext.CurrentContext.Result.Outcome.Status != TestStatus.Failed)
                    {
                        test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Test_SkipHire_MyAccountBookAbandonPayment PASSED");
                    }
                }
            }
        }

        [Test, Retry(3)]
        [Category("Selenium")]
        public void Test_SkipHire_MyAccountBookRoadRequestCallBackEast()
        {
            using (var driver = InitialiseMyAccountDriver())
            {
                ExtentTest test = null;
                try
                {
                    test = extent.CreateTest("Test_SkipHire_MyAccountBookRoadRequestCallBackEast").Info("<div style= 'color:blue; font-weight:bold'>Test Started");
                    DynamicsLogin dynamicsLogin = new DynamicsLogin(driver);
                    dynamicsLogin.LoginWindow();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Dynamics account selected");

                    SkipHire skipHire = new SkipHire(driver);
                    skipHire.MyAccountBookRoadRequestCallBackEast();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'Skip hire request call back completed successfully");
                }
                catch (Exception e)
                {
                    Assert.Fail(e.StackTrace);
                }
                finally
                {
                    commonUtils.PrintLogs("browser", driver);

                    if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
                    {
                        string fileName = @"C:\Users\garymoore\OneDrive - Wakefield Council\Desktop\CRMRegressionPack\CRMRegressionPack\Screenshots\" + DateTime.Now.ToString("dd_MM_yy -HH_mm_ss") + ".Png";
                        Screenshot cp = ((ITakesScreenshot)driver).GetScreenshot();
                        cp.SaveAsFile(fileName, ScreenshotImageFormat.Png);
                        test.AddScreenCaptureFromPath(fileName);
                        test.Info(driver.Url);
                        test.Info(Environment.StackTrace.Replace(Environment.NewLine, "<br>"));
                        test.Log(Status.Fail, "<div style= 'color:red; font-weight:bold'>Test_SkipHire_MyAccountBookRoadRequestCallBackEast FAILED");
                    }
                    else if (TestContext.CurrentContext.Result.Outcome.Status != TestStatus.Failed)
                    {
                        test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Test_SkipHire_MyAccountBookRoadRequestCallBackEast PASSED");
                    }
                }
            }
        }

        [Test, Retry(3)]
        [Category("Selenium")]
        public void Test_SkipHire_MyAccountBookRoadRequestCallBackWest()
        {
            using (var driver = InitialiseMyAccountDriver())
            {
                ExtentTest test = null;
                try
                {
                    test = extent.CreateTest("Test_SkipHire_MyAccountBookRoadRequestCallBackWest").Info("<div style= 'color:blue; font-weight:bold'>Test Started");
                    DynamicsLogin dynamicsLogin = new DynamicsLogin(driver);
                    dynamicsLogin.LoginWindow();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Dynamics account selected");

                    SkipHire skipHire = new SkipHire(driver);
                    skipHire.MyAccountBookRoadRequestCallBackWest();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'Skip hire request call back completed successfully");
                }
                catch (Exception e)
                {
                    Assert.Fail(e.StackTrace);
                }
                finally
                {
                    commonUtils.PrintLogs("browser", driver);

                    if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
                    {
                        string fileName = @"C:\Users\garymoore\OneDrive - Wakefield Council\Desktop\CRMRegressionPack\CRMRegressionPack\Screenshots\" + DateTime.Now.ToString("dd_MM_yy -HH_mm_ss") + ".Png";
                        Screenshot cp = ((ITakesScreenshot)driver).GetScreenshot();
                        cp.SaveAsFile(fileName, ScreenshotImageFormat.Png);
                        test.AddScreenCaptureFromPath(fileName);
                        test.Info(driver.Url);
                        test.Info(Environment.StackTrace.Replace(Environment.NewLine, "<br>"));
                        test.Log(Status.Fail, "<div style= 'color:red; font-weight:bold'>Test_SkipHire_MyAccountBookRoadRequestCallBackWest FAILED");
                    }
                    else if (TestContext.CurrentContext.Result.Outcome.Status != TestStatus.Failed)
                    {
                        test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Test_SkipHire_MyAccountBookRoadRequestCallBackWest PASSED");
                    }
                }
            }
        }

        [Test, Retry(3)]
        [Category("Selenium")]
        public void Test_SkipHire_MyAccountBookCancelPayment()
        {
            using (var driver = InitialiseMyAccountDriver())
            {
                ExtentTest test = null;
                try
                {
                    test = extent.CreateTest("Test_SkipHire_MyAccountBookCancelPayment").Info("<div style= 'color:blue; font-weight:bold'>Test Started");
                    DynamicsLogin dynamicsLogin = new DynamicsLogin(driver);
                    dynamicsLogin.LoginWindow();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Dynamics account selected");

                    SkipHire skipHire = new SkipHire(driver);
                    skipHire.MyAccountBookCancelPayment();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'Skip hire payment cancelled successfully");
                }
                catch (Exception e)
                {
                    Assert.Fail(e.StackTrace);
                }
                finally
                {
                    commonUtils.PrintLogs("browser", driver);

                    if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
                    {
                        string fileName = @"C:\Users\garymoore\OneDrive - Wakefield Council\Desktop\CRMRegressionPack\CRMRegressionPack\Screenshots\" + DateTime.Now.ToString("dd_MM_yy -HH_mm_ss") + ".Png";
                        Screenshot cp = ((ITakesScreenshot)driver).GetScreenshot();
                        cp.SaveAsFile(fileName, ScreenshotImageFormat.Png);
                        test.AddScreenCaptureFromPath(fileName);
                        test.Info(driver.Url);
                        test.Info(Environment.StackTrace.Replace(Environment.NewLine, "<br>"));
                        test.Log(Status.Fail, "<div style= 'color:red; font-weight:bold'>Test_SkipHire_MyAccountBookCancelPayment FAILED");
                    }
                    else if (TestContext.CurrentContext.Result.Outcome.Status != TestStatus.Failed)
                    {
                        test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Test_SkipHire_MyAccountBookCancelPayment PASSED");
                    }
                }
            }
        }

        [Test, Retry(3)]
        [Category("Selenium")]
        public void Test_SkipHire_AdminTCCallBack()
        {
            using (var driver = InitialiseMyAccountDriver())
            {
                ExtentTest test = null;
                try
                {
                    test = extent.CreateTest("Test_SkipHire_AdminTCCallBack").Info("<div style= 'color:blue; font-weight:bold'>Test Started");
                    DynamicsLogin dynamicsLogin = new DynamicsLogin(driver);
                    dynamicsLogin.LoginWindow();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Dynamics account selected");

                    SkipHire skipHire = new SkipHire(driver);
                    skipHire.AdminTCCallBack();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'Skip hire T&C's callback journey completed successfully");
                }
                catch (Exception e)
                {
                    Assert.Fail(e.StackTrace);
                }
                finally
                {
                    commonUtils.PrintLogs("browser", driver);

                    if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
                    {
                        string fileName = @"C:\Users\garymoore\OneDrive - Wakefield Council\Desktop\CRMRegressionPack\CRMRegressionPack\Screenshots\" + DateTime.Now.ToString("dd_MM_yy -HH_mm_ss") + ".Png";
                        Screenshot cp = ((ITakesScreenshot)driver).GetScreenshot();
                        cp.SaveAsFile(fileName, ScreenshotImageFormat.Png);
                        test.AddScreenCaptureFromPath(fileName);
                        test.Info(driver.Url);
                        test.Info(Environment.StackTrace.Replace(Environment.NewLine, "<br>"));
                        test.Log(Status.Fail, "<div style= 'color:red; font-weight:bold'>Test_SkipHire_AdminTCCallBack FAILED");
                    }
                    else if (TestContext.CurrentContext.Result.Outcome.Status != TestStatus.Failed)
                    {
                        test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Test_SkipHire_AdminTCCallBack PASSED");
                    }
                }
            }
        }

        [Test, Retry(3)]
        [Category("Selenium")]
        public void Test_ZClearData_Customer()
        {
            using (var driver = InitialiseDriver())
            {
                ExtentTest test = null;
                try
                {
                    test = extent.CreateTest("Test_ZClearData_Customer").Info("<div style= 'color:blue; font-weight:bold'>Test Started");
                    DynamicsLogin dynamicsLogin = new DynamicsLogin(driver);
                    dynamicsLogin.LoginWindow();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Dynamics account selected");

                    DataClearup dataClearup = new DataClearup(driver);
                    dataClearup.ClearDataCustomer();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Leftover customer data cleared successfully");
                }
                catch (Exception e)
                {
                    Assert.Fail(e.StackTrace);
                }
                finally
                {
                    commonUtils.PrintLogs("browser", driver);

                    if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
                    {
                        string fileName = @"C:\Users\garymoore\OneDrive - Wakefield Council\Desktop\CRMRegressionPack\CRMRegressionPack\Screenshots\" + DateTime.Now.ToString("dd_MM_yy -HH_mm_ss") + ".Png";
                        Screenshot cp = ((ITakesScreenshot)driver).GetScreenshot();
                        cp.SaveAsFile(fileName, ScreenshotImageFormat.Png);
                        test.AddScreenCaptureFromPath(fileName);
                        test.Info(driver.Url);
                        test.Info(Environment.StackTrace.Replace(Environment.NewLine, "<br>"));
                        test.Log(Status.Fail, "<div style= 'color:red; font-weight:bold'>Test_ClearData_Customer FAILED");
                    }
                    else if (TestContext.CurrentContext.Result.Outcome.Status != TestStatus.Failed)
                    {
                        test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Test_ClearData_Customer PASSED");
                    }
                }
            }
        }
        
        [Test, Retry(3)]
        [Category("Selenium")]
        public void Test_ZClearData_Business()
        {
            using (var driver = InitialiseDriver())
            {
                ExtentTest test = null;
                try
                {
                    test = extent.CreateTest("Test_ZClearData_Business").Info("<div style= 'color:blue; font-weight:bold'>Test Started");
                    DynamicsLogin dynamicsLogin = new DynamicsLogin(driver);
                    dynamicsLogin.LoginWindow();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Dynamics account selected");

                    DataClearup dataClearup = new DataClearup(driver);
                    dataClearup.DataClearBusiness();
                    test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Leftover business data cleared successfully");
                }
                catch (Exception e)
                {
                    Assert.Fail(e.StackTrace);
                }
                finally
                {
                    commonUtils.PrintLogs("browser", driver);

                    if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
                    {
                        string fileName = @"C:\Users\garymoore\OneDrive - Wakefield Council\Desktop\CRMRegressionPack\CRMRegressionPack\Screenshots\" + DateTime.Now.ToString("dd_MM_yy -HH_mm_ss") + ".Png";
                        Screenshot cp = ((ITakesScreenshot)driver).GetScreenshot();
                        cp.SaveAsFile(fileName, ScreenshotImageFormat.Png);
                        test.AddScreenCaptureFromPath(fileName);
                        test.Info(driver.Url);
                        test.Info(Environment.StackTrace.Replace(Environment.NewLine, "<br>"));
                        test.Log(Status.Fail, "<div style= 'color:red; font-weight:bold'>Test_ClearData_Business FAILED");
                    }
                    else if (TestContext.CurrentContext.Result.Outcome.Status != TestStatus.Failed)
                    {
                        test.Log(Status.Pass, "<div style= 'color:green; font-weight:bold'>Test_ClearData_Business PASSED");
                    }
                }
            }
        }
    }
}
