namespace CircodeApp3
{
    partial class FrmCarro
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
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblAlcool = new System.Windows.Forms.Label();
            this.txtAlcool = new System.Windows.Forms.TextBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.txtGasolina = new System.Windows.Forms.TextBox();
            this.lblGasolina = new System.Windows.Forms.Label();
            this.txtConsumo = new System.Windows.Forms.TextBox();
            this.lblConsumo = new System.Windows.Forms.Label();
            this.txtTrecho = new System.Windows.Forms.TextBox();
            this.lblTrecho = new System.Windows.Forms.Label();
            this.lblCombustivel = new System.Windows.Forms.Label();
            this.lblGasbest = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblGasto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(12, 258);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            // 
            // lblAlcool
            // 
            this.lblAlcool.AutoSize = true;
            this.lblAlcool.Location = new System.Drawing.Point(12, 18);
            this.lblAlcool.Name = "lblAlcool";
            this.lblAlcool.Size = new System.Drawing.Size(82, 13);
            this.lblAlcool.TabIndex = 1;
            this.lblAlcool.Text = "Preço do Alcool";
            // 
            // txtAlcool
            // 
            this.txtAlcool.Location = new System.Drawing.Point(12, 34);
            this.txtAlcool.Name = "txtAlcool";
            this.txtAlcool.Size = new System.Drawing.Size(156, 20);
            this.txtAlcool.TabIndex = 2;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(93, 258);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // txtGasolina
            // 
            this.txtGasolina.Location = new System.Drawing.Point(12, 93);
            this.txtGasolina.Name = "txtGasolina";
            this.txtGasolina.Size = new System.Drawing.Size(156, 20);
            this.txtGasolina.TabIndex = 5;
            // 
            // lblGasolina
            // 
            this.lblGasolina.AutoSize = true;
            this.lblGasolina.Location = new System.Drawing.Point(12, 77);
            this.lblGasolina.Name = "lblGasolina";
            this.lblGasolina.Size = new System.Drawing.Size(94, 13);
            this.lblGasolina.TabIndex = 4;
            this.lblGasolina.Text = "Preço da Gasolina";
            // 
            // txtConsumo
            // 
            this.txtConsumo.Location = new System.Drawing.Point(12, 215);
            this.txtConsumo.Name = "txtConsumo";
            this.txtConsumo.Size = new System.Drawing.Size(156, 20);
            this.txtConsumo.TabIndex = 9;
            // 
            // lblConsumo
            // 
            this.lblConsumo.AutoSize = true;
            this.lblConsumo.Location = new System.Drawing.Point(12, 199);
            this.lblConsumo.Name = "lblConsumo";
            this.lblConsumo.Size = new System.Drawing.Size(154, 13);
            this.lblConsumo.TabIndex = 8;
            this.lblConsumo.Text = "Consumo médio por litro (Km/L)";
            // 
            // txtTrecho
            // 
            this.txtTrecho.Location = new System.Drawing.Point(12, 156);
            this.txtTrecho.Name = "txtTrecho";
            this.txtTrecho.Size = new System.Drawing.Size(156, 20);
            this.txtTrecho.TabIndex = 7;
            // 
            // lblTrecho
            // 
            this.lblTrecho.AutoSize = true;
            this.lblTrecho.Location = new System.Drawing.Point(12, 140);
            this.lblTrecho.Name = "lblTrecho";
            this.lblTrecho.Size = new System.Drawing.Size(129, 13);
            this.lblTrecho.TabIndex = 6;
            this.lblTrecho.Text = "Distância a percorrer (Km)";
            // 
            // lblCombustivel
            // 
            this.lblCombustivel.AutoSize = true;
            this.lblCombustivel.Location = new System.Drawing.Point(222, 37);
            this.lblCombustivel.Name = "lblCombustivel";
            this.lblCombustivel.Size = new System.Drawing.Size(64, 13);
            this.lblCombustivel.TabIndex = 10;
            this.lblCombustivel.Text = "Combustivel";
            // 
            // lblGasbest
            // 
            this.lblGasbest.AutoSize = true;
            this.lblGasbest.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGasbest.Location = new System.Drawing.Point(222, 63);
            this.lblGasbest.Name = "lblGasbest";
            this.lblGasbest.Size = new System.Drawing.Size(70, 25);
            this.lblGasbest.TabIndex = 11;
            this.lblGasbest.Text = "label6";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(222, 163);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(70, 25);
            this.lblPrice.TabIndex = 13;
            this.lblPrice.Text = "label7";
            // 
            // lblGasto
            // 
            this.lblGasto.AutoSize = true;
            this.lblGasto.Location = new System.Drawing.Point(222, 137);
            this.lblGasto.Name = "lblGasto";
            this.lblGasto.Size = new System.Drawing.Size(80, 13);
            this.lblGasto.TabIndex = 12;
            this.lblGasto.Text = "Gasto a realizar";
            // 
            // FrmCarro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(381, 297);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblGasto);
            this.Controls.Add(this.lblGasbest);
            this.Controls.Add(this.lblCombustivel);
            this.Controls.Add(this.txtConsumo);
            this.Controls.Add(this.lblConsumo);
            this.Controls.Add(this.txtTrecho);
            this.Controls.Add(this.lblTrecho);
            this.Controls.Add(this.txtGasolina);
            this.Controls.Add(this.lblGasolina);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.txtAlcool);
            this.Controls.Add(this.lblAlcool);
            this.Controls.Add(this.btnCalcular);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCarro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculo de Combustível";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblAlcool;
        private System.Windows.Forms.TextBox txtAlcool;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.TextBox txtGasolina;
        private System.Windows.Forms.Label lblGasolina;
        private System.Windows.Forms.TextBox txtConsumo;
        private System.Windows.Forms.Label lblConsumo;
        private System.Windows.Forms.TextBox txtTrecho;
        private System.Windows.Forms.Label lblTrecho;
        private System.Windows.Forms.Label lblCombustivel;
        private System.Windows.Forms.Label lblGasbest;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblGasto;
    }
}