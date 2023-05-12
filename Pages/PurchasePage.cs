using OpenQA.Selenium;

namespace AutomationFramework.Pages
{
    public class PurchasePage : BasePage
    {
        /// <summary>
        /// Konstruktor bez parametara
        /// </summary>
        public PurchasePage()
        {
            driver = null;
        }

        /// <summary>
        /// Konstrukotr sa parametrom
        /// </summary>
        /// <param name="webDriver">driver</param>
        public PurchasePage(IWebDriver webDriver)
        {
            driver = webDriver;
        }

        // Locators
        By nameField = By.Id("name");
        By countryField = By.Id("country");
        By cityField = By.Id("city");
        By creditCardField = By.Id("card");
        By monthField = By.Id("month");
        By yearField = By.Id("year");
        By purchaseButton = By.XPath("//div[@class='modal-footer']/button[contains(., 'Purchase')]");
        By popUpMessageBox = By.XPath("//div[contains(@class, 'sweet-alert')]/h2");

        /// <summary>
        /// Metoda koja unosi vrednost u polje Name
        /// </summary>
        /// <param name="name">name of user</param>
        private void EnterName(string name)
        {
            WriteTextToElement(nameField, name);
        }

        /// <summary>
        /// Metoda koja unosi vrednost u polje Country
        /// </summary>
        /// <param name="country">country</param>
        private void EnterCountry(string country)
        {
            WriteTextToElement(countryField, country);
        }
        
        /// <summary>
        /// Metoda koja unosi vrednost u polje City
        /// </summary>
        /// <param name="city">city</param>
        private void EnterCity(string city)
        {
            WriteTextToElement(cityField, city);
        }

        /// <summary>
        /// Metoda koja upisuje vrednost u polje Credit Card
        /// </summary>
        /// <param name="creditCardNumber">Credit card number</param>
        private void EnterCreditCardNumber(long creditCardNumber)
        {
            WriteTextToElement(creditCardField, creditCardNumber);
        }

        /// <summary>
        /// Metoda koja upisuje vrednost u polje Month
        /// </summary>
        /// <param name="month">month</param>
        private void EnterMonth(string month) 
        {
            WriteTextToElement(monthField, month);
        }

        /// <summary>
        /// Metoda koja upisuje vrednost u polje Year
        /// </summary>
        /// <param name="year">year</param>
        private void EnterYear(string year)
        {
            WriteTextToElement(yearField, year);
        }

        /// <summary>
        /// Metoda koja klikne na dugme Purchase
        /// </summary>
        private void ClickOnPurchaseButton()
        {
            ClickOnElement(purchaseButton);
        }

        /// <summary>
        /// Metoda koja vraca text iz popup box-a
        /// </summary>
        /// <returns></returns>
        public string GetPopUpMessage()
        {
            return ReadTextFromElement(popUpMessageBox);
        }

        /// <summary>
        /// Metoda koja popunjava formu za kupovinu
        /// </summary>
        /// <param name="name">name</param>
        /// <param name="counry">counry</param>
        /// <param name="city">city</param>
        /// <param name="creditCart">creditCart</param>
        /// <param name="month">month</param>
        /// <param name="year">year</param>
        public void FillOutPlaceOrderForm(
            string name, 
            string country, 
            string city, 
            long creditCard, 
            string month, 
            string year
        )
        {
            EnterName(name);
            EnterCountry(country);
            EnterCity(city);
            EnterCreditCardNumber(creditCard);
            EnterMonth(month);
            EnterYear(year);
            ClickOnPurchaseButton();
        }
    }
}
