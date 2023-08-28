using EF_CodeFirst.Models;
using System.ComponentModel.DataAnnotations;

namespace EF_CodeFirst {
    internal class Program {
        static void Main(string[] args) {
            var _con = new SalesContext();
            var orders = _con.Orders.ToList();
            foreach (var o in orders) {
                Console.WriteLine(o.ID);
            }
        }
    }
}