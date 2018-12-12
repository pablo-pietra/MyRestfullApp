using MyResftfullApp.Services.MonedaService.Moneda.Strategy;
using MyResftfullApp.Services.MonedaService;
using MyResftfullApp.Services.UsuarioService;
using MyResftfullApp.Models;
using System.Collections.Generic;
using System.Web.Http;
using System.Net;
using System;

namespace MyResftfullApp.Controllers
{
    public class MyResftfullAppController : ApiController
    {

        private readonly IMonedaService _monedaService;
        private readonly IUsuarioService _usuarioService;

        public MyResftfullAppController()
        {
            _monedaService = new MonedaService();
            _usuarioService = new UsuarioService();
        }

        [HttpGet]
        [Route("MyResftfullApp/Cotizacion/{moneda}")]
        public IHttpActionResult Cotizacion(string moneda)
        {
            try
            {
                var clase = string.Concat("MyResftfullApp.Monedas.", moneda);
                var tipoMoneda = Activator.CreateInstance(Type.GetType(clase)) as IMoneda;

                return Json(_monedaService.ObtenerCotizacion(tipoMoneda));
            }
            catch
            {
                throw new HttpResponseException(HttpStatusCode.Unauthorized);
            }
        }

        [HttpGet]
        [Route("MyResftfullApp/Usuarios")]
        public List<Usuario> ObtenerUsuarios()
        {
            return _usuarioService.ObtenerUsuarios();
        }

        [HttpPost]
        [Route("MyResftfullApp/Usuario")]
        public void AgregarUsuario([FromBody] Usuario usuario)
        {
            _usuarioService.AgregarUsuario(usuario);
        }

        [HttpPut]
        [Route("MyResftfullApp/Usuario")]
        public void ModificarUsuario([FromBody] Usuario usuario)
        {
            _usuarioService.ModificarUsuario(usuario);
        }

        [HttpDelete]
        [Route("MyResftfullApp/Usuario")]
        public void EliminarUsuario([FromBody] Usuario usuario)
        {
            _usuarioService.EliminarUsuario(usuario);
        }
    }
}