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
        [HttpPost("adicionar-cadastro")]
        public void Adicionar(CreateClienteDTO createJoiaDTO)
        {
           Cadastro c = _mapper.Map<Cadastro>(createJoiaDTO);
            _service.Adicionar(c);
        }
        [HttpGet("listar-cadastro")]
        public List<Cadastro> Listar()
        {
            return _service.Listar();
        }
        [HttpPut("editar-cadastro")]
        public void Editar(int id, Cadastro j)
        {
            _service.Editar(id, j);
        }
        [HttpDelete("deletar-cadastro")]
        public void Deletar(int id)
        {
            _service.Remover(id);
        }
    }

}
