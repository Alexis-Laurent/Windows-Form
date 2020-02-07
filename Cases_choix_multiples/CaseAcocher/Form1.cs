using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaseAcocher
{
    public partial class Form1 : Form
    {
               
        public Form1()
        {
            InitializeComponent();
        }
               

        //additionner
        private void button1_Click(object sender, EventArgs e)
        {
            int Resultat = 0;

            if (checkBox1.Checked == true)
            {
                Resultat = Resultat + 1;
            }
            if (checkBox2.Checked == true)
            {
                Resultat = Resultat + 2;
            }
            if (checkBox4.Checked == true)
            {
                Resultat = Resultat + 4;
            }
            if (checkBox8.Checked == true)
            {
                Resultat = Resultat + 8;
            }
            Resultat1.Text = Resultat.ToString();

        }


        //chiffres
        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                Resultat2.Text = "1";
            }
            else if (radioButton2.Checked)
            {
                Resultat2.Text = "2";
            }
            else if (radioButton3.Checked)
            {
                Resultat2.Text = "3";
            }
            else if (radioButton4.Checked)
            {
                Resultat2.Text = "4";
            }

        }


        //couleurs
        private void button3_Click(object sender, EventArgs e)
        {
            if(radioButtonRouge.Checked)
            {
                Resultat3.Text = radioButtonRouge.Text;
            }
            else if(radioButtonVert.Checked)
            {
                Resultat3.Text = radioButtonVert.Text;
            }
            else if(radioButtonBleu.Checked)
            {
                Resultat3.Text = radioButtonBleu.Text;
            }
            else if(radioButtonJaune.Checked)
            {
                Resultat3.Text = radioButtonJaune.Text;
            }

        }



        
        private void radioButton1_CheckedChanged(object sender, EventArgs e) {}
        private void Form1_Load(object sender, EventArgs e) {}
    }
}
