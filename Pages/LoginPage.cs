using OpenQA.Selenium;

namespace AutomationFramework.Pages
{

    /// <summary>
    /// Klasa koja nam predstavlja login stranicu
    /// </summary>
    public class LoginPage : BasePage
    {

        /// <summary>
        /// Konstruktor bez parametara
        /// </summary>
        public LoginPage()
        {
            driver = null;
        }

        /// <summary>
        /// Konstruktor sa parametrima
        /// </summary>
        /// <param name="webDriver">Driver</param>
        public LoginPage(IWebDriver webDriver)
        {
            driver = webDriver;
        }

        // Locators

        By usernameField = By.Id("loginusername");
        By passwordField = By.Id("loginpassword");
        By loginButton = By.XPath("//div[@class='modal-footer']/button[contains(text(), 'Log in')]");
        By loginLink = By.Id("login2");
        By nameOfUser = By.Id("nameofuser");

        private void EnterUsername(string username)
        {
            WriteTextToElement(usernameField, username);
        }

        private void EnterPassword(string password)
        {
            WriteTextToElement(passwordField, password);
        }

        private void ClickOnLoginButton()
        {
            ClickOnElement(loginButton);
        }

        private void ClickOnLogInLink()
        {
            ClickOnElement(loginLink);
        }

        public string GetUsername()
        {
            return ReadTextFromElement(nameOfUser);
        }

        /// <summary>
        /// Metoda koja vrsi login u aplikaciju
        /// </summary>
        public void Login(string username, string password)
        {
            ClickOnLogInLink();
            EnterUsername(username);
            EnterPassword(password);
            ClickOnLoginButton();
        }
    }
}
