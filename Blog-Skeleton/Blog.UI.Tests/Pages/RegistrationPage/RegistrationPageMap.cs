using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Blog.UI.Tests.Pages.RegistrationPage
{
    public partial class RegistrationPage
    {
        public IWebElement Email => this.Driver.FindElement(By.XPath("//*[@id=\"Email\"]"));
        public IWebElement FullName => Driver.FindElement(By.XPath("//*[@id=\"FullName\"]"));
        public IWebElement Password => this.Driver.FindElement(By.XPath("//*[@id=\"Password\"]"));
        public IWebElement ConfirmPassword => this.Driver.FindElement(By.XPath("//*[@id=\"ConfirmPassword\"]"));
        public IWebElement RegisterButton => this.Driver.FindElement(By.XPath("/html/body/div[2]/div/div/form/div[6]/div/input"));

        public IWebElement ErrorMessageForEmptyFieldOrMissmatch
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
