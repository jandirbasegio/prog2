using System;
using System.Collections.Generic;
using SisVet.Model;

namespace SisVet.Repository
{
    public class AnimalRepository
    {

        public bool Salvar(Animal animal)
        {
            return true;
        }

        public Animal Retornar(int animalId)
        {
            Animal animal = new Animal(animalId);

            if (animalId == 1)
            {
                animal.Nome = "toto";
                animal.DataNascimento =DateTime.Now;
                animal.Peso = 10;
                animal.Altura = 05;
                animal.Complimento = 40;
                animal.Cor = "branco";
                animal.Raca = new Raca();   

            }

            return new Animal();
        }

        public List<Animal> Retornar()
        {
            return new List<Animal>();
        }
    }
}




