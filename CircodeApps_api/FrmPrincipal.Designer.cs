
namespace CircodeApp33
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblBuscaCEP = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblPedraPapelTesoura = new System.Windows.Forms.Label();
            this.pbxPedraPapelTesoura = new System.Windows.Forms.PictureBox();
            this.pbxCEP = new System.Windows.Forms.PictureBox();
            this.lblIMC = new System.Windows.Forms.Label();
            this.pbxIMC = new System.Windows.Forms.PictureBox();
            this.lblConsumo = new System.Windows.Forms.Label();
            this.pbxGasolina = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPedraPapelTesoura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCEP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIMC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxGasolina)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBuscaCEP
            // 
            this.lblBuscaCEP.AutoSize = true;
            this.lblBuscaCEP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscaCEP.Location = new System.Drawing.Point(49, 146);
            this.lblBuscaCEP.Name = "lblBuscaCEP";
            this.lblBuscaCEP.Size = new System.Drawing.Size(76, 16);
            this.lblBuscaCEP.TabIndex = 0;
            this.lblBuscaCEP.Text = "Busca CEP";
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(431, 327);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(74, 26);
            this.btnSair.TabIndex = 2;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblPedraPapelTesoura
            // 
            this.lblPedraPapelTesoura.AutoSize = true;
            this.lblPedraPapelTesoura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPedraPapelTesoura.Location = new System.Drawing.Point(195, 146);
            this.lblPedraPapelTesoura.Name = "lblPedraPapelTesoura";
            this.lblPedraPapelTesoura.Size = new System.Drawing.Size(138, 16);
            this.lblPedraPapelTesoura.TabIndex = 4;
            this.lblPedraPapelTesoura.Text = "Pedra Papel Tesoura";
            this.lblPedraPapelTesoura.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbxPedraPapelTesoura
            // 
            this.pbxPedraPapelTesoura.Image = global::CircodeApp3.Properties.Resources.pedrapapeltesoura;
            this.pbxPedraPapelTesoura.Location = new System.Drawing.Point(198, 12);
            this.pbxPedraPapelTesoura.Name = "pbxPedraPapelTesoura";
            this.pbxPedraPapelTesoura.Size = new System.Drawing.Size(128, 131);
            this.pbxPedraPapelTesoura.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxPedraPapelTesoura.TabIndex = 3;
            this.pbxPedraPapelTesoura.TabStop = false;
            this.pbxPedraPapelTesoura.Click += new System.EventHandler(this.pbxPedraPapelTesoura_Click);
            // 
            // pbxCEP
            // 
            this.pbxCEP.Image = global::CircodeApp3.Properties.Resources.cep;
            this.pbxCEP.Location = new System.Drawing.Point(24, 12);
            this.pbxCEP.Name = "pbxCEP";
            this.pbxCEP.Size = new System.Drawing.Size(128, 131);
            this.pbxCEP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxCEP.TabIndex = 1;
            this.pbxCEP.TabStop = false;
            this.pbxCEP.Click += new System.EventHandler(this.pbxCEP_Click);
            // 
            // lblIMC
            // 
            this.lblIMC.AutoSize = true;
            this.lblIMC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIMC.Location = new System.Drawing.Point(379, 146);
            this.lblIMC.Name = "lblIMC";
            this.lblIMC.Size = new System.Drawing.Size(126, 16);
            this.lblIMC.TabIndex = 6;
            this.lblIMC.Text = "Calculadora de IMC";
            this.lblIMC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbxIMC
            // 
            this.pbxIMC.Image = global::CircodeApp3.Properties.Resources.imc;
            this.pbxIMC.Location = new System.Drawing.Point(377, 12);
            this.pbxIMC.Name = "pbxIMC";
            this.pbxIMC.Size = new System.Drawing.Size(128, 131);
            this.pbxIMC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxIMC.TabIndex = 5;
            this.pbxIMC.TabStop = false;
            this.pbxIMC.Click += new System.EventHandler(this.pbxIMC_Click);
            // 
            // lblConsumo
            // 
            this.lblConsumo.AutoSize = true;
            this.lblConsumo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsumo.Location = new System.Drawing.Point(14, 314);
            this.lblConsumo.Name = "lblConsumo";
            this.lblConsumo.Size = new System.Drawing.Size(160, 16);
            this.lblConsumo.TabIndex = 8;
            this.lblConsumo.Text = "Calculadora de Consumo";
            this.lblConsumo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbxGasolina
            // 
            this.pbxGasolina.Image = global::CircodeApp3.Properties.Resources.gas;
            this.pbxGasolina.Location = new System.Drawing.Point(24, 180);
            this.pbxGasolina.Name = "pbxGasolina";
            this.pbxGasolina.Size = new System.Drawing.Size(128, 131);
            this.pbxGasolina.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxGasolina.TabIndex = 7;
            this.pbxGasolina.TabStop = false;
            this.pbxGasolina.Click += new System.EventHandler(this.pbxGasolina_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(517, 365);
            this.Controls.Add(this.lblConsumo);
            this.Controls.Add(this.pbxGasolina);
            this.Controls.Add(this.lblIMC);
            this.Controls.Add(this.pbxIMC);
            this.Controls.Add(this.lblPedraPapelTesoura);
            this.Controls.Add(this.pbxPedraPapelTesoura);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.pbxCEP);
            this.Controls.Add(this.lblBuscaCEP);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Circo de Apps TDS06";
            ((System.ComponentModel.ISupportInitialize)(this.pbxPedraPapelTesoura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCEP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIMC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxGasolina)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBuscaCEP;
        private System.Windows.Forms.PictureBox pbxCEP;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.PictureBox pbxPedraPapelTesoura;
        private System.Windows.Forms.Label lblPedraPapelTesoura;
        private System.Windows.Forms.Label lblIMC;
        private System.Windows.Forms.PictureBox pbxIMC;
        private System.Windows.Forms.Label lblConsumo;
        private System.Windows.Forms.PictureBox pbxGasolina;
    }
}

