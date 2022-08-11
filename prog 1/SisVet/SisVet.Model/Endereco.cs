namespace SisVet.Model
{
    public class Endereco
    {
        public string id { get; set; }

        public string rua { get; set; }

        public string Nro { get; set; }

        public string Complemento { get; set; }

        public string Bairro { get; set; }

        public string cidade { get; set; }

        public  Estado Estado { get; set; }

        public string Pais { get; set; }

        public string Cep { get; set; }
    }


    public enum Estado { 
        AC, AL, AM, AP, BA, CE, DF, ES, GO, MA, MT, 
        MS, PA, PB, PR, PE, PI, RN, RS, RJ, RO, RR, 
        SC, SP, SE, TO, 
        }
}
