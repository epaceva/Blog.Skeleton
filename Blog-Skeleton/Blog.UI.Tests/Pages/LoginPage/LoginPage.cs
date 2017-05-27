using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using Blog.UI.Tests.Models;

namespace Blog.UI.Tests.Pages.LoginPage
{
    public partial class LoginPage : BasePage
    {
        private String url = "http://localhost:60634/Account/Login";

        public LoginPage(IWebDriver driver) : base(driver)
        {
        }

        public void NavigateTo()
        {
            this.Driver.Navigate().GoToUrl(this.url);
        }

        public void FillLoginForm(LoginUser user)
        {
            Type(this.Email, user.Email);
            Type(this.Password, user.Password);
            this.RememberMe.Click();
            this.LoginButton.Click();
        }

        private void Type(IWebElement element, string text)
        {
            element.Clear();
            element.SendKeys(text);
        }
    }
}
