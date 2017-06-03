using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using Blog.UI.Tests.Models;

namespace Blog.UI.Tests.Pages.DeletePost
{
    public partial class DeletePost : BasePage
    {
        private String url = "http://localhost:60634/Article/List";

        public DeletePost(IWebDriver driver) : base(driver)
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
    }
}
