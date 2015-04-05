using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTN.Winform.AppProyectopg3.Layers.DAL.DALMantenimientos;
using UTN.Winform.AppProyectopg3.Layers.Entities;

namespace UTN.Winform.AppProyectopg3.Layers.BLL.BLLMantenimientos
{
    class BLLSalarioBase
    {

        public void InsertNewSalarioBase(SalarioBase pSalarioBase)
        {

            DALSalarioBase oDALSalarioBase = new DALSalarioBase();
            oDALSalarioBase.InsertNewSalarioBase(pSalarioBase);
        }

        public List<SalarioBase> GetListaSalarioBase()
        {
            DALSalarioBase oDALSalarioBase = new DALSalarioBase();
            return oDALSalarioBase.GetListaSalarioBase();
        }

        public void ActualizaSalarioBase(SalarioBase pSalarioBase)
        {
            DALSalarioBase oDALSalarioBase = new DALSalarioBase();
            oDALSalarioBase.ActualizaSalarioBase(pSalarioBase);
        }

        public void DeleteLogicalSalarioBase(SalarioBase pSalarioBase)
        {
            DALSalarioBase oDALSalarioBase = new DALSalarioBase();
            oDALSalarioBase.DeleteLogicalSalarioBase(pSalarioBase);
        }



    }
}
