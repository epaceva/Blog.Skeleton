using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogIntegrationTests.Pages.RegistrationPage
{
    public partial class RegistrationPage
    {
        public IWebElement Email => this.Driver.FindElement(By.XPath("//*[@id=\"Email\"]"));
        public IWebElement FullName => Driver.FindElement(By.XPath("//*[@id=\"FullName\"]"));
        public IWebElement Password => this.Driver.FindElement(By.XPath("//*[@id=\"Password\"]"));
        public IWebElement ConfirmPassword => this.Driver.FindElement(By.XPath("//*[@id=\"ConfirmPassword\"]"));
        public IWebElement RegisterButton => this.Driver.FindElement(By.ClassName("btn btn-default"));

        public IWebElement ErrorMessagesForRequiredFields
        {
            get
            {
                // /html/body/div[2]/div/div/form/div[1]/ul/li
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath("/html/body/div[2]/div/div/form/div[1]/ul/li")));
                return this.Driver.FindElement(By.XPath("/html/body/div[2]/div/div/form/div[1]/ul/li"));
            }
        }

        public IWebElement ErrorMessageForEmail
        {
            get
            {
                // /html/body/div[2]/div/div/form/div[1]/ul/li
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath("/html/body/div[2]/div/div/form/div[1]/ul/li")));
                return this.Driver.FindElement(By.XPath("/html/body/div[2]/div/div/form/div[1]/ul/li"));
            }
        }

        public IWebElement ErrorMessageForInvalidEmail
        {
            get
            {
                // /html/body/div[2]/div/div/form/div[1]/ul/li[1]
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath("/html/body/div[2]/div/div/form/div[1]/ul/li[1]")));
                return this.Driver.FindElement(By.XPath("/html/body/div[2]/div/div/form/div[1]/ul/li[1]"));
            }
        }

        public IWebElement ErrorMessageForFullName
        {
            get
            {
                // /html/body/div[2]/div/div/form/div[1]/ul/li[2]
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath("/html/body/div[2]/div/div/form/div[1]/ul/li[2]")));
                return this.Driver.FindElement(By.XPath("/html/body/div[2]/div/div/form/div[1]/ul/li[2]"));
            }
        }

        public IWebElement ErrorMessagesForPassword
        {
            get
            {
                // //html/body/div[2]/div/div/form/div[1]/ul/li[1]
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath("/html/body/div[2]/div/div/form/div[1]/ul/li[1]")));
                return this.Driver.FindElement(By.XPath("/html/body/div[2]/div/div/form/div[1]/ul/li[1]"));
            }
        }

        public IWebElement ErrorMessagesForPasswordMismatch
        {
            get
            {
                // /html/body/div[2]/div/div/form/div[1]/ul/li[3]
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath("/html/body/div[2]/div/div/form/div[1]/ul/li[3]")));
                return this.Driver.FindElement(By.XPath("/html/body/div[2]/div/div/form/div[1]/ul/li[3]"));
            }
        }
    }
}
