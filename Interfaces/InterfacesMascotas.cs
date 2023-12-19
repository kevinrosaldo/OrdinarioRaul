using ExamenRaul.Enumeradores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ExamenRaul.Enumeradores.Temperamentoenum;

namespace ExamenRaul.Interfaces
{
    public interface IMascotas
    {
        interface IMascota
        {
           Temperamentoenum temperamentoenum { get;  }
            int Id { get; }
            string Nombre { get; set; }
            int Edad { get; }

            string Dueño { get; set; }

            void HacerRuido();

            void CambiarDueño();

        }
    }
}
