using Chapter.Interface;
using Chapter.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;

namespace Chapter.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioRepository _iusuarioRepository;

        public UsuarioController(IUsuarioRepository iusuarioRepository)
        {
            _iusuarioRepository = iusuarioRepository;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Listar()
        {
            try
            {
                return Ok(_iusuarioRepository.Listar());
            } catch (Exception)
            {
                throw;
            }

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]

        public IActionResult BuscarPorId(int id)
        {
            try
            {
                Usuario usuarioEncontrado = _iusuarioRepository.BuscarPorId(id);

                if (usuarioEncontrado == null)
                    return NotFound();
                return Ok(usuarioEncontrado);
            } catch (Exception)
            {
                throw;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns></returns>
        [HttpPost]

        public IActionResult Cadastrar(Usuario usuario)
        {
            try
            {
                _iusuarioRepository.Cadastrar(usuario);

                return StatusCode(201);
            } catch (Exception)
            {
                throw;
            }
        }

        [HttpPut("{id}")]

        public IActionResult Alterar(int id, Usuario usuario)
        {
            try
            {
                _iusuarioRepository.Atualizar(id, usuario);

                return Ok("usuario alterado");
            }catch (Exception){
                throw;
            }
        }

        [HttpDelete("{id}")]

        public IActionResult Deletar(int id)
        {
            try
            {
                _iusuarioRepository.Deletar(id);

                return Ok("usuario deletado");
            }
            catch (Exception)
            {
                throw;
            }
        }



    }
}
