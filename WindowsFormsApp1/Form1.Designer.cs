namespace WindowsFormsApp1
{
    partial class form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form1));
            this.buttonPrikaziSve = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelNazivKnjuge = new System.Windows.Forms.Label();
            this.labelAutor = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.labelRaspolozivo = new System.Windows.Forms.Label();
            this.textNaziv = new System.Windows.Forms.TextBox();
            this.textAutor = new System.Windows.Forms.TextBox();
            this.textRaspolozivo = new System.Windows.Forms.TextBox();
            this.textID = new System.Windows.Forms.TextBox();
            this.buttonUbacivanje = new System.Windows.Forms.Button();
            this.buttonUcitajPromene = new System.Windows.Forms.Button();
            this.buttonBrisanje = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.poljePretrage = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.poljePretrageKnjige = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.poljePretageStudenta = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textKnjiga1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textDatum1 = new System.Windows.Forms.TextBox();
            this.buttonPovratak1 = new System.Windows.Forms.Button();
            this.buttonUzimanje1 = new System.Windows.Forms.Button();
            this.StudentID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.buttonPogeldajReyervacije = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonPrikaziSve
            // 
            this.buttonPrikaziSve.Location = new System.Drawing.Point(2, 377);
            this.buttonPrikaziSve.Name = "buttonPrikaziSve";
            this.buttonPrikaziSve.Size = new System.Drawing.Size(125, 23);
            this.buttonPrikaziSve.TabIndex = 0;
            this.buttonPrikaziSve.Text = "Prikazi sve kjige";
            this.buttonPrikaziSve.UseVisualStyleBackColor = true;
            this.buttonPrikaziSve.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(234, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(390, 295);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // labelNazivKnjuge
            // 
            this.labelNazivKnjuge.AutoSize = true;
            this.labelNazivKnjuge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNazivKnjuge.Location = new System.Drawing.Point(11, 246);
            this.labelNazivKnjuge.Name = "labelNazivKnjuge";
            this.labelNazivKnjuge.Size = new System.Drawing.Size(81, 16);
            this.labelNazivKnjuge.TabIndex = 2;
            this.labelNazivKnjuge.Text = "Naziv knjige";
            // 
            // labelAutor
            // 
            this.labelAutor.AutoSize = true;
            this.labelAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAutor.Location = new System.Drawing.Point(11, 282);
            this.labelAutor.Name = "labelAutor";
            this.labelAutor.Size = new System.Drawing.Size(39, 16);
            this.labelAutor.TabIndex = 3;
            this.labelAutor.Text = "Autor";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.Location = new System.Drawing.Point(11, 211);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(60, 16);
            this.labelID.TabIndex = 5;
            this.labelID.Text = "ID knjige";
            // 
            // labelRaspolozivo
            // 
            this.labelRaspolozivo.AutoSize = true;
            this.labelRaspolozivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRaspolozivo.Location = new System.Drawing.Point(11, 318);
            this.labelRaspolozivo.Name = "labelRaspolozivo";
            this.labelRaspolozivo.Size = new System.Drawing.Size(157, 16);
            this.labelRaspolozivo.TabIndex = 4;
            this.labelRaspolozivo.Text = "Primerci na raspolaganju";
            // 
            // textNaziv
            // 
            this.textNaziv.Location = new System.Drawing.Point(98, 246);
            this.textNaziv.Name = "textNaziv";
            this.textNaziv.Size = new System.Drawing.Size(130, 20);
            this.textNaziv.TabIndex = 6;
            // 
            // textAutor
            // 
            this.textAutor.Location = new System.Drawing.Point(98, 282);
            this.textAutor.Name = "textAutor";
            this.textAutor.Size = new System.Drawing.Size(130, 20);
            this.textAutor.TabIndex = 7;
            // 
            // textRaspolozivo
            // 
            this.textRaspolozivo.Location = new System.Drawing.Point(181, 314);
            this.textRaspolozivo.Name = "textRaspolozivo";
            this.textRaspolozivo.Size = new System.Drawing.Size(47, 20);
            this.textRaspolozivo.TabIndex = 8;
            this.textRaspolozivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textRaspolozivo.TextChanged += new System.EventHandler(this.textRaspolozivo_TextChanged);
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(98, 210);
            this.textID.Name = "textID";
            this.textID.ReadOnly = true;
            this.textID.Size = new System.Drawing.Size(130, 20);
            this.textID.TabIndex = 9;
            // 
            // buttonUbacivanje
            // 
            this.buttonUbacivanje.Location = new System.Drawing.Point(160, 377);
            this.buttonUbacivanje.Name = "buttonUbacivanje";
            this.buttonUbacivanje.Size = new System.Drawing.Size(123, 23);
            this.buttonUbacivanje.TabIndex = 10;
            this.buttonUbacivanje.Text = "Unesi novu knjigu";
            this.buttonUbacivanje.UseVisualStyleBackColor = true;
            this.buttonUbacivanje.Click += new System.EventHandler(this.buttonUbacivanje_Click);
            // 
            // buttonUcitajPromene
            // 
            this.buttonUcitajPromene.Location = new System.Drawing.Point(316, 377);
            this.buttonUcitajPromene.Name = "buttonUcitajPromene";
            this.buttonUcitajPromene.Size = new System.Drawing.Size(119, 23);
            this.buttonUcitajPromene.TabIndex = 11;
            this.buttonUcitajPromene.Text = "Ucitaj promene";
            this.buttonUcitajPromene.UseVisualStyleBackColor = true;
            this.buttonUcitajPromene.Click += new System.EventHandler(this.buttonUcitajPromene_Click);
            // 
            // buttonBrisanje
            // 
            this.buttonBrisanje.Location = new System.Drawing.Point(479, 377);
            this.buttonBrisanje.Name = "buttonBrisanje";
            this.buttonBrisanje.Size = new System.Drawing.Size(121, 23);
            this.buttonBrisanje.TabIndex = 12;
            this.buttonBrisanje.Text = "Obrisi knjigu";
            this.buttonBrisanje.UseVisualStyleBackColor = true;
            this.buttonBrisanje.Click += new System.EventHandler(this.buttonBrisanje_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(231, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Pretrazi knjigu";
            // 
            // poljePretrage
            // 
            this.poljePretrage.Location = new System.Drawing.Point(338, 20);
            this.poljePretrage.Name = "poljePretrage";
            this.poljePretrage.Size = new System.Drawing.Size(262, 20);
            this.poljePretrage.TabIndex = 14;
            this.poljePretrage.TextChanged += new System.EventHandler(this.poljePretrage_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(33, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(184, 164);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(630, -2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(8, 450);
            this.button1.TabIndex = 17;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(681, 328);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(457, 110);
            this.dataGridView2.TabIndex = 35;
            this.dataGridView2.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView2_RowHeaderMouseClick);
            // 
            // poljePretrageKnjige
            // 
            this.poljePretrageKnjige.Location = new System.Drawing.Point(880, 302);
            this.poljePretrageKnjige.Name = "poljePretrageKnjige";
            this.poljePretrageKnjige.Size = new System.Drawing.Size(173, 20);
            this.poljePretrageKnjige.TabIndex = 34;
            this.poljePretrageKnjige.TextChanged += new System.EventHandler(this.poljePretrageKnjige_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(758, 303);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 33;
            this.label2.Text = "Pretraga Knjige";
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(681, 188);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.Size = new System.Drawing.Size(457, 108);
            this.dataGridView3.TabIndex = 32;
            this.dataGridView3.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView3_RowHeaderMouseClick);
            // 
            // poljePretageStudenta
            // 
            this.poljePretageStudenta.Location = new System.Drawing.Point(880, 162);
            this.poljePretageStudenta.Name = "poljePretageStudenta";
            this.poljePretageStudenta.Size = new System.Drawing.Size(173, 20);
            this.poljePretageStudenta.TabIndex = 31;
            this.poljePretageStudenta.TextChanged += new System.EventHandler(this.poljePretageStudenta_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(691, 163);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(183, 16);
            this.label11.TabIndex = 30;
            this.label11.Text = "Pretraga Studenta/Pozajmice";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(690, 69);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 16);
            this.label10.TabIndex = 44;
            this.label10.Text = "Knjiga";
            // 
            // textKnjiga1
            // 
            this.textKnjiga1.Location = new System.Drawing.Point(799, 65);
            this.textKnjiga1.Name = "textKnjiga1";
            this.textKnjiga1.Size = new System.Drawing.Size(80, 20);
            this.textKnjiga1.TabIndex = 45;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(690, 103);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 16);
            this.label9.TabIndex = 46;
            this.label9.Text = "Datum uzimanja";
            // 
            // textDatum1
            // 
            this.textDatum1.Location = new System.Drawing.Point(799, 102);
            this.textDatum1.Name = "textDatum1";
            this.textDatum1.Size = new System.Drawing.Size(129, 20);
            this.textDatum1.TabIndex = 47;
            // 
            // buttonPovratak1
            // 
            this.buttonPovratak1.Location = new System.Drawing.Point(960, 69);
            this.buttonPovratak1.Name = "buttonPovratak1";
            this.buttonPovratak1.Size = new System.Drawing.Size(93, 22);
            this.buttonPovratak1.TabIndex = 52;
            this.buttonPovratak1.Text = "Povratak knjige";
            this.buttonPovratak1.UseVisualStyleBackColor = true;
            this.buttonPovratak1.Click += new System.EventHandler(this.buttonPovratak1_Click);
            // 
            // buttonUzimanje1
            // 
            this.buttonUzimanje1.Location = new System.Drawing.Point(960, 38);
            this.buttonUzimanje1.Name = "buttonUzimanje1";
            this.buttonUzimanje1.Size = new System.Drawing.Size(93, 21);
            this.buttonUzimanje1.TabIndex = 54;
            this.buttonUzimanje1.Text = "Uzimanje Knjige";
            this.buttonUzimanje1.UseVisualStyleBackColor = true;
            this.buttonUzimanje1.Click += new System.EventHandler(this.buttonUzimanje1_Click);
            // 
            // StudentID
            // 
            this.StudentID.Location = new System.Drawing.Point(799, 30);
            this.StudentID.Name = "StudentID";
            this.StudentID.Size = new System.Drawing.Size(80, 20);
            this.StudentID.TabIndex = 56;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(690, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 55;
            this.label3.Text = "Student";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(1024, 120);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(98, 17);
            this.checkBox1.TabIndex = 57;
            this.checkBox1.Text = "prikaz studenta";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // buttonPogeldajReyervacije
            // 
            this.buttonPogeldajReyervacije.Location = new System.Drawing.Point(246, 415);
            this.buttonPogeldajReyervacije.Name = "buttonPogeldajReyervacije";
            this.buttonPogeldajReyervacije.Size = new System.Drawing.Size(121, 23);
            this.buttonPogeldajReyervacije.TabIndex = 58;
            this.buttonPogeldajReyervacije.Text = "Pogledaj rezervacije";
            this.buttonPogeldajReyervacije.UseVisualStyleBackColor = true;
            this.buttonPogeldajReyervacije.Click += new System.EventHandler(this.buttonPogeldajReyervacije_Click);
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 450);
            this.Controls.Add(this.buttonPogeldajReyervacije);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.StudentID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonUzimanje1);
            this.Controls.Add(this.buttonPovratak1);
            this.Controls.Add(this.textDatum1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textKnjiga1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.poljePretrageKnjige);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.poljePretageStudenta);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.poljePretrage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonBrisanje);
            this.Controls.Add(this.buttonUcitajPromene);
            this.Controls.Add(this.buttonUbacivanje);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.textRaspolozivo);
            this.Controls.Add(this.textAutor);
            this.Controls.Add(this.textNaziv);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.labelRaspolozivo);
            this.Controls.Add(this.labelAutor);
            this.Controls.Add(this.labelNazivKnjuge);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonPrikaziSve);
            this.Name = "form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FIN Biblioteka";
            this.Load += new System.EventHandler(this.form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPrikaziSve;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelNazivKnjuge;
        private System.Windows.Forms.Label labelAutor;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelRaspolozivo;
        private System.Windows.Forms.TextBox textNaziv;
        private System.Windows.Forms.TextBox textAutor;
        private System.Windows.Forms.TextBox textRaspolozivo;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.Button buttonUbacivanje;
        private System.Windows.Forms.Button buttonUcitajPromene;
        private System.Windows.Forms.Button buttonBrisanje;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox poljePretrage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox poljePretrageKnjige;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.TextBox poljePretageStudenta;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textKnjiga1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textDatum1;
        private System.Windows.Forms.Button buttonPovratak1;
        private System.Windows.Forms.Button buttonUzimanje1;
        private System.Windows.Forms.TextBox StudentID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button buttonPogeldajReyervacije;
    }
}

