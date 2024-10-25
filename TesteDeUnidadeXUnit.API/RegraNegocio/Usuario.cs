namespace TesteDeUnidadeXUnit.API.RegraNegocio
{
    public interface IUsuarioRepositorio
    {
        Usuario ConsultarPorId(int id);
        void Salvar(Usuario usuario);
    }

    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
    }

    public class UsuarioService
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;

        public UsuarioService(IUsuarioRepositorio usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
        }

        public bool UsuarioEncontrado(int id)
        {
            var usuario = _usuarioRepositorio.ConsultarPorId(id);
            return usuario != null;
        }

        public void Salvar(Usuario usuario) 
        {
            _usuarioRepositorio.Salvar(usuario);
        }
    }
}
