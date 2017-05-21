using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogIntegrationTests.Pages.LoginPage
{
    public static class LoginPageAsserter
    {
        public static void AssertSuccessfulLogin(this LoginPage page, string text)
        {
            Assert.IsTrue(page.SuccessfulLogin.Displayed);
            Assert.AreEqual(text, page.SuccessfulLogin.Text);
        }

        public static void AssertErrorMessageForEmptyEmailField(this LoginPage page, string text)
        {
            Assert.IsTrue(page.ErrorMessageEmptyEmailField.Displayed);
            Assert.AreEqual(text, page.ErrorMessageEmptyEmailField.Text);
        }

        public static void AssertErrorMessageForEmptyPasswordField(this LoginPage page, string text)
        {
            Assert.IsTrue(page.ErrorMessageForEmptyPasswordField.Displayed);
            Assert.AreEqual(text, page.ErrorMessageForEmptyPasswordField.Text);
        }

        public static void AssertErrorMessageForIncorrectPassword(this LoginPage page, string text)
        {
            Assert.IsTrue(page.ErrorMessageForIncorrectPassword.Displayed);
            Assert.AreEqual(text, page.ErrorMessageForIncorrectPassword.Text);
        }
    }
}
