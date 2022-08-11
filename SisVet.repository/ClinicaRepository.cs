using System;
using System.Collections.Generic;
using SisVet.Model;

namespace SisVet.Repository
{
    public class ClinicaRepository
    {
        public bool Salvar(Clinica clinica)
        {
            return true;
        }

        public Clinica Retornar(int clinicaId)
        {

            // forma 1
            Clinica clinica = new Clinica(clinicaId);

            if (clinicaId == 1)
            {
                // Buscar dados no banco de dados
                clinica.Id = 1;
                clinica.Nome = "Jandir";
                clinica.Telefone = "49991845290";
                clinica.Email = "Jandirc.basegio@gmail.com";
                clinica.Endereco = new Endereco();
            }
            return clinica;
        }



        public List<Clinica> Retornar()
        {
            return new List<Clinica>();
        }
    }



}
