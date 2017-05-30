using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.UI.Tests.Pages.EditPost
{
    public static class EditPostAsserter
    {
        public static void AssertSuccessfulPostEdit(this EditPost page, string text)
        {
            Assert.IsTrue(page.SuccessfulPostEdit.Displayed);
            Assert.AreEqual(text, page.SuccessfulPostEdit.Text);
        }

        public static void AssertErrorMessageForEmptyFieldsPostEdit(this EditPost page, string text)
        {
            Assert.IsTrue(page.ErrorMessageEmptyFieldPostEdit.Displayed);
            Assert.AreEqual(text, page.ErrorMessageEmptyFieldPostEdit.Text);
        }

        public static void AssertPostEditCancelButton(this EditPost page, string text)
        {
            Assert.IsTrue(page.PostEditCancelButton.Displayed);
            Assert.AreNotEqual(text, page.PostEditCancelButton.Text);
        }

        public static void AssertEditPageIsDisplayed(this EditPost page, string text)
        {
            Assert.AreEqual(page.EditPostText.Text, text);
            Assert.IsTrue(page.EditPostText.Displayed);
        }

        public static void AssertComtentResizeField(this EditPost page, int size)
        {
            Assert.IsTrue(size < page.ContentToEdit.Size.Height);
        }
    }
}
