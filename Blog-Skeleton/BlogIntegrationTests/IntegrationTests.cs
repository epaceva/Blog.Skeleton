using BlogIntegrationTests.Models;
using BlogIntegrationTests.Pages.HomePage;
using BlogIntegrationTests.Pages.RegistrationPage;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogIntegrationTests
{
    [TestFixture]
    public class IntegrationTests
    {
        private IWebDriver driver = BrowserHost.Instance.Application.Browser;

        [SetUp]
        public void Init()
        {
            this.driver = new ChromeDriver();
            this.driver.Manage().Window.Maximize();
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(100));
        }

        [Test]
        public void CheckSiteLoad()
        {
            IWebDriver driver = BrowserHost.Instance.Application.Browser;
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(100));

            var logo = wait.Until(w => w.FindElement(By.XPath("/html/body/div[1]/div/div[1]/a")));
            Assert.AreEqual("SOFTUNI BLOG", logo.Text);
        }

        [Test, Property("Priority", 1)]
        [Author("epaceva")]
        public void NavigateToRegistrationPage()
        {
            HomePage homePage = new HomePage(this.driver);

            homePage.NavigateTo();

            Assert.AreEqual("SOFTUNI BLOG", homePage.heading.Text);
        }

        [Test, Property("Priority", 2)]

        public void WithoutEmailRegistration()
        {
            RegistrationPage regPage = new RegistrationPage(this.driver);
            var user = AccessExcelData.GetTestData("RegisterWithoutEmail");

            regPage.NavigateTo();
            regPage.FillRegistrationForm(user);

            regPage.AssertMissingEmail("* The Email field is required");
        }

        //[Test, Property("Priority", 2)]
        //public void WithInvalidEmail()
        //{
        //    RegistrationPage regPage = new RegistrationPage(this.driver);
        //    var user = AccessExcelData.GetTestData("WithInvalidEmail");

        //    regPage.NavigateTo();
        //    regPage.FillRegistrationForm(user);

        //    regPage.AssertMailMsgExist("* Invalid email address");
        //}

        //[Test, Property("Priority", 2)]
        //public void WithInvalidEmailAtSignEnd()
        //{
        //    RegistrationPage regPage = new RegistrationPage(this.driver);
        //    var user = AccessExcelData.GetTestData("WithInvalidEmailAtSignEnd");

        //    regPage.NavigateTo();
        //    regPage.FillRegistrationForm(user);

        //    regPage.AssertMailMsgExist("* Invalid email address");
        //}

        //[Test, Property("Priority", 2)]
        //public void WithoutNames()
        //{
        //    RegistrationPage regPage = new RegistrationPage(this.driver);
        //    RegistrationUser user = AccessExcelData.GetTestData("WithoutNames");

        //    regPage.NavigateTo();
        //    regPage.FillRegistrationForm(user);

        //    regPage.AssertNamesMsgExist("* This field is required");
        //}

        //[Test, Property("Priority", 2)]
        //public void WithoutLastName()
        //{
        //    RegistrationPage regPage = new RegistrationPage(this.driver);
        //    RegistrationUser user = AccessExcelData.GetTestData("WithoutLastName");

        //    regPage.NavigateTo();
        //    regPage.FillRegistrationForm(user);

        //    regPage.AssertNamesMsgExist("* This field is required");
        //}

        //[Test, Property("Priority", 1)]
        //public void WithoutUsername()
        //{
        //    RegistrationPage regPage = new RegistrationPage(this.driver);
        //    RegistrationUser user = AccessExcelData.GetTestData("WithoutUsername");

        //    regPage.NavigateTo();
        //    regPage.FillRegistrationForm(user);

        //    regPage.AssertUsernameMsgExist("* This field is required");
        //}

        //[Test, Property("Priority", 2)]
        //public void WithoutPhone()
        //{
        //    RegistrationPage regPage = new RegistrationPage(this.driver);
        //    RegistrationUser user = AccessExcelData.GetTestData("WithoutPhone");

        //    regPage.NavigateTo();
        //    regPage.FillRegistrationForm(user);

        //    regPage.AssertPhoneMsgExist();
        //}

        //[Test, Property("Priority", 2)]
        //public void WithShortPhoneNumber()
        //{
        //    RegistrationPage regPage = new RegistrationPage(this.driver);
        //    RegistrationUser user = AccessExcelData.GetTestData("WithShortPhoneNumber");

        //    regPage.NavigateTo();
        //    regPage.FillRegistrationForm(user);

        //    regPage.AssertShortPhoneMsgExist("* Minimum 10 Digits starting with Country Code");
        //}

        //[Test, Property("Priority", 2)]
        //public void WithoutHobby()
        //{
        //    RegistrationPage regPage = new RegistrationPage(this.driver);
        //    RegistrationUser user = AccessExcelData.GetTestData("WithoutHobby");

        //    regPage.NavigateTo();
        //    regPage.FillRegistrationForm(user);

        //    regPage.AssertHobbyMsgExist();
        //}

        //[Test, Property("Priority", 1)]
        //public void WithoutPassword()
        //{
        //    RegistrationPage regPage = new RegistrationPage(this.driver);
        //    RegistrationUser user = AccessExcelData.GetTestData("WithoutPassword");

        //    regPage.NavigateTo();
        //    regPage.FillRegistrationForm(user);

        //    regPage.AssertPasswordMsgExist("* This field is required");
        //}

        //[Test, Property("Priority", 1)]
        //public void WithShortPassword()
        //{
        //    RegistrationPage regPage = new RegistrationPage(this.driver);
        //    RegistrationUser user = AccessExcelData.GetTestData("WithShortPassword");

        //    regPage.NavigateTo();
        //    regPage.FillRegistrationForm(user);

        //    regPage.AssertPasswordMsgExist("* Minimum 8 characters required");
        //}

        //[Test, Property("Priority", 1)]
        //public void WithoutConfirmPassword()
        //{
        //    RegistrationPage regPage = new RegistrationPage(this.driver);
        //    RegistrationUser user = AccessExcelData.GetTestData("WithoutConfirmPassword");

        //    regPage.NavigateTo();
        //    regPage.FillRegistrationForm(user);

        //    regPage.AssertConfirmPasswordMsgExist("* This field is required");
        //}

        //[Test, Property("Priority", 1)]
        //public void ConfirmPasswordNotMatch()
        //{
        //    RegistrationPage regPage = new RegistrationPage(this.driver);
        //    RegistrationUser user = AccessExcelData.GetTestData("ConfirmPasswordNotMatch");

        //    regPage.NavigateTo();
        //    regPage.FillRegistrationForm(user);

        //    regPage.AssertConfirmPasswordMsgExist("* Fields do not match");
        //}

        //[Test, Property("Priority", 2)]
        //public void WithInvalidImgPath()
        //{
        //    RegistrationPage regPage = new RegistrationPage(this.driver);
        //    RegistrationUser user = AccessExcelData.GetTestData("WithInvalidImgPath");

        //    regPage.NavigateTo();
        //    regPage.FillRegistrationForm(user);

        //    regPage.AssertInvalidImgPathMsgExist("* Invalid File");
        //}

        //[Test, Property("Priority", 2)]
        //public void WithVeryWeakPassword()
        //{
        //    RegistrationPage regPage = new RegistrationPage(this.driver);
        //    RegistrationUser user = AccessExcelData.GetTestData("WithVeryWeakPassword");

        //    regPage.NavigateTo();
        //    regPage.FillRegistrationForm(user);

        //    regPage.AssertPasswordQualityChecker("Very weak");
        //}

        //[Test, Property("Priority", 2)]
        //public void WithWeakPassword()
        //{
        //    RegistrationPage regPage = new RegistrationPage(this.driver);
        //    RegistrationUser user = AccessExcelData.GetTestData("WithWeakPassword");

        //    regPage.NavigateTo();
        //    regPage.FillRegistrationForm(user);

        //    regPage.AssertPasswordQualityChecker("Weak");
        //}

        //[Test, Property("Priority", 2)]
        //public void WithMediumPassword()
        //{
        //    RegistrationPage regPage = new RegistrationPage(this.driver);
        //    RegistrationUser user = AccessExcelData.GetTestData("WithMediumPassword");

        //    regPage.NavigateTo();
        //    regPage.FillRegistrationForm(user);

        //    regPage.AssertPasswordQualityChecker("Medium");
        //}

        //[Test, Property("Priority", 2)]
        //public void WithStrongPassword()
        //{
        //    RegistrationPage regPage = new RegistrationPage(this.driver);
        //    RegistrationUser user = AccessExcelData.GetTestData("WithStrongPassword");

        //    regPage.NavigateTo();
        //    regPage.FillRegistrationForm(user);

        //    regPage.AssertPasswordQualityChecker("Strong");
        //}

        //[Test, Property("Priority", 1)]
        //public void WithMismachPassword()
        //{
        //    RegistrationPage regPage = new RegistrationPage(this.driver);
        //    RegistrationUser user = AccessExcelData.GetTestData("WithMismachPassword");

        //    regPage.NavigateTo();
        //    regPage.FillRegistrationForm(user);

        //    regPage.AssertPasswordQualityChecker("Mismatch");
        //}

        //[TearDown]
        //public void CleanUp()
        //{
        //    if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
        //    {
        //        string filename = ConfigurationManager.AppSettings["Logs"] + TestContext.CurrentContext.Test.Name + ".txt";
        //        if (File.Exists(filename))
        //        {
        //            File.Delete(filename);
        //        }
        //        File.WriteAllText(filename, TestContext.CurrentContext.Test.FullName
        //            + "\n || " + TestContext.CurrentContext.TestDirectory
        //            + "\n || " + TestContext.CurrentContext.Result.PassCount);

        //        var screenshot = ((ITakesScreenshot)this.driver).GetScreenshot();
        //        screenshot.SaveAsFile(filename + TestContext.CurrentContext.Test.Name + ".jpg", ScreenshotImageFormat.Jpeg);
        //    }

        //    this.driver.Quit();
        //}
    }
}
