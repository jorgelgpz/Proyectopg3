using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UTN.Winform.AppProyectopg3.Layers.Entities;
using UTN.Winform.AppProyectopg3.Layers.Singleton.GestorMantenimientos;
using UTN.Winform.AppProyectopg3.Layers.Singleton.GestorMantenimientos.MetodosEstaticos;

namespace UTN.Winform.AppProyectopg3.Layers.UI
{
    public partial class frmEventosReclusos : Form
    {


        List<Eventos> lista = new List<Eventos>();
        int indiceDGVEventosReclusos = 0;
        bool okDGVEventos = false;


        public frmEventosReclusos()
        {
            InitializeComponent();

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                CargarDGVEventosReclusos();


            }
            catch (Exception er)
            {

                StringBuilder msg = new StringBuilder();
                msg.AppendFormat("Message        {0}\n", er.Message);
                msg.AppendFormat("Source         {0}\n", er.Source);

                MessageBox.Show(msg.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void CargarDGVEventosReclusos()
        {
            this.dgvEventosReclusos.DataSource = null;
            this.dgvEventosReclusos.AutoGenerateColumns = false;
            this.dgvEventosReclusos.DataSource = lista;
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {

            try
            {
                if (okDGVEventos)
                {
                    lista.RemoveAt(this.indiceDGVEventosReclusos);

                    if (Estaticos.GetInstacia().GetListaEventos().Count() > 0)
                    {
                        //Estaticos.GetInstacia().SetRemoveATListaEventos(this.indiceDGVEventosReclusos);
                        Estaticos.GetInstacia().SetListaEventos(lista);

                        this.dgvEventosReclusos.DataSource = null;
                        this.dgvEventosReclusos.AutoGenerateColumns = false;
                        this.dgvEventosReclusos.DataSource = Estaticos.GetInstacia().GetListaEventos();

                    }
                    else
                    {

                        CargarDGVEventosReclusos();
                    }
                }
                okDGVEventos = false;

            }
            catch (Exception er)
            {

                StringBuilder msg = new StringBuilder();
                msg.AppendFormat("Message        {0}\n", er.Message);
                msg.AppendFormat("Source         {0}\n", er.Source);

                MessageBox.Show(msg.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void frmEventosReclusos_Load(object sender, EventArgs e)
        {
            this.dgvEventos.DataSource = GestorMantenimientos.GetInstacia().GetListaEventos();

            if (Estaticos.GetInstacia().GetListaEventos().Count() > 0)
            {
                lista = Estaticos.GetInstacia().GetListaEventos();
                this.dgvEventosReclusos.DataSource = null;
                this.dgvEventosReclusos.AutoGenerateColumns = false;
                this.dgvEventosReclusos.DataSource = lista;
            }
        }

        private void dgvEventos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Eventos oEventos = new Eventos();


                if (e.RowIndex >= 0 && this.dgvEventos.SelectedRows.Count > 0)
                {

                    if (e.RowIndex >= 0)
                    {

                        oEventos = this.dgvEventos.SelectedRows[0].DataBoundItem as Eventos;

                        lista.Add(oEventos);

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

        private void dgvEventosReclusos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Eventos oEventos = new Eventos();


                if (e.RowIndex >= 0 && this.dgvEventosReclusos.SelectedRows.Count > 0)
                {

                    if (e.RowIndex >= 0)
                    {

                        indiceDGVEventosReclusos = e.RowIndex;
                        okDGVEventos = true;


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

        private void frmEventosReclusos_FormClosing(object sender, FormClosingEventArgs e)
        {
            Estaticos.GetInstacia().SetListaEventos(lista);

        }









    }
}
