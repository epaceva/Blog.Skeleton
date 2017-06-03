using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.UI.Tests.Pages.HomePage
{
    public partial class HomePage
    {
        public IWebElement heading => Driver.FindElement(By.ClassName("navbar-brand"));
        public IWebElement registrationButton => Driver.FindElement(By.Id("registerLink"));

        public IWebElement LogoffLink => Driver.FindElement(By.XPath("//a[contains(text(),'Log off')]"));
        public IWebElement LoginLink => Driver.FindElement(By.Id("loginLink"));

        public IWebElement CreatePostLink => Driver.FindElement(By.XPath("//a[contains(text(),'Create')]"));
        public IWebElement EditPostLink => Driver.FindElement(By.LinkText("Test Post Creation"));
        public IWebElement DeletePostLink => Driver.FindElement(By.LinkText("Test Post Edit"));
    }
}
