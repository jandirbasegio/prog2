using System;
using System.Collections.Generic;
using SisVet.Model;

namespace SisVet.Repository
{
    public class ClienteRepository
    {
        public bool salvar(Cliente cliente)
        {
            return true;
        }

        public Cliente Retornar(int clienteId)
        {
            Cliente cliente = new Cliente();

            if (clienteId == 1)
            {
                cliente.Id = 1;
                cliente.Nome = "Jandir";
                cliente.Cpf = "123456789";
                cliente.Email = "jandirc.basegio@gmail.com";
                cliente.Telefone = "49991845290";
                cliente.EnderecoId = 1;
            }

            return cliente;
        }

        public List<Cliente> Retornar()
        {
            return new List<Cliente>();
        }
    }
}
