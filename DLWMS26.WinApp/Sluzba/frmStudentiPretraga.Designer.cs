namespace DLWMS26.WinApp.Sluzba
{
    partial class frmStudentiPretraga
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
            dgvStudenti = new DataGridView();
            btnNoviStudent = new Button();
            txtPretraga = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvStudenti).BeginInit();
            SuspendLayout();
            // 
            // dgvStudenti
            // 
            dgvStudenti.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudenti.Location = new Point(12, 83);
            dgvStudenti.Name = "dgvStudenti";
            dgvStudenti.Size = new Size(776, 262);
            dgvStudenti.TabIndex = 0;
            // 
            // btnNoviStudent
            // 
            btnNoviStudent.Location = new Point(702, 54);
            btnNoviStudent.Name = "btnNoviStudent";
            btnNoviStudent.Size = new Size(86, 23);
            btnNoviStudent.TabIndex = 1;
            btnNoviStudent.Text = "Novi student";
            btnNoviStudent.UseVisualStyleBackColor = true;
            btnNoviStudent.Click += btnNoviStudent_Click;
            // 
            // txtPretraga
            // 
            txtPretraga.Location = new Point(12, 54);
            txtPretraga.Name = "txtPretraga";
            txtPretraga.Size = new Size(496, 23);
            txtPretraga.TabIndex = 2;
            txtPretraga.TextChanged += txtPretraga_TextChanged;
            // 
            // frmStudentiPretraga
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 359);
            Controls.Add(txtPretraga);
            Controls.Add(btnNoviStudent);
            Controls.Add(dgvStudenti);
            Name = "frmStudentiPretraga";
            Text = "Pretraga studenata";
            Load += frmStudentiPretraga_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStudenti).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvStudenti;
        private Button btnNoviStudent;
        private TextBox txtPretraga;
    }
}