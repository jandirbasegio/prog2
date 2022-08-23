using System;
using System.Collections.Generic;
using System.Text;

namespace SisVet.Model
{
    public class Veterinario
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public int Crv { get; set; }

        public int Telefone { get; set; }

        public string Email { get; set; }

        public Endereco EnderecoId { get; set; }
    }
}
