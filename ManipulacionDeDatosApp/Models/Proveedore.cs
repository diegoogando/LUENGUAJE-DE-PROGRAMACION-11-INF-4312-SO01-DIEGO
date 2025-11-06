using System;
using System.Collections.Generic;

namespace ManipulacionDeDatosApp.Models;

public partial class Proveedore
{
    public int ProveedorId { get; set; }

    public string? NombreProveedor { get; set; }

    public string? Direccion { get; set; }

    public string? Telefono { get; set; }

    public string? CorreoElectronico { get; set; }

    public virtual ICollection<Producto> Productos { get; set; } = new List<Producto>();
}
