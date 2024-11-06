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

public class ClienteService
{

    public ClienteRepository repository { get; set; }

    public ClienteService(string _config)
    {
        repository = new ClienteRepository(_config);
    }

    public void Adicionar(Cliente i)
    {
        repository.Adicionar(i);
    }
    public void Remover(int id)
    {
        Cliente i = BuscarIId(id);
        repository.Remover(i.id);
    }
    public Cliente BuscarIId(int id)
    {
        return repository.BuscarPorId(id);
    }
    public void Editar(int id, Cliente i)
    {
        repository.Editar(id, i);
    }
    public List<Cliente> Listar()
    {
        return repository.Listar();
    }
   
}
