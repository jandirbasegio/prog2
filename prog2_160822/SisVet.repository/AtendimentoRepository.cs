using System;
using System.Collections.Generic;
using SisVet.Model;

namespace SisVet.Repository
{
    public class AtendimentoRepository
    {

        public bool Salvar(Atendimento atendimento)
        {
            return true;
        }

        public Atendimento Retornar(int atendimentoId)
        {


            Atendimento atendimento = new Atendimento(atendimentoId);

            if (atendimentoId == 1)
            {
                atendimento.Id = 1;
                atendimento.ClinicaId = 1;
                atendimento.VeterinarioId = 1;
                atendimento.AnimalId = 2;
                atendimento.ProcedimentoId = 1;
            }
            return atendimento;

        }

        public List<Atendimento> Retornar()
        {
            return new List<Atendimento>();
        }
    }
}
