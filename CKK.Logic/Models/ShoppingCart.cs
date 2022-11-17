
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

        public int GetCustomerId() // returns customers id
        {
            return _Customer.GetId();  
        }

        ///////////////////////////////////////////////////////
        public ShoppingCartItem GetProductById(int id)
        {
            if (_product1.GetProduct().GetId() == id)// gets the type of product and the id to see if it equals id
            {
                return _product1;

            }
            if (_product2.GetProduct().GetId() == id)// copy and paste but change numbers. makes it easier 
            {
                return _product2;

            }
            if (_product3.GetProduct().GetId() == id)
            {
                return _product3;

            }
            return null; //if cant get the product id returns nothing

        }
        ///////////////////////////////////////////////////////////////////////////////////////
        public ShoppingCartItem AddProduct(Product prod)
        {
            return AddProduct(prod, 1);
        }
        //////////////////////////////////////////////////////////
        public ShoppingCartItem AddProduct(Product prod, int quantity) //
        {
            
         if(quantity < 1)
            {
                return null;
            }
            if (_product1 != null && _product1.GetProduct().GetId() == prod.GetId())
            {
                _product1.SetQuantity(_product1.GetQuantity() + quantity);

                return _product1;
            }
            if (_product2 != null && _product2.GetProduct().GetId() == prod.GetId())
            {
                _product2.SetQuantity(_product2.GetQuantity() + quantity);

                return _product2;
            }
            if (_product3 != null && _product3.GetProduct().GetId() == prod.GetId())
            {
                _product3.SetQuantity(_product3.GetQuantity() + quantity);

                return _product3;
                
            }
            {
                return null;
            }

        }
        ///////////////////////////////////////////////////////////////////////////////////////
        public ShoppingCartItem RemoveProduct(Product prod, int quantity)
        {
            // (quantity ==0)
            //
            //   return _product1;
            //
            if (_product1.GetQuantity() == 0)
            {
                if (_product1 != null && _product1.GetQuantity() > 0)
                {
                    return RemoveProduct(prod, -1); // I think this should return a -1 removing the product
                }

                if (_product2 != null && _product2.GetQuantity() > 0)
                {
                    return RemoveProduct(prod, -1);
                }

                if (_product3 != null && _product3.GetQuantity() > 0)
                {
                    return RemoveProduct(prod, -1);
                }
            }
                return null;


            
        }


        //////////////////////////////////////////////////////////
        public decimal GetTotal()
        {
            decimal totalone = 0;
            decimal totaltwo = 0;
            decimal totalthree = 0;

            totalone = _product1.GetProduct().GetPrice() * _product1.GetQuantity(); // gets the type of product with price and times it with the amount
            totaltwo = _product2.GetProduct().GetPrice() * _product2.GetQuantity();
            totalthree = _product3.GetProduct().GetPrice() * _product3.GetQuantity();

            return totalone + totaltwo + totalthree; //add all totals together for GetTotal()
        }
        ///////////////////////////////////////////////////////////////////////////////////////
        public ShoppingCartItem GetProduct(int prodNum)
        {
            if (prodNum == 1)
            {
                return _product1;
            }
            else if (prodNum == 2)
            {
                return _product2;
            }
            else if (prodNum == 3)
            {
                return _product3;
            }
            else
            {
                return null;
            }

        }
        //////////////////////////////////////////////////////////
    }

}
