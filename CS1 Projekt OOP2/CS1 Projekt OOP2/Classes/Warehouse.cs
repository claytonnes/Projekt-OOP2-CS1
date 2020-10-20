﻿using CS1_Projekt_OOP2.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS1_Projekt_OOP2.Classes
{
    class Warehouse : IWarehouse
    {
        public List<Product> Products { get; set; }
        public List<Order> Orders { get; set; }
        public List<Customer> Customers { get; set; }

        public void AddNewCustomer(int id, string name, string phone, string email)
        {
            throw new NotImplementedException();
        }

        public void AddNewOrder(Customer customer, string deliveryAddress, List<OrderLine> orderLines, bool paymentCompleted)
        {
            Orders.Add(new Order(GenerateUniqueOrderNumber(), customer, deliveryAddress, orderLines, paymentCompleted));
        }

        public void AddNewProduct(int code, string name, double price, int stock)
        {
            throw new NotImplementedException();
        }

        //Metod för att uppfylla Order:3
        public void ProcessOrders()
        {
            IEnumerable<Order> readyForDisptach = Orders.Where(a => a.PaymentCompleted == true && a.Items.Any(o => o.Product.Stock < o.Count)).OrderBy(a => a.OrderDate);
            foreach(Order order in readyForDisptach)
            {
                order.Dispatched = true;
                AdjustStock(order.Items);
            }
        }

        public IEnumerable<Order> ReturnActiveOrders()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Order> ReturnActiveOrders(int customerID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Order> ReturnArchivedOrders()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Order> ReturnArchivedOrders(int customerID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Order> ReturnDispatchedOrders()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Order> ReturnPendingOrders()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> ReturnStockZero()
        {
            throw new NotImplementedException();
        }

        public void UpdateCustomerEmail(int id, string email)
        {
            throw new NotImplementedException();
        }

        public void UpdateCustomerInformation(int customerID)
        {
            throw new NotImplementedException();
        }

        public void UpdateCustomerName(int id, string name)
        {
            throw new NotImplementedException();
        }

        public void UpdateCustomerPhone(int id, string phone)
        {
            throw new NotImplementedException();
        }

        public void UpdateProductName(int code, string name)
        {
            throw new NotImplementedException();
        }

        public void UpdateProductPrice(int code, double price)
        {
            throw new NotImplementedException();
        }

        public void UpdateProductStock(int code, int stock)
        {
            throw new NotImplementedException();
        }

        //Checks the highest ordernumber amongst the orders and returns a new unique ordernumber (max+1)
        public int GenerateUniqueOrderNumber()
        {
            if (Orders.Count < 1)
                return 1;
            else
                return Orders.Max(a => a.Number)+1;
        }

        //Method called when dispatching items. Reduces stock (has already been checked if stock is enough) by the count of the OrderLine.
        public void AdjustStock(List<OrderLine> order)
        {
            foreach(OrderLine orderLine in order)
            {
                orderLine.Product.Stock -= orderLine.Count;
            }
        }
    }
}
