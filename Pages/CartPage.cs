using OpenQA.Selenium;

namespace AutomationFramework.Pages
{
    public class CartPage : BasePage
    {
        /// <summary>
        /// Konstruktor bez parametara
        /// </summary>
        public CartPage()
        {
            driver = null;
        }

        /// <summary>
        /// Konstruktor sa parametrima
        /// </summary>
        /// <param name="webDriver">driver</param>
        public CartPage(IWebDriver webDriver)
        {
            driver= webDriver;
        }

        // Locators

        By placeOrderButton = By.XPath("//button[contains(., 'Place Order')]");

        /// <summary>
        /// Metoda koja klikne na dugme Place order
        /// </summary>
        public void ClickOnPlaceOrderButton()
        {
            ClickOnElement(placeOrderButton);
        }
    }
}
