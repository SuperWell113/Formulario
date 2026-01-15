using Formulario.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Formulario.Interface
{
    public interface InterfaceServicos
    {
        void Adicionar(ModelServicos Servicos);
        void Atualizar(ModelServicos servicos);
        void Deletar(int id);
        DataTable ListarTodos();

    }
}
