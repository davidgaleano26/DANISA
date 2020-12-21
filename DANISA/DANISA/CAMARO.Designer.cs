namespace DANISA
{
    partial class CAMARO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CAMARO));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboPintura = new System.Windows.Forms.ComboBox();
            this.cboLuces = new System.Windows.Forms.ComboBox();
            this.cboPolarizado = new System.Windows.Forms.ComboBox();
            this.cboExploradoras = new System.Windows.Forms.ComboBox();
            this.btnPintura = new System.Windows.Forms.Button();
            this.btnLuces = new System.Windows.Forms.Button();
            this.btnPolarizado = new System.Windows.Forms.Button();
            this.btnExploradoras = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Aqua;
            this.label1.Location = new System.Drawing.Point(12, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "PINTURA:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Aqua;
            this.label2.Location = new System.Drawing.Point(12, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "LUCES:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Aqua;
            this.label3.Location = new System.Drawing.Point(12, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "POLARIZADO:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Aqua;
            this.label4.Location = new System.Drawing.Point(12, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "EXPLORADORAS:";
            // 
            // cboPintura
            // 
            this.cboPintura.FormattingEnabled = true;
            this.cboPintura.Items.AddRange(new object[] {
            "Amarillo",
            "Azul",
            "Blanco",
            "Rojo"});
            this.cboPintura.Location = new System.Drawing.Point(170, 84);
            this.cboPintura.Name = "cboPintura";
            this.cboPintura.Size = new System.Drawing.Size(172, 21);
            this.cboPintura.TabIndex = 7;
            // 
            // cboLuces
            // 
            this.cboLuces.FormattingEnabled = true;
            this.cboLuces.Items.AddRange(new object[] {
            "Amarillo+Luces",
            "Azul+Luces",
            "Blanco+Luces",
            "Rojo+Luces"});
            this.cboLuces.Location = new System.Drawing.Point(170, 141);
            this.cboLuces.Name = "cboLuces";
            this.cboLuces.Size = new System.Drawing.Size(172, 21);
            this.cboLuces.TabIndex = 8;
            // 
            // cboPolarizado
            // 
            this.cboPolarizado.FormattingEnabled = true;
            this.cboPolarizado.Items.AddRange(new object[] {
            "Amarillo+Polarizado",
            "Azul+Polarizado",
            "Blanco+Polarizado",
            "Rojo+Polarizado"});
            this.cboPolarizado.Location = new System.Drawing.Point(170, 195);
            this.cboPolarizado.Name = "cboPolarizado";
            this.cboPolarizado.Size = new System.Drawing.Size(172, 21);
            this.cboPolarizado.TabIndex = 9;
            // 
            // cboExploradoras
            // 
            this.cboExploradoras.FormattingEnabled = true;
            this.cboExploradoras.Items.AddRange(new object[] {
            "Amarillo+Exploradoras",
            "Amarillo+Luces+exp",
            "Azul+Exploradoras",
            "Azul+Luces+exp",
            "Blanco+Exploradoras",
            "Blanco+Luces+exp",
            "Rojo+Exploradoras",
            "Rojo+Luces+exp"});
            this.cboExploradoras.Location = new System.Drawing.Point(170, 257);
            this.cboExploradoras.Name = "cboExploradoras";
            this.cboExploradoras.Size = new System.Drawing.Size(172, 21);
            this.cboExploradoras.TabIndex = 10;
            // 
            // btnPintura
            // 
            this.btnPintura.BackColor = System.Drawing.Color.Aqua;
            this.btnPintura.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPintura.Location = new System.Drawing.Point(364, 81);
            this.btnPintura.Name = "btnPintura";
            this.btnPintura.Size = new System.Drawing.Size(36, 30);
            this.btnPintura.TabIndex = 15;
            this.btnPintura.Text = "✔";
            this.btnPintura.UseVisualStyleBackColor = false;
            this.btnPintura.Click += new System.EventHandler(this.BtnPintura_Click);
            // 
            // btnLuces
            // 
            this.btnLuces.BackColor = System.Drawing.Color.Aqua;
            this.btnLuces.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuces.Location = new System.Drawing.Point(364, 135);
            this.btnLuces.Name = "btnLuces";
            this.btnLuces.Size = new System.Drawing.Size(36, 30);
            this.btnLuces.TabIndex = 16;
            this.btnLuces.Text = "✔";
            this.btnLuces.UseVisualStyleBackColor = false;
            this.btnLuces.Click += new System.EventHandler(this.BtnLuces_Click);
            // 
            // btnPolarizado
            // 
            this.btnPolarizado.BackColor = System.Drawing.Color.Aqua;
            this.btnPolarizado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPolarizado.Location = new System.Drawing.Point(364, 189);
            this.btnPolarizado.Name = "btnPolarizado";
            this.btnPolarizado.Size = new System.Drawing.Size(36, 30);
            this.btnPolarizado.TabIndex = 17;
            this.btnPolarizado.Text = "✔";
            this.btnPolarizado.UseVisualStyleBackColor = false;
            this.btnPolarizado.Click += new System.EventHandler(this.BtnPolarizado_Click);
            // 
            // btnExploradoras
            // 
            this.btnExploradoras.BackColor = System.Drawing.Color.Aqua;
            this.btnExploradoras.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExploradoras.Location = new System.Drawing.Point(364, 254);
            this.btnExploradoras.Name = "btnExploradoras";
            this.btnExploradoras.Size = new System.Drawing.Size(36, 30);
            this.btnExploradoras.TabIndex = 18;
            this.btnExploradoras.Text = "✔";
            this.btnExploradoras.UseVisualStyleBackColor = false;
            this.btnExploradoras.Click += new System.EventHandler(this.BtnExploradoras_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(431, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(440, 229);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Aqua;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(576, 383);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 34);
            this.button1.TabIndex = 20;
            this.button1.Text = "CONTINUAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Aqua;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(15, 383);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(196, 34);
            this.button2.TabIndex = 21;
            this.button2.Text = "ATRÁS";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // CAMARO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(883, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnExploradoras);
            this.Controls.Add(this.btnPolarizado);
            this.Controls.Add(this.btnLuces);
            this.Controls.Add(this.btnPintura);
            this.Controls.Add(this.cboExploradoras);
            this.Controls.Add(this.cboPolarizado);
            this.Controls.Add(this.cboLuces);
            this.Controls.Add(this.cboPintura);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CAMARO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CAMARO";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboPintura;
        private System.Windows.Forms.ComboBox cboLuces;
        private System.Windows.Forms.ComboBox cboPolarizado;
        private System.Windows.Forms.ComboBox cboExploradoras;
        private System.Windows.Forms.Button btnPintura;
        private System.Windows.Forms.Button btnLuces;
        private System.Windows.Forms.Button btnPolarizado;
        private System.Windows.Forms.Button btnExploradoras;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}