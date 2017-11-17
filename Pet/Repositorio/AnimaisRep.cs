using System;
using System.IO;
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
        }
    }
}