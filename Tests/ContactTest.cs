using NUnit.Framework;

namespace AutomationFramework.Tests
{
    public class ContactTest : BaseTest
    {
        [Test]
        public void Contact()
        {
            Pages.ContactPage.ContactUs(
                TestData.TestData.Contact.email, 
                TestData.TestData.Contact.name, 
                TestData.TestData.Contact.message
            );

            // Assert testa
            string allertBoxMessage = Pages.ContactPage.ReadTextFromAlertBox();
            Assert.AreEqual(allertBoxMessage, "Thanks for the message!!");
        }
    }
}
