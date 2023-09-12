using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class formRichtexBox : Form
    {
        public formRichtexBox()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            rchMiDoc.SelectionFont = new System.Drawing.Font("Arial", rchMiDoc.SelectionFont.Size, rchMiDoc.SelectionFont.Style);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Nombre_Click(object sender, EventArgs e)
        {

        }

        private void btnDefult_Click(object sender, EventArgs e)
        {

        }

        private void btnTimes_Click(object sender, EventArgs e)
        {
            rchMiDoc.SelectionFont = new System.Drawing.Font("Time New Roman", rchMiDoc.SelectionFont.Size, rchMiDoc.SelectionFont.Style);
        }

        private void btnTam10_Click(object sender, EventArgs e)
        {
            rchMiDoc.SelectionFont = new Font (rchMiDoc.SelectionFont.FontFamily, 10, rchMiDoc.SelectionFont.Style);
        }

        private void btnTam14_Click(object sender, EventArgs e)
        {
            rchMiDoc.SelectionFont = new Font(rchMiDoc.SelectionFont.FontFamily, 14, rchMiDoc.SelectionFont.Style);
        }

        private void btnNegrita_Click(object sender, EventArgs e)
        {
            rchMiDoc.SelectionFont = new Font(rchMiDoc.SelectionFont.FontFamily, rchMiDoc.SelectionFont.Size, FontStyle.Bold);
        }

        private void btnCursiva_Click(object sender, EventArgs e)
        {
            rchMiDoc.SelectionFont = new Font(rchMiDoc.SelectionFont.FontFamily, rchMiDoc.SelectionFont.Size, FontStyle.Italic);
        }

        private void btnColorRojo_Click(object sender, EventArgs e)
        {
            rchMiDoc.SelectionColor=Color.Red;
        }

        private void btnColorAmarillo_Click(object sender, EventArgs e)
        {
            rchMiDoc.SelectionColor = Color.Yellow;
        }

        private void btnFonodoAzul_Click(object sender, EventArgs e)
        {
            rchMiDoc.SelectionBackColor=Color.Blue ;
        }

        private void btnFondoNaranja_Click(object sender, EventArgs e)
        {
            rchMiDoc.SelectionBackColor = Color.Orange;
        }
    }
}
