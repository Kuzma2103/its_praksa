using OpenQA.Selenium;

namespace AutomationFramework.Pages
{
    public class SignUpPage : BasePage
    {
        /// <summary>
        /// Konstruktor bez parametara
        /// </summary>
        public SignUpPage()
        {
            driver = null;
        }

        /// <summary>
        /// Konstruktor sa parametrima
        /// </summary>
        /// <param name="webDriver">driver</param>
        public SignUpPage(IWebDriver webDriver)
        {
            driver = webDriver;
        }

        // Locators

        By signUpLink = By.Id("signin2");
        By usernameField = By.Id("sign-username");
        By passwordField = By.Id("sign-password");
        By signUpButton = By.XPath("//button[contains(., 'Sign up')]");


        /// <summary>
        /// Metoda koja klikne na link sign up
        /// </summary>
        private void ClickOnSignUpLink()
        {
            ClickOnElement(signUpLink);
        }

        /// <summary>
        /// Metoda koja upisuje vrednost u polje Username
        /// </summary>
        /// <param name="username">Username</param>
        private void EnterUsername(string username)
        {
            WriteTextToElement(usernameField, username);
        }
        
        /// <summary>
        /// Metoda koja upisuje vrednost u polje Password
        /// </summary>
        /// <param name="password">Password</param>
        private void EnterPassword(string password)
        {
            WriteTextToElement(passwordField, password);
        }

        /// <summary>
        /// Metoda koja klikne na dugme sign up
        /// </summary>
        private void ClickOnSignUpButton()
        {
            ClickOnElement(signUpButton);
        }

        /// <summary>
        /// Metoda koja klikne na ok dugme u alert box-u kako bi potvrdio/zatvorio prozor
        /// </summary>
        public void ClickOnOkAlertBox()
        {
            AcceptAlertBox();
        }

        /// <summary>
        /// Metoda radi registraciju usera
        /// </summary>
        /// <param name="username">Username user-a</param>
        /// <param name="password">Password user-a</param>
        public void SignUpUser(string username, string password)
        {
            ClickOnSignUpLink();
            EnterUsername(username);
            EnterPassword(password);
            ClickOnSignUpButton();
        }
    }
}
