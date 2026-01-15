using Formulario.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Formulario.Interface
{
   public interface InterfaceAgendamento
    {
        void Adicionar(MoldelAgendamento agendamento);
        void Atualizar(MoldelAgendamento agendamento);
        void Deletar(int id);
        System.Data.DataTable ListarTodos();
    }
}
