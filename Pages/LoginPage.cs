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

        /// <summary>
        /// Metoda koja upisuje username u polje
        /// </summary>
        /// <param name="username">Username</param>
        private void EnterUsername(string username)
        {
            WriteTextToElement(usernameField, username);
        }

        /// <summary>
        /// Metoda koja upisuje password u polje
        /// </summary>
        /// <param name="password">Password</param>
        private void EnterPassword(string password)
        {
            WriteTextToElement(passwordField, password);
        }

        /// <summary>
        /// Metoda koja klikne na dugme Login
        /// </summary>
        private void ClickOnLoginButton()
        {
            ClickOnElement(loginButton);
        }

        /// <summary>
        /// Metoda koja klikne na link Login
        /// </summary>
        private void ClickOnLogInLink()
        {
            ClickOnElement(loginLink);
        }

        /// <summary>
        /// Metoda koja vraca vrednost username-a
        /// </summary>
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
