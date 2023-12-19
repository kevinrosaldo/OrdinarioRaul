using ExamenRaul.Enumeradores;
using System;
using static ExamenRaul.Enumeradores.Temperamentoenum;
using static ExamenRaul.Interfaces.IMascotas;
namespace ExamenRaul.Clases
{



    public class Gato : IMascota
    {
        private List<IMascota> _gatos;
        private string _name;
        private int _edad;
        private string _dueño;
        private int _id;
        private Temperamentoenum _temperamento;
        int Idlass = 0;

        public Gato(string nombre, int edad, string dueño, int Id)
        {
            _name = nombre;
            _edad = edad;
            _dueño = dueño;
            _id = Id;
            _id = Idlass + 1;
            Idlass++;
            _gatos = new List<IMascota>();

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
                if (value < 0 || value <= 18)
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
            Console.WriteLine("miau miau (dame comida pues)");
        }

        public void Romronear(IMascota nombre)
        {
            Console.WriteLine($"{nombre.Nombre} esta ronroneando peligro de ternura");
        }
        public void Rasguñar(IMascota gato)
        {
            Console.WriteLine($"{gato.Nombre} la caes mal al gato peligro de un ataque directo");
        }
        public void AgregarPerros(IMascota gato)
        {
            _gatos.Add(new Perro(gato.Nombre, gato.Edad, gato.Dueño, gato.Id, gato.temperamentoenum));
        }

    }
}

