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
            try
            {
                Metodo2();
            }
            catch (Exception ex)
            {
                
                Console.WriteLine($"Encontrou a exceção: {ex.Message}");
                
            }
            
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
