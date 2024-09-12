using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoFinal._03_Entidades.DTOs;

public class CreateClienteDTO
{
    public int id { get; set; }
    public string Nome { get; set; }
    public string Email { get; set; }
    public string Genero { get; set; }
}
