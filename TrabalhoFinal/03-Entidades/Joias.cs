using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoFinal._03_Entidades;
[Table("Joias")]
public class Joias
{
    public int ID { get; set; }
    public string Nome { get; set; }
    public string Tipo { get; set; }
    public double Preco { get; set; }
    public int Quantidade { get; set; }
    public int Estoque { get; set; }
    public object Valor { get; set; }
}
