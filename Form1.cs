using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zmem
{
    public partial class Form1 : Form
    {
        public string path="";
        public Form1()
        {
            InitializeComponent();
        }

        private void enregistrerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (path == "") { 
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.Filter = "ficher zeme|*.zmm";
            savefile.Title = "enregistre le fichier Zmem";
            savefile.ShowDialog();
            path = savefile.FileName;
            }           
            //TextArea.Text = savefile.FileName;
            if(path !="")
            System.IO.File.WriteAllText(path , TextArea.Text);
            path = "";
            //TextArea.Text = "";
        }

        private void ouvrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "ficher zeme|*.zmm";
            open.ShowDialog();
            path = open.FileName;
            if(path !="")
            TextArea.Text = System.IO.File.ReadAllText(open.FileName);
        }

        private void fererToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void copierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextArea.Copy();
        }

        private void collerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextArea.Paste();
        }

        private void couperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextArea.Cut();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            TextArea.Text="";
            path = "";
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            if (!TextArea.SelectionFont.Bold)
                TextArea.Font = new Font(TextArea.Font, FontStyle.Bold);
            else
                TextArea.Font = new Font(TextArea.Font);



        }
    }
}
