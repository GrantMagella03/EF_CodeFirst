using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CodeFirst.Models {
    [Index("Code", IsUnique = true)]
    public class Customer {
        [Key] public int ID { get; set; }
        [StringLength(30)] public string Code { get; set; }
        [StringLength(30)] public string Name { get; set; }
        [Column(TypeName = "decimal(11,2)")] public decimal Sales { get; set; }
        public bool active { get; set; } = true;
    }
}
