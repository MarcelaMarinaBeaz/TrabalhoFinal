using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoFinal._02_Repository;
using TrabalhoFinal._03_Entidades;

namespace TrabalhoFinal._01_Services;

public class JoiaService
{
    public JoiaRepository repository { get; set; }

    public JoiaService(string _config)
    {
        repository = new JoiaRepository(_config);
    }

    public void Adicionar(Joias i)
    {
        repository.Adicionar(i);
    }
    public void Remover(int id)
    {
        Joias i = BuscarIId(id);
        repository.Remover(i.ID);
    }
    public Joias BuscarIId(int id)
    {
        return repository.BuscarId(id);
    }
    public void Editar(int id, Joias i)
    {
        repository.Editar(id, i);
    }
    public List<Joias> Listar()
    {
        return repository.Listarr();
    }
}

