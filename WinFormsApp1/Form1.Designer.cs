namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            label16 = new Label();
            txtIntHasta = new TextBox();
            txtIntDesde = new TextBox();
            txtNroSimulaciones = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            txtDemd3 = new TextBox();
            label8 = new Label();
            label7 = new Label();
            txtDemd2 = new TextBox();
            txtDemd1 = new TextBox();
            txtDemd0 = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            groupBox3 = new GroupBox();
            label9 = new Label();
            label10 = new Label();
            txtTiempEntr3 = new TextBox();
            txtTiempEntr2 = new TextBox();
            txtTiempEntr1 = new TextBox();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            groupBox4 = new GroupBox();
            label11 = new Label();
            label15 = new Label();
            txtDanada1 = new TextBox();
            txtDanada0 = new TextBox();
            label17 = new Label();
            label18 = new Label();
            groupBox5 = new GroupBox();
            txtCostoSO = new TextBox();
            txtCostoPedi = new TextBox();
            txtCostoMant = new TextBox();
            label20 = new Label();
            label21 = new Label();
            label22 = new Label();
            groupBox6 = new GroupBox();
            txtStockInicial = new TextBox();
            txtPuntoRepo = new TextBox();
            txtTamPedi = new TextBox();
            label23 = new Label();
            label24 = new Label();
            label19 = new Label();
            btnGenerar = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label16);
            groupBox1.Controls.Add(txtIntHasta);
            groupBox1.Controls.Add(txtIntDesde);
            groupBox1.Controls.Add(txtNroSimulaciones);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(257, 129);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos De La Simulacion";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(180, 75);
            label16.Name = "label16";
            label16.Size = new Size(12, 15);
            label16.TabIndex = 5;
            label16.Text = "/";
            // 
            // txtIntHasta
            // 
            txtIntHasta.Location = new Point(194, 72);
            txtIntHasta.Name = "txtIntHasta";
            txtIntHasta.Size = new Size(40, 23);
            txtIntHasta.TabIndex = 4;
            txtIntHasta.KeyPress += txtIntHasta_KeyPress;
            // 
            // txtIntDesde
            // 
            txtIntDesde.Location = new Point(134, 72);
            txtIntDesde.Name = "txtIntDesde";
            txtIntDesde.Size = new Size(40, 23);
            txtIntDesde.TabIndex = 3;
            txtIntDesde.KeyPress += txtIntDesde_KeyPress;
            // 
            // txtNroSimulaciones
            // 
            txtNroSimulaciones.Location = new Point(134, 33);
            txtNroSimulaciones.Name = "txtNroSimulaciones";
            txtNroSimulaciones.Size = new Size(100, 23);
            txtNroSimulaciones.TabIndex = 2;
            txtNroSimulaciones.KeyPress += txtNroSimulaciones_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 75);
            label2.Name = "label2";
            label2.Size = new Size(109, 15);
            label2.TabIndex = 1;
            label2.Text = "Intervalo a mostrar:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 36);
            label1.Name = "label1";
            label1.Size = new Size(123, 15);
            label1.TabIndex = 0;
            label1.Text = "Cantidad de semanas:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtDemd3);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(txtDemd2);
            groupBox2.Controls.Add(txtDemd1);
            groupBox2.Controls.Add(txtDemd0);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(12, 163);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(195, 165);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Demanda Por Semana";
            // 
            // txtDemd3
            // 
            txtDemd3.Location = new Point(125, 125);
            txtDemd3.Name = "txtDemd3";
            txtDemd3.Size = new Size(33, 23);
            txtDemd3.TabIndex = 9;
            txtDemd3.Text = "0,1";
            txtDemd3.KeyPress += txtDemd3_KeyPress;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(100, 19);
            label8.Name = "label8";
            label8.Size = new Size(74, 15);
            label8.TabIndex = 8;
            label8.Text = "Probabildiad";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(22, 19);
            label7.Name = "label7";
            label7.Size = new Size(55, 15);
            label7.TabIndex = 7;
            label7.Text = "Cantidad";
            // 
            // txtDemd2
            // 
            txtDemd2.Location = new Point(125, 94);
            txtDemd2.Name = "txtDemd2";
            txtDemd2.Size = new Size(33, 23);
            txtDemd2.TabIndex = 6;
            txtDemd2.Text = "0,25";
            txtDemd2.KeyPress += txtDemd2_KeyPress;
            // 
            // txtDemd1
            // 
            txtDemd1.Location = new Point(125, 65);
            txtDemd1.Name = "txtDemd1";
            txtDemd1.Size = new Size(33, 23);
            txtDemd1.TabIndex = 5;
            txtDemd1.Text = "0,15";
            txtDemd1.KeyPress += txtDemd1_KeyPress;
            // 
            // txtDemd0
            // 
            txtDemd0.Location = new Point(125, 37);
            txtDemd0.Name = "txtDemd0";
            txtDemd0.Size = new Size(33, 23);
            txtDemd0.TabIndex = 4;
            txtDemd0.Text = "0,50";
            txtDemd0.KeyPress += txtDemd0_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(40, 128);
            label6.Name = "label6";
            label6.Size = new Size(13, 15);
            label6.TabIndex = 3;
            label6.Text = "3";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(40, 97);
            label5.Name = "label5";
            label5.Size = new Size(13, 15);
            label5.TabIndex = 2;
            label5.Text = "2";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 68);
            label4.Name = "label4";
            label4.Size = new Size(13, 15);
            label4.TabIndex = 1;
            label4.Text = "1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 40);
            label3.Name = "label3";
            label3.Size = new Size(13, 15);
            label3.TabIndex = 0;
            label3.Text = "0";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(txtTiempEntr3);
            groupBox3.Controls.Add(txtTiempEntr2);
            groupBox3.Controls.Add(txtTiempEntr1);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(label13);
            groupBox3.Controls.Add(label14);
            groupBox3.Location = new Point(318, 181);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(195, 125);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Tiempo De Entrega";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(100, 19);
            label9.Name = "label9";
            label9.Size = new Size(74, 15);
            label9.TabIndex = 8;
            label9.Text = "Probabildiad";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(22, 19);
            label10.Name = "label10";
            label10.Size = new Size(55, 15);
            label10.TabIndex = 7;
            label10.Text = "Cantidad";
            // 
            // txtTiempEntr3
            // 
            txtTiempEntr3.Location = new Point(125, 94);
            txtTiempEntr3.Name = "txtTiempEntr3";
            txtTiempEntr3.Size = new Size(30, 23);
            txtTiempEntr3.TabIndex = 6;
            txtTiempEntr3.Text = "0,3";
            txtTiempEntr3.KeyPress += txtTiempEntr3_KeyPress;
            // 
            // txtTiempEntr2
            // 
            txtTiempEntr2.Location = new Point(125, 65);
            txtTiempEntr2.Name = "txtTiempEntr2";
            txtTiempEntr2.Size = new Size(30, 23);
            txtTiempEntr2.TabIndex = 5;
            txtTiempEntr2.Text = "0,4";
            txtTiempEntr2.KeyPress += txtTiempEntr2_KeyPress;
            // 
            // txtTiempEntr1
            // 
            txtTiempEntr1.Location = new Point(125, 37);
            txtTiempEntr1.Name = "txtTiempEntr1";
            txtTiempEntr1.Size = new Size(30, 23);
            txtTiempEntr1.TabIndex = 4;
            txtTiempEntr1.Text = "0,3";
            txtTiempEntr1.KeyPress += txtTiempEntr1_KeyPress;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(40, 97);
            label12.Name = "label12";
            label12.Size = new Size(13, 15);
            label12.TabIndex = 2;
            label12.Text = "3";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(40, 68);
            label13.Name = "label13";
            label13.Size = new Size(13, 15);
            label13.TabIndex = 1;
            label13.Text = "2";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(40, 40);
            label14.Name = "label14";
            label14.Size = new Size(13, 15);
            label14.TabIndex = 0;
            label14.Text = "1";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label11);
            groupBox4.Controls.Add(label15);
            groupBox4.Controls.Add(txtDanada1);
            groupBox4.Controls.Add(txtDanada0);
            groupBox4.Controls.Add(label17);
            groupBox4.Controls.Add(label18);
            groupBox4.Location = new Point(539, 22);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(195, 101);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Bicicleta Dañada";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(100, 19);
            label11.Name = "label11";
            label11.Size = new Size(74, 15);
            label11.TabIndex = 8;
            label11.Text = "Probabildiad";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(22, 19);
            label15.Name = "label15";
            label15.Size = new Size(55, 15);
            label15.TabIndex = 7;
            label15.Text = "Cantidad";
            // 
            // txtDanada1
            // 
            txtDanada1.Location = new Point(125, 65);
            txtDanada1.Name = "txtDanada1";
            txtDanada1.Size = new Size(33, 23);
            txtDanada1.TabIndex = 5;
            txtDanada1.Text = "0,30";
            txtDanada1.KeyPress += txtDanada1_KeyPress;
            // 
            // txtDanada0
            // 
            txtDanada0.Location = new Point(125, 36);
            txtDanada0.Name = "txtDanada0";
            txtDanada0.Size = new Size(33, 23);
            txtDanada0.TabIndex = 4;
            txtDanada0.Text = "0,70";
            txtDanada0.KeyPress += txtDanada0_KeyPress;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(40, 68);
            label17.Name = "label17";
            label17.Size = new Size(13, 15);
            label17.TabIndex = 1;
            label17.Text = "1";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(40, 40);
            label18.Name = "label18";
            label18.Size = new Size(13, 15);
            label18.TabIndex = 0;
            label18.Text = "0";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(txtCostoSO);
            groupBox5.Controls.Add(txtCostoPedi);
            groupBox5.Controls.Add(txtCostoMant);
            groupBox5.Controls.Add(label20);
            groupBox5.Controls.Add(label21);
            groupBox5.Controls.Add(label22);
            groupBox5.Location = new Point(318, 12);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(195, 129);
            groupBox5.TabIndex = 4;
            groupBox5.TabStop = false;
            groupBox5.Text = "Costos";
            // 
            // txtCostoSO
            // 
            txtCostoSO.Location = new Point(125, 88);
            txtCostoSO.Name = "txtCostoSO";
            txtCostoSO.Size = new Size(43, 23);
            txtCostoSO.TabIndex = 6;
            txtCostoSO.Text = "50";
            txtCostoSO.KeyPress += txtCostoSO_KeyPress;
            // 
            // txtCostoPedi
            // 
            txtCostoPedi.Location = new Point(125, 59);
            txtCostoPedi.Name = "txtCostoPedi";
            txtCostoPedi.Size = new Size(43, 23);
            txtCostoPedi.TabIndex = 5;
            txtCostoPedi.Text = "200";
            txtCostoPedi.KeyPress += txtCostoPedi_KeyPress;
            // 
            // txtCostoMant
            // 
            txtCostoMant.Location = new Point(125, 30);
            txtCostoMant.Name = "txtCostoMant";
            txtCostoMant.Size = new Size(43, 23);
            txtCostoMant.TabIndex = 4;
            txtCostoMant.Text = "30";
            txtCostoMant.KeyPress += txtCostoMant_KeyPress;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(17, 62);
            label20.Name = "label20";
            label20.Size = new Size(81, 15);
            label20.TabIndex = 2;
            label20.Text = "Costo Pedido:";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(17, 91);
            label21.Name = "label21";
            label21.Size = new Size(90, 15);
            label21.TabIndex = 1;
            label21.Text = "CostoStockOut:";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(17, 33);
            label22.Name = "label22";
            label22.Size = new Size(69, 15);
            label22.TabIndex = 0;
            label22.Text = "CostoMant:";
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(txtStockInicial);
            groupBox6.Controls.Add(txtPuntoRepo);
            groupBox6.Controls.Add(txtTamPedi);
            groupBox6.Controls.Add(label23);
            groupBox6.Controls.Add(label24);
            groupBox6.Controls.Add(label19);
            groupBox6.Location = new Point(561, 185);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(201, 113);
            groupBox6.TabIndex = 5;
            groupBox6.TabStop = false;
            groupBox6.Text = "Inventario";
            // 
            // txtStockInicial
            // 
            txtStockInicial.Location = new Point(140, 80);
            txtStockInicial.Name = "txtStockInicial";
            txtStockInicial.Size = new Size(33, 23);
            txtStockInicial.TabIndex = 8;
            txtStockInicial.Text = "7";
            txtStockInicial.KeyPress += txtStockInicial_KeyPress;
            // 
            // txtPuntoRepo
            // 
            txtPuntoRepo.Location = new Point(140, 51);
            txtPuntoRepo.Name = "txtPuntoRepo";
            txtPuntoRepo.Size = new Size(33, 23);
            txtPuntoRepo.TabIndex = 7;
            txtPuntoRepo.Text = "2";
            txtPuntoRepo.KeyPress += txtPuntoRepo_KeyPress;
            // 
            // txtTamPedi
            // 
            txtTamPedi.Location = new Point(140, 22);
            txtTamPedi.Name = "txtTamPedi";
            txtTamPedi.Size = new Size(33, 23);
            txtTamPedi.TabIndex = 6;
            txtTamPedi.Text = "6";
            txtTamPedi.KeyPress += txtTamPedi_KeyPress;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(18, 82);
            label23.Name = "label23";
            label23.Size = new Size(70, 15);
            label23.TabIndex = 3;
            label23.Text = "Stock inicial";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(18, 53);
            label24.Name = "label24";
            label24.Size = new Size(113, 15);
            label24.TabIndex = 2;
            label24.Text = "Punto de reposicion";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(18, 25);
            label19.Name = "label19";
            label19.Size = new Size(89, 15);
            label19.TabIndex = 0;
            label19.Text = "Tamaño pedido";
            // 
            // btnGenerar
            // 
            btnGenerar.Location = new Point(676, 332);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(86, 23);
            btnGenerar.TabIndex = 6;
            btnGenerar.Text = "Generar";
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 367);
            Controls.Add(btnGenerar);
            Controls.Add(groupBox6);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Datos De Simulacion";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtIntHasta;
        private TextBox txtIntDesde;
        private TextBox txtNroSimulaciones;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private TextBox txtDemd3;
        private Label label8;
        private Label label7;
        private TextBox txtDemd2;
        private TextBox txtDemd1;
        private TextBox txtDemd0;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private GroupBox groupBox3;
        private Label label9;
        private Label label10;
        private TextBox txtTiempEntr3;
        private TextBox txtTiempEntr2;
        private TextBox txtTiempEntr1;
        private Label label12;
        private Label label13;
        private Label label14;
        private GroupBox groupBox4;
        private Label label11;
        private Label label15;
        private TextBox txtDanada1;
        private TextBox txtDanada0;
        private Label label17;
        private Label label18;
        private GroupBox groupBox5;
        private TextBox txtCostoSO;
        private TextBox txtCostoPedi;
        private TextBox txtCostoMant;
        private Label label20;
        private Label label21;
        private Label label22;
        private Label label16;
        private GroupBox groupBox6;
        private Label label19;
        private TextBox txtStockInicial;
        private TextBox txtPuntoRepo;
        private TextBox txtTamPedi;
        private Label label23;
        private Label label24;
        private Button btnGenerar;
    }
}