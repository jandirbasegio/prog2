using System;
using System.Collections.Generic;
using SisVet.Model;

namespace SisVet.Repository
{
    public class RacaRepository
    {
        public bool Salvar(Raca racaId)
        {
            return true;
        }

        public Raca Retornar(int racaId)
        {
            Raca raca = new Raca(racaId);

            if (racaId == 1)
            {
                raca.Id = 1;
                raca.Nome = "shitzu";
                raca.TipoAnimalId = 1;
                raca.TipoAnimal = new TipoAnimal
                {
                    Id = 1,
                    Tipo = "cachorro"
                };
            }

            return raca;
        }               
        
        public List<Raca> Retornar()
        {
            return new List<Raca>();
        }
    }
}
