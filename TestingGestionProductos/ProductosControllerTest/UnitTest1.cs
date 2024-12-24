using Xunit;

namespace ProductosControllerTest
{
    public class UnitTest1
    {
        [Fact]
        public void ProductoConPrecioNegativo_DeberiaRetornarError()
        {
            // Configurar
            var producto = new Producto { Nombre = "Prueba", Precio = -10 };

            // Validar
            Assert.True(producto.Precio >= 0, "El precio no puede ser negativo.");
        }
    }
}