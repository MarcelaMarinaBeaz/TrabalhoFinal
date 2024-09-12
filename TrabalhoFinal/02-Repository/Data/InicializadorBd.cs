using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoFinal._02_Repository.Data
{
    public static class InicializadorBd
    {
        private const string ConnectionString = "Data Source=Rotina.db";

        public static void Inicializar()
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                string commandoSQL = @"   
                 CREATE TABLE IF NOT EXISTS Pessoas(
                 Id INTEGER PRIMARY KEY AUTOINCREMENT,
                 Nome TEXT NOT NULL,
                 DataNascimento TEXT NOT NULL
                );";
                commandoSQL += @"   
                 CREATE TABLE IF NOT EXISTS Cliente(
                 Id INTEGER PRIMARY KEY AUTOINCREMENT,
                 Nome TEXT NOT NULL,
                 Email TEXT NOT NULL,
                 Genero TEXT NOT NULL
                );";
                commandoSQL += @"   
                 CREATE TABLE IF NOT EXISTS Cadastro(
                 CadastroId INTEGER PRIMARY KEY AUTOINCREMENT,
                 CadastroNome TEXT NOT NULL,
                 CadastroEmail TEXT NOT NULL,
                 CadastroSenha TEXT NOT NULL
                );";
                using (var command = new SQLiteCommand(commandoSQL, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
