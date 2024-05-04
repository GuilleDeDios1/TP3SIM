using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class frmTablaResultados : Form
    {
        private List<float> matrizMostrar;

        public frmTablaResultados(List<float> matrizMostrar)
        {
            InitializeComponent();
            this.matrizMostrar = matrizMostrar;
        }

        private void frmTablaResultados_Load(object sender, EventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            foreach (var item in matrizMostrar)
            {
                row.Cells.Add(new DataGridViewTextBoxCell { Value = item });
            }
            mostrarMonteCarlo.Rows.Add(row);
        }
    }
}
