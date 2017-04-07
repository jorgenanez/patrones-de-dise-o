using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace subsistemas
{
    //en este espacio se accede a los metodos de las diferentes clases que se van a utilizar aqui se van instanciar para crear el efecto fachada 
    //que es acceder a los diferentes metodos de las clases pero no directamente sino llamandolos de una clase que servira como fachada 
    class Fachada
    {
        //variables para instanciar a las clases a utilizar
  subsistema1 uno; 
  subsistema2 dos;
  subsistema3 tres;
  subsistema4 cuatro;

  public Fachada()
  {
    uno = new subsistema1();//instanciacion de la clase subsistema1
    dos = new subsistema2();//instanciacion de la clase subsistema2
    tres = new subsistema3();//instanciacion de la clase subsistema3
    cuatro = new subsistema4();//instanciacion de la clase subsistema1
  }

  

  public void MetodoA()//metodoA de la clase fachada
  {
    Console.WriteLine("\nMetodo A de la fachada ");//describe que metodo se esta utilizando de la fachada
    uno.Metodo1();//llamando al metodo del subsistema uno
    dos.Metodo2();//llamando al metodo del subsistema dos
    cuatro.Metodo4();//llamando al metodo del subsistema cuatro
  }

  public void MetodoB()//metodoB de la clase fachada
  {
      Console.WriteLine("\nMetodo B de la fachada ");//describe que metodo se esta utilizando de la fachada
    dos.Metodo2();//llamando al metodo del subsistema dos
    tres.Metodo3();//llamando al metodo del subsistema tres
  }
    }
}
