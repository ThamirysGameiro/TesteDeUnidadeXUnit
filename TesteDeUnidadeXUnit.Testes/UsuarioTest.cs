using Moq;
using TesteDeUnidadeXUnit.API.RegraNegocio;

namespace TesteDeUnidadeXUnit.Testes
{
    public class UsuarioTest
    {
        [Fact]
        public void Consultar_Usuario_Que_Existe()
        {
            var usuarioStub = new Mock<IUsuarioRepositorio>();
            var usuarioExistenteNoBanco = new Usuario { Id = 1, Nome = "Thamirys Gameiro",  Email = "thamy@thamy.com" };

            usuarioStub.Setup(repo => repo.ConsultarPorId(1)).Returns(usuarioExistenteNoBanco);

            var service = new UsuarioService(usuarioStub.Object);

            var usuario = service.UsuarioEncontrado(1);

            Assert.True(usuario);
        }

        [Fact]
        public void Consultar_Usuario_Que_Nao_Existe()
        {
            var usuarioStub = new Mock<IUsuarioRepositorio>();
            var usuarioExistenteNoBanco = new Usuario { Id = 1, Nome = "Thamirys Gameiro", Email = "thamy@thamy.com" };

            usuarioStub.Setup(repo => repo.ConsultarPorId(2)).Returns(usuarioExistenteNoBanco);

            var service = new UsuarioService(usuarioStub.Object);

            var usuario = service.UsuarioEncontrado(1);

            Assert.False(usuario);
        }

        [Fact]
        public void Verificar_Chamada_Gravacao()
        {
            var usuarioMock = new Mock<IUsuarioRepositorio>();
            var usuarioNovo = new Usuario { Id = 1, Nome = "Thamirys Gameiro", Email = "thamy@thamy.com" };

            var usuarioService = new UsuarioService(usuarioMock.Object);

            usuarioService.Salvar(usuarioNovo);

            usuarioMock.Verify(repo => repo.Salvar(It.Is<Usuario>(u => u.Id == usuarioNovo.Id && u.Nome == usuarioNovo.Nome && u.Email == usuarioNovo.Email)));
        }

    }
}
