using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoFinal._03_Entidades;

namespace TrabalhoFinal._02_Repository;

internal class ClienteRepository
{
    private readonly string ConnectionString;
    public ClienteRepository(string s)
    {
        ConnectionString = s;
    }

    public void Adicionar(Cliente c)
    {
        using var connnection = new SQLiteConnection(ConnectionString);
        object value = connnection.Insert<Cliente>(c);
    }

    public void Remover(int id)
    {
        using var connection = new SQLiteConnection(ConnectionString);
        Cliente novoCliente = BuscarPorId(id);
        connection.Delete<Cliente>(novoCliente);
    }

    public List<Cliente> Listar()
    {
        using var connection = new SQLiteConnection(ConnectionString);
        return connection.GetAll<Cliente>().ToList();
    }
    public Cliente BuscarPorId(int id)
    {
        using var connection = new SQLiteConnection(ConnectionString);
        return connection.Get<Cliente>(id);
    }

    public void Editar(int id, Cliente c)
    {
        using var connection = new SQLiteConnection(ConnectionString);
        connection.Update<Cliente>(c);
    }
}

