using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Reportes : Form
    {
        public Reportes()
        {
            InitializeComponent();
        }

        private void Reportes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'VILLAEJEMPLODataSet.VKardex' Puede moverla o quitarla según sea necesario.
            this.VKardexTableAdapter.Fill(this.VILLAEJEMPLODataSet.VKardex);

            this.reportViewer1.RefreshReport();
        }
    }
}
