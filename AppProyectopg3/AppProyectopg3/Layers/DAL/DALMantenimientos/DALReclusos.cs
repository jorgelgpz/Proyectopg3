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
    class DALReclusos
    {


        #region Inserta un nuevo evento en la tabla

        public void InsertNewReclusos(Reclusos pReclusos)
        {


            //  List<SqlCommand> lista = new List<SqlCommand>();

            string sqlReclusos = @"usp_INSERT_Reclusos";



            //int ID 
            //string Nacionalidad
            //string Nombre
            //string Apellidos
            //string Email
            //string Simpe
            //string TipoSangre
            //string Civil
            //int Telefono
            //string NombreContacto
            //string Notificaciones
            //DateTime FechaNacimiento
            //string Medico
            //string Trabaja
            //string Notas
            //byte[] Foto
            //byte[] Huella
            //byte[] Otros

            //int CentroPenal
            //int SeccionCarcelaria
            //int SalarioBase

            SqlCommand commandReclusos = new SqlCommand();
            // Pasar parámetros
            commandReclusos.Parameters.AddWithValue("@ID", pReclusos.ID);
            commandReclusos.Parameters.AddWithValue("@Nacionalidad", pReclusos.Nacionalidad);
            commandReclusos.Parameters.AddWithValue("@Nombre", pReclusos.Nombre);
            commandReclusos.Parameters.AddWithValue("@Apellidos", pReclusos.Apellidos);
            commandReclusos.Parameters.AddWithValue("@Email", pReclusos.Email);
            commandReclusos.Parameters.AddWithValue("@Simpe", pReclusos.Simpe);
            commandReclusos.Parameters.AddWithValue("@TipoSangre", pReclusos.TipoSangre);
            commandReclusos.Parameters.AddWithValue("@Civil", pReclusos.Civil);
            commandReclusos.Parameters.AddWithValue("@Telefono", pReclusos.Telefono);
            commandReclusos.Parameters.AddWithValue("@NombreContacto", pReclusos.NombreContacto);
            commandReclusos.Parameters.AddWithValue("@Notificaciones", pReclusos.Notificaciones);
            commandReclusos.Parameters.AddWithValue("@DateTime", pReclusos.FechaNacimiento);
            commandReclusos.Parameters.AddWithValue("@Medico", pReclusos.Medico);
            commandReclusos.Parameters.AddWithValue("@Trabaja", pReclusos.Trabaja);
            commandReclusos.Parameters.AddWithValue("@Notas", pReclusos.Notas);
            commandReclusos.Parameters.AddWithValue("@Foto", pReclusos.Foto);
            commandReclusos.Parameters.AddWithValue("@Huella", pReclusos.Huella);
            commandReclusos.Parameters.AddWithValue("@Otros", pReclusos.Otros);

            commandReclusos.Parameters.AddWithValue("@CentroPenal", pReclusos.CentroPenal);
            commandReclusos.Parameters.AddWithValue("@SeccionCarcelaria", pReclusos.SeccionCarcelaria);
            commandReclusos.Parameters.AddWithValue("@SalarioBase", pReclusos.SalarioBase);

            commandReclusos.Parameters.AddWithValue("@Estado", "true");

            commandReclusos.CommandText = sqlReclusos;
            commandReclusos.CommandType = CommandType.StoredProcedure;


            // lista.Add(commandReclusos);


            using (DataBase db = DatabaseFactory.CreateDataBase(FactoryConexion.CrearConexion()))
            {
                db.ExecuteNonQuery(commandReclusos, IsolationLevel.ReadCommitted);
            }

        }
        #endregion



        public bool IDexiste(int identificacion)
        {

            bool ok = false;
            int ID = 0;

            DataSet ds = null;
            string sql = @"usp_SELECT_Reclusos_Exite_ByID";

            SqlCommand command = new SqlCommand();
            command.CommandText = sql;
            command.CommandType = CommandType.Text;

            using (DataBase db = DatabaseFactory.CreateDataBase(FactoryConexion.CrearConexion()))
            {
                ds = db.ExecuteReader(command, "query");
            }

            // Extraer la tabla 

            DataTable dt = ds.Tables[0];



            if (dt.Rows.Count > 0)
            {

                ID = int.Parse(dt.Rows[0]["ID"].ToString());

                if (ID == identificacion)
                {
                    return true;
                }


            }


            return ok;


        }






        //#region Obtiene lista de eventos

        //public List<Eventos> GetListaEventos()
        //{

        //    DataSet ds = null;
        //    string sql = @"usp_SELECT_Eventos_All";

        //    SqlCommand command = new SqlCommand();
        //    command.CommandText = sql;
        //    command.CommandType = CommandType.Text;

        //    using (DataBase db = DatabaseFactory.CreateDataBase(FactoryConexion.CrearConexion()))
        //    {
        //        ds = db.ExecuteReader(command, "query");
        //    }


        //    List<Eventos> lista = new List<Eventos>();


        //    if (ds.Tables[0].Rows.Count > 0)
        //    {

        //        foreach (DataRow dr in ds.Tables[0].Rows)
        //        {
        //            if (dr["estado"].ToString().Trim().Equals("true"))
        //            {

        //                Eventos oEventos = new Eventos()

        //                {
        //                    ID = Convert.ToInt32(dr["ID"].ToString()),
        //                    Descripcion = dr["Descripcion"].ToString(),
        //                    Tipo = dr["Tipo"].ToString()

        //                };



        //                lista.Add(oEventos);
        //            }
        //        }

        //    }

        //    return lista;
        //}
        //#endregion


        //#region Actualiza evento
        //public void ActualizaEvento(Eventos pEventos)
        //{


        //    string sql = @"usp_UPDATE_Eventos";


        //    SqlCommand command = new SqlCommand();

        //    // Pasar parámetros
        //    command.Parameters.AddWithValue("@ID", pEventos.ID);
        //    command.Parameters.AddWithValue("@Descripcion", pEventos.Descripcion);
        //    command.Parameters.AddWithValue("@Tipo", pEventos.Tipo);


        //    command.CommandText = sql;
        //    command.CommandType = CommandType.StoredProcedure;


        //    using (DataBase db = DatabaseFactory.CreateDataBase(FactoryConexion.CrearConexion()))
        //    {
        //        db.ExecuteNonQuery(command, IsolationLevel.ReadCommitted);
        //    }

        //}
        //#endregion

        //#region EliminaLogicaMenteEventos

        //public void DeleteLogicalEventos(Eventos pEventos)
        //{


        //    string sql = @"usp_DELETELOGICO_Eventos_ByID";


        //    SqlCommand command = new SqlCommand();

        //    // Pasar parámetros
        //    command.Parameters.AddWithValue("@ID", pEventos.ID);

        //    command.CommandText = sql;
        //    command.CommandType = CommandType.StoredProcedure;


        //    using (DataBase db = DatabaseFactory.CreateDataBase(FactoryConexion.CrearConexion()))
        //    {
        //        db.ExecuteNonQuery(command, IsolationLevel.ReadCommitted);
        //    }

        //}
        //#endregion









    }
}
