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

            //Bicicleta dañada
            float biciDañadaNo = float.Parse(txtDañada0.Text);
            float biciDañadaSi = float.Parse(txtDañada1.Text);

            //Inventario
            int tamañoPedido = int.Parse(txtTamPedi.Text);
            int puntoReposicion = int.Parse(txtPuntoRepo.Text);
            int stockIncial = int.Parse(txtStockInicial.Text);


            //EMPEZAMOS CON MONTECARLONCHO
            float [] listaAnterior = new float [16];
            float [] listaActual = new float[16];
            Random rnd = new Random();
            float StockOut = 0;
            bool vanderaPedidoRealizado = false;
            float[,] matrizMostrar = new float[cantidadSemanas, 16];
            for (int i = 1; i < cantidadSemanas; i++) {

                //agrega reloj
                listaActual[0] = (float.Parse(i.ToString()));
                //agrega random de demanda
                listaActual[1] = ((float)Math.Round(rnd.NextDouble(), 2));
                //agrega el valor de la demanda
                if (listaActual[listaActual.Length - 1] <= demanda0) { listaActual[2]=(0f); }
                else
                {
                    if (listaActual[listaActual.Length - 1] <= demanda1 + demanda0) { listaActual[2] =(1f); }
                    else
                    {
                        if (listaActual[listaActual.Length - 1] <= demanda2 + demanda1 + demanda0) { listaActual[2] = (2f); }
                        else
                        {
                            if (listaActual[listaActual.Length - 1] <= demanda3 + demanda2 + demanda1 + demanda0) { listaActual[2] = (3f); }
                        }
                    }
                }

                //agregamos random en dañada
                if (i != 1 && listaActual[0] == listaAnterior[9])
                {
                    listaActual[3]=((float)Math.Round(rnd.NextDouble(), 2));
                }
                else {
                    listaActual[3]=(0f);
                }

                //agregamos valor a dañada
                if (listaActual[0] == 1) {
                    listaActual[4] = (0f);
                }
                else {
                    if (listaActual[0] == listaAnterior[9])
                    {
                        if (listaActual[3] < biciDañadaNo)
                        {
                            listaActual[4]=(0f);
                        }
                        else
                        {
                            listaActual[4]=(1f);
                        }
                    }
                    else
                    {
                        listaActual[4] = (0f);
                    }
                }

                //Agrega stock, si no es primer fila calcula
                if (listaActual[0] == 1)
                {
                    listaActual[5] = (stockIncial - listaActual[2]);
                }
                else {
                    //Si queda negativo
                    if (listaAnterior[5] - listaActual[2] < 0)
                    {
                        //si queda negativo pero hay llegada de stock
                        if (listaAnterior[9] == listaActual[0])
                        {
                            if (listaActual[4] == 1)
                            {
                                listaActual[5] = ((listaAnterior[5] + tamañoPedido) - listaActual[2] - 1);
                                vanderaPedidoRealizado = false;
                            }
                            else {
                                listaActual[5] = ((listaAnterior[5] + tamañoPedido) - listaActual[2]);
                                vanderaPedidoRealizado = false;
                            }

                        }
                        //Si queda negativo
                        else {
                            listaActual[5]=(0f);
                            StockOut = listaAnterior[5] - listaActual[2] * -1 * costoStockOut;
                        }

                    }
                    //Queda positivo
                    else
                    {
                        //Positivo pero hay llegada de stock
                        if (listaAnterior[9] == listaActual[0])
                        {
                            if (listaActual[4] == 1f)
                            {
                                listaActual[5]=((listaAnterior[5] + tamañoPedido) - listaActual[2] - 1);
                                vanderaPedidoRealizado = false;
                            }
                            else
                            {
                                listaActual[5]=((listaAnterior[5] + tamañoPedido) - listaActual[2]);
                                vanderaPedidoRealizado = false;
                            }
                        }
                        //positivo
                        else {
                            listaActual[5]=(listaAnterior[5] - listaActual[2]);
                        }
                    }
                }


                //Verificamos si hay que pedir
                if (listaActual[5] <= puntoReposicion && listaAnterior[9] == 0)
                {
                    listaActual[6] = (1f);
                }
                else
                {
                    listaActual[6] = (0f);
                }

                //agrega random de demora
                if (listaActual[6] == 1f) {
                    listaActual[7]=((float)Math.Round(rnd.NextDouble(), 2));
                }
                else
                {
                    listaActual[7]=(0f);
                }


                //agrega valor de la demora siempre y cuando la necesite
                if (listaActual[listaActual.Length - 1] <= tiempoEntrega1 && listaActual[listaActual.Length - 1] != 0f) { listaActual[8]=(1f); }
                else
                {
                    if (listaActual[listaActual.Length - 1] <= tiempoEntrega2+ tiempoEntrega1 && listaActual[listaActual.Length - 1] != 0f) { listaActual[8] = (2f); }
                    else
                    {
                        if (listaActual[listaActual.Length - 1] <= tiempoEntrega3+ tiempoEntrega2 + tiempoEntrega1 && listaActual[listaActual.Length - 1] != 0f) { listaActual[8] = (3f); }
                        else { listaActual[8]=(0f); }
                    }
                }
                
                //calculamos la llegada del pedido
                    if (vanderaPedidoRealizado)
                    {
                        listaActual[9]=(listaAnterior[9]);
                    }
                    if (listaActual[6] == 1)
                    {
                        listaActual[9]=(listaActual[0] + listaActual[8]);
                        vanderaPedidoRealizado = true;
                    }
                    else
                    {
                        listaActual[9]=(0f);
                    }

                //calculamos KO
                if (listaActual[6] == 1)
                {
                    listaActual[10]=(costoPedido);
                }
                else {
                    listaActual[10]=(0f);
                }

                //calculamos KM
                listaActual[11]=(listaActual[5]*costoMantenimieto);

                //KS
                listaActual[12]=(StockOut);

                //agregamos costo total
                listaActual[13]=(listaActual[10] + listaActual[11] + listaActual[12]);

                //Agregamos costo acumulado
                if (listaActual[0] == 1)
                {
                    listaActual[14]=(listaActual[13]);
                }
                else {
                    listaActual[14]=(listaAnterior[14] + listaActual[13]);
                }

                //agregamos el costo promedio
                listaActual[15]=(listaActual[14] / listaActual[0]);

                listaAnterior = listaActual;
                if (i <= hasta && i >= desde || i == cantidadSemanas)
                {
                    for (int j = 0; j < listaActual.Length; j++) // Cambiado de i a j
                    {
                        matrizMostrar[i, j] = listaActual[j]; // Usando i para indexar la fila correcta
                    }
                }
                listaActual = new float[16];
            }
            frmTablaResultados tablaResultados = new frmTablaResultados(matrizMostrar);
            tablaResultados.ShowDialog();
            
        }
    }
}
