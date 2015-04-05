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

        public bool CampoMuyLargo500(string parametro)
        {
            this.LimpiaError();

            if (parametro.Length > 500)
            {
                Error = true;
                this.Descripcion = "Texto demasiado largo";
            }

            return Error;
        }

        public bool CampoMuyLargo1000(string parametro)
        {
            this.LimpiaError();

            if (parametro.Length > 1000)
            {
                Error = true;
                this.Descripcion = "Texto demasiado largo";
            }

            return Error;
        }

        public bool CampoNumerico(string parametro)
        {
            this.LimpiaError();

            try
            {

                Int32.Parse(parametro);

            }
            catch
            {

                Error = true;
                this.Descripcion = "El formato de entrada debe ser numerico";
            }


            return Error;

        }

        public bool CampoNumericoDouble(string parametro)
        {
            this.LimpiaError();

            try
            {

                double.Parse(parametro);

            }
            catch
            {

                Error = true;
                this.Descripcion = "El formato de entrada debe ser numerico";
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

