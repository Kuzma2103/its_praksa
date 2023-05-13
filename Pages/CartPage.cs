using OpenQA.Selenium;
using System.Threading;

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
        By deleteLink = By.XPath("//td/a[contains(., 'Delete')][1]");

        /// <summary>
        /// Metoda koja klikne na dugme Place order
        /// </summary>
        public void ClickOnPlaceOrderButton()
        {
            ClickOnElement(placeOrderButton);
        }

        /// <summary>
        /// Metoda koja klikne na delete u cart tabeli
        /// </summary>
        public void RemoveItemFromCart()
        {
            ClickOnElement(deleteLink);
            Thread.Sleep(2000);
        }

        /// <summary>
        /// Metoda koja proverava da li je red u tabeli cart-a vidljiv
        /// </summary>
        /// <returns>vraca true ako je vidljiv, false ako nije</returns>
        public bool IsTableRowDisplayed()
        {
            try
            {
                // Find the table row element
                IWebElement tableRow = driver.FindElement(By.XPath("//tr[@class='success']"));

                // Return whether the table row is displayed or not
                return tableRow.Displayed;
            }
            catch (NoSuchElementException)
            {
                // If the table row element is not found, return false
                return false;
            }
        }
    }
}
