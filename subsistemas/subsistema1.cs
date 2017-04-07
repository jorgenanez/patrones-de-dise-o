using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace subsistemas
{
    class subsistema1
    {
        public void Metodo1()//nombre del metodo del subsistema 1 consiste en hacer una multiplicacion
        {
            Console.WriteLine(" metodo del subsistema 1 es  hacer una multiplicacion");//descripcion de lo que hace el metodo escribe en pantalla
            int a = 10, b = 2;//declaracion de 2 varaibles con valores inicializados para hacer la operacion
            int mult = a*b;//declaracion de una variable para almacenar el resultado de la operacion
            Console.WriteLine("la multiplicacion de" + " " + a + "*" + b + "=" + mult);//muestra en pantalla el resultado de la operacion
        }
    }
}
