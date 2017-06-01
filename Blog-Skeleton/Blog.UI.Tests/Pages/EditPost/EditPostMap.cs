using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.UI.Tests.Pages.EditPost
{
    public partial class EditPost
    {
        public IWebElement Title => Driver.FindElement(By.LinkText("Test Post Creation"));
        public IWebElement EditButton => Driver.FindElement(By.XPath("/html/body/div[2]/div/article/footer/a[1]"));
        public IWebElement TitleToEdit => Driver.FindElement(By.Id("Title"));
        public IWebElement ContentToEdit => Driver.FindElement(By.XPath("//*[@id=\"Content\"]"));
        public IWebElement EditButtonPost => Driver.FindElement(By.XPath("/html/body/div[2]/div/div/form/div[4]/div/input"));
        public IWebElement CancelButtonPost => Driver.FindElement(By.XPath("/html/body/div[2]/div/div/form/div[4]/div/a"));

        public IWebElement SuccessfulPostEdit
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.LinkText("Test Post Edit")));
                return this.Driver.FindElement(By.LinkText("Test Post Edit"));
            }
        }

        public IWebElement ErrorMessageEmptyFieldPostEdit
        {
            get
            {
                // /html/body/div[2]/div/div/form/div[1]/ul/li
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath("/html/body/div[2]/div/div/form/div[1]/ul/li")));
                return this.Driver.FindElement(By.XPath("/html/body/div[2]/div/div/form/div[1]/ul/li"));
            }
        }

        public IWebElement PostEditCancelButton
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.LinkText("Test Post Creation")));
                return this.Driver.FindElement(By.LinkText("Test Post Creation"));
            }
        }

        public IWebElement EditPostText
        {
            get
            {
                return this.Driver.FindElement(By.XPath("/html/body/div[2]/div/div/h2"));
            }
        }
    }
}
