using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading;

namespace AutomationFramework.Pages
{
    public class BasePage
    {
        // Driver
        public IWebDriver? driver;
        public WebDriverWait wait;


        /// <summary>
        /// Metoda koja ceka vidljivost elementa
        /// </summary>
        private void WaitElementVisibility(By elementBy)
        {
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(elementBy));
        }

        /// <summary>
        /// Metoda koja klikne na element
        /// </summary>
        public void ClickOnElement(By element)
        {
            WaitElementVisibility(element);
            driver.FindElement(element).Click();
        }

        /// <summary>
        /// Metoda koja upisuje vrednost u polje
        /// </summary>
        public void WriteTextToElement(By element, string text)
        {
            WaitElementVisibility(element);
            driver.FindElement(element).SendKeys(text);
        }

        /// <summary>
        /// Metoda koja upisuje string kroz parametar int
        /// </summary>
        /// <param name="element">element</param>
        /// <param name="number">broj</param>
        public void WriteTextToElement(By element, long number)
        {
            WaitElementVisibility(element);
            driver.FindElement(element).SendKeys(number.ToString());
        }

        /// <summary>
        /// Metoda koja cita text iz elementa
        /// </summary>
        public string ReadTextFromElement(By element)
        {
            WaitElementVisibility(element);
            return driver.FindElement(element).Text;
        }

        /// <summary>
        /// Metoda koja cita text iz alert box-a
        /// </summary>
        public string ReadTextFromAlertBox()
        {
            Thread.Sleep(1000);
            return driver.SwitchTo().Alert().Text;
        }

        /// <summary>
        /// Metoda koja potvrdjuje alert box
        /// </summary>
        public void AcceptAlertBox()
        {
            Thread.Sleep(1000);
            driver.SwitchTo().Alert().Accept();
        }

        /// <summary>
        /// Metoda koja vraca vrednosti celija iz prvog reda u tabeli
        /// </summary>
        /// <returns></returns>
        public List<string> GetValuesFromFirstTableRow()
        {
            List<string> values = new List<string>();
            ReadOnlyCollection<IWebElement> rows = driver.FindElements(By.XPath("//tr[@class='success']"));

            try
            {
                IWebElement firstRow = rows[0]; // sa 85 linijom ova linija je nepotrebna
                ReadOnlyCollection<IWebElement> cells = firstRow.FindElements(By.XPath("./td"));

                // Drugi nacin dohvatanja podataka iz prvog reda u tabeli
                //ReadOnlyCollection<IWebElement> cells = driver.FindElements(By.XPath("//tr[@class='success'][1]/td"));

                foreach (IWebElement cell in cells)
                {
                    values.Add(cell.Text);
                }
            }
            catch (Exception)
            {
                throw;
            }

            return values;
        }

        /// <summary>
        /// Metoda koja kreira jedinstvenog korisnika, kreirajuci random broj
        /// kao sufix na "Random User" string
        /// </summary>
        /// <returns></returns>
        public string GenerateRandomUsername()
        {
            Random random = new Random();
            int randomNumber = random.Next(1000, 9999);
            string username = "Random User " + randomNumber;
            return username;
        }

    }

    
}
