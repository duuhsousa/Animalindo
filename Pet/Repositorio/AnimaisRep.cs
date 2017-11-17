using System;
using System.IO;

namespace Pet.Repositorio
{
    public class AnimaisRep : Dominio.ICrud
    {
 
        public string Cadastrar()
        {
            Console.WriteLine("Bem-vindo ao cadastrado de animais!!");
            Console.WriteLine("\nQual o seu animal: "); string tipo = Console.ReadLine();
            Console.WriteLine("\nDigite a raça do seu animal: "); string raca = Console.ReadLine();
            Console.WriteLine("\nDigite a cor do seu animal: "); string cor = Console.ReadLine();
            Console.WriteLine("\nDigite o nome do seu animal: "); string nome = Console.ReadLine();
            Console.WriteLine("\nDigite a data de nascimento do seu animal: "); DateTime nascimento = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("\nDigite o porte do seu animal: "); string porte = Console.ReadLine();

            StreamWriter cadastro = new StreamWriter(@"CadastroAnimais.csv", true);
            return null;

            
        }

        public string Consultar()
        {
            return null;
        }
    }
}