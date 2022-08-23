using System.Collections.Generic;
using SisVet.Model;

namespace SisVet.Repository
{
    public class EnderecoRepository
    {
        public bool Salvar(Endereco endereco)
        {
            return true;
        }

        public Endereco Retornar(int enderecoId)
        {
            Endereco endereco = new Endereco(enderecoId);

            if (enderecoId == 1)
            {
                endereco.Id = 1;
                endereco.Rua = "Eugenio fantin";
                endereco.Nro = "384";
                endereco.Complemento = "Porão";
                endereco.Cidade = "Videria";
                endereco.Bairro = "Cibrazem";
                endereco.Pais = "Brasil";
                endereco.Cep = "89564006";
            }

            return endereco;
        }

        public List<Endereco> Retornar()
        {
            return new List<Endereco>();
        }
    }
}
