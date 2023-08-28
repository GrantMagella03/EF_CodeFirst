using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CodeFirst.Models {
    public class Order {
        public int ID { get; set; }//Primary key
        public DateTime Date { get; set; } = DateTime.Now;
        [StringLength(80)]public string Description { get; set; } = string.Empty;
        [StringLength(30)]public string Status { get; set; } = "NEW";
        [Column(TypeName = "decimal(11,2)")]public decimal Total { get; set; } = 0;

        public int CustomerID { get; set; }//Foreign Key
        public virtual Customer? Customer { get; set; } = null;//needed for FK


    }
}
