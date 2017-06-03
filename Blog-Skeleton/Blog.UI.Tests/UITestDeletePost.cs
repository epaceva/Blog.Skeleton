using Blog.UI.Tests.Models;
using Blog.UI.Tests.Pages.DeletePost;
using Blog.UI.Tests.Pages.HomePage;
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
    public class UITestDeletePost
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

        [Test, Property("UI.Tests.3.DeletePost", 1)]
        public void CancelDeleteButtonFuntionality()
        {

            HomePage homePage = new HomePage(this.driver);
            homePage.NavigateTo();

            LoginPage logPage = new LoginPage(this.driver);
            logPage.NavigateTo();
            var loginUser = AccessExcelData.GetTestDataLoging("LoginSuccessfully");
            logPage.FillLoginForm(loginUser);

            homePage.DeletePostLink.Click();

            DeletePost deletePost = new DeletePost(this.driver);
            deletePost.NavigateTo();
            deletePost.Title.Click();
            deletePost.DeleteButton.Click();
            deletePost.CancelButtonPost.Click();

            deletePost.AssertPostDeleteCancelButton("Test Post Creation");
        }

        [Test, Property("UI.Tests.3.DeletePost", 1)]
        public void DeletePostSuccessfuly()
        {

            HomePage homePage = new HomePage(this.driver);
            homePage.NavigateTo();

            LoginPage logPage = new LoginPage(this.driver);
            logPage.NavigateTo();
            var loginUser = AccessExcelData.GetTestDataLoging("LoginSuccessfully");
            logPage.FillLoginForm(loginUser);

            homePage.DeletePostLink.Click();

            DeletePost deletePost = new DeletePost(this.driver);
            deletePost.NavigateTo();
            deletePost.Title.Click();
            deletePost.DeleteButton.Click();
            deletePost.DeleteButtonPost.Click();

            deletePost.AssertSuccessfulPostDelete("Test Post Edit");
        }

        [Test, Property("UI.Tests.3.DeletePost", 1)]
        public void DeleteForeignPost()
        {

            HomePage homePage = new HomePage(this.driver);
            homePage.NavigateTo();

            LoginPage logPage = new LoginPage(this.driver);
            logPage.NavigateTo();
            var loginUser = AccessExcelData.GetTestDataLoging("LoginForeinUserData");
            logPage.FillLoginForm(loginUser);

            homePage.DeletePostLink.Click();

            DeletePost deletePost = new DeletePost(this.driver);
            deletePost.NavigateTo();
            deletePost.Title.Click();
            deletePost.DeleteButton.Click();

            deletePost.AssertEditForeignPostErrorMessageIsDisplayed("You do not have permission to view this directory or page");
        }
    }
}
