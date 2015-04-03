using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTN.Winform.AppProyectopg3.Layers.Persistencia;

namespace UTN.Winform.AppProyectopg3.Layers.DAL
{
    class DALConsecutivos
    {


        #region Obtiene consecutivo de Delitos

        internal static int GetConsecutivoDelitos()
        {

            // Investigue como crear secuencias en SQLServer
            //http://technet.microsoft.com/es-es/library/ff878091.aspx
            // CREATE SEQUENCE SecuenciaNoFactura  START WITH 1 INCREMENT BY 1 ;


            DataSet ds = null;
            string sql = @"SELECT NEXT VALUE FOR SequenceDelitos";

            SqlCommand command = new SqlCommand();


            command.CommandText = sql;
            command.CommandType = CommandType.Text;

            using (DataBase db = DatabaseFactory.CreateDataBase(FactoryConexion.CrearConexion()))
            {
                ds = db.ExecuteReader(command, "query");
            }

            // Extraer la tabla 
            DataTable dt = ds.Tables[0];

            return int.Parse(dt.Rows[0][0].ToString());

        }
        #endregion

        #region Obtiene consecutivo de CentroPenales

        internal static int GetConsecutivoCentroPenales()
        {

            // Investigue como crear secuencias en SQLServer
            //http://technet.microsoft.com/es-es/library/ff878091.aspx
            // CREATE SEQUENCE SecuenciaNoFactura  START WITH 1 INCREMENT BY 1 ;


            DataSet ds = null;
            string sql = @"SELECT NEXT VALUE FOR SequenceCentroPenales";

            SqlCommand command = new SqlCommand();


            command.CommandText = sql;
            command.CommandType = CommandType.Text;

            using (DataBase db = DatabaseFactory.CreateDataBase(FactoryConexion.CrearConexion()))
            {
                ds = db.ExecuteReader(command, "query");
            }

            // Extraer la tabla 
            DataTable dt = ds.Tables[0];

            return int.Parse(dt.Rows[0][0].ToString());

        }
        #endregion

        #region Obtiene consecutivo de Fotos

        internal static int GetConsecutivoFotos()
        {

            // Investigue como crear secuencias en SQLServer
            //http://technet.microsoft.com/es-es/library/ff878091.aspx
            // CREATE SEQUENCE SecuenciaNoFactura  START WITH 1 INCREMENT BY 1 ;


            DataSet ds = null;
            string sql = @"SELECT NEXT VALUE FOR SequenceFotos";

            SqlCommand command = new SqlCommand();


            command.CommandText = sql;
            command.CommandType = CommandType.Text;

            using (DataBase db = DatabaseFactory.CreateDataBase(FactoryConexion.CrearConexion()))
            {
                ds = db.ExecuteReader(command, "query");
            }

            // Extraer la tabla 
            DataTable dt = ds.Tables[0];

            return int.Parse(dt.Rows[0][0].ToString());

        }
        #endregion

        #region Obtiene consecutivo de SalarioBase

        internal static int GetConsecutivoSalarioBase()
        {

            // Investigue como crear secuencias en SQLServer
            //http://technet.microsoft.com/es-es/library/ff878091.aspx
            // CREATE SEQUENCE SecuenciaNoFactura  START WITH 1 INCREMENT BY 1 ;


            DataSet ds = null;
            string sql = @"SELECT NEXT VALUE FOR SequenceSalarioBase";

            SqlCommand command = new SqlCommand();


            command.CommandText = sql;
            command.CommandType = CommandType.Text;

            using (DataBase db = DatabaseFactory.CreateDataBase(FactoryConexion.CrearConexion()))
            {
                ds = db.ExecuteReader(command, "query");
            }

            // Extraer la tabla 
            DataTable dt = ds.Tables[0];

            return int.Parse(dt.Rows[0][0].ToString());

        }
        #endregion

        #region Obtiene consecutivo de Eventos

        internal static int GetConsecutivoEventos()
        {

            // Investigue como crear secuencias en SQLServer
            //http://technet.microsoft.com/es-es/library/ff878091.aspx
            // CREATE SEQUENCE SecuenciaNoFactura  START WITH 1 INCREMENT BY 1 ;


            DataSet ds = null;
            string sql = @"SELECT NEXT VALUE FOR SequenceEventos";

            SqlCommand command = new SqlCommand();


            command.CommandText = sql;
            command.CommandType = CommandType.Text;

            using (DataBase db = DatabaseFactory.CreateDataBase(FactoryConexion.CrearConexion()))
            {
                ds = db.ExecuteReader(command, "query");
            }

            // Extraer la tabla 
            DataTable dt = ds.Tables[0];

            return int.Parse(dt.Rows[0][0].ToString());

        }
        #endregion

        #region Obtiene consecutivo de Reclusos

        internal static int GetConsecutivoReclusos()
        {

            // Investigue como crear secuencias en SQLServer
            //http://technet.microsoft.com/es-es/library/ff878091.aspx
            // CREATE SEQUENCE SecuenciaNoFactura  START WITH 1 INCREMENT BY 1 ;


            DataSet ds = null;
            string sql = @"SELECT NEXT VALUE FOR SequenceReclusos";

            SqlCommand command = new SqlCommand();


            command.CommandText = sql;
            command.CommandType = CommandType.Text;

            using (DataBase db = DatabaseFactory.CreateDataBase(FactoryConexion.CrearConexion()))
            {
                ds = db.ExecuteReader(command, "query");
            }

            // Extraer la tabla 
            DataTable dt = ds.Tables[0];

            return int.Parse(dt.Rows[0][0].ToString());

        }
        #endregion




    }//fin class
}
