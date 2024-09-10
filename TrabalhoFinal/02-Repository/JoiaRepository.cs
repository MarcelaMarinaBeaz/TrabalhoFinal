using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoFinal._03_Entidades;

namespace TrabalhoFinal._02_Repository;

public class JoiaRepository
{

    private readonly string ConnectionString = "Data Source = Music.db";

    public IEnumerable<Joias> Joia { get; private set; }

    public void Adicionar(Joias i)
    {


        using (var connection = new SQLiteConnection(ConnectionString))
        {
            connection.Open();
            string commandoInsert = @"INSERT INTO Instrumento (ID, Nome, Tipo) VALUES(@Id, @Nome, @Tipo)";

            using (var command = new SQLiteCommand(commandoInsert, connection))
            {
                command.Parameters.AddWithValue("@Id", i.ID);
                command.Parameters.AddWithValue("@nome", i.Nome);
                command.Parameters.AddWithValue("@anocriacao", i.Tipo);
                command.ExecuteNonQuery();
            }
        }
    }

    public void Remover(Joias i)
    {
        using (var connection = new SQLiteConnection(ConnectionString))
        {
            connection.Open();
            string deleteCommand = @"DELETE FROM Instrumento WHERE id =@id";
            using (var command = new SQLiteCommand(deleteCommand, connection))
            {
                command.Parameters.AddWithValue("@id", i.ID);
                command.ExecuteNonQuery();
            }
        }
    }
    public Joias BuscarId(int id)
    {
        foreach (Joias t in Joia)
        {
            if (id == t.ID)
            {
                return t;
            }
        }
        return null;
    }
    public void Editar(int id, Joias i)
    {
        using (var connection = new SQLiteConnection(ConnectionString))
        {
            connection.Open();
            string updateCommand = @"UPDATE Instrumento SET nome = @nome, Estoque = @estoque
                                   WHERE id = @id";
            using (var command = new SQLiteCommand(updateCommand, connection))
            {
                command.Parameters.AddWithValue("@id", i.ID);
                command.Parameters.AddWithValue("@nome", i.Nome);
                command.Parameters.AddWithValue("@estoque", i.Tipo);
                command.ExecuteNonQuery();
            }
        }
    }
    public Joias Listarr(int id)
    {
        {
            List<Joias> i = new List<Joias>();
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                string selectCommand = "SELECT Id, Nome, Estoque,  FROM Instrumento;";
                using (var command = new SQLiteCommand(selectCommand, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Joias im = new Joias();
                            im.ID = int.Parse(reader["ID"].ToString());
                            im.Nome = reader["Nome"].ToString();
                            im.Tipo = string.(reader["Tipo"].ToString());
                            im.Add(i);
                        }
                    }
                }
            }
            return i;
        }
    }
}
