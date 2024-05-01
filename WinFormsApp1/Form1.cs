using System.Globalization;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            montecarlo();
        }

        private void montecarlo() {
            //datos de la simulacion
            int cantidadSemanas = int.Parse(txtNroSimulaciones.Text);
            int desde = int.Parse(txtIntDesde.Text);
            int hasta = int.Parse(txtIntHasta.Text);

            //demanda por semana
            float demanda0 = float.Parse(txtDemd0.Text);
            float demanda1 = float.Parse(txtDemd1.Text);
            float demanda2 = float.Parse(txtDemd2.Text);
            float demanda3 = float.Parse(txtDemd3.Text);

            //Tiempo de entrega
            float tiempoEntrega1 = float.Parse(txtTiempEntr1.Text);
            float tiempoEntrega2 = float.Parse(txtTiempEntr2.Text);
            float tiempoEntrega3 = float.Parse(txtTiempEntr3.Text);

            //Costos
            float costoMantenimieto = float.Parse(txtCostoMant.Text);
            float costoPedido = float.Parse(txtCostoPedi.Text);
            float costoStockOut = float.Parse(txtCostoSO.Text);

            //Bicicleta dañada
            float biciDañadaNo = float.Parse(txtDañada0.Text);
            float biciDañadaSi = float.Parse(txtDañada1.Text);

            //Inventario
            int tamañoPedido = int.Parse(txtTamPedi.Text);
            int puntoReposicion = int.Parse(txtPuntoRepo.Text);
            int stockIncial = int.Parse(txtStockInicial.Text);


            //EMPEZAMOS CON MONTECARLONCHO

        }
    }
}
