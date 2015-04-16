using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTN.Winform.AppProyectopg3.Layers.DAL.DALMantenimientos;
using UTN.Winform.AppProyectopg3.Layers.Entities;
using UTN.Winform.AppProyectopg3.Layers.Entities.DTO;

namespace UTN.Winform.AppProyectopg3.Layers.BLL.BLLMantenimientos
{
    class BLLDelitosReclusos
    {

        public void InsertNewDelito(DelitosReclusos pDelitosReclusos)
        {

            DALDelitosReclusos oDALDelitosReclusos = new DALDelitosReclusos();
            oDALDelitosReclusos.InsertNewDelito(pDelitosReclusos);
        }

        public void BorrarDelitoRecluso(DelitosReclusos pDelitosReclusos)
        {
            DALDelitosReclusos oDALDelitosReclusos = new DALDelitosReclusos();
            oDALDelitosReclusos.BorrarDelitoRecluso(pDelitosReclusos);
        }

        public List<DelitosReclusos> ObtieneListaDelitosReclusos(string reclusoid)
        {
            List<DelitosReclusos> lista = new List<DelitosReclusos>();

            DALDelitos oDALDelitos = new DALDelitos();
            DALDelitosReclusos oDALDelitosReclusos = new DALDelitosReclusos();


            foreach (DelitosReclusos item in oDALDelitosReclusos.GetListaDelitosReclusos(reclusoid))
            {
                DelitosReclusos oDelitosReclusos = new DelitosReclusos();

                oDelitosReclusos.FechaInicio = item.FechaInicio;
                oDelitosReclusos.FechaSalida = item.FechaSalida;

                foreach (Delitos delito in oDALDelitos.GetListaDelitos())
                {

                    if (delito.Id == item.DelitosID)
                    {
                      
                        oDelitosReclusos.Descripcion = delito.descripcion;
                    }
                }

                lista.Add(oDelitosReclusos);

            }

            return lista;
        }


    }//fin class
}
