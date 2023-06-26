using System;

namespace programa02_02
{
	class CPersona
	{
		private string nombre;
		private int edad;

        public CPersona(string pNombre, int pEdad)
        {
            Console.WriteLine("Estamos en el constructor");

            nombre = pNombre;
            edad = pEdad;           
        }
        public string Nombre
        {
            set { nombre = value; }
        }
        public int Edad 
        { 
            set { edad = value; }
        }
        public void muestra()
        {
            Console.WriteLine("Nombre: {0}, edad:{1}", nombre, edad);
        }
    }
}