﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenRaul.Interfaces
{
    internal interface IMascotas
    {
        interface IMascotas
        {
            int Id { get; set; }
            string Nombre { get; set; }
            int Edad { get; }

            string Dueño { get; set; }

            void HacerRuido();

            void CambiarDueño();

        }
    }
}