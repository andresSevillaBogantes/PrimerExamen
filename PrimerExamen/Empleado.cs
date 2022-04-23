using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerExamen
{
     class Empleado
    {
        public string[] cedula = new string[3];
        public String[] nombre = new string[3];
        public string[] tipo = new string[3];
        public int[] horas = new int[3];
        public int[] phoras= new int[3];
        
       public int opcion1 = 0;  



        public short indice;
        public Empleado()
        {
            for (int i = 0; i < cedula.Length; i++)
            {
                cedula[i] = "";
                nombre[i] = "";
                tipo[i] = "";
                horas[i] = 0;
                phoras[i] = 0;  

            }
            indice = 0;
        }


       

        public void Ingresar()
        {
            char opcion;


            do
            {

                Console.WriteLine(" 1 OPCION SI ES JEFE");
            Console.WriteLine(" 2 OPCION SI ES PROFESIONAL ");
            Console.WriteLine(" 3 OPCION SI ES TECNICO");
            opcion1 = int.Parse(Console.ReadLine());



            if (opcion1 == 1)
            {


                Console.WriteLine("INGRESE LA CEDULA");
                cedula[indice] = Console.ReadLine();
                Console.WriteLine("INGRESE EL NOMBRE");
                nombre[indice] = Console.ReadLine();

                tipo[indice] = "JEFE";
                Console.WriteLine("INGRESE LA CANTIDAD DE HORAS");
                horas[indice] = int.Parse(Console.ReadLine());

                phoras[indice] = 15000;

                


            



                indice++;



            }
            else if (opcion1 == 2)  
            {

                Console.WriteLine("INGRESE LA CEDULA");
                cedula[indice] = Console.ReadLine();
                Console.WriteLine("INGRESE EL NOMBRE");
                nombre[indice] = Console.ReadLine();

                tipo[indice] = "PROFESIONAL";
                Console.WriteLine("INGRESE LA CANTIDAD DE HORAS");
                horas[indice] = int.Parse(Console.ReadLine());

                phoras[indice] = 10000;

                indice++;


            }
            else
            {

                Console.WriteLine("INGRESE LA CEDULA");
                cedula[indice] = Console.ReadLine();
                Console.WriteLine("INGRESE EL NOMBRE");
                nombre[indice] = Console.ReadLine();

                tipo[indice] = "TECNICO";
                Console.WriteLine("INGRESE LA CANTIDAD DE HORAS");
                horas[indice] = int.Parse(Console.ReadLine());

                phoras[indice] = 5000;



                indice++;

            }


            
               

                Console.WriteLine("DESEA INGRESAR OTRO EMPLEADO(S/N):");
                opcion = Convert.ToChar(Console.ReadLine().ToUpper());

            } while (!opcion.Equals('N'));
        }



        public void Inicializar()
        {
            Console.WriteLine("VAMOS A INICIALIZAR: ");
            Console.WriteLine("#######################################################");

            for (int i = 0; i < cedula.Length; i++)
            {
                cedula[i] = "";
                nombre[i] = "";
                tipo[i] = "";
                horas[i] = 0;
                phoras[i] = 0;

            }
            indice = 0;


            Console.WriteLine("#######################################################");

        }
        public void Consultar()
        {
            Console.WriteLine("INGRESE LA CEDULA: ");
            string codigo = Console.ReadLine();

            for (int i = 0; i < cedula.Length; i++)
            {
                if (cedula[i].Equals(codigo))
                {
                    Console.WriteLine("#######################################################");
                    Console.WriteLine("#######################################################");
                    Console.WriteLine("LA CEDULA DEL EMPLEADO ES  : " + cedula[i]);
                    Console.WriteLine("EL NOMBRE DEL EMPLEADO ES : " + nombre[i]);
                    Console.WriteLine("EL TIPO DE EMPLEADO ES : " + tipo[i]);
                    
                    Console.WriteLine(" EL SALARIO TOTAL ES  : " + (horas[i] * phoras[i]));






                    Console.WriteLine("#######################################################");
                    Console.WriteLine("#######################################################");
                    Console.WriteLine("#######################################################");
                    Console.WriteLine("#######################################################");
                }
            }
        }

        public void Reporte()
        {
            Console.WriteLine("###############################################################################################");
            Console.WriteLine(" CEDULA            NOMBRE           TIPO        HORAS        PRECIO            SALARIO TOTAL");
            Console.WriteLine("###############################################################################################");
            for (int i = 0; i < cedula.Length; i++)
            {
                if (cedula[i].Length != 0)
                {

                    Console.WriteLine($"{    cedula[i]}           {nombre[i]}          {tipo[i]}          {horas[i]}          {phoras[i]}         {horas[i] * phoras[i]}  ");

                    Console.WriteLine("#######################################################################################");
                }

            }

        }
       


    }
}

    

