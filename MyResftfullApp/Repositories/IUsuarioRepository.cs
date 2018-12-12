using MyResftfullApp.Models;
using System.Collections.Generic;

namespace MyResftfullApp.Repositories
{
    public interface IUsuarioRepository
    {
        List<Usuario> ObtenerUsuarios();

        void AgregarUsuario(Usuario usuario);

        void ModificarUsuario(Usuario usuario);

        void EliminarUsuario(Usuario usuario);
    }
}