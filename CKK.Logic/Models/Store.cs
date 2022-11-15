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
            if(_product1 == null)
            {
                return _product1 = prod;
            }
            else if (_product2 == null)
            {
                return _product2 = prod;
            }
            else if (_product3 == null)
            {
                return _product3 = prod;
            }
            else
            {
                return prod;
            }
            /*    
            Adds a product to the next available product (product1, product2, product3).
If there is no available product, it will not add a product at all
If there is an item in spot two, but not spot one or three, then it should put the item in spot 1 (the next available spot) 
            */


        }
        public int RemoveStoreItem(int productNumber)
        {
            if(productNumber == 1)
            {
                return 0;
            }
            else if(productNumber == 2 )
            {
                return 0;
            }
            else if (productNumber == 3)
            {
                return 0;
            }
            else
            {
                return productNumber;
            }
            
            /* 
              Removes a product from  the desired product
If there are no products, does nothing
If product is out of range, does nothing
It should not shift/move items up in the list when things are removed
            */


        }
        public Product GetStoreItem(int productNumber)
        {
            if (productNumber == 1)
            {
                return _product1;
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


            /* 
            This is different from the FindById. This method gets the product by its position (product1, product2, or product3).
Should return correct product
If it is an invalid productNumber, then it will return null
If there is not an item in the desired spot, it will return null
            */

        }
        public Product FindStoreItemById(int id)
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
            }// is that all ? man that was more difficult because I didn't realize that it would be all if and else if.
        }
        /*
         This will return the product that has the same Id (if there is one)
If there are no items with that id, then it should return null
If there are more than one item with that Id, then it will return the first one
        */
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
 */