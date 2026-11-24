namespace DLWMS26.WinApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtStudenti = new TextBox();
            btnKupovina = new Button();
            txtKolicina = new TextBox();
            SuspendLayout();
            // 
            // txtStudenti
            // 
            txtStudenti.Location = new Point(12, 90);
            txtStudenti.Multiline = true;
            txtStudenti.Name = "txtStudenti";
            txtStudenti.Size = new Size(361, 258);
            txtStudenti.TabIndex = 0;
            // 
            // btnKupovina
            // 
            btnKupovina.Location = new Point(118, 31);
            btnKupovina.Name = "btnKupovina";
            btnKupovina.Size = new Size(75, 23);
            btnKupovina.TabIndex = 1;
            btnKupovina.Text = "Kupovina";
            btnKupovina.UseVisualStyleBackColor = true;
            btnKupovina.Click += btnKupovina_Click;
            // 
            // txtKolicina
            // 
            txtKolicina.Location = new Point(12, 31);
            txtKolicina.Name = "txtKolicina";
            txtKolicina.Size = new Size(100, 23);
            txtKolicina.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(394, 360);
            Controls.Add(txtKolicina);
            Controls.Add(btnKupovina);
            Controls.Add(txtStudenti);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtStudenti;
        private Button btnKupovina;
        private TextBox txtKolicina;
    }
}
