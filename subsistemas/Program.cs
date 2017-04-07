using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace subsistemas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ejemplo de patron de diseño fachada\n");
            Fachada fachada = new Fachada();//instanciar la clase fachada y acceder a sus metodos
            //llamando metodos de la clase fachada

    fachada.MetodoA();
    fachada.MetodoB();

    // pausa para ver pantalla de resultados
    Console.Read();
  }
        }
    }

