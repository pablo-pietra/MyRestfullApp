using MyResftfullApp.Services.MonedaService.Moneda.Strategy;

namespace MyResftfullApp.Services.MonedaService
{
    public class MonedaService : IMonedaService
    {
        public string ObtenerCotizacion(IMoneda moneda)
        {
            return moneda.ObtenerCotizacion();
        }
    }
}