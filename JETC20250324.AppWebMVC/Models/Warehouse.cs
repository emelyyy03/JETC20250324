using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace JETC20250324.AppWebMVC.Models;

public partial class Warehouse
{
    public int Id { get; set; }

    [Required(ErrorMessage = "El nombre es obligatorio.")]
    [Display(Name = "Nombre")]
    public string WarehouseName { get; set; } = null!;

    [Display(Name = "Notas")]
    public string? Notes { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
