using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTN.Winform.AppProyectopg3.Layers.Util
{
    class ExternalApp
    {

        private static ExternalApp Instancia;
        

        private ExternalApp()
        {

        }

        public static ExternalApp GetInstacia()
        {

            if (Instancia == null)
            {
                Instancia = new ExternalApp();
            }

            return Instancia;
        }

        public void Teclado()
        {
            Process ExternalTeclado = new Process();
            ExternalTeclado.EnableRaisingEvents = false;
            ExternalTeclado.StartInfo.FileName = "osk";
            ExternalTeclado.StartInfo.Arguments = "";
            ExternalTeclado.Start();
            ExternalTeclado.WaitForExit();

        }

        public void KillTeclado() {

            Process[] ExternalTeclado = Process.GetProcessesByName("osk");
            ExternalTeclado[0].Kill();


        }

        public bool TecladoIslive()
        {

            Process[] ExternalTeclado = Process.GetProcessesByName("osk");

            if (ExternalTeclado.Length == 1) {
                return true;
            }

            return false;
        }






    }
}
