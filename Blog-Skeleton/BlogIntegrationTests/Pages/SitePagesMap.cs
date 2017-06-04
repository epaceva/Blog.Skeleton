using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogIntegrationTests.Pages
{
    public partial class SitePages
    {
        public IWebElement heading => Driver.FindElement(By.ClassName("navbar-brand"));

        public IWebElement registrationButton => Driver.FindElement(By.Id("registerLink"));
        public IWebElement registrationHeading => Driver.FindElement(By.XPath("/html/body/div[2]/div/div/h2"));

        public IWebElement loginButton => Driver.FindElement(By.Id("loginLink"));
        public IWebElement loginHeading => Driver.FindElement(By.XPath("/html/body/div[2]/div/div/h2"));
        public IWebElement loginEmail => Driver.FindElement(By.Id("Email"));
        public IWebElement loginPassword => Driver.FindElement(By.Id("Password"));
        public IWebElement loginFormButton => Driver.FindElement(By.XPath("/html/body/div[2]/div/div/form/div[4]/div/input"));

        public IWebElement helloWorldButton => Driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/article/header/h2/a"));
        public IWebElement helloWorldHeading => Driver.FindElement(By.XPath("/html/body/div[2]/div/article/header/h2"));

        public IWebElement proBlogButton => Driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[2]/article/header/h2/a"));
        public IWebElement proBlogHeading => Driver.FindElement(By.XPath("/html/body/div[2]/div/article/header/h2"));

        public IWebElement blogUpdateButton => Driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[3]/article/header/h2/a"));
        public IWebElement blogUpdateHeading => Driver.FindElement(By.XPath("/html/body/div[2]/div/article/header/h2"));

        public IWebElement logoffButton => Driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li[3]/a"));
    }
}
