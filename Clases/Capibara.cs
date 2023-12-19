using ExamenRaul.Enumeradores;
using System;
using static ExamenRaul.Enumeradores.Temperamentoenum;
using static ExamenRaul.Interfaces.IMascotas;

namespace ExamenRaul.Clases
{

    public class Capibara : IMascota
    {

        private List<IMascota> _capibaras;
        private string _name;
        private int _edad;
        private string _dueño;
        private int _id;
        private Temperamentoenum _temperamento;
        int Idlass = 0;
    
        public Capibara(string nombre, int edad, string dueño, int Id, Temperamentoenum temperamentoenum)
        {
            _name = nombre;
            _edad = edad;
            _dueño = dueño;
            _id = Id;
            _id = Idlass + 1;
            Idlass++;
            _capibaras = new List<IMascota>();

        }
        public int Id

        {
            get { return _id; }


            private set
            {
                _id = value;
            }
        }

        public string Nombre
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
                if (string.IsNullOrWhiteSpace(value))
                {

                    throw new Exception("Porfavor de digitar un nombre valido");
                }
            }
        }


        public int Edad
        {
            get
            {
                return _edad;
            }
            set
            {
                _edad = value;
                if (value < 0 || value <= 11)
                {
                    throw new Exception("No puede ser numero negativos por favor digite un numero correcto");
                }

            }
        }

        public string Dueño
        {
            get { return _dueño; }
            set { _dueño = value; }
        }

        public Temperamentoenum temperamentoenum
        {
            get { return _temperamento; }
        }

        public void CambiarDueño()
        {

            throw new NotImplementedException();
        }

        public void HacerRuido()
        {
            Console.WriteLine("cui cui uwu (dame comida pues)");
        }
     
        public void AgregarCapibara(IMascota capibara)
        {
            _capibaras.Add(new Capibara(capibara.Nombre, capibara.Edad, capibara.Dueño, capibara.Id, capibara.temperamentoenum));
        }

    }
}



