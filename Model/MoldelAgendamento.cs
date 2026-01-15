using System;
using System.Collections.Generic;
using System.Text;

namespace Formulario.Model
{
    public class MoldelAgendamento
    {
        public int Id { get; set; }
        public int Id_cliente { get; set; }
        public DateTime Dia_Horario { get; set; }
    }
}
