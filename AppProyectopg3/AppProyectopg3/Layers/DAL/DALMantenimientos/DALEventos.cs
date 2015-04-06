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
    class DALEventos
    {


        #region Inserta un nuevo evento en la tabla

        public void InsertNewEvento(Eventos pEventos)
        {


            int consecutivo = DALConsecutivos.GetConsecutivoEventos();

            string sql = @"usp_INSERT_Eventos";


            SqlCommand command = new SqlCommand();

            // Pasar parámetros
            command.Parameters.AddWithValue("@ID", consecutivo);
            command.Parameters.AddWithValue("@Descripcion", pEventos.Descripcion);
            command.Parameters.AddWithValue("@Tipo", pEventos.Tipo);
            command.Parameters.AddWithValue("@Estado", "true");

            command.CommandText = sql;
            command.CommandType = CommandType.StoredProcedure;


            using (DataBase db = DatabaseFactory.CreateDataBase(FactoryConexion.CrearConexion()))
            {
                db.ExecuteNonQuery(command, IsolationLevel.ReadCommitted);
            }

        }
        #endregion

        #region Obtiene lista de eventos

        public List<Eventos> GetListaEventos()
        {

            DataSet ds = null;
            string sql = @"usp_SELECT_Eventos_All";

            SqlCommand command = new SqlCommand();
            command.CommandText = sql;
            command.CommandType = CommandType.Text;

            using (DataBase db = DatabaseFactory.CreateDataBase(FactoryConexion.CrearConexion()))
            {
                ds = db.ExecuteReader(command, "query");
            }


            List<Eventos> lista = new List<Eventos>();


            if (ds.Tables[0].Rows.Count > 0)
            {

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    if (dr["estado"].ToString().Trim().Equals("true"))
                    {

                        Eventos oEventos = new Eventos()

                        {
                            ID = Convert.ToInt32(dr["ID"].ToString()),
                            Descripcion = dr["Descripcion"].ToString(),
                            Tipo = dr["Tipo"].ToString()

                        };



                        lista.Add(oEventos);
                    }
                }

            }

            return lista;
        }
        #endregion


        #region Actualiza evento
        public void ActualizaEvento(Eventos pEventos)
        {


            string sql = @"usp_UPDATE_Eventos";


            SqlCommand command = new SqlCommand();

            // Pasar parámetros
            command.Parameters.AddWithValue("@ID", pEventos.ID);
            command.Parameters.AddWithValue("@Descripcion", pEventos.Descripcion);
            command.Parameters.AddWithValue("@Tipo", pEventos.Tipo);


            command.CommandText = sql;
            command.CommandType = CommandType.StoredProcedure;


            using (DataBase db = DatabaseFactory.CreateDataBase(FactoryConexion.CrearConexion()))
            {
                db.ExecuteNonQuery(command, IsolationLevel.ReadCommitted);
            }

        }
        #endregion

        #region EliminaLogicaMenteEventos

        public void DeleteLogicalEventos(Eventos pEventos)
        {


            string sql = @"usp_DELETELOGICO_Eventos_ByID";


            SqlCommand command = new SqlCommand();

            // Pasar parámetros
            command.Parameters.AddWithValue("@ID", pEventos.ID);

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
