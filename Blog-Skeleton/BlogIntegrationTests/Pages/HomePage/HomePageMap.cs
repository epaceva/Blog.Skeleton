using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogIntegrationTests.Pages.HomePage
{
    public partial class HomePage
    {
        public IWebElement heading => Driver.FindElement(By.ClassName("navbar-brand"));
        public IWebElement registrationButton => Driver.FindElement(By.Id("registerLink"));
    }
}
