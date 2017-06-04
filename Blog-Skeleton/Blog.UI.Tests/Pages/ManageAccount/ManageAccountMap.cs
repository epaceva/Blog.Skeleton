using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.UI.Tests.Pages.ManageAccount
{
    public partial class ManageAccount
    {
        public IWebElement ChangePassword => this.Driver.FindElement(By.XPath("/html/body/div[2]/div/dl/dd/a"));
        public IWebElement CurrentPassword => this.Driver.FindElement(By.Id("OldPassword"));
        public IWebElement NewPassword => this.Driver.FindElement(By.Id("NewPassword"));
        public IWebElement ConfirmNewPassword => this.Driver.FindElement(By.Id("ConfirmPassword"));
        public IWebElement ChangePasswordButton => this.Driver.FindElement(By.XPath("/html/body/div[2]/div/div/form/div[5]/div/input"));

        public IWebElement SuccessfulPasswordChange
        {
            get
            {
                // /html/body/div[2]/p
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath("/html/body/div[2]/p")));
                return this.Driver.FindElement(By.XPath("/html/body/div[2]/p"));
            }
        }

        public IWebElement ErrorMessageIncorrectPasswordChange
        {
            get
            {
                // /html/body/div[2]/div/div/form/div[1]/ul/li
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath("/html/body/div[2]/div/div/form/div[1]/ul/li")));
                return this.Driver.FindElement(By.XPath("/html/body/div[2]/div/div/form/div[1]/ul/li"));
            }
        }
    }
}
