using System;
using System.Collections.Generic;
using SisVet.Model;

namespace SisVet.Repository
{
    public class ProcedimentoRepository
    {

        public bool Salvar(Procedimento procedimento)
        {
            return true;

        }

        public Procedimento Retornar(int procedimentoId)
        {
            Procedimento procedimento = new Procedimento(procedimentoId);

            if (procedimentoId == 1)
            {
                procedimento.Id = 1;
                procedimento.TipoProcedimento = "Vacinação";
                procedimento.Descricao = "Vacinado";
            }    

            return procedimento;
        }

        public List<Procedimento> Retornar()
        {
            return new List<Procedimento>();
        }
    }
}
