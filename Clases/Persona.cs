using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ExamenRaul.Interfaces.IPersona;

namespace ExamenRaul.Clases
{
    internal class Persona : IPersona
    {
        private int _id;
        private string _name;
        int Idlass = 0;
        public Persona(string name,int Id)
        {
        _name = name;
            _id = Id;
            _id = Idlass + 1;
            Idlass++;
        }

        public int Id
        {
            get 
            {

                 return _id;
            }
            private set
            {
                _id = value;
            }
        }
        public string Nombre
        {
            get { return _name; }   

             set
            {
                
                _name = value;
                if (string.IsNullOrWhiteSpace(value))
                {

                    throw new Exception("Porfavor de digitar un nombre valido");
                }

            }
        }

        public void AcariciarMascota()
        {
            throw new NotImplementedException();
        }

        public void AgregarMascota(Interfaces.IMascotas.IMascota mascota)
        {
            throw new NotImplementedException();
        }

        public void ObtenerMascotaId()
        {
            throw new NotImplementedException();
        }

        public void ObtenerMascotas(Interfaces.IMascotas.IMascota mascota)
        {
            throw new NotImplementedException();
        }
    }
}
