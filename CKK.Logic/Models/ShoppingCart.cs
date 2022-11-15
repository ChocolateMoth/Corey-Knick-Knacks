
using CKK.Logic.Models;

namespace CKK.Logic
{
    public class ShoppingCart
    {
        private Customer _Customer;
        private ShoppingCartItem _product1;
        private ShoppingCartItem _product2;
        private ShoppingCartItem _product3;

        public ShoppingCart(Customer cust)
        {
            _Customer = cust;
        }

        public int GetCustomerId()
        {
            return _Customer.GetId();  
        }
        public ShoppingCartItem AddProduct(Product prod, int quantity)
        {
            if (quantity < 0)
            {
                return null;
            }
            if(prod == null)
            {
                return null;
            }
            foreach()

        }


        public ShoppingCartItem AddProduct(Product prod)
        {
            return prod.GetId();
        }
        public ShoppingCartItem RemoveProduct(Product prod, int quantity)
        {
            if (quantity > 0)
            {
                
            }
        }

        public ShoppingCartItem GetProductById(int id)
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
