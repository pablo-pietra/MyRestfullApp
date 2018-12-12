using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyResftfullApp.Repositories;
using MyResftfullApp.Services.UsuarioService;
using MyResftfullApp.Models;
using System.Collections.Generic;
using Moq;

namespace MyResftfullAppTests
{
    [TestClass]
    public class UsuarioServiceTests
    {
        private readonly Mock<IUsuarioRepository> _usuarioRepository;

        private IUsuarioService _subject;

        public UsuarioServiceTests()
        {
            _subject = new UsuarioService();
            _usuarioRepository = new Mock<IUsuarioRepository>();
        }

        [TestMethod]
        public void DebeInvocarUsuarioRespositoryEnObtenerUsuarios()
        {
            //Arrange
            _usuarioRepository.Setup(x => x.ObtenerUsuarios()).Returns(new List<Usuario>());

            //Act
            _subject.ObtenerUsuarios();

            //Assert
            _usuarioRepository.Verify(x => x.ObtenerUsuarios(), Times.Once);
        }

        [TestMethod]
        public void DebeInvocarUsuarioRespositoryEnAgregarUsuario()
        {
            //Arrange
            var usuario = new Usuario();

            _usuarioRepository.Setup(x => x.AgregarUsuario(It.IsAny<Usuario>()));

            //Act
            _subject.AgregarUsuario(usuario);

            //Assert
            _usuarioRepository.Verify(x => x.AgregarUsuario(It.IsAny<Usuario>()), Times.Once);
        }

        [TestMethod]
        public void DebeInvocarUsuarioRespositoryEnModificarUsuario()
        {
            //Arrange
            var usuario = new Usuario();

            _usuarioRepository.Setup(x => x.ModificarUsuario(It.IsAny<Usuario>()));

            //Act
            _subject.ModificarUsuario(usuario);

            //Assert
            _usuarioRepository.Verify(x => x.ModificarUsuario(It.IsAny<Usuario>()), Times.Once);
        }

        [TestMethod]
        public void DebeInvocarUsuarioRespositoryEnEliminarUsuario()
        {
            //Arrange
            var usuario = new Usuario();

            _usuarioRepository.Setup(x => x.EliminarUsuario(It.IsAny<Usuario>()));

            //Act
            _subject.EliminarUsuario(usuario);

            //Assert
            _usuarioRepository.Verify(x => x.EliminarUsuario(It.IsAny<Usuario>()), Times.Once);
        }
    }
}
