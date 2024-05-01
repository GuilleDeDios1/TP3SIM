using System.Globalization;
using System.Reflection;

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
            List<float> listaAcumulada = new List<float>();
            List<float> listaActual = new List<float>();
            Random rnd = new Random();
            for (int i = 1; i < cantidadSemanas; i++) {
                //agrega reloj
                listaActual.Add(float.Parse(i.ToString()));
                //agrega random de demanda
                listaActual.Add((float) Math.Round(rnd.NextDouble(),2));
                //agrega el valor de la demanda
                if (listaActual[listaActual.Count - 1] <= 0.5) { listaActual.Add(0f); }
                else
                {
                    if (listaActual[listaActual.Count - 1] <= 0.65) { listaActual.Add(1f); }
                    else
                    {
                        if (listaActual[listaActual.Count - 1] <= 0.9) { listaActual.Add(2f); }
                        else
                        {
                            if (listaActual[listaActual.Count - 1] <= 0.99) { listaActual.Add(3f); }
                        }
                    }
                }

                //Agrega stock, si no es primer fila calcula
                if (listaActual[0] == 1)
                {
                    listaActual.Add(stockIncial - listaActual[listaActual.Count - 1]);
                }
                else {
                    listaActual.Add(listaAcumulada[3] - listaActual[listaActual.Count - 1]);
                }






                //agrega random de demora
                listaActual.Add((float)Math.Round(rnd.NextDouble(), 2));
                //agrega valor de la demora siempre y cuando la necesite
                if (listaActual[listaActual.Count - 1] <= 0.3) { listaActual.Add(1f); }
                else
                {
                    if (listaActual[listaActual.Count - 1] <= 0.7) { listaActual.Add(2f); }
                    else
                    {
                        if (listaActual[listaActual.Count - 1] <= 0.99) { listaActual.Add(3f); } 
                    }
                }
                
            }
        }
    }
}
