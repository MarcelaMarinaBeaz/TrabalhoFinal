using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoFinal._03_Entidades.DTOs;

public class CreateLoginDTO
{
    public int id { get; set; }
    public string Nome { get; set; }
    public string Email { get; set; }
    public int DataNascimento { get; set; }
    public string User { get; internal set; }
    public string Senha { get; internal set; }
}
