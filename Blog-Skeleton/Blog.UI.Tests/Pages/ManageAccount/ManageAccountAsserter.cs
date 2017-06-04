using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.UI.Tests.Pages.ManageAccount
{
    public static class ManageAccountAsserter
    {
        public static void AssertSuccessfulPasswordChange(this ManageAccount page, string text)
        {
            Assert.IsTrue(page.SuccessfulPasswordChange.Displayed);
            Assert.AreEqual(text, page.SuccessfulPasswordChange.Text);
        }

        public static void AssertErrorMessageForEmptyEmailField(this ManageAccount page, string text)
        {
            Assert.IsTrue(page.ErrorMessageIncorrectPasswordChange.Displayed);
            Assert.AreEqual(text, page.ErrorMessageIncorrectPasswordChange.Text);
        }
    }
}
