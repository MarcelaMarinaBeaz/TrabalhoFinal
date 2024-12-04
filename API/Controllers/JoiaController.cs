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
    private readonly JoiaService _service;
    private readonly IMapper _mapper;
    public JoiaController(IConfiguration config, IMapper mapper)
    {
        string _config = config.GetConnectionString("DefaultConnection");
        _service = new JoiaService(_config);
        _mapper = mapper;
    }
    /// <summary>
    /// Adiciona uma joia db
    /// </summary>
    /// <param name="createJoiaDTO"></param>
    [HttpPost("adicionar-Joia")]
    public void Adicionar(Joias createJoiaDTO)
    {
        Joias j = _mapper.Map<Joias>(createJoiaDTO);
        _service.Adicionar(j);
    }
    /// <summary>
    /// Lista uma joia db
    /// </summary>
    /// <returns></returns>
    [HttpGet("listar-joia")]
    public List<Joias> Listar()
    {
         return Listar();
    }
    /// <summary>
    /// Edita uma Joia db
    /// </summary>
    /// <param name="id"></param>
    /// <param name="j"></param>
    [HttpPut("editar-joia")]
    public void Editar(int id, Joias j)
    {
        _service.Editar(id, j);
    }
    /// <summary>
    /// Deleta uma joia db
    /// </summary>
    /// <param name="id"></param>
    [HttpDelete("deletar-joia")]
    public void Deletar(int id)
    {
        _service.Remover(id);
    }
}
