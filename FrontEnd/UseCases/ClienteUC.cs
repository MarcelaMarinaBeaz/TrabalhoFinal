using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using TrabalhoFinal._03_Entidades;

namespace FrontEnd.UseCases
{
    public class ClienteUC
    {
        private readonly HttpClient _client;

        public ClienteUC(HttpClient cliente)
        {
            _client= cliente;
        }
        public List<Cliente> ListarCliente()
        {
            return _client.GetFromJsonAsync<List<Cliente>>("Cliente/listar-cliente").Result;
        }
        public void CadastrarCliente(Cliente cliente)
        {
            HttpResponseMessage response = _client.PostAsJsonAsync("", cliente).Result;
        }
    }
}
