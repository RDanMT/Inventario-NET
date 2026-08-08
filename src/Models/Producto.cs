namespace Inventario.Models;

// Representa un producto en el inventario.
// Incluye validación en setters (guard clauses).

// sIRve para representar un producto en el inventario, incluyendo su nombre, precio, cantidad, categoría, estado y fecha de registro. Además, proporciona validación en los setters para garantizar que los valores sean válidos.
public class Producto
{
    private string _nombre = "";
    private decimal _precio;
    private int _cantidad;

    public int Id { get; set; }

    // Nombre del producto.
    public string Nombre
    {
        get => _nombre;
        set
        {
            if (string.IsNullOrWhiteSpace(value)) // Validación: el nombre no puede estar vacío o ser solo espacios en blanco.
                throw new ArgumentException("El nombre no puede estar vacío."); // Guard clause para validar que el nombre no esté vacío.
            _nombre = value; // Asignación del valor al campo privado _nombre.
        }
    }

// Precio del producto.
    public decimal Precio
    {
        get => _precio; // Getter para obtener el precio del producto.
        set             // Setter para establecer el precio del producto.
        {
            if (value < 0)                                                      // Validación: el precio no puede ser negativo.
                throw new ArgumentException("El precio no puede ser negativo.");// Guard clause para validar que el precio no sea negativo.
            _precio = value;                                                    // Asignación del valor al campo privado _precio.
        }
    }
    
// Cantidad del producto en inventario.
    public int Cantidad
    {
        get => _cantidad;
        set
        {
            if (value < 0)
                throw new ArgumentException("La cantidad no puede ser negativa.");
            _cantidad = value;
        }
    }

    public CategoriaProducto Categoria { get; set; } = CategoriaProducto.Otros;
    public EstadoProducto Estado { get; set; } = EstadoProducto.Activo;
    public DateTime FechaRegistro { get; set; } = DateTime.Now;

 
 // Propiedad calculada: Precio × Cantidad
    
    public decimal ValorTotal => Precio * Cantidad;
}