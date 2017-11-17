using System;
using System.IO;
using System.Text;
using Util;

namespace Dominio
{
    public class Clientes
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Genero { get; set; }
        public Endereco endereco { get; set; }
        public string CPF { get; set; }
        public string CodID { get; set; }

        public Clientes()
        {

        }

        public Clientes(string Nome, int Idade, string Genero, Endereco endereco, string CPF, string CodID)
        {
            this.Nome = Nome;
            this.Idade = Idade;
            this.Genero = Genero;
            this.endereco = endereco;
            this.CPF = CPF;
            this.CodID = CodID;
        }
        public void CadastrarCliente()
        {
            bool ConverteuIdade = false;
            bool cpfvalido = true;

            System.Console.WriteLine("Bem vindo ao cadastro de cliente!!\n");
            System.Console.WriteLine("Insira o nome do novo cliente:");
            Nome = Console.ReadLine();
            do
            {
                Console.WriteLine("Qual a idade do cliente?");
                ConverteuIdade = Convert.ToBoolean(Idade = Convert.ToInt32(Console.ReadLine()));
            } while (ConverteuIdade == false);
            System.Console.WriteLine("Qual o Genêro do cliente?");
            Genero = Console.ReadLine();
            Endereco end = new Endereco();
            end.CadastrarEndereco();
            do
            {
                System.Console.WriteLine("Qual o seu CPF?");
                CPF = Console.ReadLine();
                ValidacaoCPF v = new ValidacaoCPF();
                cpfvalido = v.checagemcpf(CPF);

                if (cpfvalido == true)
                {
                    System.Console.WriteLine("Qual será o codigo do cliente?");
                    CodID = Console.ReadLine();
                    StreamWriter arquivo = new StreamWriter("../Repositorio/clientes.csv", true);
                    arquivo.WriteLine(Nome + "; " + Idade + "; " + Genero + "; " + endereco + "; " + CPF + "; " + CodID);
                    arquivo.Close();
                }
            } while (cpfvalido == false);
            {
                System.Console.WriteLine("CPF INVÁLIDO!!");
            }
        }
        public string Pesquisar(string Nome)
        {
            string Resultado = "Cliente não encontrado";
            StreamReader ler = null;
            try
            {
                ler = new StreamReader("../Repositorio/clientes.csv", Encoding.Default); // ENCODING serve para dizer os tipos de caracteres que vão ser pesquisados
                string Linha = "";

                while ((Linha = ler.ReadLine()) != null) // enquanto tiver dado escrito ele continua no while
                {
                    string[] dados = Linha.Split(';'); // indica que cada dado pesquisado é separado por ";" e a cada ';' ele inclui o dado em um ARRAY
                    if (dados[0] == Nome) // se ele encontrar o que foi epsquisado na coluna do titulo, ele lê toda a linha
                    {
                        Resultado = Linha;
                        break;
                    }
                }
            }
            catch (System.Exception ex)
            {
                Resultado = "Erro ao tentar ler o arquivo " + ex.Message;
            }
            finally
            {
                ler.Close();
            }

            return Resultado;
        }
    }
}