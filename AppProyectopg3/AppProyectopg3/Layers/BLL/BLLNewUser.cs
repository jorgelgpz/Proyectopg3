using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTN.Winform.AppProyectopg3.Layers.DAL;
using UTN.Winform.AppProyectopg3.Layers.Entities;

namespace UTN.Winform.AppProyectopg3.Layers.BLL
{
    class BLLNewUser
    {

        public void NewUser(Usuario pUsuario) {

            DALLNewUser _DALLNewUser = new DALLNewUser();
            _DALLNewUser.NewUserDataBase(pUsuario);
        
        }

    }
}
