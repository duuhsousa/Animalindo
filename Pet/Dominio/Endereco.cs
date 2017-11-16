namespace Dominio
{
    public class Endereco
    {
        public string Logradouro { get; set; }
        public int Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string CEP { get; set; }

        public Endereco(){

        }

        public Endereco(string _Logradouro, int _Numero, string _Bairro, string _Cidade, string _Estado, string _CEP){
            this.Logradouro = _Logradouro;
            this.Numero = _Numero;
            this.Bairro = _Bairro;
            this.Cidade = _Cidade;
            this.Estado = _Estado;
            this.CEP = _CEP;
        }
    }
}