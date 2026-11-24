namespace DLWMS26.WinApp.Sluzba
{
    partial class frmStudentiNovi
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
            txtBrojIndeksa = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtIme = new TextBox();
            label3 = new Label();
            txtPrezime = new TextBox();
            label4 = new Label();
            txtEmail = new TextBox();
            label5 = new Label();
            txtLozinka = new TextBox();
            dtpDatumRodjenja = new DateTimePicker();
            label6 = new Label();
            cbAktivan = new CheckBox();
            pbSlikaStudenta = new PictureBox();
            label7 = new Label();
            btnUcitajSliku = new Button();
            btnSacuvaj = new Button();
            ofdSlikaStudenta = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)pbSlikaStudenta).BeginInit();
            SuspendLayout();
            // 
            // txtBrojIndeksa
            // 
            txtBrojIndeksa.Location = new Point(167, 36);
            txtBrojIndeksa.Name = "txtBrojIndeksa";
            txtBrojIndeksa.Size = new Size(147, 23);
            txtBrojIndeksa.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(167, 18);
            label1.Name = "label1";
            label1.Size = new Size(74, 15);
            label1.TabIndex = 1;
            label1.Text = "Broj indeksa:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(167, 62);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
            label2.TabIndex = 3;
            label2.Text = "Ime:";
            // 
            // txtIme
            // 
            txtIme.Location = new Point(167, 80);
            txtIme.Name = "txtIme";
            txtIme.Size = new Size(147, 23);
            txtIme.TabIndex = 2;
            txtIme.TextChanged += txtIme_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(320, 62);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 5;
            label3.Text = "Prezime: ";
            // 
            // txtPrezime
            // 
            txtPrezime.Location = new Point(320, 80);
            txtPrezime.Name = "txtPrezime";
            txtPrezime.Size = new Size(147, 23);
            txtPrezime.TabIndex = 3;
            txtPrezime.TextChanged += txtPrezime_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(167, 106);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 7;
            label4.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(167, 124);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(147, 23);
            txtEmail.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(320, 106);
            label5.Name = "label5";
            label5.Size = new Size(50, 15);
            label5.TabIndex = 9;
            label5.Text = "Lozinka:";
            // 
            // txtLozinka
            // 
            txtLozinka.Location = new Point(320, 124);
            txtLozinka.Name = "txtLozinka";
            txtLozinka.Size = new Size(147, 23);
            txtLozinka.TabIndex = 5;
            // 
            // dtpDatumRodjenja
            // 
            dtpDatumRodjenja.Location = new Point(167, 169);
            dtpDatumRodjenja.Name = "dtpDatumRodjenja";
            dtpDatumRodjenja.Size = new Size(300, 23);
            dtpDatumRodjenja.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(167, 151);
            label6.Name = "label6";
            label6.Size = new Size(89, 15);
            label6.TabIndex = 11;
            label6.Text = "Datum rođenja:";
            // 
            // cbAktivan
            // 
            cbAktivan.AutoSize = true;
            cbAktivan.Location = new Point(167, 209);
            cbAktivan.Name = "cbAktivan";
            cbAktivan.Size = new Size(66, 19);
            cbAktivan.TabIndex = 7;
            cbAktivan.Text = "Aktivan";
            cbAktivan.UseVisualStyleBackColor = true;
            // 
            // pbSlikaStudenta
            // 
            pbSlikaStudenta.BorderStyle = BorderStyle.FixedSingle;
            pbSlikaStudenta.Location = new Point(15, 36);
            pbSlikaStudenta.Name = "pbSlikaStudenta";
            pbSlikaStudenta.Size = new Size(136, 170);
            pbSlikaStudenta.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSlikaStudenta.TabIndex = 13;
            pbSlikaStudenta.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(15, 18);
            label7.Name = "label7";
            label7.Size = new Size(34, 15);
            label7.TabIndex = 14;
            label7.Text = "Slika:";
            // 
            // btnUcitajSliku
            // 
            btnUcitajSliku.Location = new Point(15, 212);
            btnUcitajSliku.Name = "btnUcitajSliku";
            btnUcitajSliku.Size = new Size(136, 23);
            btnUcitajSliku.TabIndex = 0;
            btnUcitajSliku.Text = "Učitaj sliku";
            btnUcitajSliku.UseVisualStyleBackColor = true;
            btnUcitajSliku.Click += btnUcitajSliku_Click;
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(392, 234);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(75, 23);
            btnSacuvaj.TabIndex = 8;
            btnSacuvaj.Text = "Sačuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            btnSacuvaj.Click += btnSacuvaj_Click;
            // 
            // ofdSlikaStudenta
            // 
            ofdSlikaStudenta.FileName = "openFileDialog1";
            // 
            // frmStudentiNovi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(480, 264);
            Controls.Add(btnSacuvaj);
            Controls.Add(btnUcitajSliku);
            Controls.Add(label7);
            Controls.Add(pbSlikaStudenta);
            Controls.Add(cbAktivan);
            Controls.Add(label6);
            Controls.Add(dtpDatumRodjenja);
            Controls.Add(label5);
            Controls.Add(txtLozinka);
            Controls.Add(label4);
            Controls.Add(txtEmail);
            Controls.Add(label3);
            Controls.Add(txtPrezime);
            Controls.Add(label2);
            Controls.Add(txtIme);
            Controls.Add(label1);
            Controls.Add(txtBrojIndeksa);
            Name = "frmStudentiNovi";
            Text = "Podaci o studentu";
            Load += frmStudentiNovi_Load;
            ((System.ComponentModel.ISupportInitialize)pbSlikaStudenta).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBrojIndeksa;
        private Label label1;
        private Label label2;
        private TextBox txtIme;
        private Label label3;
        private TextBox txtPrezime;
        private Label label4;
        private TextBox txtEmail;
        private Label label5;
        private TextBox txtLozinka;
        private DateTimePicker dtpDatumRodjenja;
        private Label label6;
        private CheckBox cbAktivan;
        private PictureBox pbSlikaStudenta;
        private Label label7;
        private Button btnUcitajSliku;
        private Button btnSacuvaj;
        private OpenFileDialog ofdSlikaStudenta;
    }
}