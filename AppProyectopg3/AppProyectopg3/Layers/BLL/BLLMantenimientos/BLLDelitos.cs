using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTN.Winform.AppProyectopg3.Layers.DAL.DALMantenimientos;
using UTN.Winform.AppProyectopg3.Layers.Entities;

namespace UTN.Winform.AppProyectopg3.Layers.BLL.BLLMantenimientos
{
    class BLLDelitos
    {

        public void InsertNewDelito(Delitos pDelitos)
        {
            DALDelitos oDALDelitos = new DALDelitos();
            oDALDelitos.InsertNewDelito(pDelitos);
        }

        public List<Delitos> GetListaDelitos()
        {
            DALDelitos oDALDelitos = new DALDelitos();
            return oDALDelitos.GetListaDelitos();
        }

        public void ActualizaDelitos(Delitos pDelitos)
        {
            DALDelitos oDALDelitos = new DALDelitos();
            oDALDelitos.ActualizaDelito(pDelitos);
        }

        public void DeleteLogicalDelitos(Delitos pDelitos)
        {
            DALDelitos oDALDelitos = new DALDelitos();
            oDALDelitos.DeleteLogicalDelitos(pDelitos);
        }



    }//fin class
}
