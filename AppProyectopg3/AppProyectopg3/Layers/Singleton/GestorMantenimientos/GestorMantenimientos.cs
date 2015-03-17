using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTN.Winform.AppProyectopg3.Layers.BLL.BLLMantenimientos;
using UTN.Winform.AppProyectopg3.Layers.Entities.DTO;

namespace UTN.Winform.AppProyectopg3.Layers.Singleton.GestorMantenimientos
{
    class GestorMantenimientos
    {

        private static GestorMantenimientos Instancia;

        private GestorMantenimientos()
        {

        }

        public static GestorMantenimientos GetInstacia()
        {

            if (Instancia == null)
            {
                Instancia = new GestorMantenimientos();
            }

            return Instancia;
        }


        public List<Users> GetUsuarios() {

            BLLMantenimientos _BLLMantenimientos = new BLLMantenimientos();
            return _BLLMantenimientos.GetUsuarios();
        }


    }//fin class
}
