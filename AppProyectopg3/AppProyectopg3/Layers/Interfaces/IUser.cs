using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTN.Winform.AppProyectopg3.Layers.Interfaces
{
    interface IUser
    {
         string Nombre { get; set; }
         string Roll { get; set; }
         byte[] Foto { get; set; }
    }
}
