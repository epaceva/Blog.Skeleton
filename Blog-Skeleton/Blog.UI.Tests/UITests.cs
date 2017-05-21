using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.UI.Tests
{
    [TestFixture]
    public class UITests
    {
        //[Test, Property("UI", 1)]
        //[Author("epaceva")]

        //public void CheckSiteLoad()
        //{
        //    IWebDriver driver = BrowserHost.Instance.Application.Browser;
        //    WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(100));

        //    var logo = wait.Until(w => w.FindElement(By.XPath("/html/body/div[1]/div/div[1]/a")));
        //    Assert.AreEqual("SOFTUNI BLOG", logo.Text);
        //}

        //[Test, Property("Integration", 1)]
        //[Author("epaceva")]
        //public void CheckSiteLoad()
        //{
        //    IWebDriver driver = BrowserHost.Instance.Application.Browser;
        //    WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(100));

        //    var logo = wait.Until(w => w.FindElement(By.XPath("/html/body/div[1]/div/div[1]/a")));
        //    Assert.AreEqual("SOFTUNI BLOG", logo.Text);
        //}

        //[Test, Property("Integration", 1)]
        //[Author("epaceva")]
        //public void NavigateToRegistrationPage()
        //{
        //    HomePage homePage = new HomePage(this.driver);

        //    homePage.NavigateTo();

        //    Assert.AreEqual("SOFTUNI BLOG", homePage.heading.Text);
        //}
    }
}
