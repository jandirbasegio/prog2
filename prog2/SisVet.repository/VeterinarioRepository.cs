﻿using System;
using System.Collections.Generic;
using SisVet.Model;

namespace SisVet.Repository
{
    // comentario
    public class VeterinarioRepository
    {
        public bool Salvar(Veterinario veterinario)
        {
            return true;
        }

        public Veterinario Retornar(int veterianarioId)
        {
            Veterinario veterinario = new Veterinario(veterianarioId);

            // Buscar dados do banco de dados

            if (veterianarioId == 1)
            {
                veterinario.Nome = "Jandir";
                veterinario.Sobrenome = "Basegio";
                veterinario.Crv = "123456";
                veterinario.Email = "jandirc.basegio@gmail.com";
                veterinario.Telefone = "49 9 91845290";

            }

            return new Veterinario();
        }

        public List<Veterinario> Retornar()
        {
            return new List<Veterinario>();
        }
    }
}
