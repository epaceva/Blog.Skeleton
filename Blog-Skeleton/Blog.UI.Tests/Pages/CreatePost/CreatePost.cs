using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using Blog.UI.Tests.Models;

namespace Blog.UI.Tests.Pages.CreatePost
{
    public partial class CreatePost : BasePage
    {
        private String url = "http://localhost:60634/Article/Create";

        public CreatePost(IWebDriver driver) : base(driver)
        {
        }

        public string URL
        {
            get
            {
                return base.url + "Article/Create/";
            }
        }

        public void NavigateTo()
        {
            this.Driver.Navigate().GoToUrl(this.url);
        }

        public void FillCreatePostForm(BlogPage user)
        {
            
            Type(this.Title, user.Title);
            Type(this.Content, user.Content);
            this.CreateButton.Click();
        }

        private void Type(IWebElement element, string text)
        {
            element.Clear();
            if (text == null)
            {
                text = String.Empty;
            }
            element.SendKeys(text);
        }
    }
}
