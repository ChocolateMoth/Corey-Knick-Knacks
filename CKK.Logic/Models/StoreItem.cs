
using System;
using System.Linq;
using System.Collections.Generic;




namespace CKK.Logic.Models
{
    public class StoreItem
    {
        private Product _product { get; set; }
        private int _quantity;

        public StoreItem( Product product, int quantity)
        {
            _product = product;
            _quantity = quantity;
            //List<StoreItem> StoreItems = items;
        }
        public int GetQuantity()
        {
            return _quantity;
        }
        public void SetQuantity(int quantity)
        {
            _quantity = quantity;
        }
        
        public Product GetProduct()
        {
            return _product;
        }
        public void SetProduct(Product product)
        {
            _product = product;
        }
        
    }
}
