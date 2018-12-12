using MyResftfullApp.Models;
using System.Collections.Generic;
using MyResftfullApp.Repositories.Context;
using System.Linq;

namespace MyResftfullApp.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly MyContext _dbContext;

        public UsuarioRepository()
        {
            _dbContext = new MyContext();
        }

        public List<Usuario> ObtenerUsuarios()
        {
            return _dbContext.Usuarios.ToList();
        }

        public void AgregarUsuario(Usuario usuario)
        {
            _dbContext.Usuarios.Add(usuario);
            _dbContext.SaveChanges();
        }

        public void ModificarUsuario(Usuario usuario)
        {
            var result = _dbContext.Usuarios.SingleOrDefault(u => u.Id == usuario.Id);
            if (result != null)
            {
                result.Email = usuario.Email;
                result.Password = usuario.Password;

                _dbContext.SaveChanges();
            }
        }

        public void EliminarUsuario(Usuario usuario)
        {
            var result = _dbContext.Usuarios.SingleOrDefault(u => u.Id == usuario.Id);

            if (result != null)
            {
                _dbContext.Usuarios.Remove(result);

                _dbContext.SaveChanges();
            }
        }
    }
}