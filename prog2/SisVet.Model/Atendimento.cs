using System.Collections.Generic;

namespace SisVet.Model
{
    public class Atendimento
    {
        public int Id { get; set; }
        public System.DateTime DataHora { get; set; }
        public int ClinicaId { get; set; }
        public Clinica Clinica { get; set; }
        public int VeterinarioId { get; set; }
        public Veterinario Veterinario{ get; set; }
        public int AnimalId { get; set; }
        public Animal Animal{ get; set; }
        public int ProcedimentoId { get; set; }
    
        public ICollection<Atendimento> Atendimentos { get; set; }

        public Atendimento(int id)
        {
            Id = id;
        }

        public Atendimento()
        {
        }

        public bool Validar()
        {
            var isValid = true;
            if (string.IsNullOrEmpty(""))
                isValid = false;

            return isValid;

        }

    
    }


}
