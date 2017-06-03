using Blog.UI.Tests.Models;
using Blog.UI.Tests.Pages.EditPost;
using Blog.UI.Tests.Pages.HomePage;
using Blog.UI.Tests.Pages.LoginPage;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.UI.Tests
{
    [TestFixture]
    public class UITestsEditPost
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

        [Test, Property("UI.Tests.2.EditPost", 1)]
        public void EditPostSuccessfuly()
        {

            HomePage homePage = new HomePage(this.driver);
            homePage.NavigateTo();

            LoginPage logPage = new LoginPage(this.driver);
            logPage.NavigateTo();
            var loginUser = AccessExcelData.GetTestDataLoging("LoginSuccessfully");
            logPage.FillLoginForm(loginUser);

            homePage.EditPostLink.Click();

            EditPost editPage = new EditPost(this.driver);
            var postUser = AccessExcelData.GetTestDataPosts("EditPostSuccessfuly");
            editPage.NavigateTo();
            editPage.FillEditPostForm(postUser);

            editPage.AssertSuccessfulPostEdit("Test Post Edit");
        }

        [Test, Property("UI.Tests.2.EditPost", 1)]
        public void WithoutTitlePostEdit()
        {

            HomePage homePage = new HomePage(this.driver);
            homePage.NavigateTo();

            LoginPage logPage = new LoginPage(this.driver);
            logPage.NavigateTo();
            var loginUser = AccessExcelData.GetTestDataLoging("LoginSuccessfully");
            logPage.FillLoginForm(loginUser);

            homePage.EditPostLink.Click();

            EditPost editPage = new EditPost(this.driver);
            var postUser = AccessExcelData.GetTestDataPosts("EditPostWithoutTitle");
            editPage.NavigateTo();
            editPage.FillEditPostForm(postUser);

            editPage.AssertErrorMessageForEmptyFieldsPostEdit("The Title field is required.");
        }

        [Test, Property("UI.Tests.2.EditPost", 1)]
        public void WithoutContentPostEdit()
        {

            HomePage homePage = new HomePage(this.driver);
            homePage.NavigateTo();

            LoginPage logPage = new LoginPage(this.driver);
            logPage.NavigateTo();
            var loginUser = AccessExcelData.GetTestDataLoging("LoginSuccessfully");
            logPage.FillLoginForm(loginUser);

            homePage.EditPostLink.Click();

            EditPost editPage = new EditPost(this.driver);
            var postUser = AccessExcelData.GetTestDataPosts("EditPostWithoutContent");
            editPage.NavigateTo();
            editPage.FillEditPostForm(postUser);

            editPage.AssertErrorMessageForEmptyFieldsPostEdit("The Content field is required.");
        }

        [Test, Property("UI.Tests.2.EditPost", 1)]
        public void CancleEditButtonFuntionality()
        {

            HomePage homePage = new HomePage(this.driver);
            homePage.NavigateTo();

            LoginPage logPage = new LoginPage(this.driver);
            logPage.NavigateTo();
            var loginUser = AccessExcelData.GetTestDataLoging("LoginSuccessfully");
            logPage.FillLoginForm(loginUser);

            homePage.EditPostLink.Click();

            EditPost editPage = new EditPost(this.driver);
            var postUser = AccessExcelData.GetTestDataPosts("CancelButtonEditPost").ToString();
            editPage.EditButton.Click();
            editPage.TitleToEdit.Clear();
            editPage.TitleToEdit.SendKeys(postUser);
            editPage.ContentToEdit.Clear();
            editPage.ContentToEdit.SendKeys(postUser);
            editPage.CancelButtonPost.Click();

            editPage.AssertPostEditCancelButton("Test Post Creation");
        }

        [Test, Property("UI.Tests.2.EditPost", 1)]
        public void DuplicatePostEdit()
        {

            HomePage homePage = new HomePage(this.driver);
            homePage.NavigateTo();

            LoginPage logPage = new LoginPage(this.driver);
            logPage.NavigateTo();
            var loginUser = AccessExcelData.GetTestDataLoging("LoginSuccessfully");
            logPage.FillLoginForm(loginUser);

            homePage.EditPostLink.Click();

            EditPost editPage = new EditPost(this.driver);
            var postUser = AccessExcelData.GetTestDataPosts("CreatePostSuccessfuly");
            editPage.NavigateTo();
            editPage.FillEditPostForm(postUser);

            editPage.AssertPostEditCancelButton("Test Post Creation");
        }

        [Test, Property("UI.Tests.2.EditPost", 1)]
        public void EditPostContentResize()
        {
            HomePage homePage = new HomePage(this.driver);
            homePage.NavigateTo();

            LoginPage logPage = new LoginPage(this.driver);
            logPage.NavigateTo();
            var loginUser = AccessExcelData.GetTestDataLoging("LoginSuccessfully");
            logPage.FillLoginForm(loginUser);

            homePage.EditPostLink.Click();

            EditPost editPage = new EditPost(this.driver);
            var postUser = AccessExcelData.GetTestDataPosts("EditPostSuccessfuly").ToString();
            editPage.EditButton.Click();
            editPage.TitleToEdit.Clear();
            editPage.TitleToEdit.SendKeys(postUser);

            Actions builder = new Actions(this.driver);
            var action = builder.MoveToElement(editPage.ContentToEdit)
                                .MoveByOffset((editPage.ContentToEdit.Size.Width / 2) - 2, (editPage.ContentToEdit.Size.Height / 2) - 2)
                                .ClickAndHold()
                                .MoveByOffset(300, 300)
                                .Release();

            action.Perform();
            editPage.AssertEditPageIsDisplayed("Edit Article");
            editPage.AssertComtentResizeField(300);
        }
    }
}
