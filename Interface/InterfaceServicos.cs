using System.Data;
using Formulario.Model;

namespace Formulario.Interface
{
    public interface InterfaceServicos
    {
        void Adicionar(ModelServicos servicos);
        void Atualizar(ModelServicos servicos);
        void Deletar(int id);
        DataTable ListarTodos();
    }
}
