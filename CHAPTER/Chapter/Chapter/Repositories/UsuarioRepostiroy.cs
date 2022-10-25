using Chapter.Contexts;
using Chapter.Interface;
using Chapter.Models;

namespace Chapter.Repositories
{
    public class UsuarioRepostiroy : IUsuarioRepository
    {
        private readonly ChapterContext _chapterContext;

        public UsuarioRepostiroy(ChapterContext chapterContext)
        {
            _chapterContext = chapterContext;
        }

        public void Atualizar(int id, Usuario usuario)
        {
            Usuario usuarioEncontrado = _chapterContext.Usuarios.Find(id);

            if (usuarioEncontrado != null)
            {
                usuarioEncontrado.Email = usuario.Email;
                usuarioEncontrado.Senha = usuario.Senha;
                usuarioEncontrado.Tipo = usuario.Tipo;
                
                _chapterContext.Usuarios.Update(usuarioEncontrado);
                _chapterContext.SaveChanges();
            }
        }

        public Usuario BuscarPorId(int id)
        {
            return _chapterContext.Usuarios.Find(id);
        }

        public void Cadastrar (Usuario usuario)
        {
            _chapterContext.Usuarios.Add(usuario);
            _chapterContext.SaveChanges();
        }


        public void Deletar (int id)
        {
            Usuario usuarioEncontrado = _chapterContext.Usuarios.Find(id);
            _chapterContext.Usuarios.Remove(usuarioEncontrado);
            _chapterContext.SaveChanges();
        }

        public List<Usuario> Listar()
        {
            return _chapterContext.Usuarios.ToList();
        }

        public Usuario Login(string email, string senha)
        {
            return _chapterContext.Usuarios.FirstOrDefault(x => x.Email == email && x.Senha == senha);
        }



    }
}
