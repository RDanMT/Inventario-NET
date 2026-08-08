namespace Inventario.Models;

// Estado del producto en el inventario.
public enum EstadoProducto
{
    //Producto disponible para venta.
    Activo,
    
    //Producto temporalmente no disponible.
    Inactivo,
    
    //Producto que ya no se vende.
    Descontinuado
}