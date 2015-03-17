using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UTN.Winform.AppProyectopg3.Layers.Entities.DTO;
using UTN.Winform.AppProyectopg3.Layers.Persistencia;

namespace UTN.Winform.AppProyectopg3.Layers.DAL.DALMantenimientos
{
    class DALLUsers
    {


        #region Obtiene lista de usuarios

        public List<Users> GetUsuarios()
        {
            OpenFileDialog opt = new OpenFileDialog();
            opt.FileName = (@"C:\Users\jorge\documents\visual studio 2012\Projects\AppProyectopg3\AppProyectopg3\Resources\user168.png");
            //convierte la imagen a una cadena de bytes
            byte[] cadenaBytes;
            cadenaBytes = File.ReadAllBytes(opt.FileName);

            DataSet ds = null;
            string sql = @"usp_SELECT_Usuarios_All";

            SqlCommand command = new SqlCommand();
            command.CommandText = sql;
            command.CommandType = CommandType.Text;

            using (DataBase db = DatabaseFactory.CreateDataBase(FactoryConexion.CrearConexion()))
            {
                ds = db.ExecuteReader(command, "query");
            }


            List<Users> lista = new List<Users>();


            if (ds.Tables[0].Rows.Count > 0)
            {

                foreach (DataRow dr in ds.Tables[0].Rows)
                {

                    if (dr["Foto"].ToString().Length == 0)
                    {

                        Users oUsers = new Users()
                        {
                            Nombre = dr["Nombre"].ToString().Trim(),
                            Roll = dr["Roll"].ToString().Trim(),
                            Foto = (Byte[])cadenaBytes

                        };
                        lista.Add(oUsers);
                    }
                    else
                    {
                        Users oUsers = new Users()
                        {
                            Nombre = dr["Nombre"].ToString().Trim(),
                            Roll = dr["Roll"].ToString().Trim(),
                            Foto = (Byte[])dr["Foto"]
                        };
                        lista.Add(oUsers);
                    }



                }

            }

            return lista;
        } 
        #endregion
    
    
    }//fin class
}
