using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTN.Winform.AppProyectopg3.Layers.Interfaces;

namespace UTN.Winform.AppProyectopg3.Layers.Entities.DTO
{
    class Users : IUser
    {
        public string Nombre { get; set; }

        public string Roll { get; set; }

        public byte[] Foto { get; set; }

        
    }//fin class
}
