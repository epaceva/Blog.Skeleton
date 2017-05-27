using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Blog.UI.Tests.Pages.LoginPage
{
    public partial class LoginPage
    {
        public IWebElement Email => this.Driver.FindElement(By.XPath("//*[@id=\"Email\"]"));
        public IWebElement Password => this.Driver.FindElement(By.XPath("//*[@id=\"Password\"]"));
        public IWebElement RememberMe => this.Driver.FindElement(By.XPath("//*[@id=\"RememberMe\"]"));
        public IWebElement LoginButton => this.Driver.FindElement(By.ClassName("btn-default"));

        public IWebElement SuccessfulLogin
        {
            get
            {
                // //*[@id="logoutForm"]/ul/li[2]/a
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath("//*[@id=\"logoutForm\"]/ul/li[2]/a")));
                return this.Driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li[2]/a"));
            }
        }

        public IWebElement ErrorMessageEmptyEmailField
        {
            get
            {
                // /html/body/div[2]/div/div/form/div[1]/div/span/span
                // /html/body/div[2]/div/div/form/div[1]/div/span/span
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath("/html/body/div[2]/div/div/form/div[1]/div/span/span")));
                return this.Driver.FindElement(By.XPath("/html/body/div[2]/div/div/form/div[1]/div/span/span"));
            }
        }

        public IWebElement ErrorMessageForEmptyPasswordField
        {
            get
            {
                // /html/body/div[2]/div/div/form/div[1]/div/span/span
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath("/html/body/div[2]/div/div/form/div[2]/div/span/span")));
                return this.Driver.FindElement(By.XPath("/html/body/div[2]/div/div/form/div[2]/div/span/span"));
            }
        }

        public IWebElement ErrorMessageForIncorrectPassword
        {
            get
            {
                // /html/body/div[2]/div/div/form/div[1]/ul/li
                // /html/body/div[2]/div/div/form/div[1]/ul/li
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath("/html/body/div[2]/div/div/form/div[1]/ul/li")));
                return this.Driver.FindElement(By.XPath("/html/body/div[2]/div/div/form/div[1]/ul/li"));
            }
        }
    }
}

