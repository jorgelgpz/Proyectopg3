using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTN.Winform.AppProyectopg3.Layers.Entities.Factories
{
    class FactoriaUsuario
    {
        public static string GetRoll(TipoUsuario ptipoUsuario)
        {

            string @string = null;

            switch (ptipoUsuario)
            {

                case TipoUsuario.administrador:

                    @string = "administrador";

                    break;

                case TipoUsuario.operador:

                    @string = "operario";

                    break;

                case TipoUsuario.reportador:

                    @string = "reportador";

                    break;

            }

            return @string;
        }


    }
}
