using Examen_Final_Programacion;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using System.Threading.Tasks;

namespace InventarioDispositivosBlazor
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            await builder.Build().RunAsync();
        }
    }
}
