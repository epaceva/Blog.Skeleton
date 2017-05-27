using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Controllers.Tests.Pages
{
    public partial class SitePages
    {
        public IWebElement heading => Driver.FindElement(By.ClassName("navbar-brand"));

        public IWebElement registrationButton => Driver.FindElement(By.Id("registerLink"));
        public IWebElement registrationHeading => Driver.FindElement(By.XPath("/html/body/div[2]/div/div/h2"));

        public IWebElement loginButton => Driver.FindElement(By.Id("loginLink"));
        public IWebElement loginHeading => Driver.FindElement(By.XPath("/html/body/div[2]/div/div/h2"));

        public IWebElement helloWorldButton => Driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/article/header/h2/a"));
        public IWebElement helloWorldHeading => Driver.FindElement(By.XPath("/html/body/div[2]/div/article/header/h2"));

        public IWebElement proBlogButton => Driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[2]/article/header/h2/a"));
        public IWebElement proBlogHeading => Driver.FindElement(By.XPath("/html/body/div[2]/div/article/header/h2"));

        public IWebElement blogUpdateButton => Driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[3]/article/header/h2/a"));
        public IWebElement blogUpdateHeading => Driver.FindElement(By.XPath("/html/body/div[2]/div/article/header/h2"));
    }
}
