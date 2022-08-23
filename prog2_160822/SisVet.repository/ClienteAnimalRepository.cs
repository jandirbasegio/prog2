using System;
using System.Collections.Generic;
using SisVet.Model;

namespace SisVet.Repository
{
    public class ClienteAnimalRepository
    {
        public bool Salvar(ClienteAnimal clienteAnimal)
        {
            return true;
        }

        public ClienteAnimal Retornar(int clienteAnimalId)
        {
            ClienteAnimal clienteAnimal = new ClienteAnimal();

            if (clienteAnimalId ==1)
            {
                clienteAnimal.Id = 1;
                clienteAnimal.ClienteId = 1;
                clienteAnimal.AnimalId = 1;
            }

            return clienteAnimal;
        }

        public List<ClienteAnimal> Retornar()
        {
            return new List<ClienteAnimal>();
        }  
    }
}
