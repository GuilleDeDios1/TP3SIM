namespace WinFormsApp1
{
    partial class frmTablaResultados
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            mostrarMonteCarlo = new DataGridView();
            semana = new DataGridViewTextBoxColumn();
            rndDemanda = new DataGridViewTextBoxColumn();
            demanda = new DataGridViewTextBoxColumn();
            rndDañada = new DataGridViewTextBoxColumn();
            dañada = new DataGridViewTextBoxColumn();
            stock = new DataGridViewTextBoxColumn();
            orden = new DataGridViewTextBoxColumn();
            rndDemora = new DataGridViewTextBoxColumn();
            demora = new DataGridViewTextBoxColumn();
            llegadaPedido = new DataGridViewTextBoxColumn();
            ko = new DataGridViewTextBoxColumn();
            KM = new DataGridViewTextBoxColumn();
            ks = new DataGridViewTextBoxColumn();
            costoTotal = new DataGridViewTextBoxColumn();
            costoAcumulado = new DataGridViewTextBoxColumn();
            costoPromedio = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)mostrarMonteCarlo).BeginInit();
            SuspendLayout();
            // 
            // mostrarMonteCarlo
            // 
            mostrarMonteCarlo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            mostrarMonteCarlo.Columns.AddRange(new DataGridViewColumn[] { semana, rndDemanda, demanda, rndDañada, dañada, stock, orden, rndDemora, demora, llegadaPedido, ko, KM, ks, costoTotal, costoAcumulado, costoPromedio });
            mostrarMonteCarlo.Location = new Point(3, 3);
            mostrarMonteCarlo.Name = "mostrarMonteCarlo";
            mostrarMonteCarlo.RowTemplate.Height = 25;
            mostrarMonteCarlo.Size = new Size(1645, 400);
            mostrarMonteCarlo.TabIndex = 0;
            // 
            // semana
            // 
            semana.HeaderText = "Semana";
            semana.Name = "semana";
            semana.ReadOnly = true;
            // 
            // rndDemanda
            // 
            rndDemanda.HeaderText = "RndDemanda";
            rndDemanda.Name = "rndDemanda";
            rndDemanda.ReadOnly = true;
            // 
            // demanda
            // 
            demanda.HeaderText = "Demanda";
            demanda.Name = "demanda";
            demanda.ReadOnly = true;
            // 
            // rndDañada
            // 
            rndDañada.HeaderText = "RndDañada";
            rndDañada.Name = "rndDañada";
            // 
            // dañada
            // 
            dañada.HeaderText = "Dañada";
            dañada.Name = "dañada";
            dañada.ReadOnly = true;
            // 
            // stock
            // 
            stock.HeaderText = "Stock";
            stock.Name = "stock";
            stock.ReadOnly = true;
            // 
            // orden
            // 
            orden.HeaderText = "Orden";
            orden.Name = "orden";
            orden.ReadOnly = true;
            // 
            // rndDemora
            // 
            rndDemora.HeaderText = "RndDemora";
            rndDemora.Name = "rndDemora";
            rndDemora.ReadOnly = true;
            // 
            // demora
            // 
            demora.HeaderText = "Demora";
            demora.Name = "demora";
            demora.ReadOnly = true;
            // 
            // llegadaPedido
            // 
            llegadaPedido.HeaderText = "LlegadaPedido";
            llegadaPedido.Name = "llegadaPedido";
            llegadaPedido.ReadOnly = true;
            // 
            // ko
            // 
            ko.HeaderText = "KO";
            ko.Name = "ko";
            ko.ReadOnly = true;
            // 
            // KM
            // 
            KM.HeaderText = "KM";
            KM.Name = "KM";
            KM.ReadOnly = true;
            // 
            // ks
            // 
            ks.HeaderText = "KS";
            ks.Name = "ks";
            ks.ReadOnly = true;
            // 
            // costoTotal
            // 
            costoTotal.HeaderText = "Costo Total";
            costoTotal.Name = "costoTotal";
            costoTotal.ReadOnly = true;
            // 
            // costoAcumulado
            // 
            costoAcumulado.HeaderText = "CostoAcumulado";
            costoAcumulado.Name = "costoAcumulado";
            costoAcumulado.ReadOnly = true;
            // 
            // costoPromedio
            // 
            costoPromedio.HeaderText = "CostoPromedio";
            costoPromedio.Name = "costoPromedio";
            costoPromedio.ReadOnly = true;
            // 
            // frmTablaResultados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 416);
            Controls.Add(mostrarMonteCarlo);
            Name = "frmTablaResultados";
            Text = "frmTablaResultados";
            Load += frmTablaResultados_Load;
            ((System.ComponentModel.ISupportInitialize)mostrarMonteCarlo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView mostrarMonteCarlo;
        private DataGridViewTextBoxColumn semana;
        private DataGridViewTextBoxColumn rndDemanda;
        private DataGridViewTextBoxColumn demanda;
        private DataGridViewTextBoxColumn rndDañada;
        private DataGridViewTextBoxColumn dañada;
        private DataGridViewTextBoxColumn stock;
        private DataGridViewTextBoxColumn orden;
        private DataGridViewTextBoxColumn rndDemora;
        private DataGridViewTextBoxColumn demora;
        private DataGridViewTextBoxColumn llegadaPedido;
        private DataGridViewTextBoxColumn ko;
        private DataGridViewTextBoxColumn KM;
        private DataGridViewTextBoxColumn ks;
        private DataGridViewTextBoxColumn costoTotal;
        private DataGridViewTextBoxColumn costoAcumulado;
        private DataGridViewTextBoxColumn costoPromedio;
    }
}