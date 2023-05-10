using NUnit.Framework;
using System.Collections.Generic;

namespace AutomationFramework.Tests
{
    public class AddToCartTest : BaseTest
    {
        [SetUp]
        public void Setup()
        {
            // Prvo se ulogujemo u sistem da bismo izvrsili kupovinu proizvoda
            Pages.LoginPage.Login(TestData.TestData.Login.username, TestData.TestData.Login.password);
        }

        [Test]
        public void AddToCart()
        {
            Pages.HomePage.NavigateToItem(
                TestData.TestData.AddToCart.categoryName, 
                TestData.TestData.AddToCart.itemName
            );
            Pages.HomePage.AddToCart();

            // Assertacije alertbox poruke
            string alertBoxMessage = Pages.HomePage.ReadTextFromAlertBox();
            Assert.AreEqual(alertBoxMessage, TestData.TestData.AlertBoxMessages.ProductAdded);

            // click ok u alert box-u
            Pages.HomePage.AcceptAlertBox();

            // Provera da li se proizvod zaista nalazi u korpi
            Pages.HomePage.ClickOnCartLink();

            // Izvlacimo iz tabele prvi vrednosti kolona iz prvog reda i pakujemo u cellValues varijablu
            List<string> cellValues = Pages.CartPage.GetValuesFromFirstTableRow();

            // Proveravamo da li je item name isti kao u tabeli - Tako znamo da je izabrani proizvod dodat u korpu
            Assert.AreEqual(TestData.TestData.AddToCart.itemName, cellValues[1]);
        }
    }
}
