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
            LoginPage regPage = new LoginPage(this.driver);
            var user = AccessExcelData.GetTestDataLoging("LoginSuccessfully");

            regPage.NavigateTo();
            regPage.FillLoginForm(user);

            regPage.AssertSuccessfulLogin("Hello evitta15@mail.bg!");
        }

        [Test, Property("UI.Tests.Login", 1)]
        public void WithoutEmailLogin()
        {
            LoginPage regPage = new LoginPage(this.driver);
            var user = AccessExcelData.GetTestDataLoging("LoginWithoutEmail");

            regPage.NavigateTo();
            regPage.FillLoginForm(user);

            regPage.AssertErrorMessageForEmptyEmailField("The Email field is required.");
        }

        [Test, Property("UI.Tests.Login", 1)]
        public void WithInvalidEmailLogin()
        {
            LoginPage regPage = new LoginPage(this.driver);
            var user = AccessExcelData.GetTestDataLoging("LoginWithInvalidEmail");

            regPage.NavigateTo();
            regPage.FillLoginForm(user);

            regPage.AssertErrorMessageForEmptyEmailField("The Email field is not a valid e-mail address.");
        }

        [Test, Property("UI.Tests.Login", 1)]
        public void WithoutPasswordLogin()
        {
            LoginPage regPage = new LoginPage(this.driver);
            var user = AccessExcelData.GetTestDataLoging("LoginWithoutPassword");

            regPage.NavigateTo();
            regPage.FillLoginForm(user);

            regPage.AssertErrorMessageForEmptyPasswordField("The Password field is required.");
        }

        [Test, Property("UI.Tests.Login", 1)]
        public void WithIncorrectPasswordLogin()
        {
            LoginPage regPage = new LoginPage(this.driver);
            var user = AccessExcelData.GetTestDataLoging("LoginWithIncorrectPassword");

            regPage.NavigateTo();
            regPage.FillLoginForm(user);

            regPage.AssertErrorMessageForIncorrectPassword("Invalid login attempt.");
        }
    }
}



