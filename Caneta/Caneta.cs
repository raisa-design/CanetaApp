using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanetaApp
{
    public class Caneta
    {
        private string nome;

        private string modelo;

        private string cor;

        private int carga;

        private bool tampada;

        public Caneta(int carga )
        {
            this.carga = carga;
            destampar();
        }

        public void status()
        {
            Console.WriteLine("//////////////////////////////////////////////");
            Console.WriteLine("Nome: " + this.nome);
            Console.WriteLine("Modelo: " + this.modelo);
            Console.WriteLine("Uma caneta: " + this.cor);
            Console.WriteLine("Carga: " + this.carga);
            Console.WriteLine("Tampada: " + this.tampada);
            Console.WriteLine("//////////////////////////////////////////////");

        }

        public void setNome(string nome)
        {
            this.nome = nome;
        }

        public void setModelo(string modelo)
        {
            this.modelo = modelo;
        }

        public string getNome()
        {
            return this.nome;
        }

        public int somarNum(int num, int num2)
        {
          var soma = num + num2;
            return soma;

        }


       
       public void tampar()
        {
            this.tampada = true;
        }

       public void destampar ()
        {
            this.tampada = false;
        }

        public void setColor(int cor)
        {
            if(cor == 1)
                this.cor= "Rosa";

            else if (cor == 2){
                this.cor = "Azul";
            }
            else
            {
                Console.WriteLine("Erro ao adicionar a cor");
                Console.Error.Close();
            }

        }

       public void Rabiscar(string palavra)
        {
            if (this.carga > 0)
            {
                this.carga--;
                if (this.cor == "Rosa")
                {
                    Console.BackgroundColor = ConsoleColor.Magenta;
                    Console.WriteLine(palavra);
                    Console.ResetColor();
                }
                else if (this.cor == "Azul")
                {
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.WriteLine(palavra);
                    Console.ResetColor();
                }
                else
                {
                    Console.WriteLine(palavra);
                }
            }
            else
            {
                Console.WriteLine("Caneta sem carga"); 
            }
           
            
        }
    }
}
