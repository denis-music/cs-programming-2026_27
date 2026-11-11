namespace DLWMS26.WinApp
{
    partial class frmPrijava
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrijava));
            pbLogo = new PictureBox();
            lblKorisnickoIme = new Label();
            txtKorisnickoIme = new TextBox();
            label2 = new Label();
            txtLozinka = new TextBox();
            lblLozinka = new Label();
            btnPrijava = new Button();
            err = new ErrorProvider(components);
            cmbJezik = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            SuspendLayout();
            // 
            // pbLogo
            // 
            pbLogo.Image = (Image)resources.GetObject("pbLogo.Image");
            pbLogo.Location = new Point(5, 28);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(206, 140);
            pbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbLogo.TabIndex = 0;
            pbLogo.TabStop = false;
            // 
            // lblKorisnickoIme
            // 
            lblKorisnickoIme.AutoSize = true;
            lblKorisnickoIme.Location = new Point(271, 28);
            lblKorisnickoIme.Name = "lblKorisnickoIme";
            lblKorisnickoIme.Size = new Size(88, 15);
            lblKorisnickoIme.TabIndex = 1;
            lblKorisnickoIme.Text = "Korisničko ime:";
            // 
            // txtKorisnickoIme
            // 
            txtKorisnickoIme.Font = new Font("Segoe UI", 13F);
            txtKorisnickoIme.Location = new Point(271, 46);
            txtKorisnickoIme.Name = "txtKorisnickoIme";
            txtKorisnickoIme.Size = new Size(234, 31);
            txtKorisnickoIme.TabIndex = 2;
            // 
            // label2
            // 
            label2.BackColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(237, 28);
            label2.Name = "label2";
            label2.Size = new Size(2, 140);
            label2.TabIndex = 3;
            // 
            // txtLozinka
            // 
            txtLozinka.Font = new Font("Segoe UI", 13F);
            txtLozinka.Location = new Point(271, 98);
            txtLozinka.Name = "txtLozinka";
            txtLozinka.PasswordChar = '*';
            txtLozinka.Size = new Size(234, 31);
            txtLozinka.TabIndex = 5;
            // 
            // lblLozinka
            // 
            lblLozinka.AutoSize = true;
            lblLozinka.Location = new Point(271, 80);
            lblLozinka.Name = "lblLozinka";
            lblLozinka.Size = new Size(50, 15);
            lblLozinka.TabIndex = 4;
            lblLozinka.Text = "Lozinka:";
            // 
            // btnPrijava
            // 
            btnPrijava.Location = new Point(430, 140);
            btnPrijava.Name = "btnPrijava";
            btnPrijava.Size = new Size(75, 28);
            btnPrijava.TabIndex = 6;
            btnPrijava.Text = "Prijava";
            btnPrijava.UseVisualStyleBackColor = true;
            btnPrijava.Click += btnPrijava_Click;
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // cmbJezik
            // 
            cmbJezik.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbJezik.FormattingEnabled = true;
            cmbJezik.Items.AddRange(new object[] { "BS", "EN" });
            cmbJezik.Location = new Point(459, 12);
            cmbJezik.Name = "cmbJezik";
            cmbJezik.Size = new Size(46, 23);
            cmbJezik.TabIndex = 7;
            cmbJezik.SelectedIndexChanged += cmbJezik_SelectedIndexChanged;
            // 
            // frmPrijava
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(520, 181);
            ControlBox = false;
            Controls.Add(cmbJezik);
            Controls.Add(btnPrijava);
            Controls.Add(txtLozinka);
            Controls.Add(lblLozinka);
            Controls.Add(label2);
            Controls.Add(txtKorisnickoIme);
            Controls.Add(lblKorisnickoIme);
            Controls.Add(pbLogo);
            Name = "frmPrijava";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Prijava";
            Load += frmPrijava_Load;
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbLogo;
        private Label lblKorisnickoIme;
        private TextBox txtKorisnickoIme;
        private Label label2;
        private TextBox txtLozinka;
        private Label lblLozinka;
        private Button btnPrijava;
        private ErrorProvider err;
        private ComboBox cmbJezik;
    }
}