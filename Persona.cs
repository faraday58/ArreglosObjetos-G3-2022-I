using System;

namespace Personas
{
    public class Persona
    {

        #region Atributos
        private string nombre;
        private string telefono;
        private byte edad;
        #endregion

        #region Propiedades
        public string Nombre { get => nombre; set => nombre = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public byte Edad { get => edad;
            set
            {
                if ( value < 18  || value > 100     )
                {
                    edad = 18;
                }
                else
                {
                    edad = value;
                }                
            }
         }
        #endregion


        /// <summary>
        /// Construtor de la clase persona para inicializar
        ///  los datos del usuario
        /// </summary>
        /// <param name="nombre">Nombre completo de de la persona</param>
        /// <param name="telefono">Teléfono de la persona</param>
        /// <param name="edad">Edad de la persona</param>
        public Persona(string nombre, string telefono, byte edad)
        {
            Nombre = nombre;
            Telefono = telefono;
            Edad = edad;
        }

        public override string ToString()
        {
            string datos= String.Format( "Nombre: {0} \n Teléfono: {1} \n Edad: {2}",Nombre,Telefono,Edad);
            return datos ;
        }



    }
}
