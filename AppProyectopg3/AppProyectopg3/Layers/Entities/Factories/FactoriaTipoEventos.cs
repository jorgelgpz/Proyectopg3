using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTN.Winform.AppProyectopg3.Layers.Entities.Factories
{
    class FactoriaTipoEventos
    {

        public static string GetTipoEvento(TipoEventos ptipoEventos)
        {

            string @string = "Negativo";

            if (ptipoEventos == TipoEventos.Positivo)
            {

                return "Positivo";

            }

            return @string;
        }
    }
}
