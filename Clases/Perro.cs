using System;
using static ExamenRaul.Interfaces.IMascotas;
using static ExamenRaul.Enumeradores.Temperamentoenum;
using ExamenRaul.Enumeradores;

namespace ExamenRaul.Clases 
{
    public class Perro : IMascota
    {
        private List<IMascota> _perros;
        private string _name;
        private int _edad;
        private string _dueño;
        private int _id;
        private Temperamentoenum _temperamento;
        int Idlass = 0;

        public Perro(string nombre, int edad, string dueño,int Id, Temperamentoenum temperamento)
        {
            _name = nombre;
            _edad = edad;
            _dueño = dueño;
             _id = Id;
            _temperamento = temperamento;   
            _id = Idlass + 1;
            Idlass++;
            _perros = new List<IMascota>();

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
                if (value < 0 || value <= 14)
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
            Console.WriteLine("gua gua gua (que onda pa)");
        }

        public void Movercola(IMascota perro)
        {
            Console.WriteLine($"{perro.Nombre}Perro moviendo las caderas y la colita");
        }
        public void Gruñir()
        {
            Console.WriteLine("El perrito esta griñendo por que le caes mal");
        }
        public void AgregarPerros(IMascota perro)
        {
            _perros.Add(new Perro(perro.Nombre,perro.Edad,perro.Dueño,perro.Id,perro.temperamentoenum));
        }
    }
}

