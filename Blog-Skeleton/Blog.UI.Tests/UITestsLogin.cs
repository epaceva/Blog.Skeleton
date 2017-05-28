using Blog.UI.Tests.Models;
using Blog.UI.Tests.Pages.LoginPage;
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
    public class UITestsLogin
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
        
        [Test, Property("UI.Tests.Login", 1)]
        public void SuccessfulLogin()
        {
            LoginPage logPage = new LoginPage(this.driver);
            var user = AccessExcelData.GetTestDataLoging("LoginSuccessfully");

            logPage.NavigateTo();
            logPage.FillLoginForm(user);

            logPage.AssertSuccessfulLogin("Hello evitta15@mail.bg!");
        }

        [Test, Property("UI.Tests.Login", 1)]
        public void WithoutEmailLogin()
        {
            LoginPage logPage = new LoginPage(this.driver);
            var user = AccessExcelData.GetTestDataLoging("LoginWithoutEmail");

            logPage.NavigateTo();
            logPage.FillLoginForm(user);

            logPage.AssertErrorMessageForEmptyEmailField("The Email field is required.");
        }

        [Test, Property("UI.Tests.Login", 1)]
        public void WithInvalidEmailLogin()
        {
            LoginPage logPage = new LoginPage(this.driver);
            var user = AccessExcelData.GetTestDataLoging("LoginWithInvalidEmail");

            logPage.NavigateTo();
            logPage.FillLoginForm(user);

            logPage.AssertErrorMessageForEmptyEmailField("The Email field is not a valid e-mail address.");
        }

        [Test, Property("UI.Tests.Login", 1)]
        public void WithoutPasswordLogin()
        {
            LoginPage logPage = new LoginPage(this.driver);
            var user = AccessExcelData.GetTestDataLoging("LoginWithoutPassword");

            logPage.NavigateTo();
            logPage.FillLoginForm(user);

            logPage.AssertErrorMessageForEmptyPasswordField("The Password field is required.");
        }

        [Test, Property("UI.Tests.Login", 1)]
        public void WithIncorrectPasswordLogin()
        {
            LoginPage logPage = new LoginPage(this.driver);
            var user = AccessExcelData.GetTestDataLoging("LoginWithIncorrectPassword");

            logPage.NavigateTo();
            logPage.FillLoginForm(user);

            logPage.AssertErrorMessageForIncorrectPassword("Invalid login attempt.");
        }
    }
}



