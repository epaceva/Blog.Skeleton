using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.UI.Tests.Pages.CreatePost
{
    public partial class CreatePost
    {
        public IWebElement Title => Driver.FindElement(By.Id("Title"));
        public IWebElement Content => Driver.FindElement(By.Id("Content"));
        public IWebElement CreateButton => Driver.FindElement(By.XPath("/html/body/div[2]/div/div/form/div[4]/div/input"));
        public IWebElement CancelButton => Driver.FindElement(By.XPath("/html/body/div[2]/div/div/form/div[4]/div/a"));

        public IWebElement SuccessfulPostCreation
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.LinkText("Test Post Creation")));
                return this.Driver.FindElement(By.LinkText("Test Post Creation"));
            }
        }

        public IWebElement ErrorMessageEmptyField
        {
            get
            {
                // /html/body/div[2]/div/div/form/div[1]/ul/li
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath("/html/body/div[2]/div/div/form/div[1]/ul/li")));
                return this.Driver.FindElement(By.XPath("/html/body/div[2]/div/div/form/div[1]/ul/li"));
            }
        }

        public IWebElement PostCreationCancelButton
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.LinkText("Hello World")));
                return this.Driver.FindElement(By.LinkText("Hello World"));
            }
        }

        public IWebElement CreatePostText
        {
            get
            {
                return this.Driver.FindElement(By.XPath("/html/body/div[2]/div/div/h2"));
            }
        }
    }
}
