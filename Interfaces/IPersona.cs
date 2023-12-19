using System;
using System.Runtime.ConstrainedExecution;
using static ExamenRaul.Interfaces.IMascotas;
namespace ExamenRaul.Interfaces

	{
    public interface IPersona
    {
        public int Id => throw new NotImplementedException();

        public string nombre { get => throw new NotImplementedException(); set => throw new NotImplementedException();}

        public void AcariciarMascota() //recibe una mascota y si tiene temperamento que se pueda acariciar, deja
            // si no se puede acariciar, arrojar mensaje
        {
            throw new NotImplementedException();
        }

        public void ObtenerMascotas() //necesita una lista de la persona en base IMascota
        {
            throw new NotImplementedException();
        }

        public void ObtenerMascotaId() 
        {
            throw new NotImplementedException(); // checa la lista de la persona con el id y devuelve la mascota
            // si no se encuentra el Id, este es null 
        }

        public void AgregarMascota()
        {
            throw new NotImplementedException();
            /*Agregar mascota crea una nueva mascota y muestra un texto que diga 
             * algo tipo Raúl agrega a Milaneso a sus mascotas, seguido por el HacerRuido(); */

            // la persona debe poder acariciar a todas las mascotas de la lista de la persona
            //si el temperamento de la mascota no deja ser acariciado, arrojar mensaje
        }



       
    }
}


