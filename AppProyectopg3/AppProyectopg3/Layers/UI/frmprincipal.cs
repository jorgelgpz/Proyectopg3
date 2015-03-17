using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using UTN.Winform.AppProyectopg3.Layers.Entities;
using UTN.Winform.AppProyectopg3.Layers.Util;

namespace UTN.Winform.AppProyectopg3.Layers.UI
{
    public partial class frmprincipal : Form
    {
        public frmprincipal()
        {
            InitializeComponent();
        }

        private void frmprincipal_Load(object sender, EventArgs e)
        {

            this.CultureInfo();

            // Obtiene fecha actual
            this.sslFecha.Text += Kronos.GetInstancia().GetFechaActual().ToShortDateString() + "\n";

            #region abre una ventana de loging
            frmLoging ofrmLoging = new frmLoging();

            try
            {
                ofrmLoging.ShowDialog(this);

                if (ofrmLoging.DialogResult != DialogResult.OK)
                {
                    Application.Exit();
                } 
            #endregion

                this.sslFecha.Text += string.Format("{0} >>> {1}",
                Usuario.GetInstance().Nombre, Usuario.GetInstance().Roll);

                

                if (ExternalApp.GetInstacia().TecladoIslive())
                {
                    ExternalApp.GetInstacia().KillTeclado();
                }

            }
            catch (Exception er)
            {

                StringBuilder msg = new StringBuilder();
                msg.AppendFormat("Message        {0}\n", er.Message);
                msg.AppendFormat("Source         {0}\n", er.Source);

                MessageBox.Show(msg.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        #region cultereInfo
        private void CultureInfo()
        {
            // Colocar Cultura Estandar para Costa Rica
            // esto me permite no tener problemas con (.) de los decimales
            CultureInfo Micultura = new CultureInfo("es-CR", false);
            Micultura.NumberFormat.CurrencySymbol = "¢";
            Micultura.NumberFormat.CurrencyDecimalDigits = 2;
            Micultura.NumberFormat.CurrencyDecimalSeparator = ".";
            Micultura.NumberFormat.CurrencyGroupSeparator = ",";
            int[] grupo = new int[] { 3, 3, 3 };
            Micultura.NumberFormat.CurrencyGroupSizes = grupo;
            Micultura.NumberFormat.NumberDecimalDigits = 2;
            Micultura.NumberFormat.NumberGroupSeparator = ",";
            Micultura.NumberFormat.NumberDecimalSeparator = ".";
            Micultura.NumberFormat.NumberGroupSizes = grupo;
            //Micultura.DateTimeFormat.
            Thread.CurrentThread.CurrentCulture = Micultura;

        } 
        #endregion

        #region Mantenimientos
        private void mantenimientosToolStripMenuItem_Click(object sender, EventArgs e)
        {


            frmMantenimientos ofrmMantenimientos = new frmMantenimientos();

            try
            {
                ofrmMantenimientos.ShowDialog(this);

                if (ofrmMantenimientos.DialogResult != DialogResult.OK)
                {
                    ofrmMantenimientos.Close();

                    if (ExternalApp.GetInstacia().TecladoIslive())
                    {
                        ExternalApp.GetInstacia().KillTeclado();
                    }
                }


            }
            catch (Exception er)
            {

                StringBuilder msg = new StringBuilder();
                msg.AppendFormat("Message        {0}\n", er.Message);
                msg.AppendFormat("Source         {0}\n", er.Source);


                MessageBox.Show(msg.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        } 
        #endregion





        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



    }//fin class
}
