using System;

namespace CKK.tests
{
    public class ShoppingCartTest
    {
        [Fact]
        public void AddProduct_TestIfAddedCorrectly()
        {
            try
            {
                Customer cust = new Customer();
                ShoppingCart shop = new ShoppingCart(cust);
            }

        }
    }
}
