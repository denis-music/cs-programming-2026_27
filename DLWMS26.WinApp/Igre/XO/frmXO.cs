using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DLWMS26.WinApp.Igre.XO
{
    public partial class frmXO : Form
    {
        public frmXO()
        {
            InitializeComponent();
        }

        public int Brojac { get; set; }

        private void NapraviPotez(object sender)
        {
            if (sender is Button button && button.Text == "")
            {
                button.Text = (Brojac % 2 == 0) ? "X" : "O";

                if (KrajIgre())
                    PostaviStanje(false);

                Brojac++;
            }
        }

        private bool KrajIgre()
        {
            return ProvjeriRedove() || ProvjeriKolone() || ProvjeriDijagonale();
        }

        private bool ProvjeriDijagonale()
        {
            return ProvjeriPobjedu(button1, button5, button9) || ProvjeriPobjedu(button3, button5, button7);
        }

        private bool ProvjeriKolone()
        {
            return ProvjeriPobjedu(button1, button4, button7) ||
                   ProvjeriPobjedu(button2, button5, button8) ||
                   ProvjeriPobjedu(button3, button6, button9);
        }

        private bool ProvjeriRedove()
        {
            return ProvjeriPobjedu(button1, button2, button3) ||
                   ProvjeriPobjedu(button4, button5, button6) ||
                   ProvjeriPobjedu(button7, button8, button9);
        }

        private bool ProvjeriPobjedu(Button prviDugmic, Button drugiDugmic, Button treciDugmic)
        {
            if (prviDugmic.Text != "" && prviDugmic.Text == drugiDugmic.Text && drugiDugmic.Text == treciDugmic.Text)
            {
                prviDugmic.BackColor = drugiDugmic.BackColor = treciDugmic.BackColor = Color.Green;
                return true;
            }
            return false;
        }

        private void PostaviStanje(bool omoguci = true, bool resetTeksta = false, bool resetBoje = false)
        {
            foreach (var control in Controls)
            {
                if (control is Button button)
                {
                    button.Enabled = omoguci;
                    if (resetTeksta)
                        button.Text = "";
                    if (resetBoje)
                        button.UseVisualStyleBackColor = true;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NapraviPotez(sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NapraviPotez(sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NapraviPotez(sender);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            NapraviPotez(sender);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            NapraviPotez(sender);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            NapraviPotez(sender);

        }

        private void button7_Click(object sender, EventArgs e)
        {
            NapraviPotez(sender);

        }

        private void button8_Click(object sender, EventArgs e)
        {
            NapraviPotez(sender);

        }

        private void button9_Click(object sender, EventArgs e)
        {
            NapraviPotez(sender);

        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {

        }

        private void izlazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void novaIgraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetujIgru();
        }

        private void ResetujIgru()
        {
            Brojac = 0;
            PostaviStanje(true, true, true);
        }
    }
}
