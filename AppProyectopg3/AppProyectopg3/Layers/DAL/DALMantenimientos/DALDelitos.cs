using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTN.Winform.AppProyectopg3.Layers.Entities;
using UTN.Winform.AppProyectopg3.Layers.Persistencia;

namespace UTN.Winform.AppProyectopg3.Layers.DAL.DALMantenimientos
{
    class DALDelitos
    {

        #region Inserta un nuevo usuario en la tabla

        public void InsertNewDelito(Delitos pDelitos)
        {


            int consecutivo = DALConsecutivos.GetConsecutivoDelitos();

            string sql = @"usp_INSERT_Delitos";


            SqlCommand command = new SqlCommand();

            // Pasar parámetros
            command.Parameters.AddWithValue("@ID", consecutivo);
            command.Parameters.AddWithValue("@Descripcion", pDelitos.descripcion);
            command.Parameters.AddWithValue("@Estado", "true");

            command.CommandText = sql;
            command.CommandType = CommandType.StoredProcedure;


            using (DataBase db = DatabaseFactory.CreateDataBase(FactoryConexion.CrearConexion()))
            {
                db.ExecuteNonQuery(command, IsolationLevel.ReadCommitted);
            }

        }
        #endregion

        #region Obtiene lista de Delitos

        public List<Delitos> GetListaDelitos()
        {
      
            DataSet ds = null;
            string sql = @"usp_SELECT_Delitos_All";

            SqlCommand command = new SqlCommand();
            command.CommandText = sql;
            command.CommandType = CommandType.Text;

            using (DataBase db = DatabaseFactory.CreateDataBase(FactoryConexion.CrearConexion()))
            {
                ds = db.ExecuteReader(command, "query");
            }


            List<Delitos> lista = new List<Delitos>();


            if (ds.Tables[0].Rows.Count > 0)
            {

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    if (dr["estado"].ToString().Trim().Equals("true"))
                    {

                        Delitos oDelitos = new Delitos()

                        {
                            Id = Convert.ToInt32(dr["ID"].ToString()),
                            descripcion = dr["Descripcion"].ToString().Trim()

                        };



                        lista.Add(oDelitos);
                    }
                }

            }

            return lista;
        }
        #endregion


        #region ActualizaDelito
        public void ActualizaDelito(Delitos pDelitos)
        {


            string sql = @"usp_UPDATE_Delitos";


            SqlCommand command = new SqlCommand();

            // Pasar parámetros
            command.Parameters.AddWithValue("@ID", pDelitos.Id);
            command.Parameters.AddWithValue("@Descripcion", pDelitos.descripcion);
       

            command.CommandText = sql;
            command.CommandType = CommandType.StoredProcedure;


            using (DataBase db = DatabaseFactory.CreateDataBase(FactoryConexion.CrearConexion()))
            {
                db.ExecuteNonQuery(command, IsolationLevel.ReadCommitted);
            }

        }
        #endregion

        #region EliminaLogicaMenteDelito
        public void DeleteLogicalDelitos(Delitos pDelitos)
        {


            string sql = @"usp_DELETELOGICO_Delitos_ByID";


            SqlCommand command = new SqlCommand();

            // Pasar parámetros
            command.Parameters.AddWithValue("@ID", pDelitos.Id);
            command.Parameters.AddWithValue("@Estado", "false");


            command.CommandText = sql;
            command.CommandType = CommandType.StoredProcedure;


            using (DataBase db = DatabaseFactory.CreateDataBase(FactoryConexion.CrearConexion()))
            {
                db.ExecuteNonQuery(command, IsolationLevel.ReadCommitted);
            }

        }
        #endregion





    }
}
