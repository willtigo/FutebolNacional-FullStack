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

            //// Alternativa mais profissional:
            builder.Services.AddHttpClient("BrasileiraoAPI", client =>
            {
                //client.BaseAddress = new Uri("http://192.168.0.21:8080/");
                client.BaseAddress = new Uri("https://wtsilva-001-site1.mtempurl.com/");
            });

            // 2. Adiciona o cliente padrão (sem nome) para a página que estava dando erro
            builder.Services.AddScoped(sp => new HttpClient
            {
                //BaseAddress = new Uri("http://192.168.0.21:8080/");
                BaseAddress = new Uri("https://wtsilva-001-site1.mtempurl.com/")
            });

            await builder.Build().RunAsync();
        }
    }
}
