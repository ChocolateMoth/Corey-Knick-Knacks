using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Models
{
    public class Store
    {
        private int _id;
        private string _name;
        private Product _product1;
        private Product _product2;
        private Product _product3;


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
        public Product AddStoreItem(Product prod)
        {
            Product[] available = { _product1, _product2, _product3 };
            

            return prod;
        }
        public int RemoveStoreItem(int productNumber)
        {

            return productNumber;
        }
        public int GetStoreItem(int productNumber)
        {
            var spot = 0;
            if()

            return productNumber;
        }
        public int FindStoreItemById(int id)
        {
            return id;
        }
    }
}
/*
  Product[] available = { _product1, _product2, _product3 };
            Array.Sort(available);
            
            if (productNumber <= placeholder)
            {
                return 0;
            }
            else if (productNumber <= placeholder2)
            {
                return 0;

            }
 * 
 * 
 * 
 * 
 * 