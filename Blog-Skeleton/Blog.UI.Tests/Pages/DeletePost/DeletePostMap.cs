using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.UI.Tests.Pages.DeletePost
{
    public partial class DeletePost
    {
        public IWebElement Title => Driver.FindElement(By.LinkText("Test Post Edit"));
        public IWebElement DeleteButton => Driver.FindElement(By.XPath("/html/body/div[2]/div/article/footer/a[2]"));
        public IWebElement DeleteButtonPost => Driver.FindElement(By.XPath("/html/body/div[2]/div/div/form/div[3]/div/input"));
        public IWebElement CancelButtonPost => Driver.FindElement(By.XPath("/html/body/div[2]/div/div/form/div[3]/div/a"));

        public IWebElement SuccessfulPostDelete
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.LinkText("Hello World")));
                return this.Driver.FindElement(By.LinkText("Hello World"));
            }
        }

        public IWebElement PostDeleteCancelButton
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.LinkText("Test Post Creation")));
                return this.Driver.FindElement(By.LinkText("Test Post Creation"));
            }
        }
    }
}
