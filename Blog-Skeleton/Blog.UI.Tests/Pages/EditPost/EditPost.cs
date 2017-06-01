using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using Blog.UI.Tests.Models;

namespace Blog.UI.Tests.Pages.EditPost
{
    public partial class EditPost : BasePage
    {

        private String url = "http://localhost:60634/Article/List";
        public EditPost(IWebDriver driver) : base(driver)
        {
        }

        public string URL
        {
            get
            {
                return base.url + "Article/List/";
            }
        }

        public void NavigateTo()
        {
            this.Driver.Navigate().GoToUrl(this.url);
        }

        public void FillEditPostForm(BlogPage user)
        {
            this.Title.Click();
            this.EditButton.Click();
            Type(this.TitleToEdit, user.Title);
            Type(this.ContentToEdit, user.Content);
            this.EditButtonPost.Click();
        }

        private void Type(IWebElement element, string text)
        {
            element.Click();
            element.Clear();
            element.SendKeys(text);
        }
    }
}
