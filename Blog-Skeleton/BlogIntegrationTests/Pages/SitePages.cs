using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogIntegrationTests.Pages
{
    public partial class SitePages : BasePage
    {
        private String homeUrl = "http://localhost:60634/Article/List";
        private String registrationUrl = "http://localhost:60634/Account/Register";
        private String loginUrl = "http://localhost:60634/Account/Login";
        private String helloWorldUrl = "http://localhost:60634/Article/Details/1";
        private String proBlogUrl = "http://localhost:60634/Article/Details/2";
        private String blogUpdateUrl = "http://localhost:60634/Article/Details/3";

        public SitePages(IWebDriver driver) : base(driver)
        {
        }

        public void NavigateToHomePage()
        {
            this.Driver.Navigate().GoToUrl(this.homeUrl);
        }

        public void NavigateToRegistrationPage()
        {
            this.Driver.Navigate().GoToUrl(this.registrationUrl);
        }

        public void NavigateToLoginPage()
        {
            this.Driver.Navigate().GoToUrl(this.loginUrl);
        }

        public void NavigateToHelloWorldPage()
        {
            this.Driver.Navigate().GoToUrl(this.helloWorldUrl);
        }

        public void NavigateToProBlogPage()
        {
            this.Driver.Navigate().GoToUrl(this.proBlogUrl);
        }

        public void NavigateToBlogUpdatePage()
        {
            this.Driver.Navigate().GoToUrl(this.blogUpdateUrl);
        }
    }
}
