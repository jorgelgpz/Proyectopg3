using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTN.Winform.AppProyectopg3.Layers.Util
{
    class Validaciones
    {


        private static Validaciones Instancia;
        private bool Error { get; set; }
        private string Descripcion { get; set; }


        private Validaciones()
        {
            LimpiaError();

        }

        private void LimpiaError()
        {
            this.Error = false;
            this.Descripcion = "";
        }

        public static Validaciones GetInstancia()
        {

            if (Instancia == null)
            {
                Instancia = new Validaciones();
            }

            return Instancia;

        }

        public bool CampoRequerido(string parametro)
        {
            this.LimpiaError();

            if (parametro.Length == 0)
            {
                Error = true;
                this.Descripcion = "Campo requerido";
            }

            return Error;
        }


        public string descripcion()
        {

            if (Error)
            {
                return this.Descripcion;
            }
            throw new Exception();
        }

    }




}

