namespace DLWMS26.WinApp
{
    partial class frmGlavna
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
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            odjavaToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            izlazToolStripMenuItem = new ToolStripMenuItem();
            igreToolStripMenuItem = new ToolStripMenuItem();
            xOToolStripMenuItem = new ToolStripMenuItem();
            pogađanjeRiječiToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            tslblPrijavljeniKorisnik = new ToolStripStatusLabel();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, igreToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { odjavaToolStripMenuItem, toolStripSeparator1, izlazToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // odjavaToolStripMenuItem
            // 
            odjavaToolStripMenuItem.Name = "odjavaToolStripMenuItem";
            odjavaToolStripMenuItem.Size = new Size(180, 22);
            odjavaToolStripMenuItem.Text = "Odjava";
            odjavaToolStripMenuItem.Click += odjavaToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(177, 6);
            // 
            // izlazToolStripMenuItem
            // 
            izlazToolStripMenuItem.Name = "izlazToolStripMenuItem";
            izlazToolStripMenuItem.Size = new Size(180, 22);
            izlazToolStripMenuItem.Text = "Izlaz";
            izlazToolStripMenuItem.Click += izlazToolStripMenuItem_Click;
            // 
            // igreToolStripMenuItem
            // 
            igreToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { xOToolStripMenuItem, pogađanjeRiječiToolStripMenuItem });
            igreToolStripMenuItem.Name = "igreToolStripMenuItem";
            igreToolStripMenuItem.Size = new Size(39, 20);
            igreToolStripMenuItem.Text = "Igre";
            // 
            // xOToolStripMenuItem
            // 
            xOToolStripMenuItem.Name = "xOToolStripMenuItem";
            xOToolStripMenuItem.Size = new Size(158, 22);
            xOToolStripMenuItem.Text = "XO";
            // 
            // pogađanjeRiječiToolStripMenuItem
            // 
            pogađanjeRiječiToolStripMenuItem.Name = "pogađanjeRiječiToolStripMenuItem";
            pogađanjeRiječiToolStripMenuItem.Size = new Size(158, 22);
            pogađanjeRiječiToolStripMenuItem.Text = "Pogađanje riječi";
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { tslblPrijavljeniKorisnik });
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // tslblPrijavljeniKorisnik
            // 
            tslblPrijavljeniKorisnik.Name = "tslblPrijavljeniKorisnik";
            tslblPrijavljeniKorisnik.Size = new Size(118, 17);
            tslblPrijavljeniKorisnik.Text = "toolStripStatusLabel1";
            // 
            // frmGlavna
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmGlavna";
            Text = "frmGlavna";
            WindowState = FormWindowState.Maximized;
            Load += frmGlavna_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem odjavaToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem izlazToolStripMenuItem;
        private ToolStripMenuItem igreToolStripMenuItem;
        private ToolStripMenuItem xOToolStripMenuItem;
        private ToolStripMenuItem pogađanjeRiječiToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel tslblPrijavljeniKorisnik;
    }
}