using System;
using System.Linq;
using System.Collections.Generic;
using System.Linq.Expressions;

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
        /*
        public StoreItem GetStoreItem(StoreItem items)
        {
            return items;
        }// I think i need this somehow
        */

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

            //bool listchecker = false;
            if (prod == null || quantity < 0)
            {
                return null;
            }
            foreach (var item in items)
            {
                if (item.GetProduct() == prod)
                {
                    item.SetQuantity(item.GetQuantity() + quantity);
                    return item;
                }
            }
            StoreItem addedItem = new StoreItem(prod, quantity);
            items.Add(addedItem);
            return addedItem;
        }  

            /*
            if (quantity <= 0) // if item doesn't exist, it will return null
            {
                return null;
            }
            var CheckForItem = FindStoreItemById(prod.GetId);
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

            */
        public StoreItem RemoveStoreItem(int id, int quantity)
        {
            if (quantity <= 0) // to check if there are any items to remove
            {
                throw new Exception("error");
            }
            var notitem =
                from item in items
                where item.GetProduct().GetId() == id
                let getrid = item.GetQuantity() - quantity
                select new { item, getrid };
            if (notitem.First().getrid <= 0)
            {
                noitem.First().item.SetQuantity(0);
                return noitem.First().item;

            }
            foreach (var item notitem)
            {
                if (item.getrid > 0)
                {

                }
            }
            /*
       foreach (var item in items)
       {
           item.SetQuantity(0);
           return item;
       }
   }
   else if (quantity > 0)
   {
       foreach (StoreItem item in items)
       {

           //if(item.GetProduct.GetId() == id)
           item.SetQuantity(item.GetQuantity() - quantity);
           return item;
       }
   }
       */
            return null;
        }
           
        
        public List<StoreItem> GetStoreItems()
        {
            return items;

        }

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
            /*
            foreach(StoreItem item in items)
            {
                if (item.GetProduct().GetId() == id)
                {
                    return item;
                }
                else
                {
                    return null; // returns null 
                }
            }
            return null;
            */
         
        }
    }
}


















 //   the world revolving 