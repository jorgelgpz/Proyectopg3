using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTN.Winform.AppProyectopg3.Layers.DAL.DALMantenimientos;
using UTN.Winform.AppProyectopg3.Layers.Entities;

namespace UTN.Winform.AppProyectopg3.Layers.BLL.BLLMantenimientos
{
    class BLLEventos
    {

        public void InsertNewEvento(Eventos pEventos)
        {
            DALEventos oDALEventos = new DALEventos();
            oDALEventos.InsertNewEvento(pEventos);
        }

        public List<Eventos> GetListaEventos()
        {
            DALEventos oDALEventos = new DALEventos();
            return oDALEventos.GetListaEventos();
        }

        public void ActualizaEvento(Eventos pEventos)
        {
            DALEventos oDALEventos = new DALEventos();
            oDALEventos.ActualizaEvento(pEventos);
        }

        public void DeleteLogicalEventos(Eventos pEventos)
        {
            DALEventos oDALEventos = new DALEventos();
            oDALEventos.DeleteLogicalEventos(pEventos);
        }


    }//fin class
}
