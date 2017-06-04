using Blog.UI.Tests.Pages.CreatePost;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blog.UI.Tests.Models;
using Blog.UI.Tests.Pages.HomePage;
using Blog.UI.Tests.Pages.LoginPage;
using System.Reflection;
using OpenQA.Selenium.Interactions;

namespace Blog.UI.Tests
{
    [TestFixture]
    public class UITestsCreatePost
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

        [Test, Property("UI.Tests.1.CreatePost", 1)]
        public void CreatePostSuccessfuly()
        {
            
            HomePage homePage = new HomePage(this.driver);
            homePage.NavigateTo();

            LoginPage logPage = new LoginPage(this.driver);
            logPage.NavigateTo();
            var loginUser = AccessExcelData.GetTestDataLoging("LoginSuccessfully");
            logPage.FillLoginForm(loginUser);

            homePage.CreatePostLink.Click();

            CreatePost createPage = new CreatePost(this.driver);
            var postUser = AccessExcelData.GetTestDataPosts("CreatePostSuccessfuly");
            createPage.NavigateTo();
            createPage.FillCreatePostForm(postUser);

            createPage.AssertSuccessfulPostCreation("Test Post Creation");
        }

        [Test, Property("UI.Tests.1.CreatePost", 1)]
        public void WithoutTitlePostCreation()
        {

            HomePage homePage = new HomePage(this.driver);
            homePage.NavigateTo();

            LoginPage logPage = new LoginPage(this.driver);
            logPage.NavigateTo();
            var loginUser = AccessExcelData.GetTestDataLoging("LoginSuccessfully");
            logPage.FillLoginForm(loginUser);

            homePage.CreatePostLink.Click();

            CreatePost createPage = new CreatePost(this.driver);
            var postUser = AccessExcelData.GetTestDataPosts("CreatePostWithoutTitle");
            createPage.NavigateTo();
            createPage.FillCreatePostForm(postUser);

            createPage.AssertErrorMessageForEmptyFields("The Title field is required.");
        }

        [Test, Property("UI.Tests.1.CreatePost", 1)]
        public void WithoutContentPostCreation()
        {

            HomePage homePage = new HomePage(this.driver);
            homePage.NavigateTo();

            LoginPage logPage = new LoginPage(this.driver);
            logPage.NavigateTo();
            var loginUser = AccessExcelData.GetTestDataLoging("LoginSuccessfully");
            logPage.FillLoginForm(loginUser);

            homePage.CreatePostLink.Click();

            CreatePost createPage = new CreatePost(this.driver);
            var postUser = AccessExcelData.GetTestDataPosts("CreatePostWithoutContent");
            createPage.NavigateTo();
            createPage.FillCreatePostForm(postUser);

            createPage.AssertErrorMessageForEmptyFields("The Content field is required.");
        }

        [Test, Property("UI.Tests.1.CreatePost", 1)]
        public void CancleButtonFuntionality()
        {

            HomePage homePage = new HomePage(this.driver);
            homePage.NavigateTo();

            LoginPage logPage = new LoginPage(this.driver);
            logPage.NavigateTo();
            var loginUser = AccessExcelData.GetTestDataLoging("LoginSuccessfully");
            logPage.FillLoginForm(loginUser);

            homePage.CreatePostLink.Click();

            CreatePost createPage = new CreatePost(this.driver);
            var postUser = AccessExcelData.GetTestDataPosts("CancelButtonTestData").ToString();
            createPage.NavigateTo();
            createPage.Title.SendKeys(postUser);
            createPage.Content.SendKeys(postUser);
            createPage.CancelButton.Click();

            createPage.AssertPostCreationCancelButton("Test Post");
        }

        [Test, Property("UI.Tests.1.CreatePost", 1)]
        public void DuplicatePostCreation()
        {

            HomePage homePage = new HomePage(this.driver);
            homePage.NavigateTo();

            LoginPage logPage = new LoginPage(this.driver);
            logPage.NavigateTo();
            var loginUser = AccessExcelData.GetTestDataLoging("LoginSuccessfully");
            logPage.FillLoginForm(loginUser);

            homePage.CreatePostLink.Click();

            CreatePost createPage = new CreatePost(this.driver);
            var postUser = AccessExcelData.GetTestDataPosts("CreatePostSuccessfuly");
            createPage.NavigateTo();
            createPage.FillCreatePostForm(postUser);

            createPage.AssertPostCreationCancelButton("Test Post Creation");
        }

        [Test, Property("UI.Tests.1.CreatePost", 1)]
        public void CreatePostContentResize()
        {
            HomePage homePage = new HomePage(this.driver);
            homePage.NavigateTo();

            LoginPage logPage = new LoginPage(this.driver);
            logPage.NavigateTo();
            var loginUser = AccessExcelData.GetTestDataLoging("LoginSuccessfully");
            logPage.FillLoginForm(loginUser);

            homePage.CreatePostLink.Click();

            CreatePost createPage = new CreatePost(this.driver);
            var postUser = AccessExcelData.GetTestDataPosts("CreatePostSuccessfuly");
            createPage.NavigateTo();

            Actions builder = new Actions(this.driver);
            var action = builder.MoveToElement(createPage.Content)
                                .MoveByOffset((createPage.Content.Size.Width / 2) - 2, (createPage.Content.Size.Height / 2) - 2)
                                .ClickAndHold()
                                .MoveByOffset(300, 300)
                                .Release();

            action.Perform();
            createPage.AssertCreatePageIsDisplayed("Create Article");
            createPage.AssertComtentResizeField(300);
        }
    }
}
