using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTN.Winform.AppProyectopg3.Layers.Entities;

namespace UTN.Winform.AppProyectopg3.Layers.Persistencia
{
    class FactoryConexion
    {

        public static string CrearConexion()
        {

            StringBuilder conexion = new StringBuilder();

            // Lee la conexion default
            conexion.AppendFormat("{0}", ConfigurationManager.ConnectionStrings["default"].ConnectionString);
            // Agrega al usuario
            conexion.AppendFormat("User Id={0};Password={1}", Usuario.GetInstance().Nombre, Usuario.GetInstance().Contrasena);

            return conexion.ToString();
        }
    }
}
