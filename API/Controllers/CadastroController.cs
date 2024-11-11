using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TrabalhoFinal._01_Services;
using TrabalhoFinal._03_Entidades.DTOs.Joia;
using TrabalhoFinal._03_Entidades;

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
        [HttpPost("adicionar-Joia")]
        public void Adicionar(CreateJoiaDTO createJoiaDTO)
        {
            Joias j = _mapper.Map<Cadastro>(createJoiaDTO);
            _service.Adicionar(j);
        }
        [HttpGet("listar-joia")]
        public List<Cadastro> Listar()
        {
            return _service.Listar();
        }
        [HttpPut("editar-joia")]
        public void Editar(int id, Joias j)
        {
            _service.Editar(id, j);
        }
        [HttpDelete("deletar-joia")]
        public void Deletar(int id)
        {
            _service.Remover(id);
        }
    }

}
