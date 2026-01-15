using System;
using System.Collections.Generic;
using System.Text;

namespace Formulario.Model
{
    public class ModelClientes
    {
        public int Id { get; set; }
        public string? Cliente { get; set; }
        public string? CPF { get; set; }
        public string? Contato { get; set; }
        public string? Email { get; set; }
        public string? CEP { get; set; }
        public string? Endereco { get; set; }
        public DateTime Datadenascimento { get; set; }
        public string? Ativo { get; set; }
    }
}
