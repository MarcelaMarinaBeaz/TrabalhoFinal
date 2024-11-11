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
    public class CadastroRepository
    {
        private readonly string ConnectionString;
        public CadastroRepository(string s)
        {
            ConnectionString = s;
        }

        public void Adicionar(Carrinho c)
        {
            using var connnection = new SQLiteConnection(ConnectionString);
            object value = connnection.Insert<Carrinho>(c);
        }

        public void Remover(int id)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            Carrinho novoCliente = BuscarPorId(id);
            connection.Delete<Carrinho>(novoCliente);
        }

        public List<Carrinho> Listar()
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.GetAll<Carrinho>().ToList();
        }
        public Carrinho BuscarPorId(int id)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.Get<Carrinho>(id);
        }

        public void Editar(int id, Carrinho c)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            connection.Update<Carrinho>(c);
        }

    }
}
