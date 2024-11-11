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
        [HttpPost("adicionar-cliente")]
        public void AdicionarCliente(CreateClienteDTO cDTO)
        {
            Carrinho cliente = _mapper.Map<Carrinho>(cDTO);
            _service.Adicionar(cliente);
        }
        [HttpGet("listar-cliente")]
        public List<Carrinho> ListarCliente()
        {
            return _service.Listar();
        }
        [HttpPut("editar-cliente")]
        public void EditarCliente(int id, Carrinho c)
        {
            _service.Editar(id, c);
        }
        [HttpDelete("deletar-cliente")]
        public void DeletarCliente(int id)
        {
            _service.Remover(id);
        }
    }
}
