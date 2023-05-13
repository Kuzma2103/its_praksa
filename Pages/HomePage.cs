using OpenQA.Selenium;
using System.Threading;

namespace AutomationFramework.Pages
{
    public class HomePage : BasePage
    {
        /// <summary>
        /// Konstruktor bez parametara
        /// </summary>
        public HomePage()
        {
            driver = null;
        }

        /// <summary>
        /// Konstruktor sa parametrima
        /// </summary>
        /// <param name="webDriver">driver</param>
        public HomePage(IWebDriver webDriver)
        {
            driver = webDriver;
        }

        // Locators
        By addToCartButton = By.XPath("//a[contains(text(), 'Add to cart')]");
        By cartLink = By.Id("cartur");

        /// <summary>
        /// Metoda koja klikne na odredjenu kategoriju - Phones
        /// </summary>
        private void ClickOnCategory(string category)
        {
            By categoryLocator = By.XPath($"//a[contains(., '{category}')]");
            driver.FindElement(categoryLocator).Click();            
        }

        /// <summary>
        /// Metoda koja klikne na artikal
        /// </summary>
        /// <param name="itemName">Naziv artikla</param>
        private void ClickOnItem(string itemName)
        {
            By itemLocator = By.XPath($"//a[contains(., '{itemName}')]");
            driver.FindElement(itemLocator).Click();
        }

        /// <summary>
        /// Metoda koja klikne na dugme Add to cart
        /// </summary>
        private void ClickOnAddToCartButton()
        {
            ClickOnElement(addToCartButton);
        }
        
        /// <summary>
        /// Metoda koja klikne na link u meniju Cart
        /// </summary>
        public void ClickOnCartLink()
        {
            ClickOnElement(cartLink);
            Thread.Sleep(3000);
        }

        /// <summary>
        /// Metoda koja dovodi korisnika do zeljenog proizvoda
        /// </summary>
        /// <param name="categoryName">Ime kategorije</param>
        /// <param name="itemName">Ime proizvoda</param>
        public void NavigateToItem(string categoryName, string itemName)
        {
            Thread.Sleep(1000);
            ClickOnCategory(categoryName);
            Thread.Sleep(1000);
            ClickOnItem(itemName);
        }

        /// <summary>
        /// Metoda koja vrsi klik na dugme Add to cart
        /// </summary>
        public void AddToCart()
        {            
            ClickOnAddToCartButton();
        }
    }
}
