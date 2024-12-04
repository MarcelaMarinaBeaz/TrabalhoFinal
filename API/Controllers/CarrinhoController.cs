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
        /// <summary>
        /// Adiciona algo a um carrinho db
        /// </summary>
        /// <param name="cDTO"></param>
        [HttpPost("adicionar-carrinho")]
        public void AdicionarCliente(Carrinho cDTO)
        {
            Carrinho cliente = _mapper.Map<Carrinho>(cDTO);
            _service.Adicionar(cliente);
        }
        /// <summary>
        /// Lista um carrinho db
        /// </summary>
        /// <returns></returns>
        [HttpGet("listar-carrinho")]
        public List<Carrinho> ListarCliente()
        {
            return _service.Listar();
        }
        /// <summary>
        /// Edita um carrinho db
        /// </summary>
        /// <param name="id"></param>
        /// <param name="c"></param>
        [HttpPut("editar-carrinho")]
        public void EditarCliente(int id, Carrinho c)
        {
            _service.Editar(id, c);
        }
        /// <summary>
        /// Deleta um carrinho db
        /// </summary>
        /// <param name="id"></param>
        [HttpDelete("deletar-carrinho")]
        public void DeletarCliente(int id)
        {
            _service.Remover(id);
        }
    }
}
