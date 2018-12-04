using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektArbetet
{
    public partial class Form1 : Form
    {
        double Resultat = 0;
        string Operations = "";
        bool OperationGjord = false;

        public Form1()
        {
            InitializeComponent();
        }


        private void Btn_Click(object sender, EventArgs e)
        {
            if ((NrBox.Text == "0")||(OperationGjord))
                NrBox.Clear();

            OperationGjord = false;
            Button BtnNr = (Button)sender;
            if (BtnNr.Text==".")
            {
                if(!NrBox.Text.Contains("."))
                    NrBox.Text = NrBox.Text + BtnNr.Text;
            }else
            NrBox.Text = NrBox.Text + BtnNr.Text;
            
        }


        private void OperatorClick(object sender, EventArgs e)
        {
            Button BtnOp = (Button)sender;

            if (Resultat != 0)
            {
                BtnEqual.PerformClick();
                Operations = BtnOp.Text;
                LabelUtr.Text = Resultat + " " + Operations;
                OperationGjord = true;
            }
            else
            {
                Operations = BtnOp.Text;
                Resultat = Double.Parse(NrBox.Text);
                LabelUtr.Text = Resultat + " " + Operations;
                OperationGjord = true;
            }
        }

        private void BtnClearE_Click(object sender, EventArgs e)
        {
            NrBox.Text = "0";
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            NrBox.Text = "0";
            Resultat = 0;
        }

        private void BtnEquals(object sender, EventArgs e)
        {
            switch (Operations)
            {
                case "+":
                    NrBox.Text = (Resultat + Double.Parse(NrBox.Text)).ToString();
                    break;

                case "-":
                    NrBox.Text = (Resultat - Double.Parse(NrBox.Text)).ToString();
                    break;

                case "/":
                    NrBox.Text = (Resultat / Double.Parse(NrBox.Text)).ToString();
                    break;

                case "x":
                    NrBox.Text = (Resultat * Double.Parse(NrBox.Text)).ToString();
                    break;

                default:
                    break;
            }
            Resultat = Double.Parse(NrBox.Text);
            LabelUtr.Text = "";
        }
    }
}
