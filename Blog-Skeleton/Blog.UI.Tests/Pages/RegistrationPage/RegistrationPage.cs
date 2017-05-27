using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using Blog.UI.Tests.Models;

namespace Blog.UI.Tests.Pages.RegistrationPage
{
    public partial class RegistrationPage : BasePage
    {
        private String url = "http://localhost:60634/Account/Register";

        public RegistrationPage(IWebDriver driver) : base(driver)
        {
        }

        public void NavigateTo()
        {
            this.Driver.Navigate().GoToUrl(this.url);
        }

        public void FillRegistrationForm(RegistrationUser user)
        {
            Type(this.Email, user.Email);
            Type(this.FullName, user.FullName);
            Type(this.Password, user.Password);
            Type(this.ConfirmPassword, user.ConfirmPassword);
            this.RegisterButton.Click();
        }

        private void Type(IWebElement element, string text)
        {
            element.Clear();
            element.SendKeys(text);
        }
    }
}
