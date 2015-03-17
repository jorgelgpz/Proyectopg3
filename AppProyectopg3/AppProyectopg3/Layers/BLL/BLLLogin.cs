using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTN.Winform.AppProyectopg3.Layers.DAL;
using UTN.Winform.AppProyectopg3.Layers.Entities;

namespace UTN.Winform.AppProyectopg3.Layers.BLL
{
    class BLLLogin
    {
        public void Login(Usuario pUsuario)
        {
            DALLogin _DALLogin = new DALLogin();
            _DALLogin.Login(pUsuario);
        }
    }
}
