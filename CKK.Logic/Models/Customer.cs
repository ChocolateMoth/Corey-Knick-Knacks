
using System;
using System.Linq;
using System.Collections.Generic;
using CKK.Logic.CKK.Logic.Interfaces;

namespace CKK.Logic.Models
{
    public class Customer :Entity
    {
        private int _id;
        private string _name;
        private string _address;

       
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

        public string GetAddress()
        {
            return _address;
        }

        public void SetAddress(string address)
        {
             _address = address;
        }

        
           
        

    }
}
