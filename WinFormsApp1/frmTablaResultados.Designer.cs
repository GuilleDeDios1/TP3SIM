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
            mostrarMonteCarlo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            mostrarMonteCarlo.BackgroundColor = Color.Gray;
            mostrarMonteCarlo.CausesValidation = false;
            mostrarMonteCarlo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            mostrarMonteCarlo.Columns.AddRange(new DataGridViewColumn[] { semana, rndDemanda, demanda, rndDañada, dañada, stock, orden, rndDemora, demora, llegadaPedido, ko, KM, ks, costoTotal, costoAcumulado, costoPromedio });
            mostrarMonteCarlo.Location = new Point(3, 3);
            mostrarMonteCarlo.Name = "mostrarMonteCarlo";
            mostrarMonteCarlo.ReadOnly = true;
            mostrarMonteCarlo.RowTemplate.Height = 25;
            mostrarMonteCarlo.Size = new Size(1645, 400);
            mostrarMonteCarlo.TabIndex = 0;
            mostrarMonteCarlo.CellContentClick += mostrarMonteCarlo_CellContentClick;
            // 
            // semana
            // 
            semana.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            semana.HeaderText = "Semana";
            semana.Name = "semana";
            semana.ReadOnly = true;
            semana.Resizable = DataGridViewTriState.False;
            semana.Width = 74;
            // 
            // rndDemanda
            // 
            rndDemanda.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            rndDemanda.HeaderText = "RndDemanda";
            rndDemanda.Name = "rndDemanda";
            rndDemanda.ReadOnly = true;
            rndDemanda.Resizable = DataGridViewTriState.False;
            rndDemanda.Width = 104;
            // 
            // demanda
            // 
            demanda.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            demanda.HeaderText = "Demanda";
            demanda.Name = "demanda";
            demanda.ReadOnly = true;
            demanda.Resizable = DataGridViewTriState.False;
            demanda.Width = 83;
            // 
            // rndDañada
            // 
            rndDañada.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            rndDañada.HeaderText = "RndDañada";
            rndDañada.Name = "rndDañada";
            rndDañada.ReadOnly = true;
            rndDañada.Resizable = DataGridViewTriState.False;
            rndDañada.Width = 93;
            // 
            // dañada
            // 
            dañada.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dañada.HeaderText = "Dañada";
            dañada.Name = "dañada";
            dañada.ReadOnly = true;
            dañada.Resizable = DataGridViewTriState.False;
            dañada.Width = 72;
            // 
            // stock
            // 
            stock.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            stock.HeaderText = "Stock";
            stock.Name = "stock";
            stock.ReadOnly = true;
            stock.Resizable = DataGridViewTriState.False;
            stock.Width = 61;
            // 
            // orden
            // 
            orden.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            orden.HeaderText = "Orden";
            orden.Name = "orden";
            orden.ReadOnly = true;
            orden.Resizable = DataGridViewTriState.False;
            orden.Width = 65;
            // 
            // rndDemora
            // 
            rndDemora.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            rndDemora.HeaderText = "RndDemora";
            rndDemora.Name = "rndDemora";
            rndDemora.ReadOnly = true;
            rndDemora.Resizable = DataGridViewTriState.False;
            rndDemora.Width = 95;
            // 
            // demora
            // 
            demora.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            demora.HeaderText = "Demora";
            demora.Name = "demora";
            demora.ReadOnly = true;
            demora.Resizable = DataGridViewTriState.False;
            demora.Width = 74;
            // 
            // llegadaPedido
            // 
            llegadaPedido.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            llegadaPedido.HeaderText = "LlegadaPedido";
            llegadaPedido.Name = "llegadaPedido";
            llegadaPedido.ReadOnly = true;
            llegadaPedido.Resizable = DataGridViewTriState.False;
            llegadaPedido.Width = 110;
            // 
            // ko
            // 
            ko.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            ko.HeaderText = "KO";
            ko.Name = "ko";
            ko.ReadOnly = true;
            ko.Resizable = DataGridViewTriState.False;
            ko.Width = 47;
            // 
            // KM
            // 
            KM.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            KM.HeaderText = "KM";
            KM.Name = "KM";
            KM.ReadOnly = true;
            KM.Resizable = DataGridViewTriState.False;
            KM.Width = 50;
            // 
            // ks
            // 
            ks.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            ks.HeaderText = "KS";
            ks.Name = "ks";
            ks.ReadOnly = true;
            ks.Resizable = DataGridViewTriState.False;
            ks.Width = 45;
            // 
            // costoTotal
            // 
            costoTotal.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            costoTotal.HeaderText = "Costo Total";
            costoTotal.Name = "costoTotal";
            costoTotal.ReadOnly = true;
            costoTotal.Width = 91;
            // 
            // costoAcumulado
            // 
            costoAcumulado.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            costoAcumulado.HeaderText = "CostoAcumulado";
            costoAcumulado.Name = "costoAcumulado";
            costoAcumulado.ReadOnly = true;
            costoAcumulado.Resizable = DataGridViewTriState.False;
            costoAcumulado.Width = 125;
            // 
            // costoPromedio
            // 
            costoPromedio.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            costoPromedio.HeaderText = "CostoPromedio";
            costoPromedio.Name = "costoPromedio";
            costoPromedio.ReadOnly = true;
            costoPromedio.Resizable = DataGridViewTriState.False;
            costoPromedio.Width = 115;
            // 
            // frmTablaResultados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1336, 416);
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