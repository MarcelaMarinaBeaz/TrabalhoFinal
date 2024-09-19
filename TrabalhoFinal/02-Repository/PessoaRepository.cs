using Dapper.Contrib.Extensions;
using System.Data.SQLite;
using TrabalhoFinal._03_Entidades;

namespace TrabalhoFinal._02_Repository;

public class PessoaRepository
{
    private readonly string ConnectionString;

    public PessoaRepository(string config)
    {
        ConnectionString = config;
    }


    public void Adicionar(Pessoa p)
    {
        using var connnection = new SQLiteConnection(ConnectionString);
        connnection.Insert<Pessoa>(p);
    }

    public void Remover(int id)
    {
        using var connection = new SQLiteConnection(ConnectionString);
        Pessoa novaJoias = BuscarId(id);
        connection.Delete<Pessoa>(novaJoias);
    }

    public List<Pessoa> Listar()
    {
        using var connection = new SQLiteConnection(ConnectionString);
        return connection.GetAll<Pessoa>().ToList();
    }
   // public List<Pessoa> BuscarPorId(int id, System.Data.IDbConnection connection)
   // {
     //   using var connection = new SQLiteConnection(ConnectionString);
     //   return connection.Get<Pessoa>(id);
  //  }

    public void Editar(int id, Pessoa p)
    {
        using var connection = new SQLiteConnection(ConnectionString);
        connection.Update<Pessoa>(p);
    }

    public Pessoa BuscarId(int id)
    {
        using var connection = new SQLiteConnection(ConnectionString);
        return connection.Get<Pessoa>(id);
    }



}

