﻿using BlogIntegrationTests.Models;
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

        [TearDown]
        public void CleanUp()
        {
            this.driver.Quit();
        }

        [Test, Property("Integration", 1)]
        public void WithoutEmailRegistration()
        {
            RegistrationPage regPage = new RegistrationPage(this.driver);
            var user = AccessExcelData.GetTestData("RegisterWithoutEmail");

            regPage.NavigateTo();
            regPage.FillRegistrationForm(user);

            regPage.AssertErrorMessage("The Email field is required.");
        }

        [Test, Property("Integration", 1)]
        public void WithInvalidEmailRegistration()
        {
            RegistrationPage regPage = new RegistrationPage(this.driver);
            var user = AccessExcelData.GetTestData("RegisterWithInvalidEmail");

            regPage.NavigateTo();
            regPage.FillRegistrationForm(user);

            regPage.AssertErrorMessage("The Email field is not a valid e-mail address.");
        }

        [Test, Property("Integration", 1)]
        public void WithMissingFullNameRegistration()
        {
            RegistrationPage regPage = new RegistrationPage(this.driver);
            var user = AccessExcelData.GetTestData("RegisterWithoutFullName");

            regPage.NavigateTo();
            regPage.FillRegistrationForm(user);

            regPage.AssertErrorMessage("The Full Name field is required.");
        }

        [Test, Property("Integration", 1)]
        public void WithoutPasswordRegistration()
        {
            RegistrationPage regPage = new RegistrationPage(this.driver);
            RegistrationUser user = AccessExcelData.GetTestData("RegisterWithoutPassword");

            regPage.NavigateTo();
            regPage.FillRegistrationForm(user);

            regPage.AssertErrorMessage("The Password field is required.");
        }

        [Test, Property("Integration", 1)]
        public void WithPasswordMismatchRegistration()
        {
            RegistrationPage regPage = new RegistrationPage(this.driver);
            RegistrationUser user = AccessExcelData.GetTestData("RegisterWithPasswordMismatch");

            regPage.NavigateTo();
            regPage.FillRegistrationForm(user);

            regPage.AssertErrorMessage("The password and confirmation password do not match.");
        }
    }
}
