using System;
using System.Collections.Generic;
using System.Text;

namespace SisVet.Model
{
    public class Atendimento
    {
        public long Id { get; set; }

        public Clinica ClinicaId { get; set; }

        public String Veterinario { get; set; }

        public string Animal { get; set; }

        public DateTime DataHora{ get; set; }

        public string ProcedimentoId { get; set; }

    }
}
