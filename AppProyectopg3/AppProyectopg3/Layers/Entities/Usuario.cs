using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTN.Winform.AppProyectopg3.Layers.Entities
{
    class Usuario
    {

        public int Id { get; set; }
        public string Nombre { set; get; }
        public string NombreNew { set; get; }
        public string Contrasena { set; get; }
        public string ContrasenaNew { set; get; }
        public string Roll { get; set; }
        public string RollNew { get; set; }
        public bool Estado { get; set; }
        public byte[] Foto { get; set; }

        public static Usuario _Usuario;

        private Usuario() { }

        public static Usuario GetInstance()
        {
            if (_Usuario == null)
                _Usuario = new Usuario();

            return _Usuario;
        }



    }
}
