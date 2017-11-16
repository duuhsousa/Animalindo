using System;
using Util;

namespace Dominio {
    public class Clientes {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Genero { get; set; }
        public Endereco endereco { get; set; }
        public string CPF { get; set; }
        public string CodID { get; set; }

        public Clientes () {

        }

        public Clientes (string Nome, int Idade, string Genero, Endereco endereco, string CPF, string CodID) {
            this.Nome = Nome;
            this.Idade = Idade;
            this.Genero = Genero;
            this.endereco = endereco;
            this.CPF = CPF;
            this.CodID = CodID;
        }
        public void NovoCliente () {
            bool ConverteuIdade = false;
            bool cpfvalido = true;

            System.Console.WriteLine ("Bem vindo ao cadastro de cliente!!\n");
            System.Console.WriteLine ("Insira o nome do novo cliente:");
            Nome = Console.ReadLine ();
            do {
                Console.WriteLine ("Qual a idade do cliente?");
                ConverteuIdade = Convert.ToBoolean (Idade = Convert.ToInt32 (Console.ReadLine ()));
            } while (ConverteuIdade == false);
            System.Console.WriteLine ("Qual o Genêro do cliente?");
            Genero = Console.ReadLine ();
            Endereco end = new Endereco ();
            end.CadastrarEndereco ();
            do {
                System.Console.WriteLine ("Qual o seu CPF?");
                CPF = Console.ReadLine ();
                ValidacaoCPF v = new ValidacaoCPF ();
                cpfvalido = v.checagemcpf (CPF);

                if (cpfvalido == true) {
                    System.Console.WriteLine ("Qual será o codigo do cliente?");
                    CodID = Console.ReadLine ();
                }
            }while(cpfvalido==false);
        }
    }
}