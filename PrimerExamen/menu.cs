using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerExamen
{
     class menu
    {
     

        byte opcion;
        Empleado empleado = new Empleado();

        

        public menu()
        {
            
        }

       

        public void Mostrar()
        {
            do
            {

                Console.WriteLine(" ***BIENVENIDO PROFESOR*** ");
                Console.WriteLine("1- INICIALIZAR DATOS ");
                Console.WriteLine("2- INGRESO DATOS");
                Console.WriteLine("3- CONSULTAR  DATOS");
                Console.WriteLine("4- REPORTE DATOS ");
                Console.WriteLine("5- SALIR ");
                Console.Write("Digite una opcion: ");
                opcion = byte.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        empleado.Inicializar();
                        break;
                    case 2:
                        empleado.Ingresar();
                        break;
                    case 3:
                        empleado.Consultar();
                        break;
                    case 4:
                        empleado.Reporte();
                        break;

                        

                    default:
                        Console.WriteLine("opcion incorrecta");
                        break;
                }

            } while (opcion != 5);

        }


    }

}

