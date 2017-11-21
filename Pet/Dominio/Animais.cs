using System;
using System.IO;
using System.Text;

namespace Dominio
{
    public class Animais
    {
        public string Nome { get; set; }
<<<<<<< HEAD
        public string Nascimento { get; set; }
=======
        public DateTime Nascimento { get; set; }
>>>>>>> 5d395eef859a7549b9c81a954292ad8b6d55c345
        public string Raca { get; set; }
        public string Cor { get; set; }
        public string Porte { get; set; }
        public string Tipo { get; set; }
        public string ID { get; set; }
<<<<<<< HEAD
    }
=======

        public Animais()
        {

        }
        public Animais(string Tipo, string Raca, string Cor, string Nome, DateTime Nascimento, string Porte, string ID)
        {
            this.Nome = Nome;
            this.Nascimento = Nascimento;
            this.Raca = Raca;
            this.Cor = Cor;
            this.Porte = Porte;
            this.Tipo = Tipo;
            this.ID = ID;
        }




    }   
>>>>>>> 5d395eef859a7549b9c81a954292ad8b6d55c345
}