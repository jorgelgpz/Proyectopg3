using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTN.Winform.AppProyectopg3.Layers.BLL;
using UTN.Winform.AppProyectopg3.Layers.Entities;

namespace UTN.Winform.AppProyectopg3.Layers.Singleton
{
    class GestorLoging
    {

        private static GestorLoging Instancia;

        private GestorLoging()
        {

        }

        public static GestorLoging GetInstacia()
        {

            if (Instancia == null)
            {
                Instancia = new GestorLoging();
            }

            return Instancia;
        }


        public void Loging(Usuario pUsuario)
        {

            BLLLogin _BLLLogin = new BLLLogin();

            _BLLLogin.Login(pUsuario);

        }
    }
}
