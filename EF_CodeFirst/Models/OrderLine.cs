using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace EF_CodeFirst.Models {
    public class OrderLine {
        public int ID { get; set; }
        public int Quantity { get; set; } = 1;

        public int OrderID { get; set; }
        [JsonIgnore]public virtual Order? Order { get; set; }
        
        public int ItemID { get; set; }
        public virtual Item? Item { get; set; }



    }
}
