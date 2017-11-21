using System;
using System.IO;
<<<<<<< HEAD

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
=======
using System.Text;
using Dominio;

namespace Repositorio
{
    public class AnimaisRep : Dominio.ICrud
    {
        /// <summary>
        /// Esta função faz o cadastro dos animais
        /// </summary>
        /// <param name="animais"></param>
        /// <returns>Retorna boolean</returns>
        public bool Cadastrar(Animais animais)
        {
            bool efetuado = false;
            StreamWriter arquivo = null;
>>>>>>> 5d395eef859a7549b9c81a954292ad8b6d55c345

            try
            {
                arquivo = new StreamWriter("CadastroAnimais.csv", true);
                arquivo.WriteLine(
                    animais.ID + ";"+
                    animais.Nome + ";" + // fazendo um get
                    animais.Nascimento.ToShortDateString() + ";" + // outro get
                    animais.Raca + ";" +
                    animais.Cor + ";" + // Acessamos a classe Cat (categoria) e acessamos o parâmetro Nome
                    animais.Porte + ";"+
                    animais.Tipo
                );
                efetuado = true;
            }
            
            catch(Exception ex)
            {
                throw new Exception("Erro ao tentar gravar o arquivo!"+ex.Message); //exibe uma mensagem avisando que não foi possível gravar no arquivo
            }
            finally //fecha o arquivo após o TRY/CATCH
            {
                arquivo.Close();
            }
            return efetuado;
        }
        
        public string Consultar(string ID)
        {
<<<<<<< HEAD
            return null;
=======
             string resultado = ("ID não encontrada");
            StreamReader ler = null;

            try
            {
                ler = new StreamReader("CadastroAnimais.csv", Encoding.Default); //Encoding.Default serve para utilizar
                string linha = "";
                while((linha=ler.ReadLine())!=null)
                {
                    string[] dados = linha.Split(';');
                    if(dados[0] == ID)
                    {
                        resultado = linha;
                        break;
                    }
                }
            }
            catch(Exception ex)
            {
                resultado = ("Erro ao tentar ler o arquivo!"+ex.Message);
            }
            finally
            {
                ler.Close();
            }

            return resultado;
>>>>>>> 5d395eef859a7549b9c81a954292ad8b6d55c345
        }
    }
}