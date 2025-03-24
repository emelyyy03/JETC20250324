using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace JETC20250324.AppWebMVC.Models;

public partial class Product
{
    public int Id { get; set; }

    [Required(ErrorMessage = "El nombre de producto es obligatorio.")]
    [Display(Name = "Nombre de producto")]
    public string ProductName { get; set; } = null!;

    [Display(Name = "Descripcion")]
    public string? Description { get; set; }

    [Required(ErrorMessage = "El precio es obligatorio.")]
    [Range(typeof(decimal), "0.01", "99999999.99", ErrorMessage = "El precio debe estar entre 0.01 y 99999999.99")]
    [Display(Name = "Precio")]
    public decimal Price { get; set; }

    [Required(ErrorMessage = "El precio de compra es obligatorio.")]
    [Range(typeof(decimal), "0.01", "99999999.99", ErrorMessage = "El precio de compra debe estar entre 0.01 y 99999999.99")]
    [Display(Name = "Precio Compra")]
    public decimal PurchasePrice { get; set; }

    [Display(Name = "Bodega")]
    public int? WarehouseId { get; set; }

    [Display(Name = "Marca")]
    public int? BrandId { get; set; }

    public string? Notes { get; set; }

    public virtual Brand? Brand { get; set; }

    public virtual Warehouse? Warehouse { get; set; }
}
