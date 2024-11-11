using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TrabalhoFinal._01_Services;
using TrabalhoFinal._03_Entidades.DTOs;
using TrabalhoFinal._03_Entidades;
using TrabalhoFinal._03_Entidades.DTOs.Joia;

namespace API.Controllers;


[ApiController]
[Route("[controller]")]
public class JoiaController : ControllerBase
{
    private readonly CadastroService _service;
    private readonly IMapper _mapper;
    public JoiaController(IConfiguration config, IMapper mapper)
    {
        string _config = config.GetConnectionString("DefaultConnection");
        _service = new CadastroService(_config);
        _mapper = mapper;
    }
    [HttpPost("adicionar-Joia")]
    public void Adicionar(CreateJoiaDTO createJoiaDTO)
    {
        Joias j = _mapper.Map<Joias>(createJoiaDTO);
        _service.Adicionar(j);
    }
    [HttpGet("listar-joia")]
    public List<Joias> Listar()
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
