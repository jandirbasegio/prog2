using System;
using System.Collections.Generic;
using System.Text;

namespace SisVet.Model
{
    public class Clinica

    {
        public int Id { get; set; }

        public String Nome { get; set; }

        public int  Telefone { get; set; }

        public String Email { get; set; }

        public Endereco EnderecoId { get; set; }

    }
}
