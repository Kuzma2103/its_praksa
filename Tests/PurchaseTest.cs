using NUnit.Framework;

namespace AutomationFramework.Tests
{
    public class PurchaseTest : BaseTest
    {
        [SetUp]
        public void Setup()
        {
            // Login user
            Pages.LoginPage.Login(
                TestData.TestData.Login.username,
                TestData.TestData.Login.password
            );

            // Dodavanje proizvoda u korpu
            Pages.HomePage.NavigateToItem(
                TestData.TestData.AddToCart.categoryName,
                TestData.TestData.AddToCart.itemName
            );
            Pages.HomePage.AddToCart();
            Pages.HomePage.AcceptAlertBox();
            Pages.HomePage.ClickOnCartLink();
        }

        [Test]
        public void PurchaseItem() 
        {
            Pages.CartPage.ClickOnPlaceOrderButton();
            Pages.PurchasePage.FillOutPlaceOrderForm(
                TestData.TestData.PurchaseItem.name,
                TestData.TestData.PurchaseItem.country,
                TestData.TestData.PurchaseItem.city,
                TestData.TestData.PurchaseItem.creditCard,
                TestData.TestData.PurchaseItem.month,
                TestData.TestData.PurchaseItem.year
            );

            // Assert
            string popupMessage = Pages.PurchasePage.GetPopUpMessage();
            Assert.AreEqual(popupMessage, TestData.TestData.PopUpMessages.PurchaseComplete);
        }
    }
}
