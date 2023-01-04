using System;
using System.Linq;
using System.Collections.Generic;


namespace CKK.Logic.Models
{
    public class ShoppingCart
    {
        private Customer _Customer;
        private List<ShoppingCartItem> Products { get; set; }
        public ShoppingCart()
        {
            Products = new List<ShoppingCartItem>();
        }
        //private ShoppingCartItem _product1;
        //private ShoppingCartItem _product2;
        //private ShoppingCartItem _product3;

        public ShoppingCart(Customer cust)
        {
            _Customer = cust;
        }

        public int GetCustomerId() // returns customers id
        {
            return _Customer.GetId();  
        }

        ///////////////////////////////////////////////////////
        public ShoppingCartItem GetProductById(int id)
        {
            foreach(ShoppingCartItem productitem in Products)
            {
                if (productitem.GetProduct().GetId() == id)// gets the type of product and the id to see if it equals id
                {
                    return productitem;
                }
                return null;
                
            }
            //if cant get the product id returns nothing
            return null;
        }
        ///////////////////////////////////////////////////////////////////////////////////////
       
        
        public ShoppingCartItem AddProduct(Product prod, int quantity) //
        {
            bool listchecker = false;
            if (quantity <= 0) // if item doesn't exist, it will return null
            {
                return null;
            }

            else if (quantity > 0)
            {
                foreach (ShoppingCartItem productitem in Products)
                {
                    if (productitem.GetProduct() == prod)
                    {
                        productitem.SetQuantity(quantity + productitem.GetQuantity());
                        listchecker = true;
                        return productitem;
                    }
                }
            }
            if (listchecker == false)
            {
                ShoppingCartItem productitem = new ShoppingCartItem(prod, quantity);
                Products.Add(productitem);
                return productitem;
            }
            else
            {
                return null;
            }
            
        }
        //////////////////////////////////////////////////////////
      
        ///////////////////////////////////////////////////////////////////////////////////////
        public ShoppingCartItem RemoveProduct(int id, int quantity)
        {
            if (quantity <= 0) // to check if there are any items to remove
            {
                foreach (ShoppingCartItem productitem in Products)
                {
                    productitem.SetQuantity(0);
                    return productitem;
                }
            }
            else if (quantity > 0)
            {
                foreach (ShoppingCartItem productitem in Products)
                {
                    productitem.SetQuantity(productitem.GetQuantity() - quantity);
                    return productitem;
                }
            }
            return null;

        }


        //////////////////////////////////////////////////////////
        public decimal GetTotal()
        {
            //decimal totalone = 0;
            //decimal totaltwo = 0;
            //decimal totalthree = 0;
            decimal total = 0;

            foreach (ShoppingCartItem productitem in Products)
            {
                total += productitem.GetTotal();
                
            }
            return total;

        }

        ///////////////////////////////////////////////////////////////////////////////////////
        public List<ShoppingCartItem> GetProducts()
        {
            return Products;

        }
        //////////////////////////////////////////////////////////
    }

}