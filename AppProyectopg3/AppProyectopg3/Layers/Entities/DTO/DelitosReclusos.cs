using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTN.Winform.AppProyectopg3.Layers.Entities.DTO
{
    class DelitosReclusos
    {

        public int ReclusosID { get; set; }
        public int DelitosID { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaSalida { get; set; }
        public string descripcion { get; set; }

    }
}
