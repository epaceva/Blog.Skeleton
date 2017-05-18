using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogIntegrationTests.Pages.RegistrationPage
{
    public static class RegistrationPageAsserter
    {
        public static void AssertRequiredFields(this RegistrationPage page, string text)
        {
            Assert.IsTrue(page.ErrorMessagesForRequiredFields.Displayed);
            Assert.AreEqual(text, page.ErrorMessagesForRequiredFields.Text);
        }

        public static void AssertMissingEmail(this RegistrationPage page, string text)
        {
            Assert.IsTrue(page.ErrorMessageForEmail.Displayed);
            Assert.AreEqual(text, page.ErrorMessageForEmail.Text);
        }

        public static void AssertInvalidEmail(this RegistrationPage page, string text)
        {
            Assert.IsTrue(page.ErrorMessageForInvalidEmail.Displayed);
            Assert.AreEqual(text, page.ErrorMessageForInvalidEmail.Text);
        }

        public static void AssertMissingFullName(this RegistrationPage page, string text)
        {
            Assert.IsTrue(page.ErrorMessageForFullName.Displayed);
            Assert.AreEqual(text, page.ErrorMessageForFullName.Text);
        }

        public static void AssertMissingPassword(this RegistrationPage page, string text)
        {
            Assert.IsTrue(page.ErrorMessagesForPassword.Displayed);
            Assert.AreEqual(text, page.ErrorMessagesForPassword.Text);
        }

        public static void AssertPasswordMismatch(this RegistrationPage page, string text)
        {
            Assert.IsTrue(page.ErrorMessagesForPasswordMismatch.Displayed);
            Assert.AreEqual(text, page.ErrorMessagesForPasswordMismatch.Text);
        }
    }
}
