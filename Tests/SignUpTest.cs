using NUnit.Framework;

namespace AutomationFramework.Tests
{
    public class SignUpTest : BaseTest
    {
        [Test]
        public void SignUpUser()
        {
            Pages.SignUpPage.SignUpUser(
                TestData.TestData.SignUpUser.username, 
                TestData.TestData.SignUpUser.password
            );

            string alertBoxMessage = Pages.SignUpPage.ReadTextFromAlertBox();

            Assert.AreEqual(alertBoxMessage, "Sign up successful.");

            Pages.SignUpPage.ClickOnOkAlertBox();
        }

        [TearDown]
        public void LoginUser()
        {
            Pages.LoginPage.Login(
                TestData.TestData.SignUpUser.username,
                TestData.TestData.SignUpUser.password
            );
            string username = Pages.LoginPage.GetUsername();
            Assert.AreEqual(username, $"Welcome {TestData.TestData.SignUpUser.username}");
        }
    }
}
