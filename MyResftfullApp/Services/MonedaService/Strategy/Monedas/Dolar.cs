using MyResftfullApp.Services.MonedaService.Moneda.Strategy;
using System.Net.Http;

namespace MyResftfullApp.Monedas
{
    public class Dolar : IMoneda
    {
        const string url = "http://www.bancoprovincia.com.ar/Principal/Dolar";

        public string ObtenerCotizacion()
        {
            var bancoProvincia = new HttpClient();

            return bancoProvincia.GetStringAsync(url).Result;
        }
    }
}