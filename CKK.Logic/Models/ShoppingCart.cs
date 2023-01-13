using System;
using System.Linq;
using System.Collections.Generic;

//                                                                                                                                                                                                             all your friends abandon you for the slime you are?? well Ive got just the thing you need
namespace CKK.Logic.Models
{
    public class ShoppingCart
    {
        private Customer _Customer;
        List<ShoppingCartItem> Products = new List<ShoppingCartItem>();
        
        /*
        private List<ShoppingCartItem> Products { get; set; }
        public ShoppingCart()
        {
            Products = new List<ShoppingCartItem>();
        }
        */



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
     
        ///////////////////////////////////////////////////////////////////////////////////////
       // a lot of stuff is in green because its probalby a failed attempt . I tend to keep things than get rid of them. who knows doing it this way may be faster if I need to copy paste something again.
        
        public ShoppingCartItem AddProduct(Product prod, int quantity) //
        {
            //bool listchecker = false;
            if (quantity <0 || prod ==null) // if item doesn't exist, it will return null
            {
                return null;
            }

                foreach (var productitems in Products) // productitemS <- has an S
                {
                    if (productitems.GetProduct() == prod)
                    {
                        productitems.SetQuantity(quantity + productitems.GetQuantity());
                      
                        return productitems;
                    }
                }
                ShoppingCartItem productitem = new ShoppingCartItem(prod, quantity);
                Products.Add(productitem);
                return productitem;
            
            
               // changed the shopping cart to be the same as the store
            
            
        }
        //////////////////////////////////////////////////////////
      
        ///////////////////////////////////////////////////////////////////////////////////////
        public ShoppingCartItem RemoveProduct(int id, int quantity)
        {
            if (quantity == 0) // to check if there are any items to remove
            {
                return null;
            }



            foreach (var productitems in Products)
            {
                if(productitems.GetProduct().GetId() == id)
                {
                    int testvalue = productitems.GetQuantity() - quantity;
                    if (testvalue <= 0) 
                    {
                        Products.Remove(productitems);
                        return new ShoppingCartItem(null, 0);
                    }
                    else if(testvalue > 0)
                    {
                        productitems.SetQuantity(testvalue);
                        return productitems;
                    }
                    else
                    {
                        return null;
                    } // lets see if this one works ??
                }
                /*
                productitems.SetQuantity(0);
                //Products.Remove(productitem);
                return productitems;
                */
            }
            /*
            else if (quantity > 0)
            {
                foreach (ShoppingCartItem productitem in Products)
                {
                    productitem.SetQuantity(productitem.GetQuantity() - quantity);
                    return productitem;
                }
            }*/

            return null;

        }

        public ShoppingCartItem GetProductById(int id)
        {
            if (id < 0)
            {
                throw new Exception("error");
            }
            var prodid =
                from product in Products
                where product.GetProduct().GetId() == id
                select product;
            foreach (var item in prodid)
            {
                if (Products == null)
                {
                    return null;
                }
                else
                {
                    return item;
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
            var total =
                from money in Products
                let amountequal = money.GetProduct().GetPrice() * money.GetQuantity()
                select new { amountequal };

            decimal testTotal = 0;
            foreach (var item in total) 
            {
                testTotal = testTotal + item.amountequal;
            }
            return testTotal;
            /*
            foreach (ShoppingCartItem productitem in Products)
            {
                total += productitem.GetTotal();
                
            }
            return total;
            */
        }

        ///////////////////////////////////////////////////////////////////////////////////////
        public List<ShoppingCartItem> GetProducts()
        {
            return Products;

        }
        //////////////////////////////////////////////////////////
    }

}


/*
    foreach (ShoppingCartItem productitem in Products)
    {
        if (productitem.GetProduct().GetId() == id)// gets the type of product and the id to see if it equals id
        {
            return productitem;
        }
        return null;

    }

}//if cant get the product id returns nothing
return null;
}*/
/*
 public StoreItem FindStoreItemById(int id)
{
    if(id < 0)
    {
        throw new Exception("id is less than 0 which cannot happen. error");
    }
    var itemid = // linq to find where item is.
        from item in items
        where item.GetProduct().GetId() ==id
        select item;
    foreach(var item in itemid)
    {
        if (item ==null)
        {
            return null; // if item is == to null make it null.

        }
        else
        {
            return item;
        }
    }
    return null; // all paths return 
*/