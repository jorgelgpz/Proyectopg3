using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTN.Winform.AppProyectopg3.Layers.Entities
{
    class Reclusos
    {

        public int ID { get; set; }
        public string Nacionalidad { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Email { get; set; }
        public string Simpe { get; set; }
        public string TipoSangre { get; set; }
        public string Civil { get; set; }
        public int Telefono { get; set; }
        public string NombreContacto { get; set; }
        public string Notificaciones { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Medico { get; set; }
        public string Trabaja { get; set; }
        public string Notas { get; set; }
        public byte[] Foto { get; set; }
        public byte[] Huella { get; set; }
        public byte[] Otros { get; set; }

        public int CentroPenal { get; set; }
        public string SeccionCarcelaria { get; set; }
        public int SalarioBase { get; set; }





    }
}
