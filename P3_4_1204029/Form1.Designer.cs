namespace P3_4_1204029
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.cbJk = new System.Windows.Forms.ComboBox();
            this.dtTglLahir = new System.Windows.Forms.DateTimePicker();
            this.btSelesai = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btTampilkan = new System.Windows.Forms.Button();
            this.gbJadwal = new System.Windows.Forms.GroupBox();
            this.rbJadwal1 = new System.Windows.Forms.RadioButton();
            this.rbJadwal3 = new System.Windows.Forms.RadioButton();
            this.rbJadwal4 = new System.Windows.Forms.RadioButton();
            this.rbJadwal2 = new System.Windows.Forms.RadioButton();
            this.gbKelas = new System.Windows.Forms.GroupBox();
            this.cbKomposer = new System.Windows.Forms.CheckBox();
            this.cbVokal = new System.Windows.Forms.CheckBox();
            this.cbDrum = new System.Windows.Forms.CheckBox();
            this.cbPiano = new System.Windows.Forms.CheckBox();
            this.cbKonduktor = new System.Windows.Forms.CheckBox();
            this.cbSaxophone = new System.Windows.Forms.CheckBox();
            this.cbGitar = new System.Windows.Forms.CheckBox();
            this.cbBiola = new System.Windows.Forms.CheckBox();
            this.gbJadwal.SuspendLayout();
            this.gbKelas.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(179, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(179, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Jenis Kelamin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(179, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tanggal Lahir";
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(286, 67);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(200, 20);
            this.txtNama.TabIndex = 3;
            // 
            // cbJk
            // 
            this.cbJk.FormattingEnabled = true;
            this.cbJk.Items.AddRange(new object[] {
            "Perempuan",
            "Laki-Laki"});
            this.cbJk.Location = new System.Drawing.Point(286, 108);
            this.cbJk.Name = "cbJk";
            this.cbJk.Size = new System.Drawing.Size(125, 21);
            this.cbJk.TabIndex = 4;
            this.cbJk.Text = "-Pilih Jenis Kelamin-";
            // 
            // dtTglLahir
            // 
            this.dtTglLahir.Location = new System.Drawing.Point(286, 147);
            this.dtTglLahir.Name = "dtTglLahir";
            this.dtTglLahir.Size = new System.Drawing.Size(125, 20);
            this.dtTglLahir.TabIndex = 5;
            // 
            // btSelesai
            // 
            this.btSelesai.Location = new System.Drawing.Point(320, 394);
            this.btSelesai.Name = "btSelesai";
            this.btSelesai.Size = new System.Drawing.Size(75, 23);
            this.btSelesai.TabIndex = 16;
            this.btSelesai.Text = "&Selesai";
            this.btSelesai.UseVisualStyleBackColor = true;
            this.btSelesai.Click += new System.EventHandler(this.btSelesai_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(250, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "FORM PENDAFTARARAN";
            // 
            // btTampilkan
            // 
            this.btTampilkan.Location = new System.Drawing.Point(229, 394);
            this.btTampilkan.Name = "btTampilkan";
            this.btTampilkan.Size = new System.Drawing.Size(75, 23);
            this.btTampilkan.TabIndex = 18;
            this.btTampilkan.Text = "&Tampilkan";
            this.btTampilkan.UseVisualStyleBackColor = true;
            this.btTampilkan.Click += new System.EventHandler(this.btTampilkan_Click);
            // 
            // gbJadwal
            // 
            this.gbJadwal.Controls.Add(this.rbJadwal1);
            this.gbJadwal.Controls.Add(this.rbJadwal3);
            this.gbJadwal.Controls.Add(this.rbJadwal4);
            this.gbJadwal.Controls.Add(this.rbJadwal2);
            this.gbJadwal.Location = new System.Drawing.Point(320, 208);
            this.gbJadwal.Name = "gbJadwal";
            this.gbJadwal.Size = new System.Drawing.Size(267, 180);
            this.gbJadwal.TabIndex = 12;
            this.gbJadwal.TabStop = false;
            this.gbJadwal.Text = "Pilihan Jadwal";
            this.gbJadwal.Enter += new System.EventHandler(this.gbJadwal_Enter);
            // 
            // rbJadwal1
            // 
            this.rbJadwal1.AutoSize = true;
            this.rbJadwal1.Location = new System.Drawing.Point(17, 19);
            this.rbJadwal1.Name = "rbJadwal1";
            this.rbJadwal1.Size = new System.Drawing.Size(159, 17);
            this.rbJadwal1.TabIndex = 8;
            this.rbJadwal1.TabStop = true;
            this.rbJadwal1.Text = "Senin  & Rabu , 14.00 - 16.00";
            this.rbJadwal1.UseVisualStyleBackColor = true;
            // 
            // rbJadwal3
            // 
            this.rbJadwal3.AutoSize = true;
            this.rbJadwal3.Location = new System.Drawing.Point(17, 87);
            this.rbJadwal3.Name = "rbJadwal3";
            this.rbJadwal3.Size = new System.Drawing.Size(169, 17);
            this.rbJadwal3.TabIndex = 10;
            this.rbJadwal3.TabStop = true;
            this.rbJadwal3.Text = "Sabtu &  Minggu , 19.00 - 11.00";
            this.rbJadwal3.UseVisualStyleBackColor = true;
            // 
            // rbJadwal4
            // 
            this.rbJadwal4.AutoSize = true;
            this.rbJadwal4.Location = new System.Drawing.Point(17, 124);
            this.rbJadwal4.Name = "rbJadwal4";
            this.rbJadwal4.Size = new System.Drawing.Size(132, 17);
            this.rbJadwal4.TabIndex = 11;
            this.rbJadwal4.TabStop = true;
            this.rbJadwal4.Text = "Minggu , 13.00 - 17.00";
            this.rbJadwal4.UseVisualStyleBackColor = true;
            // 
            // rbJadwal2
            // 
            this.rbJadwal2.AutoSize = true;
            this.rbJadwal2.Location = new System.Drawing.Point(17, 52);
            this.rbJadwal2.Name = "rbJadwal2";
            this.rbJadwal2.Size = new System.Drawing.Size(163, 17);
            this.rbJadwal2.TabIndex = 9;
            this.rbJadwal2.TabStop = true;
            this.rbJadwal2.Text = "Selasa & Kamis , 14.00 - 16.00";
            this.rbJadwal2.UseVisualStyleBackColor = true;
            // 
            // gbKelas
            // 
            this.gbKelas.Controls.Add(this.cbKomposer);
            this.gbKelas.Controls.Add(this.cbVokal);
            this.gbKelas.Controls.Add(this.cbDrum);
            this.gbKelas.Controls.Add(this.cbPiano);
            this.gbKelas.Controls.Add(this.cbKonduktor);
            this.gbKelas.Controls.Add(this.cbSaxophone);
            this.gbKelas.Controls.Add(this.cbGitar);
            this.gbKelas.Controls.Add(this.cbBiola);
            this.gbKelas.Location = new System.Drawing.Point(37, 208);
            this.gbKelas.Name = "gbKelas";
            this.gbKelas.Size = new System.Drawing.Size(267, 180);
            this.gbKelas.TabIndex = 10;
            this.gbKelas.TabStop = false;
            this.gbKelas.Text = "Pilihan Kelas ";
            this.gbKelas.Enter += new System.EventHandler(this.gbKelas_Enter);
            // 
            // cbKomposer
            // 
            this.cbKomposer.AutoSize = true;
            this.cbKomposer.Location = new System.Drawing.Point(170, 124);
            this.cbKomposer.Name = "cbKomposer";
            this.cbKomposer.Size = new System.Drawing.Size(73, 17);
            this.cbKomposer.TabIndex = 8;
            this.cbKomposer.Text = "Komposer";
            this.cbKomposer.UseVisualStyleBackColor = true;
            // 
            // cbVokal
            // 
            this.cbVokal.AutoSize = true;
            this.cbVokal.Location = new System.Drawing.Point(170, 89);
            this.cbVokal.Name = "cbVokal";
            this.cbVokal.Size = new System.Drawing.Size(53, 17);
            this.cbVokal.TabIndex = 7;
            this.cbVokal.Text = "Vokal";
            this.cbVokal.UseVisualStyleBackColor = true;
            // 
            // cbDrum
            // 
            this.cbDrum.AutoSize = true;
            this.cbDrum.Location = new System.Drawing.Point(170, 53);
            this.cbDrum.Name = "cbDrum";
            this.cbDrum.Size = new System.Drawing.Size(51, 17);
            this.cbDrum.TabIndex = 6;
            this.cbDrum.Text = "Drum";
            this.cbDrum.UseVisualStyleBackColor = true;
            // 
            // cbPiano
            // 
            this.cbPiano.AutoSize = true;
            this.cbPiano.Location = new System.Drawing.Point(170, 19);
            this.cbPiano.Name = "cbPiano";
            this.cbPiano.Size = new System.Drawing.Size(53, 17);
            this.cbPiano.TabIndex = 5;
            this.cbPiano.Text = "Piano";
            this.cbPiano.UseVisualStyleBackColor = true;
            // 
            // cbKonduktor
            // 
            this.cbKonduktor.AutoSize = true;
            this.cbKonduktor.Location = new System.Drawing.Point(17, 124);
            this.cbKonduktor.Name = "cbKonduktor";
            this.cbKonduktor.Size = new System.Drawing.Size(75, 17);
            this.cbKonduktor.TabIndex = 4;
            this.cbKonduktor.Text = "Konduktor";
            this.cbKonduktor.UseVisualStyleBackColor = true;
            // 
            // cbSaxophone
            // 
            this.cbSaxophone.AutoSize = true;
            this.cbSaxophone.Location = new System.Drawing.Point(17, 88);
            this.cbSaxophone.Name = "cbSaxophone";
            this.cbSaxophone.Size = new System.Drawing.Size(80, 17);
            this.cbSaxophone.TabIndex = 3;
            this.cbSaxophone.Text = "Saxophone";
            this.cbSaxophone.UseVisualStyleBackColor = true;
            // 
            // cbGitar
            // 
            this.cbGitar.AutoSize = true;
            this.cbGitar.Location = new System.Drawing.Point(17, 53);
            this.cbGitar.Name = "cbGitar";
            this.cbGitar.Size = new System.Drawing.Size(48, 17);
            this.cbGitar.TabIndex = 2;
            this.cbGitar.Text = "Gitar";
            this.cbGitar.UseVisualStyleBackColor = true;
            // 
            // cbBiola
            // 
            this.cbBiola.AutoSize = true;
            this.cbBiola.Location = new System.Drawing.Point(17, 20);
            this.cbBiola.Name = "cbBiola";
            this.cbBiola.Size = new System.Drawing.Size(49, 17);
            this.cbBiola.TabIndex = 1;
            this.cbBiola.Text = "Biola";
            this.cbBiola.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Violet;
            this.ClientSize = new System.Drawing.Size(624, 429);
            this.Controls.Add(this.gbKelas);
            this.Controls.Add(this.gbJadwal);
            this.Controls.Add(this.btTampilkan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btSelesai);
            this.Controls.Add(this.dtTglLahir);
            this.Controls.Add(this.cbJk);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "FORM  PENDAFTARAN";
            this.gbJadwal.ResumeLayout(false);
            this.gbJadwal.PerformLayout();
            this.gbKelas.ResumeLayout(false);
            this.gbKelas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.ComboBox cbJk;
        private System.Windows.Forms.DateTimePicker dtTglLahir;
        private System.Windows.Forms.Button btSelesai;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btTampilkan;
        private System.Windows.Forms.GroupBox gbJadwal;
        private System.Windows.Forms.RadioButton rbJadwal1;
        private System.Windows.Forms.RadioButton rbJadwal3;
        private System.Windows.Forms.RadioButton rbJadwal4;
        private System.Windows.Forms.RadioButton rbJadwal2;
        private System.Windows.Forms.GroupBox gbKelas;
        private System.Windows.Forms.CheckBox cbKomposer;
        private System.Windows.Forms.CheckBox cbVokal;
        private System.Windows.Forms.CheckBox cbDrum;
        private System.Windows.Forms.CheckBox cbPiano;
        private System.Windows.Forms.CheckBox cbKonduktor;
        private System.Windows.Forms.CheckBox cbSaxophone;
        private System.Windows.Forms.CheckBox cbGitar;
        private System.Windows.Forms.CheckBox cbBiola;
    }
}

