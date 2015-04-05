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
    class DALSalarioBase
    {



        #region Inserta un nuevo Salario Base en la tabla

        public void InsertNewSalarioBase(SalarioBase pSalarioBase)
        {


            int consecutivo = DALConsecutivos.GetConsecutivoSalarioBase();

            string sql = @"usp_INSERT_SalarioBase";


            SqlCommand command = new SqlCommand();

            // Pasar parámetros
            command.Parameters.AddWithValue("@ID", consecutivo);
            command.Parameters.AddWithValue("@Monto", pSalarioBase.Monto);
            command.Parameters.AddWithValue("@Estado", "true");

            command.CommandText = sql;
            command.CommandType = CommandType.StoredProcedure;


            using (DataBase db = DatabaseFactory.CreateDataBase(FactoryConexion.CrearConexion()))
            {
                db.ExecuteNonQuery(command, IsolationLevel.ReadCommitted);
            }

        }
        #endregion

        #region Obtiene lista de Salario Base

        public List<SalarioBase> GetListaSalarioBase()
        {

            DataSet ds = null;
            string sql = @"usp_SELECT_SalarioBase_All";

            SqlCommand command = new SqlCommand();
            command.CommandText = sql;
            command.CommandType = CommandType.Text;

            using (DataBase db = DatabaseFactory.CreateDataBase(FactoryConexion.CrearConexion()))
            {
                ds = db.ExecuteReader(command, "query");
            }


            List<SalarioBase> lista = new List<SalarioBase>();


            if (ds.Tables[0].Rows.Count > 0)
            {

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    if (dr["estado"].ToString().Trim().Equals("true"))
                    {

                        SalarioBase oSalarioBase = new SalarioBase()

                        {
                            ID = Convert.ToInt32(dr["ID"].ToString()),
                            Monto = Convert.ToDouble (dr["Monto"].ToString())

                        };



                        lista.Add(oSalarioBase);
                    }
                }

            }

            return lista;
        }
        #endregion


        #region ActualizaSalario Base
        public void ActualizaSalarioBase(SalarioBase pSalarioBase)
        {


            string sql = @"usp_UPDATE_SalarioBase";


            SqlCommand command = new SqlCommand();

            // Pasar parámetros
            command.Parameters.AddWithValue("@ID", pSalarioBase.ID);
            command.Parameters.AddWithValue("@Monto", pSalarioBase.Monto);


            command.CommandText = sql;
            command.CommandType = CommandType.StoredProcedure;


            using (DataBase db = DatabaseFactory.CreateDataBase(FactoryConexion.CrearConexion()))
            {
                db.ExecuteNonQuery(command, IsolationLevel.ReadCommitted);
            }

        }
        #endregion

        #region EliminaLogicaMenteSalarioBase
        public void DeleteLogicalSalarioBase(SalarioBase pSalarioBase)
        {


            string sql = @"usp_DELETELOGICO_SalarioBase_ByID";


            SqlCommand command = new SqlCommand();

            // Pasar parámetros
            command.Parameters.AddWithValue("@ID", pSalarioBase.ID);
          
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
