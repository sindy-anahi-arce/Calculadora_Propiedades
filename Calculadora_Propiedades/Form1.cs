using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_Propiedades
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            //Objeto
            Operaciones pSuma = new Operaciones();
            pSuma.Nume1 = float.Parse(txtNum1.Text);
            pSuma.Nume2 = float.Parse(txtNum2.Text);
            txtResult.Text = pSuma.suma().ToString();
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            //Objeto
            Operaciones pResta = new Operaciones();
            pResta.Nume1 = float.Parse(txtNum1.Text);
            pResta.Nume2 = float.Parse(txtNum2.Text);
            txtResult.Text = pResta.resta().ToString();
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            //Objeto
            Operaciones pMultip = new Operaciones();
            pMultip.Nume1 = float.Parse(txtNum1.Text);
            pMultip.Nume2 = float.Parse(txtNum2.Text);
            txtResult.Text = pMultip.multiplicacion().ToString();
        }

        private void btnDivi_Click(object sender, EventArgs e)
        {
            //Objeto
            Operaciones pDiv = new Operaciones();
            pDiv.Nume1 = float.Parse(txtNum1.Text);
            pDiv.Nume2 = float.Parse(txtNum2.Text);
            txtResult.Text = pDiv.division().ToString();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txtNum1.Clear();
            txtNum2.Clear();
            txtResult.Clear();
        }
    }
}
