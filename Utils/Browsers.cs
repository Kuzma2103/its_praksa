using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace AutomationFramework.Utils
{
    /// <summary>
    /// Klasa koja konfigurise browser 
    /// </summary>
    public class Browsers
    {
        private IWebDriver webDriver;
        private string baseURL = "https://www.demoblaze.com/";

        /// <summary>
        /// Metoda koja pravi objekat odredjenog browsera, maximizira prozor i navigira na baseURL
        /// </summary>
        public void Init()
        {
            var chromeOptions = new ChromeOptions();

            chromeOptions.AddArgument("ignore-certificate-errors");
            chromeOptions.AddArgument("start-maximized");
            webDriver = new ChromeDriver(chromeOptions);

            Goto(baseURL);
        }

        /// <summary>
        /// Getter metoda za webDriver
        /// </summary>
        public IWebDriver GetDriver
        {
            get { return webDriver; }
        }

        /// <summary>
        /// Metoda koja navigira driver na odredjeni URL
        /// </summary>
        /// <param name="url">URL</param>
        public void Goto(string url)
        {
            //webDriver.Url = url;
            webDriver.Navigate().GoToUrl(url);
        }

        /// <summary>
        /// Metoda koja gasi driver
        /// </summary>
        public void Close()
        {
            webDriver.Quit();
        }
    }
}
