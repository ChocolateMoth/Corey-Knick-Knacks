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


        public StoreItem RemoveStoreItem(int id, int quantity)
        {
            if (quantity <= 0) // to check if there are any items to remove
            {
                foreach (StoreItem item in items)
                {
                    item.SetQuantity(0);
                    return item;
                }
            }
            else if (quantity > 0)
            {
                foreach (StoreItem item in items)
                {
                    item.SetQuantity(item.GetQuantity() - quantity);
                    return item;
                }
            }
            return null;
        }
           
        
        public List<StoreItem> GetStoreItems()
        {
            return items;

        }

        public StoreItem FindStoreItemById(int id)
        {
            foreach(StoreItem item in items)
            {
                if (item.GetProduct().GetId() == id)
                {
                    return item;
                }
            }
            return null;
            
         
        }
    }
}


















 //   the world revolving 