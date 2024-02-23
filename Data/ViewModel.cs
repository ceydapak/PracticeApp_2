using PracticeApp3.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeApp3.Data
{
    internal class ViewModel
    {
        public ObservableCollection<Current> Currents { get; set; }
        public ObservableCollection<Order> Orders { get; set; }
        public ObservableCollection<OrderItem> OrderItems { get; set; }

        public ViewModel() {
            Currents = new ObservableCollection<Current>()
            { new Current()
            {
                CurrentCode="1",
                CurrentName= "1-Current"
            }, new Current()
            {
                CurrentCode ="2",
                CurrentName= "2-Current"
            }, new Current()
            {
                CurrentCode= "3",
                CurrentName = "3-Current"
            }};

            Orders = new ObservableCollection<Order>() {new Order()
            {
                CurrentCode="1",
                OrderId = "1.1"

            },new Order(){

                CurrentCode="1",
                OrderId = "1.2"


            },new Order(){

                CurrentCode="2",
                OrderId = "2.1"


            },new Order(){

                CurrentCode="3",
                OrderId = "3.1"


            },new Order(){

                CurrentCode="3",
                OrderId = "3.2"


            },new Order(){

                CurrentCode="3",
                OrderId = "3.3"

            }};

            OrderItems = new ObservableCollection<OrderItem>() {
                new OrderItem() {  OrderId="1.1", DocumentSerialNumber="1-Document"},

                new OrderItem() {  OrderId="1.1", DocumentSerialNumber="2-Document"},

                new OrderItem() {  OrderId="2.1", DocumentSerialNumber="1- Document"},

                new OrderItem() {  OrderId="2.1", DocumentSerialNumber="2- Document"},

                new OrderItem() {  OrderId="3.1", DocumentSerialNumber="1- Document"},

                new OrderItem() {  OrderId="3.3", DocumentSerialNumber="2- Document"}

            };

        }

        
    }
}
