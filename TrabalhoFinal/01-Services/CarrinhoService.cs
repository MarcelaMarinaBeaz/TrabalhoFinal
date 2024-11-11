using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoFinal._02_Repository;
using TrabalhoFinal._03_Entidades;

namespace TrabalhoFinal._01_Services
{
    public class CarrinhoService
    {
        public CarrinhoRepository repository { get; set; }

        public CarrinhoService(string _config)
        {
            repository = new CarrinhoRepository(_config);
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
}
