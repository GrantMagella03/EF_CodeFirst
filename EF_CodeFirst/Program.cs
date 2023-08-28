using EF_CodeFirst.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace EF_CodeFirst {
    internal class Program {
        static void Main(string[] args) {
            var _con = new SalesContext();

            var order = _con.Orders.Include(x => x.OrderLines).ThenInclude(x => x.Item).Where(x => x.ID == 1);//works like joine clause

            /*
            var orders = from o in _con.Orders
                         join ol in _con.orderLines
                         on o.ID equals ol.OrderID
                         join i in _con.Items
                         on ol.ItemID equals i.ID
                         select new {
                             Order = o.ID,
                             o.Description,
                             product = i.Name,
                             ol.Quantity,
                             i.Price,
                             LineTotal = ol.Quantity*i.Price
                         };
            foreach (var i in orders.ToList()) {
                Console.WriteLine($"{i.Order}|{i.Description}|{i.product}|{i.Quantity}|{i.Price}|{i.LineTotal}");
            }
             */




            /*
            var orders = _con.Orders.ToList();
            foreach (var o in orders) {
                Console.WriteLine(o.ID);
            }*/
        }
    }
}