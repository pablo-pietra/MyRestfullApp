using MyResftfullApp.Models;
using System.Collections.Generic;

namespace MyResftfullApp.Services.UsuarioService
{
    public interface IUsuarioService
    {
        List<Usuario> ObtenerUsuarios();

        void AgregarUsuario(Usuario usuario);

        void ModificarUsuario(Usuario usuario);

        void EliminarUsuario(Usuario usuario);  
    }
}