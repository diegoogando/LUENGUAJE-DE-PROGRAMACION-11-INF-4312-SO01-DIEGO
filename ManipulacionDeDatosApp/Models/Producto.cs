using System;
using System.Collections.Generic;

namespace ManipulacionDeDatosApp.Models;

public partial class Producto
{
    public int ProductoId { get; set; }

    public string? NombreProducto { get; set; }

    public decimal? Precio { get; set; }

    public int? CategoriaId { get; set; }

    public int? ProveedorId { get; set; }

    public virtual Categoria? Categoria { get; set; }

    public virtual Proveedore? Proveedor { get; set; }
}
