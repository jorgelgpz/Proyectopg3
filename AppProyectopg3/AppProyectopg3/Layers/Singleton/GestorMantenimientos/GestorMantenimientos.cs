using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTN.Winform.AppProyectopg3.Layers.BLL.BLLMantenimientos;
using UTN.Winform.AppProyectopg3.Layers.Entities;
using UTN.Winform.AppProyectopg3.Layers.Entities.DTO;

namespace UTN.Winform.AppProyectopg3.Layers.Singleton.GestorMantenimientos
{
    class GestorMantenimientos
    {

        #region Singleton
        private static GestorMantenimientos Instancia;

        private GestorMantenimientos()
        {

        }

        public static GestorMantenimientos GetInstacia()
        {

            if (Instancia == null)
            {
                Instancia = new GestorMantenimientos();
            }

            return Instancia;
        } 
        #endregion

        #region Get lista usuarios
        public List<Users> GetUsuarios()
        {

            BLLMantenimientos _BLLMantenimientos = new BLLMantenimientos();
            return _BLLMantenimientos.GetUsuarios();
        } 
        #endregion

        #region inserta delito
        public void InsertNewDelito(Delitos pDelitos)
        {
            BLLDelitos oBLLDelitos = new BLLDelitos();
            oBLLDelitos.InsertNewDelito(pDelitos);
        } 
        #endregion

        #region Get lista de delitos
        public List<Delitos> GetListaDelitos()
        {
            BLLDelitos OBLLDelitos = new BLLDelitos();
            return OBLLDelitos.GetListaDelitos();
        } 
        #endregion





    }//fin class
}
