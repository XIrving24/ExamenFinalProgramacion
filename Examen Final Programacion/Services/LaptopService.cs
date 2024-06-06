using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using InventarioDispositivos;

namespace InventarioDispositivosBlazor.Services
{
    public static class LaptopService
    {
        private static readonly string filePath = "wwwroot/laptops.json";

        public static async Task GuardarLaptop(Laptop laptop)
        {
            try
            {
                // Leer los datos existentes de laptops
                List<Laptop> laptops = await LeerLaptops();

                // Agregar la nueva laptop a la lista
                laptops.Add(laptop);

                // Serializar la lista de laptops a formato JSON
                string json = JsonSerializer.Serialize(laptops);

                // Escribir los datos en el archivo
                await File.WriteAllTextAsync(filePath, json);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al guardar la laptop: {ex.Message}");
                // Lanza la excepción para que pueda ser manejada en otro lugar si es necesario
                throw;
            }
        }

        public static async Task<List<Laptop>> LeerLaptops()
        {
            try
            {
                if (!File.Exists(filePath))
                {
                    return new List<Laptop>();
                }

                // Leer el contenido del archivo
                string json = await File.ReadAllTextAsync(filePath);

                // Deserializar el contenido a una lista de laptops
                return JsonSerializer.Deserialize<List<Laptop>>(json);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al leer los datos de laptops: {ex.Message}");
                // Lanza la excepción para que pueda ser manejada en otro lugar si es necesario
                throw;
            }
        }
    }
}
