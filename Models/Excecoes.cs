using System;
using System.Threading.Tasks;

namespace DotNet_Excecoes_Colecoes.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class Excecoes
    {
        public void Metodo1(){
            Metodo2();
        }

        public void Metodo2(){
            Metodo3();
        }

        public void Metodo3(){
            Metodo4();
        }

        public void Metodo4(){
            throw new Exception("Ocorreu uma exceção");
        }                


    }
}
