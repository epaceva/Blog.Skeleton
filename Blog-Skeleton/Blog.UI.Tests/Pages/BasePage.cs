﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Blog.UI.Tests.Pages
{
    public class BasePage
    {
        protected string url = ConfigurationManager.AppSettings["URL"];
        private IWebDriver driver;
        private WebDriverWait wait;

        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
            this.wait = new WebDriverWait(this.driver, TimeSpan.FromSeconds(10));
        }

        public IWebDriver Driver
        {
            get { return this.driver; }
        }

        public WebDriverWait Wait
        {
            get
            {
                wait = new WebDriverWait(this.Driver, TimeSpan.FromSeconds(60));
                return this.wait;
            }
        }

        public void NavigateTo(string url)
        {
            this.Driver.Navigate().GoToUrl(url);
        }
    }
}