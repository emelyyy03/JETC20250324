using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JETC20250324.AppWebMVC.Models;

public partial class User
{
    public int Id { get; set; }

    [Required(ErrorMessage = "El nombre es obligatorio.")]
    [Display(Name = "Nombre")]
    public string Username { get; set; } = null!;

    [Required(ErrorMessage = "El correo es obligatorio.")]
    [EmailAddress(ErrorMessage = "El correo electrónico no tiene un formato válido.")]
    [Display(Name = "Correo electronico")]
    public string Email { get; set; } = null!;

    [DataType(DataType.Password)]
    [StringLength(40, MinimumLength = 5, ErrorMessage = "El passowrd debe tener entre 5 y 50 caracteres.")]
    [Required(ErrorMessage = "La contraseña es obligatoria.")]
    [Display(Name = "Contraseña")]
    public string Password { get; set; } = null!;

    [Required(ErrorMessage = "El rol es obligatorio.")]
    [Display(Name = "Rol")]
    public string Role { get; set; } = null!;

    public string? Notes { get; set; }

    [NotMapped]
    [StringLength(40, MinimumLength = 5, ErrorMessage = "El password debe tener entre 5 y 50 caracteres.")]
    [Display(Name = "Confirmar Password")]
    [DataType(DataType.Password)]
    [Compare("Password", ErrorMessage = "Las contraseñas no coinciden.")]
    public string? ConfirmarPassword { get; set; } = null!;
}
