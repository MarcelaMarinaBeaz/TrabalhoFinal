﻿using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoFinal._03_Entidades;

namespace TrabalhoFinal._02_Repository;

public class JoiaRepository
{

    private readonly string ConnectionString;
    public JoiaRepository(string s)
    {
        ConnectionString = s;
    }

    public JoiaRepository()
    {
    }

    public void Adicionar(Joias l)
    {
        using var connnection = new SQLiteConnection(ConnectionString);
        connnection.Insert<Joias>(l);
    }

    public void Remover(int id)
    {
        using var connection = new SQLiteConnection(ConnectionString);
        Joias novoLivro = BuscarId(id);
        connection.Delete<Joias>(novoLivro);
    }

    public List<Joias> Listar()
    {
        using var connection = new SQLiteConnection(ConnectionString);
        return connection.GetAll<Joias>().ToList();
    }

    public void Editar(int id, Joias l)
    {
        using var connection = new SQLiteConnection(ConnectionString);
        connection.Update<Joias>(l);
    }

    public Joias BuscarId(int id)
    {
        using var connection = new SQLiteConnection(ConnectionString);
        return connection.Get<Joias>(id);
    }



    internal List<Joias> Listarr()
    {
        throw new NotImplementedException();
    }
}

