using System;

namespace programa02_02
{
	class CPersona
	{
		private string nombre;
		private int edad;

        public CPersona()
        {
            string tempEdad = "Estamos en el constructor";
            Console.WriteLine("Dame el nombre");
            nombre = Console.ReadLine();
            Console.WriteLine("Dame la edad");
            tempEdad = Console.ReadLine();
            edad = Convert.ToInt32(tempEdad);

            Console.WriteLine("");
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