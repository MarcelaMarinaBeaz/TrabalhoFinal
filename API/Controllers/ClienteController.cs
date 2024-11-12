using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TrabalhoFinal._01_Services;
using TrabalhoFinal._03_Entidades;
using TrabalhoFinal._03_Entidades.DTOs;

namespace API.Controllers;

[ApiController]
[Route("[controller]")]
public class ClienteController : ControllerBase
{
    private readonly ClienteService _service;
    private readonly IMapper _mapper;
    public ClienteController(IConfiguration config, IMapper mapper)
    {
        string _config = config.GetConnectionString("DefaultConnection");
        _service = new ClienteService(_config);
        _mapper = mapper;
    }
    [HttpPost("adicionar-cliente")]
    public void AdicionarCliente(CreateClienteDTO cDTO)
    {
        Cadastro cliente = _mapper.Map<Cadastro>(cDTO);
        _service.Adicionar(cliente);
    }
    [HttpGet("listar-cliente")]
    public List<Cadastro> ListarCliente()
    {
        return _service.Listar();
    }
    [HttpPut("editar-cliente")]
    public void EditarCliente(int id, Cadastro c)
    {
        _service.Editar(id, c);
    }
    [HttpDelete("deletar-cliente")]
    public void DeletarCliente(int id)
    {
        _service.Remover(id);
    }
}
   

