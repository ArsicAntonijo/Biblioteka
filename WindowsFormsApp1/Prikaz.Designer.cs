namespace WindowsFormsApp1
{
    partial class Prikaz
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
            this.prikazRezervacije = new System.Windows.Forms.DataGridView();
            this.poljePretrageRezervacije = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.prikazRazuzenja = new System.Windows.Forms.DataGridView();
            this.poljePretageRazduzenja = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.prikazRezervacije)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prikazRazuzenja)).BeginInit();
            this.SuspendLayout();
            // 
            // prikazRezervacije
            // 
            this.prikazRezervacije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.prikazRezervacije.Location = new System.Drawing.Point(29, 63);
            this.prikazRezervacije.Name = "prikazRezervacije";
            this.prikazRezervacije.ReadOnly = true;
            this.prikazRezervacije.Size = new System.Drawing.Size(373, 154);
            this.prikazRezervacije.TabIndex = 41;
            // 
            // poljePretrageRezervacije
            // 
            this.poljePretrageRezervacije.Location = new System.Drawing.Point(213, 37);
            this.poljePretrageRezervacije.Name = "poljePretrageRezervacije";
            this.poljePretrageRezervacije.Size = new System.Drawing.Size(159, 20);
            this.poljePretrageRezervacije.TabIndex = 40;
            this.poljePretrageRezervacije.TextChanged += new System.EventHandler(this.poljePretrageKnjige_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 16);
            this.label2.TabIndex = 39;
            this.label2.Text = "Pretraga rezervacije";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // prikazRazuzenja
            // 
            this.prikazRazuzenja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.prikazRazuzenja.Location = new System.Drawing.Point(29, 263);
            this.prikazRazuzenja.Name = "prikazRazuzenja";
            this.prikazRazuzenja.ReadOnly = true;
            this.prikazRazuzenja.Size = new System.Drawing.Size(440, 164);
            this.prikazRazuzenja.TabIndex = 38;
            // 
            // poljePretageRazduzenja
            // 
            this.poljePretageRazduzenja.Location = new System.Drawing.Point(253, 238);
            this.poljePretageRazduzenja.Name = "poljePretageRazduzenja";
            this.poljePretageRazduzenja.Size = new System.Drawing.Size(173, 20);
            this.poljePretageRazduzenja.TabIndex = 37;
            this.poljePretageRazduzenja.TextChanged += new System.EventHandler(this.poljePretageRazduzenja_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(39, 238);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(142, 16);
            this.label11.TabIndex = 36;
            this.label11.Text = "Pretraga razduzuvanja";
            // 
            // Prikaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 450);
            this.Controls.Add(this.prikazRezervacije);
            this.Controls.Add(this.poljePretrageRezervacije);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.prikazRazuzenja);
            this.Controls.Add(this.poljePretageRazduzenja);
            this.Controls.Add(this.label11);
            this.Name = "Prikaz";
            this.Text = "Prikaz";
            this.Load += new System.EventHandler(this.Prikaz_Load);
            ((System.ComponentModel.ISupportInitialize)(this.prikazRezervacije)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prikazRazuzenja)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView prikazRezervacije;
        private System.Windows.Forms.TextBox poljePretrageRezervacije;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView prikazRazuzenja;
        private System.Windows.Forms.TextBox poljePretageRazduzenja;
        private System.Windows.Forms.Label label11;
    }
}