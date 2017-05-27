using Blog.UI.Tests.Models;
using Blog.UI.Tests.Pages.RegistrationPage;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.UI.Tests
{
    [TestFixture]
    public class UITestsRegistration
    {
        private IWebDriver driver = BrowserHost.Instance.Application.Browser;

        [SetUp]
        public void Init()
        {
            this.driver = new ChromeDriver();
            this.driver.Manage().Window.Maximize();
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(100));
        }

        [TearDown]
        public void CleanUp()
        {
            this.driver.Quit();
        }

        [Test, Property("UI.Tests.Registration", 1)]
        public void WithoutEmailRegistration()
        {
            RegistrationPage regPage = new RegistrationPage(this.driver);
            var user = AccessExcelData.GetTestDataRegistration("RegisterWithoutEmail");

            regPage.NavigateTo();
            regPage.FillRegistrationForm(user);

            regPage.AssertErrorMessage("The Email field is required.");
        }

        [Test, Property("UI.Tests.Registration", 1)]
        public void WithInvalidEmailRegistration()
        {
            RegistrationPage regPage = new RegistrationPage(this.driver);
            var user = AccessExcelData.GetTestDataRegistration("RegisterWithInvalidEmail");

            regPage.NavigateTo();
            regPage.FillRegistrationForm(user);

            regPage.AssertErrorMessage("The Email field is not a valid e-mail address.");
        }

        [Test, Property("UI.Tests.Registration", 1)]
        public void WithMissingFullNameRegistration()
        {
            RegistrationPage regPage = new RegistrationPage(this.driver);
            var user = AccessExcelData.GetTestDataRegistration("RegisterWithoutFullName");

            regPage.NavigateTo();
            regPage.FillRegistrationForm(user);

            regPage.AssertErrorMessage("The Full Name field is required.");
        }

        [Test, Property("UI.Tests.Registration", 1)]
        public void WithoutPasswordRegistration()
        {
            RegistrationPage regPage = new RegistrationPage(this.driver);
            RegistrationUser user = AccessExcelData.GetTestDataRegistration("RegisterWithoutPassword");

            regPage.NavigateTo();
            regPage.FillRegistrationForm(user);

            regPage.AssertErrorMessage("The Password field is required.");
        }

        [Test, Property("UI.Tests.Registration", 1)]
        public void WithPasswordMismatchRegistration()
        {
            RegistrationPage regPage = new RegistrationPage(this.driver);
            RegistrationUser user = AccessExcelData.GetTestDataRegistration("RegisterWithPasswordMismatch");

            regPage.NavigateTo();
            regPage.FillRegistrationForm(user);

            regPage.AssertErrorMessage("The password and confirmation password do not match.");
        }
    }
}



