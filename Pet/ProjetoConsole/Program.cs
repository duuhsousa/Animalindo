using System;

namespace ProjetoConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            //============================================LÓGICA DO CADASTRO DE ANIMAIS==========================================================
            Console.WriteLine("Bem-vindo ao cadastrado de animais");
            Console.Write("\nDigite qual animal você deseja cadastrar: "); string tipo = Console.ReadLine();
            Console.Write("Digite a raça do seu animal: "); string raca = Console.ReadLine();
            Console.Write("Digite a cor do seu animal: "); string cor = Console.ReadLine();
            Console.Write("Digite o nome do seu animal: "); string nome = Console.ReadLine();
            Console.Write("Digite a data de nascimento do seu animal: "); DateTime nascimento = Convert.ToDateTime(Console.ReadLine());
            Console.Write("Digite o porte do seu animal: "); string porte = Console.ReadLine();

            string id = string.Empty;
            Random num = new Random();
            id = num.Next(0,100).ToString();

            Animais animais = new Animais(tipo,raca,cor,nome,nascimento,porte,id);  //Instancia a classe ANIMAIS pedindo os parâmetros estabelecidos
            AnimaisRep CadAnimal = new AnimaisRep();
            

            bool cadastrosucesso = CadAnimal.Cadastrar(animais);
            if(cadastrosucesso)
            Console.WriteLine("\nAnimal cadastrado com sucesso.");
            else
            Console.WriteLine("\nOcorreu um erro no processo de cadastramento, contacte o ADM.");

            Console.Write("Pesquisar ID do animal:  ");
            string pesquisa = Console.ReadLine();
            AnimaisRep PesAnimais = new AnimaisRep();
            Console.WriteLine(PesAnimais.Consultar(pesquisa));
            

            //======================================================================================================================================

        }
    }
}
