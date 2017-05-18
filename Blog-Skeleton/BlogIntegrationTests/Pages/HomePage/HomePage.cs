﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace BlogIntegrationTests.Pages.HomePage
{
    public partial class HomePage : BasePage
    {
        private String url = "http://localhost:60634/Article/List";

        public HomePage(IWebDriver driver) : base(driver)
        {
        }

        public void NavigateTo()
        {
            this.Driver.Navigate().GoToUrl(this.url);
        }
    }
}
