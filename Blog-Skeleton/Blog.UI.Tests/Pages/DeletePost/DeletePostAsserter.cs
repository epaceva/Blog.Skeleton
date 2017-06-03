using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.UI.Tests.Pages.DeletePost
{
    public static class DeletePostAsserter
    {
        public static void AssertSuccessfulPostDelete(this DeletePost page, string text)
        {
            Assert.IsTrue(page.SuccessfulPostDelete.Displayed);
            Assert.AreNotEqual(text, page.SuccessfulPostDelete.Text);
        }

        public static void AssertPostDeleteCancelButton(this DeletePost page, string text)
        {
            Assert.IsTrue(page.PostDeleteCancelButton.Displayed);
            Assert.AreEqual(text, page.PostDeleteCancelButton.Text);
        }
    }
}
