using System;
using System.Linq;
using System.Collections.Generic;


namespace CKK.Logic.Models
{
    public class Store
    {
        private int _id;
        private string _name;
        private static List<StoreItem> items { get; set; }

        public Store()
        {
            items = new List<StoreItem>();//constructor to prevent nullpoint..
        }


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


        public StoreItem AddStoreItem(Product prod, int quantity)// now returns all 
        {
            bool listchecker = false;
            if (quantity <= 0) // if item doesn't exist, it will return null
            {
                return null;
            }

            else if (quantity > 0)
            {
                foreach (StoreItem item in items)
                {
                    if (item.GetProduct() == prod)
                    {
                        item.SetQuantity(quantity + item.GetQuantity());
                        listchecker = true;
                        return item;
                    }
                }
            }
            if (listchecker == false)
            {
                StoreItem item = new StoreItem(prod, quantity);
                items.Add(item);
                return item;
            }
            else
            {
                return null;
            }
        }


        //if (amount.SetQuantity(quantity + amount.GetQuantity)) ;




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



        public static StoreItem RemoveStoreItem(int id, int quantity)
        {
            if (quantity <= 0) // to check if there are any items to remove
            {
                int b = 0;
                var returnToZero =
                    from e in quantity
                    where e > 0
                    select e;

                /*
                from e in items
                let zeroQuantity = e._quantity * b
                select new { zeroQuantity };

            foreach(var tEMMIE in )
            */
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
            if (_product1.GetId() == id)
            {
                return _product1;
            }
            else if (_product2.GetId() == id)
            {
                return _product2;
            }
            else if (_product3.GetId() == id)
            {
                return _product3;
            }
            else
            {
                return null;
            }
            /*
             This will return the product that has the same Id (if there is one)
    If there are no items with that id, then it should return null
    If there are more than one item with that Id, then it will return the first one
            */
        }
    }
}


















 //   the world revolving 