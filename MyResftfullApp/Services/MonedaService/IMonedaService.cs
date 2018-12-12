using MyResftfullApp.Services.MonedaService.Moneda.Strategy;

namespace MyResftfullApp.Services.MonedaService
{
    public interface IMonedaService
    {
        string ObtenerCotizacion(IMoneda moneda);
    }
}