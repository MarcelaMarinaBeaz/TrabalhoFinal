using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoFinal._03_Entidades.DTOs
{
    public class CreateCadastroDTO
    {
        public int CadastroId { get; set; }
        public string CadastroNome { get; set; }
        public string CadastroEmail { get; set; }
        public string CadastroSenha { get; set; }
    }
}
