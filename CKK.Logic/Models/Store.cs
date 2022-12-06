using System;
using System.Linq;
using System.Collections.Generic;


namespace CKK.Logic.Models
{
    public class Store
    {
        private int _id;
        private string _name;
        private List<StoreItem> items = new List<StoreItem>();
        
      
        //items.Add(Product _product1);
        //private Product _product2;
        //private Product _product3;

        
        public int GetId()
        {
            return _id;
        }
        public void SetId(int id)
        {
            _id = id;
        }
        public string GetName()
        {
            return _name;
        }
        public void SetName(string name)
        {
            _name = name;
        }


        public StoreItem AddStoreItem(Product prod, int quantity)
        {
            if(quantity < 0)
            {
                return null;
            }
            // needs for each? 
            foreach(StoreItem amount in items)
            {
                if (amount.SetQuantity(quantity + amount.GetQuantity)) ;
            }

            /*
            if (quantity > 0)
            {
                throw new ArgumentOutOfRangeException("already exist");


            }
            else if(quantity < 0 || prod == null)
            {

            }
            */


             
            /*
                
            */


        }
        public static StoreItem RemoveStoreItem(int id, int quantity)
        {
            if (quantity <= 0) // to check if there are any items to remove
            {
                var returnToZero =
                    
                
                return quantity = 0;
                
            }
            else
            {
                return StoreItem;
            }
            
            /* 
              Removes a product from  the desired product
If there are no products, does nothing
If product is out of range, does nothing
It should not shift/move items up in the list when things are removed
            */


        }
        public List<StoreItem> GetStoreItem()
        {
            return items;

        }
            /*
             if (StoreItem == 1)
            {
                return StoreItem;
            }
            else if (productNumber == 2)
            {
                return _product2;
            }
            else if (productNumber == 3)
            {
                return _product3;
            }
            else
            {
                return null;
            }
            */


            /* 
            This is different from the FindById. This method gets the product by its position (product1, product2, or product3).
Should return correct product
If it is an invalid productNumber, then it will return null
If there is not an item in the desired spot, it will return null
            */

        
        public StoreItem FindStoreItemById(int id)
        {
            
            // is that all ? man that was more difficult because I didn't realize that it would be all if and else if.
        }
        /*
         This will return the product that has the same Id (if there is one)
If there are no items with that id, then it should return null
If there are more than one item with that Id, then it will return the first one
        */
    }
}