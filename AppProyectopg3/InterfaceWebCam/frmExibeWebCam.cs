using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace InterfaceWebCam
{
    public partial class frmExibeWebCam : Form
    {
        public frmExibeWebCam()
        {
            InitializeComponent();
            
            
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            userControl11.TomarFoto();
            userControl11.Stop();
            DialogResult = DialogResult.OK;
        }

     

        private void frmExibeWebCam_Load(object sender, EventArgs e)
        {
            //// Delete a file by using File class static method...
            //if (System.IO.File.Exists(@"C:\\temp\Foto.bmp"))
            //{
            //    // Use a try block to catch IOExceptions, to
            //    // handle the case of the file already being
            //    // opened by another process.
            //    try
            //    {
            //        System.IO.File.Delete(@"C:\\temp\Foto.bmp");
            //    }
            //    catch (System.IO.IOException er)
            //    {
            //        Console.WriteLine(er.Message);
            //        return;
            //    }

                userControl11.Start();
            //}
            
        }

    }//fin class
}
