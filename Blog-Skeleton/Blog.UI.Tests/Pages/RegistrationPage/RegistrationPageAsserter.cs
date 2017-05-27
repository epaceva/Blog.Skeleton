using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Blog.UI.Tests.Pages.RegistrationPage
{
    public static class RegistrationPageAsserter
    {
        public static void AssertErrorMessage(this RegistrationPage page, string text)
        {
            Assert.IsTrue(page.ErrorMessageForEmptyFieldOrMissmatch.Displayed);
            Assert.AreEqual(text, page.ErrorMessageForEmptyFieldOrMissmatch.Text);
        }
    }
}

