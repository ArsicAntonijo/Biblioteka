namespace WindowsFormsApp1
{
    partial class Admin
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
            this.textID = new System.Windows.Forms.TextBox();
            this.textSifra = new System.Windows.Forms.TextBox();
            this.textPrezime = new System.Windows.Forms.TextBox();
            this.textIme = new System.Windows.Forms.TextBox();
            this.labelID = new System.Windows.Forms.Label();
            this.labelRaspolozivo = new System.Windows.Forms.Label();
            this.labelAutor = new System.Windows.Forms.Label();
            this.labelNazivKnjuge = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.poljePretrageRadnika = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonNoviRadnik = new System.Windows.Forms.Button();
            this.buttonUcitajPromene = new System.Windows.Forms.Button();
            this.buttonIzlaz = new System.Windows.Forms.Button();
            this.buttonPrebaci = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.studentFakultet = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.studentPrezime = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.studentIme = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.studentIndeks = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.poljePretageStudenta = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.buttonNoviSudent = new System.Windows.Forms.Button();
            this.buttonStudentIzmena = new System.Windows.Forms.Button();
            this.buttonBrisanjeRadnika = new System.Windows.Forms.Button();
            this.buttonBrisanjeStudenta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(128, 47);
            this.textID.Name = "textID";
            this.textID.ReadOnly = true;
            this.textID.Size = new System.Drawing.Size(147, 20);
            this.textID.TabIndex = 17;
            // 
            // textSifra
            // 
            this.textSifra.Location = new System.Drawing.Point(128, 152);
            this.textSifra.Name = "textSifra";
            this.textSifra.Size = new System.Drawing.Size(147, 20);
            this.textSifra.TabIndex = 16;
            this.textSifra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textPrezime
            // 
            this.textPrezime.Location = new System.Drawing.Point(128, 119);
            this.textPrezime.Name = "textPrezime";
            this.textPrezime.Size = new System.Drawing.Size(147, 20);
            this.textPrezime.TabIndex = 15;
            // 
            // textIme
            // 
            this.textIme.Location = new System.Drawing.Point(128, 83);
            this.textIme.Name = "textIme";
            this.textIme.Size = new System.Drawing.Size(147, 20);
            this.textIme.TabIndex = 14;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.Location = new System.Drawing.Point(7, 48);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(88, 16);
            this.labelID.TabIndex = 13;
            this.labelID.Text = "ID sluzbenika";
            // 
            // labelRaspolozivo
            // 
            this.labelRaspolozivo.AutoSize = true;
            this.labelRaspolozivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRaspolozivo.Location = new System.Drawing.Point(7, 156);
            this.labelRaspolozivo.Name = "labelRaspolozivo";
            this.labelRaspolozivo.Size = new System.Drawing.Size(115, 16);
            this.labelRaspolozivo.TabIndex = 12;
            this.labelRaspolozivo.Text = "Sifra za logovanje";
            // 
            // labelAutor
            // 
            this.labelAutor.AutoSize = true;
            this.labelAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAutor.Location = new System.Drawing.Point(7, 119);
            this.labelAutor.Name = "labelAutor";
            this.labelAutor.Size = new System.Drawing.Size(57, 16);
            this.labelAutor.TabIndex = 11;
            this.labelAutor.Text = "Prezime";
            // 
            // labelNazivKnjuge
            // 
            this.labelNazivKnjuge.AutoSize = true;
            this.labelNazivKnjuge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNazivKnjuge.Location = new System.Drawing.Point(7, 83);
            this.labelNazivKnjuge.Name = "labelNazivKnjuge";
            this.labelNazivKnjuge.Size = new System.Drawing.Size(33, 16);
            this.labelNazivKnjuge.TabIndex = 10;
            this.labelNazivKnjuge.Text = "Ime ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(304, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(421, 147);
            this.dataGridView1.TabIndex = 38;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // poljePretrageRadnika
            // 
            this.poljePretrageRadnika.Location = new System.Drawing.Point(423, 22);
            this.poljePretrageRadnika.Name = "poljePretrageRadnika";
            this.poljePretrageRadnika.Size = new System.Drawing.Size(231, 20);
            this.poljePretrageRadnika.TabIndex = 37;
            this.poljePretrageRadnika.TextChanged += new System.EventHandler(this.poljePretrageRadnika_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(301, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 16);
            this.label2.TabIndex = 36;
            this.label2.Text = "Pretraga radnika";
            // 
            // buttonNoviRadnik
            // 
            this.buttonNoviRadnik.Location = new System.Drawing.Point(9, 200);
            this.buttonNoviRadnik.Name = "buttonNoviRadnik";
            this.buttonNoviRadnik.Size = new System.Drawing.Size(122, 23);
            this.buttonNoviRadnik.TabIndex = 39;
            this.buttonNoviRadnik.Text = "Ubaci novog radnika";
            this.buttonNoviRadnik.UseVisualStyleBackColor = true;
            this.buttonNoviRadnik.Click += new System.EventHandler(this.buttonNoviRadnik_Click);
            // 
            // buttonUcitajPromene
            // 
            this.buttonUcitajPromene.Location = new System.Drawing.Point(217, 201);
            this.buttonUcitajPromene.Name = "buttonUcitajPromene";
            this.buttonUcitajPromene.Size = new System.Drawing.Size(110, 23);
            this.buttonUcitajPromene.TabIndex = 40;
            this.buttonUcitajPromene.Text = "Ucitaj promene";
            this.buttonUcitajPromene.UseVisualStyleBackColor = true;
            this.buttonUcitajPromene.Click += new System.EventHandler(this.buttonUcitajPromene_Click);
            // 
            // buttonIzlaz
            // 
            this.buttonIzlaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIzlaz.Location = new System.Drawing.Point(383, 478);
            this.buttonIzlaz.Name = "buttonIzlaz";
            this.buttonIzlaz.Size = new System.Drawing.Size(75, 23);
            this.buttonIzlaz.TabIndex = 41;
            this.buttonIzlaz.Text = "IZLAZ";
            this.buttonIzlaz.UseVisualStyleBackColor = true;
            this.buttonIzlaz.Click += new System.EventHandler(this.buttonIzlaz_Click);
            // 
            // buttonPrebaci
            // 
            this.buttonPrebaci.Location = new System.Drawing.Point(182, 476);
            this.buttonPrebaci.Name = "buttonPrebaci";
            this.buttonPrebaci.Size = new System.Drawing.Size(162, 25);
            this.buttonPrebaci.TabIndex = 42;
            this.buttonPrebaci.Text = "Rad sa studentima i knjigama";
            this.buttonPrebaci.UseVisualStyleBackColor = true;
            this.buttonPrebaci.Click += new System.EventHandler(this.buttonPrebaci_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(-1, 241);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(766, 10);
            this.button1.TabIndex = 43;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // studentFakultet
            // 
            this.studentFakultet.Location = new System.Drawing.Point(128, 395);
            this.studentFakultet.Name = "studentFakultet";
            this.studentFakultet.Size = new System.Drawing.Size(129, 20);
            this.studentFakultet.TabIndex = 51;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 399);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 50;
            this.label5.Text = "Fakultet";
            // 
            // studentPrezime
            // 
            this.studentPrezime.Location = new System.Drawing.Point(128, 358);
            this.studentPrezime.Name = "studentPrezime";
            this.studentPrezime.Size = new System.Drawing.Size(129, 20);
            this.studentPrezime.TabIndex = 49;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 362);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 16);
            this.label6.TabIndex = 48;
            this.label6.Text = "Prezime";
            // 
            // studentIme
            // 
            this.studentIme.Location = new System.Drawing.Point(128, 322);
            this.studentIme.Name = "studentIme";
            this.studentIme.Size = new System.Drawing.Size(129, 20);
            this.studentIme.TabIndex = 47;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 326);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 16);
            this.label4.TabIndex = 46;
            this.label4.Text = "Ime";
            // 
            // studentIndeks
            // 
            this.studentIndeks.Location = new System.Drawing.Point(128, 285);
            this.studentIndeks.Name = "studentIndeks";
            this.studentIndeks.Size = new System.Drawing.Size(129, 20);
            this.studentIndeks.TabIndex = 45;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 44;
            this.label3.Text = "Indeks";
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(304, 294);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.Size = new System.Drawing.Size(432, 135);
            this.dataGridView3.TabIndex = 54;
            this.dataGridView3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            this.dataGridView3.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView3_RowHeaderMouseClick);
            // 
            // poljePretageStudenta
            // 
            this.poljePretageStudenta.Location = new System.Drawing.Point(432, 268);
            this.poljePretageStudenta.Name = "poljePretageStudenta";
            this.poljePretageStudenta.Size = new System.Drawing.Size(283, 20);
            this.poljePretageStudenta.TabIndex = 53;
            this.poljePretageStudenta.TextChanged += new System.EventHandler(this.poljePretageStudenta_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(310, 269);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(116, 16);
            this.label11.TabIndex = 52;
            this.label11.Text = "Pretraga Studenta";
            // 
            // buttonNoviSudent
            // 
            this.buttonNoviSudent.Location = new System.Drawing.Point(22, 435);
            this.buttonNoviSudent.Name = "buttonNoviSudent";
            this.buttonNoviSudent.Size = new System.Drawing.Size(168, 23);
            this.buttonNoviSudent.TabIndex = 56;
            this.buttonNoviSudent.Text = "Ubaci novog studenta u bazu";
            this.buttonNoviSudent.UseVisualStyleBackColor = true;
            this.buttonNoviSudent.Click += new System.EventHandler(this.buttonNoviSudent_Click);
            // 
            // buttonStudentIzmena
            // 
            this.buttonStudentIzmena.Location = new System.Drawing.Point(217, 435);
            this.buttonStudentIzmena.Name = "buttonStudentIzmena";
            this.buttonStudentIzmena.Size = new System.Drawing.Size(110, 23);
            this.buttonStudentIzmena.TabIndex = 57;
            this.buttonStudentIzmena.Text = "Ucitaj promene";
            this.buttonStudentIzmena.UseVisualStyleBackColor = true;
            this.buttonStudentIzmena.Click += new System.EventHandler(this.buttonStudentIzmena_Click);
            // 
            // buttonBrisanjeRadnika
            // 
            this.buttonBrisanjeRadnika.Location = new System.Drawing.Point(383, 201);
            this.buttonBrisanjeRadnika.Name = "buttonBrisanjeRadnika";
            this.buttonBrisanjeRadnika.Size = new System.Drawing.Size(110, 23);
            this.buttonBrisanjeRadnika.TabIndex = 58;
            this.buttonBrisanjeRadnika.Text = "Obriši radnika";
            this.buttonBrisanjeRadnika.UseVisualStyleBackColor = true;
            this.buttonBrisanjeRadnika.Click += new System.EventHandler(this.buttonBrisanjeRadnika_Click);
            // 
            // buttonBrisanjeStudenta
            // 
            this.buttonBrisanjeStudenta.Location = new System.Drawing.Point(383, 435);
            this.buttonBrisanjeStudenta.Name = "buttonBrisanjeStudenta";
            this.buttonBrisanjeStudenta.Size = new System.Drawing.Size(110, 23);
            this.buttonBrisanjeStudenta.TabIndex = 59;
            this.buttonBrisanjeStudenta.Text = "Obriši studenta";
            this.buttonBrisanjeStudenta.UseVisualStyleBackColor = true;
            this.buttonBrisanjeStudenta.Click += new System.EventHandler(this.buttonBrisanjeStudenta_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 513);
            this.Controls.Add(this.buttonBrisanjeStudenta);
            this.Controls.Add(this.buttonBrisanjeRadnika);
            this.Controls.Add(this.buttonStudentIzmena);
            this.Controls.Add(this.buttonNoviSudent);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.poljePretageStudenta);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.studentFakultet);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.studentPrezime);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.studentIme);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.studentIndeks);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonPrebaci);
            this.Controls.Add(this.buttonIzlaz);
            this.Controls.Add(this.buttonUcitajPromene);
            this.Controls.Add(this.buttonNoviRadnik);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.poljePretrageRadnika);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.textSifra);
            this.Controls.Add(this.textPrezime);
            this.Controls.Add(this.textIme);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.labelRaspolozivo);
            this.Controls.Add(this.labelAutor);
            this.Controls.Add(this.labelNazivKnjuge);
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.TextBox textSifra;
        private System.Windows.Forms.TextBox textPrezime;
        private System.Windows.Forms.TextBox textIme;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelRaspolozivo;
        private System.Windows.Forms.Label labelAutor;
        private System.Windows.Forms.Label labelNazivKnjuge;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox poljePretrageRadnika;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonNoviRadnik;
        private System.Windows.Forms.Button buttonUcitajPromene;
        private System.Windows.Forms.Button buttonIzlaz;
        private System.Windows.Forms.Button buttonPrebaci;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox studentFakultet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox studentPrezime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox studentIme;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox studentIndeks;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.TextBox poljePretageStudenta;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button buttonNoviSudent;
        private System.Windows.Forms.Button buttonStudentIzmena;
        private System.Windows.Forms.Button buttonBrisanjeRadnika;
        private System.Windows.Forms.Button buttonBrisanjeStudenta;
    }
}