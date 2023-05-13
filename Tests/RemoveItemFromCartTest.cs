using NUnit.Framework;

namespace AutomationFramework.Tests
{
    public class RemoveItemFromCartTest : BaseTest
    {
        [SetUp]
        public void Setup()
        {
            // Sign up user
            string username = Pages.SignUpPage.GenerateRandomUsername();

            Pages.SignUpPage.SignUpUser(
                username,
                TestData.TestData.SignUpUser.password
            );
            Pages.HomePage.AcceptAlertBox();

            // User login
            Pages.LoginPage.Login(
                username,
                TestData.TestData.SignUpUser.password
            );

            // Add item to cart
            AddItemToCart();
            
            // click ok u alert box-u
            Pages.HomePage.AcceptAlertBox();
            Pages.HomePage.ClickOnCartLink();
        }

        [Test]
        public void RemoveItemFromCart()
        {
            Pages.CartPage.RemoveItemFromCart();

            // Asertacija testa
            Assert.IsFalse(Pages.CartPage.IsTableRowDisplayed());
        }

        /// <summary>
        /// Preduslovna metoda koja dodaje proizvod u korpu
        /// </summary>
        private void AddItemToCart()
        {
            Pages.HomePage.NavigateToItem(
                TestData.TestData.RemoveItemFromCart.categoryName,
                TestData.TestData.RemoveItemFromCart.itemName
            );
            Pages.HomePage.AddToCart();
        }
    }
}
