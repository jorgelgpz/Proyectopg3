using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTN.Winform.AppProyectopg3.Layers.Util
{
    class Kronos
    {

        private static Kronos Instancia;
        private DateTime fecha;

        private Kronos()
        {

            fecha = new DateTime();
        }

        public static Kronos GetInstancia()
        {

            if (Instancia == null)
            {
                Instancia = new Kronos();
            }

            return Instancia;

        }


        public DateTime GetFechaActual()
        {

            return (fecha = DateTime.Now);

        }





    }//Fin class
}
