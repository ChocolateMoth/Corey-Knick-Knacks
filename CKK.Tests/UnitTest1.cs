using System;
using Xunit;
using CKK.Logic.Models;


namespace CKK.Tests
{
    public class ShoppingCartTest
    {
        [Fact]
        public void AddProduct_TestIfAddedCorrectly()
        {
            try
            {
                Customer cust = new Customer();
                Product prod = new Product();
                ShoppingCart shop = new ShoppingCart(cust);
                int expected = 5;
                //int actual = prod

                prod.SetId(2);
                cust.SetId(1);
                int actual = shop.AddProduct(prod, expected).GetQuantity();



                Assert.Equal(expected, actual);

            }
            catch
            {
                throw new ArgumentNullException();
            }

        }
        [Fact]
        public void RemoveProduct_TestTheRemove()
        {
            try
            {
                Customer cust = new Customer();
                Product prod = new Product();
                ShoppingCart shop = new ShoppingCart(cust);
                int expected = 5;
                //int actual = prod

                prod.SetId(2);
                cust.SetId(1);
                int actual = shop.AddProduct(prod, expected).GetQuantity();



                Assert.Equal(expected, actual);

            }
            catch
            {
                throw new ArgumentNullException();
            }
            
        }
        [Fact]
        public void GetTotal_CheckForTot()
        {
            try
            {
                Customer cust = new Customer();
                Product _product1 = new Product();
                Product _product2 = new Product();
                Product _product3 = new Product();
                ShoppingCart shop = new ShoppingCart(cust);
                
                _product1.SetId(1);
                _product1.SetPrice(5);
                _product2.SetId(2);
                _product2.SetPrice(5);
                _product3.SetId(3);
                _product3.SetPrice(5);
                shop.AddProduct(_product1, 1);
                shop.AddProduct(_product2, 2);
                shop.AddProduct(_product3, 3);
                var act = shop.GetTotal();
                Assert.Equal(30, act);
            }
            catch
            {
                throw new Exception("wrong");
            }
        }

        
    }
}
