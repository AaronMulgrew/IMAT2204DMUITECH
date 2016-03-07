using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyClassLibrary
{
    public class clsServiceOrderCollection
    {
        //private data member for allorders list
        public List<clsServiceOrder> allOrders;

        public int Count
        {
            get
            {
             //return count property of private list
                return allOrders.Count;
            }
             set
             {
                //   
             }
        }

        //public property for all orders
        public List<clsServiceOrder> AllOrders
        {
            //getter sends data to requesting code
            get
            {
                //return private data memeber
                return allOrders;
            }
            //setter accepts data from other objects
            set
            {
                //assign incoming value to the private data memeber
                allOrders = value;
            }
        }
    }
}
