using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TrabalhoFinal._01_Services;
using TrabalhoFinal._03_Entidades.DTOs.Joia;
using TrabalhoFinal._03_Entidades;
using TrabalhoFinal._03_Entidades.DTOs;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CadastroController : ControllerBase
    {
        private readonly CadastroService _service;
        private readonly IMapper _mapper;
        public CadastroController(IConfiguration config, IMapper mapper)
        {
            string _config = config.GetConnectionString("DefaultConnection");
            _service = new CadastroService(_config);
            _mapper = mapper;
        }
        /// <summary>
        /// Adiciona um cadastro db
        /// </summary>
        /// <param name="createJoiaDTO"></param>
        [HttpPost("adicionar-cadastro")]
        public void Adicionar(Cadastro createJoiaDTO)
        {
           Cadastro c = _mapper.Map<Cadastro>(createJoiaDTO);
            _service.Adicionar(c);
        }
        /// <summary>
        /// Lista um cadastro db
        /// </summary>
        /// <returns></returns>
        [HttpGet("listar-cadastro")]
        public List<Cadastro> Listar()
        {
            return _service.Listar();
        }
        /// <summary>
        /// Edita um cadastro db
        /// </summary>
        /// <param name="id"></param>
        /// <param name="j"></param>
        [HttpPut("editar-cadastro")]
        public void Editar(int id, Cadastro j)
        {
            _service.Editar(id, j);
        }
        /// <summary>
        /// deleta um cadastro db
        /// </summary>
        /// <param name="id"></param>
        [HttpDelete("deletar-cadastro")]
        public void Deletar(int id)
        {
            _service.Remover(id);
        }
    }

}
