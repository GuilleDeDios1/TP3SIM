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
            this.mostrarMonteCarlo = new System.Windows.Forms.DataGridView();
            this.semana = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rndDemanda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.demanda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rndDañada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dañada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rndDemora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.demora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.llegadaPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ko = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costoAcumulado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costoPromedio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.mostrarMonteCarlo)).BeginInit();
            this.SuspendLayout();
            // 
            // mostrarMonteCarlo
            // 
            this.mostrarMonteCarlo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mostrarMonteCarlo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.semana,
            this.rndDemanda,
            this.demanda,
            this.rndDañada,
            this.dañada,
            this.stock,
            this.orden,
            this.rndDemora,
            this.demora,
            this.llegadaPedido,
            this.ko,
            this.KM,
            this.ks,
            this.costoTotal,
            this.costoAcumulado,
            this.costoPromedio});
            this.mostrarMonteCarlo.Location = new System.Drawing.Point(3, 3);
            this.mostrarMonteCarlo.Name = "mostrarMonteCarlo";
            this.mostrarMonteCarlo.RowTemplate.Height = 25;
            this.mostrarMonteCarlo.Size = new System.Drawing.Size(1645, 400);
            this.mostrarMonteCarlo.TabIndex = 0;
            // 
            // semana
            // 
            this.semana.HeaderText = "Semana";
            this.semana.Name = "semana";
            this.semana.ReadOnly = true;
            // 
            // rndDemanda
            // 
            this.rndDemanda.HeaderText = "RndDemanda";
            this.rndDemanda.Name = "rndDemanda";
            this.rndDemanda.ReadOnly = true;
            // 
            // demanda
            // 
            this.demanda.HeaderText = "Demanda";
            this.demanda.Name = "demanda";
            this.demanda.ReadOnly = true;
            // 
            // rndDañada
            // 
            this.rndDañada.HeaderText = "RndDañada";
            this.rndDañada.Name = "rndDañada";
            // 
            // dañada
            // 
            this.dañada.HeaderText = "Dañada";
            this.dañada.Name = "dañada";
            this.dañada.ReadOnly = true;
            // 
            // stock
            // 
            this.stock.HeaderText = "Stock";
            this.stock.Name = "stock";
            this.stock.ReadOnly = true;
            // 
            // orden
            // 
            this.orden.HeaderText = "Orden";
            this.orden.Name = "orden";
            this.orden.ReadOnly = true;
            // 
            // rndDemora
            // 
            this.rndDemora.HeaderText = "RndDemora";
            this.rndDemora.Name = "rndDemora";
            this.rndDemora.ReadOnly = true;
            // 
            // demora
            // 
            this.demora.HeaderText = "Demora";
            this.demora.Name = "demora";
            this.demora.ReadOnly = true;
            // 
            // llegadaPedido
            // 
            this.llegadaPedido.HeaderText = "LlegadaPedido";
            this.llegadaPedido.Name = "llegadaPedido";
            this.llegadaPedido.ReadOnly = true;
            // 
            // ko
            // 
            this.ko.HeaderText = "KO";
            this.ko.Name = "ko";
            this.ko.ReadOnly = true;
            // 
            // KM
            // 
            this.KM.HeaderText = "KM";
            this.KM.Name = "KM";
            this.KM.ReadOnly = true;
            // 
            // ks
            // 
            this.ks.HeaderText = "KS";
            this.ks.Name = "ks";
            this.ks.ReadOnly = true;
            // 
            // costoTotal
            // 
            this.costoTotal.HeaderText = "Costo Total";
            this.costoTotal.Name = "costoTotal";
            this.costoTotal.ReadOnly = true;
            // 
            // costoAcumulado
            // 
            this.costoAcumulado.HeaderText = "CostoAcumulado";
            this.costoAcumulado.Name = "costoAcumulado";
            this.costoAcumulado.ReadOnly = true;
            // 
            // costoPromedio
            // 
            this.costoPromedio.HeaderText = "CostoPromedio";
            this.costoPromedio.Name = "costoPromedio";
            this.costoPromedio.ReadOnly = true;
            // 
            // frmTablaResultados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1660, 416);
            this.Controls.Add(this.mostrarMonteCarlo);
            this.Name = "frmTablaResultados";
            this.Text = "frmTablaResultados";
            this.Load += new System.EventHandler(this.frmTablaResultados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mostrarMonteCarlo)).EndInit();
            this.ResumeLayout(false);

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