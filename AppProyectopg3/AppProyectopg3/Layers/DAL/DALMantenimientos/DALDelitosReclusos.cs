using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTN.Winform.AppProyectopg3.Layers.Entities;
using UTN.Winform.AppProyectopg3.Layers.Entities.DTO;
using UTN.Winform.AppProyectopg3.Layers.Persistencia;

namespace UTN.Winform.AppProyectopg3.Layers.DAL.DALMantenimientos
{
    class DALDelitosReclusos
    {

        
         public void InsertNewDelito(DelitosReclusos pDelitosReclusos)
        {

            string sql = @"usp_INSERT_DelitosReclusos";


            SqlCommand command = new SqlCommand();

            // Pasar parámetros
            command.Parameters.AddWithValue("@ReclusosID", pDelitosReclusos.ReclusosID);
            command.Parameters.AddWithValue("@DelitosID", pDelitosReclusos.DelitosID);
            command.Parameters.AddWithValue("@FechaInicio", pDelitosReclusos.FechaInicio);
            command.Parameters.AddWithValue("@FechaSalida", pDelitosReclusos.FechaSalida);

            command.CommandText = sql;
            command.CommandType = CommandType.StoredProcedure;


            using (DataBase db = DatabaseFactory.CreateDataBase(FactoryConexion.CrearConexion()))
            {
                db.ExecuteNonQuery(command, IsolationLevel.ReadCommitted);
            }

        }

         #region Obtiene lista de Delitos Reclusos



         public List<DelitosReclusos> GetListaDelitosReclusos(string ReclusosID)
         {

             DataSet ds = null;
             string sql = @"usp_SELECT_DelitosReclusos_ByID";

             SqlCommand command = new SqlCommand();



             // Pasar parámetros
             command.Parameters.AddWithValue("@ReclusosID", ReclusosID);
             command.CommandText = sql;
             command.CommandType = CommandType.StoredProcedure;

             using (DataBase db = DatabaseFactory.CreateDataBase(FactoryConexion.CrearConexion()))
             {
                 ds = db.ExecuteReader(command, "query");
             }


             List<DelitosReclusos> lista = new List<DelitosReclusos>();


             if (ds.Tables[0].Rows.Count > 0)
             {

                 foreach (DataRow dr in ds.Tables[0].Rows)
                 {
                     DelitosReclusos oDelitosReclusos = new DelitosReclusos()

                     {
                         ReclusosID = Convert.ToInt32(dr["reclusosid"].ToString()),
                         DelitosID = Convert.ToInt32(dr["delitosid"].ToString()),
                         FechaInicio = Convert.ToDateTime( dr["fechainicio"]),
                         FechaSalida = Convert.ToDateTime(dr["fechasalida"])
                        
                     };



                     lista.Add(oDelitosReclusos);

                 }

             }

             return lista;
         }
         #endregion


         public void BorrarDelitoRecluso(DelitosReclusos pDelitosReclusos)
         {

             string sql = @"usp_DELETE_DelitosReclusos_ByID";


             SqlCommand command = new SqlCommand();

             // Pasar parámetros
             command.Parameters.AddWithValue("@ReclusosID", pDelitosReclusos.ReclusosID);
             command.Parameters.AddWithValue("@DelitosID", pDelitosReclusos.DelitosID);
            

             command.CommandText = sql;
             command.CommandType = CommandType.StoredProcedure;


             using (DataBase db = DatabaseFactory.CreateDataBase(FactoryConexion.CrearConexion()))
             {
                 db.ExecuteNonQuery(command, IsolationLevel.ReadCommitted);
             }

         }



       



    }//fin class
}
