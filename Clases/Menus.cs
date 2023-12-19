using System;
namespace ExamenRaul.Clases
{
	public class Menus
	{
		public Menus()
		{
            void ProgramaPrincipal()
            {
                Console.WriteLine("1 - Administración del centro \n");
                Console.WriteLine("2 - Administración de Adopciones \n");
                Console.WriteLine("3 - Administración del bienestar animal \n");
                Console.WriteLine("4 - Simulación de interacciones \n");
                Console.WriteLine("5 - Finalizar el programa \n");
            }

             void AdministracionDelCentro()
            {
                Console.WriteLine("1 - Administración de personas \n");
                Console.WriteLine("2 - Administración de mascotas \n");
                Console.WriteLine("3 - Regresar al menu principal \n");
            }

            void AdministracionDePersonas()
            {
                Console.WriteLine("1 - Mostrar todas las personas registradas \n");
                Console.WriteLine("2 - Registrar persona nueva \n");
                Console.WriteLine("3 - Buscar personas por nombre \n");
                Console.WriteLine("4 - Examinar persona \n");
                Console.WriteLine("5 - Regresar al menu anterior \n");
            }

             void AdministracionDeMascotas()
            {
                Console.WriteLine("1 - Mostrar todas las mascotas registradas \n");
                Console.WriteLine("2 - Registrar mascota nueva \n");
                Console.WriteLine("3 - Buscar mascota por especie \n");
                Console.WriteLine("4 - Buscar mascotas por nombre \n");
                Console.WriteLine("5 - Examinar Mascota \n");
                Console.WriteLine("6 - Volver al menú anterior");
            }

            void AdministracionDeAdopciones()
            {
                Console.WriteLine("1 - Ver mascotas disponibles para adoptar \n");
                Console.WriteLine("2 - Adoptar mascota \n");
                Console.WriteLine("3 - Regresar al menú anterior \n");
            }

            void AdministracionDeBienestarAnimal()
            {
                Console.WriteLine("1 - Servicio de spa \n");
                Console.WriteLine("2 - Corte de pelo \n");
                Console.WriteLine("3 - Volver al Menú anterior \n");
            }

        }

    }
}

