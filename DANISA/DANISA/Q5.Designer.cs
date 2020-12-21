namespace DANISA
{
    partial class Q5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Q5));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboPintura = new System.Windows.Forms.ComboBox();
            this.cboLuces = new System.Windows.Forms.ComboBox();
            this.cboPolarizado = new System.Windows.Forms.ComboBox();
            this.btnPintura = new System.Windows.Forms.Button();
            this.btnPolarizado = new System.Windows.Forms.Button();
            this.btnLuces = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cboExploradoras = new System.Windows.Forms.ComboBox();
            this.btnExploradoras = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(394, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(578, 326);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Aqua;
            this.label1.Location = new System.Drawing.Point(12, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "PINTURA:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Aqua;
            this.label2.Location = new System.Drawing.Point(12, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "LUCES:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Aqua;
            this.label3.Location = new System.Drawing.Point(12, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "POLARIZADO:";
            // 
            // cboPintura
            // 
            this.cboPintura.FormattingEnabled = true;
            this.cboPintura.Items.AddRange(new object[] {
            "Amarillo",
            "Azul",
            "BLANCO",
            "Morado",
            "Verde",
            "Vinotinto"});
            this.cboPintura.Location = new System.Drawing.Point(130, 54);
            this.cboPintura.Name = "cboPintura";
            this.cboPintura.Size = new System.Drawing.Size(172, 21);
            this.cboPintura.TabIndex = 4;
            this.cboPintura.SelectedIndexChanged += new System.EventHandler(this.cboPintura_SelectedIndexChanged);
            // 
            // cboLuces
            // 
            this.cboLuces.FormattingEnabled = true;
            this.cboLuces.Items.AddRange(new object[] {
            "Amarillo_Luces",
            "Azul_Luces",
            "Blanca_Luces",
            "Morado_Luces",
            "Verde_Luces",
            "Vinotinto_luces"});
            this.cboLuces.Location = new System.Drawing.Point(130, 191);
            this.cboLuces.Name = "cboLuces";
            this.cboLuces.Size = new System.Drawing.Size(172, 21);
            this.cboLuces.TabIndex = 5;
            // 
            // cboPolarizado
            // 
            this.cboPolarizado.FormattingEnabled = true;
            this.cboPolarizado.Items.AddRange(new object[] {
            "Amarillo+pol",
            "Azul+pol",
            "Blanco+pol",
            "Morado+pol",
            "Verde+pol",
            "Vinotinto+pol"});
            this.cboPolarizado.Location = new System.Drawing.Point(130, 123);
            this.cboPolarizado.Name = "cboPolarizado";
            this.cboPolarizado.Size = new System.Drawing.Size(172, 21);
            this.cboPolarizado.TabIndex = 6;
            // 
            // btnPintura
            // 
            this.btnPintura.BackColor = System.Drawing.Color.Aqua;
            this.btnPintura.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPintura.Location = new System.Drawing.Point(327, 48);
            this.btnPintura.Name = "btnPintura";
            this.btnPintura.Size = new System.Drawing.Size(36, 30);
            this.btnPintura.TabIndex = 7;
            this.btnPintura.Text = "✔";
            this.btnPintura.UseVisualStyleBackColor = false;
            this.btnPintura.Click += new System.EventHandler(this.BtnPintura_Click);
            // 
            // btnPolarizado
            // 
            this.btnPolarizado.BackColor = System.Drawing.Color.Aqua;
            this.btnPolarizado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPolarizado.Location = new System.Drawing.Point(327, 117);
            this.btnPolarizado.Name = "btnPolarizado";
            this.btnPolarizado.Size = new System.Drawing.Size(36, 30);
            this.btnPolarizado.TabIndex = 8;
            this.btnPolarizado.Text = "✔";
            this.btnPolarizado.UseVisualStyleBackColor = false;
            this.btnPolarizado.Click += new System.EventHandler(this.BtnPolarizado_Click);
            // 
            // btnLuces
            // 
            this.btnLuces.BackColor = System.Drawing.Color.Aqua;
            this.btnLuces.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuces.Location = new System.Drawing.Point(327, 185);
            this.btnLuces.Name = "btnLuces";
            this.btnLuces.Size = new System.Drawing.Size(36, 30);
            this.btnLuces.TabIndex = 9;
            this.btnLuces.Text = "✔";
            this.btnLuces.UseVisualStyleBackColor = false;
            this.btnLuces.Click += new System.EventHandler(this.BtnLuces_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Aqua;
            this.label4.Location = new System.Drawing.Point(12, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "EXPLORADORAS:";
            // 
            // cboExploradoras
            // 
            this.cboExploradoras.FormattingEnabled = true;
            this.cboExploradoras.Items.AddRange(new object[] {
            "Amarillo+Luces+exp",
            "Azul+Luces+exp",
            "Blanca+Luces+exp",
            "Morado+Luces+exp",
            "Verde+Luces+exp",
            "Vinotinto+Luces+exp"});
            this.cboExploradoras.Location = new System.Drawing.Point(149, 254);
            this.cboExploradoras.Name = "cboExploradoras";
            this.cboExploradoras.Size = new System.Drawing.Size(172, 21);
            this.cboExploradoras.TabIndex = 11;
            // 
            // btnExploradoras
            // 
            this.btnExploradoras.BackColor = System.Drawing.Color.Aqua;
            this.btnExploradoras.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExploradoras.Location = new System.Drawing.Point(327, 248);
            this.btnExploradoras.Name = "btnExploradoras";
            this.btnExploradoras.Size = new System.Drawing.Size(36, 30);
            this.btnExploradoras.TabIndex = 12;
            this.btnExploradoras.Text = "✔";
            this.btnExploradoras.UseVisualStyleBackColor = false;
            this.btnExploradoras.Click += new System.EventHandler(this.BtnExploradoras_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Aqua;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(776, 387);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 34);
            this.button1.TabIndex = 13;
            this.button1.Text = "CONTINUAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Aqua;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(15, 387);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(196, 34);
            this.button2.TabIndex = 14;
            this.button2.Text = "ATRÁS";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Q5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(984, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnExploradoras);
            this.Controls.Add(this.cboExploradoras);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnLuces);
            this.Controls.Add(this.btnPolarizado);
            this.Controls.Add(this.btnPintura);
            this.Controls.Add(this.cboPolarizado);
            this.Controls.Add(this.cboLuces);
            this.Controls.Add(this.cboPintura);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Q5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Q5";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboPintura;
        private System.Windows.Forms.ComboBox cboLuces;
        private System.Windows.Forms.ComboBox cboPolarizado;
        private System.Windows.Forms.Button btnPintura;
        private System.Windows.Forms.Button btnPolarizado;
        private System.Windows.Forms.Button btnLuces;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboExploradoras;
        private System.Windows.Forms.Button btnExploradoras;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}