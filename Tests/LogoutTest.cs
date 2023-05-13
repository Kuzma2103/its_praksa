using NUnit.Framework;

namespace AutomationFramework.Tests
{
    public class LogoutTest : BaseTest
    {
        [SetUp]
        public void Setup()
        {
            // User login
            Pages.LoginPage.Login(
                TestData.TestData.Login.username, 
                TestData.TestData.Login.password
            );
        }

        [Test]
        public void LogoutUser()
        {
            Pages.HomePage.ClickOnLogoutLink();

            // Asertacija testa - Proverava da li postoji link logout
            Assert.IsFalse(Pages.HomePage.IsLinkDisplayed("logout2"));
        }
    }
}
