using System;
using Personas;
namespace ArreglosObjetos_G3_2022_I
{
    class Program
    {
        static void Main(string[] args)
        {

            Persona[] integranteEquipo1 = new Persona[3];

            integranteEquipo1[0] = new Persona("Armando","552517248",24);
            integranteEquipo1[1] = new Persona("Pablo", "251015789", 20);
            integranteEquipo1[2] = new Persona("Carlos", "12345847", 22);

            for(int i=0; i < integranteEquipo1.Length; i++)
            {
                Console.WriteLine(integranteEquipo1[i].Nombre);
            }
            
            foreach( Persona integrante in integranteEquipo1    )
            {
                Console.WriteLine("Teléfono: {0}", integrante.Telefono );
                Console.WriteLine("Edad:  {0}", integrante.Edad);
            }

            Persona[,] integranteG3Equipo = new Persona[2, 2];

            //Integrantes para el equipo1 del Grupo 3
            integranteG3Equipo[0, 0] = new Persona("Juan", "2510111012", 20);
            integranteG3Equipo[0, 1] = new Persona("Carlos", "2511111012", 22);
            //Integrantes para el equipo2 del Grupo 3
            integranteG3Equipo[1, 0] = new Persona(" Luis  ", "12548789", 20);
            integranteG3Equipo[1, 1] = new Persona("Hugo", "215245885", 20);

            for( int i=0; i < 2; i++   )
            {
                Console.WriteLine("****Equipo {0}*****", i + 1);
                for(int j=0; j< 2; j++)
                {
                    Console.WriteLine("Integrante {0}", j+1);
                    Console.WriteLine(integranteG3Equipo[i,j]);
                   // Console.WriteLine("Nombre: {0}, ", integranteG3Equipo[i,j].Nombre);
                   // Console.WriteLine("Telefono: {0}", integranteG3Equipo[i, j].Telefono);
                  //  Console.WriteLine("Edad: {0}", integranteG3Equipo[i, j].Edad);
                }
            }




            Console.ReadLine();

        }
    }
}
