using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTN.Winform.AppProyectopg3.Layers.BLL;
using UTN.Winform.AppProyectopg3.Layers.Entities;

namespace UTN.Winform.AppProyectopg3.Layers.Singleton
{
    class GestorNewUser
    {
        private static GestorNewUser Instancia;

        private GestorNewUser()
        {

        }

        public static GestorNewUser GetInstacia()
        {

            if (Instancia == null)
            {
                Instancia = new GestorNewUser();
            }

            return Instancia;
        }

        public void NewUser(Usuario pUsuario)
        {

            BLLNewUser _BLLNewUser = new BLLNewUser();
            _BLLNewUser.NewUser(pUsuario);

        }

    }
}
