using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTN.Winform.AppProyectopg3.Layers.Entities;
using UTN.Winform.AppProyectopg3.Layers.Persistencia;

namespace UTN.Winform.AppProyectopg3.Layers.DAL
{
    class DALLogin
    {

        #region agrega el usuario a la conexion
        public void Login(Usuario pUsuario)
        {

            StringBuilder conexion = new StringBuilder();

            // Lee la conexion default
            conexion.AppendFormat("{0}", ConfigurationManager.ConnectionStrings["default"].ConnectionString);
            // Agrega al usuario
            conexion.AppendFormat("User Id={0};Password={1}", pUsuario.Nombre, pUsuario.Contrasena);


            DataBase db = DatabaseFactory.CreateDataBase(conexion.ToString());

            this.GetUserLogeed();

        } 
        #endregion


        #region Obtiene el usuario logeado
        private void GetUserLogeed()
        {

            DataSet ds = null;
            string sql = @" select * from  Usuarios where Nombre = @Nombre ";



            SqlCommand command = new SqlCommand();
            // Pasar parámetros
            command.Parameters.AddWithValue("@Nombre", Usuario.GetInstance().Nombre);


            command.CommandText = sql;
            command.CommandType = CommandType.Text;

            using (DataBase db = DatabaseFactory.CreateDataBase(FactoryConexion.CrearConexion()))
            {
                ds = db.ExecuteReader(command, "query");
            }

            // Extraer la tabla 
            DataTable dt = ds.Tables[0];

            //Autor oAutor = null;

            if (dt.Rows.Count > 0)
            {

                {
                    Usuario.GetInstance().Id = int.Parse(dt.Rows[0]["ID"].ToString());
                    Usuario.GetInstance().Nombre = dt.Rows[0]["Nombre"].ToString().Trim();
                    Usuario.GetInstance().Roll = dt.Rows[0]["Roll"].ToString().Trim();
                    Usuario.GetInstance().Estado = Convert.ToBoolean(dt.Rows[0]["Estado"].ToString().Trim());

                };

            }

        } 
        #endregion




    }//fin class
}
