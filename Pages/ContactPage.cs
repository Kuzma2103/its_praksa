using OpenQA.Selenium;

namespace AutomationFramework.Pages
{
    public class ContactPage : BasePage
    {
        public ContactPage()
        {
            driver = null;
        }

        public ContactPage(IWebDriver webDriver)
        {
            driver = webDriver;
        }

        // Locators
        By contactLink = By.XPath("//a[@data-target='#exampleModal']");
        By contactEmailField = By.Id("recipient-email");
        By contactNameField = By.Id("recipient-name");
        By messageField = By.Id("message-text");
        By sendMessageButton = By.XPath("//button[contains(., 'Send message')]");

        /// <summary>
        /// Metoda koja vrsi klik na link contact us
        /// </summary>
        private void ClikOnContactLink()
        {
            ClickOnElement(contactLink);
        }

        /// <summary>
        /// Metoda koja upisuje vrednost u contact email polje
        /// </summary>
        /// <param name="text">Text koji upisujemo u polje</param>
        private void EnterContactEmail(string text)
        {
            WriteTextToElement(contactEmailField, text);
        }

        /// <summary>
        /// Metoda koja upisuje vrednost u contact name polje
        /// </summary>
        /// <param name="text">Text koji upisujemo u polje</param>
        private void EnterContactName(string text)
        {
            WriteTextToElement(contactNameField, text);
        }

        /// <summary>
        /// Metoda koja upisuje vrednost u message polje
        /// </summary>
        /// <param name="message">Text koji upisujemo u message polje</param>
        private void EnterMessage(string message)
        {
            WriteTextToElement(messageField, message);
        }

        private void ClickOnSendMessage()
        {
            ClickOnElement(sendMessageButton);
        }

        /// <summary>
        /// Metoda koja popunjava formu New message
        /// </summary>
        public void ContactUs(string email, string name, string message)
        {
            ClikOnContactLink();
            EnterContactEmail(email);
            EnterContactName(name);
            EnterMessage(message);
            ClickOnSendMessage();
        }
    }
}
