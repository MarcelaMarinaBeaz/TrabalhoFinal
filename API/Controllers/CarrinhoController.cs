using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TrabalhoFinal._01_Services;
using TrabalhoFinal._03_Entidades.DTOs;
using TrabalhoFinal._03_Entidades;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarrinhoController : ControllerBase
    {
        private readonly CarrinhoService _service;
        private readonly IMapper _mapper;
        public CarrinhoController(IConfiguration config, IMapper mapper)
        {
            string _config = config.GetConnectionString("DefaultConnection");
            _service = new CarrinhoService(_config);
            _mapper = mapper;
        }
        [HttpPost("adicionar-carrinho")]
        public void AdicionarCliente(CreateClienteDTO cDTO)
        {
            Cadastro cliente = _mapper.Map<Cadastro>(cDTO);
            _service.Adicionar(cliente);
        }
        [HttpGet("listar-carrinho")]
        public List<Cadastro> ListarCliente()
        {
            return _service.Listar();
        }
        [HttpPut("editar-carrinho")]
        public void EditarCliente(int id, Cadastro c)
        {
            _service.Editar(id, c);
        }
        [HttpDelete("deletar-carrinho")]
        public void DeletarCliente(int id)
        {
            _service.Remover(id);
        }
    }
}
