using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Formulario.Model;

namespace Formulario.Interface
{
    public interface InterfaceClientes
    {
        void Adicionar(ModelClientes cliente);
        void Atualizar(ModelClientes cliente);
        void Deletar(int id);
        DataTable ListarTodos();

    }
}
