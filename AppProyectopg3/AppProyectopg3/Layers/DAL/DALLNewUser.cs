using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTN.Winform.AppProyectopg3.Layers.Entities;
using UTN.Winform.AppProyectopg3.Layers.Persistencia;

namespace UTN.Winform.AppProyectopg3.Layers.DAL
{
    class DALLNewUser
    {

        #region Crea un nuevo usuario en la base de datos

        public void NewUserDataBase(Usuario pUsuario)
        {

            try
            {

                /*CREATE LOGIN [MARIA] WITH PASSWORD=N'123', DEFAULT_DATABASE=[EBook_Store],
                CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF

                EXEC master..sp_addsrvrolemember @loginame = N'MARIA', @rolename = N'sysadmin'
                USE [EBook_Store]
                CREATE USER [MARIA] FOR LOGIN [MARIA] */
                // Creo el Login

                StringBuilder sql = new StringBuilder();
                sql.AppendFormat("CREATE LOGIN [{0}] WITH PASSWORD=N'{1}', DEFAULT_DATABASE=[{2}],CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF ",
                pUsuario.NombreNew, pUsuario.ContrasenaNew, "Proyectopg3");
                sql.AppendFormat("EXEC master..sp_addsrvrolemember @loginame = N'{0}', @rolename = N'sysadmin'   ", pUsuario.NombreNew);
                sql.AppendFormat("USE [{0}]  ", "Proyectopg3");
                sql.AppendFormat("CREATE USER [{0}] FOR LOGIN [{1}]  ", pUsuario.NombreNew, pUsuario.NombreNew);
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = sql.ToString();

                using (DataBase db = DatabaseFactory.CreateDataBase(FactoryConexion.CrearConexion()))
                {
                    db.ExecuteNonQuery(cmd);

                }

                this.InsertNewUser(pUsuario);

            }
            catch (Exception)
            {

                throw;

            }

        } 
        #endregion

        #region Inserta un nuevo usuario en la tabla

        public void InsertNewUser(Usuario pUsuario)
        {
            int consecutivo = this.GetConsecutivo();

            string sql = @"usp_INSERT_Usuarios";


            SqlCommand command = new SqlCommand();

            // Pasar parámetros
            command.Parameters.AddWithValue("@id", consecutivo);
            command.Parameters.AddWithValue("@nombre", pUsuario.NombreNew);
            command.Parameters.AddWithValue("@roll", pUsuario.RollNew);
            command.Parameters.AddWithValue("@estado", "true");
            command.Parameters.AddWithValue("@Foto", pUsuario.Foto);

            command.CommandText = sql;
            command.CommandType = CommandType.StoredProcedure;


            using (DataBase db = DatabaseFactory.CreateDataBase(FactoryConexion.CrearConexion()))
            {
                db.ExecuteNonQuery(command, IsolationLevel.ReadCommitted);
            }

        } 
        #endregion

        #region Obtiene consecutivo

        internal int GetConsecutivo()
        {

            // Investigue como crear secuencias en SQLServer
            //http://technet.microsoft.com/es-es/library/ff878091.aspx
            // CREATE SEQUENCE SecuenciaNoFactura  START WITH 1 INCREMENT BY 1 ;


            DataSet ds = null;
            string sql = @"SELECT NEXT VALUE FOR SequenceUser";

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
