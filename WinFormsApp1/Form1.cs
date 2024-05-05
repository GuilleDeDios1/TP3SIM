using System;
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

            //Bicicleta da�ada
            float biciDa�adaNo = float.Parse(txtDa�ada0.Text);
            float biciDa�adaSi = float.Parse(txtDa�ada1.Text);

            //Inventario
            int tama�oPedido = int.Parse(txtTamPedi.Text);
            int puntoReposicion = int.Parse(txtPuntoRepo.Text);
            int stockIncial = int.Parse(txtStockInicial.Text);


            //EMPEZAMOS CON MONTECARLONCHO
            List<float> listaAnterior = new List<float>();
            List<float> listaActual = new List<float>();
            Random rnd = new Random();
            float stockOut = 0;
            bool bandera = false;
            List<List<float>> tablaMostrar = new List<List<float>>();

            for (int i = 1; i < cantidadSemanas; i++) {
                //agrega semana
                listaActual.Add(i);


                // Generar un n�mero aleatorio para la demanda de esta semana
                float rndDemanda = (float)rnd.NextDouble();

                // Calcular la demanda seg�n el n�mero aleatorio generado
                float demanda;
                if (rndDemanda < demanda0)
                    demanda = 0f;
                else if (rndDemanda < demanda0 + demanda1)
                    demanda = 1f;
                else if (rndDemanda < demanda0 + demanda1 + demanda2)
                    demanda = 2f;
                else
                    demanda = 3f;

                // Agregar el n�mero aleatorio de demanda y el valor de la demanda a la lista actual
                listaActual.Add(rndDemanda);
                listaActual.Add(demanda);

                // Controlar si llega un pedido esta semana utilizando la lista anterior
                if (i != 1 && listaAnterior[9] - listaActual[0] == 0) // Si es el d�a de llegada del pedido
                {
                    // Generar un n�mero aleatorio para determinar si llega una bicicleta da�ada
                    float rndDa�ada = (float)rnd.NextDouble();
                    // Determinar si la bicicleta est� da�ada
                    float bicicletaDa�ada = rndDa�ada > biciDa�adaNo ? 1 : 0;

                    // Agregar el valor aleatorio de la demanda a la lista actual
                    listaActual.Add(rndDa�ada);
                    // Agregar si la bicicleta est� da�ada o no a la lista actual
                    listaActual.Add(bicicletaDa�ada);
                }
                else
                {
                    // Si no es el d�a de llegada del pedido, agregar 0 en ambas columnas
                    listaActual.Add(0);
                    listaActual.Add(0);
                }

                //control de stock
                //si es mejor a 0
                if (i == 1) {
                    listaActual.Add(stockIncial - listaActual[2]);
                }
                if (i != 1 && listaAnterior[5] - listaActual[2] < 0)
                {
                    if (listaAnterior[9] - listaActual[0] == 0)
                    {
                        if (listaActual[4] == 1)
                        {
                            listaActual.Add((listaAnterior[5] - listaActual[2]) + tama�oPedido - 1);
                        }
                        else
                        {
                            listaActual.Add((listaAnterior[5] - listaActual[2]) + tama�oPedido);
                        }
                        bandera = false;
                    }
                    else {
                        listaActual.Add(0f);
                        stockOut = (listaAnterior[5] - listaActual[2]) * -1 * costoStockOut;

                    }
                }
                else {
                    //si es mayor a 0 y llega la reposicion
                    if (i != 1 && listaAnterior[9] - listaActual[0] == 0)
                    {
                        if (listaActual[4] == 1)
                        {
                            listaActual.Add((listaAnterior[5] - listaActual[2]) + tama�oPedido - 1);
                        }
                        else {
                            listaActual.Add((listaAnterior[5] - listaActual[2]) + tama�oPedido);
                        }
                        bandera = false;
                    }
                    else {
                        if (i != 1) {
                            listaActual.Add(listaAnterior[5] - listaActual[2]);
                        }
                    }
                    
                }

                //Orden
                if (i != 1 && listaActual[5] <= puntoReposicion && listaAnterior[9] == 0)
                {
                    listaActual.Add(1f);
                }
                else {
                    listaActual.Add(0f);
                }

                //AgregaDemora
                if (listaActual[6] == 1) { listaActual.Add((float)rnd.NextDouble()); }
                else { listaActual.Add(0f); }

                // Controlar el valor de demora seg�n el n�mero aleatorio generado
                if (listaActual[6] == 1) {
                    if (listaActual[7] < tiempoEntrega1)
                    {
                        listaActual.Add(1f);
                    }
                    else if (listaActual[7] < tiempoEntrega1 + tiempoEntrega2)
                    {
                        listaActual.Add(2f);
                    }
                    else if (listaActual[7] < tiempoEntrega1 + tiempoEntrega2 + tiempoEntrega3)
                    {
                        listaActual.Add(3f);
                    }
                }
                else { listaActual.Add(0f); }

                //dia de llegada del pedido
                if (bandera)
                {
                    listaActual.Add(listaAnterior[9]);
                }
                else {
                    if (listaActual[6] == 1 && bandera == false)
                    {
                        listaActual.Add(listaActual[0] + listaActual[8]);
                        bandera = true;
                    }
                    else { listaActual.Add(0f); }
                }

                //KO
                if (listaActual[6] == 1)
                {
                    listaActual.Add(costoPedido);
                }
                else {
                    listaActual.Add(0f);
                }

                //KM
                listaActual.Add(listaActual[5] * costoMantenimieto);

                //Ks
                listaActual.Add(stockOut);
                stockOut = 0;

                //costo total
                listaActual.Add(listaActual[10] + listaActual[11] + listaActual[12]);

                //costo acumulado
                if (i != 1)
                {
                    listaActual.Add(listaAnterior[14] + listaActual[13]);
                }
                else {
                    listaActual.Add(listaActual[13]);
                }
                //costo promedio
                listaActual.Add(listaActual[14] / listaActual[0]);

                listaAnterior = listaActual;

                //llenamos la matriz
                if (i >= desde && i < desde + hasta) {
                    tablaMostrar.Add(listaActual);
                }
               

                listaActual = new List<float>();
            }
            frmTablaResultados fr = new frmTablaResultados(tablaMostrar);
            fr.ShowDialog();
        }
    }
}
