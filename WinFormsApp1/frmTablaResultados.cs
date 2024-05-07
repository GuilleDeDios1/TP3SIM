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
        private List<List<float>> matrizMostrar;

        public frmTablaResultados(List<List<float>> matrizMostrar)
        {
            InitializeComponent();
            this.matrizMostrar = matrizMostrar;
        }

        private void frmTablaResultados_Load(object sender, EventArgs e)
        {
            // Agregar filas al DataGridView
            mostrarMonteCarlo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            foreach (var fila in matrizMostrar)
            {
                DataGridViewRow row = new DataGridViewRow();
                // Agregar celdas a la fila
                foreach (var valor in fila)
                {
                    row.Cells.Add(new DataGridViewTextBoxCell { Value = valor });
                }
                // Agregar la fila al DataGridView
                mostrarMonteCarlo.Rows.Add(row);
            }
        }

        private void mostrarMonteCarlo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
