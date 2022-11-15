
using CKK.Logic.Models;

namespace CKK.Logic
{
    public class ShoppingCart
    {
        private string _Customer;
        private Product _product1;
        private Product _product2;
        private Product _product3;

        public ShoppingCart(string cust)
        {
            _Customer = cust;
        }

        public int GetCustomerId(int id)
        {
            
            return id;  
        }

        public int GetProductById(int id)
        {
            return id.GetProductById();
        }

        public ShoppingCartItem AddProduct()
        {

        }
        public ShoppingCartItem AddProduct()
        {

        }
        public ShoppingCartItem RemoveProduct()
        {

        }

        public ShoppingCartItem GetProductById()
        {

        }

        public decimal GetTotal()
        {
            
        }

        public ShoppingCartItem GetProduct(int prodNum)
        {

        }
    }

}
