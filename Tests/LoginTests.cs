using NUnit.Framework;

namespace AutomationFramework.Tests
{
    public class LoginTests : BaseTest
    {

        [Test]
        public void LoginWithInvalidData()
        {
            Pages.LoginPage.Login(TestData.TestData.Login.invalidUsername, TestData.TestData.Login.invalidPassword);
            string errorMsg = Pages.LoginPage.ReadTextFromAlertBox();
            Assert.AreEqual(errorMsg, "User does not exist.");
        }

        [Test]
        public void LoginWithValidData()
        {
            Pages.LoginPage.Login(TestData.TestData.Login.username, TestData.TestData.Login.password);

            // Test assert
            string username = Pages.LoginPage.GetUsername();
            Assert.AreEqual(username, "Welcome test");
        }
    }
}
