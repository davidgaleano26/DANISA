namespace DANISA
{
    partial class VistaPrevia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VistaPrevia));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cboPintura = new System.Windows.Forms.ComboBox();
            this.cboPolarizado = new System.Windows.Forms.ComboBox();
            this.cboExploradoras = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnPintura = new System.Windows.Forms.Button();
            this.btnPolarizado = new System.Windows.Forms.Button();
            this.btnExploradora = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(441, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(639, 360);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // cboPintura
            // 
            this.cboPintura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboPintura.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPintura.FormattingEnabled = true;
            this.cboPintura.Items.AddRange(new object[] {
            "Amarillo",
            "Azul",
            "Blanco",
            "Gris",
            "Morado",
            "Rojo"});
            this.cboPintura.Location = new System.Drawing.Point(209, 68);
            this.cboPintura.Name = "cboPintura";
            this.cboPintura.Size = new System.Drawing.Size(121, 24);
            this.cboPintura.TabIndex = 1;
            this.cboPintura.SelectedIndexChanged += new System.EventHandler(this.CboPintura_SelectedIndexChanged);
            // 
            // cboPolarizado
            // 
            this.cboPolarizado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboPolarizado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPolarizado.FormattingEnabled = true;
            this.cboPolarizado.Items.AddRange(new object[] {
            "Amarillo_Polarizado",
            "Azul_Polarizado",
            "Blanco_Polarizado",
            "Gris_Polarizado",
            "Morado_Polarizado",
            "Rojo_Polarizado"});
            this.cboPolarizado.Location = new System.Drawing.Point(209, 123);
            this.cboPolarizado.Name = "cboPolarizado";
            this.cboPolarizado.Size = new System.Drawing.Size(121, 24);
            this.cboPolarizado.TabIndex = 2;
            // 
            // cboExploradoras
            // 
            this.cboExploradoras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboExploradoras.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboExploradoras.FormattingEnabled = true;
            this.cboExploradoras.Items.AddRange(new object[] {
            "Amarillo_exploradora",
            "Azul_exploradora",
            "Blanco_exploradora",
            "Gris_exploradora",
            "Rojo_exploradora",
            "Morado_exploradora",
            "Amarillo+exp+pol",
            "Azul+exp+pol",
            "Blanco+exp+pol",
            "Gris+exp+pol",
            "Rojo+exp+pol",
            "Morado+exp+pol"});
            this.cboExploradoras.Location = new System.Drawing.Point(209, 177);
            this.cboExploradoras.Name = "cboExploradoras";
            this.cboExploradoras.Size = new System.Drawing.Size(121, 24);
            this.cboExploradoras.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Aqua;
            this.label1.Location = new System.Drawing.Point(12, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "PINTURA:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Aqua;
            this.label2.Location = new System.Drawing.Point(12, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "POLARIZADO:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Aqua;
            this.label7.Location = new System.Drawing.Point(12, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "EXPLORADORAS:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Aqua;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(801, 499);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(247, 34);
            this.button1.TabIndex = 15;
            this.button1.Text = "CONTINUAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1095, 543);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.PictureBox2_Click);
            // 
            // btnPintura
            // 
            this.btnPintura.BackColor = System.Drawing.Color.Aqua;
            this.btnPintura.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPintura.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPintura.Location = new System.Drawing.Point(349, 62);
            this.btnPintura.Name = "btnPintura";
            this.btnPintura.Size = new System.Drawing.Size(34, 34);
            this.btnPintura.TabIndex = 17;
            this.btnPintura.Text = "✔";
            this.btnPintura.UseVisualStyleBackColor = false;
            this.btnPintura.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // btnPolarizado
            // 
            this.btnPolarizado.BackColor = System.Drawing.Color.Aqua;
            this.btnPolarizado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPolarizado.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPolarizado.Location = new System.Drawing.Point(349, 117);
            this.btnPolarizado.Name = "btnPolarizado";
            this.btnPolarizado.Size = new System.Drawing.Size(34, 34);
            this.btnPolarizado.TabIndex = 19;
            this.btnPolarizado.Text = "✔";
            this.btnPolarizado.UseVisualStyleBackColor = false;
            this.btnPolarizado.Click += new System.EventHandler(this.BtnPolarizado_Click);
            // 
            // btnExploradora
            // 
            this.btnExploradora.BackColor = System.Drawing.Color.Aqua;
            this.btnExploradora.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExploradora.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnExploradora.Location = new System.Drawing.Point(349, 171);
            this.btnExploradora.Name = "btnExploradora";
            this.btnExploradora.Size = new System.Drawing.Size(34, 34);
            this.btnExploradora.TabIndex = 24;
            this.btnExploradora.Text = "✔";
            this.btnExploradora.UseVisualStyleBackColor = false;
            this.btnExploradora.Click += new System.EventHandler(this.BtnExploradora_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Aqua;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(25, 499);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(247, 34);
            this.button2.TabIndex = 25;
            this.button2.Text = "ATRÁS";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // VistaPrevia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1092, 545);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnExploradora);
            this.Controls.Add(this.btnPolarizado);
            this.Controls.Add(this.btnPintura);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboExploradoras);
            this.Controls.Add(this.cboPolarizado);
            this.Controls.Add(this.cboPintura);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VistaPrevia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VistaPrevia";
            this.Load += new System.EventHandler(this.VistaPrevia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cboPintura;
        private System.Windows.Forms.ComboBox cboPolarizado;
        private System.Windows.Forms.ComboBox cboExploradoras;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnPintura;
        private System.Windows.Forms.Button btnPolarizado;
        private System.Windows.Forms.Button btnExploradora;
        private System.Windows.Forms.Button button2;
    }
}