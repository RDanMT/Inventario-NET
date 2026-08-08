namespace InventarioApp.Models;

/// Representa un proveedor (record - inmutable por defecto).
/// Ejemplo de cuándo usar record vs class.

public record Proveedor(
    int Id,
    string Nombre,
    string Email,
    string Telefono
);