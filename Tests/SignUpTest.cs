using NUnit.Framework;

namespace AutomationFramework.Tests
{
    public class SignUpTest : BaseTest
    {
        [Test]
        public void SignUpUser()
        {
            string username = Pages.SignUpPage.GenerateRandomUsername();

            Pages.SignUpPage.SignUpUser(
                username,
                TestData.TestData.SignUpUser.password
            );

            string alertBoxMessage = Pages.SignUpPage.ReadTextFromAlertBox();
            Assert.AreEqual(alertBoxMessage, "Sign up successful.");

            // Accept alertbox
            Pages.SignUpPage.ClickOnOkAlertBox();

            // Asertacija testa - kreirani korisnik se uloguje u sistem
            Pages.LoginPage.Login(
                username,
                TestData.TestData.SignUpUser.password
            );

            string usernameLink = Pages.LoginPage.GetUsername();
            Assert.AreEqual(usernameLink, $"Welcome {username}");
        }
    }
}
