using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.UI.Tests.Pages.CreatePost
{
    public static class CreatePostAsserter
    {
        public static void AssertSuccessfulPostCreation(this CreatePost page, string text)
        {
            Assert.IsTrue(page.SuccessfulPostCreation.Displayed);
            Assert.AreEqual(text, page.SuccessfulPostCreation.Text);
        }

        public static void AssertErrorMessageForEmptyFields(this CreatePost page, string text)
        {
            Assert.IsTrue(page.ErrorMessageEmptyField.Displayed);
            Assert.AreEqual(text, page.ErrorMessageEmptyField.Text);
        }

        public static void AssertPostCreationCancelButton(this CreatePost page, string text)
        {
            Assert.IsTrue(page.PostCreationCancelButton.Displayed);
            Assert.AreNotEqual(text, page.PostCreationCancelButton.Text);
        }

        public static void AssertCreatePageIsDisplayed(this CreatePost page, string text)
        {
            Assert.AreEqual(page.CreatePostText.Text, text);
            Assert.IsTrue(page.CreatePostText.Displayed);
        }

        public static void AssertComtentResizeField(this CreatePost page, int size)
        {
            Assert.IsTrue(size < page.Content.Size.Height);
        }
    }
}
