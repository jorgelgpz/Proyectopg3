using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTN.Winform.AppProyectopg3.Layers.Entities;
using UTN.Winform.AppProyectopg3.Layers.Entities.DTO;

namespace UTN.Winform.AppProyectopg3.Layers.Singleton.GestorMantenimientos.MetodosEstaticos
{
     class Estaticos
    {
        
        private static Estaticos Instancia;
    

        private Estaticos()
        {

        }

        public static Estaticos GetInstacia()
        {

            if (Instancia == null)
            {
                Instancia = new Estaticos();
            }

            return Instancia;
        }

        public  void SetListaEventos(List<Eventos> plista)
        {
            
            LST_Eventos.ListaEventos = plista;
        }

        public  List<Eventos> GetListaEventos()
        {

            return LST_Eventos.ListaEventos;
        }

        public void LimpiaListaEventos() {

            LST_Eventos.ListaEventos = new List<Eventos>();
        }

        public void SetRemoveATListaEventos(int item)
        {

            LST_Eventos.ListaEventos.RemoveAt(item);
        }



    }
}
