using Blog.UI.Tests.Models;
using Blog.UI.Tests.Pages.LoginPage;
using Blog.UI.Tests.Pages.ManageAccount;
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
    public class UITestsManageAccount
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

        [Test, Property("UI.Tests.ManageAccount", 1)]
        public void SuccessfulPasswordChange()
        {
            LoginPage logPage = new LoginPage(this.driver);
            var userLogin = AccessExcelData.GetTestDataLoging("LoginForeinUserData");

            logPage.NavigateTo();
            logPage.FillLoginForm(userLogin);

            ManageAccount manage = new ManageAccount(this.driver);
            var userPassword = AccessExcelData.GetTestDataManage("ChangePasswordSuccessfully");

            manage.NavigateTo();

            manage.FillChangePassworForm(userPassword);
            manage.AssertSuccessfulPasswordChange("Your password has been changed.");
        }

        [Test, Property("UI.Tests.ManageAccount", 1)]
        public void EmptyFieldCurrentPasswordChange()
        {
            LoginPage logPage = new LoginPage(this.driver);
            var userLogin = AccessExcelData.GetTestDataLoging("LoginForeinUserData");

            logPage.NavigateTo();
            logPage.FillLoginForm(userLogin);

            ManageAccount manage = new ManageAccount(this.driver);
            var user = AccessExcelData.GetTestDataManage("ChangePasswordEmptryCurrentPassword");

            manage.NavigateTo();

            manage.FillChangePassworForm(user);
            manage.AssertErrorMessageForEmptyEmailField("The Current password field is required.");
        }

        [Test, Property("UI.Tests.ManageAccount", 1)]
        public void IncorrectCurrentPasswordChange()
        {
            LoginPage logPage = new LoginPage(this.driver);
            var userLogin = AccessExcelData.GetTestDataLoging("LoginForeinUserData");

            logPage.NavigateTo();
            logPage.FillLoginForm(userLogin);

            ManageAccount manage = new ManageAccount(this.driver);
            var user = AccessExcelData.GetTestDataManage("ChangePasswordIncorrectCurrentPassword");

            manage.NavigateTo();

            manage.FillChangePassworForm(user);
            manage.AssertErrorMessageForEmptyEmailField("Incorrect password.");
        }

        [Test, Property("UI.Tests.ManageAccount", 1)]
        public void EmptyFieldNewPasswordChange()
        {
            LoginPage logPage = new LoginPage(this.driver);
            var userLogin = AccessExcelData.GetTestDataLoging("LoginForeinUserData");

            logPage.NavigateTo();
            logPage.FillLoginForm(userLogin);

            ManageAccount manage = new ManageAccount(this.driver);
            var user = AccessExcelData.GetTestDataManage("ChangePasswordEmptryNewPassword");

            manage.NavigateTo();

            manage.FillChangePassworForm(user);
            manage.AssertErrorMessageForEmptyEmailField("The New password field is required.");
        }

        [Test, Property("UI.Tests.ManageAccount", 1)]
        public void PasswordMismatchChange()
        {
            LoginPage logPage = new LoginPage(this.driver);
            var userLogin = AccessExcelData.GetTestDataLoging("LoginForeinUserData");

            logPage.NavigateTo();
            logPage.FillLoginForm(userLogin);

            ManageAccount manage = new ManageAccount(this.driver);
            var user = AccessExcelData.GetTestDataManage("ChangePasswordMismatchNewPasswordAndConfirmPassword");

            manage.NavigateTo();

            manage.FillChangePassworForm(user);
            manage.AssertErrorMessageForEmptyEmailField("The new password and confirmation password do not match.");
        }
    }
}
