using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenRaul.Interfaces
{
    public interface IMascotas
    {
        interface IMascota
        {
            int Id { get; }
            string Nombre { get; set; }
            int Edad { get; }

            string Dueño { get; set; }

            void HacerRuido();

            void CambiarDueño();

        }
    }
}
