using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PassGenerator
{
    public partial class Form1 : Form
    {
        //Skapar en variabel för filnamnet som är null
        private string fileName = null;

        public int count = 0;

        private string tecken = "!&/()?<>";

        public Form1()
        {
            InitializeComponent();

            //Skapa scrollers till textboxen
            //txtboxlösen.ScrollBars = ScrollBars.Both; 
        }

        //Knapp för generera lösenord
        private void buttongenerate_Click(object sender, EventArgs e) 
        {
            //Om ensam checkad
            if (checknummer.Checked  && checkgemen.Checked == false && checktecken.Checked == false && checkversal.Checked == false)
            {
                //Skapa string för de tecken som används
                string minatecken = "1234567890";
                //Skapa random
                Random rnd = new Random();
                //For loop som loopar antalet gånger som ett lösenord ska skrivas
                for (int u = 0; u < passantal.Value; u++)
                {
                    //For loop som loopar antalet gånger som ett lösenord ska innehålla tecken
                    for (int i = 0; i < passlängd.Value; i++)
                    {
                        //Skapa int slumptal som beror på längden av de täcken som används
                        int slumptal = rnd.Next(minatecken.Length);
                        //Skapa string som gör om variabeln minatecken till en string
                        string slumptecken = minatecken[slumptal].ToString();
                        //Skriv ut slumtecken i textboxen
                        txtboxlösen.Text += (slumptecken);
                    }
                    txtboxlösen.Text += "\r\n";
                    

                }
            }
            if (checktecken.Checked && checkgemen.Checked == false && checknummer.Checked == false && checkversal.Checked == false)
            {
                string minatecken = tecken;
                Random rnd = new Random();
                for (int u = 0; u < passantal.Value; u++)
                {

                    for (int i = 0; i < passlängd.Value; i++)
                    {

                        int slumptal = rnd.Next(minatecken.Length);
                        string slumptecken = minatecken[slumptal].ToString();
                        txtboxlösen.Text += (slumptecken);
                    }
                    txtboxlösen.Text += "\r\n";

                }
            }
            if (checkversal.Checked && checkgemen.Checked == false && checknummer.Checked == false && checktecken.Checked == false)
            {
                string minatecken = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                Random rnd = new Random();
                for (int u = 0; u < passantal.Value; u++)
                {

                    for (int i = 0; i < passlängd.Value; i++)
                    {

                        int slumptal = rnd.Next(minatecken.Length);
                        string slumptecken = minatecken[slumptal].ToString();
                        txtboxlösen.Text += (slumptecken);
                    }
                    txtboxlösen.Text += "\r\n";

                }
            }
            if (checkgemen.Checked && checkversal.Checked == false && checknummer.Checked == false && checktecken.Checked == false)
            {
                string minatecken = "abcdefghijklmnopqrstuvwxyz";
                Random rnd = new Random();
                for (int u = 0; u < passantal.Value; u++)
                {

                    for (int i = 0; i < passlängd.Value; i++)
                    {

                        int slumptal = rnd.Next(minatecken.Length);
                        string slumptecken = minatecken[slumptal].ToString();
                        txtboxlösen.Text += (slumptecken);
                    }
                    txtboxlösen.Text += "\r\n";

                }
            }

            //Om två checkad
            if (checknummer.Checked && checkgemen.Checked && checktecken.Checked == false && checkversal.Checked == false)
            {
                string minatecken = "1234567890abcdefghijklmnopqrstuvwxyz";
                Random rnd = new Random();
                for (int u = 0; u < passantal.Value; u++)
                {

                    for (int i = 0; i < passlängd.Value; i++)
                    {

                        int slumptal = rnd.Next(minatecken.Length);
                        string slumptecken = minatecken[slumptal].ToString();
                        txtboxlösen.Text += (slumptecken);
                    }
                    txtboxlösen.Text += "\r\n";

                }
            }
            if (checknummer.Checked && checkversal.Checked && checktecken.Checked == false && checkgemen.Checked == false)
            {
                string minatecken = "1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                Random rnd = new Random();
                for (int u = 0; u < passantal.Value; u++)
                {

                    for (int i = 0; i < passlängd.Value; i++)
                    {

                        int slumptal = rnd.Next(minatecken.Length);
                        string slumptecken = minatecken[slumptal].ToString();
                        txtboxlösen.Text += (slumptecken);
                    }
                    txtboxlösen.Text += "\r\n";

                }
            }
            if (checknummer.Checked && checktecken.Checked && checkgemen.Checked == false && checkversal.Checked == false)
            {
                string minatecken = "1234567890" + tecken;
                Random rnd = new Random();
                for (int u = 0; u < passantal.Value; u++)
                {

                    for (int i = 0; i < passlängd.Value; i++)
                    {

                        int slumptal = rnd.Next(minatecken.Length);
                        string slumptecken = minatecken[slumptal].ToString();
                        txtboxlösen.Text += (slumptecken);
                    }
                    txtboxlösen.Text += "\r\n";

                }
            }
            if (checkgemen.Checked && checkversal.Checked && checktecken.Checked == false && checknummer.Checked == false)
            {
                string minatecken = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUWXYZ";
                Random rnd = new Random();
                for (int u = 0; u < passantal.Value; u++)
                {

                    for (int i = 0; i < passlängd.Value; i++)
                    {

                        int slumptal = rnd.Next(minatecken.Length);
                        string slumptecken = minatecken[slumptal].ToString();
                        txtboxlösen.Text += (slumptecken);
                    }
                    txtboxlösen.Text += "\r\n";

                }
            }
            if (checkgemen.Checked && checktecken.Checked && checknummer.Checked == false && checkversal.Checked == false)
            {
                string minatecken = "abcdefghijklmnopqrstuvwxyz" + tecken;
                Random rnd = new Random();
                for (int u = 0; u < passantal.Value; u++)
                {

                    for (int i = 0; i < passlängd.Value; i++)
                    {

                        int slumptal = rnd.Next(minatecken.Length);
                        string slumptecken = minatecken[slumptal].ToString();
                        txtboxlösen.Text += (slumptecken);
                    }
                    txtboxlösen.Text += "\r\n";

                }
            }
            if (checkversal.Checked && checktecken.Checked && checkgemen.Checked == false && checknummer.Checked == false)
            {
                string minatecken = "ABCDEFGHIJKLMNOPQRSTUVWXYZ" + tecken;
                Random rnd = new Random();
                for (int u = 0; u < passantal.Value; u++)
                {

                    for (int i = 0; i < passlängd.Value; i++)
                    {

                        int slumptal = rnd.Next(minatecken.Length);
                        string slumptecken = minatecken[slumptal].ToString();
                        txtboxlösen.Text += (slumptecken);
                    }
                    txtboxlösen.Text += "\r\n";

                }
            }

            //Om tre checkad
            if (checkgemen.Checked && checkversal.Checked && checktecken.Checked && checknummer.Checked == false)
            {
                string minatecken = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ" + tecken;
                Random rnd = new Random();
                for (int u = 0; u < passantal.Value; u++)
                {

                    for (int i = 0; i < passlängd.Value; i++)
                    {

                        int slumptal = rnd.Next(minatecken.Length);
                        string slumptecken = minatecken[slumptal].ToString();
                        txtboxlösen.Text += (slumptecken);
                    }
                    txtboxlösen.Text += "\r\n";

                }
            }
            if (checkgemen.Checked && checknummer.Checked && checktecken.Checked && checkversal.Checked == false)
            {
                string minatecken = "abcdefghijklmnopqrstuvwxyz1234567890" + tecken;
                Random rnd = new Random();
                for (int u = 0; u < passantal.Value; u++)
                {

                    for (int i = 0; i < passlängd.Value; i++)
                    {

                        int slumptal = rnd.Next(minatecken.Length);
                        string slumptecken = minatecken[slumptal].ToString();
                        txtboxlösen.Text += (slumptecken);
                    }
                    txtboxlösen.Text += "\r\n";

                }
            }
            if (checkgemen.Checked && checknummer.Checked && checkversal.Checked && checktecken.Checked == false)
            {
                string minatecken = "abcdefghijklmnopqrstuvwxyz1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                Random rnd = new Random();
                for (int u = 0; u < passantal.Value; u++)
                {

                    for (int i = 0; i < passlängd.Value; i++)
                    {

                        int slumptal = rnd.Next(minatecken.Length);
                        string slumptecken = minatecken[slumptal].ToString();
                        txtboxlösen.Text += (slumptecken);
                    }
                    txtboxlösen.Text += "\r\n";

                }
            }
            if (checkversal.Checked && checknummer.Checked && checktecken.Checked && checkgemen.Checked == false)
            {
                string minatecken = "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890" + tecken;
                Random rnd = new Random();
                for (int u = 0; u < passantal.Value; u++)
                {

                    for (int i = 0; i < passlängd.Value; i++)
                    {

                        int slumptal = rnd.Next(minatecken.Length);
                        string slumptecken = minatecken[slumptal].ToString();
                        txtboxlösen.Text += (slumptecken);
                    }
                    txtboxlösen.Text += "\r\n";

                }
            }


            //Om alla checkad
            if (checkgemen.Checked && checkversal.Checked && checktecken.Checked && checknummer.Checked)
            {
                string minatecken = "abcdefghijklmnopqrstuvwxyz1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZ" + tecken;
                Random myRnd = new Random();
                for (int u = 0; u < passantal.Value; u++)
                {

                    for (int i = 0; i < passlängd.Value; i++)
                    {

                        int slumptal = myRnd.Next(minatecken.Length);
                        string slumptecken = minatecken[slumptal].ToString();
                        txtboxlösen.Text += (slumptecken);
                    }
                    txtboxlösen.Text += "\r\n";

                }
            }
        }

        
        private void passantal_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void passlängd_ValueChanged(object sender, EventArgs e)
        {

        }

        //Knapp för rensning
        private void buttonclear_Click(object sender, EventArgs e)
        {
            txtboxlösen.Text = "";
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtboxlösen.Text = "";
        }

        //Knapp för avsluta
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(fileName))
            {
                if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    fileName = saveFileDialog1.FileName;
                
            else
                return;
            }
            File.WriteAllText(fileName, txtboxlösen.Text);
            MessageBox.Show("Your document has now been saved");
        }

        private void checkall_Click(object sender, EventArgs e)
        {
            count++;
            if (count % 2 == 0)
            {
                checkall.Text = "Uncheck all";
                checkgemen.Checked = true;
                checknummer.Checked = true;
                checktecken.Checked = true;
                checkversal.Checked = true;
            }
            else
                
            {
                checkall.Text = "Check all";
                checkgemen.Checked = false;
                checknummer.Checked = false;
                checktecken.Checked = false;
                checkversal.Checked = false;
            }
  
        }

        private void textboxsign_Click(object sender, EventArgs e)
        {
            tecken = textboxsign.Text;
        }

        private void defaultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tecken = "!&/()?<>";
            textboxsign.Text = "!&/()?<>";
        }

        private void showHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
