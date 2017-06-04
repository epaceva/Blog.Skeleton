using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using Blog.UI.Tests.Models;

namespace Blog.UI.Tests.Pages.ManageAccount
{
    public partial class ManageAccount : BasePage
    {
        private String url = "http://localhost:60634/Manage";

        public ManageAccount(IWebDriver driver) : base(driver)
        {
        }

        public void NavigateTo()
        {
            this.Driver.Navigate().GoToUrl(this.url);
        }

        public void FillChangePassworForm(ManageUser user)
        {
            this.ChangePassword.Click();
            Type(this.CurrentPassword, user.CurrentPassword);
            Type(this.NewPassword, user.NewPassword);
            Type(this.ConfirmNewPassword, user.ConfirmNewPassword);
            this.ChangePasswordButton.Click();
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
