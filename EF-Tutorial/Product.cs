using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Tutorial;

public class Product {

    public int Id { get; set; }
    public string PartNbr { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public string Unit { get; set; } = string.Empty;
    public string? PhotoPath { get; set; }

    public int VendorId { get; set; }
    public virtual Vendor? Vendor { get; set; }

}
