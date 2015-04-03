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
    class DALCentroPenales
    {

        #region Inserta un nuevo centro penal en la tabla

        public void InsertNewCentroPenales(CentroPenales pCentroPenales)
        {


            int consecutivo = DALConsecutivos.GetConsecutivoCentroPenales();

            string sql = @"usp_INSERT_CentroPenales";


            SqlCommand command = new SqlCommand();

            // Pasar parámetros
            command.Parameters.AddWithValue("@ID", consecutivo);
            command.Parameters.AddWithValue("@Nombre", pCentroPenales.Nombre);
            command.Parameters.AddWithValue("@Direccion", pCentroPenales.Direccion);
            command.Parameters.AddWithValue("@Telefono1", pCentroPenales.Telefono1);
            command.Parameters.AddWithValue("@Telefono2", pCentroPenales.Telefono2);
            command.Parameters.AddWithValue("@Estado", "true");

            command.CommandText = sql;
            command.CommandType = CommandType.StoredProcedure;


            using (DataBase db = DatabaseFactory.CreateDataBase(FactoryConexion.CrearConexion()))
            {
                db.ExecuteNonQuery(command, IsolationLevel.ReadCommitted);
            }

        }
        #endregion

        #region Obtiene lista de Centros Penales

        public List<CentroPenales> GetListaPenales()
        {

            DataSet ds = null;
            string sql = @"usp_SELECT_CentroPenales_All";

            SqlCommand command = new SqlCommand();
            command.CommandText = sql;
            command.CommandType = CommandType.StoredProcedure;

            using (DataBase db = DatabaseFactory.CreateDataBase(FactoryConexion.CrearConexion()))
            {
                ds = db.ExecuteReader(command, "query");
            }


            List<CentroPenales> lista = new List<CentroPenales>();


            if (ds.Tables[0].Rows.Count > 0)
            {

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    if (dr["Estado"].ToString().Trim().Equals("true"))
                    {
                        CentroPenales oCentroPenales = new CentroPenales()

                        {
                            Id = Convert.ToInt32(dr["ID"].ToString()),
                            Nombre = dr["Nombre"].ToString().Trim(),
                            Direccion = dr["Direccion"].ToString().Trim(),
                            Telefono1 = Convert.ToInt32(dr["Telefono1"].ToString().Trim()),
                            Telefono2 = Convert.ToInt32(dr["Telefono2"].ToString().Trim())
                        };

                        lista.Add(oCentroPenales);
                    }


                }

            }

            return lista;
        }
        #endregion


        #region ActualizaCentroPenales
        public void ActualizaCentroPenales(CentroPenales pCentroPenales)
        {


            string sql = @"usp_UPDATE_CentroPenales";


            SqlCommand command = new SqlCommand();

            // Pasar parámetros
            command.Parameters.AddWithValue("@ID", pCentroPenales.Id);
            command.Parameters.AddWithValue("@Nombre", pCentroPenales.Nombre);
            command.Parameters.AddWithValue("@Direccion", pCentroPenales.Direccion);
            command.Parameters.AddWithValue("@Telefono1", pCentroPenales.Telefono1);
            command.Parameters.AddWithValue("@Telefono2", pCentroPenales.Telefono2);

            command.CommandText = sql;
            command.CommandType = CommandType.StoredProcedure;


            using (DataBase db = DatabaseFactory.CreateDataBase(FactoryConexion.CrearConexion()))
            {
                db.ExecuteNonQuery(command, IsolationLevel.ReadCommitted);
            }

        }
        #endregion

        #region EliminaLogicaMenteCentroPenales
        public void DeleteLogicalCentroPenales(CentroPenales pCentroPenales)
        {


            string sql = @"usp_UPDATE_CentroPenales";


            SqlCommand command = new SqlCommand();

            // Pasar parámetros
            command.Parameters.AddWithValue("@ID", pCentroPenales.Id);
            command.Parameters.AddWithValue("@Estado", "false");


            command.CommandText = sql;
            command.CommandType = CommandType.StoredProcedure;


            using (DataBase db = DatabaseFactory.CreateDataBase(FactoryConexion.CrearConexion()))
            {
                db.ExecuteNonQuery(command, IsolationLevel.ReadCommitted);
            }

        }
        #endregion







    }//fin class
}
