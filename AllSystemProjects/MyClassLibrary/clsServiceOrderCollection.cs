using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyClassLibrary
{
    

    public class clsServiceOrderCollection
    {

        //public constructor for the class
        //this constructor is a function that runs when class is created
        public clsServiceOrderCollection()
        {
            //create instance of data connection class
            clsDataConnection DB = new clsDataConnection();
            //execute stored procedure to get list of data
            DB.Execute("sproc_tblServiceOrder_SelectAll");
            //get count of records
            Int32 RecordCount = DB.Count;
            //Set up index for the loop
            Int32 Index = 0;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create instance of Service Order class
                clsServiceOrder AnOrder = new clsServiceOrder();
                //get service
                AnOrder.Service = DB.DataTable.Rows[Index]["Service"].ToString();
                //get primary key
                AnOrder.OrderNo = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderNo"]);
                //increment the index
                Index++;


                /* //create instance of order class to store an order
                 clsServiceOrder AnOrder = new clsServiceOrder();
                 //set service to 'Antivirus'
                 AnOrder.Service = "Antivirus";
                 //add the order to the private list of orders
                 allOrders.Add(AnOrder);
                 //re-initialise the AnOrder object to accept a new item
                 AnOrder = new clsServiceOrder();
                 //set the new service to 'Memory'
                 AnOrder.Service = "Memory";
                 //add second service to private list of orders
                 allOrders.Add(AnOrder);
                 //the private list now contains two orders*/
            }
        }

        //private data member for allOrders list
        public List<clsServiceOrder> allOrders;
        //public property for Count
       
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



        //public property of allOrders
        public List<clsServiceOrder> AllOrders
        {
            //getter sends data to requesting code
            get
            {
                //retuern proivate data memeberr
                return allOrders;
            }
            //setter accepts data from other objects
            set
            {
                //assign incoming value to private data member
                allOrders = value;
            }
        }
    }
}

