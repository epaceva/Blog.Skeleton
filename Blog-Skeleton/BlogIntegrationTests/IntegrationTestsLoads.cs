using BlogIntegrationTests;
using BlogIntegrationTests.Pages;
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

namespace Blog.Integration.Tests
{
    [TestFixture]
    public class IntegrationTestsLoads
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

        [Test, Property("Integration.Load", 1)]
        public void CheckSiteLoad()
        {
            SitePages homePage = new SitePages(this.driver);

            homePage.NavigateToHomePage();

            Assert.AreEqual("SOFTUNI BLOG", homePage.heading.Text);
        }

        [Test, Property("Integration.Load", 1)]
        public void LoadRegistrationPage()
        {
            SitePages homePage = new SitePages(this.driver);

            homePage.NavigateToRegistrationPage();

            Assert.AreEqual("Register", homePage.registrationHeading.Text);
        }

        [Test, Property("Integration.Load", 1)]
        public void LoadLoginPage()
        {
            SitePages homePage = new SitePages(this.driver);

            homePage.NavigateToLoginPage();

            Assert.AreEqual("Log in", homePage.loginHeading.Text);
        }

        [Test, Property("Integration.Load", 1)]
        public void LoadHelloWorldPage()
        {
            SitePages homePage = new SitePages(this.driver);

            homePage.NavigateToHelloWorldPage();

            Assert.AreEqual("Hello World", homePage.helloWorldHeading.Text);
        }

        [Test, Property("Integration.Load", 1)]
        public void LoadProBlogPage()
        {
            SitePages homePage = new SitePages(this.driver);

            homePage.NavigateToProBlogPage();

            Assert.AreEqual("Pro Blog", homePage.proBlogHeading.Text);
        }

        [Test, Property("Integration.Load", 1)]
        public void LoadBlogUpdatePage()
        {
            SitePages homePage = new SitePages(this.driver);

            homePage.NavigateToBlogUpdatePage();

            Assert.AreEqual("Blog Update!", homePage.blogUpdateHeading.Text);
        }
    }
}
