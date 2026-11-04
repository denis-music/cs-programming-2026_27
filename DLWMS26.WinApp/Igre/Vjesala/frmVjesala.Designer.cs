namespace DLWMS26.WinApp.Igre.Vjesala
{
    partial class frmVjesala
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
            lblPrikaz = new Label();
            txtSlovo = new TextBox();
            btnDodaj = new Button();
            progresPokusaji = new ProgressBar();
            SuspendLayout();
            // 
            // lblPrikaz
            // 
            lblPrikaz.AutoSize = true;
            lblPrikaz.Font = new Font("Segoe UI", 30F);
            lblPrikaz.Location = new Point(15, 84);
            lblPrikaz.Name = "lblPrikaz";
            lblPrikaz.Size = new Size(410, 54);
            lblPrikaz.TabIndex = 0;
            lblPrikaz.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtSlovo
            // 
            txtSlovo.Font = new Font("Segoe UI", 15F);
            txtSlovo.Location = new Point(97, 185);
            txtSlovo.Name = "txtSlovo";
            txtSlovo.Size = new Size(100, 34);
            txtSlovo.TabIndex = 1;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(221, 184);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(115, 35);
            btnDodaj.TabIndex = 2;
            btnDodaj.Text = "Dodaj";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // progresPokusaji
            // 
            progresPokusaji.Location = new Point(15, 25);
            progresPokusaji.Name = "progresPokusaji";
            progresPokusaji.Size = new Size(410, 23);
            progresPokusaji.TabIndex = 3;
            // 
            // frmVjesala
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(452, 234);
            Controls.Add(progresPokusaji);
            Controls.Add(btnDodaj);
            Controls.Add(txtSlovo);
            Controls.Add(lblPrikaz);
            Name = "frmVjesala";
            Text = "frmVjesala";
            Load += frmVjesala_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPrikaz;
        private TextBox txtSlovo;
        private Button btnDodaj;
        private ProgressBar progresPokusaji;
    }
}