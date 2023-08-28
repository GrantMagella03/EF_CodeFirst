using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CodeFirst.Models {
        [Index("UPD", IsUnique = true)]
    public class Item {
        public int ID { get; set; }
        [StringLength(30)] public string UPD { get; set; } = string.Empty;
        [StringLength(30)] public string Name { get; set; } = string.Empty;
        [Column(TypeName = "decimal(11,2)")] public decimal Price { get; set; }
        public bool Active { get; set; } = true;

    }
}
