using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoFinal._03_Entidades;

namespace TrabalhoFinal._02_Repository
{
    public class CarrinhoRepository
    {
        private readonly string ConnectionString;
        public CarrinhoRepository(string s)
        {
            ConnectionString = s;
        }

        public void Adicionar(Cadastro c)
        {
            using var connnection = new SQLiteConnection(ConnectionString);
            object value = connnection.Insert<Cadastro>(c);
        }

        public void Remover(int id)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            Cadastro novoCliente = BuscarPorId(id);
            connection.Delete<Cadastro>(novoCliente);
        }

        public List<Cadastro> Listar()
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.GetAll<Cadastro>().ToList();
        }
        public Cadastro BuscarPorId(int id)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.Get<Cadastro>(id);
        }

        public void Editar(int id, Cadastro c)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            connection.Update<Cadastro>(c);
        }


    }
}
