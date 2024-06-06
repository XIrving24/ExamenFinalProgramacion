using System;
using System.Collections.Generic;

namespace InventarioDispositivos
{
    // Clase base Dispositivo
    public abstract class Dispositivo
    {
        public string NumeroDeSerie { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
    }

    // Clase Laptop que hereda de Dispositivo
    public class Laptop : Dispositivo
    {
        public int MemoriaRAM { get; set; } // en GB
        public int Almacenamiento { get; set; } // en GB
    }

    // Clase Smartphone que hereda de Dispositivo
    public class Smartphone : Dispositivo
    {
        public string SistemaOperativo { get; set; }
        public int NumeroDeCamaras { get; set; }
    }

    // Clase Tablet que hereda de Dispositivo
    public class Tablet : Dispositivo
    {
        public double TamanoDePantalla { get; set; } // en pulgadas
        public bool SoporteParaStylus { get; set; }
    }

    // Clase para manejar la lógica relacionada con los productos
    public static class ManejadorProductos
    {
        private static List<Dispositivo> productos = new List<Dispositivo>();

        // Método para guardar un producto
        public static void GuardarProducto(Dispositivo producto)
        {
            productos.Add(producto);
        }

        // Método para obtener la cantidad total de productos
        public static int ObtenerCantidadProductos()
        {
            return productos.Count;
        }

        // Método para obtener el listado completo de productos
        public static List<Dispositivo> ObtenerProductos()
        {
            return productos;
        }
    }
}
