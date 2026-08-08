namespace Inventario.Repositories;

using Inventario.Models;

// Contrato para el repositorio de productos.
// Define las operaciones básicas de almacenamiento.

public interface IProductoRepository
{
    // Agrega un producto al repositorio.
    void Agregar(Producto producto);

    // Obtiene un producto por su ID.
    Producto? ObtenerPorId(int id);

    // Obtiene todos los productos.
    IEnumerable<Producto> ObtenerTodos();

    // Actualiza un producto existente.
    bool Actualizar(Producto producto);

    // Elimina un producto por su ID.
    bool Eliminar(int id);

    // Cantidad total de productos.
    int Cantidad { get; }
}