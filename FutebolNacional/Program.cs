using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace FutebolNacional
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            // Alternativa mais profissional:
            builder.Services.AddHttpClient("BrasileiraoAPI", client => {
                client.BaseAddress = new Uri("http://localhost:8080/");
            });

            await builder.Build().RunAsync();
        }
    }
}
