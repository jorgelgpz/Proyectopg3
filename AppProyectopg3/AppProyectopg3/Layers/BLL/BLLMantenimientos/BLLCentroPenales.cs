using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTN.Winform.AppProyectopg3.Layers.DAL.DALMantenimientos;
using UTN.Winform.AppProyectopg3.Layers.Entities;

namespace UTN.Winform.AppProyectopg3.Layers.BLL.BLLMantenimientos
{
    class BLLCentroPenales
    {


        public void InsertNewCentroPenales(CentroPenales pCentroPenales)
        {
            DALCentroPenales oDALCentroPenales = new DALCentroPenales();
            oDALCentroPenales.InsertNewCentroPenales(pCentroPenales);
        }

        public List<CentroPenales> GetListaPenales()
        {
            DALCentroPenales oDALCentroPenales = new DALCentroPenales();
            return oDALCentroPenales.GetListaPenales();
        }

        public void ActualizaCentroPenales(CentroPenales pCentroPenales)
        {
            DALCentroPenales oDALCentroPenales = new DALCentroPenales();
            oDALCentroPenales.ActualizaCentroPenales(pCentroPenales);
        }

        public void DeleteLogicalCentroPenales(CentroPenales pCentroPenales)
        {
            DALCentroPenales oDALCentroPenales = new DALCentroPenales();
            oDALCentroPenales.DeleteLogicalCentroPenales(pCentroPenales);
        }


    }
}
