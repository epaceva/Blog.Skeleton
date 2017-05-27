using BlogIntegrationTests;
using BlogIntegrationTests.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Integration.Tests
{
    [TestFixture]
    public class IntegrationTestsNavigations
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

        [Test, Property("Integration.Navigation", 1)]
        public void NavigateToRegistrationPage()
        {
            SitePages homePage = new SitePages(this.driver);

            homePage.NavigateToHomePage();
            homePage.registrationButton.Click();

            Assert.AreEqual("Register", homePage.registrationHeading.Text);
        }

        [Test, Property("Integration.Navigation", 1)]
        public void NavigateToLoginPage()
        {
            SitePages homePage = new SitePages(this.driver);

            homePage.NavigateToHomePage();
            homePage.loginButton.Click();

            Assert.AreEqual("Log in", homePage.loginHeading.Text);
        }

        [Test, Property("Integration.Navigation", 1)]
        public void NavigateToHelloWorldPage()
        {
            SitePages homePage = new SitePages(this.driver);

            homePage.NavigateToHomePage();
            homePage.helloWorldButton.Click();

            Assert.AreEqual("Hello World", homePage.helloWorldHeading.Text);
        }

        [Test, Property("Integration.Navigation", 1)]
        public void NavigateToProBlogPage()
        {
            SitePages homePage = new SitePages(this.driver);

            homePage.NavigateToHomePage();
            homePage.proBlogButton.Click();

            Assert.AreEqual("Pro Blog", homePage.proBlogHeading.Text);
        }

        [Test, Property("Integration.Navigation", 1)]
        public void NavigateToBlogUpdatePage()
        {
            SitePages homePage = new SitePages(this.driver);

            homePage.NavigateToHomePage();
            homePage.blogUpdateButton.Click();

            Assert.AreEqual("Blog Update!", homePage.blogUpdateHeading.Text);
        }
    }
}
