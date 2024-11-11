using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoFinal._02_Repository;
using TrabalhoFinal._03_Entidades;
using TrabalhoFinal._03_Entidades.DTOs;

namespace TrabalhoFinal._01_Services;

public class CarrinhoService
{

    public ClienteRepository repository { get; set; }

    public CarrinhoService(string _config)
    {
        repository = new ClienteRepository(_config);
    }

    public void Adicionar(Carrinho i)
    {
        repository.Adicionar(i);
    }
    public void Remover(int id)
    {
        Carrinho i = BuscarIId(id);
        repository.Remover(i.id);
    }
    public Carrinho BuscarIId(int id)
    {
        return repository.BuscarPorId(id);
    }
    public void Editar(int id, Carrinho i)
    {
        repository.Editar(id, i);
    }
    public List<Carrinho> Listar()
    {
        return repository.Listar();
    }
   
}
