using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTN.Winform.AppProyectopg3.Layers.DAL.DALMantenimientos;
using UTN.Winform.AppProyectopg3.Layers.Entities.DTO;

namespace UTN.Winform.AppProyectopg3.Layers.BLL.BLLMantenimientos
{
    class BLLMantenimientos
    {
        public List<Users> GetUsuarios() {

            DALLUsers _DALLUsers = new DALLUsers();
            return _DALLUsers.GetUsuarios();
        
        }

    }//fin class
}
